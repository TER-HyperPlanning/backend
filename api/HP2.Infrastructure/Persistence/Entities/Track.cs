using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Track
{
    public string TrackId { get; set; } = null!;

    public DateTime? DeletedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string Name { get; set; } = null!;

    public string TeacherId { get; set; } = null!;

    public string ProgramId { get; set; } = null!;

    public virtual ICollection<Assign> Assigns { get; set; } = new List<Assign>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual Program Program { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;

    public string? Description { get; set; }

    public string? Lieu { get; set; }
}
