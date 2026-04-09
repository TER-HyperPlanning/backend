using System.Text.Json.Serialization;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Session;

public class DeletedSessionResponse
{
    public string Id { get; set; } = string.Empty;

    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SessionMode Mode { get; set; }

    public string SessionTypeId { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public string SessionStatusId { get; set; } = string.Empty;
    public string RoomId { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime? DeletedAt { get; set; }
}