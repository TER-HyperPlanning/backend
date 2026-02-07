using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class UnavailableDay
{
    public string UnavailableDayId { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string UnavailableDayTypeId { get; set; } = null!;

    public virtual UnavailableDayType UnavailableDayType { get; set; } = null!;
}
