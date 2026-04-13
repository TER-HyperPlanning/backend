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
            throw new KeyNotFoundException("Demande introuvable.");

        if (!string.Equals(sessionChange.ChangeType, SessionChangeType.RoomChange.ToString(), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Cette demande n'est pas une demande de changement de salle.");

        if (string.IsNullOrWhiteSpace(roomId))
            throw new InvalidOperationException("La salle est obligatoire.");

        var roomExists = await _sessionChangeRepository.RoomExistsAsync(roomId);
        if (!roomExists)
            throw new KeyNotFoundException("La salle sélectionnée est introuvable.");

        var approvedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Approuvé");
        if (string.IsNullOrWhiteSpace(approvedStatusId))
            throw new InvalidOperationException("Le statut 'Approuvé' est introuvable.");

        if (sessionChange.ChangeStatusId == approvedStatusId)
            throw new InvalidOperationException("Cette demande est déjà approuvée.");

        await _sessionChangeRepository.ApproveRoomChangeAsync(sessionChangeId, roomId, approvedStatusId);
    }

    public async Task RejectAsync(string sessionChangeId, string rejectionReason)
    {
        var sessionChange = await _sessionChangeRepository.GetDetailedByIdAsync(sessionChangeId);
        if (sessionChange == null)
            throw new KeyNotFoundException("Demande introuvable.");

        if (string.IsNullOrWhiteSpace(rejectionReason))
            throw new InvalidOperationException("Le motif de refus est obligatoire.");

        var rejectedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Refusé");
        if (string.IsNullOrWhiteSpace(rejectedStatusId))
            throw new InvalidOperationException("Le statut 'Refusé' est introuvable.");

        if (sessionChange.ChangeStatusId == rejectedStatusId)
            throw new InvalidOperationException("Cette demande est déjà refusée.");

        await _sessionChangeRepository.RejectAsync(sessionChangeId, rejectionReason, rejectedStatusId);
    }

    public async Task ApproveRecoveryAsync(string sessionChangeId)
    {
        var sessionChange = await _sessionChangeRepository.GetDetailedByIdAsync(sessionChangeId);
        if (sessionChange == null)
            throw new KeyNotFoundException("Demande introuvable.");

        if (!string.Equals(sessionChange.ChangeType, SessionChangeType.SessionRecovery.ToString(), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Cette demande n'est pas une demande de rattrapage.");

        var approvedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Approuvé");
        if (string.IsNullOrWhiteSpace(approvedStatusId))
            throw new InvalidOperationException("Le statut 'Approuvé' est introuvable.");

        if (sessionChange.ChangeStatusId == approvedStatusId)
            throw new InvalidOperationException("Cette demande est déjà approuvée.");

        if (!sessionChange.ProposedDate.HasValue ||
            !sessionChange.ProposedStartTime.HasValue ||
            !sessionChange.ProposedEndTime.HasValue)
        {
            throw new InvalidOperationException("Aucun créneau proposé n'est défini pour cette demande.");
        }

        if (!string.IsNullOrWhiteSpace(sessionChange.ProposedRoomId))
        {
            var roomExists = await _sessionChangeRepository.RoomExistsAsync(sessionChange.ProposedRoomId);
            if (!roomExists)
                throw new KeyNotFoundException("La salle proposée pour le rattrapage est introuvable.");
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
            throw new KeyNotFoundException("Demande introuvable.");

        if (!string.Equals(sessionChange.ChangeType, SessionChangeType.SessionRecovery.ToString(), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("La contre-proposition n'est disponible que pour une demande de rattrapage.");

        if (startTime >= endTime)
            throw new InvalidOperationException("L'heure de début doit être antérieure à l'heure de fin.");

        if (string.IsNullOrWhiteSpace(roomId))
            throw new InvalidOperationException("La salle de la contre-proposition est obligatoire.");

        var roomExists = await _sessionChangeRepository.RoomExistsAsync(roomId);
        if (!roomExists)
            throw new KeyNotFoundException("La salle de la contre-proposition est introuvable.");

        var rejectedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Refusé");
        if (string.IsNullOrWhiteSpace(rejectedStatusId))
            throw new InvalidOperationException("Le statut 'Refusé' est introuvable.");

        await _sessionChangeRepository.CounterProposeAsync(
            sessionChangeId,
            date,
            startTime,
            endTime,
            roomId,
            rejectedStatusId);
    }

    public async Task<IEnumerable<AvailableRoomResponse>> GetAvailableRoomsAsync(string sessionId)
    {
        return await _sessionChangeRepository.GetAvailableRoomsForSessionAsync(sessionId);
    }

    public async Task<IEnumerable<AvailableSlotResponse>> GetAvailableSlotsAsync(string recoveryChangeId, DateTime from, DateTime to)
    {
        if (from > to)
            throw new InvalidOperationException("La date 'from' doit être antérieure à la date 'to'.");

        return await _sessionChangeRepository.GetAvailableSlotsForRecoveryAsync(recoveryChangeId, from, to);
    }
}
