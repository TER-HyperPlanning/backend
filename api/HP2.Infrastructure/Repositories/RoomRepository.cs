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
            var roomTypeId = await ResolveRoomTypeIdAsync(roomModel.Type);
            var room = new Room
            {
                RoomId = roomModel.RoomId,
                RoomNumber = roomModel.RoomNumber,
                IsAvailable = roomModel.IsAvailable,
                Capacity = roomModel.Capacity,
                BuildingId = roomModel.BuildingId,
                RoomTypeId = roomTypeId
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
                Type = roomModel.Type
            };
        }

        public override async Task DeleteAsync(string id)
        {
            var room = await _dbContext.Rooms
                .Include(r => r.Sessions)
                .FirstOrDefaultAsync(r => r.RoomId == id);

            if (room == null) return;

            if (room.Sessions != null && room.Sessions.Count > 0)
            {
                throw new InvalidOperationException($"Impossible de supprimer la salle. Elle contient {room.Sessions.Count} session(s) planifiée(s).");
            }

            _dbContext.Rooms.Remove(room);
            await _dbContext.SaveChangesAsync();
        }

        public override async Task<IReadOnlyList<RoomModel>> GetAllAsync()
        {
            var rooms = await _dbContext.Rooms
                .Include(r => r.RoomType)
                .ToListAsync();

            return rooms.Select(r => new RoomModel
            {
                RoomId = r.RoomId,
                RoomNumber = r.RoomNumber,
                IsAvailable = r.IsAvailable,
                Capacity = r.Capacity,
                BuildingId = r.BuildingId,
                Type = RoomTypeEnumExtensions.ParseRoomType(r.RoomType.Name)
            }).ToList();
        }

        public override async Task<RoomModel> GetByIdAsync(string id)
        {
            var room = await _dbContext.Rooms
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(r => r.RoomId == id);
            if (room == null) return null!;

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = RoomTypeEnumExtensions.ParseRoomType(room.RoomType.Name)
            };
        }

        public async Task<IReadOnlyList<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId)
        {
            var rooms = await _dbContext.Rooms
                .Include(r => r.RoomType)
                .Where(r => r.BuildingId == buildingId)
                .ToListAsync();

            return rooms.Select(r => new RoomModel
            {
                RoomId = r.RoomId,
                IsAvailable = r.IsAvailable,
                Capacity = r.Capacity,
                BuildingId = r.BuildingId,
                Type = RoomTypeEnumExtensions.ParseRoomType(r.RoomType.Name)
            }).ToList();
        }

        private async Task<string> ResolveRoomTypeIdAsync(RoomTypeEnum roomType)
        {
            var roomTypeName = roomType.ToRoomTypeName();
            var typeEntity = await _dbContext.RoomTypes.FirstOrDefaultAsync(rt => rt.Name == roomTypeName);
            if (typeEntity == null)
            {
                throw new KeyNotFoundException($"RoomType '{roomTypeName}' introuvable en base.");
            }

            return typeEntity.RoomTypeId;
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
            room.RoomTypeId = await ResolveRoomTypeIdAsync(roomModel.Type);

            _dbContext.Rooms.Update(room);
            await _dbContext.SaveChangesAsync();

            return new RoomModel
            {
                RoomId = room.RoomId,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = roomModel.Type
            };
        }
    }
}