using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationUserDetailViewModel
    {
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        public static implicit operator ApplicationUserDetailViewModel(ApplicationUser user)
        {
            return new ApplicationUserDetailViewModel()
            {
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}