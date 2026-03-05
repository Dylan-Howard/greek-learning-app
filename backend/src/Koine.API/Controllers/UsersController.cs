// Koine.API/Controllers/UsersController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Auth;
using Koine.Application.DTOs.Users;
using Koine.Application.Interfaces;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IProgressService _progressService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, IProgressService progressService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _progressService = progressService;
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
            try
            {
                var user = await _userService.CreateUserAsync(createDto);
                if (user == null)
                    return BadRequest(new { message = "Failed to create user. User may already exist or input is invalid." });

                return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating user");
                return StatusCode(500, new { message = "An error occurred while creating the user" });
            }
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
            try
            {
                var lessons = await _progressService.GetUserLessonsAsync(id);
                return Ok(lessons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user lessons");
                return StatusCode(500, new { message = "An error occurred while fetching user lessons" });
            }
        }

        [HttpGet("{id}/words")]
        public async Task<ActionResult<List<UserWordDto>>> GetUserWords(int id)
        {
            try
            {
                var words = await _progressService.GetUserVocabularyAsync(id);
                return Ok(words);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user words");
                return StatusCode(500, new { message = "An error occurred while fetching user words" });
            }
        }

        [HttpGet("{id}/settings")]
        public async Task<ActionResult<List<UserSettingDto>>> GetUserSettings(int id)
        {
            try
            {
                var settings = await _userService.GetUserSettingsAsync(id);
                return Ok(settings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user settings");
                return StatusCode(500, new { message = "An error occurred while fetching user settings" });
            }
        }

        [HttpPut("{id}/settings")]
        public async Task<ActionResult> UpdateUserSettings(int id, [FromBody] UserSettingDto settingDto)
        {
            try
            {
                var success = await _userService.UpdateUserSettingAsync(id, settingDto);
                if (!success)
                    return BadRequest(new { message = "Failed to update user setting" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating user setting");
                return StatusCode(500, new { message = "An error occurred while updating the user setting" });
            }
        }
    }
}
