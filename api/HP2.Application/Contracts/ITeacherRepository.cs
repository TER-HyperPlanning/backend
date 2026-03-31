using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ITeacherRepository : IAsyncRepository<TeacherModel>
{
    Task<TeacherModel?> GetByEmailAsync(string email);
    Task<TeacherModel?> GetByMatriculeAsync(string matricule);

    /// <summary>US15 — Vérifie si l'enseignant a des disponibilités enregistrées.</summary>
    Task<bool> HasAvailabilitiesAsync(string id);

    /// <summary>US15 — Bloque suppression si l'enseignant est dans une session future.</summary>
    Task<bool> HasFutureSessionsAsync(string id);

    /// <summary>US11 — Recherche par nom/prénom/email + filtre par statut.</summary>
    Task<IReadOnlyList<TeacherModel>> GetFilteredAsync(string? search, string? titleFilter);
}
