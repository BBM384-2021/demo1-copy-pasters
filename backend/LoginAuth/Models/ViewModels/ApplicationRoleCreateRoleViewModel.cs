using System.ComponentModel.DataAnnotations;

namespace LoginAuth.Models.ViewModels
{
    public class ApplicationRoleCreateRoleViewModel
    {
        [Required(ErrorMessage = "Name field of a role cannot be left empty.")]
        public string Name { get; set; }
    }
}