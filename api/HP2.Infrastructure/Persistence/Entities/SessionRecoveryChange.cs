using System;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class SessionRecoveryChange
{
    public string SessionRecoveryChangeId { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public string Reason { get; set; } = null!;

    public string TeacherId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string ChangeStatusId { get; set; } = null!;

    public DateTime? ProposedDate { get; set; }

    public TimeSpan? ProposedStartTime { get; set; }

    public TimeSpan? ProposedEndTime { get; set; }

    public string? ProposedRoomId { get; set; }

    public DateTime? CounterProposalDate { get; set; }

    public TimeSpan? CounterProposalStartTime { get; set; }

    public TimeSpan? CounterProposalEndTime { get; set; }

    public string? CounterProposalRoomId { get; set; }

    public string? RejectionReason { get; set; }

    public virtual Teacher Teacher { get; set; } = null!;

    public virtual Session Session { get; set; } = null!;

    public virtual ChangeStatus ChangeStatus { get; set; } = null!;

    public virtual Room? ProposedRoom { get; set; }

    public virtual Room? CounterProposalRoom { get; set; }
}
