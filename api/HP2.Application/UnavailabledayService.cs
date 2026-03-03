using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application
{
    public class UnavailabledayService : IUnavailabledayService
    {
        private readonly IUnavailabledayRepository _unavailabledayRepository;

        public UnavailabledayService(IUnavailabledayRepository unavailabledayRepository)
        {
            _unavailabledayRepository = unavailabledayRepository;
        }

        public async Task<UnavailableDayModel> CreateUnavailabledayAsync(UnavailableDayModel unavailableday)
        {


            return await _unavailabledayRepository.AddAsync(unavailableday);
        }

        public async Task<UnavailableDayModel?> GetUnavailabledayByIdAsync(string id)
        {
            return await _unavailabledayRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<UnavailableDayModel>> GetAllUnavailabledaysAsync()
        {
            return await _unavailabledayRepository.GetAllAsync();
        }

        public async Task UpdateUnavailabledayAsync(UnavailableDayModel unavailableday)
        {
            await _unavailabledayRepository.UpdateAsync(unavailableday);
        }

        public async Task DeleteUnavailabledayAsync(string id)
        {
            await _unavailabledayRepository.DeleteAsync(id);
        }
    }
}