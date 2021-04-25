using Microsoft.AspNetCore.Identity;

namespace LoginAuth.App_Data
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        // public override IdentityError DuplicateUserName(string userName) => new IdentityError { Code = "DuplicateUserName", Description = "Custom" };
        // public override IdentityError InvalidUserName(string userName) => new IdentityError { Code = "InvalidUserName", Description = "Custom" };
        // public override IdentityError DuplicateEmail(string email) => new IdentityError { Code = "DuplicateEmail", Description = "Custom" };
        // public override IdentityError InvalidEmail(string email) => new IdentityError { Code = "InvalidEmail", Description = "Custom" };
    }
}