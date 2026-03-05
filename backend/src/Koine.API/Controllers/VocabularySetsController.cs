using Koine.Application.DTOs.Study;
using Koine.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Koine.API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/vocabulary-sets")]
    public class VocabularySetsController : ControllerBase
    {
        private readonly IStudyService _studyService;
        private readonly ILogger<VocabularySetsController> _logger;

        public VocabularySetsController(IStudyService studyService, ILogger<VocabularySetsController> logger)
        {
            _studyService = studyService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<VocabularySetDto>>> GetAll()
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var sets = await _studyService.GetUserSetsAsync(userId);
                return Ok(sets);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching vocabulary sets");
                return StatusCode(500, new { message = "An error occurred while fetching vocabulary sets" });
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<VocabularySetDto>> GetById(int id)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var set = await _studyService.GetSetByIdAsync(id, userId);
                if (set == null) return NotFound(new { message = "Vocabulary set not found" });
                return Ok(set);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching vocabulary set {SetId}", id);
                return StatusCode(500, new { message = "An error occurred while fetching the vocabulary set" });
            }
        }

        [HttpPost]
        public async Task<ActionResult<VocabularySetDto>> Create([FromBody] CreateVocabularySetDto createDto)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var created = await _studyService.CreateSetAsync(userId, createDto);
                return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating vocabulary set");
                return StatusCode(500, new { message = "An error occurred while creating the vocabulary set" });
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<VocabularySetDto>> Update(int id, [FromBody] UpdateVocabularySetDto updateDto)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var updated = await _studyService.UpdateSetAsync(id, userId, updateDto);
                if (updated == null)
                {
                    return NotFound(new { message = "Vocabulary set not found or cannot be updated" });
                }

                return Ok(updated);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating vocabulary set {SetId}", id);
                return StatusCode(500, new { message = "An error occurred while updating the vocabulary set" });
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var deleted = await _studyService.DeleteSetAsync(id, userId);
                if (!deleted) return NotFound(new { message = "Vocabulary set not found or cannot be deleted" });
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting vocabulary set {SetId}", id);
                return StatusCode(500, new { message = "An error occurred while deleting the vocabulary set" });
            }
        }

        [HttpPost("{id:int}/items")]
        public async Task<ActionResult> AddVocabulary(int id, [FromBody] AddVocabularySetItemDto request)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var success = await _studyService.AddVocabularyToSetAsync(id, userId, request.VocabularyId);
                if (!success)
                {
                    return NotFound(new { message = "Vocabulary set not found or cannot be modified" });
                }

                return Ok(new { message = "Vocabulary added to set" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding vocabulary to set {SetId}", id);
                return StatusCode(500, new { message = "An error occurred while adding vocabulary to the set" });
            }
        }

        [HttpDelete("{id:int}/items/{vocabularyId:int}")]
        public async Task<ActionResult> RemoveVocabulary(int id, int vocabularyId)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var success = await _studyService.RemoveVocabularyFromSetAsync(id, userId, vocabularyId);
                if (!success)
                {
                    return NotFound(new { message = "Vocabulary set not found or cannot be modified" });
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removing vocabulary from set {SetId}", id);
                return StatusCode(500, new { message = "An error occurred while removing vocabulary from the set" });
            }
        }

        [HttpPut("{id:int}/progress/{vocabularyId:int}")]
        public async Task<ActionResult> UpdateProgress(int id, int vocabularyId, [FromBody] UpdateVocabularySetProgressDto request)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var success = await _studyService.UpdateVocabularyProgressAsync(id, userId, vocabularyId, request.MasteryLevel);
                if (!success)
                {
                    return NotFound(new { message = "Vocabulary set or vocabulary item not found" });
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating progress for set {SetId}", id);
                return StatusCode(500, new { message = "An error occurred while updating progress" });
            }
        }

        private int GetUserIdFromClaimsOrDefault()
        {
            var userIdClaim = HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!string.IsNullOrEmpty(userIdClaim) && int.TryParse(userIdClaim, out var claimUserId))
            {
                return claimUserId;
            }

            var headerValue = HttpContext?.Request?.Headers["X-Dev-User-Id"].FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(headerValue) && int.TryParse(headerValue, out var headerUserId) && headerUserId > 0)
            {
                return headerUserId;
            }

            // TODO(next phase): Re-enable strict auth and remove dev fallback.
            return 1;
        }
    }
}
