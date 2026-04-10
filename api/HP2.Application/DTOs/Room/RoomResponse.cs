using System;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.RoomDtos;

public class RoomResponse
{
    public string RoomId { get; set; } = null!;

    public string RoomNumber { get; set; } = null!;

    public bool? IsAvailable { get; set; }

    public int Capacity { get; set; }

    public string BuildingId { get; set; } = null!;

    public RoomTypeEnum Type { get; set; }

    public DateTime? DeletedAt { get; set; }
}