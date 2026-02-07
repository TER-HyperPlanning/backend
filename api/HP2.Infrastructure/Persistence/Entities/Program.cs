using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Program
{
    public string ProgramId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Field { get; set; } = null!;

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
