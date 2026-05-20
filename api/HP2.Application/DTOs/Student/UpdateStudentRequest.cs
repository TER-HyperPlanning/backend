using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Student;

public class UpdateStudentRequest
{
    [Required(ErrorMessage = "L'email est requis.")]
    [EmailAddress(ErrorMessage = "Format d'email invalide.")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@etud\.fr$", ErrorMessage = "L'email doit obligatoirement se terminer par @etud.fr")]
    [StringLength(100, ErrorMessage = "L'email ne peut pas dépasser 100 caractères.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le prénom est requis.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Le prénom doit faire entre 2 et 50 caractères.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le nom est requis.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit faire entre 2 et 50 caractères.")]
    public string LastName { get; set; } = string.Empty;

    [Phone(ErrorMessage = "Format de téléphone invalide.")]
    [RegularExpression(@"^0[67][0-9]{8}$", ErrorMessage = "Le numéro de téléphone doit commencer par 06 ou 07 et contenir 10 chiffres au total.")]
    [StringLength(20, ErrorMessage = "Le numéro ne peut pas dépasser 20 caractères.")]
    public string? Phone { get; set; }

    public string? GroupId { get; set; }
}
