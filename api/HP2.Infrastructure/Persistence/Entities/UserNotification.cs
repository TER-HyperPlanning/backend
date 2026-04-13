namespace HP2.Infrastructure.Persistence.Entities;

/// <summary>
/// Table pivot entre un utilisateur et une notification.
/// Gère l'état "IsRead" par utilisateur.
/// </summary>
public partial class UserNotification
{
    public string UserId { get; set; } = null!;

    public string NotificationId { get; set; } = null!;

    public bool IsRead { get; set; } = false;

    public virtual User User { get; set; } = null!;

    public virtual Notification Notification { get; set; } = null!;
}
