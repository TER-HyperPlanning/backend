using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Room;
using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IRoomService
{
    Task<ApiResponse<IEnumerable<RoomResponse>>> GetAllAsync();
    Task<ApiResponse<RoomResponse>> GetByIdAsync(string id);
    Task<ApiResponse<RoomResponse>> CreateAsync(CreateRoomRequest request);
    Task<ApiResponse<RoomResponse>> UpdateAsync(string id, UpdateRoomRequest request);
    Task<ApiResponse<string>> DeleteAsync(string id);
}