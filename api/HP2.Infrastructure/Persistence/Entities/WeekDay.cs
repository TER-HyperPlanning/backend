using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class WeekDay
{
    public string WeekdayId { get; set; } = null!;

    public byte OrderIndex { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
}
