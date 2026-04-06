using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class SessionChangeRepository : RepositoryBase<SessionChangeModel>, ISessionChangeRepository
{
    public SessionChangeRepository(TerHyperplanningContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<SessionChangeModel>> GetAllAsync()
    {
        var entities = await _dbContext.SessionChanges.ToListAsync();
        return _mapper.Map<IReadOnlyList<SessionChangeModel>>(entities);
    }

    public override async Task<SessionChangeModel?> GetByIdAsync(string id)
    {
        var entity = await _dbContext.SessionChanges
            .FirstOrDefaultAsync(x => x.SessionChangeId == id);

        return entity == null ? null : _mapper.Map<SessionChangeModel>(entity);
    }

    public override async Task<SessionChangeModel> AddAsync(SessionChangeModel model)
    {
        var entity = _mapper.Map<SessionChange>(model);

        if (string.IsNullOrWhiteSpace(entity.SessionChangeId))
        {
            entity.SessionChangeId = Guid.NewGuid().ToString();
        }

        await _dbContext.SessionChanges.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<SessionChangeModel>(entity);
    }

    public override async Task UpdateAsync(SessionChangeModel model)
    {
        var entity = await _dbContext.SessionChanges
            .FirstOrDefaultAsync(x => x.SessionChangeId == model.Id);

        if (entity == null) return;

        entity.ChangeDate = model.Date;
        entity.Reason = model.Reason;
        entity.TeacherId = model.TeacherId;
        entity.SessionId = model.SessionId;
        entity.ChangeStatusId = model.ChangeStatusId;
        entity.ChangeType = model.ChangeType.ToString();

        entity.ApprovedRoomId = model.ApprovedRoomId;

        entity.ProposedDate = model.ProposedDate;
        entity.ProposedStartTime = model.ProposedStartTime;
        entity.ProposedEndTime = model.ProposedEndTime;
        entity.ProposedRoomId = model.ProposedRoomId;

        entity.CounterProposalDate = model.CounterProposalDate;
        entity.CounterProposalStartTime = model.CounterProposalStartTime;
        entity.CounterProposalEndTime = model.CounterProposalEndTime;
        entity.CounterProposalRoomId = model.CounterProposalRoomId;

        entity.RejectionReason = model.RejectionReason;

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var entity = await _dbContext.SessionChanges
            .FirstOrDefaultAsync(x => x.SessionChangeId == id);

        if (entity == null) return;

        _dbContext.SessionChanges.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<SessionChangeModel>> GetAllDetailedAsync()
    {
        return await _dbContext.SessionChanges
            .Include(x => x.Teacher)
                .ThenInclude(t => t.User)
            .Include(x => x.Session)
                .ThenInclude(s => s.Course)
            .Include(x => x.Session)
                .ThenInclude(s => s.Room)
                    .ThenInclude(r => r.Building)
            .Include(x => x.ChangeStatus)
            .Include(x => x.ApprovedRoom)
                .ThenInclude(r => r.Building)
            .Include(x => x.ProposedRoom)
                .ThenInclude(r => r.Building)
            .Include(x => x.CounterProposalRoom)
                .ThenInclude(r => r.Building)
            .Select(x => new SessionChangeModel
            {
                Id = x.SessionChangeId,
                Date = x.ChangeDate,
                Reason = x.Reason,
                TeacherId = x.TeacherId,
                SessionId = x.SessionId,
                ChangeStatusId = x.ChangeStatusId,
                ChangeType = Enum.Parse<HP2.Domain.Enums.SessionChangeType>(x.ChangeType, true),

                ApprovedRoomId = x.ApprovedRoomId,
                ProposedDate = x.ProposedDate,
                ProposedStartTime = x.ProposedStartTime,
                ProposedEndTime = x.ProposedEndTime,
                ProposedRoomId = x.ProposedRoomId,
                CounterProposalDate = x.CounterProposalDate,
                CounterProposalStartTime = x.CounterProposalStartTime,
                CounterProposalEndTime = x.CounterProposalEndTime,
                CounterProposalRoomId = x.CounterProposalRoomId,
                RejectionReason = x.RejectionReason,

                TeacherName = x.Teacher.User.FirstName + " " + x.Teacher.User.LastName,
                TeacherEmail = x.Teacher.User.Email,

                CourseName = x.Session.Course.Name,

                SessionDate = x.Session.Date,
                SessionStartTime = x.Session.StartTime,
                SessionEndTime = x.Session.EndTime,

                CurrentRoomId = x.Session.RoomId,
                CurrentRoomNumber = x.Session.Room.RoomNumber,
                CurrentBuildingName = x.Session.Room.Building.Name,

                ApprovedRoomNumber = x.ApprovedRoom != null ? x.ApprovedRoom.RoomNumber : null,
                ApprovedBuildingName = x.ApprovedRoom != null ? x.ApprovedRoom.Building.Name : null,

                ProposedRoomNumber = x.ProposedRoom != null ? x.ProposedRoom.RoomNumber : null,
                ProposedBuildingName = x.ProposedRoom != null ? x.ProposedRoom.Building.Name : null,

                CounterProposalRoomNumber = x.CounterProposalRoom != null ? x.CounterProposalRoom.RoomNumber : null,
                CounterProposalBuildingName = x.CounterProposalRoom != null ? x.CounterProposalRoom.Building.Name : null,

                ChangeStatusLabel = x.ChangeStatus.Label
            })
            .ToListAsync();
    }

    public async Task<SessionChangeModel?> GetDetailedByIdAsync(string id)
    {
        return await _dbContext.SessionChanges
            .Include(x => x.Teacher)
                .ThenInclude(t => t.User)
            .Include(x => x.Session)
                .ThenInclude(s => s.Course)
            .Include(x => x.Session)
                .ThenInclude(s => s.Room)
                    .ThenInclude(r => r.Building)
            .Include(x => x.ChangeStatus)
            .Include(x => x.ApprovedRoom)
                .ThenInclude(r => r.Building)
            .Include(x => x.ProposedRoom)
                .ThenInclude(r => r.Building)
            .Include(x => x.CounterProposalRoom)
                .ThenInclude(r => r.Building)
            .Where(x => x.SessionChangeId == id)
            .Select(x => new SessionChangeModel
            {
                Id = x.SessionChangeId,
                Date = x.ChangeDate,
                Reason = x.Reason,
                TeacherId = x.TeacherId,
                SessionId = x.SessionId,
                ChangeStatusId = x.ChangeStatusId,
                ChangeType = Enum.Parse<HP2.Domain.Enums.SessionChangeType>(x.ChangeType, true),

                ApprovedRoomId = x.ApprovedRoomId,
                ProposedDate = x.ProposedDate,
                ProposedStartTime = x.ProposedStartTime,
                ProposedEndTime = x.ProposedEndTime,
                ProposedRoomId = x.ProposedRoomId,
                CounterProposalDate = x.CounterProposalDate,
                CounterProposalStartTime = x.CounterProposalStartTime,
                CounterProposalEndTime = x.CounterProposalEndTime,
                CounterProposalRoomId = x.CounterProposalRoomId,
                RejectionReason = x.RejectionReason,

                TeacherName = x.Teacher.User.FirstName + " " + x.Teacher.User.LastName,
                TeacherEmail = x.Teacher.User.Email,

                CourseName = x.Session.Course.Name,

                SessionDate = x.Session.Date,
                SessionStartTime = x.Session.StartTime,
                SessionEndTime = x.Session.EndTime,

                CurrentRoomId = x.Session.RoomId,
                CurrentRoomNumber = x.Session.Room.RoomNumber,
                CurrentBuildingName = x.Session.Room.Building.Name,

                ApprovedRoomNumber = x.ApprovedRoom != null ? x.ApprovedRoom.RoomNumber : null,
                ApprovedBuildingName = x.ApprovedRoom != null ? x.ApprovedRoom.Building.Name : null,

                ProposedRoomNumber = x.ProposedRoom != null ? x.ProposedRoom.RoomNumber : null,
                ProposedBuildingName = x.ProposedRoom != null ? x.ProposedRoom.Building.Name : null,

                CounterProposalRoomNumber = x.CounterProposalRoom != null ? x.CounterProposalRoom.RoomNumber : null,
                CounterProposalBuildingName = x.CounterProposalRoom != null ? x.CounterProposalRoom.Building.Name : null,

                ChangeStatusLabel = x.ChangeStatus.Label
            })
            .FirstOrDefaultAsync();
    }

    public async Task ApproveRoomChangeAsync(string sessionChangeId, string roomId, string approvedStatusId)
    {
        var entity = await _dbContext.SessionChanges
            .Include(x => x.Session)
            .FirstOrDefaultAsync(x => x.SessionChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"SessionChange {sessionChangeId} introuvable.");

        if (entity.Session == null)
            throw new InvalidOperationException("La séance liée à la demande est introuvable.");

        entity.ApprovedRoomId = roomId;
        entity.ChangeStatusId = approvedStatusId;
        entity.Session.RoomId = roomId;

        await _dbContext.SaveChangesAsync();
    }

    public async Task RejectAsync(string sessionChangeId, string rejectionReason, string rejectedStatusId)
    {
        var entity = await _dbContext.SessionChanges
            .FirstOrDefaultAsync(x => x.SessionChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"SessionChange {sessionChangeId} introuvable.");

        entity.RejectionReason = rejectionReason;
        entity.ChangeStatusId = rejectedStatusId;

        await _dbContext.SaveChangesAsync();
    }

    public async Task ApproveRecoveryAsync(string sessionChangeId, string approvedStatusId)
    {
        var entity = await _dbContext.SessionChanges
            .Include(x => x.Session)
            .FirstOrDefaultAsync(x => x.SessionChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"SessionChange {sessionChangeId} introuvable.");

        if (entity.Session == null)
            throw new InvalidOperationException("La séance liée à la demande est introuvable.");

        if (!entity.ProposedDate.HasValue || !entity.ProposedStartTime.HasValue || !entity.ProposedEndTime.HasValue)
            throw new InvalidOperationException("Aucun créneau proposé n'est renseigné pour cette demande.");

        entity.Session.Date = entity.ProposedDate.Value.Date;
        entity.Session.StartTime = entity.ProposedStartTime.Value;
        entity.Session.EndTime = entity.ProposedEndTime.Value;

        if (!string.IsNullOrWhiteSpace(entity.ProposedRoomId))
        {
            entity.Session.RoomId = entity.ProposedRoomId;
        }

        entity.ChangeStatusId = approvedStatusId;

        await _dbContext.SaveChangesAsync();
    }

    public async Task<string?> GetChangeStatusIdByLabelAsync(string label)
    {
        return await _dbContext.ChangeStatuses
            .Where(x => x.Label == label)
            .Select(x => x.ChangeStatusId)
            .FirstOrDefaultAsync();
    }

    public async Task CounterProposeAsync(
        string sessionChangeId,
        DateTime date,
        TimeSpan startTime,
        TimeSpan endTime,
        string roomId,
        string statusId)
    {
        var entity = await _dbContext.SessionChanges
            .FirstOrDefaultAsync(x => x.SessionChangeId == sessionChangeId);

        if (entity == null)
            throw new KeyNotFoundException($"SessionChange {sessionChangeId} introuvable.");

        entity.CounterProposalDate = date.Date;
        entity.CounterProposalStartTime = startTime;
        entity.CounterProposalEndTime = endTime;
        entity.CounterProposalRoomId = roomId;
        entity.ChangeStatusId = statusId;

        await _dbContext.SaveChangesAsync();
    }
    public async Task<bool> RoomExistsAsync(string roomId)
{
    return await _dbContext.Rooms.AnyAsync(r => r.RoomId == roomId);
}
}