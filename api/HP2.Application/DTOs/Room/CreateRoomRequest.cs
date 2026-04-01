namespace HP2.Application.DTOs.Room;

public class CreateRoomRequest
{
    public string RoomNumber { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public string BuildingId { get; set; } = string.Empty;
    public string RoomTypeId { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;
}