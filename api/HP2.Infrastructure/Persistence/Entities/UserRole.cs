using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class UserRole
{
    public string UserRoleId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
