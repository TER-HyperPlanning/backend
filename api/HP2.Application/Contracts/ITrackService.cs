using HP2.Domain.Models;

namespace HP2.Application.Contracts
{
    public interface ITrackService
    {
        Task<List<TrackModel>> GetAllAsync();
        Task<List<TrackModel>>GetDeletedAsync();
        Task<TrackModel> GetByIdAsync(string id);
        Task<TrackModel> AddAsync(TrackModel model);
        Task<TrackModel> UpdateAsync(TrackModel model);
        Task<bool> DeleteAsync(string id);
    }
}