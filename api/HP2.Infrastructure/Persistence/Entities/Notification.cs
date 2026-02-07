using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Notification
{
    public string NotificationId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
