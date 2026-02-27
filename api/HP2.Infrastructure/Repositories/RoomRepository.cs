using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Persistence.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly TerHyperplanningContext _context;

        public RoomRepository(TerHyperplanningContext context)
        {
            _context = context;
        }

        public async Task<RoomResponseDto> CreateRoomAsync(RoomRequestDto roomDto)
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

            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();

            return new RoomResponseDto
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                RoomTypeId = room.RoomTypeId
            };
        }

        public async Task DeleteRoomAsync(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<RoomResponseDto>> GetAllRoomsAsync()
        {
            return await _context.Rooms
                .Select(r => new RoomResponseDto
                {
                    RoomId = r.RoomId,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    RoomTypeId = r.RoomTypeId
                })
                .ToListAsync();
        }

        public async Task<RoomResponseDto> GetRoomByIdAsync(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null) return null!;

            return new RoomResponseDto
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                RoomTypeId = room.RoomTypeId
            };
        }

        public async Task<IEnumerable<RoomResponseDto>> GetRoomsByBuildingIdAsync(int buildingId)
        {
            return await _context.Rooms
                .Where(r => r.BuildingId == buildingId.ToString())
                .Select(r => new RoomResponseDto
                {
                    RoomId = r.RoomId,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Capacity = r.Capacity,
                    BuildingId = r.BuildingId,
                    RoomTypeId = r.RoomTypeId
                })
                .ToListAsync();
        }



        public async Task<RoomResponseDto> UpdateRoomAsync(int id, RoomRequestDto roomDto)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                throw new KeyNotFoundException($"salle  {id} introuvable.");
            }

            room.RoomNumber = roomDto.RoomNumber;
            room.IsAvailable = roomDto.IsAvailable;
            room.Capacity = roomDto.Capacity;
            room.BuildingId = roomDto.BuildingId;
            room.RoomTypeId = roomDto.RoomTypeId;

            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();

            return new RoomResponseDto
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                RoomTypeId = room.RoomTypeId
            };
        }
    }
}