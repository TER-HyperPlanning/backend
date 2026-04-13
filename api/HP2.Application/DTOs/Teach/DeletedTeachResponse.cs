namespace HP2.Application.DTOs.Teach;

public class DeletedTeachResponse
{
    public string SessionId { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
    public DateTime? DeletedAt { get; set; }
}
