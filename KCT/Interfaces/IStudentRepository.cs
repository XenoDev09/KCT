using KCT.Models;

namespace KCT.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<StudentViewModel>> GetAllAsync();
        Task<StudentViewModel> GetByIdAsync(int id);
        Task<int> AddAsync(StudentViewModel student);
        Task<int> UpdateAsync(StudentViewModel student);
        Task<int> DeleteAsync(int id);
    }
}
