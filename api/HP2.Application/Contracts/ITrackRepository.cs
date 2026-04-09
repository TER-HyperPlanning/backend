using HP2.Domain.Models;
using HP2.Application.DTOs.Assign;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface ITrackRepository
    {
        Task<List<TrackModel>> GetAllAsync();
        Task<List<TrackModel>> GetDeletedAsync();
        Task<TrackModel?> GetByIdAsync(string id);
        Task<TrackModel> AddAsync(TrackModel model);
        Task<TrackModel> UpdateAsync(TrackModel model);
        Task<bool> DeleteAsync(string id);
        Task<bool> ExistsAsync(string id);
        Task<AssignResponse?> GetFirstAssignByTrackIdAsync(string trackId);
    }
}