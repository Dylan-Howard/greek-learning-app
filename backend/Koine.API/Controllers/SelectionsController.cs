// Koine.API/Controllers/SelectionsController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Selections;
using Koine.Application.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/selections")]
    public class SelectionsController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IChapterService _chapterService;
        private readonly ILogger<SelectionsController> _logger;

        public SelectionsController(
            IBookService bookService,
            IChapterService chapterService,
            ILogger<SelectionsController> logger)
        {
            _bookService = bookService;
            _chapterService = chapterService;
            _logger = logger;
        }

        [HttpGet("{textId}")]
        public async Task<ActionResult<SelectionsDto>> GetSelectionsByTextId(int textId)
        {
            try
            {
                var books = await _bookService.GetAllBooksAsync();
                var chapters = await _chapterService.GetChaptersByBookIdAsync(textId);

                var result = new SelectionsDto
                {
                    Texts = books
                        .Select(b => new TextSelectionDto
                        {
                            TextId = b.Id,
                            Title = b.Title
                        })
                        .ToArray(),
                    Chapters = chapters
                        .Select(c => new ChapterSelectionDto
                        {
                            ChapterId = c.Id,
                            ChapterNumber = c.ChapterIndex
                        })
                        .ToArray(),
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching selections for text {TextId}", textId);
                return StatusCode(500, new { message = "An error occurred while fetching selections" });
            }
        }
    }
}
