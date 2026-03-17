using HP2.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface ISessionRepository
    {
        Task<IEnumerable<SessionModel>> GetAllAsync();
        Task<SessionModel?> GetByIdAsync(string id);
        Task<SessionModel> AddAsync(SessionModel model);
        Task<SessionModel?> UpdateAsync(SessionModel model);
        Task<bool> DeleteAsync(string id);
    }
}