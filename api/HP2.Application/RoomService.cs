using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Room;
using HP2.Domain.Models;

namespace HP2.Application;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _roomRepository;

    public RoomService(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task<ApiResponse<IEnumerable<RoomResponse>>> GetAllAsync()
    {
        var rooms = await _roomRepository.GetAllAsync();
        var result = rooms.Select(ToResponse);
        return ApiResponse<IEnumerable<RoomResponse>>.Success(result);
    }

    public async Task<ApiResponse<RoomResponse>> GetByIdAsync(string id)
    {
        var room = await _roomRepository.GetByIdAsync(id);
        if (room == null)
            return ApiResponse<RoomResponse>.Fail($"Salle avec l'ID {id} introuvable.");

        return ApiResponse<RoomResponse>.Success(ToResponse(room));
    }

    public async Task<ApiResponse<RoomResponse>> CreateAsync(CreateRoomRequest request)
    {
        if (await _roomRepository.RoomNumberExistsAsync(request.RoomNumber))
            return ApiResponse<RoomResponse>.Fail("Ce numéro de salle existe déjà.");

        var room = new RoomModel
        {
            RoomNumber = request.RoomNumber,
            Capacity = request.Capacity,
            BuildingId = request.BuildingId,
            RoomTypeId = request.RoomTypeId,
            IsAvailable = request.IsAvailable
        };

        var created = await _roomRepository.AddAsync(room);
        return ApiResponse<RoomResponse>.Success(ToResponse(created), "Salle créée avec succès.");
    }

    public async Task<ApiResponse<RoomResponse>> UpdateAsync(string id, UpdateRoomRequest request)
    {
        var room = await _roomRepository.GetByIdAsync(id);
        if (room == null)
            return ApiResponse<RoomResponse>.Fail($"Salle avec l'ID {id} introuvable.");

        if (await _roomRepository.RoomNumberExistsAsync(request.RoomNumber, id))
            return ApiResponse<RoomResponse>.Fail("Ce numéro de salle est déjà utilisé par une autre salle.");

        var minCapacity = await _roomRepository.GetMinCapacityRequiredAsync(id);
        if (request.Capacity < minCapacity)
            return ApiResponse<RoomResponse>.Fail(
                $"La capacité doit être d'au moins {minCapacity} pour les cours déjà planifiés dans cette salle.");

        room.RoomNumber = request.RoomNumber;
        room.Capacity = request.Capacity;
        room.BuildingId = request.BuildingId;
        room.RoomTypeId = request.RoomTypeId;
        room.IsAvailable = request.IsAvailable;

        await _roomRepository.UpdateAsync(room);
        return ApiResponse<RoomResponse>.Success(ToResponse(room), "Salle mise à jour avec succès.");
    }

    public async Task<ApiResponse<string>> DeleteAsync(string id)
    {
        var room = await _roomRepository.GetByIdAsync(id);
        if (room == null)
            return ApiResponse<string>.Fail($"Salle avec l'ID {id} introuvable.");

        await _roomRepository.DeleteAsync(id);
        return ApiResponse<string>.Success(id, "Salle supprimée avec succès.");
    }

    private static RoomResponse ToResponse(RoomModel r) => new()
    {
        RoomId = r.RoomId,
        RoomNumber = r.RoomNumber,
        Capacity = r.Capacity,
        IsAvailable = r.IsAvailable,
        BuildingId = r.BuildingId,
        RoomTypeId = r.RoomTypeId
    };
}