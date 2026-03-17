using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories
{
    public class WeekDayRepository : IWeekDayRepository
    {
        private readonly TerHyperplanningContext _context;

        public WeekDayRepository(TerHyperplanningContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WeekDayModel>> GetAllAsync()
        {
            return await _context.WeekDays
                .OrderBy(w => w.OrderIndex)
                .Select(w => new WeekDayModel
                {
                    WeekdayId = w.WeekdayId,
                    OrderIndex = w.OrderIndex,
                    Name = w.Name
                })
                .ToListAsync();
        }

        public async Task<WeekDayModel?> GetByIdAsync(string id)
        {
            return await _context.WeekDays
                .Where(w => w.WeekdayId == id)
                .Select(w => new WeekDayModel
                {
                    WeekdayId = w.WeekdayId,
                    OrderIndex = w.OrderIndex,
                    Name = w.Name
                })
                .FirstOrDefaultAsync();
        }

        public Task<bool> ExistsAsync(string id)
            => _context.WeekDays.AnyAsync(w => w.WeekdayId == id);

        public async Task<WeekDayModel> CreateAsync(WeekDayModel weekDay)
        {
            var entity = new WeekDay
            {
                WeekdayId = weekDay.WeekdayId,
                OrderIndex = weekDay.OrderIndex,
                Name = weekDay.Name
            };

            _context.WeekDays.Add(entity);
            await _context.SaveChangesAsync();

            return weekDay;
        }

        public async Task<bool> UpdateAsync(string id, byte orderIndex, string name)
        {
            var entity = await _context.WeekDays.FirstOrDefaultAsync(w => w.WeekdayId == id);
            if (entity == null) return false;

            entity.OrderIndex = orderIndex;
            entity.Name = name;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await _context.WeekDays.FirstOrDefaultAsync(w => w.WeekdayId == id);
            if (entity == null) return false;

            _context.WeekDays.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
