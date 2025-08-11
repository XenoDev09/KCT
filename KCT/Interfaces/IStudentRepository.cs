using KCT.Models;

namespace KCT.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(int id);
        Task<int> AddAsync(Student student);
        Task<int> UpdateAsync(Student student);
        Task<int> DeleteAsync(int id);
    }
}
