using HP2.Application.Contracts;
using HP2.Application.DTOs.Planning;
using HP2.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HP2.Application;

public class PlanningService : IPlanningService
{
    private readonly IPlanningRepository _planningRepository;
    private readonly IGroupRepository _groupRepository;
    private readonly ITrackRepository _trackRepository;
    private readonly IProgramRepository _programRepository;

    public PlanningService(
        IPlanningRepository planningRepository,
        IGroupRepository groupRepository,
        ITrackRepository trackRepository,
        IProgramRepository programRepository)
    {
        _planningRepository = planningRepository;
        _groupRepository = groupRepository;
        _trackRepository = trackRepository;
        _programRepository = programRepository;
    }

    public async Task<IEnumerable<PlanningWeekDto>> GetPlanningAsync(PlanningRequest request, string? currentUserId, string? currentUserRole)
    {
        if (!string.IsNullOrWhiteSpace(request.GroupId))
        {
            var groupExists = await _groupRepository.GetByIdAsync(request.GroupId);
            if (groupExists == null)
            {
                throw new ArgumentException($"Group with ID {request.GroupId} does not exist.");
            }
        }

        if (!string.IsNullOrWhiteSpace(request.TrackId))
        {
            var trackExists = await _trackRepository.ExistsAsync(request.TrackId);
            if (!trackExists)
            {
                throw new ArgumentException($"Track with ID {request.TrackId} does not exist.");
            }
        }

        if (!string.IsNullOrWhiteSpace(request.ProgramId))
        {
            var programExists = await _programRepository.GetByIdAsync(request.ProgramId);
            if (programExists == null)
            {
                throw new ArgumentException($"Program with ID {request.ProgramId} does not exist.");
            }
        }

        var sessions = await _planningRepository.GetPlanningSessionsAsync(request, currentUserId, currentUserRole);

        if (!sessions.Any())
            return new List<PlanningWeekDto>();

        var culture = new System.Globalization.CultureInfo("fr-FR");
        var result = new List<PlanningWeekDto>();

        // Find min and max date from sessions
        var minDate = sessions.Min(s => s.StartDateTime).Date;
        var maxDate = sessions.Max(s => s.StartDateTime).Date;

        // Start from the Monday of the minDate
        var diffMin = (7 + (minDate.DayOfWeek - DayOfWeek.Monday)) % 7;
        var currentStartOfWeek = minDate.AddDays(-1 * diffMin).Date;

        // Group sessions by exact date date for quick lookup
        var sessionsByDate = sessions
            .OrderBy(s => s.StartDateTime)
            .GroupBy(s => s.StartDateTime.Date)
            .ToDictionary(g => g.Key, g => g.ToList());

        // Generate weeks up to the week containing maxDate
        while (currentStartOfWeek <= maxDate)
        {
            var endOfWeek = currentStartOfWeek.AddDays(7).AddSeconds(-1);
            var weekDto = new PlanningWeekDto
            {
                WeekStartDate = currentStartOfWeek,
                WeekEndDate = endOfWeek
            };

            bool hasSessionsInWeek = false;

            for (int i = 0; i < 7; i++)
            {
                var date = currentStartOfWeek.AddDays(i);
                var dayDto = new PlanningDayDto
                {
                    Date = date,
                    DayName = culture.TextInfo.ToTitleCase(culture.DateTimeFormat.GetDayName(date.DayOfWeek)),
                    Sessions = sessionsByDate.ContainsKey(date)
                        ? sessionsByDate[date].Select(s => new PlanningSessionDto
                        {
                            Id = s.Id,
                            StartDateTime = s.StartDateTime,
                            EndDateTime = s.EndDateTime,
                            Mode = s.Mode.ToString(),
                            Type = s.SessionTypeLabel ?? string.Empty,
                            Status = s.SessionStatusLabel ?? string.Empty,
                            Room = s.RoomNumber ?? string.Empty,
                            Course = s.CourseName ?? string.Empty,
                            Description = s.Description ?? string.Empty
                        }).ToList()
                        : new List<PlanningSessionDto>()
                };

                if (dayDto.Sessions.Any())
                {
                    hasSessionsInWeek = true;
                }

                weekDto.Weekdays.Add(dayDto);
            }

            if (hasSessionsInWeek)
            {
                result.Add(weekDto);
            }
            
            currentStartOfWeek = currentStartOfWeek.AddDays(7);
        }

        return result;
    }
}
