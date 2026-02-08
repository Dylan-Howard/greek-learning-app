// GreekParser.API/Controllers/LessonsController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Lessons;
using GreekParser.Application.Interfaces;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api/lessons")]
    public class LessonsController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        private readonly ILogger<LessonsController> _logger;

        public LessonsController(ILessonService lessonService, ILogger<LessonsController> logger)
        {
            _lessonService = lessonService;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<SimpleLessonDto>>> GetAllLessons()
        {
            // Placeholder implementation
            var lessons = new List<SimpleLessonDto>
            {
                new SimpleLessonDto { LessonId = 1, Title = "Lesson 1: The Alphabet", LessonGUID = Guid.NewGuid() },
                new SimpleLessonDto { LessonId = 2, Title = "Lesson 2: Nouns", LessonGUID = Guid.NewGuid() }
            };
            return Ok(lessons);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<SimpleLessonDto>> GetLesson(int id)
        {
            // Placeholder implementation
            if (id > 2)
            {
                return NotFound(new { message = "Lesson not found" });
            }
            var lesson = new SimpleLessonDto { LessonId = id, Title = $"Lesson {id}", LessonGUID = Guid.NewGuid() };
            return Ok(lesson);
        }
        
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<SimpleLessonDto>> CreateLesson([FromBody] SimpleLessonDto lesson)
        {
            // Placeholder implementation
            lesson.LessonId = 99; // Dummy ID
            lesson.LessonGUID = Guid.NewGuid();
            return CreatedAtAction(nameof(GetLesson), new { id = lesson.LessonId }, lesson);
        }

        [Authorize]
        [HttpPost("{id}/complete")]
        public async Task<ActionResult> CompleteLesson(int id, [FromBody] CompleteLessonDto completionDto)
        {
            try
            {
                var userId = GetUserIdFromClaims();
                completionDto.LessonId = id;
                
                var success = await _lessonService.CompleteLessonAsync(userId, completionDto);
                
                if (!success)
                    return BadRequest(new { message = "Failed to complete lesson" });
                
                return Ok(new { message = "Lesson completed successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error completing lesson");
                return StatusCode(500, new { message = "An error occurred while completing the lesson" });
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
