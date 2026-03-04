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
                await EnsureLessonSchemaAsync(context);

                // Check if already seeded
                if (await context.Books.AnyAsync())
                {
                    logger.LogInformation("Database already seeded. Clearing old data for fresh re-seed.");
                    context.Chapters.RemoveRange(context.Chapters);
                    context.Books.RemoveRange(context.Books);
                    context.Vocabularies.RemoveRange(context.Vocabularies);
                    context.TranslationUnits.RemoveRange(context.TranslationUnits);
                    await context.SaveChangesAsync();
                }

                var chapters = FirstJohnTextData.GetChapters();

                // 1. Seed Grammatical Features
                logger.LogInformation("Seeding grammatical features...");
                var gramFeatures = GrammaticalFeaturesData.GetFeatures();
                await UpsertGrammaticalFeaturesAsync(context, gramFeatures);

                // 2. Seed Syntactical Features
                logger.LogInformation("Seeding syntactical features...");
                var synFeatures = SyntacticalFeaturesData.GetFeatures();
                await UpsertSyntacticalFeaturesAsync(context, synFeatures);

                // Ensure every grammar/syntax code used in chapter seed data has a backing feature row.
                await EnsureFeatureCoverageForSeedDataAsync(context, chapters, logger);

                // 3. Seed Vocabulary
                logger.LogInformation("Seeding vocabulary...");
                var vocabulary = FirstJohnTextData.GetVocabulary();
                var occurrencesByRoot = GreekNtOccurrencesData.Load();
                await UpsertVocabularyAsync(context, vocabulary, occurrencesByRoot);

                // Get ID mappings for text seeding (duplicate-safe)
                var gramCodeToId = await BuildGrammaticalFeatureCodeMapAsync(context);
                var synCodeToId = await BuildSyntacticalFeatureCodeMapAsync(context);
                var vocabToId = await BuildVocabularyRootMapAsync(context);

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
                foreach (var (index, seedUnits) in chapters)
                {
                    // Map objects (Phrase/Word) to Domain UnitNodes
                    var unitNodes = seedUnits.Select((u, i) => MapObjectToUnitNode(u, gramCodeToId, synCodeToId, vocabToId, i.ToString())).ToList();
                    
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

                // 7. Create lesson tracks and lessons
                logger.LogInformation("Creating lesson tracks and lessons...");
                await EnsureLessonTracksAndLessonsAsync(context, logger);

                // 8. Create development users and progression profiles for reader/SRS validation.
                logger.LogInformation("Creating development users and vocabulary mastery profiles...");
                await EnsureDevelopmentUsersAndProfilesAsync(context, logger);

                // 9. Seed system vocabulary sets
                logger.LogInformation("Creating system vocabulary sets...");
                await EnsureSystemVocabularySetsAsync(context);

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

        private static UnitNode MapObjectToUnitNode(
            object seedObj,
            Dictionary<string, int> gramCodeToId,
            Dictionary<string, int> synCodeToId,
            Dictionary<string, int> vocabToId,
            string path)
        {
            if (seedObj is Phrase phrase)
            {
                return new UnitNode
                {
                    Type = "unit",
                    Path = path,
                    Translation = phrase.Translation,
                    SynFeatureIds = phrase.SyntaxCodes?
                        .Select(c => synCodeToId.TryGetValue(c, out var id) ? id : 0)
                        .Where(id => id != 0)
                        .ToList(),
                    Children = phrase.Content?
                        .Select((c, i) => MapObjectToUnitNode(c, gramCodeToId, synCodeToId, vocabToId, $"{path}.{i}"))
                        .ToList()
                };
            }
            else if (seedObj is Word word)
            {
                var node = new UnitNode
                {
                    Type = "word",
                    Path = path,
                    Root = word.Greek,
                    Content = word.Gloss,
                    Marker = word.Transliteration,
                    GramFeatureIds = word.GrammarCodes?
                        .Select(c => gramCodeToId.TryGetValue(c, out var id) ? id : 0)
                        .Where(id => id != 0)
                        .ToList(),
                    VocabId = word.Greek != null && vocabToId.TryGetValue(word.Greek, out var vid) ? vid : null
                };
                return node;
            }

            return new UnitNode { Type = "unknown", Path = path };
        }

        private static string HashPassword(string password)
        {
            // TODO: Use proper password hashing (BCrypt, Argon2, etc.)
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }

        private static async Task EnsureDevelopmentUsersAndProfilesAsync(KoineDbContext context, ILogger logger)
        {
            var now = DateTime.UtcNow;
            var userSeeds = new[]
            {
                new { Username = "novice", Email = "novice@test.com", DisplayName = "Dev Novice", Profile = "none" },
                new { Username = "freq100", Email = "freq100@test.com", DisplayName = "Dev 100+", Profile = "gt100" },
                new { Username = "freq50", Email = "freq50@test.com", DisplayName = "Dev 50+", Profile = "gt50" },
                new { Username = "freq15", Email = "freq15@test.com", DisplayName = "Dev 15+", Profile = "gt15" },
                new { Username = "mastered", Email = "mastered@test.com", DisplayName = "Dev Mastered", Profile = "all" },
            };

            var usersByProfile = new Dictionary<string, User>(StringComparer.Ordinal);
            foreach (var seed in userSeeds)
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.Username == seed.Username);
                if (user == null)
                {
                    user = new User
                    {
                        Email = seed.Email,
                        Username = seed.Username,
                        DisplayName = seed.DisplayName,
                        TotalExperience = 0,
                        PasswordHash = HashPassword("password123"),
                        CreatedAt = now
                    };
                    context.Users.Add(user);
                }
                else
                {
                    user.Email = seed.Email;
                    user.DisplayName = seed.DisplayName;
                    user.TotalExperience = 0;
                    user.PasswordHash = HashPassword("password123");
                    context.Users.Update(user);
                }

                usersByProfile[seed.Profile] = user;
            }

            await context.SaveChangesAsync();

            var profileExperience = new Dictionary<string, int>(StringComparer.Ordinal)
            {
                ["none"] = 120,
                ["gt100"] = 1350,
                ["gt50"] = 2850,
                ["gt15"] = 5200,
                ["all"] = 9800,
            };
            foreach (var (profile, user) in usersByProfile)
            {
                user.TotalExperience = profileExperience.TryGetValue(profile, out var xp) ? xp : 0;
            }
            await context.SaveChangesAsync();

            var vocabMeta = await context.Vocabularies
                .AsNoTracking()
                .Select(v => new { v.Id, Occurrences = v.Occurrences ?? 0 })
                .ToListAsync();
            var grammarIds = await context.GrammaticalFeatures
                .AsNoTracking()
                .Select(g => g.Id)
                .ToListAsync();
            var syntaxIds = await context.SyntacticalFeatures
                .AsNoTracking()
                .Select(s => s.Id)
                .ToListAsync();

            Dictionary<int, FeatureProgress> BuildFeatureProfile(int mastery)
            {
                return grammarIds.ToDictionary(
                    id => id,
                    _ => new FeatureProgress
                    {
                        MasteryLevel = mastery,
                        NeedsPractice = false,
                        LastPracticed = now.AddDays(-1)
                    });
            }

            Dictionary<int, FeatureProgress> BuildSyntaxProfile(int mastery)
            {
                return syntaxIds.ToDictionary(
                    id => id,
                    _ => new FeatureProgress
                    {
                        MasteryLevel = mastery,
                        NeedsPractice = false,
                        LastPracticed = now.AddDays(-1)
                    });
            }

            Dictionary<int, VocabularyProgress> BuildVocabularyProfile(
                HashSet<int> masteredIds,
                double practicingFractionOfRemaining = 0.35,
                Func<int, bool>? forcePracticingPredicate = null)
            {
                var remainingByFrequency = vocabMeta
                    .Where(v => !masteredIds.Contains(v.Id))
                    .OrderByDescending(v => v.Occurrences)
                    .ThenBy(v => v.Id)
                    .Select(v => v.Id)
                    .ToList();
                var practicingCount = remainingByFrequency.Count == 0
                    ? 0
                    : practicingFractionOfRemaining <= 0
                        ? 0
                        : Math.Max(1, (int)Math.Ceiling(remainingByFrequency.Count * practicingFractionOfRemaining));
                var practicingIds = remainingByFrequency
                    .Take(practicingCount)
                    .ToHashSet();

                return vocabMeta.ToDictionary(
                    v => v.Id,
                    v =>
                    {
                        var forcePracticing = forcePracticingPredicate?.Invoke(v.Id) == true;
                        var mastered = masteredIds.Contains(v.Id) && !forcePracticing;
                        var practicing = !mastered && (forcePracticing || practicingIds.Contains(v.Id));
                        return new VocabularyProgress
                        {
                            MasteryLevel = mastered ? 95 : practicing ? 60 : 0,
                            NeedsPractice = practicing,
                            LastPracticed = now.AddDays(mastered ? -2 : practicing ? -5 : -14),
                            TimesSeen = mastered ? 24 : practicing ? 8 : 0
                        };
                    });
            }

            HashSet<int> ResolveMasteredIds(int thresholdExclusive, double fallbackPercentile)
            {
                var direct = vocabMeta
                    .Where(v => v.Occurrences > thresholdExclusive)
                    .Select(v => v.Id)
                    .ToHashSet();
                if (direct.Count > 0)
                {
                    return direct;
                }

                if (vocabMeta.Count == 0)
                {
                    return new HashSet<int>();
                }

                var takeCount = Math.Max(1, (int)Math.Ceiling(vocabMeta.Count * fallbackPercentile));
                return vocabMeta
                    .OrderByDescending(v => v.Occurrences)
                    .ThenBy(v => v.Id)
                    .Take(takeCount)
                    .Select(v => v.Id)
                    .ToHashSet();
            }

            HashSet<int> CapMasteredIds(HashSet<int> masteredIds, double maxFraction)
            {
                if (vocabMeta.Count == 0)
                {
                    return masteredIds;
                }

                var maxCount = Math.Max(1, (int)Math.Floor(vocabMeta.Count * maxFraction));
                if (masteredIds.Count <= maxCount)
                {
                    return masteredIds;
                }

                return vocabMeta
                    .Where(v => masteredIds.Contains(v.Id))
                    .OrderByDescending(v => v.Occurrences)
                    .ThenBy(v => v.Id)
                    .Take(maxCount)
                    .Select(v => v.Id)
                    .ToHashSet();
            }

            var gt100MasteredIds = ResolveMasteredIds(100, 0.10);
            var gt50MasteredIds = CapMasteredIds(ResolveMasteredIds(50, 0.25), maxFraction: 0.80);
            var gt15MasteredIds = CapMasteredIds(ResolveMasteredIds(15, 0.50), maxFraction: 0.92);

            var profileProgress = new Dictionary<string, Dictionary<int, VocabularyProgress>>(StringComparer.Ordinal)
            {
                // Novice: unknown vocabulary to force translated rendering.
                ["none"] = BuildVocabularyProfile(new HashSet<int>(), practicingFractionOfRemaining: 0.0),
                ["gt100"] = BuildVocabularyProfile(gt100MasteredIds),
                ["gt50"] = BuildVocabularyProfile(gt50MasteredIds, forcePracticingPredicate: id => id % 5 == 0),
                ["gt15"] = BuildVocabularyProfile(gt15MasteredIds, forcePracticingPredicate: id => id % 11 == 0),
                ["all"] = BuildVocabularyProfile(vocabMeta.Select(v => v.Id).ToHashSet(), practicingFractionOfRemaining: 0.0),
            };

            var profileGrammar = new Dictionary<string, Dictionary<int, FeatureProgress>>(StringComparer.Ordinal)
            {
                ["none"] = BuildFeatureProfile(30),
                // gt100 keeps grammar below threshold to exercise parsing-help state.
                ["gt100"] = BuildFeatureProfile(55),
                // gt50+ should be grammar-capable so non-mastered vocab can render as amber practice.
                ["gt50"] = BuildFeatureProfile(85),
                ["gt15"] = BuildFeatureProfile(95),
                ["all"] = BuildFeatureProfile(100),
            };

            var profileSyntax = new Dictionary<string, Dictionary<int, FeatureProgress>>(StringComparer.Ordinal)
            {
                ["none"] = BuildSyntaxProfile(30),
                ["gt100"] = BuildSyntaxProfile(55),
                ["gt50"] = BuildSyntaxProfile(85),
                ["gt15"] = BuildSyntaxProfile(95),
                ["all"] = BuildSyntaxProfile(100),
            };

            foreach (var (profile, user) in usersByProfile)
            {
                var userProgress = await context.UserProgresses.FirstOrDefaultAsync(up => up.UserId == user.Id);
                if (userProgress == null)
                {
                    userProgress = new UserProgress
                    {
                        UserId = user.Id,
                        CompletedLessonIdsJson = "[]",
                        UpdatedAt = now
                    };
                    context.UserProgresses.Add(userProgress);
                }

                userProgress.GrammaticalFeatureProgressJson = JsonSerializer.Serialize(profileGrammar[profile]);
                userProgress.SyntacticalFeatureProgressJson = JsonSerializer.Serialize(profileSyntax[profile]);
                userProgress.VocabularyProgressJson = JsonSerializer.Serialize(profileProgress[profile]);
                userProgress.UpdatedAt = now;
            }

            await context.SaveChangesAsync();

            logger.LogInformation(
                "Ensured development reader profiles: novice(0), freq100(>100), freq50(>50), freq15(>15), mastered(all).");
            logger.LogInformation(
                "Development profile coverage counts: gt100={Gt100}, gt50={Gt50}, gt15={Gt15}, totalVocab={Total}.",
                gt100MasteredIds.Count,
                gt50MasteredIds.Count,
                gt15MasteredIds.Count,
                vocabMeta.Count);
        }

        private static async Task UpsertGrammaticalFeaturesAsync(
            KoineDbContext context,
            IEnumerable<(string Code, string Name, string Category, string Definition, int SortOrder)> features)
        {
            var existing = await context.GrammaticalFeatures
                .OrderBy(f => f.Id)
                .ToListAsync();
            var duplicateRows = existing
                .GroupBy(f => f.Code)
                .SelectMany(g => g.Skip(1))
                .ToList();
            if (duplicateRows.Count > 0)
            {
                context.GrammaticalFeatures.RemoveRange(duplicateRows);
            }
            var byCode = existing
                .GroupBy(f => f.Code)
                .ToDictionary(g => g.Key, g => g.First());

            foreach (var (code, name, category, definition, sortOrder) in features)
            {
                if (byCode.TryGetValue(code, out var current))
                {
                    current.Name = name;
                    current.Category = category;
                    current.Definition = definition;
                    current.SortOrder = sortOrder;
                }
                else
                {
                    var created = new GrammaticalFeature
                    {
                        Code = code,
                        Name = name,
                        Category = category,
                        Definition = definition,
                        SortOrder = sortOrder
                    };
                    context.GrammaticalFeatures.Add(created);
                    byCode[code] = created;
                }
            }

            await context.SaveChangesAsync();
        }

        private static async Task UpsertSyntacticalFeaturesAsync(
            KoineDbContext context,
            IEnumerable<(string Code, string Name, string Definition, int SortOrder)> features)
        {
            var existing = await context.SyntacticalFeatures
                .OrderBy(f => f.Id)
                .ToListAsync();
            var duplicateRows = existing
                .GroupBy(f => f.Code)
                .SelectMany(g => g.Skip(1))
                .ToList();
            if (duplicateRows.Count > 0)
            {
                context.SyntacticalFeatures.RemoveRange(duplicateRows);
            }
            var byCode = existing
                .GroupBy(f => f.Code)
                .ToDictionary(g => g.Key, g => g.First());

            foreach (var (code, name, definition, sortOrder) in features)
            {
                if (byCode.TryGetValue(code, out var current))
                {
                    current.Name = name;
                    current.Definition = definition;
                    current.SortOrder = sortOrder;
                }
                else
                {
                    var created = new SyntacticalFeature
                    {
                        Code = code,
                        Name = name,
                        Definition = definition,
                        SortOrder = sortOrder
                    };
                    context.SyntacticalFeatures.Add(created);
                    byCode[code] = created;
                }
            }

            await context.SaveChangesAsync();
        }

        private static async Task UpsertVocabularyAsync(
            KoineDbContext context,
            IEnumerable<(string Root, string Transliteration, string Gloss, string PartOfSpeech, int Occurrences)> vocabulary,
            IReadOnlyDictionary<string, int> occurrencesByRoot)
        {
            var existing = await context.Vocabularies
                .OrderBy(v => v.Id)
                .ToListAsync();
            var duplicateRows = existing
                .Where(v => !string.IsNullOrWhiteSpace(v.Root))
                .GroupBy(v => v.Root)
                .SelectMany(g => g.Skip(1))
                .ToList();
            if (duplicateRows.Count > 0)
            {
                context.Vocabularies.RemoveRange(duplicateRows);
            }
            var byRoot = existing
                .Where(v => !string.IsNullOrWhiteSpace(v.Root))
                .GroupBy(v => v.Root)
                .ToDictionary(g => g.Key, g => g.First());

            foreach (var (root, transliteration, gloss, partOfSpeech, fallbackOccurrences) in vocabulary)
            {
                var occurrences = occurrencesByRoot.GetValueOrDefault(root, fallbackOccurrences);
                if (byRoot.TryGetValue(root, out var current))
                {
                    current.Transliteration = transliteration;
                    current.Gloss = gloss;
                    current.PartOfSpeech = partOfSpeech;
                    current.Occurrences = occurrences;
                }
                else
                {
                    var created = new Vocabulary
                    {
                        Root = root,
                        Transliteration = transliteration,
                        Gloss = gloss,
                        PartOfSpeech = partOfSpeech,
                        Occurrences = occurrences,
                        CreatedAt = DateTime.UtcNow
                    };
                    context.Vocabularies.Add(created);
                    byRoot[root] = created;
                }
            }

            await context.SaveChangesAsync();
        }

        private static async Task EnsureFeatureCoverageForSeedDataAsync(
            KoineDbContext context,
            Dictionary<int, List<object>> chapters,
            ILogger logger)
        {
            var (usedGrammarCodes, usedSyntaxCodes) = CollectFeatureCodes(chapters);
            var knownGrammarCodes = await context.GrammaticalFeatures
                .Select(f => f.Code)
                .Distinct()
                .ToListAsync();
            var knownSyntaxCodes = await context.SyntacticalFeatures
                .Select(f => f.Code)
                .Distinct()
                .ToListAsync();

            var missingGrammar = usedGrammarCodes
                .Where(code => !knownGrammarCodes.Contains(code))
                .OrderBy(code => code)
                .ToList();
            var missingSyntax = usedSyntaxCodes
                .Where(code => !knownSyntaxCodes.Contains(code))
                .OrderBy(code => code)
                .ToList();

            if (missingGrammar.Count == 0 && missingSyntax.Count == 0)
            {
                return;
            }

            var maxGrammarSortOrder = await context.GrammaticalFeatures
                .Select(f => (int?)f.SortOrder)
                .MaxAsync() ?? 0;
            var maxSyntaxSortOrder = await context.SyntacticalFeatures
                .Select(f => (int?)f.SortOrder)
                .MaxAsync() ?? 0;

            foreach (var code in missingGrammar)
            {
                context.GrammaticalFeatures.Add(new GrammaticalFeature
                {
                    Code = code,
                    Name = code,
                    Category = "generated",
                    Definition = $"Auto-generated from seed data for grammar code '{code}'.",
                    SortOrder = ++maxGrammarSortOrder
                });
            }

            foreach (var code in missingSyntax)
            {
                context.SyntacticalFeatures.Add(new SyntacticalFeature
                {
                    Code = code,
                    Name = code.Replace('_', ' '),
                    Definition = $"Auto-generated from seed data for syntax code '{code}'.",
                    SortOrder = ++maxSyntaxSortOrder
                });
            }

            await context.SaveChangesAsync();
            logger.LogWarning(
                "Auto-generated missing seed feature definitions. Grammar: {GrammarCodes}. Syntax: {SyntaxCodes}.",
                string.Join(", ", missingGrammar),
                string.Join(", ", missingSyntax));
        }

        private static (HashSet<string> GrammarCodes, HashSet<string> SyntaxCodes) CollectFeatureCodes(
            IReadOnlyDictionary<int, List<object>> chapters)
        {
            var grammarCodes = new HashSet<string>(StringComparer.Ordinal);
            var syntaxCodes = new HashSet<string>(StringComparer.Ordinal);

            foreach (var (_, nodes) in chapters)
            {
                foreach (var node in nodes)
                {
                    CollectFeatureCodesFromNode(node, grammarCodes, syntaxCodes);
                }
            }

            return (grammarCodes, syntaxCodes);
        }

        private static void CollectFeatureCodesFromNode(
            object node,
            ISet<string> grammarCodes,
            ISet<string> syntaxCodes)
        {
            if (node is Word word)
            {
                foreach (var code in word.GrammarCodes.Where(c => !string.IsNullOrWhiteSpace(c)))
                {
                    grammarCodes.Add(code);
                }

                return;
            }

            if (node is Phrase phrase)
            {
                foreach (var code in phrase.SyntaxCodes.Where(c => !string.IsNullOrWhiteSpace(c)))
                {
                    syntaxCodes.Add(code);
                }

                foreach (var child in phrase.Content)
                {
                    CollectFeatureCodesFromNode(child, grammarCodes, syntaxCodes);
                }
            }
        }

        private static async Task<Dictionary<string, int>> BuildGrammaticalFeatureCodeMapAsync(KoineDbContext context)
        {
            var features = await context.GrammaticalFeatures
                .AsNoTracking()
                .OrderBy(f => f.Id)
                .ToListAsync();

            return features
                .GroupBy(f => f.Code)
                .ToDictionary(g => g.Key, g => g.First().Id);
        }

        private static async Task<Dictionary<string, int>> BuildSyntacticalFeatureCodeMapAsync(KoineDbContext context)
        {
            var features = await context.SyntacticalFeatures
                .AsNoTracking()
                .OrderBy(f => f.Id)
                .ToListAsync();

            return features
                .GroupBy(f => f.Code)
                .ToDictionary(g => g.Key, g => g.First().Id);
        }

        private static async Task<Dictionary<string, int>> BuildVocabularyRootMapAsync(KoineDbContext context)
        {
            var vocabulary = await context.Vocabularies
                .AsNoTracking()
                .OrderBy(v => v.Id)
                .ToListAsync();

            return vocabulary
                .Where(v => !string.IsNullOrWhiteSpace(v.Root))
                .GroupBy(v => v.Root)
                .ToDictionary(g => g.Key, g => g.First().Id);
        }

        private static async Task EnsureLessonTracksAndLessonsAsync(KoineDbContext context, ILogger logger)
        {
            var now = DateTime.UtcNow;
            var tracks = new[]
            {
                new { Slug = "koine-core", Title = "Koine Core Track", Description = "Core grammar and syntax progression for Koine Greek.", SortOrder = 1 },
                new { Slug = "decker-track", Title = "Decker Track", Description = "Alternative track with the same feature coverage for textbook-based pacing.", SortOrder = 2 },
            };

            foreach (var trackSeed in tracks)
            {
                var track = await context.LessonTracks.FirstOrDefaultAsync(t => t.Slug == trackSeed.Slug);
                if (track == null)
                {
                    track = new LessonTrack
                    {
                        Slug = trackSeed.Slug,
                        Title = trackSeed.Title,
                        Description = trackSeed.Description,
                        SortOrder = trackSeed.SortOrder,
                        IsSystem = true,
                        CreatedAt = now
                    };
                    context.LessonTracks.Add(track);
                    await context.SaveChangesAsync();
                }
                else
                {
                    track.Title = trackSeed.Title;
                    track.Description = trackSeed.Description;
                    track.SortOrder = trackSeed.SortOrder;
                    track.IsSystem = true;
                    context.LessonTracks.Update(track);
                    await context.SaveChangesAsync();
                }

                await EnsureTrackLessonsAsync(context, track, logger);
            }

            // Backfill legacy lessons that may still be unassigned.
            var defaultTrack = await context.LessonTracks.FirstAsync(t => t.Slug == "koine-core");
            var unassignedLessons = await context.Lessons.Where(l => l.TrackId == 0).ToListAsync();
            foreach (var lesson in unassignedLessons)
            {
                lesson.TrackId = defaultTrack.Id;
                lesson.Slug = string.IsNullOrWhiteSpace(lesson.Slug) ? $"lesson-{lesson.Id}" : lesson.Slug;
            }

            if (unassignedLessons.Count > 0)
            {
                context.Lessons.UpdateRange(unassignedLessons);
                await context.SaveChangesAsync();
            }
        }

        private static async Task EnsureTrackLessonsAsync(KoineDbContext context, LessonTrack track, ILogger logger)
        {
            var grammarFeatures = await context.GrammaticalFeatures
                .OrderBy(g => g.SortOrder)
                .ThenBy(g => g.Id)
                .ToListAsync();
            var syntaxFeatures = await context.SyntacticalFeatures
                .OrderBy(s => s.SortOrder)
                .ThenBy(s => s.Id)
                .ToListAsync();

            var lessonIndex = 1;
            var expectedLessonSlugs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var feature in grammarFeatures)
            {
                var lessonSlug = $"grammar-{feature.Code.ToLowerInvariant()}";
                expectedLessonSlugs.Add(lessonSlug);
                var contentPath = "Data/Seed/Lessons/grammar-template.mdx";
                var content = await BuildFeatureLessonContentAsync(
                    fallbackHeading: $"Grammar: {feature.Name}",
                    definition: feature.Definition,
                    featureCode: feature.Code,
                    lessonType: "grammar",
                    contentPath: contentPath);

                await UpsertTrackLessonAsync(
                    context,
                    track.Id,
                    lessonSlug,
                    title: $"{feature.Name}",
                    lessonType: "grammar",
                    lessonIndex: lessonIndex++,
                    contentMarkdown: content,
                    contentPath: contentPath,
                    grammaticalFeatureIds: new[] { feature.Id },
                    syntacticalFeatureIds: Array.Empty<int>(),
                    vocabularyIds: Array.Empty<int>());
            }

            foreach (var feature in syntaxFeatures)
            {
                var lessonSlug = $"syntax-{feature.Code.ToLowerInvariant()}";
                expectedLessonSlugs.Add(lessonSlug);
                var contentPath = "Data/Seed/Lessons/syntax-template.mdx";
                var content = await BuildFeatureLessonContentAsync(
                    fallbackHeading: $"Syntax: {feature.Name}",
                    definition: feature.Definition,
                    featureCode: feature.Code,
                    lessonType: "syntax",
                    contentPath: contentPath);

                await UpsertTrackLessonAsync(
                    context,
                    track.Id,
                    lessonSlug,
                    title: $"{feature.Name}",
                    lessonType: "syntax",
                    lessonIndex: lessonIndex++,
                    contentMarkdown: content,
                    contentPath: contentPath,
                    grammaticalFeatureIds: Array.Empty<int>(),
                    syntacticalFeatureIds: new[] { feature.Id },
                    vocabularyIds: Array.Empty<int>());
            }

            if (lessonIndex == 1)
            {
                // Guarantee PoC content exists even if feature tables are empty in legacy/dev databases.
                await UpsertTrackLessonAsync(
                    context,
                    track.Id,
                    slug: "intro-overview",
                    title: "Introduction and Learning Workflow",
                    lessonType: "overview",
                    lessonIndex: lessonIndex++,
                    contentMarkdown: """
                        # Introduction and Learning Workflow

                        This is a placeholder lesson for MVP proof-of-concept.

                        ## Goal
                        Learn how lessons, progress, and next-step navigation work in this track.

                        ## TODO (Next Phase)
                        Add practice problems and scored checks.
                        """,
                    contentPath: null,
                    grammaticalFeatureIds: Array.Empty<int>(),
                    syntacticalFeatureIds: Array.Empty<int>(),
                    vocabularyIds: Array.Empty<int>());
                expectedLessonSlugs.Add("intro-overview");

                await UpsertTrackLessonAsync(
                    context,
                    track.Id,
                    slug: "intro-syntax-basics",
                    title: "Syntax Basics Walkthrough",
                    lessonType: "syntax",
                    lessonIndex: lessonIndex++,
                    contentMarkdown: """
                        # Syntax Basics Walkthrough

                        This is a second placeholder lesson to verify ordered track progression.

                        ## Goal
                        Confirm completion toggles and next lesson behavior.

                        ## TODO (Next Phase)
                        Add targeted syntax drills.
                        """,
                    contentPath: null,
                    grammaticalFeatureIds: Array.Empty<int>(),
                    syntacticalFeatureIds: Array.Empty<int>(),
                    vocabularyIds: Array.Empty<int>());
                expectedLessonSlugs.Add("intro-syntax-basics");
            }

            var staleLessons = await context.Lessons
                .Where(l => l.TrackId == track.Id && !expectedLessonSlugs.Contains(l.Slug))
                .ToListAsync();
            if (staleLessons.Count > 0)
            {
                context.Lessons.RemoveRange(staleLessons);
                await context.SaveChangesAsync();
            }

            logger.LogInformation("Ensured lessons for track {TrackSlug}: {Count} lessons", track.Slug, lessonIndex - 1);
        }

        private static async Task UpsertTrackLessonAsync(
            KoineDbContext context,
            int trackId,
            string slug,
            string title,
            string lessonType,
            int lessonIndex,
            string contentMarkdown,
            string? contentPath,
            IEnumerable<int> grammaticalFeatureIds,
            IEnumerable<int> syntacticalFeatureIds,
            IEnumerable<int> vocabularyIds)
        {
            var lesson = await context.Lessons.FirstOrDefaultAsync(l => l.TrackId == trackId && l.Slug == slug);
            if (lesson == null)
            {
                lesson = new Lesson
                {
                    TrackId = trackId,
                    Slug = slug,
                    Title = title,
                    LessonType = lessonType,
                    LessonIndex = lessonIndex,
                    ContentMarkdown = contentMarkdown,
                    ContentPath = contentPath,
                    GrammaticalFeatureIdsJson = JsonSerializer.Serialize(grammaticalFeatureIds.Distinct().ToList()),
                    SyntacticalFeatureIdsJson = JsonSerializer.Serialize(syntacticalFeatureIds.Distinct().ToList()),
                    VocabularyIdsJson = JsonSerializer.Serialize(vocabularyIds.Distinct().ToList()),
                    CreatedAt = DateTime.UtcNow
                };
                context.Lessons.Add(lesson);
            }
            else
            {
                lesson.Title = title;
                lesson.LessonType = lessonType;
                lesson.LessonIndex = lessonIndex;
                lesson.ContentMarkdown = contentMarkdown;
                lesson.ContentPath = contentPath;
                lesson.GrammaticalFeatureIdsJson = JsonSerializer.Serialize(grammaticalFeatureIds.Distinct().ToList());
                lesson.SyntacticalFeatureIdsJson = JsonSerializer.Serialize(syntacticalFeatureIds.Distinct().ToList());
                lesson.VocabularyIdsJson = JsonSerializer.Serialize(vocabularyIds.Distinct().ToList());
                context.Lessons.Update(lesson);
            }

            await context.SaveChangesAsync();
        }

        private static async Task<string> BuildFeatureLessonContentAsync(
            string fallbackHeading,
            string definition,
            string featureCode,
            string lessonType,
            string contentPath)
        {
            var mdx = await LoadLessonMdxAsync(contentPath);
            if (!string.IsNullOrWhiteSpace(mdx))
            {
                return mdx
                    .Replace("{{HEADING}}", fallbackHeading)
                    .Replace("{{FEATURE_CODE}}", featureCode)
                    .Replace("{{DEFINITION}}", definition)
                    .Replace("{{LESSON_TYPE}}", lessonType);
            }

            return $"""
                # {fallbackHeading}

                **Feature Code:** `{featureCode}`

                ## Overview
                {definition}

                ## Why It Matters
                This placeholder lesson introduces {lessonType} feature `{featureCode}` for the MVP track.

                ## TODO (Next Phase)
                Add interactive practice problems and adaptive checks for this lesson.
                """;
        }

        private static async Task<string?> LoadLessonMdxAsync(string relativePath)
        {
            var candidates = new[]
            {
                Path.Combine(AppContext.BaseDirectory, relativePath.Replace('/', Path.DirectorySeparatorChar)),
                Path.Combine(Directory.GetCurrentDirectory(), relativePath.Replace('/', Path.DirectorySeparatorChar)),
            };

            foreach (var candidate in candidates)
            {
                if (File.Exists(candidate))
                {
                    return await File.ReadAllTextAsync(candidate);
                }
            }

            return null;
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
                    TotalExperience = 0,
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

            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[VocabularySetItems]', N'U') IS NOT NULL
                BEGIN
                    IF COL_LENGTH('VocabularySetItems', 'MasteryLevel') IS NOT NULL
                    BEGIN
                        UPDATE [VocabularySetItems]
                        SET [MasteryLevel] = COALESCE([MasteryLevel], 0);

                        IF NOT EXISTS (
                            SELECT 1
                            FROM sys.default_constraints dc
                            INNER JOIN sys.columns c
                                ON c.default_object_id = dc.object_id
                            WHERE dc.parent_object_id = OBJECT_ID('VocabularySetItems')
                              AND c.name = 'MasteryLevel'
                        )
                        BEGIN
                            ALTER TABLE [VocabularySetItems]
                            ADD CONSTRAINT [DF_VocabularySetItems_MasteryLevel] DEFAULT (0) FOR [MasteryLevel];
                        END
                    END
                END
                """);
        }

        private static async Task EnsureLessonSchemaAsync(KoineDbContext context)
        {
            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[LessonTracks]', N'U') IS NULL
                BEGIN
                    CREATE TABLE [LessonTracks](
                        [Id] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
                        [Slug] nvarchar(200) NOT NULL,
                        [Title] nvarchar(200) NOT NULL,
                        [Description] nvarchar(1000) NOT NULL CONSTRAINT [DF_LessonTracks_Description] DEFAULT (''),
                        [SortOrder] int NOT NULL CONSTRAINT [DF_LessonTracks_SortOrder] DEFAULT (0),
                        [IsSystem] bit NOT NULL CONSTRAINT [DF_LessonTracks_IsSystem] DEFAULT (1),
                        [CreatedAt] datetime2 NOT NULL CONSTRAINT [DF_LessonTracks_CreatedAt] DEFAULT (GETUTCDATE())
                    );

                    CREATE UNIQUE INDEX [IX_LessonTracks_Slug] ON [LessonTracks]([Slug]);
                END
                """);

            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[Lessons]', N'U') IS NOT NULL
                BEGIN
                    IF COL_LENGTH('Lessons', 'TrackId') IS NULL
                    BEGIN
                        ALTER TABLE [Lessons] ADD [TrackId] int NOT NULL CONSTRAINT [DF_Lessons_TrackId] DEFAULT (0);
                    END

                    IF COL_LENGTH('Lessons', 'Slug') IS NULL
                    BEGIN
                        ALTER TABLE [Lessons] ADD [Slug] nvarchar(200) NOT NULL CONSTRAINT [DF_Lessons_Slug] DEFAULT ('');
                    END

                    IF COL_LENGTH('Lessons', 'ContentPath') IS NULL
                    BEGIN
                        ALTER TABLE [Lessons] ADD [ContentPath] nvarchar(500) NULL;
                    END

                    UPDATE [Lessons]
                    SET [Slug] = CONCAT('lesson-', [Id])
                    WHERE [Slug] IS NULL OR LTRIM(RTRIM([Slug])) = '';
                END
                """);

            await context.Database.ExecuteSqlRawAsync(
                """
                IF OBJECT_ID(N'[Lessons]', N'U') IS NOT NULL
                BEGIN
                    IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_Lessons_Track_LessonIndex' AND object_id = OBJECT_ID('Lessons'))
                    BEGIN
                        CREATE INDEX [IX_Lessons_Track_LessonIndex] ON [Lessons]([TrackId], [LessonIndex]);
                    END

                    IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_Lessons_Track_Slug' AND object_id = OBJECT_ID('Lessons'))
                    BEGIN
                        CREATE INDEX [IX_Lessons_Track_Slug] ON [Lessons]([TrackId], [Slug]);
                    END
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
                        EXEC sp_executesql N'
                            UPDATE [Vocabularies]
                            SET [Occurrences] = COALESCE([Occurrences], [FrequencyRank]);
                        ';
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
