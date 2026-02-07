// GreekParser.API/Controllers/VocabularyController.cs
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Common;
using GreekParser.Application.DTOs.Vocabulary;
using GreekParser.Application.Interfaces;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api/vocabulary")]
    public class VocabularyController : ControllerBase
    {
        private readonly IVocabularyService _vocabularyService;
        private readonly ILogger<VocabularyController> _logger;

        public VocabularyController(IVocabularyService vocabularyService, ILogger<VocabularyController> logger)
        {
            _vocabularyService = vocabularyService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedResultDto<VocabularyDto>>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 50)
        {
            try
            {
                var result = await _vocabularyService.GetVocabularyAsync(page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching vocabulary");
                return StatusCode(500, new { message = "An error occurred while fetching vocabulary" });
            }
        }

        [HttpGet("search")]
        public async Task<ActionResult<PaginatedResultDto<VocabularyDto>>> Search([FromQuery] VocabularySearchDto searchDto)
        {
            try
            {
                var result = await _vocabularyService.SearchVocabularyAsync(searchDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching vocabulary");
                return StatusCode(500, new { message = "An error occurred while searching vocabulary" });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VocabularyDto>> GetById(int id)
        {
            try
            {
                var vocab = await _vocabularyService.GetVocabularyByIdAsync(id);
                if (vocab == null)
                    return NotFound(new { message = "Vocabulary not found" });

                return Ok(vocab);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching vocabulary");
                return StatusCode(500, new { message = "An error occurred while fetching the vocabulary" });
            }
        }

        [HttpPost]
        public async Task<ActionResult<VocabularyDto>> Create([FromBody] CreateVocabularyDto createDto)
        {
            try
            {
                var vocab = await _vocabularyService.CreateVocabularyAsync(createDto);
                return CreatedAtAction(nameof(GetById), new { id = vocab.Id }, vocab);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating vocabulary");
                return StatusCode(500, new { message = "An error occurred while creating the vocabulary" });
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VocabularyDto>> Update(int id, [FromBody] UpdateVocabularyDto updateDto)
        {
            try
            {
                var vocab = await _vocabularyService.UpdateVocabularyAsync(id, updateDto);
                if (vocab == null)
                    return NotFound(new { message = "Vocabulary not found" });

                return Ok(vocab);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating vocabulary");
                return StatusCode(500, new { message = "An error occurred while updating the vocabulary" });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _vocabularyService.DeleteVocabularyAsync(id);
                if (!success)
                    return NotFound(new { message = "Vocabulary not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting vocabulary");
                return StatusCode(500, new { message = "An error occurred while deleting the vocabulary" });
            }
        }
    }
}
