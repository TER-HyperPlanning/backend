using AutoMapper;
using HP2.Application.Contracts;
using HP2.Infrastructure.Persistence;
using HP2.Domain.Models;
using HP2.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.Infrastructure.Repositories;

public class StudentRepository : RepositoryBase<StudentModel>, IStudentRepository
{
    public StudentRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<StudentModel>> GetAllAsync()
    {
        var students = await _dbContext.Students
            .Include(s => s.User)
            .ToListAsync();
        
        return _mapper.Map<List<StudentModel>>(students);
    }

    public override async Task<StudentModel?> GetByIdAsync(string id)
    {
        var student = await _dbContext.Students
            .Include(s => s.User)
            .FirstOrDefaultAsync(s => s.UserId == id);
        
        return student != null ? _mapper.Map<StudentModel>(student) : null;
    }

    public async Task<StudentModel?> GetByEmailAsync(string email)
    {
        var student = await _dbContext.Students
            .Include(s => s.User)
            .FirstOrDefaultAsync(s => s.User != null && s.User.Email == email);
        
        return student != null ? _mapper.Map<StudentModel>(student) : null;
    }

    public override async Task<StudentModel> AddAsync(StudentModel studentModel)
    {
        // Create User entity from StudentModel (which inherits UserModel)
        var user = new Infrastructure.Persistence.Entities.User
        {
            UserId = Guid.NewGuid().ToString(),
            Email = studentModel.Email,
            Password = studentModel.Password,
            FirstName = studentModel.FirstName,
            LastName = studentModel.LastName,
            PhoneNumber = studentModel.Phone,
            UserRoleId = studentModel.Role.ToString(),
            CreatedAt = DateTime.UtcNow,
        };

        // Create Student entity with the same ID as User
        var student = new Infrastructure.Persistence.Entities.Student
        {
            UserId = user.UserId,  // Shared primary key
            GroupId = studentModel.GroupId,
            User = user
        };
        
        // Add both entities
        await _dbContext.Users.AddAsync(user);
        await _dbContext.Students.AddAsync(student);
        await _dbContext.SaveChangesAsync();
        
        // Map back to Model
        studentModel.Id = user.UserId;
        return studentModel;
    }

    public override async Task UpdateAsync(StudentModel studentModel)
    {
        var student = await _dbContext.Students
            .Include(s => s.User)
            .FirstOrDefaultAsync(s => s.UserId == studentModel.Id);

        if (student == null) return;

        // Update User properties
        if (student.User != null)
        {
            student.User.Email = studentModel.Email;
            student.User.FirstName = studentModel.FirstName;
            student.User.LastName = studentModel.LastName;
            student.User.PhoneNumber = studentModel.Phone;
        }

        // Update Student properties
        student.GroupId = studentModel.GroupId;

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var student = await _dbContext.Students
            .Include(s => s.User)
            .FirstOrDefaultAsync(s => s.UserId == id);

        if (student != null)
        {
            _dbContext.Students.Remove(student);
            if (student.User != null)
            {
                _dbContext.Users.Remove(student.User);
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
