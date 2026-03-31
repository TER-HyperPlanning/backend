using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Teacher;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    public TeachersController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    // ─── US11 : Consulter la liste ───────────────────────────────────────────

    /// <summary>
    /// Retourne tous les enseignants.
    /// Chargement automatique à l'ouverture de la page (US11 — critère 2).
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeacherResponse>>>> GetAll()
    {
        var teachers = await _teacherService.GetAllTeachersAsync();
        return Ok(ApiResponse<IEnumerable<TeacherResponse>>.Success(teachers.Select(ToResponse)));
    }

    /// <summary>
    /// US11 — Recherche et filtrage :
    ///   ?search=...  → filtre sur nom, prénom, email (critère 3)
    ///   ?title=...   → filtre sur statut : TITULAIRE | CONTRACTUEL (critère 4)
    /// Les deux paramètres sont cumulables.
    /// </summary>
    [HttpGet("search")]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeacherResponse>>>> Search(
        [FromQuery] string? search,
        [FromQuery] string? title)
    {
        var teachers = await _teacherService.GetFilteredTeachersAsync(search, title);
        return Ok(ApiResponse<IEnumerable<TeacherResponse>>.Success(teachers.Select(ToResponse)));
    }

    /// <summary>
    /// Retourne un enseignant par son identifiant.
    /// Utilisé en interne pour le formulaire prérempli (US14 — critère 2).
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<TeacherResponse>>> Get(string id)
    {
        var teacher = await _teacherService.GetTeacherByIdAsync(id);
        if (teacher == null)
            return NotFound(ApiResponse<TeacherResponse>.Fail($"Enseignant avec l'ID {id} introuvable."));

        return Ok(ApiResponse<TeacherResponse>.Success(ToResponse(teacher)));
    }

    // ─── US12 : Ajouter un enseignant ────────────────────────────────────────

    /// <summary>
    /// Crée un nouvel enseignant (US12).
    /// Retourne le message "Enseignant ajouté" en cas de succès (critère 3).
    /// En cas d'erreur de validation : message explicite (critère 3).
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ApiResponse<TeacherResponse>>> Create([FromBody] CreateTeacherRequest request)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
            return BadRequest(ApiResponse<TeacherResponse>.Fail(string.Join(" | ", errors)));
        }

        try
        {
            var teacher = new TeacherModel
            {
                Email = request.Email,
                Password = request.Password,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone,
                Matricule = request.Matricule,
                Title = request.Title,
            };

            var created = await _teacherService.CreateTeacherAsync(teacher);
            var response = ToResponse(created);

            return CreatedAtAction(
                nameof(Get),
                new { id = response.Id },
                ApiResponse<TeacherResponse>.Success(response, "Enseignant ajouté"));
        }
        catch (InvalidOperationException ex)
        {
            // Email déjà utilisé → message explicite (US12 — critère 3)
            return Conflict(ApiResponse<TeacherResponse>.Fail(ex.Message));
        }
    }

    // ─── US14 : Modifier un enseignant ───────────────────────────────────────

    /// <summary>
    /// Met à jour un enseignant existant (US14).
    /// Validation identique à la création (critère 4).
    /// Retourne "Enseignant modifié" en cas de succès (critère 5).
    /// </summary>
    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<TeacherResponse>>> Update(
        string id,
        [FromBody] UpdateTeacherRequest request)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
            return BadRequest(ApiResponse<TeacherResponse>.Fail(string.Join(" | ", errors)));
        }

        var existing = await _teacherService.GetTeacherByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<TeacherResponse>.Fail($"Enseignant avec l'ID {id} introuvable."));

        try
        {
            existing.Email = request.Email;
            existing.FirstName = request.FirstName;
            existing.LastName = request.LastName;
            existing.Phone = request.Phone;
            existing.Matricule = request.Matricule;
            existing.Title = request.Title;

            await _teacherService.UpdateTeacherAsync(existing);
            return Ok(ApiResponse<TeacherResponse>.Success(ToResponse(existing), "Enseignant modifié"));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<TeacherResponse>.Fail(ex.Message));
        }
    }

    // ─── US15 : Supprimer un enseignant ──────────────────────────────────────

    /// <summary>
    /// Supprime un enseignant (US15).
    /// Bloqué si l'enseignant est affecté à une session future (critère 2).
    /// Retourne "Enseignant supprimé" en cas de succès (critère 3).
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _teacherService.GetTeacherByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Enseignant avec l'ID {id} introuvable."));

        // US15 critère 2 — Blocage si sessions futures
        var hasFutureSessions = await _teacherService.HasFutureSessionsAsync(id);
        if (hasFutureSessions)
            return BadRequest(ApiResponse<string>.Fail(
                "Impossible de supprimer cet enseignant : il est affecté à des cours à venir."));

        await _teacherService.DeleteTeacherAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Enseignant supprimé"));
    }

    // ─── Mapping privé ───────────────────────────────────────────────────────

    private static TeacherResponse ToResponse(TeacherModel m) => new()
    {
        Id = m.Id,
        Email = m.Email,
        FirstName = m.FirstName,
        LastName = m.LastName,
        Phone = m.Phone,
        Matricule = m.Matricule,
        Title = m.Title,
        Role = m.Role,
        CreatedAt = m.CreatedAt,
        UpdatedAt = m.UpdatedAt,
    };
}
