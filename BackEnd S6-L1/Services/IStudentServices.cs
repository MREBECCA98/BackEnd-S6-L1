using BackEnd_S6_L1.Models.Entities;

namespace BackEnd_S6_L1.Services
{
    public interface IStudentServices
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentByIdAsync(Guid id);
        Task<bool> CreateAsync(Student student);
        Task<bool> UpdateAsync(Student student);
        Task<bool> DeleteAsync(Student student);
    }
}
