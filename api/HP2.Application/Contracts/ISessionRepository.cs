using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionRepository : IAsyncRepository<SessionModel>
{
    // On ajoute cette méthode pour le filtrage complexe (Planning)
    Task<IEnumerable<SessionModel>> GetPlanningAsync(string? trackId, string? programId, string? niveau);

    Task<string?> GetSessionTypeIdByLabelAsync(string label);
    Task<string?> GetSessionStatusIdByLabelAsync(string label);
    Task<bool> CourseExistsAsync(string courseId);
    Task<bool> RoomExistsAsync(string roomId);
}