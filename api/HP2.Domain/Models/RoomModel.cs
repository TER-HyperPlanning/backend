using HP2.Domain.Common;
using HP2.Domain.Enums;

public class RoomModel : BaseModel
{

    public string RoomId { get; set; } = null!;
    public string RoomNumber { get; set; } = null!;

    public bool? IsAvailable { get; set; } = true;

    public int Capacity { get; set; }

    public string BuildingId { get; set; } = null!;

    // public string RoomTypeId { get; set; } = null!;
    public RoomTypeEnum Type { get; set; }


}
