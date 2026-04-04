using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Enums;
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
            var unavailableDays = await _dbContext.UnavailableDays.ToListAsync();
            return unavailableDays.Select(entity => MapEntityToModel(entity)).ToList();
        }

        public override async Task<UnavailableDayModel?> GetByIdAsync(string id)
        {
            var entity = await _dbContext.UnavailableDays
                .FirstOrDefaultAsync(x => x.UnavailableDayId == id);

            return entity != null ? MapEntityToModel(entity) : null;
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
                UnavailableDayTypeId = UnavailableDayTypeMapper.ToDbValue(model.Type),
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
            entity.UnavailableDayTypeId = UnavailableDayTypeMapper.ToDbValue(model.Type);

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

        // 🔹 Méthode de mapping entity → model
        private static UnavailableDayModel MapEntityToModel(UnavailableDay entity)
        {
            return new UnavailableDayModel
            {
                Id = entity.UnavailableDayId,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                StartTime = entity.StartTime,
                EndTime = entity.EndTime,
                Type = UnavailableDayTypeMapper.FromDbValue(entity.UnavailableDayTypeId)
            };
        }
    }
}