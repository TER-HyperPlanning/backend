using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class SeanceTest
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Type { get; set; }

    public int? IdMatiere { get; set; }

    public virtual MatiereTest? IdMatiereNavigation { get; set; }
}
