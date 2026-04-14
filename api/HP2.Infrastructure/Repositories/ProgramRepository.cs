using System;
using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class ProgramRepository : RepositoryBase<ProgramModel>, IProgramRepository
{
    public ProgramRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<ProgramModel>> GetAllAsync()
    {
        var programs = await _dbContext.Programs.AsNoTracking().ToListAsync();
        return _mapper.Map<List<ProgramModel>>(programs);
    }

    public async Task<IReadOnlyList<ProgramModel>> GetDeletedAsync()
    {
        var programs = await _dbContext.Programs
            .IgnoreQueryFilters()
            .AsNoTracking()
            .Where(p => p.IsDeleted)
            .ToListAsync();

        return _mapper.Map<List<ProgramModel>>(programs);
    }

    public override async Task<ProgramModel?> GetByIdAsync(string id)
    {
        var program = await _dbContext.Programs.AsNoTracking()
            .FirstOrDefaultAsync(p => p.ProgramId == id);

        return program != null ? _mapper.Map<ProgramModel>(program) : null;
    }

    public override async Task<ProgramModel> AddAsync(ProgramModel programModel)
    {
        var entity = _mapper.Map<Program>(programModel);

        if (string.IsNullOrWhiteSpace(entity.ProgramId))
        {
            entity.ProgramId = Guid.NewGuid().ToString();
        }

        entity.IsDeleted = false;
        entity.DeletedAt = null;

        await _dbContext.Programs.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        programModel.Id = entity.ProgramId;
        programModel.IsDeleted = entity.IsDeleted;
        programModel.DeletedAt = entity.DeletedAt;
        return programModel;
    }

    public override async Task UpdateAsync(ProgramModel programModel)
    {
        var program = await _dbContext.Programs
            .FirstOrDefaultAsync(p => p.ProgramId == programModel.Id);

        if (program == null) return;

        program.Name = programModel.Name;
        program.Field = programModel.Field;
        program.IsDeleted = programModel.IsDeleted;
        program.DeletedAt = programModel.DeletedAt;

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        await base.DeleteAsync(id);
    }
}
