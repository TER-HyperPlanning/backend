using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IGroupService
{
    Task<GroupModel> CreateGroupAsync(GroupModel group);
    Task<GroupModel?> GetGroupByIdAsync(string id);
    Task<IEnumerable<GroupModel>> GetAllGroupsAsync();
    Task UpdateGroupAsync(GroupModel group);
    Task DeleteGroupAsync(string id);
}