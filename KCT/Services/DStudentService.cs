using KCT.Interfaces;
using KCT.Models;

namespace KCT.Services
{
    public class DStudentService
    {
        private readonly IStudentRepository _repo;

        public DStudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<StudentViewModel>> GetAllStudents() => await _repo.GetAllAsync();

        public async Task<StudentViewModel> GetStudent(int id) => await _repo.GetByIdAsync(id);

        public async Task AddStudent(StudentViewModel student) => await _repo.AddAsync(student);

        public async Task UpdateStudent(StudentViewModel student) => await _repo.UpdateAsync(student);

        public async Task DeleteStudent(int id) => await _repo.DeleteAsync(id);
    }
}
