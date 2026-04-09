using HP2.Application.DTOs.Session;

namespace HP2.Application.Exceptions;

public class DeleteConflictException : InvalidOperationException
{
    public object BlockingResource { get; }
    public BlockingSessionInfo? BlockingSession => BlockingResource as BlockingSessionInfo;

    public DeleteConflictException(string message, object blockingResource)
        : base(message)
    {
        BlockingResource = blockingResource;
    }

    public DeleteConflictException(string message, BlockingSessionInfo blockingSession)
        : this(message, (object)blockingSession)
    {
    }
}
