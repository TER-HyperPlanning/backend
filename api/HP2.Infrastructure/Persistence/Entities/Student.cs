using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Student
{
    public string UserId { get; set; } = null!;

    public string? GroupId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual User User { get; set; } = null!;
}
