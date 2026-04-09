namespace HP2.Application.DTOs.Common;

public class ApiResponse<T>
{
    public string Status { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public T? Result { get; set; }

    public static ApiResponse<T> Success(T result, string message = "")
        => new() { Status = "success", Message = message, Result = result };

    public static ApiResponse<T> Fail(string message)
        => new() { Status = "failed", Message = message, Result = default };

    public static ApiResponse<T> Fail(string message, T? result)
        => new() { Status = "failed", Message = message, Result = result };
}
