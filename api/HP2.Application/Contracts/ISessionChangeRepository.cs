using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionChangeRepository : IAsyncRepository<SessionChangeModel>
{
    Task<IReadOnlyList<SessionChangeModel>> GetAllDetailedAsync();
    Task<SessionChangeModel?> GetDetailedByIdAsync(string id);

    Task<string?> GetChangeStatusIdByLabelAsync(string label);
    Task<bool> RoomExistsAsync(string roomId);

    Task ApproveRoomChangeAsync(string sessionChangeId, string roomId, string approvedStatusId);

    Task RejectAsync(string sessionChangeId, string rejectionReason, string rejectedStatusId);

    Task ApproveRecoveryAsync(string sessionChangeId, string approvedStatusId);

    Task CounterProposeAsync(
        string sessionChangeId,
        DateTime date,
        TimeSpan startTime,
        TimeSpan endTime,
        string roomId,
        string statusId);
}