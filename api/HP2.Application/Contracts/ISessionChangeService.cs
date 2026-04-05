using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionChangeService
{
    Task<IEnumerable<SessionChangeModel>> GetAllAsync();
    Task<SessionChangeModel?> GetByIdAsync(string id);

    Task ApproveRoomChangeAsync(string sessionChangeId, string roomId);

    Task RejectAsync(string sessionChangeId, string rejectionReason);

    Task ApproveRecoveryAsync(string sessionChangeId);

    Task CounterProposeAsync(
        string sessionChangeId,
        DateTime date,
        TimeSpan startTime,
        TimeSpan endTime,
        string roomId);
}