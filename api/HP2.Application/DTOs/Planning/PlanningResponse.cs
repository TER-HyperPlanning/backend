using System;
using System.Collections.Generic;

namespace HP2.Application.DTOs.Planning;

public class PlanningWeekDto
{
    public DateTime WeekStartDate { get; set; }
    public DateTime WeekEndDate { get; set; }

    /// <summary>
    /// Les jours de la semaine contenant les sessions (Lundi -> Dimanche)
    /// </summary>
    public List<PlanningDayDto> Weekdays { get; set; } = new List<PlanningDayDto>();
}

public class PlanningDayDto
{
    public DateTime Date { get; set; }
    public string DayName { get; set; } = string.Empty;
    public List<PlanningSessionDto> Sessions { get; set; } = new List<PlanningSessionDto>();
}

public class PlanningSessionDto
{
    public string Id { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public string Mode { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Room { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
