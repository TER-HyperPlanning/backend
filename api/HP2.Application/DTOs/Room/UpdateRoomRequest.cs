using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Room;

public class UpdateRoomRequest
{
    [Required(ErrorMessage = "Le numéro de salle est obligatoire.")]
    [MaxLength(50, ErrorMessage = "Le numéro de salle ne doit pas dépasser 50 caractères.")]
    public string RoomNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "La capacité est obligatoire.")]
    [Range(1, int.MaxValue, ErrorMessage = "La capacité doit être un entier supérieur ou égal à 1.")]
    public int Capacity { get; set; }

    [Required(ErrorMessage = "Le bâtiment est obligatoire.")]
    public string BuildingId { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le type de salle est obligatoire.")]
    public string RoomTypeId { get; set; } = string.Empty;

    public bool IsAvailable { get; set; }
}
