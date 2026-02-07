// GreekParser.API/Controllers/TranslationsController.cs
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Translations;
using GreekParser.Application.Interfaces;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class TranslationsController : ControllerBase
    {
        private readonly ITranslationService _translationService;
        private readonly ILogger<TranslationsController> _logger;

        public TranslationsController(ITranslationService translationService, ILogger<TranslationsController> logger)
        {
            _translationService = translationService;
            _logger = logger;
        }

        [HttpGet("books/{bookId}/translations")]
        public async Task<ActionResult<List<TranslationDto>>> GetByBookId(int bookId)
        {
            try
            {
                var translations = await _translationService.GetTranslationsByBookIdAsync(bookId);
                return Ok(translations);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching translations");
                return StatusCode(500, new { message = "An error occurred while fetching translations" });
            }
        }

        [HttpGet("translations/{id}")]
        public async Task<ActionResult<TranslationDto>> GetById(int id)
        {
            try
            {
                var translation = await _translationService.GetTranslationByIdAsync(id);
                if (translation == null)
                    return NotFound(new { message = "Translation not found" });

                return Ok(translation);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching translation");
                return StatusCode(500, new { message = "An error occurred while fetching the translation" });
            }
        }

        [HttpPost("books/{bookId}/translations")]
        public async Task<ActionResult<TranslationDto>> Create(int bookId, [FromBody] CreateTranslationDto createDto)
        {
            try
            {
                var translation = await _translationService.CreateTranslationAsync(bookId, createDto);
                return CreatedAtAction(nameof(GetById), new { id = translation.Id }, translation);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating translation");
                return StatusCode(500, new { message = "An error occurred while creating the translation" });
            }
        }

        [HttpPut("translations/{id}")]
        public async Task<ActionResult<TranslationDto>> Update(int id, [FromBody] UpdateTranslationDto updateDto)
        {
            try
            {
                var translation = await _translationService.UpdateTranslationAsync(id, updateDto);
                if (translation == null)
                    return NotFound(new { message = "Translation not found" });

                return Ok(translation);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating translation");
                return StatusCode(500, new { message = "An error occurred while updating the translation" });
            }
        }

        [HttpDelete("translations/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _translationService.DeleteTranslationAsync(id);
                if (!success)
                    return NotFound(new { message = "Translation not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting translation");
                return StatusCode(500, new { message = "An error occurred while deleting the translation" });
            }
        }
    }
}
