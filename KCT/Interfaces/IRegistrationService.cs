using KCT.Models;

namespace KCT.Interfaces
{
    public interface IRegistrationService
    {
        Task<IEnumerable<Registration>> GetAllRegistrationsAsync();

        Task<Registration> GetRegistrationByIdAsync(int id);

        Task<int> AddRegistrationAsync(Registration registration);

        Task<int> UpdateRegistrationAsync(Registration registration);

        Task<int> DeleteRegistrationAsync(int id);

    }
}
