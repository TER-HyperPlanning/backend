using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;
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

        public async Task<RoomModel> AddAsync(RoomRequest roomDto)
        {
            var room = new Room
            {
                RoomId = roomDto.RoomId,
                RoomNumber = roomDto.RoomNumber,
                IsAvailable = roomDto.IsAvailable,
                Capacity = roomDto.Capacity,
                BuildingId = roomDto.BuildingId,
                RoomTypeId = roomDto.RoomTypeId
            };

            await _dbContext.Rooms.AddAsync(room);
            await _dbContext.SaveChangesAsync();

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                RoomTypeId = room.RoomTypeId
            };
        }

        public async Task DeleteAsync(int id)
        {
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room != null)
            {
                _dbContext.Rooms.Remove(room);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<RoomModel>> GetAllAsync()
        {
            return await _dbContext.Rooms
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    RoomTypeId = r.RoomTypeId
                })
                .ToListAsync();
        }

        public async Task<RoomModel> GetByIdAsync(int id)
        {
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room == null) return null!;

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                RoomTypeId = room.RoomTypeId
            };
        }

        public async Task<IEnumerable<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId)
        {
            return await _dbContext.Rooms
                .Where(r => r.BuildingId == buildingId)
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    RoomTypeId = r.RoomTypeId
                })
                .ToListAsync();
        }



        public async Task<RoomModel> UpdateAsync(int id, RoomRequest roomDto)
        {
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room == null)
            {
                throw new KeyNotFoundException($"salle  {id} introuvable.");
            }

            room.RoomNumber = roomDto.RoomNumber;
            room.IsAvailable = roomDto.IsAvailable;
            room.Capacity = roomDto.Capacity;
            room.BuildingId = roomDto.BuildingId;
            room.RoomTypeId = roomDto.RoomTypeId;

            _dbContext.Rooms.Update(room);
            await _dbContext.SaveChangesAsync();

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                RoomTypeId = room.RoomTypeId
            };
        }
    }
}