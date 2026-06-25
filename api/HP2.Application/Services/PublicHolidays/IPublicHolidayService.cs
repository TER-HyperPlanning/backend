using HP2.Domain.Models;

namespace HP2.Application.Services.PublicHolidays;

/// <summary>
/// Contrat pour la gestion des jours fériés.
/// </summary>
public interface IPublicHolidayService
{
    Task<bool> IsPublicHolidayAsync(DateOnly date, CancellationToken ct = default);
    Task<IReadOnlyList<PublicHoliday>> GetHolidaysAsync(int year, CancellationToken ct = default);
}
