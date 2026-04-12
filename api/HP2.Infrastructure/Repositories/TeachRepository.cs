using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class TeachRepository : ITeachRepository
{
    private readonly TerHyperplanningContext _context;

    public TeachRepository(TerHyperplanningContext context)
    {
        _context = context;
    }

    public async Task<TeachModel> AddAsync(TeachModel model)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync(System.Data.IsolationLevel.Serializable);

        var session = await _context.Sessions
            .Include(s => s.Teachers)
            .FirstOrDefaultAsync(s => s.SessionId == model.SessionId);

        if (session == null)
        {
            throw new ArgumentException($"Session with ID {model.SessionId} does not exist.");
        }

        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.UserId == model.TeacherId);

        if (teacher == null)
        {
            throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
        }

        if (session.Teachers.Any(t => t.UserId == model.TeacherId))
        {
            throw new InvalidOperationException("This teacher is already assigned to this session.");
        }

        await EnsureTeacherHasNoScheduleConflictAsync(session, model.TeacherId);

        session.Teachers.Add(teacher);
        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        return model;
    }

    public async Task<TeachModel> UpdateAsync(string currentSessionId, string currentTeacherId, TeachModel model)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync(System.Data.IsolationLevel.Serializable);

        var currentSession = await _context.Sessions
            .Include(s => s.Teachers)
            .FirstOrDefaultAsync(s => s.SessionId == currentSessionId);

        if (currentSession == null)
        {
            throw new KeyNotFoundException("Teach relation not found.");
        }

        var currentTeacher = currentSession.Teachers.FirstOrDefault(t => t.UserId == currentTeacherId);
        if (currentTeacher == null)
        {
            throw new KeyNotFoundException("Teach relation not found.");
        }

        var targetSession = await _context.Sessions
            .Include(s => s.Teachers)
            .FirstOrDefaultAsync(s => s.SessionId == model.SessionId);

        if (targetSession == null)
        {
            throw new ArgumentException($"Session with ID {model.SessionId} does not exist.");
        }

        var targetTeacher = await _context.Teachers
            .FirstOrDefaultAsync(t => t.UserId == model.TeacherId);

        if (targetTeacher == null)
        {
            throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
        }

        if (targetSession.Teachers.Any(t => t.UserId == model.TeacherId)
            && (currentSessionId != model.SessionId || currentTeacherId != model.TeacherId))
        {
            throw new InvalidOperationException("This teacher is already assigned to this session.");
        }

        // If the same teacher is moved between sessions, ignore the current one during overlap check.
        var sessionIdToIgnore = currentTeacherId == model.TeacherId ? currentSessionId : null;
        await EnsureTeacherHasNoScheduleConflictAsync(targetSession, model.TeacherId, sessionIdToIgnore);

        currentSession.Teachers.Remove(currentTeacher);
        targetSession.Teachers.Add(targetTeacher);

        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        return model;
    }

    public async Task<bool> DeleteAsync(string sessionId, string teacherId)
    {
        var session = await _context.Sessions
            .Include(s => s.Teachers)
            .FirstOrDefaultAsync(s => s.SessionId == sessionId);

        if (session == null)
        {
            return false;
        }

        var teacher = session.Teachers.FirstOrDefault(t => t.UserId == teacherId);
        if (teacher == null)
        {
            return false;
        }

        session.Teachers.Remove(teacher);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IReadOnlyList<TeachModel>> GetAllAsync()
    {
        var rows = await _context.Sessions
            .AsNoTracking()
            .SelectMany(
                s => s.Teachers,
                (s, t) => new TeachModel
                {
                    SessionId = s.SessionId,
                    TeacherId = t.UserId
                })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<TeachModel>> GetBySessionIdAsync(string sessionId)
    {
        var rows = await _context.Sessions
            .AsNoTracking()
            .Where(s => s.SessionId == sessionId)
            .SelectMany(
                s => s.Teachers,
                (s, t) => new TeachModel
                {
                    SessionId = s.SessionId,
                    TeacherId = t.UserId
                })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<TeachModel>> GetByTeacherIdAsync(string teacherId)
    {
        var rows = await _context.Teachers
            .AsNoTracking()
            .Where(t => t.UserId == teacherId)
            .SelectMany(
                t => t.Sessions,
                (t, s) => new TeachModel
                {
                    SessionId = s.SessionId,
                    TeacherId = t.UserId
                })
            .ToListAsync();

        return rows;
    }

    public Task<bool> ExistsAsync(string sessionId, string teacherId)
        => _context.Sessions.AnyAsync(s => s.SessionId == sessionId && s.Teachers.Any(t => t.UserId == teacherId));

    public Task<bool> SessionExistsAsync(string sessionId)
        => _context.Sessions.AnyAsync(s => s.SessionId == sessionId);

    public Task<bool> TeacherExistsAsync(string teacherId)
        => _context.Teachers.AnyAsync(t => t.UserId == teacherId);

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
