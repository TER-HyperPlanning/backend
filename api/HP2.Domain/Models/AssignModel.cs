using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class AssignModel : BaseModel
{
    public string TrackId { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public float Coefficient { get; set; }
    public int HourlyVolumeCM { get; set; }
    public int HourlyVolumeTD { get; set; }
    public int HourlyVolumeTP { get; set; }
}
