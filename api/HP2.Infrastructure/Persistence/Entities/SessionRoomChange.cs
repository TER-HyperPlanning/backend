using System;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class SessionRoomChange
{
    public string SessionRoomChangeId { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public string Reason { get; set; } = null!;

    public string TeacherId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string ChangeStatusId { get; set; } = null!;

    public string? ApprovedRoomId { get; set; }

    public string? RejectionReason { get; set; }

    public virtual Teacher Teacher { get; set; } = null!;

    public virtual Session Session { get; set; } = null!;

    public virtual ChangeStatus ChangeStatus { get; set; } = null!;

    public virtual Room? ApprovedRoom { get; set; }
}
