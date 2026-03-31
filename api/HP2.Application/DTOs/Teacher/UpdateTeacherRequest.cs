using System.ComponentModel.DataAnnotations;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Teacher;

public class UpdateTeacherRequest
{
    /// <summary>Nom — obligatoire, max 100 caractères (US14).</summary>
    [Required(ErrorMessage = "Le nom est obligatoire.")]
    [MaxLength(100, ErrorMessage = "Le nom ne peut pas dépasser 100 caractères.")]
    public string LastName { get; set; } = string.Empty;

    /// <summary>Prénom — obligatoire, max 100 caractères (US14).</summary>
    [Required(ErrorMessage = "Le prénom est obligatoire.")]
    [MaxLength(100, ErrorMessage = "Le prénom ne peut pas dépasser 100 caractères.")]
    public string FirstName { get; set; } = string.Empty;

    /// <summary>Email — obligatoire (US14).</summary>
    [Required(ErrorMessage = "L'email est obligatoire.")]
    [EmailAddress(ErrorMessage = "L'email n'est pas valide.")]
    public string Email { get; set; } = string.Empty;

    /// <summary>Téléphone — obligatoire, exactement 10 chiffres (US14).</summary>
    [Required(ErrorMessage = "Le téléphone est obligatoire.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Le téléphone doit contenir exactement 10 chiffres.")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>Matricule de l'enseignant.</summary>
    [Required(ErrorMessage = "Le matricule est obligatoire.")]
    public string Matricule { get; set; } = string.Empty;

    /// <summary>Statut : TITULAIRE / CONTRACTUEL (US14).</summary>
    [Required(ErrorMessage = "Le statut est obligatoire.")]
    public TeacherTitle Title { get; set; }
}
