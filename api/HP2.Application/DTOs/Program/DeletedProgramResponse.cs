namespace HP2.Application.DTOs.Program;

public class DeletedProgramResponse
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Field { get; set; } = string.Empty;
    public DateTime? DeletedAt { get; set; }
}
