using Microsoft.EntityFrameworkCore;
namespace BackEnd_S6_L1.Models.Entities
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
