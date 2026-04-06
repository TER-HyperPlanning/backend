using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Enums;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class SessionRepository : RepositoryBase<SessionModel>, ISessionRepository
{
    public SessionRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public override async Task<IReadOnlyList<SessionModel>> GetAllAsync()
    {
        var rows = await _dbContext.Sessions
            .Select(s => new
            {
                Id = s.SessionId,
                StartDateTime = s.Date.Date + s.StartTime,
                EndDateTime = s.Date.Date + s.EndTime,
                Mode = s.Mode,

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

        return rows
            .Select(s => new SessionModel
            {
                Id = s.Id,
                StartDateTime = s.StartDateTime,
                EndDateTime = s.EndDateTime,
                Mode = ParseSessionModeOrDefault(s.Mode),
                SessionTypeId = s.SessionTypeId,
                CourseId = s.CourseId,
                SessionStatusId = s.SessionStatusId,
                RoomId = s.RoomId,
                SessionTypeLabel = s.SessionTypeLabel,
                SessionStatusLabel = s.SessionStatusLabel,
                RoomNumber = s.RoomNumber,
                CourseName = s.CourseName,
                Description = s.Description
            })
            .ToList();
    }

    public override async Task<SessionModel?> GetByIdAsync(string id)
    {
        var row = await _dbContext.Sessions
            .Where(s => s.SessionId == id)
            .Select(s => new
            {
                Id = s.SessionId,
                StartDateTime = s.Date.Date + s.StartTime,
                EndDateTime = s.Date.Date + s.EndTime,
                Mode = s.Mode,

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

        if (row == null)
        {
            return null;
        }

        return new SessionModel
        {
            Id = row.Id,
            StartDateTime = row.StartDateTime,
            EndDateTime = row.EndDateTime,
            Mode = ParseSessionModeOrDefault(row.Mode),
            SessionTypeId = row.SessionTypeId,
            CourseId = row.CourseId,
            SessionStatusId = row.SessionStatusId,
            RoomId = row.RoomId,
            SessionTypeLabel = row.SessionTypeLabel,
            SessionStatusLabel = row.SessionStatusLabel,
            RoomNumber = row.RoomNumber,
            CourseName = row.CourseName,
            Description = row.Description
        };
    }

    public override async Task<SessionModel> AddAsync(SessionModel model)
    {
        var entity = new Session
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

    public async Task<string?> GetSessionTypeIdByLabelAsync(string label)
    {
        return await _dbContext.SessionTypes
            .Where(x => x.Label == label)
            .Select(x => x.SessionTypeId)
            .FirstOrDefaultAsync();
    }

    public async Task<string?> GetSessionStatusIdByLabelAsync(string label)
    {
        return await _dbContext.SessionStatuses
            .Where(x => x.Label == label)
            .Select(x => x.SessionStatusId)
            .FirstOrDefaultAsync();
    }

    public Task<bool> CourseExistsAsync(string courseId)
    {
        return _dbContext.Courses.AnyAsync(x => x.CourseId == courseId);
    }

    public Task<bool> RoomExistsAsync(string roomId)
    {
        return _dbContext.Rooms.AnyAsync(x => x.RoomId == roomId);
    }

    private static SessionMode ParseSessionModeOrDefault(string? mode)
    {
        return Enum.TryParse<SessionMode>(mode, true, out var parsed)
            ? parsed
            : SessionMode.PRESENTIAL;
    }
}