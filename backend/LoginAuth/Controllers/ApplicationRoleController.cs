using System.Linq;
using System.Threading.Tasks;
using LoginAuth.Models;
using LoginAuth.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginAuth.Controllers
{
    [Route("User/[action]")]
    public class ApplicationRoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public ApplicationRoleController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }


        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(ApplicationRoleCreateRoleViewModel viewModel)
        {
            var roleExists = await _roleManager.RoleExistsAsync(viewModel.Name);
            if (!roleExists)
            {
                ModelState.AddModelError("UsedName",
                    "There is already a role whose name is the same as the given name.");
                return View(viewModel);
            }

            var result = await _roleManager.CreateAsync(new ApplicationRole() {Name = viewModel.Name});
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");    
            return View(viewModel);
        }

        public IActionResult ListRoles()
        {
            // list all of the roles available in the system.
            
            return View(_roleManager.Roles.ToList());
        }
        
        [Route("/{id}")]
        public async Task<IActionResult> UpdateRole(string id)
        {
            ApplicationRoleUpdateRoleViewModel role = await _roleManager.FindByIdAsync(id);
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(ApplicationRoleUpdateRoleViewModel viewModel)
        {
            var role = await _roleManager.FindByIdAsync(viewModel.Id);
            role.Name = viewModel.Name;
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            return View(viewModel);
        }


        public async Task<IActionResult> DeleteRole(string id)
        {
            ApplicationRoleUpdateRoleViewModel role = await _roleManager.FindByIdAsync(id);
            return View(role);
        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteRole(ApplicationRoleUpdateRoleViewModel viewModel)
        {
            var role = await _roleManager.FindByIdAsync(viewModel.Id);
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
        
    }
}