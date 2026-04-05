using HP2.Application.DTOs.Planning;
using HP2.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts;

public interface IPlanningRepository
{
    Task<IEnumerable<SessionModel>> GetPlanningSessionsAsync(PlanningRequest request, string? currentUserId, string? currentUserRole);
    Task<IEnumerable<SessionModel>> GetMyPlanningSessionsAsync(PlanningRequest request, string currentUserId, string currentUserRole);
}
