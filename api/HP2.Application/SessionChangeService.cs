using HP2.Application.Contracts;
using HP2.Application.DTOs.SessionChange;
using HP2.Domain.Enums;

namespace HP2.Application;

public class SessionChangeService : ISessionChangeService
{
    private readonly ISessionChangeRepository _sessionChangeRepository;

    public SessionChangeService(ISessionChangeRepository sessionChangeRepository)
    {
        _sessionChangeRepository = sessionChangeRepository;
    }

    public async Task<IEnumerable<SessionChangeListResponse>> GetAllAsync()
    {
        return await _sessionChangeRepository.GetAllDetailedAsync();
    }

    public async Task<SessionChangeDetailsResponse?> GetByIdAsync(string id)
    {
        return await _sessionChangeRepository.GetDetailedByIdAsync(id);
    }

    public async Task ApproveRoomChangeAsync(string sessionChangeId, string roomId)
    {
        var sessionChange = await _sessionChangeRepository.GetDetailedByIdAsync(sessionChangeId);
        if (sessionChange == null)
            throw new KeyNotFoundException("Request not found.");

        if (!string.Equals(sessionChange.ChangeType, SessionChangeType.RoomChange.ToString(), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("This request is not a room change request.");

        if (string.IsNullOrWhiteSpace(roomId))
            throw new InvalidOperationException("Room is required.");

        var roomExists = await _sessionChangeRepository.RoomExistsAsync(roomId);
        if (!roomExists)
            throw new KeyNotFoundException("Selected room was not found.");

        var approvedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Approuvé");
        if (string.IsNullOrWhiteSpace(approvedStatusId))
            throw new InvalidOperationException("Approved status was not found.");

        if (sessionChange.ChangeStatusId == approvedStatusId)
            throw new InvalidOperationException("This request is already approved.");

        await _sessionChangeRepository.ApproveRoomChangeAsync(sessionChangeId, roomId, approvedStatusId);
    }

    public async Task RejectAsync(string sessionChangeId, string rejectionReason)
    {
        var sessionChange = await _sessionChangeRepository.GetDetailedByIdAsync(sessionChangeId);
        if (sessionChange == null)
            throw new KeyNotFoundException("Request not found.");

        if (string.IsNullOrWhiteSpace(rejectionReason))
            throw new InvalidOperationException("Rejection reason is required.");

        var rejectedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Refusé");
        if (string.IsNullOrWhiteSpace(rejectedStatusId))
            throw new InvalidOperationException("Rejected status was not found.");

        if (sessionChange.ChangeStatusId == rejectedStatusId)
            throw new InvalidOperationException("This request is already rejected.");

        await _sessionChangeRepository.RejectAsync(sessionChangeId, rejectionReason, rejectedStatusId);
    }

    public async Task ApproveRecoveryAsync(string sessionChangeId)
    {
        var sessionChange = await _sessionChangeRepository.GetDetailedByIdAsync(sessionChangeId);
        if (sessionChange == null)
            throw new KeyNotFoundException("Request not found.");

        if (!string.Equals(sessionChange.ChangeType, SessionChangeType.SessionRecovery.ToString(), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("This request is not a recovery request.");

        var approvedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Approuvé");
        if (string.IsNullOrWhiteSpace(approvedStatusId))
            throw new InvalidOperationException("Approved status was not found.");

        if (sessionChange.ChangeStatusId == approvedStatusId)
            throw new InvalidOperationException("This request is already approved.");

        if (!sessionChange.ProposedDate.HasValue ||
            !sessionChange.ProposedStartTime.HasValue ||
            !sessionChange.ProposedEndTime.HasValue)
        {
            throw new InvalidOperationException("No proposed schedule is defined for this request.");
        }

        if (!string.IsNullOrWhiteSpace(sessionChange.ProposedRoomId))
        {
            var roomExists = await _sessionChangeRepository.RoomExistsAsync(sessionChange.ProposedRoomId);
            if (!roomExists)
                throw new KeyNotFoundException("The proposed recovery room was not found.");
        }

        await _sessionChangeRepository.ApproveRecoveryAsync(sessionChangeId, approvedStatusId);
    }

    public async Task CounterProposeAsync(
        string sessionChangeId,
        DateTime date,
        TimeSpan startTime,
        TimeSpan endTime,
        string roomId)
    {
        var sessionChange = await _sessionChangeRepository.GetDetailedByIdAsync(sessionChangeId);
        if (sessionChange == null)
            throw new KeyNotFoundException("Request not found.");

        if (!string.Equals(sessionChange.ChangeType, SessionChangeType.SessionRecovery.ToString(), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Counter proposal is only available for a recovery request.");

        if (startTime >= endTime)
            throw new InvalidOperationException("Start time must be before end time.");

        if (string.IsNullOrWhiteSpace(roomId))
            throw new InvalidOperationException("Counter proposal room is required.");

        var roomExists = await _sessionChangeRepository.RoomExistsAsync(roomId);
        if (!roomExists)
            throw new KeyNotFoundException("Counter proposal room was not found.");

        var rejectedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Refusé");
        if (string.IsNullOrWhiteSpace(rejectedStatusId))
            throw new InvalidOperationException("Rejected status was not found.");

        await _sessionChangeRepository.CounterProposeAsync(
            sessionChangeId,
            date,
            startTime,
            endTime,
            roomId,
            rejectedStatusId);
    }
}