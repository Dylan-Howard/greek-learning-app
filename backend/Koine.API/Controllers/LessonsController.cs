// Koine.API/Controllers/LessonsController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Lessons;
using Koine.Application.Interfaces;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Koine.API.Controllers
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
        public async Task<ActionResult<List<LessonDto>>> GetAllLessons()
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var lessons = await _lessonService.GetAllLessonsAsync(userId);
                return Ok(lessons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching lessons");
                return StatusCode(500, new { message = "An error occurred while fetching lessons" });
            }
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<LessonDto>> GetLesson(int id)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var lesson = await _lessonService.GetLessonByIdAsync(id, userId);
                if (lesson == null)
                    return NotFound(new { message = "Lesson not found" });

                return Ok(lesson);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching lesson");
                return StatusCode(500, new { message = "An error occurred while fetching the lesson" });
            }
        }
        
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<LessonDto>> CreateLesson([FromBody] CreateLessonDto lessonDto)
        {
            try
            {
                var lesson = await _lessonService.CreateLessonAsync(lessonDto);
                return CreatedAtAction(nameof(GetLesson), new { id = lesson.Id }, lesson);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating lesson");
                return StatusCode(500, new { message = "An error occurred while creating the lesson" });
            }
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

        private int GetUserIdFromClaimsOrDefault()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out var userId))
            {
                return 0; // Default for anonymous
            }
            return userId;
        }
    }
}
