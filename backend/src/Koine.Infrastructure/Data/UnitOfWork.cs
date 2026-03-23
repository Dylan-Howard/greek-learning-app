using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Infrastructure.Data.Context;
using Koine.Infrastructure.Data.Repositories;

namespace Koine.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KoineDbContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(KoineDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            
            Books = new BookRepository(_context);
            Chapters = new ChapterRepository(_context);
            UserProgress = new UserProgressRepository(_context);
            TranslationUnits = new TranslationUnitRepository(_context);
            LessonTracks = new LessonTrackRepository(_context);
            Lessons = new LessonRepository(_context);
            LessonCompletions = new LessonCompletionRepository(_context);
            Users = new UserRepository(_context, loggerFactory.CreateLogger<UserRepository>());
            Vocabulary = new VocabularyRepository(_context);
            GrammaticalFeatures = new GrammaticalFeatureRepository(_context);
            SyntacticalFeatures = new SyntacticalFeatureRepository(_context);
            Translations = new TranslationRepository(_context);
            UserSettings = new UserSettingRepository(_context);
            VocabularySets = new VocabularySetRepository(_context);
            VocabularySetItems = new VocabularySetItemRepository(_context);
        }

        public IBookRepository Books { get; }
        public IChapterRepository Chapters { get; }
        public IUserProgressRepository UserProgress { get; }
        public ITranslationUnitRepository TranslationUnits { get; }
        public ILessonTrackRepository LessonTracks { get; }
        public ILessonRepository Lessons { get; }
        public ILessonCompletionRepository LessonCompletions { get; }
        public IUserRepository Users { get; }
        public IVocabularyRepository Vocabulary { get; }
        public IGrammaticalFeatureRepository GrammaticalFeatures { get; }
        public ISyntacticalFeatureRepository SyntacticalFeatures { get; }
        public ITranslationRepository Translations { get; }
        public IUserSettingRepository UserSettings { get; }
        public IVocabularySetRepository VocabularySets { get; }
        public IVocabularySetItemRepository VocabularySetItems { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
}
