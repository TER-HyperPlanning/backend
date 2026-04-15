using HP2.API.Hubs;
using HP2.Application.Contracts;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace HP2.API.Services;

public class NotificationService : INotificationService
{
    private readonly TerHyperplanningContext _dbContext;
    private readonly IHubContext<NotificationHub> _hubContext;
    private readonly ILogger<NotificationService> _logger;

    public NotificationService(TerHyperplanningContext dbContext, IHubContext<NotificationHub> hubContext, ILogger<NotificationService> logger)
    {
        _dbContext = dbContext;
        _hubContext = hubContext;
        _logger = logger;
    }

    public async Task NotifyUsersAsync(IEnumerable<string> userIds, string title, string message, string type = "General", string? relatedId = null)
    {
        // 1. Créer la notification en base
        var notification = new Notification
        {
            NotificationId = Guid.NewGuid().ToString(),
            Title = title,
            Message = message,
            Type = type,
            RelatedId = relatedId,
            CreatedAt = DateTime.UtcNow
        };

        await _dbContext.Notifications.AddAsync(notification);

        // 2. Créer les liens UserNotification (un par destinataire)
        var userNotifications = userIds.Select(userId => new UserNotification
        {
            UserId = userId,
            NotificationId = notification.NotificationId,
            IsRead = false
        }).ToList();

        await _dbContext.UserNotifications.AddRangeAsync(userNotifications);
        await _dbContext.SaveChangesAsync();

        // 3. Envoyer en temps réel via SignalR à chaque utilisateur connecté
        var payload = new
        {
            id = notification.NotificationId,
            title = notification.Title,
            message = notification.Message,
            type = notification.Type,
            relatedId = notification.RelatedId,
            createdAt = notification.CreatedAt,
            isRead = false
        };

        foreach (var userId in userIds)
        {
            var normalizedId = userId.ToLower();
            await _hubContext.Clients.Group($"user-{normalizedId}")
                .SendAsync("ReceiveNotification", payload);
        }
    }

    public async Task<IEnumerable<NotificationDto>> GetNotificationsAsync(string userId)
    {
        return await _dbContext.UserNotifications
            .Where(un => un.UserId == userId)
            .Include(un => un.Notification)
            .OrderByDescending(un => un.Notification.CreatedAt)
            .Select(un => new NotificationDto(
                un.Notification.NotificationId,
                un.Notification.Title,
                un.Notification.Message,
                un.Notification.Type,
                un.Notification.RelatedId,
                un.Notification.CreatedAt,
                un.IsRead
            ))
            .ToListAsync();
    }

    public async Task<int> GetUnreadCountAsync(string userId)
    {
        return await _dbContext.UserNotifications
            .Where(un => un.UserId == userId && !un.IsRead)
            .CountAsync();
    }

    public async Task MarkAsReadAsync(string userId, string notificationId)
    {
        var userNotif = await _dbContext.UserNotifications
            .FirstOrDefaultAsync(un => un.UserId == userId && un.NotificationId == notificationId);

        if (userNotif != null)
        {
            userNotif.IsRead = true;
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task MarkAllAsReadAsync(string userId)
    {
        var unreadNotifs = await _dbContext.UserNotifications
            .Where(un => un.UserId == userId && !un.IsRead)
            .ToListAsync();

        foreach (var notif in unreadNotifs)
        {
            notif.IsRead = true;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(string userId, string notificationId)
    {
        var userNotif = await _dbContext.UserNotifications
            .FirstOrDefaultAsync(un => un.UserId == userId && un.NotificationId == notificationId);

        if (userNotif != null)
        {
            _dbContext.UserNotifications.Remove(userNotif);
            await _dbContext.SaveChangesAsync();
        }
    }
}
