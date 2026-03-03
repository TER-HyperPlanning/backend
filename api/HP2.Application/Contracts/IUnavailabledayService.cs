using HP2.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface IUnavailabledayService
    {
        Task<UnavailableDayModel> CreateUnavailabledayAsync(UnavailableDayModel unavailableday);
        Task<IEnumerable<UnavailableDayModel>> GetAllUnavailabledaysAsync();
        Task<UnavailableDayModel?> GetUnavailabledayByIdAsync(string id);
        Task UpdateUnavailabledayAsync(UnavailableDayModel unavailableday);
        Task DeleteUnavailabledayAsync(string id);
    }
}