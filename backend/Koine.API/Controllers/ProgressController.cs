// GreekParser.API/Controllers/ProgressController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Progress;
using GreekParser.Application.Interfaces;
using System.Security.Claims;

namespace GreekParser.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/progress")]
    public class ProgressController : ControllerBase
    {
        private readonly IProgressService _progressService;
        private readonly ILogger<ProgressController> _logger;

        public ProgressController(IProgressService progressService, ILogger<ProgressController> logger)
        {
            _progressService = progressService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<UserProgressDto>> Get()
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var progress = await _progressService.GetUserProgressAsync(userId);
                
                if (progress == null)
                    return NotFound(new { message = "Progress not found" });

                return Ok(progress);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching progress");
                return StatusCode(500, new { message = "An error occurred while fetching progress" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UserProgressDto progressDto)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var success = await _progressService.UpdateProgressAsync(userId, progressDto);
                
                if (!success)
                    return BadRequest(new { message = "Failed to update progress" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating progress");
                return StatusCode(500, new { message = "An error occurred while updating progress" });
            }
        }

        private int GetUserIdFromClaims()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out var userId))
            {
                throw new UnauthorizedAccessException("Invalid user token");
            }
            return userId;
        }
    }
}
