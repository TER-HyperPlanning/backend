using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Domain.Enums;

namespace HP2.Application;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;
    private readonly IUserRepository _userRepository;

    public TeacherService(ITeacherRepository teacherRepository, IUserRepository userRepository)
    {
        _teacherRepository = teacherRepository;
        _userRepository = userRepository;
    }

    // ─── US12 : Ajouter un enseignant ────────────────────────────────────────

    public async Task<TeacherModel> CreateTeacherAsync(TeacherModel teacher)
    {
        // Unicité email (US12)
        var existing = await _teacherRepository.GetByEmailAsync(teacher.Email);
        if (existing != null)
            throw new InvalidOperationException("Un enseignant avec cet email existe déjà.");

        teacher.Role = UserRole.TEACHER;
        teacher.CreatedAt = DateTime.UtcNow;
        teacher.UpdatedAt = DateTime.UtcNow;

        return await _teacherRepository.AddAsync(teacher);
    }

    // ─── US11 : Consulter les enseignants ────────────────────────────────────

    public async Task<TeacherModel?> GetTeacherByIdAsync(string id)
    {
        return await _teacherRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<TeacherModel>> GetAllTeachersAsync()
    {
        return await _teacherRepository.GetAllAsync();
    }

    /// <summary>US11 — Recherche par nom/prénom/email + filtre statut titulaire/contractuel.</summary>
    public async Task<IEnumerable<TeacherModel>> GetFilteredTeachersAsync(string? search, string? titleFilter)
    {
        return await _teacherRepository.GetFilteredAsync(search, titleFilter);
    }

    // ─── US14 : Modifier un enseignant ───────────────────────────────────────

    public async Task UpdateTeacherAsync(TeacherModel teacher)
    {
        // Unicité email en excluant l'enseignant courant (US14)
        var existing = await _teacherRepository.GetByEmailAsync(teacher.Email);
        if (existing != null && existing.Id != teacher.Id)
            throw new InvalidOperationException("Cet email est déjà utilisé par un autre enseignant.");

        teacher.UpdatedAt = DateTime.UtcNow;
        await _teacherRepository.UpdateAsync(teacher);
    }

    // ─── US15 : Supprimer un enseignant ──────────────────────────────────────

    public async Task DeleteTeacherAsync(string id)
    {
        await _teacherRepository.DeleteAsync(id);
    }

    public async Task<bool> HasAvailabilitiesAsync(string id)
    {
        return await _teacherRepository.HasAvailabilitiesAsync(id);
    }

    /// <summary>US15 — Bloque la suppression si l'enseignant est dans une session future.</summary>
    public async Task<bool> HasFutureSessionsAsync(string id)
    {
        return await _teacherRepository.HasFutureSessionsAsync(id);
    }
}
