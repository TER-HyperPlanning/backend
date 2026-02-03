using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class MatiereTest
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<SeanceTest> Seances { get; set; } = new List<SeanceTest>();
}
