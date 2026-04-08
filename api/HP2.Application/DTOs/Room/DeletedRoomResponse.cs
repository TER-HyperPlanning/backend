using HP2.Domain.Enums;

namespace HP2.Application.DTOs.RoomDtos;

public class DeletedRoomResponse
{
    public string RoomId { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public bool? IsAvailable { get; set; }
    public int Capacity { get; set; }
    public string BuildingId { get; set; } = string.Empty;
    public RoomTypeEnum Type { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
}
