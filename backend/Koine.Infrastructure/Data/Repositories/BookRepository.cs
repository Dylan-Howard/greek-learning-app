// GreekParser.Infrastructure/Data/Repositories/BookRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<List<Book>> GetAllWithChaptersAsync()
        {
            return await _dbSet
                .Include(b => b.Chapters)
                .ToListAsync();
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/TranslationUnitRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class TranslationUnitRepository : Repository<TranslationUnit>, ITranslationUnitRepository
    {
        public TranslationUnitRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<List<TranslationUnit>> GetByChapterAndTranslationAsync(int chapterId, int translationId)
        {
            return await _dbSet
                .Where(tu => tu.ChapterId == chapterId && tu.TranslationId == translationId)
                .OrderBy(tu => tu.DisplayOrder)
                .ToListAsync();
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/LessonRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        public LessonRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<List<Lesson>> GetAllOrderedAsync()
        {
            return await _dbSet
                .OrderBy(l => l.LessonIndex)
                .ToListAsync();
        }

        public async Task<List<Lesson>> GetByTypeAsync(string lessonType)
        {
            return await _dbSet
                .Where(l => l.LessonType == lessonType)
                .OrderBy(l => l.LessonIndex)
                .ToListAsync();
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/LessonCompletionRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class LessonCompletionRepository : Repository<LessonCompletion>, ILessonCompletionRepository
    {
        public LessonCompletionRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<List<LessonCompletion>> GetByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(lc => lc.UserId == userId)
                .ToListAsync();
        }

        public async Task<LessonCompletion?> GetByUserAndLessonAsync(int userId, int lessonId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(lc => lc.UserId == userId && lc.LessonId == lessonId);
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/UserRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dbSet
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _dbSet
                .FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/VocabularyRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class VocabularyRepository : Repository<Vocabulary>, IVocabularyRepository
    {
        public VocabularyRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<List<Vocabulary>> GetByIdsAsync(List<int> ids)
        {
            return await _dbSet
                .Where(v => ids.Contains(v.Id))
                .ToListAsync();
        }

        public async Task<List<Vocabulary>> GetByFrequencyRankAsync(int minRank, int maxRank)
        {
            return await _dbSet
                .Where(v => v.FrequencyRank >= minRank && v.FrequencyRank <= maxRank)
                .OrderBy(v => v.FrequencyRank)
                .ToListAsync();
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/GrammaticalFeatureRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class GrammaticalFeatureRepository : Repository<GrammaticalFeature>, IGrammaticalFeatureRepository
    {
        public GrammaticalFeatureRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<GrammaticalFeature?> GetByCodeAsync(string code)
        {
            return await _dbSet
                .FirstOrDefaultAsync(f => f.Code == code);
        }

        public async Task<List<GrammaticalFeature>> GetByIdsAsync(List<int> ids)
        {
            return await _dbSet
                .Where(f => ids.Contains(f.Id))
                .ToListAsync();
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/SyntacticalFeatureRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class SyntacticalFeatureRepository : Repository<SyntacticalFeature>, ISyntacticalFeatureRepository
    {
        public SyntacticalFeatureRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<SyntacticalFeature?> GetByCodeAsync(string code)
        {
            return await _dbSet
                .FirstOrDefaultAsync(f => f.Code == code);
        }

        public async Task<List<SyntacticalFeature>> GetByIdsAsync(List<int> ids)
        {
            return await _dbSet
                .Where(f => ids.Contains(f.Id))
                .ToListAsync();
        }
    }
}

// GreekParser.Infrastructure/Data/Repositories/TranslationRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class TranslationRepository : Repository<Translation>, ITranslationRepository
    {
        public TranslationRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<Translation?> GetByBookAndLanguageAsync(int bookId, string languageCode)
        {
            return await _dbSet
                .FirstOrDefaultAsync(t => t.BookId == bookId && t.LanguageCode == languageCode);
        }
    }
}