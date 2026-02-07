// GreekParser.Application/Interfaces/IReaderService.cs
namespace GreekParser.Application.Interfaces
{
    public interface IReaderService
    {
        Task<RenderedChapterDto> RenderChapterAsync(int userId, int bookId, int chapterIndex, string targetLanguage = "en");
    }
}
