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
                CourseName = s.Course.Name,
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
                CourseName = s.Course.Name,
                Description = s.Description 
            })
            .FirstOrDefaultAsync();
    }

    public override async Task<SessionModel> AddAsync(SessionModel model)
    {
        var entity = new HP2.Infrastructure.Persistence.Entities.Session
        {
            SessionId = Guid.NewGuid().ToString(),
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

        model.Id = entity.SessionId;
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

        private static string MapSessionTypeEnumToLabel(SessionTypeEnum sessionType) => sessionType switch
    {
        SessionTypeEnum.COURS_MAGISTRAL => "Cours Magistral",
        SessionTypeEnum.TD => "TD",
        SessionTypeEnum.TP => "TP",
        _ => throw new ArgumentOutOfRangeException(nameof(sessionType), sessionType, null)
    };

    private static string MapSessionStatusEnumToLabel(SessionStatusEnum sessionStatus) => sessionStatus switch
    {
        SessionStatusEnum.PROGRAMME => "Programmé",
        _ => throw new ArgumentOutOfRangeException(nameof(sessionStatus), sessionStatus, null)
    };

    public async Task<string> GetSessionTypeIdByEnumAsync(SessionTypeEnum sessionType)
    {
        var label = MapSessionTypeEnumToLabel(sessionType);

        var entity = await _dbContext.SessionTypes
            .FirstOrDefaultAsync(x => x.Label == label);

        if (entity == null)
            throw new InvalidOperationException($"SessionType with label '{label}' not found.");

        return entity.SessionTypeId;
    }

    public async Task<string> GetSessionStatusIdByEnumAsync(SessionStatusEnum sessionStatus)
    {
        var label = MapSessionStatusEnumToLabel(sessionStatus);

        var entity = await _dbContext.SessionStatuses
            .FirstOrDefaultAsync(x => x.Label == label);

        if (entity == null)
            throw new InvalidOperationException($"SessionStatus with label '{label}' not found.");

        return entity.SessionStatusId;
    }
}