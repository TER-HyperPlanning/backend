// api/HP2.Domain/Models/SessionRecoveryChangeModel.cs
using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class SessionRecoveryChangeModel : BaseModel
{
    public string Id { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public string Reason { get; set; } = string.Empty;

    public string TeacherId { get; set; } = string.Empty;

    public string SessionId { get; set; } = string.Empty;

    public string ChangeStatusId { get; set; } = string.Empty;

    public DateTime? ProposedDate { get; set; }

    public TimeSpan? ProposedStartTime { get; set; }

    public TimeSpan? ProposedEndTime { get; set; }

    public string? ProposedRoomId { get; set; }

    public DateTime? CounterProposalDate { get; set; }

    public TimeSpan? CounterProposalStartTime { get; set; }

    public TimeSpan? CounterProposalEndTime { get; set; }

    public string? CounterProposalRoomId { get; set; }

    public string? RejectionReason { get; set; }
}