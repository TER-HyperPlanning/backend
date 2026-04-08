using HP2.Application.DTOs.Session;

namespace HP2.Application.Exceptions;

public class DeleteConflictException : InvalidOperationException
{
    public BlockingSessionInfo BlockingSession { get; }

    public DeleteConflictException(string message, BlockingSessionInfo blockingSession)
        : base(message)
    {
        BlockingSession = blockingSession;
    }
}
