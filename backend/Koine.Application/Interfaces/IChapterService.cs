// Koine.Application/Interfaces/IChapterService.cs
using Koine.Application.DTOs.Chapters;

namespace Koine.Application.Interfaces
{
    public interface IChapterService
    {
        Task<List<ChapterDto>> GetChaptersByBookIdAsync(int bookId);
        Task<ChapterDto?> GetChapterByIdAsync(int chapterId);
        Task<ChapterDto> CreateChapterAsync(int bookId, CreateChapterDto createDto);
        Task<ChapterDto?> UpdateChapterAsync(int chapterId, UpdateChapterDto updateDto);
        Task<bool> DeleteChapterAsync(int chapterId);
    }
}
