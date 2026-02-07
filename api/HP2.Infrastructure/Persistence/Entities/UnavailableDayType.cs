using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class UnavailableDayType
{
    public string UnavailableDayTypeId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<UnavailableDay> UnavailableDays { get; set; } = new List<UnavailableDay>();
}
