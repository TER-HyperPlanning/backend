using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IGroupRepository : IAsyncRepository<GroupModel>
{
    Task<GroupModel?> GetByNameAsync(string name);
}