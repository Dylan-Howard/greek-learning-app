// GreekParser.Infrastructure/Data/Context/GreekParserDbContext.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Domain.Entities;

namespace GreekParser.Infrastructure.Data.Context
{
    public class GreekParserDbContext : DbContext
    {
        public GreekParserDbContext(DbContextOptions<GreekParserDbContext> options)
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply all configurations from assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GreekParserDbContext).Assembly);
        }
    }
}