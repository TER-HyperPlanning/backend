using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class TeacherTitle
{
    public string TeacherTitleId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
