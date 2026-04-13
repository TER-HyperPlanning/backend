namespace HP2.Application.DTOs.SessionChange;

public class AvailableSlotResponse
{
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public List<AvailableRoomResponse> AvailableRooms { get; set; } = new();
}
