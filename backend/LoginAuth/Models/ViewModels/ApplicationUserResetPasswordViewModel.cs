using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationUserResetPasswordViewModel
    {
        [Required(ErrorMessage = "Please enter the e-mail address of the account whose password to be reset.")]
        public string Email { get; set; }
    }
}