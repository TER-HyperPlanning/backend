using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Course
{
    public string CourseId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<Assign> Assigns { get; set; } = new List<Assign>();

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();

    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
}
