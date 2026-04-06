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
        private const string SalleTdName = "Salle de TD";
        private const string SalleCoursName = "Salle de Cours";
        private const string AmphitheatreName = "Amphitheatre";

        public RoomRepository(TerHyperplanningContext _dbContext, IMapper mapper) : base(_dbContext, mapper)
        {
        }

        private static RoomTypeEnum MapRoomTypeNameToEnum(string roomTypeName)
        {
            var normalized = roomTypeName.Trim();

            return normalized.ToLowerInvariant() switch
            {
                "salle de td" => RoomTypeEnum.SalleTD,
                "salle td" => RoomTypeEnum.SalleTD,
                "salletd" => RoomTypeEnum.SalleTD,
                "salle de cours" => RoomTypeEnum.SalleCOURS,
                "salle cours" => RoomTypeEnum.SalleCOURS,
                "sallecours" => RoomTypeEnum.SalleCOURS,
                "amphitheatre" => RoomTypeEnum.AMPHITHEATRE,
                "amphitheater" => RoomTypeEnum.AMPHITHEATRE,
                _ => throw new KeyNotFoundException($"Type de salle inconnu: '{roomTypeName}'.")
            };
        }

        private static string MapEnumToRoomTypeName(RoomTypeEnum roomType)
        {
            return roomType switch
            {
                RoomTypeEnum.SalleTD => SalleTdName,
                RoomTypeEnum.SalleCOURS => SalleCoursName,
                RoomTypeEnum.AMPHITHEATRE => AmphitheatreName,
                _ => throw new KeyNotFoundException($"Enum de type de salle inconnu: {roomType}.")
            };
        }

        private async Task<string> ResolveRoomTypeIdAsync(RoomTypeEnum roomType)
        {
            var roomTypeName = MapEnumToRoomTypeName(roomType);
            var roomTypeEntity = await _dbContext.RoomTypes.FirstOrDefaultAsync(rt => rt.Name == roomTypeName);

            if (roomTypeEntity == null)
            {
                throw new KeyNotFoundException($"Aucun RoomType trouvé pour '{roomTypeName}'.");
            }

            return roomTypeEntity.RoomTypeId;
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
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room != null)
            {
                _dbContext.Rooms.Remove(room);
                await _dbContext.SaveChangesAsync();
            }
        }

        public override async Task<IReadOnlyList<RoomModel>> GetAllAsync()
        {
            var rooms = await _dbContext.Rooms
                .Include(r => r.RoomType)
                .ToListAsync();

            return rooms
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    Type = MapRoomTypeNameToEnum(r.RoomType.Name)
                })
                .ToList();
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
                Type = MapRoomTypeNameToEnum(room.RoomType.Name)
            };
        }

        public async Task<IReadOnlyList<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId)
        {
            var rooms = await _dbContext.Rooms
                .Where(r => r.BuildingId == buildingId)
                .Include(r => r.RoomType)
                .ToListAsync();

            return rooms
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    Type = MapRoomTypeNameToEnum(r.RoomType.Name)
                })
                .ToList();
        }



        public override async Task<RoomModel> UpdateAsync(RoomModel roomModel)
        {
            var id = roomModel.RoomId;
            var room = await _dbContext.Rooms.FindAsync(id);
            if (room == null)
            {
                throw new KeyNotFoundException($"salle  {id} introuvable.");
            }

            var roomTypeId = await ResolveRoomTypeIdAsync(roomModel.Type);

            room.RoomNumber = roomModel.RoomNumber;
            room.IsAvailable = roomModel.IsAvailable;
            room.Capacity = roomModel.Capacity;
            room.BuildingId = roomModel.BuildingId;
            room.RoomTypeId = roomTypeId;

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