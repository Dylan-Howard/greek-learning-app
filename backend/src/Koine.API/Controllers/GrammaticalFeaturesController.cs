// Koine.API/Controllers/GrammaticalFeaturesController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Features;
using Koine.Application.DTOs.Lessons;
using Koine.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/grammaticalForms")]
    public class GrammaticalFeaturesController : ControllerBase
    {
        private readonly IGrammaticalFeatureService _featureService;
        private readonly ILessonService _lessonService;
        private readonly ILogger<GrammaticalFeaturesController> _logger;

        public GrammaticalFeaturesController(
            IGrammaticalFeatureService featureService,
            ILessonService lessonService,
            ILogger<GrammaticalFeaturesController> logger)
        {
            _featureService = featureService;
            _lessonService = lessonService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<SimpleGrammaticalFormDto>>> GetAll()
        {
            try
            {
                var features = await _featureService.GetAllFeaturesAsync();
                var lessons = await _lessonService.GetAllLessonsAsync(0);

                var lessonLookup = lessons
                    .SelectMany(l => l.GrammaticalFeatureIds.Select(gid => new { gid, lessonId = l.Id }))
                    .GroupBy(x => x.gid)
                    .ToDictionary(g => g.Key, g => g.Select(x => x.lessonId).FirstOrDefault());

                var forms = features.Select(f => new SimpleGrammaticalFormDto
                {
                    GrammarGUID = BuildStableGuid(f.Id),
                    GrammarId = f.Id,
                    Name = f.Name,
                    Abbreviation = f.Code,
                    LessonId = lessonLookup.GetValueOrDefault(f.Id, 0),
                }).ToList();

                return Ok(forms);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching grammatical forms");
                return StatusCode(500, new { message = "An error occurred while fetching grammatical forms" });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SimpleGrammaticalFormDto>> GetById(int id)
        {
            try
            {
                var feature = await _featureService.GetFeatureByIdAsync(id);
                if (feature == null)
                    return NotFound(new { message = "Feature not found" });

                var lessons = await _lessonService.GetAllLessonsAsync(0);
                var lessonId = lessons
                    .FirstOrDefault(l => l.GrammaticalFeatureIds.Contains(id))
                    ?.Id ?? 0;

                return Ok(new SimpleGrammaticalFormDto
                {
                    GrammarGUID = BuildStableGuid(feature.Id),
                    GrammarId = feature.Id,
                    Name = feature.Name,
                    Abbreviation = feature.Code,
                    LessonId = lessonId,
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching grammatical form {Id}", id);
                return StatusCode(500, new { message = "An error occurred while fetching grammatical form" });
            }
        }

        [HttpPost]
        public async Task<ActionResult<SimpleGrammaticalFormDto>> Create([FromBody] SimpleGrammaticalFormDto createDto)
        {
            try
            {
                var created = await _featureService.CreateFeatureAsync(new CreateGrammaticalFeatureDto
                {
                    Code = string.IsNullOrWhiteSpace(createDto.Abbreviation) ? $"GF-{Guid.NewGuid():N}" : createDto.Abbreviation,
                    Name = createDto.Name,
                    Category = "legacy",
                    Definition = null,
                    SortOrder = 0,
                });

                var response = new SimpleGrammaticalFormDto
                {
                    GrammarGUID = BuildStableGuid(created.Id),
                    GrammarId = created.Id,
                    Name = created.Name,
                    Abbreviation = created.Code,
                    LessonId = createDto.LessonId,
                };

                return CreatedAtAction(nameof(GetById), new { id = response.GrammarId }, response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating grammatical form");
                return StatusCode(500, new { message = "An error occurred while creating grammatical form" });
            }
        }

        [HttpGet("{id}/lessons")]
        public async Task<ActionResult<List<LessonDto>>> GetLessonsByGrammaticalForm(int id)
        {
            try
            {
                var lessons = await _lessonService.GetAllLessonsAsync(0);
                var filtered = lessons
                    .Where(l => l.GrammaticalFeatureIds.Contains(id))
                    .ToList();

                return Ok(filtered);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching lessons by grammatical form {Id}", id);
                return StatusCode(500, new { message = "An error occurred while fetching lessons by grammatical form" });
            }
        }

        private static Guid BuildStableGuid(int value)
        {
            Span<byte> bytes = stackalloc byte[16];
            BitConverter.TryWriteBytes(bytes, value);
            return new Guid(bytes);
        }
    }
}
