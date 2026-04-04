using System;
using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Planning;

public class PlanningRequest
{
    public string? GroupId { get; set; }
    public string? TrackId { get; set; }
    public string? ProgramId { get; set; }
    
    // Optional date range
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
