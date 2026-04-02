using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Planning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlanningController : ControllerBase
{
    private readonly IPlanningService _planningService;

    public PlanningController(IPlanningService planningService)
    {
        _planningService = planningService;
    }

    [HttpGet("get-planning")]
    [Authorize]
    public async Task<ActionResult<ApiResponse<IEnumerable<PlanningWeekDto>>>> GetPlanning([FromQuery] PlanningRequest request)
    {
        var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        var planning = await _planningService.GetPlanningAsync(request, currentUserId, currentUserRole);

        return Ok(ApiResponse<IEnumerable<PlanningWeekDto>>.Success(planning));
    }
}
