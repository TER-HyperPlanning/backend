using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class ChangeStatus
{
    public string ChangeStatusId { get; set; } = null!;

    public string Label { get; set; } = null!;

    public virtual ICollection<SessionChange> SessionChanges { get; set; } = new List<SessionChange>();
}
