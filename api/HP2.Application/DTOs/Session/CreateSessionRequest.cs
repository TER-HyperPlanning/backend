using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Session;

public class CreateSessionRequest
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public SessionMode Mode { get; set; }
    public SessionTypeEnum SessionType { get; set; }
    public string CourseId { get; set; } = string.Empty;
    public SessionStatusEnum SessionStatus { get; set; }
    public string RoomId { get; set; } = string.Empty;
    public string? Description { get; set; }
}