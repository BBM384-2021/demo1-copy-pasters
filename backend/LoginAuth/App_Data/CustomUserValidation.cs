using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAuth.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginAuth.App_Data
{
    public class CustomUserValidation : IUserValidator<ApplicationUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            var errors = new List<IdentityError>();

            if (int.TryParse(user.UserName[0].ToString(), out int _))
                errors.Add(new IdentityError
                    {Code = "UserNameNumberStartWith", Description = "Username cannot start with numerical character."});
            if (user.UserName.Length < 3 && user.UserName.Length > 25)
                errors.Add(new IdentityError
                    {Code = "UserNameLength", Description = "Username must be between the length of 3 and 25."});
            if (user.Email.Length > 70)
                errors.Add(new IdentityError
                    {Code = "EmailLength", Description = "Email cannot exceed the length of 70 characters."});

            return Task.FromResult(!errors.Any() ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}