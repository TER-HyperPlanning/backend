using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;
using HP2.Application.DTOs.Common;
using HP2.Application.Exceptions;
using HP2.Domain.Enums;

namespace HP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        private static readonly Dictionary<string, string> EnumAllowedValues = new(StringComparer.OrdinalIgnoreCase)
        {
            ["type"] = string.Join(", ", "TD", "COURS", "INFO", "AMPHITHEATRE")
        };

        private static string FormatFieldWithAllowedValues(string field)
        {
            return EnumAllowedValues.TryGetValue(field, out var allowedValues)
                ? $"{field}( {allowedValues} )"
                : field;
        }

        // GET: api/Room
        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<RoomResponse>>>> GetRooms()
        {
            var rooms = await _roomService.GetAllRoomsAsync();
            var response = rooms.Select(MapToResponse);
            return Ok(ApiResponse<IEnumerable<RoomResponse>>.Success(response));
        }

        [HttpGet("deleted")]
        public async Task<ActionResult<ApiResponse<IEnumerable<DeletedRoomResponse>>>> GetDeleted()
        {
            var rooms = await _roomService.GetDeletedRoomsAsync();
            var response = rooms.Select(MapToDeletedResponse);
            return Ok(ApiResponse<IEnumerable<DeletedRoomResponse>>.Success(response));
        }

        // GET: api/Room/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<RoomResponse>>> GetRoom(string id)
        {
            var room = await _roomService.GetRoomByIdAsync(id);
            if (room == null)
                return NotFound(ApiResponse<RoomResponse>.Fail($"Room with ID {id} not found"));

            return Ok(ApiResponse<RoomResponse>.Success(MapToResponse(room)));
        }

        // POST: api/Room
        [HttpPost]
        public async Task<ActionResult<ApiResponse<RoomModel>>> CreateRoom([FromBody] RoomRequest request)
        {
            if (request == null)
            {
                if (!ModelState.IsValid)
                {
                    var invalidFields = ModelState
                        .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                        .Select(x => x.Key.Split('.').Last())
                        .Where(x => !string.IsNullOrWhiteSpace(x)
                                    && !x.Equals("request", StringComparison.OrdinalIgnoreCase)
                                    && x != "$")
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToList();

                    if (invalidFields.Any())
                        return BadRequest(ApiResponse<RoomModel>.Fail($"Invalid field values: {string.Join(", ", invalidFields.Select(FormatFieldWithAllowedValues))}"));
                }

                return BadRequest(ApiResponse<RoomModel>.Fail("Room payload is required"));
            }

            if (!ModelState.IsValid)
            {
                var invalidFields = ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                    .Select(x => x.Key.Split('.').Last())
                    .Where(x => !string.IsNullOrWhiteSpace(x)
                                && !x.Equals("request", StringComparison.OrdinalIgnoreCase)
                                && x != "$")
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (invalidFields.Any())
                    return BadRequest(ApiResponse<RoomModel>.Fail($"Invalid field values: {string.Join(", ", invalidFields.Select(FormatFieldWithAllowedValues))}"));
            }

            if (!request.Type.HasValue)
            {
                return BadRequest(ApiResponse<RoomModel>.Fail($"Invalid field values: {FormatFieldWithAllowedValues("type")}"));
            }

            var room = new RoomModel
            {
                IsAvailable = request.IsAvailable,
                Capacity = request.Capacity,
                RoomNumber = request.RoomNumber,
                BuildingId = request.BuildingId,
                Type = request.Type.Value
            };
            var createdRoom = await _roomService.CreateRoomAsync(room);
            return CreatedAtAction(nameof(GetRoom), new { id = createdRoom.RoomId },
                ApiResponse<RoomModel>.Success(createdRoom, "Room created successfully"));
        }

        // PUT: api/Room/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<RoomModel>>> EditRoom(string id, [FromBody] RoomRequest roomDto)
        {
            if (roomDto == null)
            {
                if (!ModelState.IsValid)
                {
                    var invalidFields = ModelState
                        .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                        .Select(x => x.Key.Split('.').Last())
                        .Where(x => !string.IsNullOrWhiteSpace(x)
                                    && !x.Equals("roomDto", StringComparison.OrdinalIgnoreCase)
                                    && x != "$")
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToList();

                    if (invalidFields.Any())
                        return BadRequest(ApiResponse<RoomModel>.Fail($"Invalid field values: {string.Join(", ", invalidFields.Select(FormatFieldWithAllowedValues))}"));
                }

                return BadRequest(ApiResponse<RoomModel>.Fail("Room payload is required"));
            }

            if (!ModelState.IsValid)
            {
                var invalidFields = ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                    .Select(x => x.Key.Split('.').Last())
                    .Where(x => !string.IsNullOrWhiteSpace(x)
                                && !x.Equals("roomDto", StringComparison.OrdinalIgnoreCase)
                                && x != "$")
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (invalidFields.Any())
                    return BadRequest(ApiResponse<RoomModel>.Fail($"Invalid field values: {string.Join(", ", invalidFields.Select(FormatFieldWithAllowedValues))}"));
            }

            if (!roomDto.Type.HasValue)
            {
                return BadRequest(ApiResponse<RoomModel>.Fail($"Invalid field values: {FormatFieldWithAllowedValues("type")}"));
            }

            var existingRoom = await _roomService.GetRoomByIdAsync(id);
            if (existingRoom == null)
                return NotFound(ApiResponse<RoomModel>.Fail($"Room with ID {id} not found"));
            existingRoom.IsAvailable = roomDto.IsAvailable;
            existingRoom.Capacity = roomDto.Capacity;
            existingRoom.BuildingId = roomDto.BuildingId;
            existingRoom.RoomNumber = roomDto.RoomNumber;
            existingRoom.Type = roomDto.Type.Value;

            await _roomService.UpdateRoomAsync(existingRoom);

            return Ok(ApiResponse<RoomModel>.Success(existingRoom, "Room updated successfully"));
        }

        // DELETE: api/Room/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<object>>> DeleteRoom(string id)
        {
            var room = await _roomService.GetRoomByIdAsync(id);
            if (room == null)
            {
                return NotFound(ApiResponse<object>.Fail($"Room with ID {id} not found"));
            }

            try
            {
                await _roomService.DeleteRoomAsync(id);
                return Ok(ApiResponse<object>.Success(id.ToString(), "Room deleted successfully"));
            }
            catch (DeleteConflictException ex)
            {
                return Conflict(ApiResponse<object>.Fail(ex.Message, ex.BlockingSession));
            }
        }

        private static DeletedRoomResponse MapToDeletedResponse(RoomModel room)
        {
            return new DeletedRoomResponse
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = room.Type,
                DeletedAt = room.DeletedAt
            };
        }

        private static RoomResponse MapToResponse(RoomModel room)
        {
            return new RoomResponse
            {
                RoomId = room.RoomId,
                RoomNumber = room.RoomNumber,
                IsAvailable = room.IsAvailable,
                Capacity = room.Capacity,
                BuildingId = room.BuildingId,
                Type = room.Type,
                DeletedAt = room.DeletedAt
            };
        }
    }
}