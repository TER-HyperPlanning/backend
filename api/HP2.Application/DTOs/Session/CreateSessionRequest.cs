namespace HP2.Application.DTOs.Session;

public class CreateSessionRequest
{
    public string Id { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public SessionMode Mode { get; set; }
    public string SessionTypeId { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public string SessionStatusId { get; set; } = string.Empty;
    public string RoomId { get; set; } = string.Empty;

    public string? Description { get; set; }
}