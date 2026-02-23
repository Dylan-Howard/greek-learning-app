// Koine.API/Controllers/TranslationUnitsController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Translations;
using Koine.Application.Interfaces;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class TranslationUnitsController : ControllerBase
    {
        private readonly ITranslationUnitService _unitService;
        private readonly ILogger<TranslationUnitsController> _logger;

        public TranslationUnitsController(ITranslationUnitService unitService, ILogger<TranslationUnitsController> logger)
        {
            _unitService = unitService;
            _logger = logger;
        }

        [HttpGet("translations/{translationId}/units")]
        public async Task<ActionResult<List<TranslationUnitDto>>> GetByTranslationId(int translationId)
        {
            try
            {
                var units = await _unitService.GetUnitsByTranslationIdAsync(translationId);
                return Ok(units);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching translation units");
                return StatusCode(500, new { message = "An error occurred while fetching translation units" });
            }
        }

        [HttpGet("translation-units/{id}")]
        public async Task<ActionResult<TranslationUnitDto>> GetById(int id)
        {
            try
            {
                var unit = await _unitService.GetUnitByIdAsync(id);
                if (unit == null)
                    return NotFound(new { message = "Translation unit not found" });

                return Ok(unit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching translation unit");
                return StatusCode(500, new { message = "An error occurred while fetching the translation unit" });
            }
        }

        [HttpPost("translations/{translationId}/units")]
        public async Task<ActionResult<TranslationUnitDto>> Create(int translationId, [FromBody] CreateTranslationUnitDto createDto)
        {
            try
            {
                var unit = await _unitService.CreateUnitAsync(translationId, createDto);
                return CreatedAtAction(nameof(GetById), new { id = unit.Id }, unit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating translation unit");
                return StatusCode(500, new { message = "An error occurred while creating the translation unit" });
            }
        }

        [HttpPost("translations/{translationId}/units/batch")]
        public async Task<ActionResult<List<TranslationUnitDto>>> BatchCreate(int translationId, [FromBody] BatchCreateTranslationUnitsDto batchDto)
        {
            try
            {
                var units = await _unitService.BatchCreateUnitsAsync(translationId, batchDto);
                return Ok(units);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error batch creating translation units");
                return StatusCode(500, new { message = "An error occurred while creating the translation units" });
            }
        }

        [HttpPut("translation-units/{id}")]
        public async Task<ActionResult<TranslationUnitDto>> Update(int id, [FromBody] UpdateTranslationUnitDto updateDto)
        {
            try
            {
                var unit = await _unitService.UpdateUnitAsync(id, updateDto);
                if (unit == null)
                    return NotFound(new { message = "Translation unit not found" });

                return Ok(unit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating translation unit");
                return StatusCode(500, new { message = "An error occurred while updating the translation unit" });
            }
        }

        [HttpDelete("translation-units/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _unitService.DeleteUnitAsync(id);
                if (!success)
                    return NotFound(new { message = "Translation unit not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting translation unit");
                return StatusCode(500, new { message = "An error occurred while deleting the translation unit" });
            }
        }
    }
}
