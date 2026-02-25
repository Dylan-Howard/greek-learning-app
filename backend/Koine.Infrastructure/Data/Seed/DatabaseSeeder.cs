// Koine.Infrastructure/Data/Seed/DatabaseSeeder.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Koine.Infrastructure.Data.Context;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;
using System.Text.Json;

namespace Koine.Infrastructure.Data.Seed
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<KoineDbContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<KoineDbContext>>();

            try
            {
                logger.LogInformation("Starting database seeding...");
                await EnsureVocabularySchemaAsync(context);
                await EnsureVocabularySetSchemaAsync(context);

                // Check if already seeded
                if (await context.Books.AnyAsync())
                {
                    logger.LogInformation("Database already seeded. Ensuring system vocabulary sets are synchronized.");
                    await EnsureSystemVocabularySetsAsync(context);
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
                var occurrencesByRoot = GreekNtOccurrencesData.Load();
                foreach (var (root, transliteration, gloss, partOfSpeech, fallbackOccurrences) in vocabulary)
                {
                    var occurrences = occurrencesByRoot.GetValueOrDefault(root, fallbackOccurrences);
                    context.Vocabularies.Add(new Vocabulary
                    {
                        Root = root,
                        Transliteration = transliteration,
                        Gloss = gloss,
                        PartOfSpeech = partOfSpeech,
                        Occurrences = occurrences,
                        CreatedAt = DateTime.UtcNow
                    });
                }
                await context.SaveChangesAsync();

                // Get ID mappings for text seeding
                var gramCodeToId = await context.GrammaticalFeatures.ToDictionaryAsync(f => f.Code, f => f.Id);
                var synCodeToId = await context.SyntacticalFeatures.ToDictionaryAsync(f => f.Code, f => f.Id);
                var vocabToId = await context.Vocabularies.ToDictionaryAsync(v => v.Root, v => v.Id);

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
                foreach (var (index, seedUnits) in chapters)
                {
                    // Map SeedUnitNodes to Domain UnitNodes
                    var unitNodes = seedUnits.Select((u, i) => MapToUnitNode(u, gramCodeToId, synCodeToId, vocabToId, i.ToString())).ToList();
                    
                    context.Chapters.Add(new Chapter
                    {
                        BookId = book.Id,
                        ChapterIndex = index,
                        Title = $"Chapter {index}",
                        UnitTreeJson = JsonSerializer.Serialize(unitNodes),
                        CreatedAt = DateTime.UtcNow
                    });
                }
                await context.SaveChangesAsync();

                // 6. Seed system vocabulary sets
                logger.LogInformation("Creating system vocabulary sets...");
                await EnsureSystemVocabularySetsAsync(context);

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

        private static UnitNode MapToUnitNode(
            SeedUnitNode seedNode, 
            Dictionary<string, int> gramCodeToId, 
            Dictionary<string, int> synCodeToId,
            Dictionary<string, int> vocabToId,
            string path)
        {
            var node = new UnitNode
            {
                Type = seedNode.Type ?? "unit",
                Path = path,
                Root = seedNode.Root,
                Translation = seedNode.Translation,
                Content = seedNode.Content,
                Marker = seedNode.Marker,
                GramFeatureIds = seedNode.GrammarCodes?
                    .Select(c => gramCodeToId.TryGetValue(c, out var id) ? id : 0)
                    .Where(id => id != 0)
                    .ToList(),
                SynFeatureIds = seedNode.SyntaxCodes?
                    .Select(c => synCodeToId.TryGetValue(c, out var id) ? id : 0)
                    .Where(id => id != 0)
                    .ToList(),
                VocabId = seedNode.Root != null && vocabToId.TryGetValue(seedNode.Root, out var vid) ? vid : null,
                Children = seedNode.Children?
                    .Select((c, i) => MapToUnitNode(c, gramCodeToId, synCodeToId, vocabToId, $"{path}.{i}"))
                    .ToList()
            };
            return node;
        }

        private static string HashPassword(string password)
        {
            // TODO: Use proper password hashing (BCrypt, Argon2, etc.)
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }

        private static async Task EnsureSystemVocabularySetsAsync(KoineDbContext context)
        {
            var now = DateTime.UtcNow;
            var systemOwnerUserId = await context.Users
                .OrderBy(u => u.Id)
                .Select(u => u.Id)
                .FirstOrDefaultAsync();

            if (systemOwnerUserId == 0)
            {
                var systemOwner = new User
                {
                    Email = "system@test.com",
                    Username = "system",
                    PasswordHash = HashPassword("password123"),
                    CreatedAt = now
                };

                context.Users.Add(systemOwner);
                await context.SaveChangesAsync();
                systemOwnerUserId = systemOwner.Id;
            }

            var allVocabulary = await context.Vocabularies.ToListAsync();

            await UpsertSystemSetAsync(
                context,
                slug: "nt-occ-gt-50",
                title: "NT Vocabulary Occurrences > 50",
                description: "All New Testament vocabulary occurring more than 50 times.",
                vocabularyIds: allVocabulary
                    .Where(v => (v.Occurrences ?? 0) > 50)
                    .Select(v => v.Id)
                    .ToList(),
                ownerUserId: systemOwnerUserId,
                bookId: null,
                now: now);

            await UpsertSystemSetAsync(
                context,
                slug: "nt-occ-gt-15",
                title: "NT Vocabulary Occurrences > 15",
                description: "All New Testament vocabulary occurring more than 15 times.",
                vocabularyIds: allVocabulary
                    .Where(v => (v.Occurrences ?? 0) > 15)
                    .Select(v => v.Id)
                    .ToList(),
                ownerUserId: systemOwnerUserId,
                bookId: null,
                now: now);

            await UpsertSystemSetAsync(
                context,
                slug: "nt-all-vocab",
                title: "All NT Vocabulary",
                description: "All currently loaded New Testament vocabulary.",
                vocabularyIds: allVocabulary.Select(v => v.Id).ToList(),
                ownerUserId: systemOwnerUserId,
                bookId: null,
                now: now);

            var books = await context.Books.ToListAsync();
            foreach (var existingBook in books)
            {
                var chapterUnitTrees = await context.Chapters
                    .Where(c => c.BookId == existingBook.Id)
                    .Select(c => c.UnitTreeJson)
                    .ToListAsync();

                var bookVocabularyIds = new HashSet<int>();
                foreach (var unitTreeJson in chapterUnitTrees)
                {
                    foreach (var vocabId in ExtractVocabularyIdsFromUnitTree(unitTreeJson))
                    {
                        bookVocabularyIds.Add(vocabId);
                    }
                }

                var normalizedTitle = NormalizeSlug(existingBook.Title);
                await UpsertSystemSetAsync(
                    context,
                    slug: $"book-{normalizedTitle}",
                    title: $"{existingBook.Title} Vocabulary",
                    description: $"All vocabulary currently used in {existingBook.Title}.",
                    vocabularyIds: bookVocabularyIds.ToList(),
                    ownerUserId: systemOwnerUserId,
                    bookId: existingBook.Id,
                    now: now);
            }

            // TODO(next phase): Auto-generate book-specific system sets when new books are imported.
        }

        private static async Task UpsertSystemSetAsync(
            KoineDbContext context,
            string slug,
            string title,
            string description,
            List<int> vocabularyIds,
            int ownerUserId,
            int? bookId,
            DateTime now)
        {
            var set = await context.VocabularySets
                .Include(vs => vs.Items)
                .FirstOrDefaultAsync(vs => vs.Slug == slug);

            if (set == null)
            {
                set = new VocabularySet
                {
                    OwnerUserId = ownerUserId,
                    IsSystem = true,
                    Slug = slug,
                    Title = title,
                    Description = description,
                    CreatedAt = now,
                    BookId = bookId
                };
                await context.VocabularySets.AddAsync(set);
                await context.SaveChangesAsync();
            }
            else
            {
                set.IsSystem = true;
                set.OwnerUserId = ownerUserId;
                set.Title = title;
                set.Description = description;
                set.BookId = bookId;
                context.VocabularySets.Update(set);
                await context.SaveChangesAsync();
            }

            var targetIds = vocabularyIds.Distinct().ToHashSet();
            var existingByVocabId = set.Items.ToDictionary(i => i.VocabularyId, i => i);

            var toRemove = set.Items.Where(i => !targetIds.Contains(i.VocabularyId)).ToList();
            if (toRemove.Count > 0)
            {
                context.VocabularySetItems.RemoveRange(toRemove);
            }

            var toAdd = targetIds.Where(vocabId => !existingByVocabId.ContainsKey(vocabId)).ToList();
            foreach (var vocabId in toAdd)
            {
                await context.VocabularySetItems.AddAsync(new VocabularySetItem
                {
                    VocabularySetId = set.Id,
                    VocabularyId = vocabId,
                    MasteryLevel = 0,
                    AddedAt = now
                });
            }

            await context.SaveChangesAsync();
        }

        private static async Task EnsureVocabularySetSchemaAsync(KoineDbContext context)
        {
            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[VocabularySets]', N'U') IS NOT NULL
                BEGIN
                    IF COL_LENGTH('VocabularySets', 'IsSystem') IS NULL
                    BEGIN
                        ALTER TABLE [VocabularySets]
                        ADD [IsSystem] bit NOT NULL CONSTRAINT [DF_VocabularySets_IsSystem] DEFAULT (0);
                    END

                    IF COL_LENGTH('VocabularySets', 'Slug') IS NULL
                    BEGIN
                        ALTER TABLE [VocabularySets]
                        ADD [Slug] nvarchar(200) NOT NULL CONSTRAINT [DF_VocabularySets_Slug] DEFAULT ('');
                    END

                    IF COL_LENGTH('VocabularySets', 'BookId') IS NULL
                    BEGIN
                        ALTER TABLE [VocabularySets]
                        ADD [BookId] int NULL;
                    END

                    UPDATE [VocabularySets]
                    SET [Slug] = CONCAT('legacy-', [Id])
                    WHERE [Slug] IS NULL OR LTRIM(RTRIM([Slug])) = '';
                END
                """);
        }

        private static async Task EnsureVocabularySchemaAsync(KoineDbContext context)
        {
            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[Vocabularies]', N'U') IS NOT NULL
                BEGIN
                    IF COL_LENGTH('Vocabularies', 'Occurrences') IS NULL
                    BEGIN
                        ALTER TABLE [Vocabularies]
                        ADD [Occurrences] int NULL;
                    END
                END
                """);

            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[Vocabularies]', N'U') IS NOT NULL
                BEGIN
                    IF COL_LENGTH('Vocabularies', 'FrequencyRank') IS NOT NULL
                    BEGIN
                        UPDATE [Vocabularies]
                        SET [Occurrences] = COALESCE([Occurrences], [FrequencyRank]);
                    END
                END
                """);
        }

        private static IEnumerable<int> ExtractVocabularyIdsFromUnitTree(string? unitTreeJson)
        {
            if (string.IsNullOrWhiteSpace(unitTreeJson))
            {
                return Enumerable.Empty<int>();
            }

            var nodes = JsonSerializer.Deserialize<List<UnitNode>>(unitTreeJson) ?? new List<UnitNode>();
            var ids = new List<int>();
            foreach (var node in nodes)
            {
                TraverseNode(node, ids);
            }

            return ids;
        }

        private static void TraverseNode(UnitNode node, ICollection<int> ids)
        {
            if (node.VocabId.HasValue)
            {
                ids.Add(node.VocabId.Value);
            }

            if (node.Children == null || node.Children.Count == 0)
            {
                return;
            }

            foreach (var child in node.Children)
            {
                TraverseNode(child, ids);
            }
        }

        private static string NormalizeSlug(string value)
        {
            var normalized = new string(
                value.Trim().ToLowerInvariant().Select(ch => char.IsLetterOrDigit(ch) ? ch : '-').ToArray());

            while (normalized.Contains("--"))
            {
                normalized = normalized.Replace("--", "-");
            }

            return normalized.Trim('-');
        }
    }
}
