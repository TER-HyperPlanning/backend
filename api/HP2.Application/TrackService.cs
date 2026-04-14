using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class TrackService : ITrackService
{
    private readonly ITrackRepository _repository;

    public TrackService(ITrackRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<TrackModel>> GetAllAsync(string? programId, string? name)
    {
        return await _repository.GetAllAsync(programId, name);
    }

    public async Task<List<TrackModel>> GetDeletedAsync()
    {
        return await _repository.GetDeletedAsync();
    }

    public async Task<TrackModel?> GetByIdAsync(string id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<TrackModel> AddAsync(TrackModel model)
    {
        return await _repository.AddAsync(model);
    }

    public async Task<TrackModel> UpdateAsync(TrackModel model)
    {
        return await _repository.UpdateAsync(model);
    }

    public async Task<bool> DeleteAsync(string id)
    {
        return await _repository.DeleteAsync(id);
    }
}
