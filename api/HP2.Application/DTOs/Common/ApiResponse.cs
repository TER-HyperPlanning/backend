namespace HP2.Application.DTOs.Common;

public class ApiResponse<T>
{
    public string Status { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public T? Result { get; set; }
    public int? StatusCode { get; set; }

    public static ApiResponse<T> Success(T result, string message = "", int statusCode = 200)
        => new() { Status = "success", Message = message, Result = result, StatusCode = statusCode };

    public static ApiResponse<T> Fail(string message, int statusCode = 400)
        => new() { Status = "failed", Message = message, Result = default, StatusCode = statusCode };
}
