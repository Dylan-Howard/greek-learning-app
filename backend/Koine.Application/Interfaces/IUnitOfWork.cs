using Koine.Domain.Entities;
using Koine.Application.Interfaces.Repositories;

namespace Koine.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IChapterRepository Chapters { get; }
        IUserProgressRepository UserProgress { get; }
        ITranslationUnitRepository TranslationUnits { get; }
        ILessonRepository Lessons { get; }
        ILessonCompletionRepository LessonCompletions { get; }
        IUserRepository Users { get; }
        IVocabularyRepository Vocabulary { get; }
        IGrammaticalFeatureRepository GrammaticalFeatures { get; }
        ISyntacticalFeatureRepository SyntacticalFeatures { get; }
        ITranslationRepository Translations { get; }
        IUserSettingRepository UserSettings { get; }
        IVocabularySetRepository VocabularySets { get; }
        IVocabularySetItemRepository VocabularySetItems { get; }
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
