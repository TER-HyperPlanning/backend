namespace HP2.Application.DTOs.SessionChange;

public class AvailableRoomResponse
{
    public string RoomId { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public string BuildingName { get; set; } = string.Empty;
}
