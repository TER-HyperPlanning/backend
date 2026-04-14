namespace HP2.Domain.Models;

/// <summary>
/// Représente un jour férié avec sa date et son libellé.
/// </summary>
public record PublicHoliday(DateOnly Date, string Label);
