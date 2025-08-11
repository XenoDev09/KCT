using KCT.Data;
using KCT.Interfaces;
using KCT.Models;
using Microsoft.EntityFrameworkCore;

namespace KCT.Repositories
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly KCTContext _kCTContext;

        public EFStudentRepository(KCTContext kCTContext)
        {
            _kCTContext = kCTContext;
        }
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _kCTContext.Students.ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _kCTContext.Students.FindAsync(id);
        }

        public async Task<int> AddAsync(Student student)
        {
            await _kCTContext.Students.AddAsync(student);
            return await _kCTContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Student student)
        {
            _kCTContext.Students.Update(student);
            return await _kCTContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var student = await _kCTContext.Students.FindAsync(id);
            if (student == null)
                return 0;

            _kCTContext.Students.Remove(student);
            return await _kCTContext.SaveChangesAsync();
        }
    }
}
