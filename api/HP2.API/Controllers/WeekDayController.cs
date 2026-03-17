using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeekDayController : ControllerBase
{
    private readonly IWeekDayService _weekDayService;

    public WeekDayController(IWeekDayService weekDayService)
    {
        _weekDayService = weekDayService;
    }

    public class CreateWeekDayRequest
    {
        public string WeekdayId { get; set; } = null!;
        public byte OrderIndex { get; set; }
        public string Name { get; set; } = null!;
    }

    public class UpdateWeekDayRequest
    {
        public string WeekdayId { get; set; } = null!;
        public byte OrderIndex { get; set; }
        public string Name { get; set; } = null!;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<WeekDayModel>>> Create([FromBody] CreateWeekDayRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<WeekDayModel>.Fail("WeekDay payload is required"));

        try
        {
            var created = await _weekDayService.CreateAsync(new WeekDayModel
            {
                WeekdayId = request.WeekdayId,
                OrderIndex = request.OrderIndex,
                Name = request.Name
            });

            return Ok(ApiResponse<WeekDayModel>.Success(created, "WeekDay created successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<WeekDayModel>.Fail(ex.Message));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<WeekDayModel>>> Get(string id)
    {
        var item = await _weekDayService.GetByIdAsync(id);
        if (item == null)
            return NotFound(ApiResponse<WeekDayModel>.Fail($"WeekDay with ID {id} not found"));

        return Ok(ApiResponse<WeekDayModel>.Success(item));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<WeekDayModel>>>> GetAll()
    {
        var items = await _weekDayService.GetAllAsync();
        return Ok(ApiResponse<IEnumerable<WeekDayModel>>.Success(items));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<WeekDayModel>>> Update(string id, [FromBody] UpdateWeekDayRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<WeekDayModel>.Fail("WeekDay payload is required"));

        if (id != request.WeekdayId)
            return BadRequest(ApiResponse<WeekDayModel>.Fail("ID mismatch"));

        var existing = await _weekDayService.GetByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<WeekDayModel>.Fail($"WeekDay with ID {id} not found"));

        await _weekDayService.UpdateAsync(id, request.OrderIndex, request.Name);

        // Optionnel: renvoyer l'objet mis à jour comme StudentController
        existing.OrderIndex = request.OrderIndex;
        existing.Name = request.Name;

        return Ok(ApiResponse<WeekDayModel>.Success(existing, "WeekDay updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _weekDayService.GetByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"WeekDay with ID {id} not found"));

        await _weekDayService.DeleteAsync(id);
        return Ok(ApiResponse<string>.Success(id, "WeekDay deleted successfully"));
    }
}