using LoginAuth.Models;
using LoginAuth.Models.ClubModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        
        public DbSet<Club> Clubs { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<SubClub> SubClubs { get; set; }
        
    }
}