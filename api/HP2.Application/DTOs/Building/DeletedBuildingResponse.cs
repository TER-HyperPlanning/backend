namespace HP2.Application.DTOs.Building;

public class DeletedBuildingResponse
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public DateTime? DeletedAt { get; set; }
}
