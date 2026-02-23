using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;


namespace HP2.Infrastructure.Repositories;

public class SessionRepository : RepositoryBase<SessionModel>, HP2.Application.Contracts.ISessionRepository
{
    public SessionRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public override async Task<IReadOnlyList<SessionModel>> GetAllAsync()
    {
        var sessions = await _dbContext.Sessions.ToListAsync();
        return _mapper.Map<List<SessionModel>>(sessions);
    }

    public override async Task<SessionModel?> GetByIdAsync(string id)
    {
        var session = await _dbContext.Sessions.FirstOrDefaultAsync(s => s.SessionId == id);
        return session != null ? _mapper.Map<SessionModel>(session) : null;
    }

    public override async Task<SessionModel> AddAsync(SessionModel model)
{
    if (string.IsNullOrWhiteSpace(model.Id))
        model.Id = Guid.NewGuid().ToString();

    var entity = new HP2.Infrastructure.Persistence.Entities.Session
    {
        SessionId = model.Id,
        Date = model.StartDateTime.Date,
        StartTime = model.StartDateTime.TimeOfDay,
        EndTime = model.EndDateTime.TimeOfDay,
        Mode = model.Mode,
        SessionTypeId = model.SessionTypeId,
        CourseId = model.CourseId,
        SessionStatusId = model.SessionStatusId,
        RoomId = model.RoomId
    };

    await _dbContext.Sessions.AddAsync(entity);
    await _dbContext.SaveChangesAsync();

    return model;
}

    public override async Task UpdateAsync(SessionModel model)
    {
        var entity = await _dbContext.Sessions.FirstOrDefaultAsync(s => s.SessionId == model.Id);
        if (entity == null) return;

        // update champs
        entity.Date = model.StartDateTime.Date;
        entity.StartTime = model.StartDateTime.TimeOfDay;
        entity.EndTime = model.EndDateTime.TimeOfDay;
        entity.Mode = model.Mode;
        entity.SessionTypeId = model.SessionTypeId;
        entity.CourseId = model.CourseId;
        entity.SessionStatusId = model.SessionStatusId;
        entity.RoomId = model.RoomId;

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var entity = await _dbContext.Sessions.FirstOrDefaultAsync(s => s.SessionId == id);
        if (entity == null) return;

        _dbContext.Sessions.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}