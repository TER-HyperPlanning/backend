using HP2.Application.Contracts;
using HP2.Application.DTOs.Availability;
using HP2.Application.DTOs.Common;
using HP2.Domain.Enums;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AvailabilitiesController : ControllerBase
{
    private readonly IAvailabilityService _service;
    private readonly IWeekDayService _weekDayService;

    public AvailabilitiesController(IAvailabilityService service, IWeekDayService weekDayService)
    {
        _service = service;
        _weekDayService = weekDayService;
    }

    [HttpGet("teacher/{teacherId}")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AvailabilityResponse>>>> GetByTeacher(string teacherId)
    {
        try
        {
            var data = await _service.GetByTeacherAsync(teacherId);
            return Ok(ApiResponse<IEnumerable<AvailabilityResponse>>.Success(data));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<IEnumerable<AvailabilityResponse>>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<AvailabilityResponse>>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<AvailabilityResponse>>> Create([FromBody] CreateAvailabilityRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var invalidEnumFields = GetInvalidEnumFieldsFromModelState();
                if (invalidEnumFields.Any())
                {
                    return BadRequest(ApiResponse<AvailabilityResponse>.Fail(
                        $"Invalid field values: {string.Join(", ", invalidEnumFields.Select(FormatFieldWithAllowedValues))}"));
                }

                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                return BadRequest(ApiResponse<AvailabilityResponse>.Fail(string.Join(" | ", errors)));
            }

            var model = new AvailabilityModel
            {
                WeekDayId = await ResolveWeekDayIdAsync(request.WeekDay),
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TeacherId = request.TeacherId,
                AvailabilityGroupId = request.AvailabilityGroupId
            };

            var result = await _service.CreateAsync(model);
            return Ok(ApiResponse<AvailabilityResponse>.Success(result, "Availability created successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<AvailabilityResponse>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<AvailabilityResponse>>> Update(string id, [FromBody] UpdateAvailabilityRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var invalidEnumFields = GetInvalidEnumFieldsFromModelState();
                if (invalidEnumFields.Any())
                {
                    return BadRequest(ApiResponse<AvailabilityResponse>.Fail(
                        $"Invalid field values: {string.Join(", ", invalidEnumFields.Select(FormatFieldWithAllowedValues))}"));
                }

                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                return BadRequest(ApiResponse<AvailabilityResponse>.Fail(string.Join(" | ", errors)));
            }

            var model = new AvailabilityModel
            {
                Id = id,
                WeekDayId = await ResolveWeekDayIdAsync(request.WeekDay),
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TeacherId = request.TeacherId,
                AvailabilityGroupId = request.AvailabilityGroupId
            };

            var result = await _service.UpdateAsync(id, model);
            return Ok(ApiResponse<AvailabilityResponse>.Success(result, "Availability updated successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<AvailabilityResponse>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        try
        {
            await _service.DeleteAsync(id);
            return Ok(ApiResponse<string>.Success(id, "Availability deleted successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    private async Task<string> ResolveWeekDayIdAsync(WeekDay weekDay)
    {
        var weekDayName = weekDay.ToString();
        var weekDays = await _weekDayService.GetAllAsync();

        var matchedWeekDay = weekDays
            .FirstOrDefault(w => w.Name.Equals(weekDayName, StringComparison.OrdinalIgnoreCase));

        if (matchedWeekDay == null)
            throw new InvalidOperationException($"Invalid field values: {FormatFieldWithAllowedValues("weekDay")}");

        return matchedWeekDay.WeekdayId;
    }

    private static readonly Dictionary<string, string> EnumAllowedValues = new(StringComparer.OrdinalIgnoreCase)
    {
        ["weekDay"] = string.Join(", ", Enum.GetNames<WeekDay>())
    };

    private IEnumerable<string> GetInvalidEnumFieldsFromModelState()
    {
        return ModelState
            .Where(x => x.Value != null && x.Value.Errors.Any(e =>
                !string.IsNullOrWhiteSpace(e.ErrorMessage) &&
                e.ErrorMessage.Contains("could not be converted", StringComparison.OrdinalIgnoreCase)))
            .Select(x => NormalizeFieldName(x.Key))
            .Where(x => !string.IsNullOrWhiteSpace(x) && EnumAllowedValues.ContainsKey(x))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private static string NormalizeFieldName(string key)
    {
        var normalized = key.Replace("$.", string.Empty, StringComparison.OrdinalIgnoreCase);
        var parts = normalized.Split('.', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return string.Empty;

        var field = parts.Last();
        return char.ToLowerInvariant(field[0]) + field[1..];
    }

    private static string FormatFieldWithAllowedValues(string field)
    {
        return EnumAllowedValues.TryGetValue(field, out var allowedValues)
            ? $"{field}( {allowedValues} )"
            : field;
    }
}
