using HP2.Domain.Models;

namespace HP2.Application.Contracts
{
    public interface IWeekDayService
    {
        Task<IEnumerable<WeekDayModel>> GetAllAsync();
        Task<WeekDayModel?> GetByIdAsync(string id);
        Task<WeekDayModel> CreateAsync(WeekDayModel weekDay);
        Task<bool> UpdateAsync(string id, byte orderIndex, string name);
        Task<bool> DeleteAsync(string id);
    }
}
