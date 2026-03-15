using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class SessionTypeRepository : RepositoryBase<SessionTypeModel>, ISessionTypeRepository
{
    public SessionTypeRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public async Task<IEnumerable<SessionTypeModel>> GetAllAsync()
    {
        var sessionTypes = await _dbContext.SessionTypes.AsNoTracking().ToListAsync();
        return _mapper.Map<List<SessionTypeModel>>(sessionTypes);
    }

    public async Task<SessionTypeModel?> GetByIdAsync(string id)
    {
        var sessionType = await _dbContext.SessionTypes.AsNoTracking()
            .FirstOrDefaultAsync(s => s.SessionTypeId == id);
        return sessionType != null ? _mapper.Map<SessionTypeModel>(sessionType) : null;
    }

    public async Task<SessionTypeModel> AddAsync(SessionTypeModel sessionTypeModel)
    {
        if (await _dbContext.SessionTypes.AnyAsync(s => s.Label == sessionTypeModel.Label))
            throw new InvalidOperationException($"Un SessionType nommé '{sessionTypeModel.Label}' existe déjà.");

        var entity = new SessionType
        {
            SessionTypeId = Guid.NewGuid().ToString(),
            Label = sessionTypeModel.Label
        };

        await _dbContext.SessionTypes.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        sessionTypeModel.Id = entity.SessionTypeId;
        return sessionTypeModel;
    }

    public async Task UpdateAsync(SessionTypeModel sessionTypeModel)
    {
        var sessionType = await _dbContext.SessionTypes
            .FirstOrDefaultAsync(s => s.SessionTypeId == sessionTypeModel.Id);
        if (sessionType == null) return;

        if (await _dbContext.SessionTypes.AnyAsync(s => s.Label == sessionTypeModel.Label && s.SessionTypeId != sessionTypeModel.Id))
            throw new InvalidOperationException($"Un SessionType nommé '{sessionTypeModel.Label}' existe déjà.");

        sessionType.Label = sessionTypeModel.Label;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id)
    {
        var sessionType = await _dbContext.SessionTypes
            .FirstOrDefaultAsync(s => s.SessionTypeId == id);
        if (sessionType == null) return;

        // Vérification intégrité référentielle
        var hasSessions = await _dbContext.Sessions
            .AnyAsync(s => s.SessionTypeId == id);

        if (hasSessions)
            throw new InvalidOperationException("Impossible de supprimer ce type de session car des sessions y sont rattachées.");

        _dbContext.SessionTypes.Remove(sessionType);
        await _dbContext.SaveChangesAsync();
    }
}
