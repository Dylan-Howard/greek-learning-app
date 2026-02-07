// GreekParser.API/Controllers/AuthController.cs
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Auth;
using GreekParser.Application.Interfaces;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

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

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] RegisterRequestDto registerDto)
        {
            try
            {
                var user = await _authService.RegisterAsync(
                    registerDto.Email, 
                    registerDto.Username, 
                    registerDto.Password);
                
                if (user == null)
                    return BadRequest(new { message = "Registration failed" });
                
                return CreatedAtAction(nameof(Register), user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during registration");
                return StatusCode(500, new { message = "An error occurred during registration" });
            }
        }
    }
}
