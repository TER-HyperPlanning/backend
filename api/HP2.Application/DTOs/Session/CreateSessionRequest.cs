using HP2.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Session;

public class CreateSessionRequest
{
    [Required]
    public DateTime Date { get; set; }

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }

    [Required]
    public SessionMode Mode { get; set; }

    [Required]
    public string SessionTypeId { get; set; } = string.Empty;

    [Required]
    public string CourseId { get; set; } = string.Empty;

    [Required]
    public string SessionStatusId { get; set; } = string.Empty;

    [Required]
    public string RoomId { get; set; } = string.Empty;
}