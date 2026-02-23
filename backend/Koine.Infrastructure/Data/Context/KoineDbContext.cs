// Koine.Infrastructure/Data/Context/KoineDbContext.cs
using Microsoft.EntityFrameworkCore;
using Koine.Domain.Entities;

namespace Koine.Infrastructure.Data.Context
{
    public class KoineDbContext : DbContext
    {
        public KoineDbContext(DbContextOptions<KoineDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Chapter> Chapters { get; set; } = null!;
        public DbSet<GrammaticalFeature> GrammaticalFeatures { get; set; } = null!;
        public DbSet<SyntacticalFeature> SyntacticalFeatures { get; set; } = null!;
        public DbSet<Vocabulary> Vocabularies { get; set; } = null!;
        public DbSet<Translation> Translations { get; set; } = null!;
        public DbSet<TranslationUnit> TranslationUnits { get; set; } = null!;
        public DbSet<Lesson> Lessons { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserProgress> UserProgresses { get; set; } = null!;
        public DbSet<LessonCompletion> LessonCompletions { get; set; } = null!;
        public DbSet<UserSetting> UserSettings { get; set; } = null!;
        public DbSet<VocabularySet> VocabularySets { get; set; } = null!;
        public DbSet<VocabularySetItem> VocabularySetItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply all configurations from assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KoineDbContext).Assembly);
        }
    }
}