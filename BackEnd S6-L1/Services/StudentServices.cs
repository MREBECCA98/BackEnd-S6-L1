using BackEnd_S6_L1.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace BackEnd_S6_L1.Services
{
    public class StudentServices
    {
        private readonly StudentDbContext _context;

        public StudentServices(StudentDbContext context)
        {
            _context = context;
        }


        //GET ALL STUDENTS
        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        //GET BY ID
        public async Task<Student> GetStudentByIdAsync(Guid id)
        {
            return await _context.Students.FindAsync(id);
        }

        //CREATE STUDENT
        public async Task<bool> CreateAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            return await _context.SaveChangesAsync() > 0;

        }
    }
}
