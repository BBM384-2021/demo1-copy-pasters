using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationUserUpdatePasswordViewModel
    {
        [Display(Name = "New Password")]
        [Required(ErrorMessage = "Please fill in the new password field.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}