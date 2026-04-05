using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class SessionChangeService : ISessionChangeService
{
    private readonly ISessionChangeRepository _sessionChangeRepository;

    public SessionChangeService(ISessionChangeRepository sessionChangeRepository)
    {
        _sessionChangeRepository = sessionChangeRepository;
    }

    public async Task<IEnumerable<SessionChangeModel>> GetAllAsync()
    {
        return await _sessionChangeRepository.GetAllDetailedAsync();
    }

    public async Task<SessionChangeModel?> GetByIdAsync(string id)
    {
        return await _sessionChangeRepository.GetDetailedByIdAsync(id);
    }

    public async Task ApproveRoomChangeAsync(string sessionChangeId, string roomId)
    {
        if (string.IsNullOrWhiteSpace(roomId))
            throw new InvalidOperationException("La salle est obligatoire.");

        var approvedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Approuvé");
        if (string.IsNullOrWhiteSpace(approvedStatusId))
            throw new InvalidOperationException("Le statut 'Approuvé' est introuvable.");

        await _sessionChangeRepository.ApproveRoomChangeAsync(sessionChangeId, roomId, approvedStatusId);
    }

    public async Task RejectAsync(string sessionChangeId, string rejectionReason)
    {
        if (string.IsNullOrWhiteSpace(rejectionReason))
            throw new InvalidOperationException("Le motif du refus est obligatoire.");

        var rejectedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Refusé");
        if (string.IsNullOrWhiteSpace(rejectedStatusId))
            throw new InvalidOperationException("Le statut 'Refusé' est introuvable.");

        await _sessionChangeRepository.RejectAsync(sessionChangeId, rejectionReason, rejectedStatusId);
    }

    public async Task ApproveRecoveryAsync(string sessionChangeId)
    {
        var approvedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Approuvé");
        if (string.IsNullOrWhiteSpace(approvedStatusId))
            throw new InvalidOperationException("Le statut 'Approuvé' est introuvable.");

        await _sessionChangeRepository.ApproveRecoveryAsync(sessionChangeId, approvedStatusId);
    }

    public async Task CounterProposeAsync(
        string sessionChangeId,
        DateTime date,
        TimeSpan startTime,
        TimeSpan endTime,
        string roomId)
    {
        if (startTime >= endTime)
            throw new InvalidOperationException("L'heure de début doit être avant l'heure de fin.");

        if (string.IsNullOrWhiteSpace(roomId))
            throw new InvalidOperationException("La salle de contre-proposition est obligatoire.");

        var rejectedStatusId = await _sessionChangeRepository.GetChangeStatusIdByLabelAsync("Refusé");
        if (string.IsNullOrWhiteSpace(rejectedStatusId))
            throw new InvalidOperationException("Le statut 'Refusé' est introuvable.");

        await _sessionChangeRepository.CounterProposeAsync(sessionChangeId, date, startTime, endTime, roomId, rejectedStatusId);
    }
}