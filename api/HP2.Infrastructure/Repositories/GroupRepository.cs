using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.Infrastructure.Repositories;

public class GroupRepository : RepositoryBase<GroupModel>, IGroupRepository
{

    public GroupRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

        public override async Task<IReadOnlyList<GroupModel>> GetAllAsync()
    {
        var groups = await _dbContext.Groups
            .ToListAsync();
            return _mapper.Map<List<GroupModel>>(groups);
    }


    public override async Task<GroupModel> AddAsync(GroupModel groupModel)
    {
        var group = new Infrastructure.Persistence.Entities.Group
        {
            GroupId = Guid.NewGuid().ToString(),
            Name = groupModel.Name,
            AcademicYear = groupModel.AcademicYear,
            TrackId = groupModel.TrackId
        };
        
        // Add both entities
        await _dbContext.Groups.AddAsync(group);
        await _dbContext.SaveChangesAsync();
        
        // Map back to Model with the generated ID
        return _mapper.Map<GroupModel>(group);
    }

    public override async Task<GroupModel?> GetByIdAsync(string id)
    {
        var group = await _dbContext.Groups
            .FirstOrDefaultAsync(s => s.GroupId == id);
        
        return group != null ? _mapper.Map<GroupModel>(group) : null;
    }

    public override async Task UpdateAsync(GroupModel groupModel)
    {
        var group = await _dbContext.Groups
            .FirstOrDefaultAsync(s => s.GroupId == groupModel.Id);

        if (group == null) return;

        if (group != null)
        {
            // update properties
            group.Name = groupModel.Name;
            group.AcademicYear = groupModel.AcademicYear;
            group.TrackId = groupModel.TrackId;
        }

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var group = await _dbContext.Groups
            .FirstOrDefaultAsync(s => s.GroupId == id);

        if (group != null)
        {
            _dbContext.Groups.Remove(group);
            if (group != null)
            {
                _dbContext.Groups.Remove(group);
            }
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<GroupModel?> GetByNameAsync(string name)
    {
      var group = await _dbContext.Groups
            .FirstOrDefaultAsync(s => s.Name == name);
        
        return group != null ? _mapper.Map<GroupModel>(group) : null;
    }
}