using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionTypeRepository
{
    Task<IEnumerable<SessionTypeModel>> GetAllAsync();
    Task<SessionTypeModel?> GetByIdAsync(string id);
    Task<SessionTypeModel> AddAsync(SessionTypeModel sessionType);
    Task UpdateAsync(SessionTypeModel sessionType);
    Task DeleteAsync(string id);
}
