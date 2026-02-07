using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class TeacherModel : UserModel
{
    public string Matricule { get; set; } = string.Empty;
    public string? TitleId { get; set; }
}
