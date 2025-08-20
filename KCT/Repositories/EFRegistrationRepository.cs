using KCT.Data;
using KCT.Interfaces;
using KCT.Models;
using Microsoft.EntityFrameworkCore;

namespace KCT.Repositories
{
    public class EFRegistrationRepository : IRegistrationRepository
    {
        private readonly KCTContext _kCTContext;

        public EFRegistrationRepository(KCTContext kCTContext)
        {
            _kCTContext = kCTContext;
        }
        public async Task<IEnumerable<Registration>> GetAllAsync()
        {
            return await _kCTContext.Registrations.ToListAsync();
        }

        public async Task<Registration> GetByIdAsync(int id)
        {
            return await _kCTContext.Registrations.FindAsync(id);
        }

        public async Task<int> AddAsync(Registration registration)
        {
            await _kCTContext.Registrations.AddAsync(registration);
            return await _kCTContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Registration registration)
        {
            _kCTContext.Registrations.Update(registration);
            return await _kCTContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var registration = await _kCTContext.Registrations.FindAsync(id);
            if (registration == null)
                return 0;

            _kCTContext.Registrations.Remove(registration);
            return await _kCTContext.SaveChangesAsync();
        }
    }
}
