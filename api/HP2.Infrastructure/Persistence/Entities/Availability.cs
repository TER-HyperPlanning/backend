using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Availability
{
    public string AvailabilityId { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string WeekdayId { get; set; } = null!;

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string TeacherId { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;

    public virtual WeekDay Weekday { get; set; } = null!;
}
