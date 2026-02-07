// GreekParser.Infrastructure/Data/UnitOfWork.cs (Updated)
using Microsoft.EntityFrameworkCore.Storage;
using GreekParser.Application.Interfaces;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Infrastructure.Data.Context;
using GreekParser.Infrastructure.Data.Repositories;

namespace GreekParser.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GreekParserDbContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(GreekParserDbContext context)
        {
            _context = context;
            
            Books = new BookRepository(_context);
            Chapters = new ChapterRepository(_context);
            UserProgress = new UserProgressRepository(_context);
            TranslationUnits = new TranslationUnitRepository(_context);
            Lessons = new LessonRepository(_context);
            LessonCompletions = new LessonCompletionRepository(_context);
            Users = new UserRepository(_context);
            Vocabulary = new VocabularyRepository(_context);
            GrammaticalFeatures = new GrammaticalFeatureRepository(_context);
            SyntacticalFeatures = new SyntacticalFeatureRepository(_context);
            Translations = new TranslationRepository(_context);
        }

        public IBookRepository Books { get; }
        public IChapterRepository Chapters { get; }
        public IUserProgressRepository UserProgress { get; }
        public ITranslationUnitRepository TranslationUnits { get; }
        public ILessonRepository Lessons { get; }
        public ILessonCompletionRepository LessonCompletions { get; }
        public IUserRepository Users { get; }
        public IVocabularyRepository Vocabulary { get; }
        public IGrammaticalFeatureRepository GrammaticalFeatures { get; }
        public ISyntacticalFeatureRepository SyntacticalFeatures { get; }
        public ITranslationRepository Translations { get; }
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