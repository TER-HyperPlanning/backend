using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class TeachRepository : ITeachRepository
{
    private const string TeachEntityName = "Teach";
    private readonly TerHyperplanningContext _context;

    public TeachRepository(TerHyperplanningContext context)
    {
        _context = context;
    }

    public async Task<TeachModel> AddAsync(TeachModel model)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync(System.Data.IsolationLevel.Serializable);

        var session = await _context.Sessions
            .FirstOrDefaultAsync(s => s.SessionId == model.SessionId);

        if (session == null)
        {
            throw new ArgumentException($"Session with ID {model.SessionId} does not exist.");
        }

        var teacherExists = await _context.Teachers
            .AnyAsync(t => t.UserId == model.TeacherId);

        if (!teacherExists)
        {
            throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
        }

        var teachRow = await GetTeachRowAsync(model.SessionId, model.TeacherId, includeDeleted: true);

        if (teachRow != null && !GetTeachIsDeleted(teachRow))
        {
            throw new InvalidOperationException("This teacher is already assigned to this session.");
        }

        await EnsureTeacherHasNoScheduleConflictAsync(session, model.TeacherId);

        if (teachRow == null)
        {
            _context.Set<Dictionary<string, object>>(TeachEntityName).Add(new Dictionary<string, object>
            {
                ["SessionId"] = model.SessionId,
                ["TeacherId"] = model.TeacherId,
                ["IsDeleted"] = false
            });
        }
        else
        {
            teachRow["IsDeleted"] = false;
            _context.Entry(teachRow).Property("DeletedAt").CurrentValue = null;
        }

        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        return model;
    }

    public async Task<TeachModel> UpdateAsync(string currentSessionId, string currentTeacherId, TeachModel model)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync(System.Data.IsolationLevel.Serializable);

        var currentTeach = await GetTeachRowAsync(currentSessionId, currentTeacherId, includeDeleted: true);
        if (currentTeach == null || GetTeachIsDeleted(currentTeach))
        {
            throw new KeyNotFoundException("Teach relation not found.");
        }

        var targetSession = await _context.Sessions
            .FirstOrDefaultAsync(s => s.SessionId == model.SessionId);

        if (targetSession == null)
        {
            throw new ArgumentException($"Session with ID {model.SessionId} does not exist.");
        }

        var targetTeacherExists = await _context.Teachers
            .AnyAsync(t => t.UserId == model.TeacherId);

        if (!targetTeacherExists)
        {
            throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
        }

        var isSameRelation = currentSessionId == model.SessionId && currentTeacherId == model.TeacherId;
        var targetTeach = await GetTeachRowAsync(model.SessionId, model.TeacherId, includeDeleted: true);
        if (!isSameRelation && targetTeach != null && !GetTeachIsDeleted(targetTeach))
        {
            throw new InvalidOperationException("This teacher is already assigned to this session.");
        }

        // If the same teacher is moved between sessions, ignore the current one during overlap check.
        var sessionIdToIgnore = currentTeacherId == model.TeacherId ? currentSessionId : null;
        await EnsureTeacherHasNoScheduleConflictAsync(targetSession, model.TeacherId, sessionIdToIgnore);

        if (!isSameRelation)
        {
            var deletedAt = DateTime.UtcNow;
            currentTeach["IsDeleted"] = true;
            currentTeach["DeletedAt"] = deletedAt;

            if (targetTeach == null)
            {
                _context.Set<Dictionary<string, object>>(TeachEntityName).Add(new Dictionary<string, object>
                {
                    ["SessionId"] = model.SessionId,
                    ["TeacherId"] = model.TeacherId,
                    ["IsDeleted"] = false
                });
            }
            else
            {
                targetTeach["IsDeleted"] = false;
                _context.Entry(targetTeach).Property("DeletedAt").CurrentValue = null;
            }
        }

        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        return model;
    }

    public async Task<bool> DeleteAsync(string sessionId, string teacherId)
    {
        var teachRow = await GetTeachRowAsync(sessionId, teacherId, includeDeleted: true);
        if (teachRow == null || GetTeachIsDeleted(teachRow))
        {
            return false;
        }

        teachRow["IsDeleted"] = true;
        teachRow["DeletedAt"] = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IReadOnlyList<TeachModel>> GetAllAsync()
    {
        var rows = await _context.Set<Dictionary<string, object>>(TeachEntityName)
            .AsNoTracking()
            .Select(r => new TeachModel
            {
                SessionId = EF.Property<string>(r, "SessionId"),
                TeacherId = EF.Property<string>(r, "TeacherId"),
                IsDeleted = EF.Property<bool>(r, "IsDeleted"),
                DeletedAt = EF.Property<DateTime?>(r, "DeletedAt")
            })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<TeachModel>> GetDeletedAsync()
    {
        var rows = await _context.Set<Dictionary<string, object>>(TeachEntityName)
            .IgnoreQueryFilters()
            .AsNoTracking()
            .Where(r => EF.Property<bool>(r, "IsDeleted"))
            .Select(r => new TeachModel
            {
                SessionId = EF.Property<string>(r, "SessionId"),
                TeacherId = EF.Property<string>(r, "TeacherId"),
                IsDeleted = EF.Property<bool>(r, "IsDeleted"),
                DeletedAt = EF.Property<DateTime?>(r, "DeletedAt")
            })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<TeachModel>> GetBySessionIdAsync(string sessionId)
    {
        var rows = await _context.Set<Dictionary<string, object>>(TeachEntityName)
            .AsNoTracking()
            .Where(r => EF.Property<string>(r, "SessionId") == sessionId)
            .Select(r => new TeachModel
            {
                SessionId = EF.Property<string>(r, "SessionId"),
                TeacherId = EF.Property<string>(r, "TeacherId"),
                IsDeleted = EF.Property<bool>(r, "IsDeleted"),
                DeletedAt = EF.Property<DateTime?>(r, "DeletedAt")
            })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<TeachModel>> GetByTeacherIdAsync(string teacherId)
    {
        var rows = await _context.Set<Dictionary<string, object>>(TeachEntityName)
            .AsNoTracking()
            .Where(r => EF.Property<string>(r, "TeacherId") == teacherId)
            .Select(r => new TeachModel
            {
                SessionId = EF.Property<string>(r, "SessionId"),
                TeacherId = EF.Property<string>(r, "TeacherId"),
                IsDeleted = EF.Property<bool>(r, "IsDeleted"),
                DeletedAt = EF.Property<DateTime?>(r, "DeletedAt")
            })
            .ToListAsync();

        return rows;
    }

    public Task<bool> ExistsAsync(string sessionId, string teacherId)
        => _context.Set<Dictionary<string, object>>(TeachEntityName)
            .AnyAsync(r => EF.Property<string>(r, "SessionId") == sessionId
                && EF.Property<string>(r, "TeacherId") == teacherId);

    public Task<bool> SessionExistsAsync(string sessionId)
        => _context.Sessions.AnyAsync(s => s.SessionId == sessionId);

    public Task<bool> TeacherExistsAsync(string teacherId)
        => _context.Teachers.AnyAsync(t => t.UserId == teacherId);

    private async Task<Dictionary<string, object>?> GetTeachRowAsync(string sessionId, string teacherId, bool includeDeleted)
    {
        var query = _context.Set<Dictionary<string, object>>(TeachEntityName).AsQueryable();
        if (includeDeleted)
        {
            query = query.IgnoreQueryFilters();
        }

        return await query.FirstOrDefaultAsync(r => EF.Property<string>(r, "SessionId") == sessionId
            && EF.Property<string>(r, "TeacherId") == teacherId);
    }

    private static bool GetTeachIsDeleted(IReadOnlyDictionary<string, object> row)
        => row.TryGetValue("IsDeleted", out var value) && value is bool b && b;

    private async Task EnsureTeacherHasNoScheduleConflictAsync(Session targetSession, string teacherId, string? sessionIdToIgnore = null)
    {
        var conflict = await _context.Sessions
            .AsNoTracking()
            .Where(s => s.Date == targetSession.Date)
            .Where(s => s.SessionId != targetSession.SessionId)
            .Where(s => sessionIdToIgnore == null || s.SessionId != sessionIdToIgnore)
            .Where(s => s.Teachers.Any(t => t.UserId == teacherId))
            .Where(s => targetSession.StartTime <= s.EndTime && s.StartTime <= targetSession.EndTime)
            .Select(s => new
            {
                s.SessionId,
                s.StartTime,
                s.EndTime,
                CourseName = s.Course.Name
            })
            .FirstOrDefaultAsync();

        if (conflict == null)
        {
            return;
        }

        throw new InvalidOperationException(
            $"Teacher already has session '{conflict.SessionId}' ({conflict.CourseName}) on {targetSession.Date:yyyy-MM-dd} from {conflict.StartTime:hh\\:mm} to {conflict.EndTime:hh\\:mm}.");
    }
}
