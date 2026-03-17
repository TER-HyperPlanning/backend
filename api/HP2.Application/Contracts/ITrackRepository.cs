using System.Threading.Tasks;

namespace HP2.Application.Contracts;

public interface ITrackRepository
{
    Task<bool> ExistsAsync(string trackId);
}