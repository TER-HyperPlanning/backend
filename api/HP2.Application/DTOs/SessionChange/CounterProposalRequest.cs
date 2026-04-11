namespace HP2.Application.DTOs.SessionChange;

public class CounterProposalRequest
{
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string RoomId { get; set; } = string.Empty;
}