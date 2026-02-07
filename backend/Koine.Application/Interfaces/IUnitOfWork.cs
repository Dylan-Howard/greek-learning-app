// GreekParser.Application/Interfaces/IUnitOfWork.cs (Updated)
namespace GreekParser.Application.Interfaces
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
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}