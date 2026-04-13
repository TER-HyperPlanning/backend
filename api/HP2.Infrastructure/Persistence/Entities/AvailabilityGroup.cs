using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class AvailabilityGroup
{
    public string AvailabilityGroupId { get; set; } = null!;

    public string TeacherId { get; set; } = null!;

    public int NumberOfAvailableDays { get; set; }

    public virtual Teacher Teacher { get; set; } = null!;

    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
}
