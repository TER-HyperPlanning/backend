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

public override async Task<TeacherModel> AddAsync(TeacherModel teacherModel)
{
    // Get the TEACHER role from database
    var teacherRole = await _dbContext.UserRoles
        .FirstOrDefaultAsync(r => r.Name == "TEACHER");
    
    if (teacherRole == null)
        throw new InvalidOperationException("TEACHER role not found in database");

    // If TitleId is not provided, get a default one from database
    string teacherTitleId;
if (teacherModel.Title.HasValue)
{
    var titleName = teacherModel.Title.Value.ToString(); // e.g. "PROFESSEUR"
    var titleEntity = await _dbContext.TeacherTitles.FirstOrDefaultAsync(t => t.Name == titleName);
    teacherTitleId = titleEntity?.TeacherTitleId 
        ?? throw new InvalidOperationException($"TeacherTitle '{titleName}' not found in database.");
}
else
{
    var defaultTitle = await _dbContext.TeacherTitles.FirstOrDefaultAsync();
    teacherTitleId = defaultTitle?.TeacherTitleId 
        ?? throw new InvalidOperationException("No TeacherTitle found in database.");
}

    // Create User entity from TeacherModel
    var user = new Infrastructure.Persistence.Entities.User
    {
        UserId = Guid.NewGuid().ToString(),
        Email = teacherModel.Email,
        Password = teacherModel.Password,
        FirstName = teacherModel.FirstName,
        LastName = teacherModel.LastName,
        PhoneNumber = teacherModel.Phone ?? string.Empty,
        UserRoleId = teacherRole.UserRoleId,  // Use the actual UUID from the database
        CreatedAt = DateTime.UtcNow,
        UpdatedAt = DateTime.UtcNow,
    };

    // Create Teacher entity
    var teacher = new Infrastructure.Persistence.Entities.Teacher
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

    public override async Task UpdateAsync(TeacherModel teacherModel)
{
    var teacher = await _dbContext.Teachers
        .Include(t => t.User)
        .ThenInclude(u => u.UserRole)  
        .FirstOrDefaultAsync(t => t.UserId == teacherModel.Id);

    if (teacher == null) return;

    // Update User properties
    if (teacher.User != null)
    {
        teacher.User.Email = teacherModel.Email;
        teacher.User.FirstName = teacherModel.FirstName;
        teacher.User.LastName = teacherModel.LastName;
        teacher.User.PhoneNumber = teacherModel.Phone ?? string.Empty;
        teacher.User.UpdatedAt = DateTime.UtcNow;
    }

    // Update Teacher properties
    teacher.RegistrationNumber = teacherModel.Matricule;
    
    // Handle TitleId - only update if provided
    if (teacherModel.Title.HasValue)
{
    var titleName = teacherModel.Title.Value.ToString();
    var titleEntity = await _dbContext.TeacherTitles.FirstOrDefaultAsync(t => t.Name == titleName);
    if (titleEntity != null)
        teacher.TeacherTitleId = titleEntity.TeacherTitleId;
}
else if (string.IsNullOrEmpty(teacher.TeacherTitleId))
{
    var defaultTitle = await _dbContext.TeacherTitles.FirstOrDefaultAsync();
    if (defaultTitle != null)
        teacher.TeacherTitleId = defaultTitle.TeacherTitleId;
}
    // else: keep the existing TitleId if it's already set and new one is null

    await _dbContext.SaveChangesAsync();
}

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

    if (teacher != null)
    {
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
}

public async Task<bool> HasAvailabilitiesAsync(string id)
{
    return await _dbContext.Availabilities.AnyAsync(a => a.TeacherId == id);
}
}