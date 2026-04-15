using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.EntityFrameworkCore;
using HP2.Application.Exceptions;

namespace HP2.Application;

public class ProgramService : IProgramService
{
    private readonly IProgramRepository _programRepository;

    public ProgramService(IProgramRepository programRepository)
    {
        _programRepository = programRepository;
    }

    public async Task<ProgramModel> CreateProgramAsync(ProgramModel program)
    {
        return await _programRepository.AddAsync(program);
    }

    public async Task<ProgramModel?> GetProgramByIdAsync(string id)
    {
        return await _programRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<ProgramModel>> GetAllProgramsAsync()
    {
        return await _programRepository.GetAllAsync();
    }

    public async Task UpdateProgramAsync(ProgramModel program)
    {
        await _programRepository.UpdateAsync(program);
    }

    public async Task DeleteProgramAsync(string id)
    {
            await _programRepository.DeleteAsync(id);
    }
}
