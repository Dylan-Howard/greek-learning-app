// Koine.API/Controllers/GrammaticalFeaturesController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Features;
using Koine.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/grammaticalForms")]
    public class GrammaticalFeaturesController : ControllerBase
    {
        private readonly IGrammaticalFeatureService _featureService;
        private readonly ILogger<GrammaticalFeaturesController> _logger;

        public GrammaticalFeaturesController(IGrammaticalFeatureService featureService, ILogger<GrammaticalFeaturesController> logger)
        {
            _featureService = featureService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<SimpleGrammaticalFormDto>>> GetAll()
        {
            // Placeholder implementation
            var features = new List<SimpleGrammaticalFormDto>
            {
                new SimpleGrammaticalFormDto { GrammarId = 1, Name = "Noun", Abbreviation = "N", LessonId = 2, GrammarGUID = Guid.NewGuid() },
                new SimpleGrammaticalFormDto { GrammarId = 2, Name = "Verb", Abbreviation = "V", LessonId = 3, GrammarGUID = Guid.NewGuid() }
            };
            return Ok(features);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SimpleGrammaticalFormDto>> GetById(int id)
        {
            // Placeholder implementation
            if (id > 2)
            {
                return NotFound(new { message = "Feature not found" });
            }
            var feature = new SimpleGrammaticalFormDto { GrammarId = id, Name = "Placeholder", Abbreviation = "P", LessonId = 1, GrammarGUID = Guid.NewGuid() };
            return Ok(feature);
        }

        [HttpPost]
        public async Task<ActionResult<SimpleGrammaticalFormDto>> Create([FromBody] SimpleGrammaticalFormDto createDto)
        {
            // Placeholder implementation
            createDto.GrammarId = 99;
            createDto.GrammarGUID = Guid.NewGuid();
            return CreatedAtAction(nameof(GetById), new { id = createDto.GrammarId }, createDto);
        }

        // [HttpGet("code/{code}")]
        // public async Task<ActionResult<GrammaticalFeatureDto>> GetByCode(string code)
        // {
        //     try
        //     {
        //         var feature = await _featureService.GetFeatureByCodeAsync(code);
        //         if (feature == null)
        //             return NotFound(new { message = "Feature not found" });

        //         return Ok(feature);
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.LogError(ex, "Error fetching feature by code");
        //         return StatusCode(500, new { message = "An error occurred while fetching the feature" });
        //     }
        // }

        // [HttpPut("{id}")]
        // public async Task<ActionResult<GrammaticalFeatureDto>> Update(int id, [FromBody] UpdateGrammaticalFeatureDto updateDto)
        // {
        //     try
        //     {
        //         var feature = await _featureService.UpdateFeatureAsync(id, updateDto);
        //         if (feature == null)
        //             return NotFound(new { message = "Feature not found" });

        //         return Ok(feature);
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.LogError(ex, "Error updating feature");
        //         return StatusCode(500, new { message = "An error occurred while updating the feature" });
        //     }
        // }

        // [HttpDelete("{id}")]
        // public async Task<ActionResult> Delete(int id)
        // {
        //     try
        //     {
        //         var success = await _featureService.DeleteFeatureAsync(id);
        //         if (!success)
        //             return NotFound(new { message = "Feature not found" });

        //         return NoContent();
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.LogError(ex, "Error deleting feature");
        //         return StatusCode(500, new { message = "An error occurred while deleting the feature" });
        //     }
        // }
    }
}
