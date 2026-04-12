using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Planning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<ApiResponse<IEnumerable<PlanningWeekDto>>>> GetPlanning([FromQuery] PlanningRequest request)
    {
        var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        try
        {
            var planning = await _planningService.GetPlanningAsync(request, currentUserId, currentUserRole);

            if (!planning.Any())
            {
                return NotFound(ApiResponse<IEnumerable<PlanningWeekDto>>.Fail(BuildNoPlanningMessage(request)));
            }

            return Ok(ApiResponse<IEnumerable<PlanningWeekDto>>.Success(planning));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<IEnumerable<PlanningWeekDto>>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<IEnumerable<PlanningWeekDto>>.Fail("Internal server error"));
        }
    }

    [HttpGet("me")]
    [Authorize]
    public async Task<ActionResult<ApiResponse<IEnumerable<PlanningWeekDto>>>> GetMyPlanning([FromQuery] PlanningRequest request)
    {
        var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUserRole = User.FindFirst(ClaimTypes.Role)?.Value;

        if (string.IsNullOrEmpty(currentUserId) || string.IsNullOrEmpty(currentUserRole))
        {
            return Unauthorized(ApiResponse<IEnumerable<PlanningWeekDto>>.Fail("User is not authenticated."));
        }

        try
        {
            var planning = await _planningService.GetMyPlanningAsync(request, currentUserId, currentUserRole);

            if (!planning.Any())
            {
                return NotFound(ApiResponse<IEnumerable<PlanningWeekDto>>.Fail(BuildNoPlanningMessage(request)));
            }

            return Ok(ApiResponse<IEnumerable<PlanningWeekDto>>.Success(planning));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<IEnumerable<PlanningWeekDto>>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<IEnumerable<PlanningWeekDto>>.Fail("Internal server error"));
        }
    }

    private static string BuildNoPlanningMessage(PlanningRequest request)
    {
        if (request.StartDate.HasValue && request.EndDate.HasValue)
        {
            return $"No planning found between {request.StartDate.Value:yyyy-MM-dd} and {request.EndDate.Value:yyyy-MM-dd}.";
        }

        if (request.StartDate.HasValue)
        {
            return $"No planning found from {request.StartDate.Value:yyyy-MM-dd}.";
        }

        if (request.EndDate.HasValue)
        {
            return $"No planning found up to {request.EndDate.Value:yyyy-MM-dd}.";
        }

        return "No planning found for the requested criteria.";
    }
}
