using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string UserRoleId { get; set; } = null!;

    public virtual Admin? Admin { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }

    public virtual UserRole UserRole { get; set; } = null!;

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
