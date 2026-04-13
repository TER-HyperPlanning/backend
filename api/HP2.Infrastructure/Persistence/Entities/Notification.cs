using System;
using System.Collections.Generic;

namespace HP2.Infrastructure.Persistence.Entities;

public partial class Notification
{
    public string NotificationId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    /// <summary>Type de notification : SessionUpdate, GroupChange, General</summary>
    public string? Type { get; set; }

    /// <summary>ID de la ressource liée (ex: ID de la séance modifiée)</summary>
    public string? RelatedId { get; set; }

    public DateTime CreatedAt { get; set; }

    /// <summary>Relation Many-to-Many via la table Receive</summary>
    public virtual ICollection<User> Users { get; set; } = new List<User>();

    /// <summary>Table pivot enrichie pour accéder à IsRead par utilisateur</summary>
    public virtual ICollection<UserNotification> UserNotifications { get; set; } = new List<UserNotification>();
}
