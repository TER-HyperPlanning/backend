using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionTypeService
{
    Task<IEnumerable<SessionTypeModel>> GetAllSessionTypesAsync();
    Task<SessionTypeModel?> GetSessionTypeByIdAsync(string id);
    Task<SessionTypeModel> CreateSessionTypeAsync(SessionTypeModel sessionType);
    Task UpdateSessionTypeAsync(SessionTypeModel sessionType);
    Task DeleteSessionTypeAsync(string id);
}
