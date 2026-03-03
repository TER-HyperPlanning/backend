using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;

    public GroupService(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<GroupModel> CreateGroupAsync(GroupModel group)
    {
        return await _groupRepository.AddAsync(group);
    }

    public async Task<GroupModel?> GetGroupByIdAsync(string id)
    {
        return await _groupRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<GroupModel>> GetAllGroupsAsync()
    {
        return await _groupRepository.GetAllAsync();
    }

    public async Task UpdateGroupAsync(GroupModel group)
    {
        await _groupRepository.UpdateAsync(group);
    }

    public async Task DeleteGroupAsync(string id)
    {
        await _groupRepository.DeleteAsync(id);
    }
}