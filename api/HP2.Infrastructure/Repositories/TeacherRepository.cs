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
    private readonly IBCryptService _bcryptService;

    public TeacherRepository(TerHyperplanningContext dbContext, IMapper mapper, IBCryptService bcryptService) : base(dbContext, mapper)
    {
        _bcryptService = bcryptService;
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

    public async Task<IReadOnlyList<TeacherModel>> GetDeletedAsync()
    {
        var deletedTeachers = await _dbContext.Teachers
            .IgnoreQueryFilters()
            .Include(t => t.User)
            .ThenInclude(u => u.UserRole)
            .Include(t => t.TeacherTitle)
            .Where(t => t.User != null && t.User.IsDeleted)
            .ToListAsync();

        return _mapper.Map<List<TeacherModel>>(deletedTeachers);
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

    var hashedPassword = _bcryptService.HashPassword(teacherModel.Password);

    // Create User entity from TeacherModel
    var user = new Infrastructure.Persistence.Entities.User
    {
        UserId = Guid.NewGuid().ToString(),
        Email = teacherModel.Email,
        Password = hashedPassword,
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
        teacher.User.IsDeleted = teacherModel.IsDeleted;
        teacher.User.DeletedAt = teacherModel.DeletedAt;
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
    await base.DeleteAsync(id);
}

public async Task<bool> HasAvailabilitiesAsync(string id)
{
    return await _dbContext.Availabilities.AnyAsync(a => a.TeacherId == id);
}

public async Task<IEnumerable<TeacherModel>> SearchAsync(string query)
{
    var lower = query.ToLower();
    var teachers = await _dbContext.Teachers
        .Include(t => t.User)
        .ThenInclude(u => u.UserRole)
        .Include(t => t.TeacherTitle)
        .Where(t => t.User != null && (
            t.User.FirstName.ToLower().Contains(lower) ||
            t.User.LastName.ToLower().Contains(lower) ||
            t.User.Email.ToLower().Contains(lower)
        ))
        .ToListAsync();

    return _mapper.Map<List<TeacherModel>>(teachers);
}

public async Task<IEnumerable<TeacherModel>> FilterByTitleAsync(HP2.Domain.Enums.TeacherTitle title)
{
    var titleName = title.ToString();
    var teachers = await _dbContext.Teachers
        .Include(t => t.User)
        .ThenInclude(u => u.UserRole)
        .Include(t => t.TeacherTitle)
        .Where(t => t.TeacherTitle != null && t.TeacherTitle.Name == titleName)
        .ToListAsync();

    return _mapper.Map<List<TeacherModel>>(teachers);
}
}