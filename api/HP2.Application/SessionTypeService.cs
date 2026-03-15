using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class SessionTypeService : ISessionTypeService
{
    private readonly ISessionTypeRepository _sessionTypeRepository;

    public SessionTypeService(ISessionTypeRepository sessionTypeRepository)
    {
        _sessionTypeRepository = sessionTypeRepository;
    }

    public async Task<IEnumerable<SessionTypeModel>> GetAllSessionTypesAsync()
    {
        return await _sessionTypeRepository.GetAllAsync();
    }

    public async Task<SessionTypeModel?> GetSessionTypeByIdAsync(string id)
    {
        return await _sessionTypeRepository.GetByIdAsync(id);
    }

    public async Task<SessionTypeModel> CreateSessionTypeAsync(SessionTypeModel sessionType)
    {
        return await _sessionTypeRepository.AddAsync(sessionType);
    }

    public async Task UpdateSessionTypeAsync(SessionTypeModel sessionType)
    {
        await _sessionTypeRepository.UpdateAsync(sessionType);
    }

    public async Task DeleteSessionTypeAsync(string id)
    {
        await _sessionTypeRepository.DeleteAsync(id);
    }
}
