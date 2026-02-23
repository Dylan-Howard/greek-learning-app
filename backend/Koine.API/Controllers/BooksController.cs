// Koine.API/Controllers/BooksController.cs
using Microsoft.AspNetCore.Mvc;
using Koine.Application.DTOs.Books;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Koine.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IVocabularyService _vocabularyService;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBookService bookService, IVocabularyService vocabularyService, ILogger<BooksController> logger)
        {
            _bookService = bookService;
            _vocabularyService = vocabularyService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookDto>>> GetAll()
        {
            try
            {
                var books = await _bookService.GetAllBooksAsync();
                return Ok(books);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching books");
                return StatusCode(500, new { message = "An error occurred while fetching books" });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> GetById(int id)
        {
            try
            {
                var book = await _bookService.GetBookByIdAsync(id);
                if (book == null)
                    return NotFound(new { message = "Book not found" });

                return Ok(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching book");
                return StatusCode(500, new { message = "An error occurred while fetching the book" });
            }
        }

        [HttpGet("{id}/words")]
        public async Task<ActionResult<List<SimpleWordDto>>> GetWordsByBookId(int id)
        {
            try
            {
                var words = await _vocabularyService.GetWordsByBookIdAsync(id);
                return Ok(words);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching words for book");
                return StatusCode(500, new { message = "An error occurred while fetching words for book" });
            }
        }

        [HttpPost]
        public async Task<ActionResult<BookDto>> Create([FromBody] CreateBookDto createDto)
        {
            try
            {
                var book = await _bookService.CreateBookAsync(createDto);
                return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating book");
                return StatusCode(500, new { message = "An error occurred while creating the book" });
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BookDto>> Update(int id, [FromBody] UpdateBookDto updateDto)
        {
            try
            {
                var book = await _bookService.UpdateBookAsync(id, updateDto);
                if (book == null)
                    return NotFound(new { message = "Book not found" });

                return Ok(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating book");
                return StatusCode(500, new { message = "An error occurred while updating the book" });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var success = await _bookService.DeleteBookAsync(id);
                if (!success)
                    return NotFound(new { message = "Book not found" });

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting book");
                return StatusCode(500, new { message = "An error occurred while deleting the book" });
            }
        }
    }
}
