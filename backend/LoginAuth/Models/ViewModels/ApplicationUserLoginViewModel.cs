using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationUserLoginViewModel
    {
        [Required(ErrorMessage = "Email cannot be left empty.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password field cannot be left empty.")]
        [DataType(DataType.Password, ErrorMessage = "Please enter a valid password.")]
        public string Password { get; set; }
        
        public bool Persistent { get; set; }    
        
        public bool Lock { get; set; }
    }
}