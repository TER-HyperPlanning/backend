using HP2.Application.Contracts;
using HP2.Application.DTOs.Auth;
using HP2.Application.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBasedotn
    {
        private readonly IAuthenticationService _authService;

        public AuthController(IAuthenticationService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<ApiResponse<LoginResponse>>> Login([FromBody] LoginRequest request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Email))
                    return BadRequest(ApiResponse<LoginResponse>.Fail("Email address is required"));

                if (!System.Text.RegularExpressions.Regex.IsMatch(request.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    return BadRequest(ApiResponse<LoginResponse>.Fail("Email address is not valid"));

                if (string.IsNullOrWhiteSpace(request.Password))
                    return BadRequest(ApiResponse<LoginResponse>.Fail("Password is required"));

                var response = await _authService.Login(request);
                return Ok(ApiResponse<LoginResponse>.Success(response, "Login successful"));
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(ApiResponse<LoginResponse>.Fail("Invalid email or password"));
            }
            catch (Exception)
            {
                return StatusCode(500, ApiResponse<LoginResponse>.Fail("An internal error occurred. Please try again later"));
            }
        }

        [HttpGet("current-user")]
        [Authorize]
        public async Task<ActionResult<ApiResponse<CurrentUserResponse>>> GetCurrentUser()
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId))
                    return Unauthorized(ApiResponse<CurrentUserResponse>.Fail("Invalid or expired token"));

                var response = await _authService.GetCurrentUser(userId);
                return Ok(ApiResponse<CurrentUserResponse>.Success(response));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ApiResponse<CurrentUserResponse>.Fail(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<CurrentUserResponse>.Fail(ex.Message));
            }
        }
    }
}
