using System;

namespace HP2.Application.DTOs.RoomDtos;

public class RoomResponse
{
    public string RoomId { get; set; } = null!;

    public string RoomNumber { get; set; } = null!;

    public bool? IsAvailable { get; set; }

    public int Capacity { get; set; }

    public string BuildingId { get; set; } = null!;

    public string RoomTypeId { get; set; } = null!;

    public DateTime? DeletedAt { get; set; }
}