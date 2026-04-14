using HP2.Application.Contracts;
using HP2.Application.DTOs.SessionChange;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class SessionChangeRepository : ISessionChangeRepository
{
    private readonly TerHyperplanningContext _dbContext;

    public SessionChangeRepository(TerHyperplanningContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IReadOnlyList<SessionChangeListResponse>> GetAllDetailedAsync()
    {
        var roomChanges = await _dbContext.SessionRoomChanges
            .Include(x => x.Teacher).ThenInclude(t => t.User)
            .Include(x => x.Session).ThenInclude(s => s.Course)
            .Include(x => x.Session).ThenInclude(s => s.Room).ThenInclude(r => r.Building)
            .Include(x => x.ChangeStatus)
            .Select(x => new SessionChangeListResponse
            {
                Id = x.SessionRoomChangeId,
                TeacherId = x.TeacherId,
                TeacherName = x.Teacher.User.FirstName + " " + x.Teacher.User.LastName,
                TeacherEmail = x.Teacher.User.Email,
                SessionId = x.SessionId,
                CourseName = x.Session.Course.Name,
                SessionDate = x.Session.Date,
                SessionStartTime = x.Session.StartTime,
                SessionEndTime = x.Session.EndTime,
                CurrentRoomNumber = x.Session.Room.RoomNumber,
                CurrentBuildingName = x.Session.Room.Building.Name,
                ChangeStatusId = x.ChangeStatusId,
                ChangeStatusLabel = x.ChangeStatus.Label,
                ChangeType = "RoomChange",
                OldRoomId = x.OldRoomId,
                ApprovedRoomId = x.ApprovedRoomId,
                Reason = x.Reason,
                RequestDate = x.ChangeDate
            })
            .ToListAsync();

        var recoveryChanges = await _dbContext.SessionRecoveryChanges
            .Include(x => x.Teacher).ThenInclude(t => t.User)
            .Include(x => x.Session).ThenInclude(s => s.Course)
            .Include(x => x.Session).ThenInclude(s => s.Room).ThenInclude(r => r.Building)
            .Include(x => x.Session).ThenInclude(s => s.Teachers).ThenInclude(t => t.User)
            .Include(x => x.ChangeStatus)
            .Select(x => new SessionChangeListResponse
            {
                Id = x.SessionRecoveryChangeId,
                TeacherId = x.TeacherId,
                TeacherName = x.Teacher.User.FirstName + " " + x.Teacher.User.LastName,
                TeacherEmail = x.Teacher.User.Email,
                ConcernedTeacherId = x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId) != null
                    ? x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.UserId
                    : x.Session.Teachers.FirstOrDefault()!.UserId,
                ConcernedTeacherName = x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId) != null
                    ? x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.User.FirstName + " " + x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.User.LastName
                    : x.Session.Teachers.FirstOrDefault()!.User.FirstName + " " + x.Session.Teachers.FirstOrDefault()!.User.LastName,
                ConcernedTeacherEmail = x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId) != null
                    ? x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.User.Email
                    : x.Session.Teachers.FirstOrDefault()!.User.Email,
                SessionId = x.SessionId,
                CourseName = x.Session.Course.Name,
                SessionDate = x.Session.Date,
                SessionStartTime = x.Session.StartTime,
                SessionEndTime = x.Session.EndTime,
                CurrentRoomNumber = x.Session.Room.RoomNumber,
                CurrentBuildingName = x.Session.Room.Building.Name,
                ChangeStatusId = x.ChangeStatusId,
                ChangeStatusLabel = x.ChangeStatus.Label,
                ChangeType = "SessionRecovery",
                ProposedDate = x.ProposedDate,
                ProposedStartTime = x.ProposedStartTime,
                ProposedEndTime = x.ProposedEndTime,
                ProposedRoomId = x.ProposedRoomId,
                CounterProposalDate = x.CounterProposalDate,
                CounterProposalStartTime = x.CounterProposalStartTime,
                CounterProposalEndTime = x.CounterProposalEndTime,
                CounterProposalRoomId = x.CounterProposalRoomId,
                RejectionReason = x.RejectionReason,
                Reason = x.Reason,
                RequestDate = x.ChangeDate
            })
            .ToListAsync();

        return roomChanges.Concat(recoveryChanges)
            .OrderByDescending(x => x.RequestDate)
            .ToList();
    }

    public async Task<SessionChangeDetailsResponse?> GetDetailedByIdAsync(string id)
    {
        var roomChange = await _dbContext.SessionRoomChanges
            .Include(x => x.Teacher).ThenInclude(t => t.User)
            .Include(x => x.Session).ThenInclude(s => s.Course)
            .Include(x => x.Session).ThenInclude(s => s.Room).ThenInclude(r => r.Building)
            .Include(x => x.ChangeStatus)
            .Where(x => x.SessionRoomChangeId == id)
            .Select(x => new SessionChangeDetailsResponse
            {
                Id = x.SessionRoomChangeId,
                TeacherId = x.TeacherId,
                TeacherName = x.Teacher.User.FirstName + " " + x.Teacher.User.LastName,
                TeacherEmail = x.Teacher.User.Email,
                SessionId = x.SessionId,
                CourseName = x.Session.Course.Name,
                SessionDate = x.Session.Date,
                SessionStartTime = x.Session.StartTime,
                SessionEndTime = x.Session.EndTime,
                CurrentRoomId = x.Session.RoomId,
                CurrentRoomNumber = x.Session.Room.RoomNumber,
                CurrentBuildingName = x.Session.Room.Building.Name,
                ChangeStatusId = x.ChangeStatusId,
                ChangeStatusLabel = x.ChangeStatus.Label,
                ChangeType = "RoomChange",
                Reason = x.Reason,
                RequestDate = x.ChangeDate,
                OldRoomId = x.OldRoomId,
                ApprovedRoomId = x.ApprovedRoomId,
                RejectionReason = x.RejectionReason
            })
            .FirstOrDefaultAsync();

        if (roomChange != null)
            return roomChange;

        return await _dbContext.SessionRecoveryChanges
            .Include(x => x.Teacher).ThenInclude(t => t.User)
            .Include(x => x.Session).ThenInclude(s => s.Course)
            .Include(x => x.Session).ThenInclude(s => s.Room).ThenInclude(r => r.Building)
            .Include(x => x.Session).ThenInclude(s => s.Teachers).ThenInclude(t => t.User)
            .Include(x => x.ChangeStatus)
            .Where(x => x.SessionRecoveryChangeId == id)
            .Select(x => new SessionChangeDetailsResponse
            {
                Id = x.SessionRecoveryChangeId,
                TeacherId = x.TeacherId,
                TeacherName = x.Teacher.User.FirstName + " " + x.Teacher.User.LastName,
                TeacherEmail = x.Teacher.User.Email,
                ConcernedTeacherId = x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId) != null
                    ? x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.UserId
                    : x.Session.Teachers.FirstOrDefault()!.UserId,
                ConcernedTeacherName = x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId) != null
                    ? x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.User.FirstName + " " + x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.User.LastName
                    : x.Session.Teachers.FirstOrDefault()!.User.FirstName + " " + x.Session.Teachers.FirstOrDefault()!.User.LastName,
                ConcernedTeacherEmail = x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId) != null
                    ? x.Session.Teachers.FirstOrDefault(t => t.UserId != x.TeacherId)!.User.Email
                    : x.Session.Teachers.FirstOrDefault()!.User.Email,
                SessionId = x.SessionId,
                CourseName = x.Session.Course.Name,
                SessionDate = x.Session.Date,
                SessionStartTime = x.Session.StartTime,
                SessionEndTime = x.Session.EndTime,
                CurrentRoomId = x.Session.RoomId,
                CurrentRoomNumber = x.Session.Room.RoomNumber,
                CurrentBuildingName = x.Session.Room.Building.Name,
                ChangeStatusId = x.ChangeStatusId,
                ChangeStatusLabel = x.ChangeStatus.Label,
                ChangeType = "SessionRecovery",
                Reason = x.Reason,
                RequestDate = x.ChangeDate,
                ProposedDate = x.ProposedDate,
                ProposedStartTime = x.ProposedStartTime,
                ProposedEndTime = x.ProposedEndTime,
                ProposedRoomId = x.ProposedRoomId,
                CounterProposalDate = x.CounterProposalDate,
                CounterProposalStartTime = x.CounterProposalStartTime,
                CounterProposalEndTime = x.CounterProposalEndTime,
                CounterProposalRoomId = x.CounterProposalRoomId,
                RejectionReason = x.RejectionReason
            })
            .FirstOrDefaultAsync();
    }

    public async Task ApproveRoomChangeAsync(string sessionChangeId, string roomId, string approvedStatusId)
    {
        var entity = await _dbContext.SessionRoomChanges
            .Include(x => x.Session)
            .FirstOrDefaultAsync(x => x.SessionRoomChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"Demande de changement de salle {sessionChangeId} introuvable.");

        if (entity.Session == null)
            throw new InvalidOperationException("La séance liée à cette demande est introuvable.");

        entity.OldRoomId = entity.Session.RoomId;
        entity.ApprovedRoomId = roomId;
        entity.ChangeStatusId = approvedStatusId;
        entity.Session.RoomId = roomId;

        await _dbContext.SaveChangesAsync();
    }

    public async Task RejectAsync(string sessionChangeId, string rejectionReason, string rejectedStatusId)
    {
        var roomEntity = await _dbContext.SessionRoomChanges
            .FirstOrDefaultAsync(x => x.SessionRoomChangeId == sessionChangeId);

        if (roomEntity != null)
        {
            roomEntity.RejectionReason = rejectionReason;
            roomEntity.ChangeStatusId = rejectedStatusId;
            await _dbContext.SaveChangesAsync();
            return;
        }

        var recoveryEntity = await _dbContext.SessionRecoveryChanges
            .FirstOrDefaultAsync(x => x.SessionRecoveryChangeId == sessionChangeId);

        if (recoveryEntity == null)
            throw new KeyNotFoundException($"Demande {sessionChangeId} introuvable.");

        recoveryEntity.RejectionReason = rejectionReason;
        recoveryEntity.ChangeStatusId = rejectedStatusId;
        await _dbContext.SaveChangesAsync();
    }

    public async Task ApproveRecoveryAsync(string sessionChangeId, string approvedStatusId)
    {
        var entity = await _dbContext.SessionRecoveryChanges
            .Include(x => x.Session)
            .ThenInclude(s => s.Groups)
            .Include(x => x.Session)
            .ThenInclude(s => s.Teachers)
            .FirstOrDefaultAsync(x => x.SessionRecoveryChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"Demande de rattrapage {sessionChangeId} introuvable.");

        if (entity.Session == null)
            throw new InvalidOperationException("La séance liée à cette demande est introuvable.");

        if (!entity.ProposedDate.HasValue || !entity.ProposedStartTime.HasValue || !entity.ProposedEndTime.HasValue)
            throw new InvalidOperationException("Aucun créneau proposé n'est défini pour cette demande.");

        var movedStatusId = await GetSessionStatusIdByLabelAsync("DEPLACE");
        if (string.IsNullOrWhiteSpace(movedStatusId))
            throw new InvalidOperationException("Le statut de séance 'DEPLACE' est introuvable.");

        var recoveredStatusId = await GetSessionStatusIdByLabelAsync("RATTRAPE");
        if (string.IsNullOrWhiteSpace(recoveredStatusId))
            throw new InvalidOperationException("Le statut de séance 'RATTRAPE' est introuvable.");

        var originalSession = entity.Session;
        var recoveredSession = new Session
        {
            SessionId = Guid.NewGuid().ToString(),
            Date = entity.ProposedDate.Value.Date,
            StartTime = entity.ProposedStartTime.Value,
            EndTime = entity.ProposedEndTime.Value,
            Mode = originalSession.Mode,
            SessionTypeId = originalSession.SessionTypeId,
            CourseId = originalSession.CourseId,
            SessionStatusId = recoveredStatusId,
            RoomId = !string.IsNullOrWhiteSpace(entity.ProposedRoomId) ? entity.ProposedRoomId : originalSession.RoomId,
            Description = originalSession.Description
        };

        foreach (var group in originalSession.Groups)
            recoveredSession.Groups.Add(group);

        foreach (var teacher in originalSession.Teachers)
            recoveredSession.Teachers.Add(teacher);

        originalSession.SessionStatusId = movedStatusId;
        _dbContext.Sessions.Add(recoveredSession);

        entity.ChangeStatusId = approvedStatusId;

        await _dbContext.SaveChangesAsync();
    }

    public async Task CounterProposeAsync(
        string sessionChangeId,
        DateTime date,
        TimeSpan startTime,
        TimeSpan endTime,
        string roomId,
        string statusId)
    {
        var entity = await _dbContext.SessionRecoveryChanges
            .Include(x => x.Session).ThenInclude(s => s.Teachers)
            .Include(x => x.Session).ThenInclude(s => s.Groups)
            .FirstOrDefaultAsync(x => x.SessionRecoveryChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"Demande de rattrapage {sessionChangeId} introuvable.");

        if (entity.Session == null)
            throw new InvalidOperationException("La séance liée à cette demande est introuvable.");

        var rattrapageStatusId = await GetSessionStatusIdByLabelAsync("RATTRAPE");

        if (string.IsNullOrWhiteSpace(rattrapageStatusId))
            throw new InvalidOperationException("Le statut de séance 'RATTRAPE' est introuvable.");

        var newSession = new Session
        {
            SessionId = Guid.NewGuid().ToString(),
            Date = date.Date,
            StartTime = startTime,
            EndTime = endTime,
            Mode = entity.Session.Mode,
            CourseId = entity.Session.CourseId,
            SessionTypeId = entity.Session.SessionTypeId,
            SessionStatusId = rattrapageStatusId,
            RoomId = roomId
        };

        await _dbContext.Sessions.AddAsync(newSession);

        foreach (var teacher in entity.Session.Teachers)
            newSession.Teachers.Add(teacher);

        foreach (var group in entity.Session.Groups)
            newSession.Groups.Add(group);

        entity.CounterProposalDate = date.Date;
        entity.CounterProposalStartTime = startTime;
        entity.CounterProposalEndTime = endTime;
        entity.CounterProposalRoomId = roomId;
        entity.ChangeStatusId = statusId;

        await _dbContext.SaveChangesAsync();
    }

    public async Task<string?> GetChangeStatusIdByLabelAsync(string label)
    {
        return await _dbContext.ChangeStatuses
            .Where(x => x.Label == label)
            .Select(x => x.ChangeStatusId)
            .FirstOrDefaultAsync();
    }

    private async Task<string?> GetSessionStatusIdByLabelAsync(string label)
    {
        return await _dbContext.SessionStatuses
            .Where(x => x.Label == label)
            .Select(x => x.SessionStatusId)
            .FirstOrDefaultAsync();
    }

    public async Task<bool> RoomExistsAsync(string roomId)
    {
        return await _dbContext.Rooms.AnyAsync(r => r.RoomId == roomId);
    }

    public async Task<IReadOnlyList<AvailableRoomResponse>> GetAvailableRoomsForSessionAsync(string sessionId)
    {
        var session = await _dbContext.Sessions
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.SessionId == sessionId);

        if (session == null)
            throw new KeyNotFoundException($"Séance {sessionId} introuvable.");

        var occupiedRoomIds = await _dbContext.Sessions
            .AsNoTracking()
            .Where(s => s.SessionId != sessionId
                && s.Date == session.Date
                && s.StartTime < session.EndTime
                && s.EndTime > session.StartTime)
            .Select(s => s.RoomId)
            .ToListAsync();

        return await _dbContext.Rooms
            .AsNoTracking()
            .Include(r => r.Building)
            .Where(r => !occupiedRoomIds.Contains(r.RoomId) && r.IsAvailable == true && !r.IsDeleted)
            .Select(r => new AvailableRoomResponse
            {
                RoomId = r.RoomId,
                RoomNumber = r.RoomNumber,
                Capacity = r.Capacity,
                BuildingName = r.Building.Name
            })
            .ToListAsync();
    }

    public async Task<IReadOnlyList<AvailableSlotResponse>> GetAvailableSlotsForRecoveryAsync(
        string recoveryChangeId,
        DateTime from,
        DateTime to)
    {
        var recoveryChange = await _dbContext.SessionRecoveryChanges
            .AsNoTracking()
            .Include(x => x.Session).ThenInclude(s => s.Teachers)
            .Include(x => x.Session).ThenInclude(s => s.Groups)
            .FirstOrDefaultAsync(x => x.SessionRecoveryChangeId == recoveryChangeId);

        if (recoveryChange == null)
            throw new KeyNotFoundException($"Demande de rattrapage {recoveryChangeId} introuvable.");

        var session = recoveryChange.Session;
        var duration = session.EndTime - session.StartTime;
        var teacherIds = session.Teachers.Select(t => t.UserId).ToList();
        var groupIds = session.Groups.Select(g => g.GroupId).ToList();

        var teacherAvailabilities = await _dbContext.Availabilities
            .AsNoTracking()
            .Where(a => teacherIds.Contains(a.TeacherId)
                && a.StartDate <= to
                && a.EndDate >= from)
            .ToListAsync();

        var result = new List<AvailableSlotResponse>();

        for (var day = from.Date; day <= to.Date; day = day.AddDays(1))
        {
            var dayOfWeek = (int)day.DayOfWeek;
            // Map .NET DayOfWeek (0=Sun) to WeekDay OrderIndex (1=Mon..7=Sun)
            var orderIndex = dayOfWeek == 0 ? 7 : dayOfWeek;

            var weekdayId = await _dbContext.WeekDays
                .AsNoTracking()
                .Where(w => w.OrderIndex == orderIndex)
                .Select(w => w.WeekdayId)
                .FirstOrDefaultAsync();

            if (weekdayId == null)
                continue;

            var dayAvailabilities = teacherAvailabilities
                .Where(a => a.WeekdayId == weekdayId
                    && a.StartDate.Date <= day
                    && a.EndDate.Date >= day)
                .ToList();

            foreach (var avail in dayAvailabilities)
            {
                var slotStart = avail.StartTime;
                while (slotStart + duration <= avail.EndTime)
                {
                    var slotEnd = slotStart + duration;

                    var teacherConflict = await _dbContext.Sessions
                        .AsNoTracking()
                        .Include(s => s.Teachers)
                        .AnyAsync(s => s.Date == day
                            && s.StartTime < slotEnd
                            && s.EndTime > slotStart
                            && s.Teachers.Any(t => teacherIds.Contains(t.UserId)));

                    if (!teacherConflict)
                    {
                        var groupConflict = await _dbContext.Sessions
                            .AsNoTracking()
                            .Include(s => s.Groups)
                            .AnyAsync(s => s.Date == day
                                && s.StartTime < slotEnd
                                && s.EndTime > slotStart
                                && s.Groups.Any(g => groupIds.Contains(g.GroupId)));

                        if (!groupConflict)
                        {
                            var occupiedRoomIds = await _dbContext.Sessions
                                .AsNoTracking()
                                .Where(s => s.Date == day
                                    && s.StartTime < slotEnd
                                    && s.EndTime > slotStart)
                                .Select(s => s.RoomId)
                                .ToListAsync();

                            var availableRooms = await _dbContext.Rooms
                                .AsNoTracking()
                                .Include(r => r.Building)
                                .Where(r => !occupiedRoomIds.Contains(r.RoomId)
                                    && r.IsAvailable == true
                                    && !r.IsDeleted)
                                .Select(r => new AvailableRoomResponse
                                {
                                    RoomId = r.RoomId,
                                    RoomNumber = r.RoomNumber,
                                    Capacity = r.Capacity,
                                    BuildingName = r.Building.Name
                                })
                                .ToListAsync();

                            if (availableRooms.Count > 0)
                            {
                                result.Add(new AvailableSlotResponse
                                {
                                    Date = day,
                                    StartTime = slotStart,
                                    EndTime = slotEnd,
                                    AvailableRooms = availableRooms
                                });
                            }
                        }
                    }

                    slotStart = slotStart.Add(duration);
                }
            }
        }

        return result;
    }
}
