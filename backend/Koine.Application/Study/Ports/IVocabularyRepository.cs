// Koine.Application/Study/Ports/IVocabularyRepository.cs
using Koine.Domain.Entities;

namespace Koine.Application.Study.Ports
{
    public interface IVocabularyRepository
    {
        Task<List<Vocabulary>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct);
        Task<List<Vocabulary>> GetRandomSampleAsync(int count, CancellationToken ct);
    }
}
