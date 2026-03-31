using AutoMapper;
using HP2.Application.Contracts;
using HP2.Infrastructure.Persistence;
using HP2.Domain.Models;
using HP2.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.Infrastructure.Repositories;

public class TeacherRepository : RepositoryBase<TeacherModel>, ITeacherRepository
{
    public TeacherRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    // ─── Lecture ─────────────────────────────────────────────────────────────

    public override async Task<IReadOnlyList<TeacherModel>> GetAllAsync()
    {
        var teachers = await _dbContext.Teachers
            .Include(t => t.User)
                .ThenInclude(u => u.UserRole)
            .Include(t => t.TeacherTitle)
            .ToListAsync();

        return _mapper.Map<List<TeacherModel>>(teachers);
    }

    public override async Task<TeacherModel?> GetByIdAsync(string id)
    {
        var teacher = await _dbContext.Teachers
            .Include(t => t.User)
                .ThenInclude(u => u.UserRole)
            .Include(t => t.TeacherTitle)
            .FirstOrDefaultAsync(t => t.UserId == id);

        return teacher != null ? _mapper.Map<TeacherModel>(teacher) : null;
    }

    public async Task<TeacherModel?> GetByEmailAsync(string email)
    {
        var teacher = await _dbContext.Teachers
            .Include(t => t.User)
                .ThenInclude(u => u.UserRole)
            .Include(t => t.TeacherTitle)
            .FirstOrDefaultAsync(t => t.User != null && t.User.Email == email);

        return teacher != null ? _mapper.Map<TeacherModel>(teacher) : null;
    }

    public async Task<TeacherModel?> GetByMatriculeAsync(string matricule)
    {
        var teacher = await _dbContext.Teachers
            .Include(t => t.User)
                .ThenInclude(u => u.UserRole)
            .Include(t => t.TeacherTitle)
            .FirstOrDefaultAsync(t => t.RegistrationNumber == matricule);

        return teacher != null ? _mapper.Map<TeacherModel>(teacher) : null;
    }

    // ─── US11 : Recherche + filtre statut ────────────────────────────────────

    /// <summary>
    /// Filtre par nom/prénom/email (search) et/ou par statut (titleFilter = "TITULAIRE" | "CONTRACTUEL").
    /// </summary>
    public async Task<IReadOnlyList<TeacherModel>> GetFilteredAsync(string? search, string? titleFilter)
    {
        var query = _dbContext.Teachers
            .Include(t => t.User)
                .ThenInclude(u => u.UserRole)
            .Include(t => t.TeacherTitle)
            .AsQueryable();

        // Filtre texte : nom, prénom ou email
        if (!string.IsNullOrWhiteSpace(search))
        {
            var term = search.Trim().ToLower();
            query = query.Where(t =>
                t.User != null && (
                    t.User.LastName.ToLower().Contains(term) ||
                    t.User.FirstName.ToLower().Contains(term) ||
                    t.User.Email.ToLower().Contains(term)
                ));
        }

        // Filtre statut : TITULAIRE / CONTRACTUEL
        if (!string.IsNullOrWhiteSpace(titleFilter))
        {
            var titleNorm = titleFilter.Trim().ToUpper();
            query = query.Where(t =>
                t.TeacherTitle != null &&
                t.TeacherTitle.Name.ToUpper() == titleNorm);
        }

        var teachers = await query.ToListAsync();
        return _mapper.Map<List<TeacherModel>>(teachers);
    }

    // ─── US12 : Création ─────────────────────────────────────────────────────

    public override async Task<TeacherModel> AddAsync(TeacherModel teacherModel)
    {
        var teacherRole = await _dbContext.UserRoles
            .FirstOrDefaultAsync(r => r.Name == "TEACHER");

        if (teacherRole == null)
            throw new InvalidOperationException("Le rôle TEACHER est introuvable en base.");

        string teacherTitleId;
        if (teacherModel.Title.HasValue)
        {
            var titleName = teacherModel.Title.Value.ToString();
            var titleEntity = await _dbContext.TeacherTitles
                .FirstOrDefaultAsync(t => t.Name == titleName);
            teacherTitleId = titleEntity?.TeacherTitleId
                ?? throw new InvalidOperationException($"Le titre '{titleName}' est introuvable en base.");
        }
        else
        {
            var defaultTitle = await _dbContext.TeacherTitles.FirstOrDefaultAsync();
            teacherTitleId = defaultTitle?.TeacherTitleId
                ?? throw new InvalidOperationException("Aucun titre enseignant disponible en base.");
        }

        var user = new User
        {
            UserId = Guid.NewGuid().ToString(),
            Email = teacherModel.Email,
            Password = teacherModel.Password,
            FirstName = teacherModel.FirstName,
            LastName = teacherModel.LastName,
            PhoneNumber = teacherModel.Phone ?? string.Empty,
            UserRoleId = teacherRole.UserRoleId,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };

        var teacher = new Teacher
        {
            UserId = user.UserId,
            RegistrationNumber = teacherModel.Matricule,
            TeacherTitleId = teacherTitleId,
            User = user
        };

        await _dbContext.Users.AddAsync(user);
        await _dbContext.Teachers.AddAsync(teacher);
        await _dbContext.SaveChangesAsync();

        teacherModel.Id = user.UserId;
        return teacherModel;
    }

    // ─── US14 : Mise à jour ───────────────────────────────────────────────────

    public override async Task UpdateAsync(TeacherModel teacherModel)
    {
        var teacher = await _dbContext.Teachers
            .Include(t => t.User)
                .ThenInclude(u => u.UserRole)
            .FirstOrDefaultAsync(t => t.UserId == teacherModel.Id);

        if (teacher == null) return;

        if (teacher.User != null)
        {
            teacher.User.Email = teacherModel.Email;
            teacher.User.FirstName = teacherModel.FirstName;
            teacher.User.LastName = teacherModel.LastName;
            teacher.User.PhoneNumber = teacherModel.Phone ?? string.Empty;
            teacher.User.UpdatedAt = DateTime.UtcNow;
        }

        teacher.RegistrationNumber = teacherModel.Matricule;

        if (teacherModel.Title.HasValue)
        {
            var titleName = teacherModel.Title.Value.ToString();
            var titleEntity = await _dbContext.TeacherTitles
                .FirstOrDefaultAsync(t => t.Name == titleName);
            if (titleEntity != null)
                teacher.TeacherTitleId = titleEntity.TeacherTitleId;
        }
        else if (string.IsNullOrEmpty(teacher.TeacherTitleId))
        {
            var defaultTitle = await _dbContext.TeacherTitles.FirstOrDefaultAsync();
            if (defaultTitle != null)
                teacher.TeacherTitleId = defaultTitle.TeacherTitleId;
        }

        await _dbContext.SaveChangesAsync();
    }

    // ─── US15 : Suppression ───────────────────────────────────────────────────

    public override async Task DeleteAsync(string id)
    {
        var teacher = await _dbContext.Teachers
            .Include(t => t.User)
            .Include(t => t.Tracks)
                .ThenInclude(tr => tr.Assigns)
            .Include(t => t.Tracks)
                .ThenInclude(tr => tr.Groups)
                    .ThenInclude(g => g.Students)
            .FirstOrDefaultAsync(t => t.UserId == id);

        if (teacher == null) return;

        foreach (var track in teacher.Tracks)
        {
            if (track.Assigns.Any())
                _dbContext.Assigns.RemoveRange(track.Assigns);

            foreach (var group in track.Groups)
            {
                if (group.Students.Any())
                    _dbContext.Students.RemoveRange(group.Students);
            }

            if (track.Groups.Any())
                _dbContext.Groups.RemoveRange(track.Groups);
        }

        if (teacher.Tracks.Any())
            _dbContext.Tracks.RemoveRange(teacher.Tracks);

        _dbContext.Teachers.Remove(teacher);

        if (teacher.User != null)
            _dbContext.Users.Remove(teacher.User);

        await _dbContext.SaveChangesAsync();
    }

    // ─── Vérifications métier ─────────────────────────────────────────────────

    /// <summary>
    /// US15 — Vérifie si l'enseignant a des disponibilités.
    /// Availability.TeacherId est une FK directe vers Teacher.UserId.
    /// </summary>
    public async Task<bool> HasAvailabilitiesAsync(string id)
    {
        return await _dbContext.Availabilities.AnyAsync(a => a.TeacherId == id);
    }

    /// <summary>
    /// US15 — Bloque la suppression si l'enseignant est affecté à une session future.
    /// Session ↔ Teacher est une relation many-to-many via Session.Teachers.
    /// La date de la session est portée par Session.Date + Session.StartTime.
    /// </summary>
    public async Task<bool> HasFutureSessionsAsync(string id)
    {
        var today = DateTime.UtcNow.Date;

        return await _dbContext.Sessions
            .AnyAsync(s =>
                s.Date > today &&
                s.Teachers.Any(t => t.UserId == id));
    }
}
