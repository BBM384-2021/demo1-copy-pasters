using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationUserEditPasswordViewModel
    {
        [Required(ErrorMessage = "You must provide the previous password to change the password")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        
        [Required(ErrorMessage = "The fields must be the same.")]
        [DataType(DataType.Password)]
        [Compare(nameof(OldPassword))]
        public string ConfirmOldPassword { get; set; }

        [Required(ErrorMessage = "New password field cannot be left empty.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}