using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using LoginAuth.App_Data;
using LoginAuth.Models;
using LoginAuth.Models.ViewModels;
using LoginAuth.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace LoginAuth.Controllers
{
    [Route("User/[action]")]
    public class ApplicationUserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly SimpleMailTransferProtocol _smtp;
        private readonly CustomMailMessage _cmm;

        public ApplicationUserController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, SimpleMailTransferProtocol smtp,
            CustomMailMessage cmm)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _smtp = smtp;
            _cmm = cmm;
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUserRegisterViewModel viewModel)
        {
            //;
            if (!ModelState.IsValid) return View(viewModel);
            ApplicationUser user = viewModel;
            //user.Id = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(user, viewModel.Password);

            if (result.Succeeded)
                return RedirectToAction("Login");

            result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));

            return View(viewModel);
        }


        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(ApplicationUserLoginViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);
            var user = await _userManager.FindByEmailAsync(viewModel.Email);
            if (user != null)
            {
                await _signInManager.SignOutAsync();
                var result = await _signInManager.PasswordSignInAsync(user, viewModel.Password,
                    viewModel.Persistent, viewModel.Lock);

                if (!result.Succeeded)
                {
                    await _userManager.AccessFailedAsync(user);
                    var failCount = await _userManager.GetAccessFailedCountAsync(user);
                    var maximumAttempt = 3;
                    if (failCount == maximumAttempt)
                    {
                        await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(1)));
                        ModelState.AddModelError("Locked", "Your login attempt number has exceeded the boundary.");
                    }

                    else if (result.IsLockedOut)
                        ModelState.AddModelError("Locked",
                            "Because successive failed attempts, the account has been suspended.");

                    return View(viewModel);
                }

                await _userManager.ResetAccessFailedCountAsync(user);

                return TempData["returnUrl"].ToString() == null
                    ? RedirectToAction("Index", "Home")
                    : RedirectToAction(TempData["returnUrl"].ToString());
            }

            ModelState.AddModelError("NotUser", "There is no user registered with that email.");
            ModelState.AddModelError("NotUser2", "Given email or password is not valid.");
            return View(viewModel);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ApplicationUserResetPasswordViewModel viewModel)
        {
            var user = await _userManager.FindByEmailAsync(viewModel.Email);
            if (user != null)
            {
                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                _cmm.To.Add(user.Email);
                _smtp.Send(_cmm);
                ViewBag.State = true;
            }
            else
                ViewBag.State = false;

            return View();
        }

        [HttpGet("{userId}/{token}")]
        public IActionResult UpdatePassword()
        {
            return View();
        }

        [HttpPost("{userId}/{token}")]
        public async Task<IActionResult> UpdatePassword(ApplicationUserUpdatePasswordViewModel viewModel, string userId,
            string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var result = await _userManager.ResetPasswordAsync(user, HttpUtility.UrlDecode(token), viewModel.Password);
            if (result.Succeeded)
            {
                ViewBag.State = true;
                await _userManager.UpdateSecurityStampAsync(user);
            }
            else
                ViewBag.State = false;

            return View();
        }


        public async Task<IActionResult> EditProfile()
        {
            ApplicationUserDetailViewModel viewModel = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(viewModel);
        }
        

        [HttpPost]
        public async Task<IActionResult> EditProfile(ApplicationUserDetailViewModel viewModel)
        {
            if (ModelState.IsValid && User.Identity != null)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.PhoneNumber = viewModel.PhoneNumber;
                IdentityResult result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                    return View(viewModel);
                }
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, true);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult EditPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditPassword(ApplicationUserEditPasswordViewModel viewModel)
        {
            if (ModelState.IsValid  && User.Identity != null)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (await _userManager.CheckPasswordAsync(user, viewModel.OldPassword))
                {
                    var result = await _userManager.ChangePasswordAsync(user, viewModel.OldPassword, viewModel.NewPassword);
                    if (!result.Succeeded)
                    {
                        result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                        return View();
                    }
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, true);
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}