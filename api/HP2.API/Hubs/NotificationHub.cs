using HP2.Application.DTOs.Common;
using Microsoft.AspNetCore.SignalR;

namespace HP2.API.Hubs;

/// <summary>
/// Hub SignalR pour les notifications en temps réel.
/// Les clients se connectent à /hubs/notifications et sont automatiquement
/// joints à leur groupe personnel (ex: "user-20260001") à la connexion.
/// </summary>
public class NotificationHub : Hub
{
    private readonly ILogger<NotificationHub> _logger;

    public NotificationHub(ILogger<NotificationHub> logger)
    {
        _logger = logger;
    }

    public override async Task OnConnectedAsync()
    {
        var userId = Context.User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value
                     ?? Context.User?.FindFirst("sub")?.Value;

        if (!string.IsNullOrEmpty(userId))
        {
            userId = userId.ToLower();
            await Groups.AddToGroupAsync(Context.ConnectionId, $"user-{userId}");
        }

        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var userId = Context.User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value
                     ?? Context.User?.FindFirst("sub")?.Value
                     ?? Context.User?.FindFirst("UserId")?.Value;

        if (!string.IsNullOrEmpty(userId))
        {
            userId = userId.ToLower();
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"user-{userId}");
        }

        await base.OnDisconnectedAsync(exception);
    }
}
