// GreekParser.Application/Services/ChapterService.cs
using System.Text.Json;
using GreekParser.Application.DTOs.Chapters;
using GreekParser.Application.Interfaces;
using GreekParser.Domain.Entities;

namespace GreekParser.Application.Services
{
    public class ChapterService : IChapterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChapterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ChapterDto>> GetChaptersByBookIdAsync(int bookId)
        {
            var chapters = await _unitOfWork.Chapters.GetByBookIdAsync(bookId);

            return chapters.Select(c => new ChapterDto
            {
                Id = c.Id,
                BookId = c.BookId,
                ChapterIndex = c.ChapterIndex,
                Title = c.Title,
                UnitTree = JsonSerializer.Deserialize<List<UnitNodeDto>>(c.UnitTreeJson) ?? new(),
                CreatedAt = c.CreatedAt
            }).ToList();
        }

        public async Task<ChapterDto?> GetChapterByIdAsync(int chapterId)
        {
            var chapter = await _unitOfWork.Chapters.GetByIdAsync(chapterId);
            if (chapter == null) return null;

            return new ChapterDto
            {
                Id = chapter.Id,
                BookId = chapter.BookId,
                ChapterIndex = chapter.ChapterIndex,
                Title = chapter.Title,
                UnitTree = JsonSerializer.Deserialize<List<UnitNodeDto>>(chapter.UnitTreeJson) ?? new(),
                CreatedAt = chapter.CreatedAt
            };
        }

        public async Task<ChapterDto> CreateChapterAsync(int bookId, CreateChapterDto createDto)
        {
            var chapter = new Chapter
            {
                BookId = bookId,
                ChapterIndex = createDto.ChapterIndex,
                Title = createDto.Title,
                UnitTreeJson = JsonSerializer.Serialize(createDto.UnitTree),
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Chapters.AddAsync(chapter);
            await _unitOfWork.SaveChangesAsync();

            return new ChapterDto
            {
                Id = chapter.Id,
                BookId = chapter.BookId,
                ChapterIndex = chapter.ChapterIndex,
                Title = chapter.Title,
                UnitTree = createDto.UnitTree,
                CreatedAt = chapter.CreatedAt
            };
        }

        public async Task<ChapterDto?> UpdateChapterAsync(int chapterId, UpdateChapterDto updateDto)
        {
            var chapter = await _unitOfWork.Chapters.GetByIdAsync(chapterId);
            if (chapter == null) return null;

            chapter.ChapterIndex = updateDto.ChapterIndex;
            chapter.Title = updateDto.Title;
            chapter.UnitTreeJson = JsonSerializer.Serialize(updateDto.UnitTree);

            await _unitOfWork.Chapters.UpdateAsync(chapter);
            await _unitOfWork.SaveChangesAsync();

            return new ChapterDto
            {
                Id = chapter.Id,
                BookId = chapter.BookId,
                ChapterIndex = chapter.ChapterIndex,
                Title = chapter.Title,
                UnitTree = updateDto.UnitTree,
                CreatedAt = chapter.CreatedAt
            };
        }

        public async Task<bool> DeleteChapterAsync(int chapterId)
        {
            var chapter = await _unitOfWork.Chapters.GetByIdAsync(chapterId);
            if (chapter == null) return false;

            await _unitOfWork.Chapters.DeleteAsync(chapter);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
