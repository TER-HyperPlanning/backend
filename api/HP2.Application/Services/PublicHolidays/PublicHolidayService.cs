using HP2.Domain.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace HP2.Application.Services.PublicHolidays;

/// <summary>
/// Récupère les jours fériés depuis l'API Etalab avec mise en cache annuelle.
/// Bascule sur un jeu de données statiques en mode dégradé si l'API est injoignable.
/// </summary>
public sealed class PublicHolidayService : IPublicHolidayService
{
    private const string CacheKeyPrefix = "public_holidays_";
    private readonly IMemoryCache _cache;
    private readonly HttpClient _httpClient;
    private readonly ILogger<PublicHolidayService> _logger;

    public PublicHolidayService(
        IMemoryCache cache,
        HttpClient httpClient,
        ILogger<PublicHolidayService> logger)
    {
        _cache = cache;
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<bool> IsPublicHolidayAsync(DateOnly date, CancellationToken ct = default)
    {
        var holidays = await GetHolidaysAsync(date.Year, ct);
        return holidays.Any(h => h.Date == date);
    }

    public async Task<IReadOnlyList<PublicHoliday>> GetHolidaysAsync(int year, CancellationToken ct = default)
    {
        var cacheKey = $"{CacheKeyPrefix}{year}";

        if (_cache.TryGetValue(cacheKey, out IReadOnlyList<PublicHoliday>? cached) && cached is not null)
        {
            _logger.LogDebug("Jours fériés {Year} servis depuis le cache.", year);
            return cached;
        }

        IReadOnlyList<PublicHoliday> holidays;
        try
        {
            holidays = await FetchFromApiAsync(year, ct);
            _logger.LogInformation("Jours fériés {Year} récupérés depuis l'API Etalab.", year);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "API Etalab injoignable pour {Year}. Basculement sur les données statiques.", year);
            holidays = GetStaticFallback(year);
        }

        var expiry = new DateTimeOffset(year + 1, 1, 1, 0, 0, 0, TimeSpan.Zero);
        _cache.Set(cacheKey, holidays, expiry);

        return holidays;
    }

    private async Task<IReadOnlyList<PublicHoliday>> FetchFromApiAsync(int year, CancellationToken ct)
    {
        var url = $"https://etalab.github.io/jours-feries-france/json/metropole/{year}.json";
        var response = await _httpClient.GetAsync(url, ct);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync(ct);
        var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                   ?? throw new InvalidOperationException("Réponse API vide ou invalide.");

        return dict
            .Select(kv => new PublicHoliday(DateOnly.Parse(kv.Key), kv.Value))
            .OrderBy(h => h.Date)
            .ToList()
            .AsReadOnly();
    }

    private static IReadOnlyList<PublicHoliday> GetStaticFallback(int year) =>
        new List<PublicHoliday>
        {
            new(new DateOnly(year,  1,  1), "Jour de l'An"),
            new(new DateOnly(year,  5,  1), "Fête du Travail"),
            new(new DateOnly(year,  5,  8), "Victoire 1945"),
            new(new DateOnly(year,  7, 14), "Fête Nationale"),
            new(new DateOnly(year,  8, 15), "Assomption"),
            new(new DateOnly(year, 11,  1), "Toussaint"),
            new(new DateOnly(year, 11, 11), "Armistice"),
            new(new DateOnly(year, 12, 25), "Noël"),
        }.AsReadOnly();
}
