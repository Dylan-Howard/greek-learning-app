// Koine.Application/Study/Ports/IVocabularySetItemRepository.cs
namespace Koine.Application.Study.Ports
{
    public interface IVocabularySetItemRepository
    {
        Task<List<int>> GetVocabularyIdsForSetAsync(int setId, CancellationToken ct);
    }
}
