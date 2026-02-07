// GreekParser.API/Controllers/ReaderController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Reader;
using GreekParser.Application.Interfaces;
using System.Security.Claims;

namespace GreekParser.API.Controllers
{
    [Authorize]
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
            [FromQuery] string lang = "en")
        {
            try
            {
                var userId = GetUserIdFromClaims();
                var result = await _readerService.RenderChapterAsync(userId, book, chapter, lang);
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
