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

    public async Task<IEnumerable<SessionModel>> GetPlanningSessionsAsync(string? trackId, string? programId, string? niveau, string? groupId, string? teacherId)
    {
        var query = _dbContext.Sessions.AsQueryable();

        // 1. Filtrage dynamique au niveau de la base de données (SQL)
        if (!string.IsNullOrEmpty(trackId))
            query = query.Where(s => s.Course.Assigns.Any(a => a.TrackId == trackId));

        if (!string.IsNullOrEmpty(programId))
            query = query.Where(s => s.Course.Assigns.Any(a => a.Track.ProgramId == programId));

        if (!string.IsNullOrEmpty(niveau))
            query = query.Where(s => s.Course.Assigns.Any(a => a.Track.Name.StartsWith(niveau)));

        if (!string.IsNullOrEmpty(groupId))
            query = query.Where(s => s.Groups.Any(g => g.GroupId == groupId));

        if (!string.IsNullOrEmpty(teacherId))
            query = query.Where(s => s.Teachers.Any(t => t.UserId == teacherId));

        // 2. Projection vers SessionModel avec toutes les données liées
        return await query
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

    // Garde tes méthodes existantes (GetAllAsync, GetByIdAsync, etc.) ci-dessous...
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

    public async Task<IReadOnlyList<SessionModel>> GetDeletedAsync()
    {
        return await _dbContext.Sessions
            .IgnoreQueryFilters()
            .Where(s => s.IsDeleted)
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
                Description = s.Description,
                DeletedAt = s.DeletedAt
            })
            .ToListAsync();
    }

    public async Task<string?> GetSessionTypeIdByLabelAsync(string label) => 
        await _dbContext.SessionTypes.Where(x => x.Label == label).Select(x => x.SessionTypeId).FirstOrDefaultAsync();

    public async Task<string?> GetSessionStatusIdByLabelAsync(string label) => 
        await _dbContext.SessionStatuses.Where(x => x.Label == label).Select(x => x.SessionStatusId).FirstOrDefaultAsync();

    public Task<bool> CourseExistsAsync(string courseId) => _dbContext.Courses.AnyAsync(x => x.CourseId == courseId);
    public Task<bool> RoomExistsAsync(string roomId) => _dbContext.Rooms.AnyAsync(x => x.RoomId == roomId);
}