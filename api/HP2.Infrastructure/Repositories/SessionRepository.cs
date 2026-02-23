using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Domain.Enums;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;


namespace HP2.Infrastructure.Repositories;

public class SessionRepository : RepositoryBase<SessionModel>, HP2.Application.Contracts.ISessionRepository
{
    public SessionRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public override async Task<IReadOnlyList<SessionModel>> GetAllAsync()
    {
        return await _dbContext.Sessions
            .Select(s => new SessionModel
            {
                Id = s.SessionId,
                StartDateTime = s.Date.Date + s.StartTime,
                EndDateTime = s.Date.Date + s.EndTime,
                Mode = Enum.Parse<SessionMode>(s.Mode, true),

                SessionTypeId = s.SessionTypeId,
                CourseId = s.CourseId,
                SessionStatusId = s.SessionStatusId,
                RoomId = s.RoomId,

                SessionTypeLabel = s.SessionType.Label,
                SessionStatusLabel = s.SessionStatus.Label,
                RoomNumber = s.Room.RoomNumber,

                Description = s.Description
            })
            .ToListAsync();
    }

    public override async Task<SessionModel?> GetByIdAsync(string id)   
    {
        return await _dbContext.Sessions
            .Where(s => s.SessionId == id)
            .Select(s => new SessionModel
            {
                Id = s.SessionId,
                StartDateTime = s.Date.Date + s.StartTime,
                EndDateTime = s.Date.Date + s.EndTime,
                Mode = Enum.Parse<SessionMode>(s.Mode, true),

                SessionTypeId = s.SessionTypeId,
                CourseId = s.CourseId,
                SessionStatusId = s.SessionStatusId,
                RoomId = s.RoomId,

             
                SessionTypeLabel = s.SessionType.Label,
                SessionStatusLabel = s.SessionStatus.Label,
                RoomNumber = s.Room.RoomNumber,

                Description = s.Description 
            })
            .FirstOrDefaultAsync();
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
        Mode = model.Mode.ToString(),
        SessionTypeId = model.SessionTypeId,
        CourseId = model.CourseId,
        SessionStatusId = model.SessionStatusId,
        RoomId = model.RoomId,
        Description = model.Description
    };

    await _dbContext.Sessions.AddAsync(entity);
    await _dbContext.SaveChangesAsync();

    return model;
}

    public override async Task UpdateAsync(SessionModel model)
    {
        var entity = await _dbContext.Sessions.FirstOrDefaultAsync(s => s.SessionId == model.Id);
        if (entity == null) return;

        entity.Date = model.StartDateTime.Date;
        entity.StartTime = model.StartDateTime.TimeOfDay;
        entity.EndTime = model.EndDateTime.TimeOfDay;
        entity.Mode = model.Mode.ToString();
        entity.SessionTypeId = model.SessionTypeId;
        entity.CourseId = model.CourseId;
        entity.SessionStatusId = model.SessionStatusId;
        entity.RoomId = model.RoomId;
        entity.Description = model.Description;

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