using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application
{
    public class WeekDayService : IWeekDayService
    {
        private readonly IWeekDayRepository _repo;

        public WeekDayService(IWeekDayRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<WeekDayModel>> GetAllAsync() => _repo.GetAllAsync();

        public Task<WeekDayModel?> GetByIdAsync(string id) => _repo.GetByIdAsync(id);

        public async Task<WeekDayModel> CreateAsync(WeekDayModel weekDay)
        {
            if (await _repo.ExistsAsync(weekDay.WeekdayId))
                throw new InvalidOperationException($"WeekDay with id '{weekDay.WeekdayId}' already exists");

            return await _repo.CreateAsync(weekDay);
        }

        public Task<bool> UpdateAsync(string id, byte orderIndex, string name)
            => _repo.UpdateAsync(id, orderIndex, name);

        public Task<bool> DeleteAsync(string id)
            => _repo.DeleteAsync(id);
    }
}



