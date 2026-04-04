using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Unavailableday;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnavailableDaysController : ControllerBase
    {
        private readonly IUnavailabledayService _unavailabledayService;

        public UnavailableDaysController(IUnavailabledayService unavailabledayService)
        {
            _unavailabledayService = unavailabledayService;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<UnavailableDayModel>>> Create([FromBody] CreateUnavailabledayRequest request)
        {
            if (request == null)
                return BadRequest(ApiResponse<UnavailableDayModel>.Fail("UnavailableDay payload is required"));

            var unavailableDay = new UnavailableDayModel
            {
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                Type = request.Type
            };

            var createdUnavailableDay = await _unavailabledayService.CreateUnavailabledayAsync(unavailableDay);
            return CreatedAtAction(nameof(Get), new { id = createdUnavailableDay.Id },
                ApiResponse<UnavailableDayModel>.Success(createdUnavailableDay, "UnavailableDay created successfully"));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<UnavailableDayModel>>> Get(string id)
        {
            var unavailableDay = await _unavailabledayService.GetUnavailabledayByIdAsync(id);
            if (unavailableDay == null)
                return NotFound(ApiResponse<UnavailableDayModel>.Fail($"UnavailableDay with ID {id} not found"));

            return Ok(ApiResponse<UnavailableDayModel>.Success(unavailableDay));
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<UnavailableDayModel>>>> GetAll()
        {
            var unavailableDays = await _unavailabledayService.GetAllUnavailabledaysAsync();
            return Ok(ApiResponse<IEnumerable<UnavailableDayModel>>.Success(unavailableDays));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<UnavailableDayModel>>> Update(string id, [FromBody] UpdateUnavailableDayRequest request)
        {
            if (request == null)
                return BadRequest(ApiResponse<UnavailableDayModel>.Fail("UnavailableDay payload is required"));

            var existing = await _unavailabledayService.GetUnavailabledayByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<UnavailableDayModel>.Fail($"UnavailableDay with ID {id} not found"));

            existing.StartDate = request.StartDate;
            existing.EndDate = request.EndDate;
            existing.StartTime = request.StartTime;
            existing.EndTime = request.EndTime;
            existing.Type = request.Type;

            await _unavailabledayService.UpdateUnavailabledayAsync(existing);
            return Ok(ApiResponse<UnavailableDayModel>.Success(existing, "UnavailableDay updated successfully"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
        {
            var existing = await _unavailabledayService.GetUnavailabledayByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<string>.Fail($"UnavailableDay with ID {id} not found"));

            await _unavailabledayService.DeleteUnavailabledayAsync(id);
            return Ok(ApiResponse<string>.Success(id, "UnavailableDay deleted successfully"));
        }
    }
}