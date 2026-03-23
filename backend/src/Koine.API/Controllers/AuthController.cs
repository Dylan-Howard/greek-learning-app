// Koine.API/Controllers/AuthController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Auth;
using Koine.Application.Interfaces;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        /// <summary>
        /// Initializes a new instance of <see cref="AuthController"/>.
        /// </summary>
        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        /// <summary>
        /// Authenticates a user and returns a JWT token.
        /// </summary>
        [HttpPost("login")]
        public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginRequestDto loginDto)
        {
            try
            {
                var result = await _authService.LoginAsync(loginDto);
                
                if (result == null)
                    return Unauthorized(new { message = "Invalid credentials" });
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login");
                return StatusCode(500, new { message = "An error occurred during login" });
            }
        }

        /// <summary>
        /// Deprecated. Users are provisioned automatically on first Clerk sign-in.
        /// </summary>
        /// <returns>HTTP 410 Gone.</returns>
        [HttpPost("register")]
        public IActionResult Register()
        {
            _logger.LogWarning("Deprecated POST /api/auth/register endpoint was called. Users are now provisioned via Clerk.");
            return StatusCode(410, new { message = "Registration via this endpoint is deprecated. Users are provisioned automatically on first Clerk sign-in." });
        }
    }
}
