using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Group
{
    public string GroupId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string AcademicYear { get; set; } = null!;

    public string TrackId { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual Track Track { get; set; } = null!;


    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
    
    public bool IsActive { get; set; } = true;
}
