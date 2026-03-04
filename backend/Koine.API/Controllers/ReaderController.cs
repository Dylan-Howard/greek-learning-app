// Koine.API/Controllers/ReaderController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Reader;
using Koine.Application.Interfaces;
using System.Security.Claims;

namespace Koine.API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class ReaderController : ControllerBase
    {
        private readonly IReaderService _readerService;
        private readonly ILogger<ReaderController> _logger;

        public ReaderController(IReaderService readerService, ILogger<ReaderController> logger)
        {
            _readerService = readerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<RenderedChapterDto>> GetChapter(
            [FromQuery] int book,
            [FromQuery] int chapter,
            [FromQuery] string lang = "en",
            [FromQuery] int? userId = null)
        {
            try
            {
                var resolvedUserId = GetUserIdFromClaimsOrDefault(userId);
                var result = await _readerService.RenderChapterAsync(resolvedUserId, book, chapter, lang);
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning(ex, "Resource not found");
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error rendering chapter");
                return StatusCode(500, new { message = "An error occurred while rendering the chapter" });
            }
        }

        private int GetUserIdFromClaimsOrDefault(int? fallbackUserId = null)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out var userId))
            {
                // TODO: For production, enforce authentication. 
                // For development without auth, allow explicit query user override.
                if (fallbackUserId.HasValue && fallbackUserId.Value > 0)
                {
                    return fallbackUserId.Value;
                }

                return 1;
            }
            return userId;
        }
    }
}
