namespace HP2.Application.DTOs.Session;
public class SessionResponse
{
    public string Id { get; set; } = string.Empty;

    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public SessionMode Mode { get; set; }

    public ReferenceResponse Type { get; set; } = new();
    public ReferenceResponse Status { get; set; } = new();

    public string Room { get; set; } = string.Empty; 
}