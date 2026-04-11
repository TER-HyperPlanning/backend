using HP2.Application.Services.PublicHolidays;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

/// <summary>
/// Expose les jours fériés au frontend.
/// </summary>
[ApiController]
[Route("api/public-holidays")]
public class PublicHolidayController : ControllerBase
{
    private readonly IPublicHolidayService _holidayService;

    public PublicHolidayController(IPublicHolidayService holidayService)
    {
        _holidayService = holidayService;
    }

    /// <summary>
    /// Retourne tous les jours fériés d'une année.
    /// GET /api/public-holidays?year=2025
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetHolidays([FromQuery] int? year)
    {
        var targetYear = year ?? DateTime.Now.Year;
        var holidays = await _holidayService.GetHolidaysAsync(targetYear);
        return Ok(holidays);
    }

    /// <summary>
    /// Vérifie si une date précise est un jour férié.
    /// GET /api/public-holidays/check?date=2025-12-25
    /// </summary>
    [HttpGet("check")]
    public async Task<IActionResult> CheckDate([FromQuery] DateOnly date)
    {
        var isHoliday = await _holidayService.IsPublicHolidayAsync(date);
        return Ok(new { date, isHoliday });
    }
}
