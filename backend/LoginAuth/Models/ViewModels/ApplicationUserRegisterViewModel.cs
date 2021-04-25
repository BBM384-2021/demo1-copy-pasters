using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationUserRegisterViewModel
    {
        [Required(ErrorMessage = "Username field cannot be left empty.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email field cannot be left empty.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password field cannot be left empty.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please be sure that passwords match.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        
        public static implicit operator ApplicationUser(ApplicationUserRegisterViewModel viewModel)
        {
            return new ApplicationUser()
            {
                Email = viewModel.Email,
                UserName = viewModel.UserName
            };
        }
    }
}