using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Application.Exceptions;

namespace HP2.Application
{

    public class TrackService : ITrackService
    {
        private readonly ITrackRepository _repository;

        public TrackService(ITrackRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TrackModel>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
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
            var blockingAssign = await _repository.GetFirstAssignByTrackIdAsync(id);
            if (blockingAssign != null)
            {
                throw new DeleteConflictException(
                    $"Cannot delete track '{id}' because it is still linked to one or more assign records. Remove those assign records first.",
                    blockingAssign);
            }

            return await _repository.DeleteAsync(id);
        }
    }
}