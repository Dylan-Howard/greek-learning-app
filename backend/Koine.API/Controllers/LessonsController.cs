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
        public async Task<ActionResult<List<LessonDto>>> GetAllLessons([FromQuery] string? trackSlug = null)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var lessons = string.IsNullOrWhiteSpace(trackSlug)
                    ? await _lessonService.GetAllLessonsAsync(userId)
                    : await _lessonService.GetLessonsByTrackAsync(userId, trackSlug);
                return Ok(lessons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching lessons");
                return StatusCode(500, new { message = "An error occurred while fetching lessons" });
            }
        }

        [AllowAnonymous]
        [HttpGet("tracks")]
        public async Task<ActionResult<List<LessonTrackDto>>> GetLessonTracks([FromQuery] bool includeLessons = false)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var tracks = await _lessonService.GetLessonTracksAsync(userId, includeLessons);
                return Ok(tracks);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching lesson tracks");
                return StatusCode(500, new { message = "An error occurred while fetching lesson tracks" });
            }
        }

        [AllowAnonymous]
        [HttpGet("tracks/{trackSlug}")]
        public async Task<ActionResult<LessonTrackDto>> GetLessonTrack(string trackSlug)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var track = await _lessonService.GetLessonTrackAsync(trackSlug, userId);
                if (track == null)
                {
                    return NotFound(new { message = "Lesson track not found" });
                }

                return Ok(track);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching lesson track {TrackSlug}", trackSlug);
                return StatusCode(500, new { message = "An error occurred while fetching the lesson track" });
            }
        }

        [AllowAnonymous]
        [HttpGet("tracks/{trackSlug}/next")]
        public async Task<ActionResult<LessonDto>> GetNextLesson(string trackSlug)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault();
                var lesson = await _lessonService.GetNextLessonAsync(userId, trackSlug);
                if (lesson == null)
                {
                    return NotFound(new { message = "No next lesson found for track" });
                }

                return Ok(lesson);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching next lesson for {TrackSlug}", trackSlug);
                return StatusCode(500, new { message = "An error occurred while fetching the next lesson" });
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

        [AllowAnonymous]
        [HttpPost("{id}/complete")]
        public async Task<ActionResult<LessonCompletionResponseDto>> CompleteLesson(
            int id,
            [FromBody] CompleteLessonDto completionDto,
            [FromHeader(Name = "X-Dev-User-Id")] string? devUserId = null)
        {
            try
            {
                var userId = GetUserIdFromClaimsOrDefault(devUserId);
                completionDto.LessonId = id;
                
                var response = await _lessonService.CompleteLessonAsync(userId, completionDto);
                
                if (response == null)
                    return BadRequest(new { message = "Failed to complete lesson" });
                
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error completing lesson");
                return StatusCode(500, new { message = "An error occurred while completing the lesson" });
            }
        }

        private int GetUserIdFromClaimsOrDefault(string? devUserId = null)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!string.IsNullOrEmpty(userIdClaim) && int.TryParse(userIdClaim, out var claimUserId))
            {
                return claimUserId;
            }

            if (!string.IsNullOrWhiteSpace(devUserId) && int.TryParse(devUserId, out var headerUserId) && headerUserId > 0)
            {
                return headerUserId;
            }

            return 1; // Default for MVP development.
        }
    }
}
