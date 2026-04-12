using System;
using System.ComponentModel.DataAnnotations;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.RoomDtos;

public class RoomRequest
{
    public string? RoomId { get; set; }

    [Required]
    [MinLength(1)]
    public string RoomNumber { get; set; } = null!;



    public bool? IsAvailable { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0")]
    public int Capacity { get; set; }

    [Required]
    [MinLength(1)]
    public string BuildingId { get; set; } = null!;

    [Required]
    public RoomTypeEnum? Type { get; set; }
}