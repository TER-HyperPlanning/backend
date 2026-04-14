namespace HP2.Application.Contracts;

public interface INotificationService
{
    /// <summary>Envoie une notification à une liste d'utilisateurs (DB + SignalR)</summary>
    Task NotifyUsersAsync(IEnumerable<string> userIds, string title, string message, string type = "General", string? relatedId = null);

    /// <summary>Récupère toutes les notifications d'un utilisateur (lues et non lues)</summary>
    Task<IEnumerable<NotificationDto>> GetNotificationsAsync(string userId);

    /// <summary>Retourne le nombre de notifications non lues</summary>
    Task<int> GetUnreadCountAsync(string userId);

    /// <summary>Marque une notification précise comme lue</summary>
    Task MarkAsReadAsync(string userId, string notificationId);

    /// <summary>Marque toutes les notifications d'un utilisateur comme lues</summary>
    Task MarkAllAsReadAsync(string userId);

    /// <summary>Supprime une notification pour un utilisateur</summary>
    Task DeleteAsync(string userId, string notificationId);
}

public record NotificationDto(
    string Id,
    string Title,
    string Message,
    string Type,
    string? RelatedId,
    DateTime CreatedAt,
    bool IsRead
);
