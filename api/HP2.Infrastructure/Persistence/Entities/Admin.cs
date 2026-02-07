using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Admin
{
    public string UserId { get; set; } = null!;

    public virtual ICollection<SessionChange> SessionChanges { get; set; } = new List<SessionChange>();

    public virtual User User { get; set; } = null!;
}
