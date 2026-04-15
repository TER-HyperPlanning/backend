using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class RoomModel : BaseModel
{
    public string RoomId { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;
    public int Capacity { get; set; }
    public string BuildingId { get; set; } = string.Empty;
    public string RoomTypeId { get; set; } = string.Empty;
}