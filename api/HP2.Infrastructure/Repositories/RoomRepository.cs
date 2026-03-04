using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;
using HP2.Domain.Enums;
using HP2.Infrastructure.Persistence.Entities;
using HP2.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Persistence.Repositories
{
    public class RoomRepository : RepositoryBase<RoomModel>, IRoomRepository
    {
        public RoomRepository(TerHyperplanningContext _dbContext, IMapper mapper) : base(_dbContext, mapper)
        {
        }

        public override async Task<RoomModel> AddAsync(RoomModel roomModel)
        {
            var room = new Room
            {
                RoomId = roomModel.RoomId,
                RoomNumber = roomModel.RoomNumber,
                IsAvailable = roomModel.IsAvailable,
                Capacity = roomModel.Capacity,
                BuildingId = roomModel.BuildingId,
                RoomTypeId = roomModel.Type.ToString()
            };

            await _dbContext.Rooms.AddAsync(room);
            await _dbContext.SaveChangesAsync();

            return new RoomModel
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = Enum.Parse<RoomTypeEnum>(room.RoomTypeId)
            };
        }

        public override async Task DeleteAsync(string id)
        {
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room != null)
            {
                _dbContext.Rooms.Remove(room);
                await _dbContext.SaveChangesAsync();
            }
        }

        public override async Task<IReadOnlyList<RoomModel>> GetAllAsync()
        {
            return await _dbContext.Rooms
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    Type = Enum.Parse<RoomTypeEnum>(r.RoomTypeId)
                })
                .ToListAsync();
        }

        public override async Task<RoomModel> GetByIdAsync(string id)
        {
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room == null) return null!;

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = Enum.Parse<RoomTypeEnum>(room.RoomTypeId)
            };
        }

        public async Task<IReadOnlyList<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId)
        {
            return await _dbContext.Rooms
                .Where(r => r.BuildingId == buildingId)
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    Type = Enum.Parse<RoomTypeEnum>(r.RoomTypeId)
                })
                .ToListAsync();
        }



        public override async Task<RoomModel> UpdateAsync(RoomModel roomModel)
        {
            var id = roomModel.RoomId;
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room == null)
            {
                throw new KeyNotFoundException($"salle  {id} introuvable.");
            }

            room.RoomNumber = roomModel.RoomNumber;
            room.IsAvailable = roomModel.IsAvailable;
            room.Capacity = roomModel.Capacity;
            room.BuildingId = roomModel.BuildingId;
            room.RoomTypeId = roomModel.Type.ToString();

            _dbContext.Rooms.Update(room);
            await _dbContext.SaveChangesAsync();

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = Enum.Parse<RoomTypeEnum>(room.RoomTypeId)
            };
        }
    }
}