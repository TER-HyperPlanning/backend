using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Assign
{
    public string TrackId { get; set; } = null!;

    public string CourseId { get; set; } = null!;

    public int HourlyVolume { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Track Track { get; set; } = null!;

    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
}
