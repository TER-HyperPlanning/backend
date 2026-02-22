using HP2.Application.Contracts;
using HP2.Application.DTOs.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthController(IAuthenticationService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Email))
                {
                    return BadRequest(new { message = "Email address is required." });
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(request.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    return BadRequest(new { message = "Email address is not valid." });
                }

                if (string.IsNullOrWhiteSpace(request.Password))
                {
                    return BadRequest(new { message = "Password is required." });
                }

                var response = await _authService.Login(request);
                return Ok(response);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An internal error occurred. Please try again later." });
            }
        }

        [HttpGet("current-user")]
        [Authorize]
        public async Task<ActionResult<CurrentUserResponse>> GetCurrentUser()
        {
            try
            {
                // Récupérer l'ID de l'utilisateur depuis le token JWT
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized(new { message = "Invalid or expired token." });
                }

                var response = await _authService.GetCurrentUser(userId);
                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred.", details = ex.Message });
            }
        }
    }
}
