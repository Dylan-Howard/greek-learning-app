// GreekParser.API/Controllers/ChaptersController.cs
using Microsoft.AspNetCore.Mvc;
using GreekParser.Application.DTOs.Chapters;
using GreekParser.Application.Interfaces;

namespace GreekParser.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterService _chapterService;
        private readonly ILogger<ChaptersController> _logger;

        public ChaptersController(IChapterService chapterService, ILogger<ChaptersController> logger)
        {
            _chapterService = chapterService;
            _logger = logger;
        }

        [HttpGet("books/{bookId}/chapters")]
        public async Task<ActionResult<List<ChapterDto>>> GetByBookId(int bookId)
        {
            try
            {
                var chapters = await _chapterService.GetChaptersByBookIdAsync(bookId);
                return Ok(chapters);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching chapters");
                return StatusCode(500, new { message = "An error occurred while fetching chapters" });
            }
        }

        [HttpGet("chapters/{id}")]
        public async Task<ActionResult<ChapterDto>> GetById(int id)
        {
            try
            {
                var chapter = await _chapterService.GetChapterByIdAsync(id);
                if (chapter == null)
                    return NotFound(new { message = "Chapter not found" });

                return Ok(chapter);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching chapter");
                return StatusCode(500, new { message = "An error occurred while fetching the chapter" });
            }
        }

        [HttpPost("books/{bookId}/chapters")]
        public async Task<ActionResult<ChapterDto>> Create(int bookId, [FromBody] CreateChapterDto createDto)
        {
            try
            {
                var chapter = await _chapterService.CreateChapterAsync(bookId, createDto);
                return CreatedAtAction(nameof(GetById), new { id = chapter.Id }, chapter);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating chapter");
                return StatusCode(500, new { message = "An error occurred while creating the chapter" });
            }
        }

        [HttpPut("chapters/{id}")]
        public async Task<ActionResult<ChapterDto>> Update(int id, [FromBody] UpdateChapterDto updateDto)
        {
            try
            {
                var chapter = await _chapterService.UpdateChapterAsync(id, updateDto);
                if (chapter == null)
                    return NotFound(new { message = "Chapter not found" });

                return Ok(chapter);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating chapter");
                return StatusCode(500, new { message = "An error occurred while updating the chapter" });
            }
        }

        [HttpDelete("chapters/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _chapterService.DeleteChapterAsync(id);
                if (!success)
                    return NotFound(new { message = "Chapter not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting chapter");
                return StatusCode(500, new { message = "An error occurred while deleting the chapter" });
            }
        }
    }
}
