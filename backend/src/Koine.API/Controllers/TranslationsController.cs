// Koine.API/Controllers/TranslationsController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Translations;
using Koine.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/translations")]
    public class TranslationsController : ControllerBase
    {
        private readonly ITranslationService _translationService;
        private readonly ITranslationUnitService _translationUnitService;
        private readonly ILogger<TranslationsController> _logger;

        public TranslationsController(
            ITranslationService translationService,
            ITranslationUnitService translationUnitService,
            ILogger<TranslationsController> logger)
        {
            _translationService = translationService;
            _translationUnitService = translationUnitService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<SimpleTranslationDto>> CreateTranslation([FromBody] SimpleTranslationDto translation)
        {
            try
            {
                if (translation.TranslationId <= 0)
                {
                    return BadRequest(new { message = "translationId is required for legacy translation unit creation." });
                }

                if (string.IsNullOrWhiteSpace(translation.Content))
                {
                    return BadRequest(new { message = "content is required." });
                }

                var created = await _translationUnitService.CreateUnitAsync(translation.TranslationId, new CreateTranslationUnitDto
                {
                    // Legacy payload did not have these fields; use a deterministic compatibility mapping.
                    ChapterId = translation.UnitId,
                    OriginalUnitPath = $"legacy/unit/{translation.UnitId}",
                    TranslatedText = translation.Content,
                    DisplayOrder = 0,
                    ScopeStart = null,
                    ScopeEnd = null,
                });

                var response = new SimpleTranslationDto
                {
                    TranslationGuid = Guid.NewGuid(),
                    TranslationId = created.Id,
                    UnitId = translation.UnitId,
                    Content = created.TranslatedText,
                };

                return CreatedAtAction(nameof(GetById), new { id = response.TranslationId }, response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating legacy translation unit");
                return StatusCode(500, new { message = "An error occurred while creating the translation" });
            }
        }

        [HttpGet("~/api/books/{bookId}/translations")]
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

        [HttpGet("{id}")]
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

        [HttpPost("~/api/books/{bookId}/translations")]
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

        [HttpPut("{id}")]
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

        [HttpDelete("{id}")]
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
