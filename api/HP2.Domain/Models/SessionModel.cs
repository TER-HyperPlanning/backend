using HP2.Domain.Common;
using HP2.Domain.Enums;

namespace HP2.Domain.Models;

public class SessionModel : BaseModel
{
    public string Id { get; set; } = string.Empty;

    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public SessionMode Mode { get; set; }
    public string SessionTypeId { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public string SessionStatusId { get; set; } = string.Empty;
    public string RoomId { get; set; } = string.Empty;

    public string? Description { get; set; }

    // --- Propriétés existantes pour la lecture ---
    public string? SessionTypeLabel { get; set; }
    public string? SessionStatusLabel { get; set; }
    public string? RoomNumber { get; set; }
    public string? CourseName { get; set; }

    // --- NOUVELLES PROPRIÉTÉS AJOUTÉES (Pour le filtre Planning) ---
    
    // Correspond au track_id (Filière)
    public string? TrackId { get; set; } 
    
    // Correspond au name dans la table Track (ex: "M1 Ingénierie...")
    // Utile pour filtrer le "Niveau" avec .StartsWith("M1")
    public string? TrackName { get; set; }

    // Correspond au program_id (Formation)
    public string? ProgramId { get; set; }

    // Optionnel : pour afficher le nom de la formation (ex: "Informatique")
    public string? ProgramName { get; set; }
}