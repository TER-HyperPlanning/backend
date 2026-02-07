namespace HP2.Domain.Models;

public class SessionModel
{
    public string Id { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public string? Description { get; set; }
}
