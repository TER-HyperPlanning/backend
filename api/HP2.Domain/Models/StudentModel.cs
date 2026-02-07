using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class StudentModel : UserModel
{
    public string? GroupId { get; set; }
}
