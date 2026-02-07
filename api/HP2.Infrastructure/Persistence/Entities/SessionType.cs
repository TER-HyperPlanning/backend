using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class SessionType
{
    public string SessionTypeId { get; set; } = null!;

    public string Label { get; set; } = null!;

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
