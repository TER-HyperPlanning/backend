using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IProgramRepository : IAsyncRepository<ProgramModel>
{
    Task<IEnumerable<ProgramModel>> GetFilteredAsync(string? name, string? field);
}
