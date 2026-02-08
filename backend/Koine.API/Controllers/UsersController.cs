// GreekParser.API/Controllers/UsersController.cs
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Auth;
using GreekParser.Application.DTOs.Users;
using GreekParser.Application.Interfaces;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetAll()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching users");
                return StatusCode(500, new { message = "An error occurred while fetching users" });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetById(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                    return NotFound(new { message = "User not found" });

                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user");
                return StatusCode(500, new { message = "An error occurred while fetching the user" });
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Create([FromBody] CreateUserDto createDto)
        {
            return StatusCode(501, new { message = "Not Implemented" });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Update(int id, [FromBody] UpdateUserDto updateDto)
        {
            try
            {
                var user = await _userService.UpdateUserAsync(id, updateDto);
                if (user == null)
                    return NotFound(new { message = "User not found" });

                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating user");
                return StatusCode(500, new { message = "An error occurred while updating the user" });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _userService.DeleteUserAsync(id);
                if (!success)
                    return NotFound(new { message = "User not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting user");
                return StatusCode(500, new { message = "An error occurred while deleting the user" });
            }
        }

        [HttpGet("{id}/lessons")]
        public async Task<ActionResult<List<UserLessonDto>>> GetUserLessons(int id)
        {
            return StatusCode(501, new { message = "Not Implemented" });
        }

        [HttpGet("{id}/words")]
        public async Task<ActionResult<List<UserWordDto>>> GetUserWords(int id)
        {
            return StatusCode(501, new { message = "Not Implemented" });
        }

        [HttpGet("{id}/settings")]
        public async Task<ActionResult<List<UserSettingDto>>> GetUserSettings(int id)
        {
            return StatusCode(501, new { message = "Not Implemented" });
        }
    }
}
