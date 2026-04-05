using HP2.Application.Contracts;
using HP2.Application.DTOs.Planning;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HP2.Infrastructure.Repositories;

public class PlanningRepository : IPlanningRepository
{
    private readonly TerHyperplanningContext _dbContext;

    public PlanningRepository(TerHyperplanningContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<SessionModel>> GetPlanningSessionsAsync(PlanningRequest request, string? currentUserId, string? currentUserRole)
    {
        var query = _dbContext.Sessions
            .Include(s => s.Course)
            .Include(s => s.Room)
            .Include(s => s.SessionType)
            .Include(s => s.SessionStatus)
            .Include(s => s.Groups)
            .Include(s => s.Teachers)
            .AsNoTracking()
            .AsQueryable();

        // 1. Date Filtering
        if (request.StartDate.HasValue)
        {
            query = query.Where(s => s.Date >= request.StartDate.Value.Date);
        }
        
        if (request.EndDate.HasValue)
        {
            query = query.Where(s => s.Date <= request.EndDate.Value.Date);
        }

        // 2. Explicit Filtering
        if (!string.IsNullOrWhiteSpace(request.GroupId))
        {
            query = query.Where(s => s.Groups.Any(g => g.GroupId == request.GroupId));
        }

        if (!string.IsNullOrWhiteSpace(request.TrackId))
        {
            query = query.Where(s => s.Groups.Any(g => g.TrackId == request.TrackId));
        }

        if (!string.IsNullOrWhiteSpace(request.ProgramId))
        {
            query = query.Where(s => s.Groups.Any(g => g.Track.ProgramId == request.ProgramId));
        }

        var sessions = await query.OrderBy(s => s.Date).ThenBy(s => s.StartTime).ToListAsync();

        // Map to standard SessionModel as expected by the application layer
        // Ideally we map directly to dto, but to respect the existing DDD architecture flow, 
        // repo returns models and service maps to DTO.
        return sessions.Select(s => new SessionModel
        {
            Id = s.SessionId,
            StartDateTime = s.Date.Date + s.StartTime,
            EndDateTime = s.Date.Date + s.EndTime,
            Mode = Enum.TryParse<HP2.Domain.Enums.SessionMode>(s.Mode, true, out var m) ? m : HP2.Domain.Enums.SessionMode.PRESENTIAL,
            SessionTypeId = s.SessionTypeId,
            CourseId = s.CourseId,
            SessionStatusId = s.SessionStatusId,
            RoomId = s.RoomId,
            SessionTypeLabel = s.SessionType?.Label,
            SessionStatusLabel = s.SessionStatus?.Label,
            RoomNumber = s.Room?.RoomNumber,
            CourseName = s.Course?.Name,
            Description = s.Description
        }).ToList();
    }

    public async Task<IEnumerable<SessionModel>> GetMyPlanningSessionsAsync(PlanningRequest request, string currentUserId, string currentUserRole)
    {
        var query = _dbContext.Sessions
            .Include(s => s.Course)
            .Include(s => s.Room)
            .Include(s => s.SessionType)
            .Include(s => s.SessionStatus)
            .Include(s => s.Groups)
            .Include(s => s.Teachers)
            .AsNoTracking()
            .AsQueryable();

        // 1. Date Filtering (Always apply)
        if (request.StartDate.HasValue)
        {
            query = query.Where(s => s.Date >= request.StartDate.Value.Date);
        }
        
        if (request.EndDate.HasValue)
        {
            query = query.Where(s => s.Date <= request.EndDate.Value.Date);
        }

        // 2. Role-based Filtering
        var roleUpper = currentUserRole?.ToUpperInvariant();

        if (roleUpper == HP2.Domain.Enums.UserRole.STUDENT.ToString())
        {
            // For students, ignore specific group/track/program requests and force filtering on their own group
            query = query.Where(s => s.Groups.Any(g => g.Students.Any(st => st.UserId == currentUserId)));
        }
        else if (roleUpper == HP2.Domain.Enums.UserRole.TEACHER.ToString())
        {
            // For teachers, ignore specific requests and force filtering on sessions they teach
            query = query.Where(s => s.Teachers.Any(t => t.UserId == currentUserId));
        }
        else if (roleUpper == HP2.Domain.Enums.UserRole.ADMIN.ToString())
        {
            // Admin can use specific filters like get-planning if provided
            if (!string.IsNullOrWhiteSpace(request.GroupId))
            {
                query = query.Where(s => s.Groups.Any(g => g.GroupId == request.GroupId));
            }

            if (!string.IsNullOrWhiteSpace(request.TrackId))
            {
                query = query.Where(s => s.Groups.Any(g => g.TrackId == request.TrackId));
            }

            if (!string.IsNullOrWhiteSpace(request.ProgramId))
            {
                query = query.Where(s => s.Groups.Any(g => g.Track.ProgramId == request.ProgramId));
            }
        }

        var sessions = await query.OrderBy(s => s.Date).ThenBy(s => s.StartTime).ToListAsync();

        return sessions.Select(s => new SessionModel
        {
            Id = s.SessionId,
            StartDateTime = s.Date.Date + s.StartTime,
            EndDateTime = s.Date.Date + s.EndTime,
            Mode = Enum.TryParse<HP2.Domain.Enums.SessionMode>(s.Mode, true, out var m) ? m : HP2.Domain.Enums.SessionMode.PRESENTIAL,
            SessionTypeId = s.SessionTypeId,
            CourseId = s.CourseId,
            SessionStatusId = s.SessionStatusId,
            RoomId = s.RoomId,
            SessionTypeLabel = s.SessionType?.Label,
            SessionStatusLabel = s.SessionStatus?.Label,
            RoomNumber = s.Room?.RoomNumber,
            CourseName = s.Course?.Name,
            Description = s.Description
        }).ToList();
    }
}
