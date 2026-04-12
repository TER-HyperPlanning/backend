using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;
using HP2.Application.DTOs.Session;
using HP2.Domain.Enums;
using HP2.Infrastructure.Persistence.Entities;
using HP2.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Persistence.Repositories
{
    public class RoomRepository : RepositoryBase<RoomModel>, IRoomRepository
    {
        private const string TdName = "TD";
        private const string CoursName = "COURS";
        private const string InfoName = "INFO";
        private const string AmphitheatreName = "AMPHITHEATRE";

        public RoomRepository(TerHyperplanningContext _dbContext, IMapper mapper) : base(_dbContext, mapper)
        {
        }

        private static RoomTypeEnum MapRoomTypeNameToEnum(string roomTypeName)
        {
            var normalized = roomTypeName.Trim().ToUpperInvariant();

            return normalized switch
            {
                "TD" => RoomTypeEnum.TD,
                "COURS" => RoomTypeEnum.COURS,
                "INFO" => RoomTypeEnum.INFO,
                "AMPHITHEATRE" => RoomTypeEnum.AMPHITHEATRE,
                "AMPHITHEATER" => RoomTypeEnum.AMPHITHEATRE,
                "SALLE DE TD" => RoomTypeEnum.TD,
                "SALLE TD" => RoomTypeEnum.TD,
                "SALLE DE COURS" => RoomTypeEnum.COURS,
                "SALLE COURS" => RoomTypeEnum.COURS,
                _ => throw new KeyNotFoundException($"Type de salle inconnu: '{roomTypeName}'.")
            };
        }

        private static string MapEnumToRoomTypeName(RoomTypeEnum roomType)
        {
            return roomType switch
            {
                RoomTypeEnum.TD => TdName,
                RoomTypeEnum.COURS => CoursName,
                RoomTypeEnum.INFO => InfoName,
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
                RoomTypeId = roomTypeId,
                IsDeleted = false,
                DeletedAt = null
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
                Type = roomModel.Type,
                IsDeleted = room.IsDeleted,
                DeletedAt = room.DeletedAt
            };
        }

        public override async Task DeleteAsync(string id)
        {
            await base.DeleteAsync(id);
        }

        public async Task<IReadOnlyList<RoomModel>> GetDeletedAsync()
        {
            var rooms = await _dbContext.Rooms
                .IgnoreQueryFilters()
                .Where(r => r.IsDeleted)
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
                    Type = MapRoomTypeNameToEnum(r.RoomType.Name),
                    IsDeleted = r.IsDeleted,
                    DeletedAt = r.DeletedAt
                })
                .ToList();
        }

        public Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionAsync(string roomId, DateTime referenceDateTime)
        {
            var referenceDate = referenceDateTime.Date;
            var referenceTime = referenceDateTime.TimeOfDay;

            return _dbContext.Sessions
                .AsNoTracking()
                .Where(s => s.RoomId == roomId
                            && (s.Date > referenceDate
                                || (s.Date == referenceDate && s.EndTime > referenceTime)))
                .OrderBy(s => s.Date)
                .ThenBy(s => s.StartTime)
                .Select(s => new BlockingSessionInfo
                {
                    SessionId = s.SessionId,
                    StartDateTime = s.Date.Date + s.StartTime,
                    EndDateTime = s.Date.Date + s.EndTime,
                    RoomId = s.RoomId,
                    RoomNumber = s.Room.RoomNumber,
                    CourseId = s.CourseId,
                    CourseName = s.Course.Name
                })
                .FirstOrDefaultAsync();
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
                    Type = MapRoomTypeNameToEnum(r.RoomType.Name),
                    IsDeleted = r.IsDeleted,
                    DeletedAt = r.DeletedAt
                })
                .ToList();
        }

        public async Task<IReadOnlyList<RoomModel>> GetRoomsAsync(IEnumerable<RoomTypeEnum> types, string? query)
        {
            var requestedTypes = types?.Distinct().ToArray() ?? Array.Empty<RoomTypeEnum>();
            var normalizedQuery = query?.Trim();
            var hasQueryFilter = !string.IsNullOrWhiteSpace(normalizedQuery);
            var hasTypeFilter = requestedTypes.Length > 0;

            var roomsQuery = _dbContext.Rooms
                .AsNoTracking()
                .Include(r => r.RoomType)
                .Include(r => r.Building)
                .AsQueryable();

            if (hasTypeFilter)
            {
                var requestedTypeNames = requestedTypes
                    .Select(MapEnumToRoomTypeName)
                    .ToList();

                roomsQuery = roomsQuery.Where(r => requestedTypeNames.Contains(r.RoomType.Name));
            }

            if (hasQueryFilter)
            {
                var uppercaseQuery = normalizedQuery!.ToUpperInvariant();
                var isCapacityQuery = int.TryParse(normalizedQuery, out var capacityValue);

                roomsQuery = roomsQuery.Where(r =>
                    r.RoomNumber.ToUpper().Contains(uppercaseQuery)
                    || r.RoomType.Name.ToUpper().Contains(uppercaseQuery)
                    || r.Building.Name.ToUpper().Contains(uppercaseQuery)
                    || (isCapacityQuery && r.Capacity == capacityValue));
            }

            var rooms = await roomsQuery
                .OrderBy(r => r.RoomNumber)
                .ToListAsync();

            return rooms
                .Select(r => new RoomModel
                {
                    RoomId = r.RoomId,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    Type = MapRoomTypeNameToEnum(r.RoomType.Name),
                    IsDeleted = r.IsDeleted,
                    DeletedAt = r.DeletedAt
                })
                .ToList();
        }

        public override async Task<RoomModel?> GetByIdAsync(string id)
        {
            var room = await _dbContext.Rooms
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(r => r.RoomId == id);

            if (room == null) return null;

            return new RoomModel
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = MapRoomTypeNameToEnum(room.RoomType.Name),
                IsDeleted = room.IsDeleted,
                DeletedAt = room.DeletedAt
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
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    Type = MapRoomTypeNameToEnum(r.RoomType.Name),
                    IsDeleted = r.IsDeleted,
                    DeletedAt = r.DeletedAt
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
            room.IsDeleted = roomModel.IsDeleted;
            room.DeletedAt = roomModel.DeletedAt;

            _dbContext.Rooms.Update(room);
            await _dbContext.SaveChangesAsync();

            return new RoomModel
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = roomModel.Type,
                IsDeleted = room.IsDeleted,
                DeletedAt = room.DeletedAt
            };
        }
    }
}