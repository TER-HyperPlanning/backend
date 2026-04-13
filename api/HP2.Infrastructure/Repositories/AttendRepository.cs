using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class AttendRepository : IAttendRepository
{
    private readonly TerHyperplanningContext _context;

    public AttendRepository(TerHyperplanningContext context)
    {
        _context = context;
    }

    public async Task<AttendModel> AddAsync(AttendModel model)
    {
        var group = await _context.Groups
            .Include(g => g.Sessions)
            .FirstOrDefaultAsync(g => g.GroupId == model.GroupId);

        if (group == null)
        {
            throw new ArgumentException($"Group with ID {model.GroupId} does not exist.");
        }

        var session = await _context.Sessions
            .FirstOrDefaultAsync(s => s.SessionId == model.SessionId);

        if (session == null)
        {
            throw new ArgumentException($"Session with ID {model.SessionId} does not exist.");
        }

        if (group.Sessions.Any(s => s.SessionId == model.SessionId))
        {
            throw new InvalidOperationException("This session is already assigned to this group.");
        }

        group.Sessions.Add(session);
        await _context.SaveChangesAsync();

        return model;
    }

    public async Task<AttendModel> UpdateAsync(string currentGroupId, string currentSessionId, AttendModel model)
    {
        var currentGroup = await _context.Groups
            .Include(g => g.Sessions)
            .FirstOrDefaultAsync(g => g.GroupId == currentGroupId);

        if (currentGroup == null)
        {
            throw new KeyNotFoundException("Attend relation not found.");
        }

        var currentSession = currentGroup.Sessions.FirstOrDefault(s => s.SessionId == currentSessionId);
        if (currentSession == null)
        {
            throw new KeyNotFoundException("Attend relation not found.");
        }

        var targetGroup = await _context.Groups
            .Include(g => g.Sessions)
            .FirstOrDefaultAsync(g => g.GroupId == model.GroupId);

        if (targetGroup == null)
        {
            throw new ArgumentException($"Group with ID {model.GroupId} does not exist.");
        }

        var targetSession = await _context.Sessions
            .FirstOrDefaultAsync(s => s.SessionId == model.SessionId);

        if (targetSession == null)
        {
            throw new ArgumentException($"Session with ID {model.SessionId} does not exist.");
        }

        if (targetGroup.Sessions.Any(s => s.SessionId == model.SessionId)
            && (currentGroupId != model.GroupId || currentSessionId != model.SessionId))
        {
            throw new InvalidOperationException("This session is already assigned to this group.");
        }

        currentGroup.Sessions.Remove(currentSession);
        targetGroup.Sessions.Add(targetSession);

        await _context.SaveChangesAsync();

        return model;
    }

    public async Task<bool> DeleteAsync(string groupId, string sessionId)
    {
        var group = await _context.Groups
            .Include(g => g.Sessions)
            .FirstOrDefaultAsync(g => g.GroupId == groupId);

        if (group == null)
        {
            return false;
        }

        var session = group.Sessions.FirstOrDefault(s => s.SessionId == sessionId);
        if (session == null)
        {
            return false;
        }

        group.Sessions.Remove(session);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IReadOnlyList<AttendModel>> GetAllAsync()
    {
        var rows = await _context.Groups
            .AsNoTracking()
            .SelectMany(
                g => g.Sessions,
                (g, s) => new AttendModel
                {
                    GroupId = g.GroupId,
                    SessionId = s.SessionId
                })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<AttendModel>> GetByGroupIdAsync(string groupId)
    {
        var rows = await _context.Groups
            .AsNoTracking()
            .Where(g => g.GroupId == groupId)
            .SelectMany(
                g => g.Sessions,
                (g, s) => new AttendModel
                {
                    GroupId = g.GroupId,
                    SessionId = s.SessionId
                })
            .ToListAsync();

        return rows;
    }

    public async Task<IReadOnlyList<AttendModel>> GetBySessionIdAsync(string sessionId)
    {
        var rows = await _context.Sessions
            .AsNoTracking()
            .Where(s => s.SessionId == sessionId)
            .SelectMany(
                s => s.Groups,
                (s, g) => new AttendModel
                {
                    GroupId = g.GroupId,
                    SessionId = s.SessionId
                })
            .ToListAsync();

        return rows;
    }

    public Task<bool> ExistsAsync(string groupId, string sessionId)
        => _context.Groups.AnyAsync(g => g.GroupId == groupId && g.Sessions.Any(s => s.SessionId == sessionId));

    public Task<bool> GroupExistsAsync(string groupId)
        => _context.Groups.AnyAsync(g => g.GroupId == groupId);

    public Task<bool> SessionExistsAsync(string sessionId)
        => _context.Sessions.AnyAsync(s => s.SessionId == sessionId);

    public async Task<IEnumerable<string>> GetAffectedUserIdsAsync(string groupId)
    {
        return await _context.Students
            .AsNoTracking()
            .Where(s => s.GroupId == groupId)
            .Select(s => s.UserId)
            .ToListAsync();
    }
}
