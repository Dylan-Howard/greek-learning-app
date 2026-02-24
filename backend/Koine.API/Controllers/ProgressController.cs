// Koine.API/Controllers/ProgressController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Progress;
using Koine.Application.Interfaces;
using System.Security.Claims;

namespace Koine.API.Controllers
{
    [AllowAnonymous]
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
                var userId = GetUserIdFromClaimsOrDefault();
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
                var userId = GetUserIdFromClaimsOrDefault();
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

        private int GetUserIdFromClaimsOrDefault()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out var userId))
            {
                // TODO(next phase): Re-enable strict auth and remove dev fallback.
                return 1;
            }
            return userId;
        }
    }
}
