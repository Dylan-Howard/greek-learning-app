// GreekParser.API/Controllers/SyntacticalFeaturesController.cs
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Features;
using GreekParser.Application.Interfaces;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api/syntactical-features")]
    public class SyntacticalFeaturesController : ControllerBase
    {
        private readonly ISyntacticalFeatureService _featureService;
        private readonly ILogger<SyntacticalFeaturesController> _logger;

        public SyntacticalFeaturesController(ISyntacticalFeatureService featureService, ILogger<SyntacticalFeaturesController> logger)
        {
            _featureService = featureService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<SyntacticalFeatureDto>>> GetAll()
        {
            try
            {
                var features = await _featureService.GetAllFeaturesAsync();
                return Ok(features);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching syntactical features");
                return StatusCode(500, new { message = "An error occurred while fetching features" });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SyntacticalFeatureDto>> GetById(int id)
        {
            try
            {
                var feature = await _featureService.GetFeatureByIdAsync(id);
                if (feature == null)
                    return NotFound(new { message = "Feature not found" });

                return Ok(feature);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching feature");
                return StatusCode(500, new { message = "An error occurred while fetching the feature" });
            }
        }

        [HttpGet("code/{code}")]
        public async Task<ActionResult<SyntacticalFeatureDto>> GetByCode(string code)
        {
            try
            {
                var feature = await _featureService.GetFeatureByCodeAsync(code);
                if (feature == null)
                    return NotFound(new { message = "Feature not found" });

                return Ok(feature);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching feature by code");
                return StatusCode(500, new { message = "An error occurred while fetching the feature" });
            }
        }

        [HttpPost]
        public async Task<ActionResult<SyntacticalFeatureDto>> Create([FromBody] CreateSyntacticalFeatureDto createDto)
        {
            try
            {
                var feature = await _featureService.CreateFeatureAsync(createDto);
                return CreatedAtAction(nameof(GetById), new { id = feature.Id }, feature);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating feature");
                return StatusCode(500, new { message = "An error occurred while creating the feature" });
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SyntacticalFeatureDto>> Update(int id, [FromBody] UpdateSyntacticalFeatureDto updateDto)
        {
            try
            {
                var feature = await _featureService.UpdateFeatureAsync(id, updateDto);
                if (feature == null)
                    return NotFound(new { message = "Feature not found" });

                return Ok(feature);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating feature");
                return StatusCode(500, new { message = "An error occurred while updating the feature" });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _featureService.DeleteFeatureAsync(id);
                if (!success)
                    return NotFound(new { message = "Feature not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting feature");
                return StatusCode(500, new { message = "An error occurred while deleting the feature" });
            }
        }
    }
}
