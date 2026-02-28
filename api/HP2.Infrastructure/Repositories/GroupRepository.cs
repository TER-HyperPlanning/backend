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

        public async Task<IEnumerable<GroupModel>> GetAllAsync()
    {
        var groups = await _dbContext.Groups
            .ToListAsync();
            return _mapper.Map<List<GroupModel>>(groups);
    }


    public async Task<GroupModel> AddAsync(GroupModel groupModel)
    {
        var group = new Infrastructure.Persistence.Entities.Group
        {
            GroupId = Guid.NewGuid().ToString(),
            Name = groupModel.Name
        };
        
        // Add both entities
        await _dbContext.Groups.AddAsync(group);
        await _dbContext.SaveChangesAsync();
        
        // Map back to Model
        return groupModel;
    }

    public async Task<GroupModel?> GetByIdAsync(string id)
    {
        var group = await _dbContext.Groups
            .FirstOrDefaultAsync(s => s.GroupId == id);
        
        return group != null ? _mapper.Map<GroupModel>(group) : null;
    }

    public async Task UpdateAsync(GroupModel groupModel)
    {
        var group = await _dbContext.Groups
            .FirstOrDefaultAsync(s => s.GroupId == groupModel.Id);

        if (group == null) return;

        if (group != null)
        {
            group.GroupId = groupModel.Id;
            group.Name = groupModel.Name;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id)
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