using HP2.Domain.Models;
using HP2.Domain.Enums;
namespace HP2.Application.DTOs.Session;

public class SessionResponse
{
    public string Id { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public SessionMode Mode { get; set; }
    public SessionTypeEnum Type { get; set; }
    public SessionStatusEnum Status { get; set; }
    public string Room { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Course { get; set; } = string.Empty;
    public DateTime? DeletedAt { get; set; }
}