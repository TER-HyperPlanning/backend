using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories
{
    public class UnavailabledayRepository
        : RepositoryBase<UnavailableDayModel>, IUnavailabledayRepository
    {
        public UnavailabledayRepository(
            TerHyperplanningContext dbContext,
            IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<IReadOnlyList<UnavailableDayModel>> GetAllAsync()
        {
            var unavailableDays = await _dbContext.UnavailableDays
                .ToListAsync();

            return _mapper.Map<List<UnavailableDayModel>>(unavailableDays);
        }

        public override async Task<UnavailableDayModel?> GetByIdAsync(string id)
        {
            var unavailableDay = await _dbContext.UnavailableDays
                .FirstOrDefaultAsync(x => x.UnavailableDayId == id);

            return unavailableDay != null
                ? _mapper.Map<UnavailableDayModel>(unavailableDay)
                : null;
        }

        public override async Task<UnavailableDayModel> AddAsync(UnavailableDayModel model)
        {
            var entity = new UnavailableDay
            {
                UnavailableDayId = Guid.NewGuid().ToString(),
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                UnavailableDayTypeId = model.UnavailableDayTypeId,

            };

            await _dbContext.UnavailableDays.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            model.Id = entity.UnavailableDayId;
            return model;
        }

        public override async Task UpdateAsync(UnavailableDayModel model)
        {
            var entity = await _dbContext.UnavailableDays
                .FirstOrDefaultAsync(x => x.UnavailableDayId == model.Id);

            if (entity == null) return;

            entity.StartDate = model.StartDate;
            entity.EndDate = model.EndDate;
            entity.StartTime = model.StartTime;
            entity.EndTime = model.EndTime;
            entity.UnavailableDayTypeId = model.UnavailableDayTypeId;

            await _dbContext.SaveChangesAsync();
        }

        public override async Task DeleteAsync(string id)
        {
            var entity = await _dbContext.UnavailableDays
                .FirstOrDefaultAsync(x => x.UnavailableDayId == id);

            if (entity != null)
            {
                _dbContext.UnavailableDays.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}