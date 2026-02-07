using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class SessionChange
{
    public string SessionChangeId { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public string Reason { get; set; } = null!;

    public string TeacherId { get; set; } = null!;

    public string AdminId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string ChangeStatusId { get; set; } = null!;

    public virtual Admin Admin { get; set; } = null!;

    public virtual ChangeStatus ChangeStatus { get; set; } = null!;

    public virtual Session Session { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
