using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAdminRepository : IAsyncRepository<AdminModel>
{
    Task<AdminModel?> GetByEmailAsync(string email);
    Task<IReadOnlyList<AdminModel>> GetDeletedAsync();
}