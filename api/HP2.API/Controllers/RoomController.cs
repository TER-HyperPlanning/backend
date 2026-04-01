using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;
using HP2.Application.DTOs.Common;
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

        // GET: api/Room
        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<RoomModel>>>> GetRooms()
        {
            var rooms = await _roomService.GetAllRoomsAsync();
            return Ok(ApiResponse<IEnumerable<RoomModel>>.Success(rooms));
        }

        // GET: api/Room/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<RoomModel>>> GetRoom(string id)
        {
            var room = await _roomService.GetRoomByIdAsync(id);
            if (room == null)
                return NotFound(ApiResponse<RoomModel>.Fail($"Room with ID {id} not found"));

            return Ok(ApiResponse<RoomModel>.Success(room));
        }

        // POST: api/Room
        [HttpPost]
        public async Task<ActionResult<ApiResponse<RoomModel>>> CreateRoom([FromBody] RoomRequest request)
        {
            if (request == null)
                return BadRequest(ApiResponse<RoomModel>.Fail("Room payload is required"));

            var room = new RoomModel
            {
                IsAvailable = request.IsAvailable,
                Capacity = request.Capacity,
                RoomNumber = request.RoomNumber,
                BuildingId = request.BuildingId,
                Type = Enum.Parse<RoomTypeEnum>(request.RoomTypeId)
            };
            var createdRoom = await _roomService.CreateRoomAsync(room);
            return CreatedAtAction(nameof(GetRoom), new { id = createdRoom.RoomId }, createdRoom);
        }

        // PUT: api/Room/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<RoomModel>>> EditRoom(string id, [FromBody] RoomRequest roomDto)
        {
            if (roomDto == null)
                return BadRequest(ApiResponse<RoomModel>.Fail("Room payload is required"));
            var existingRoom = await _roomService.GetRoomByIdAsync(id);
            if (existingRoom == null)
                return NotFound(ApiResponse<RoomModel>.Fail($"Room with ID {id} not found"));
            existingRoom.IsAvailable = roomDto.IsAvailable;
            existingRoom.Capacity = roomDto.Capacity;
            existingRoom.BuildingId = roomDto.BuildingId;
            existingRoom.Type = Enum.Parse<RoomTypeEnum>(roomDto.RoomTypeId);

            await _roomService.UpdateRoomAsync(existingRoom);

            return Ok(ApiResponse<RoomModel>.Success(existingRoom, "Room updated successfully"));
        }

        // DELETE: api/Room/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<string>>> DeleteRoom(string id)
        {
            var room = await _roomService.GetRoomByIdAsync(id);
            if (room == null)
            {
                return NotFound(ApiResponse<string>.Fail($"Room with ID {id} not found"));
            }

            await _roomService.DeleteRoomAsync(id);
            return Ok(ApiResponse<string>.Success(id.ToString(), "Room deleted successfully"));
        }
    }
}