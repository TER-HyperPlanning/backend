using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionRepository : IAsyncRepository<SessionModel>
{
}