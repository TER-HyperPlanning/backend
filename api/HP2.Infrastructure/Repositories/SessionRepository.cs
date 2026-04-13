using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Enums;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using Microsoft.Extensions.Logging;

namespace HP2.Infrastructure.Repositories;
public class SessionRepository : RepositoryBase<SessionModel>, ISessionRepository
{
    private readonly ILogger<SessionRepository> _logger;

    public SessionRepository(TerHyperplanningContext dbContext, IMapper mapper, ILogger<SessionRepository> logger) : base(dbContext, mapper) 
    {
        _logger = logger;
    }

    public override async Task<IReadOnlyList<SessionModel>> GetAllAsync()
    {
        var rows = await _dbContext.Sessions
            .Where(s => !s.IsDeleted)
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
        await using var transaction = await _dbContext.Database.BeginTransactionAsync(IsolationLevel.Serializable);
        await AcquireRoomDateLockAsync(model.RoomId, model.StartDateTime.Date);
        await EnsureRoomHasNoScheduleConflictAsync(
            model.StartDateTime.Date,
            model.StartDateTime.TimeOfDay,
            model.EndDateTime.TimeOfDay,
            model.RoomId);

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
        await transaction.CommitAsync();

        model.Id = entity.SessionId;
        return model;
    }

    public override async Task UpdateAsync(SessionModel model)
    {
        var entity = await _dbContext.Sessions.FirstOrDefaultAsync(s => s.SessionId == model.Id);
        if (entity == null)
        {
            return;
        }

        // Soft-delete updates should not trigger schedule conflict validation.
        if (model.IsDeleted)
        {
            entity.IsDeleted = model.IsDeleted;
            entity.DeletedAt = model.DeletedAt;
            await _dbContext.SaveChangesAsync();
            return;
        }

        await using var transaction = await _dbContext.Database.BeginTransactionAsync(IsolationLevel.Serializable);
        await AcquireRoomDateLockAsync(model.RoomId, model.StartDateTime.Date);
        await EnsureRoomHasNoScheduleConflictAsync(
            model.StartDateTime.Date,
            model.StartDateTime.TimeOfDay,
            model.EndDateTime.TimeOfDay,
            model.RoomId,
            model.Id);

        entity.Date = model.StartDateTime.Date;
        entity.StartTime = model.StartDateTime.TimeOfDay;
        entity.EndTime = model.EndDateTime.TimeOfDay;
        entity.Mode = model.Mode.ToString();
        entity.SessionTypeId = model.SessionTypeId;
        entity.CourseId = model.CourseId;
        entity.SessionStatusId = model.SessionStatusId;
        entity.RoomId = model.RoomId;
        entity.Description = model.Description;
        entity.IsDeleted = model.IsDeleted;
        entity.DeletedAt = model.DeletedAt;

        await _dbContext.SaveChangesAsync();
        await transaction.CommitAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        await base.DeleteAsync(id);
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

    private static string SanitizeForLog(string? value)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;
            
        return value.Replace("\r", string.Empty).Replace("\n", string.Empty);
    }

    public async Task<IEnumerable<string>> GetAffectedUserIdsAsync(string sessionId)
    {
        var safeSessionId = SanitizeForLog(sessionId);
        _logger.LogInformation("[DEBUG] SessionRepository: Getting affected users for session {SessionId}", safeSessionId);
        
        try
        {
            // On utilise une projection directe sur la session pour laisser EF Core gÃ©rer les jointures de maniÃ¨re optimale
            var data = await _dbContext.Sessions
                .Where(s => s.SessionId == sessionId)
                .Select(s => new
                {
                    TeacherIds = s.Teachers.Select(t => t.UserId).ToList(),
                    StudentIds = s.Groups.SelectMany(g => g.Students).Select(st => st.UserId).ToList()
                })
                .FirstOrDefaultAsync();

            if (data == null)
            {
                _logger.LogWarning("[DEBUG] SessionRepository: Session {SessionId} not found.", safeSessionId);
                return Enumerable.Empty<string>();
            }

            var totalIds = data.TeacherIds.Concat(data.StudentIds).Distinct().ToList();
            
            _logger.LogInformation("[DEBUG] SessionRepository: Found {Count} unique users to notify for session {SessionId}: {UserIds}", 
                totalIds.Count, safeSessionId, string.Join(", ", totalIds));
            return totalIds;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "[DEBUG] SessionRepository: Error while getting affected users for session {SessionId}", safeSessionId);
            return Enumerable.Empty<string>();
        }
    }

    private static SessionMode ParseSessionModeOrDefault(string? mode)
    {
        return Enum.TryParse<SessionMode>(mode, true, out var parsed)
            ? parsed
            : SessionMode.PRESENTIAL;
    }

    private async Task EnsureRoomHasNoScheduleConflictAsync(
        DateTime targetDate,
        TimeSpan targetStart,
        TimeSpan targetEnd,
        string roomId,
        string? sessionIdToIgnore = null)
    {
        var conflict = await _dbContext.Sessions
            .AsNoTracking()
            .Where(s => s.Date == targetDate)
            .Where(s => s.RoomId == roomId)
            .Where(s => sessionIdToIgnore == null || s.SessionId != sessionIdToIgnore)
            .Where(s => targetStart <= s.EndTime && s.StartTime <= targetEnd)
            .Select(s => new
            {
                s.SessionId,
                s.StartTime,
                s.EndTime,
                RoomNumber = s.Room.RoomNumber,
                CourseName = s.Course.Name
            })
            .FirstOrDefaultAsync();

        if (conflict == null)
        {
            return;
        }

        throw new InvalidOperationException(
            $"Room '{conflict.RoomNumber}' is already occupied by session '{conflict.SessionId}' ({conflict.CourseName}) on {targetDate:yyyy-MM-dd} from {conflict.StartTime:hh\\:mm} to {conflict.EndTime:hh\\:mm}.");
    }

    private async Task AcquireRoomDateLockAsync(string roomId, DateTime date)
    {
        var efTransaction = _dbContext.Database.CurrentTransaction;
        if (efTransaction == null)
        {
            throw new InvalidOperationException("Room lock acquisition requires an active transaction.");
        }

        var connection = _dbContext.Database.GetDbConnection();
        if (connection.State != ConnectionState.Open)
        {
            await connection.OpenAsync();
        }

        await using var command = connection.CreateCommand();
        command.Transaction = efTransaction.GetDbTransaction();
        command.CommandText = @"
DECLARE @result int;
EXEC @result = sp_getapplock
    @Resource = @resource,
    @LockMode = 'Exclusive',
    @LockOwner = 'Transaction',
    @LockTimeout = 10000;
SELECT @result;";

        var resourceParameter = command.CreateParameter();
        resourceParameter.ParameterName = "@resource";
        resourceParameter.Value = $"room:{roomId}:date:{date:yyyyMMdd}";
        command.Parameters.Add(resourceParameter);

        var scalar = await command.ExecuteScalarAsync();
        var lockResult = scalar == null || scalar == DBNull.Value ? -999 : Convert.ToInt32(scalar);

        if (lockResult < 0)
        {
            throw new InvalidOperationException(
                $"Unable to lock room '{roomId}' on {date:yyyy-MM-dd} to validate schedule conflict (sp_getapplock result: {lockResult}).");
        }
    }

    public async Task<IReadOnlyList<SessionModel>> GetDeletedAsync()
    {
        var rows = await _dbContext.Sessions
            .IgnoreQueryFilters()
            .Where(s => s.IsDeleted)
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
                Description = s.Description,
                IsDeleted = s.IsDeleted,
                DeletedAt = s.DeletedAt
            })
            .ToListAsync();

        return rows.Select(s => new SessionModel
        {
            Id = s.Id,
            StartDateTime = s.StartDateTime,
            EndDateTime = s.EndDateTime,
            Mode = ParseSessionModeOrDefault(s.Mode),
            SessionTypeId = s.SessionTypeId,
            CourseId = s.CourseId,
            SessionStatusId = s.SessionStatusId,
            RoomId = s.RoomId,
            Description = s.Description,
            IsDeleted = s.IsDeleted,
            DeletedAt = s.DeletedAt
        }).ToList();
    }
    public async Task<IEnumerable<SessionModel>> SearchSessionsAsync(string? groupId, string? type, string? search)
    {
        groupId = string.IsNullOrWhiteSpace(groupId) ? null : groupId;
        type = string.IsNullOrWhiteSpace(type) ? null : type;
        search = string.IsNullOrWhiteSpace(search) ? null : search;

        var query = _dbContext.Sessions
            .Where(s => !s.IsDeleted)
            .AsQueryable();

        if (groupId != null)
        {
            query = query.Where(s => s.Groups.Any(g => g.GroupId == groupId));
        }
        if (type != null)
        {
            var lowerType = type.ToLower();
            query = query.Where(s => s.SessionType.Label.ToLower() == lowerType);
        }
        if (search != null)
        {
            var lower = search.ToLower();

            query = query.Where(s =>
                s.Course.Name.ToLower().Contains(lower) ||
                s.Room.RoomNumber.ToLower().Contains(lower) ||
                s.SessionType.Label.ToLower().Contains(lower) ||
                s.SessionStatus.Label.ToLower().Contains(lower) ||
                (s.Description != null && s.Description.ToLower().Contains(lower))
            );
        }

        var rows = await query
            .Select(s => new
            {
                Id = s.SessionId,
                StartDateTime = s.Date.Date + s.StartTime,
                EndDateTime = s.Date.Date + s.EndTime,
                Mode = s.Mode,
                SessionTypeLabel = s.SessionType.Label,
                SessionStatusLabel = s.SessionStatus.Label,
                RoomNumber = s.Room.RoomNumber,
                CourseName = s.Course.Name,
                Description = s.Description
            })
            .ToListAsync();

        return rows.Select(s => new SessionModel
        {
            Id = s.Id,
            StartDateTime = s.StartDateTime,
            EndDateTime = s.EndDateTime,
            Mode = ParseSessionModeOrDefault(s.Mode),
            SessionTypeLabel = s.SessionTypeLabel,
            SessionStatusLabel = s.SessionStatusLabel,
            RoomNumber = s.RoomNumber,
            CourseName = s.CourseName,
            Description = s.Description
        }).ToList();
    }
}