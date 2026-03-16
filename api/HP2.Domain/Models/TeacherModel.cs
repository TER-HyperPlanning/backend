using HP2.Domain.Common;
using HP2.Domain.Enums;

namespace HP2.Domain.Models;

public class TeacherModel : UserModel
{
    public string Matricule { get; set; } = string.Empty;
    public TeacherTitle? Title { get; set; }
}
