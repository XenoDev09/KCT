using KCT.Interfaces;
using KCT.Models;

namespace KCT.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }

        public async Task<int> AddStudentAsync(Student student)
        {
            // You can add business logic or validation here before adding
            return await _studentRepository.AddAsync(student);
        }

        public async Task<int> UpdateStudentAsync(Student student)
        {
            // You can add business logic or validation here before updating
            return await _studentRepository.UpdateAsync(student);
        }

        public async Task<int> DeleteStudentAsync(int id)
        {
            // You can add business logic or validation here before deleting
            return await _studentRepository.DeleteAsync(id);
        }

    }
}
