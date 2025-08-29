using KCT.Interfaces;
using KCT.Models;

namespace KCT.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public async Task<IEnumerable<Registration>> GetAllRegistrationsAsync()
        {
            return await _registrationRepository.GetAllAsync();
        }

        public async Task<Registration> GetRegistrationByIdAsync(int id)
        {
            return await _registrationRepository.GetByIdAsync(id);
        }

        public async Task<int> AddRegistrationAsync(Registration registration)
        {
            // You can add business logic or validation here before adding
            return await _registrationRepository.AddAsync(registration);
        }

        public async Task<int> UpdateRegistrationAsync(Registration registration)
        {
            // You can add business logic or validation here before updating
            return await _registrationRepository.UpdateAsync(registration);
        }

        public async Task<int> DeleteRegistrationAsync(int id)
        {
            // You can add business logic or validation here before deleting
            return await _registrationRepository.DeleteAsync(id);
        }

    }
}
