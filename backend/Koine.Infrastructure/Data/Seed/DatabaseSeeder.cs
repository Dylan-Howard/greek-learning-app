// GreekParser.Infrastructure/Data/Seed/DatabaseSeeder.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GreekParser.Infrastructure.Data.Context;
using GreekParser.Domain.Entities;
using System.Text.Json;

namespace GreekParser.Infrastructure.Data.Seed
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<GreekParserDbContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<GreekParserDbContext>>();

            try
            {
                logger.LogInformation("Starting database seeding...");

                // Check if already seeded
                if (await context.Books.AnyAsync())
                {
                    logger.LogInformation("Database already seeded. Skipping.");
                    return;
                }

                // 1. Seed Grammatical Features
                logger.LogInformation("Seeding grammatical features...");
                var gramFeatures = GrammaticalFeaturesData.GetFeatures();
                foreach (var (code, name, category, definition, sortOrder) in gramFeatures)
                {
                    context.GrammaticalFeatures.Add(new GrammaticalFeature
                    {
                        Code = code,
                        Name = name,
                        Category = category,
                        Definition = definition,
                        SortOrder = sortOrder
                    });
                }
                await context.SaveChangesAsync();

                // 2. Seed Syntactical Features
                logger.LogInformation("Seeding syntactical features...");
                var synFeatures = SyntacticalFeaturesData.GetFeatures();
                foreach (var (code, name, definition, sortOrder) in synFeatures)
                {
                    context.SyntacticalFeatures.Add(new SyntacticalFeature
                    {
                        Code = code,
                        Name = name,
                        Definition = definition,
                        SortOrder = sortOrder
                    });
                }
                await context.SaveChangesAsync();

                // 3. Seed Vocabulary
                logger.LogInformation("Seeding vocabulary...");
                var vocabulary = FirstJohnTextData.GetVocabulary();
                foreach (var (root, transliteration, gloss, partOfSpeech, frequencyRank) in vocabulary)
                {
                    context.Vocabularies.Add(new Vocabulary
                    {
                        Root = root,
                        Transliteration = transliteration,
                        Gloss = gloss,
                        PartOfSpeech = partOfSpeech,
                        FrequencyRank = frequencyRank,
                        CreatedAt = DateTime.UtcNow
                    });
                }
                await context.SaveChangesAsync();

                // 4. Create Book
                logger.LogInformation("Creating book: 1 John...");
                var book = new Book
                {
                    Title = "1 John",
                    LanguageCode = "grc",
                    CreatedAt = DateTime.UtcNow
                };
                context.Books.Add(book);
                await context.SaveChangesAsync();

                // 5. Create Chapters
                logger.LogInformation("Creating chapters...");
                var chapters = FirstJohnTextData.GetChapters();
                foreach (var (index, units) in chapters)
                {
                    context.Chapters.Add(new Chapter
                    {
                        BookId = book.Id,
                        ChapterIndex = index,
                        Title = $"Chapter {index}",
                        UnitTreeJson = JsonSerializer.Serialize(units),
                        CreatedAt = DateTime.UtcNow
                    });
                }
                await context.SaveChangesAsync();

                // 6. Create Translation
                logger.LogInformation("Creating translation...");
                var translation = new Translation
                {
                    BookId = book.Id,
                    LanguageCode = "en",
                    Name = "ESV",
                    CreatedAt = DateTime.UtcNow
                };
                context.Translations.Add(translation);
                await context.SaveChangesAsync();

                // 7. Create Lessons
                logger.LogInformation("Creating lessons...");
                int lessonIndex = 1;
                
                foreach (var gramFeature in await context.GrammaticalFeatures.ToListAsync())
                {
                    context.Lessons.Add(new Lesson
                    {
                        Title = $"Test Lesson: {gramFeature.Name}",
                        LessonIndex = lessonIndex++,
                        ContentMarkdown = $"# {gramFeature.Name}\n\n{gramFeature.Definition}\n\nThis is a test lesson.",
                        LessonType = "grammar",
                        GrammaticalFeatureIdsJson = JsonSerializer.Serialize(new[] { gramFeature.Id }),
                        SyntacticalFeatureIdsJson = "[]",
                        VocabularyIdsJson = "[]",
                        CreatedAt = DateTime.UtcNow
                    });
                }

                foreach (var synFeature in await context.SyntacticalFeatures.ToListAsync())
                {
                    context.Lessons.Add(new Lesson
                    {
                        Title = $"Test Lesson: {synFeature.Name}",
                        LessonIndex = lessonIndex++,
                        ContentMarkdown = $"# {synFeature.Name}\n\n{synFeature.Definition}\n\nThis is a test lesson.",
                        LessonType = "syntax",
                        GrammaticalFeatureIdsJson = "[]",
                        SyntacticalFeatureIdsJson = JsonSerializer.Serialize(new[] { synFeature.Id }),
                        VocabularyIdsJson = "[]",
                        CreatedAt = DateTime.UtcNow
                    });
                }
                await context.SaveChangesAsync();

                // 8. Create Test Users
                logger.LogInformation("Creating test users...");
                var testUsers = new[]
                {
                    new User { Email = "beginner@test.com", Username = "beginner", PasswordHash = HashPassword("password123"), CreatedAt = DateTime.UtcNow },
                    new User { Email = "intermediate@test.com", Username = "intermediate", PasswordHash = HashPassword("password123"), CreatedAt = DateTime.UtcNow },
                    new User { Email = "advanced@test.com", Username = "advanced", PasswordHash = HashPassword("password123"), CreatedAt = DateTime.UtcNow },
                    new User { Email = "struggling@test.com", Username = "struggling", PasswordHash = HashPassword("password123"), CreatedAt = DateTime.UtcNow }
                };

                foreach (var user in testUsers)
                {
                    context.Users.Add(user);
                }
                await context.SaveChangesAsync();

                logger.LogInformation("Database seeding completed successfully!");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred during database seeding");
                throw;
            }
        }

        private static string HashPassword(string password)
        {
            // TODO: Use proper password hashing (BCrypt, Argon2, etc.)
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}