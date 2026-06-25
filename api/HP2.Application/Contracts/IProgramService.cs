using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IProgramService
{
    Task<ProgramModel> CreateProgramAsync(ProgramModel program);
    Task<IEnumerable<ProgramModel>> GetAllProgramsAsync();
    Task<IEnumerable<ProgramModel>> GetFilteredProgramsAsync(string? name, string? field);
    Task<ProgramModel?> GetProgramByIdAsync(string id);
    Task UpdateProgramAsync(ProgramModel program);
    Task DeleteProgramAsync(string id);
}
