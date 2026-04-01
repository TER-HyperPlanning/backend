namespace HP2.Application.DTOs.Teach;

public class UpdateTeachRequest
{
    public string CurrentSessionId { get; set; } = string.Empty;
    public string CurrentTeacherId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
}
