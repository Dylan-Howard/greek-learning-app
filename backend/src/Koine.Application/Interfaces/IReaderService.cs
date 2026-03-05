// Koine.Application/Interfaces/IReaderService.cs
using Koine.Application.DTOs.Reader;

namespace Koine.Application.Interfaces
{
    public interface IReaderService
    {
        Task<RenderedChapterDto> RenderChapterAsync(int userId, int bookId, int chapterIndex, string targetLanguage = "en");
    }
}
