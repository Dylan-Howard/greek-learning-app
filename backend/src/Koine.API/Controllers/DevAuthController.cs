// Koine.API/Controllers/DevAuthController.cs
#if DEBUG
using Microsoft.AspNetCore.Mvc;
using Koine.Application.Interfaces;

namespace Koine.API.Controllers
{
    /// <summary>
    /// Development-only authentication endpoints
    /// </summary>
    [ApiController]
    [Route("api/dev")]
    public class DevAuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly ILogger<DevAuthController> _logger;

        public DevAuthController(
            IAuthService authService, 
            IConfiguration configuration,
            ILogger<DevAuthController> logger)
        {
            _authService = authService;
            _configuration = configuration;
            _logger = logger;
        }

        /// <summary>
        /// Get a test token for development
        /// </summary>
        [HttpGet("token")]
        public async Task<ActionResult<object>> GetDevToken([FromQuery] string? username = null)
        {
            var testUsername = username ?? _configuration["DevSettings:DefaultTestUser"] ?? "beginner";
            
            try
            {
                var loginResult = await _authService.LoginAsync(new Application.DTOs.Auth.LoginRequestDto
                {
                    Email = $"{testUsername}@test.com",
                    Password = "password123"
                });

                if (loginResult == null)
                {
                    return NotFound(new { message = $"Test user '{testUsername}' not found. Available: beginner, intermediate, advanced, struggling" });
                }

                return Ok(new
                {
                    token = loginResult.Token,
                    user = loginResult.User,
                    message = "⚠️  DEVELOPMENT TOKEN - Do not use in production!"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting dev token");
                return StatusCode(500, new { message = "Error generating dev token" });
            }
        }

        /// <summary>
        /// List available test users
        /// </summary>
        [HttpGet("users")]
        public ActionResult<object> GetTestUsers()
        {
            return Ok(new
            {
                users = new[]
                {
                    new { username = "beginner", email = "beginner@test.com", level = "Knows basic parts of speech" },
                    new { username = "intermediate", email = "intermediate@test.com", level = "Knows grammar, limited syntax" },
                    new { username = "advanced", email = "advanced@test.com", level = "Knows most features" },
                    new { username = "struggling", email = "struggling@test.com", level = "Needs practice on basics" }
                },
                password = "password123",
                note = "These users are created by the seeding script"
            });
        }
    }
}
#endif