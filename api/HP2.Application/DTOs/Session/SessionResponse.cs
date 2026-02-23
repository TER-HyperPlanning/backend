using HP2.Domain.Models;
using HP2.Domain.Enums;
namespace HP2.Application.DTOs.Session;

public class SessionResponse
{
    public string Id { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public SessionMode Mode { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Room { get; set; } = string.Empty;
    public string? Description { get; set; }
}