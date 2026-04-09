using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class CourseModel : BaseModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
}