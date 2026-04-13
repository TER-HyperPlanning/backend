using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class NotificationsController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationsController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    /// <summary>Récupère toutes les notifications de l'utilisateur connecté</summary>
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<NotificationDto>>>> GetAll()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? User.FindFirst("UserId")?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<IEnumerable<NotificationDto>>.Fail("Utilisateur non identifié."));

        var notifications = await _notificationService.GetNotificationsAsync(userId);
        return Ok(ApiResponse<IEnumerable<NotificationDto>>.Success(notifications));
    }

    /// <summary>Retourne le nombre de notifications non lues (pour le badge)</summary>
    [HttpGet("unread-count")]
    public async Task<ActionResult<ApiResponse<int>>> GetUnreadCount()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? User.FindFirst("UserId")?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<int>.Fail("Utilisateur non identifié."));

        var count = await _notificationService.GetUnreadCountAsync(userId);
        return Ok(ApiResponse<int>.Success(count));
    }

    /// <summary>Marque une notification précise comme lue</summary>
    [HttpPatch("{id}/read")]
    public async Task<ActionResult<ApiResponse<string>>> MarkAsRead(string id)
    {
        var userId = User.FindFirst("UserId")?.Value ?? User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.Fail("Utilisateur non identifié."));

        await _notificationService.MarkAsReadAsync(userId, id);
        return Ok(ApiResponse<string>.Success("Notification marquée comme lue."));
    }

    /// <summary>Marque toutes les notifications comme lues d'un coup</summary>
    [HttpPatch("read-all")]
    public async Task<ActionResult<ApiResponse<string>>> MarkAllAsRead()
    {
        var userId = User.FindFirst("UserId")?.Value ?? User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.Fail("Utilisateur non identifié."));

        await _notificationService.MarkAllAsReadAsync(userId);
        return Ok(ApiResponse<string>.Success("Toutes les notifications sont marquées comme lues."));
    }

    /// <summary>Supprime une notification de l'historique de l'utilisateur</summary>
    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var userId = User.FindFirst("UserId")?.Value ?? User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(ApiResponse<string>.Fail("Utilisateur non identifié."));

        await _notificationService.DeleteAsync(userId, id);
        return Ok(ApiResponse<string>.Success("Notification supprimée."));
    }
}
