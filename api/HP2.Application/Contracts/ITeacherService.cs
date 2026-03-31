using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ITeacherService
{
    Task<TeacherModel> CreateTeacherAsync(TeacherModel teacher);
    Task<TeacherModel?> GetTeacherByIdAsync(string id);
    Task<IEnumerable<TeacherModel>> GetAllTeachersAsync();

    /// <summary>US11 — Recherche/filtre côté service.</summary>
    Task<IEnumerable<TeacherModel>> GetFilteredTeachersAsync(string? search, string? titleFilter);

    Task UpdateTeacherAsync(TeacherModel teacher);
    Task DeleteTeacherAsync(string id);

    /// <summary>US15 — Vérifie disponibilités.</summary>
    Task<bool> HasAvailabilitiesAsync(string id);

    /// <summary>US15 — Vérifie sessions futures (blocage suppression).</summary>
    Task<bool> HasFutureSessionsAsync(string id);
}
