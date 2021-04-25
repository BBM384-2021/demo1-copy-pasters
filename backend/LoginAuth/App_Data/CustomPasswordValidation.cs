using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAuth.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginAuth.App_Data
{
    public class CustomPasswordValidation : IPasswordValidator<ApplicationUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user,
            string password)
        {
            var errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.UserName.ToLower()))
                errors.Add(new IdentityError()
                {
                    Code = "PasswordContainsUserName",
                    Description = "Password should not contain username within it."
                });

            return Task.FromResult(!errors.Any() ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}