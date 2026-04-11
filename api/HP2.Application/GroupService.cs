using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;
    private readonly ITrackRepository _trackRepository; // Add track repository

    public GroupService(IGroupRepository groupRepository, ITrackRepository trackRepository)
    {
        _groupRepository = groupRepository;
        _trackRepository = trackRepository;
    }

    public async Task<GroupModel> CreateGroupAsync(GroupModel group)
    {
        if (group.Place <= 0)
        {
            throw new ArgumentException("Place must be greater than 0");
        }

        var trackExists = await _trackRepository.ExistsAsync(group.TrackId);
        if (!trackExists)
        {
            throw new ArgumentException($"Track with ID {group.TrackId} does not exist.");
        }

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
        if (group.Place <= 0)
        {
            throw new ArgumentException("Place must be greater than 0");
        }

        var trackExists = await _trackRepository.ExistsAsync(group.TrackId);
        if (!trackExists)
        {
            throw new ArgumentException($"Track with ID {group.TrackId} does not exist.");
        }

        await _groupRepository.UpdateAsync(group);
    }

    public async Task DeleteGroupAsync(string id)
    {
        await _groupRepository.DeleteAsync(id);
    }
}