namespace LoginAuth.Models.ViewModels
{
    public class ApplicationRoleUpdateRoleViewModel
    {
        public string Name { get; set; }
        
        public string Id { get; set; }

        public static implicit operator ApplicationRoleUpdateRoleViewModel(ApplicationRole role)
        {
            return new ApplicationRoleUpdateRoleViewModel()
            {
                Name = role.Name,
                Id = role.Id
            };
        }
    }
}