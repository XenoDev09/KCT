using KCT.Models;

namespace KCT.Interfaces
{
    public interface IRegistrationRepository
    {
        Task<IEnumerable<Registration>> GetAllAsync();
        Task<Registration> GetByIdAsync(int id);
        Task<int> AddAsync(Registration registration);
        Task<int> UpdateAsync(Registration registration);
        Task<int> DeleteAsync(int id);
    }
}
