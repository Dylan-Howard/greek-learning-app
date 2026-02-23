// Koine.API/Controllers/VocabularyController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Common;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/words")]
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
        public async Task<ActionResult<List<SimpleWordDto>>> GetAll([FromQuery] int? occurances, [FromQuery] string? comparison)
        {
            try
            {
                var words = await _vocabularyService.GetAllSimpleAsync();

                if (occurances.HasValue && !string.IsNullOrEmpty(comparison))
                {
                    if (comparison == "greater")
                    {
                        words = words.Where(w => w.Occurances > occurances.Value).ToList();
                    }
                    else
                    {
                        words = words.Where(w => w.Occurances < occurances.Value).ToList();
                    }
                }

                return Ok(words);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching vocabulary");
                return StatusCode(500, new { message = "An error occurred while fetching vocabulary" });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SimpleWordDto>> GetById(int id)
        {
            try
            {
                var word = await _vocabularyService.GetSimpleByIdAsync(id);
                if (word == null)
                    return NotFound(new { message = "Word not found" });

                return Ok(word);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching word");
                return StatusCode(500, new { message = "An error occurred while fetching the word" });
            }
        }

        [HttpPost("update")]
        public async Task<ActionResult> UpdateWord([FromBody] SimpleWordDto word)
        {
            try
            {
                var success = await _vocabularyService.UpdateSimpleWordAsync(word);
                if (!success)
                    return NotFound(new { message = "Word not found" });

                return Ok(new { message = "Word updated successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating word");
                return StatusCode(500, new { message = "An error occurred while updating the word" });
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
