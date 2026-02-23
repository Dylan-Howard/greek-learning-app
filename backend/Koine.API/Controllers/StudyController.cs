using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Study;
using Koine.Application.Interfaces;
using System.Security.Claims;

namespace Koine.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/study")]
    public class StudyController : ControllerBase
    {
        private readonly IStudyService _studyService;
        private readonly ILogger<StudyController> _logger;

        public StudyController(IStudyService studyService, ILogger<StudyController> logger)
        {
            _studyService = studyService;
            _logger = logger;
        }

        [HttpGet("sets")]
        public async Task<ActionResult<List<VocabularySetDto>>> GetUserSets()
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var sets = await _studyService.GetUserSetsAsync(userId);
                return Ok(sets);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching study sets");
                return StatusCode(500, new { message = "An error occurred while fetching study sets" });
            }
        }

        [HttpGet("sets/{id}")]
        public async Task<ActionResult<VocabularySetDto>> GetSet(int id)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var set = await _studyService.GetSetByIdAsync(id, userId);
                if (set == null)
                    return NotFound(new { message = "Study set not found" });

                return Ok(set);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching study set");
                return StatusCode(500, new { message = "An error occurred while fetching the study set" });
            }
        }

        [HttpPost("sets")]
        public async Task<ActionResult<VocabularySetDto>> CreateSet([FromBody] CreateVocabularySetDto createDto)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var set = await _studyService.CreateSetAsync(userId, createDto);
                return CreatedAtAction(nameof(GetSet), new { id = set.Id }, set);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating study set");
                return StatusCode(500, new { message = "An error occurred while creating the study set" });
            }
        }

        [HttpDelete("sets/{id}")]
        public async Task<ActionResult> DeleteSet(int id)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var success = await _studyService.DeleteSetAsync(id, userId);
                if (!success)
                    return NotFound(new { message = "Study set not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting study set");
                return StatusCode(500, new { message = "An error occurred while deleting the study set" });
            }
        }

        [HttpPost("sets/{id}/words")]
        public async Task<ActionResult> AddVocabularyToSet(int id, [FromBody] int vocabularyId)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var success = await _studyService.AddVocabularyToSetAsync(id, userId, vocabularyId);
                if (!success)
                    return NotFound(new { message = "Study set not found or not owned by user" });

                return Ok(new { message = "Vocabulary added to set successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding vocabulary to set");
                return StatusCode(500, new { message = "An error occurred while adding vocabulary to set" });
            }
        }

        [HttpPut("items/{itemId}/mastery")]
        public async Task<ActionResult> UpdateItemMastery(int itemId, [FromBody] int masteryLevel)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var success = await _studyService.UpdateItemMasteryAsync(itemId, userId, masteryLevel);
                if (!success)
                    return NotFound(new { message = "Study item not found or not owned by user" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating item mastery");
                return StatusCode(500, new { message = "An error occurred while updating item mastery" });
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
