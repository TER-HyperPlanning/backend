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
                Reason = x.Reason,
                RequestDate = x.ChangeDate
            })
            .ToListAsync();

        var recoveryChanges = await _dbContext.SessionRecoveryChanges
            .Include(x => x.Teacher).ThenInclude(t => t.User)
            .Include(x => x.Session).ThenInclude(s => s.Course)
            .Include(x => x.Session).ThenInclude(s => s.Room).ThenInclude(r => r.Building)
            .Include(x => x.ChangeStatus)
            .Select(x => new SessionChangeListResponse
            {
                Id = x.SessionRecoveryChangeId,
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
                ChangeType = "SessionRecovery",
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
            .Include(x => x.ChangeStatus)
            .Where(x => x.SessionRecoveryChangeId == id)
            .Select(x => new SessionChangeDetailsResponse
            {
                Id = x.SessionRecoveryChangeId,
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
            throw new KeyNotFoundException($"Room change request {sessionChangeId} not found.");

        if (entity.Session == null)
            throw new InvalidOperationException("The session linked to this request was not found.");

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
            throw new KeyNotFoundException($"Session change request {sessionChangeId} not found.");

        recoveryEntity.RejectionReason = rejectionReason;
        recoveryEntity.ChangeStatusId = rejectedStatusId;
        await _dbContext.SaveChangesAsync();
    }

    public async Task ApproveRecoveryAsync(string sessionChangeId, string approvedStatusId)
    {
        var entity = await _dbContext.SessionRecoveryChanges
            .Include(x => x.Session)
            .FirstOrDefaultAsync(x => x.SessionRecoveryChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"Recovery change request {sessionChangeId} not found.");

        if (entity.Session == null)
            throw new InvalidOperationException("The session linked to this request was not found.");

        if (!entity.ProposedDate.HasValue || !entity.ProposedStartTime.HasValue || !entity.ProposedEndTime.HasValue)
            throw new InvalidOperationException("No proposed schedule is defined for this request.");

        entity.Session.Date = entity.ProposedDate.Value.Date;
        entity.Session.StartTime = entity.ProposedStartTime.Value;
        entity.Session.EndTime = entity.ProposedEndTime.Value;

        if (!string.IsNullOrWhiteSpace(entity.ProposedRoomId))
            entity.Session.RoomId = entity.ProposedRoomId;

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
            .FirstOrDefaultAsync(x => x.SessionRecoveryChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"Recovery change request {sessionChangeId} not found.");

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

    public async Task<bool> RoomExistsAsync(string roomId)
    {
        return await _dbContext.Rooms.AnyAsync(r => r.RoomId == roomId);
    }
}
