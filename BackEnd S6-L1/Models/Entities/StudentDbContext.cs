using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace BackEnd_S6_L1.Models.Entities
{
    public class StudentDbContext : IdentityDbContext<IdentityUser> //CONNESSIONE AL DB PER IDENTITY
    {
        public DbSet<ApplicationUser> AspNetUsers { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
