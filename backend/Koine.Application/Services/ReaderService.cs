// Koine.Application/Services/ReaderService.cs
using System.Text.Json;
using Koine.Application.DTOs.Reader;
using Koine.Application.Interfaces;
using Koine.Domain.ValueObjects;

namespace Koine.Application.Services
{
    public class ReaderService : IReaderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReaderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RenderedChapterDto> RenderChapterAsync(
            int userId, 
            int bookId, 
            int chapterIndex, 
            string targetLanguage = "en")
        {
            // 1. Fetch chapter
            var chapter = await _unitOfWork.Chapters.GetByBookAndIndexAsync(bookId, chapterIndex);
            if (chapter == null)
                throw new KeyNotFoundException($"Chapter {chapterIndex} not found in book {bookId}");

            // 2. Fetch user progress (with fallback for MVP)
            var userProgress = await _unitOfWork.UserProgress.GetByUserIdAsync(userId);
            
            // 3. Fetch translation
            var translation = await _unitOfWork.Translations.GetByBookAndLanguageAsync(bookId, targetLanguage);
            if (translation == null)
                throw new KeyNotFoundException($"Translation not found for book {bookId} in language {targetLanguage}");

            // 4. Fetch translation units
            var translationUnits = await _unitOfWork.TranslationUnits
                .GetByChapterAndTranslationAsync(chapter.Id, translation.Id);

            // 5. Build translation map
            var translationMap = translationUnits.ToDictionary(
                tu => tu.OriginalUnitPath,
                tu => new TranslationMapping 
                { 
                    Path = tu.OriginalUnitPath, 
                    Text = tu.TranslatedText, 
                    Order = tu.DisplayOrder 
                }
            );

            // 6. Parse unit tree
            var unitTree = JsonSerializer.Deserialize<List<UnitNode>>(chapter.UnitTreeJson) 
                ?? new List<UnitNode>();

            var grammarFeatureIds = new HashSet<int>();
            var syntaxFeatureIds = new HashSet<int>();
            foreach (var node in unitTree)
            {
                CollectFeatureIds(node, grammarFeatureIds, syntaxFeatureIds);
            }

            var grammaticalFeatures = grammarFeatureIds.Count > 0
                ? await _unitOfWork.GrammaticalFeatures.GetByIdsAsync(grammarFeatureIds.ToList())
                : new List<Domain.Entities.GrammaticalFeature>();
            var syntacticalFeatures = syntaxFeatureIds.Count > 0
                ? await _unitOfWork.SyntacticalFeatures.GetByIdsAsync(syntaxFeatureIds.ToList())
                : new List<Domain.Entities.SyntacticalFeature>();

            var gramCodeById = grammaticalFeatures.ToDictionary(f => f.Id, f => f.Code);
            var synCodeById = syntacticalFeatures.ToDictionary(f => f.Id, f => f.Code);

            // 7. Parse progress data (fallback to defaults if userProgress is null)
            var gramProgress = userProgress != null 
                ? (JsonSerializer.Deserialize<Dictionary<int, FeatureProgress>>(userProgress.GrammaticalFeatureProgressJson) ?? new())
                : new Dictionary<int, FeatureProgress>();
                
            var synProgress = userProgress != null
                ? (JsonSerializer.Deserialize<Dictionary<int, FeatureProgress>>(userProgress.SyntacticalFeatureProgressJson) ?? new())
                : new Dictionary<int, FeatureProgress>();
                
            var vocabProgress = userProgress != null
                ? (JsonSerializer.Deserialize<Dictionary<int, VocabularyProgress>>(userProgress.VocabularyProgressJson) ?? new())
                : new Dictionary<int, VocabularyProgress>();

            // 8. Render units
            var renderedUnits = unitTree
                .Select(unit => RenderUnit(unit, translationMap, gramProgress, synProgress, vocabProgress, gramCodeById, synCodeById))
                .ToList();

            return new RenderedChapterDto
            {
                ChapterId = chapter.Id,
                Title = chapter.Title ?? string.Empty,
                Units = renderedUnits
            };
        }

        private RenderedUnitDto RenderUnit(
            UnitNode unit,
            Dictionary<string, TranslationMapping> translationMap,
            Dictionary<int, FeatureProgress> gramProgress,
            Dictionary<int, FeatureProgress> synProgress,
            Dictionary<int, VocabularyProgress> vocabProgress,
            Dictionary<int, string> gramCodeById,
            Dictionary<int, string> synCodeById)
        {
            // Handle meta nodes
            if (unit.Type == "meta")
            {
                return new RenderedUnitDto
                {
                    Type = "meta",
                    Text = unit.Content,
                    Marker = unit.Marker,
                    Path = unit.Path
                };
            }

            // Check grammar/syntax knowledge together for rendering decisions.
            var grammarMastered = FeaturesMastered(unit.GramFeatureIds, gramProgress)
                && FeaturesMastered(unit.SynFeatureIds, synProgress);
            var grammarNeedsSupport = FeaturesNeedSupport(unit.GramFeatureIds, gramProgress)
                || FeaturesNeedSupport(unit.SynFeatureIds, synProgress);

            var vocabMastery = unit.VocabId.HasValue && vocabProgress.TryGetValue(unit.VocabId.Value, out var vp)
                ? vp.MasteryLevel
                : 0;
            var knowsVocabAtAll = !unit.VocabId.HasValue || vocabMastery > 0;
            var vocabMastered = !unit.VocabId.HasValue || vocabMastery >= 70;

            // Rendering logic
            if (unit.Children != null && unit.Children.Any())
            {
                // Expand children so leaf-level words always remain individually inspectable.
                var children = unit.Children
                    .Select(child => RenderUnit(child, translationMap, gramProgress, synProgress, vocabProgress, gramCodeById, synCodeById))
                    .ToList();

                var translatedText = translationMap.TryGetValue(unit.Path!, out var mapping)
                    ? mapping.Text
                    : unit.Translation;

                return new RenderedUnitDto
                {
                    Type = "expanded",
                    Children = children,
                    Path = unit.Path,
                    Original = unit.Root,
                    Text = translatedText,
                    GramFeatureIds = unit.GramFeatureIds,
                    SynFeatureIds = unit.SynFeatureIds
                };
            }

            // Leaf node
            // 1) Unknown vocabulary -> show translated/gloss fallback.
            if (!knowsVocabAtAll)
            {
                var translatedUnknown = translationMap.TryGetValue(unit.Path!, out var unknownMap)
                    ? unknownMap.Text
                    : unit.Translation ?? unit.Content ?? unit.Root;

                return new RenderedUnitDto
                {
                    Type = "translated",
                    Text = translatedUnknown,
                    Original = unit.Root,
                    VocabId = unit.VocabId,
                    Path = unit.Path,
                    GramFeatureIds = unit.GramFeatureIds,
                    SynFeatureIds = unit.SynFeatureIds
                };
            }

            // 2) Knows vocab but not grammar -> show Greek with parsing helps.
            if (grammarNeedsSupport)
            {
                var hints = BuildParsingHints(unit, synProgress, gramCodeById, synCodeById);
                return new RenderedUnitDto
                {
                    Type = "original_with_hints",
                    Text = unit.Root,
                    Hints = hints,
                    VocabId = unit.VocabId,
                    Path = unit.Path,
                    GramFeatureIds = unit.GramFeatureIds,
                    SynFeatureIds = unit.SynFeatureIds
                };
            }

            // 3) Knows vocab+grammar but vocab mastery < 70 -> amber practice state.
            if (!vocabMastered)
            {
                return new RenderedUnitDto
                {
                    Type = "original_practice",
                    Text = unit.Root,
                    VocabId = unit.VocabId,
                    Path = unit.Path,
                    GramFeatureIds = unit.GramFeatureIds,
                    SynFeatureIds = unit.SynFeatureIds
                };
            }

            // 4) Mastered vocab+grammar -> show Greek in mastered state.
            if (grammarMastered && vocabMastered)
            {
                return new RenderedUnitDto
                {
                    Type = "original_mastered",
                    Text = unit.Root,
                    VocabId = unit.VocabId,
                    Path = unit.Path,
                    GramFeatureIds = unit.GramFeatureIds,
                    SynFeatureIds = unit.SynFeatureIds
                };
            }

            // Show translation
            var text = translationMap.TryGetValue(unit.Path!, out var map)
                ? map.Text
                : unit.Translation ?? unit.Content ?? unit.Root;

            return new RenderedUnitDto
            {
                Type = "translated",
                Text = text,
                Original = unit.Root,
                VocabId = unit.VocabId,
                Path = unit.Path,
                GramFeatureIds = unit.GramFeatureIds,
                SynFeatureIds = unit.SynFeatureIds
            };
        }

        private static bool FeaturesMastered(
            List<int>? featureIds,
            Dictionary<int, FeatureProgress> progressMap)
        {
            return featureIds?.All(id =>
                progressMap.TryGetValue(id, out var progress) && progress.MasteryLevel >= 70) ?? true;
        }

        private static bool FeaturesNeedSupport(
            List<int>? featureIds,
            Dictionary<int, FeatureProgress> progressMap)
        {
            return featureIds?.Any(id =>
                !progressMap.TryGetValue(id, out var progress) || progress.MasteryLevel < 70) ?? false;
        }

        private List<string> BuildParsingHints(
            UnitNode unit,
            Dictionary<int, FeatureProgress> synProgress,
            Dictionary<int, string> gramCodeById,
            Dictionary<int, string> synCodeById)
        {
            var grammarCodes = (unit.GramFeatureIds ?? new List<int>())
                .Select(id => gramCodeById.TryGetValue(id, out var code) ? code : string.Empty)
                .Where(code => !string.IsNullOrWhiteSpace(code))
                .Select(code => code.Trim().ToUpperInvariant())
                .Distinct()
                .ToList();

            var hints = BuildGrammarAbbreviations(grammarCodes);

            // If there are no compact grammar hints, fall back to syntax codes needing support.
            if (hints.Count == 0 && unit.SynFeatureIds != null)
            {
                foreach (var id in unit.SynFeatureIds)
                {
                    if (!synProgress.TryGetValue(id, out var progress) || progress.MasteryLevel < 70)
                    {
                        if (synCodeById.TryGetValue(id, out var code) && !string.IsNullOrWhiteSpace(code))
                        {
                            var normalized = code.Trim().ToUpperInvariant();
                            if (!hints.Contains(normalized))
                            {
                                hints.Add(normalized);
                            }
                        }
                    }
                }
            }

            return hints;
        }

        private static List<string> BuildGrammarAbbreviations(List<string> codes)
        {
            var hints = new List<string>();
            if (codes.Count == 0)
            {
                return hints;
            }

            var posCodes = new HashSet<string> { "N", "V", "ADJ", "ART", "PRON", "PREP", "CONJ", "ADV", "PART", "INTERJ" };
            var tenseMap = new Dictionary<string, string>
            {
                ["PRES"] = "Pr",
                ["IMPF"] = "Im",
                ["FUT"] = "F",
                ["AOR"] = "Ao",
                ["PERF"] = "Pf",
                ["PLUP"] = "PlPf",
                ["PLPF"] = "PlPf",
            };
            var voiceMap = new Dictionary<string, string>
            {
                ["ACT"] = "A",
                ["MID"] = "M",
                ["PASS"] = "P",
                ["MP"] = "MP",
            };
            var moodMap = new Dictionary<string, string>
            {
                ["IND"] = "I",
                ["SUBJ"] = "S",
                ["OPT"] = "O",
                ["IMP"] = "M",
                ["INF"] = "N",
                ["PTCP"] = "P",
            };
            var caseMap = new Dictionary<string, string>
            {
                ["NOM"] = "N",
                ["GEN"] = "G",
                ["DAT"] = "D",
                ["ACC"] = "A",
                ["VOC"] = "V",
            };
            var genderMap = new Dictionary<string, string>
            {
                ["M"] = "M",
                ["F"] = "F",
                ["N"] = "N",
                ["NEUT"] = "N",
            };
            var numberSet = new HashSet<string> { "S", "P" };
            var personSet = new HashSet<string> { "1P", "2P", "3P" };

            var pos = codes.FirstOrDefault(code => posCodes.Contains(code));
            if (!string.IsNullOrEmpty(pos))
            {
                hints.Add(pos);
            }

            var tense = codes.FirstOrDefault(code => tenseMap.ContainsKey(code));
            var voice = codes.FirstOrDefault(code => voiceMap.ContainsKey(code));
            var mood = codes.FirstOrDefault(code => moodMap.ContainsKey(code));
            var tvm = $"{(tense != null ? tenseMap[tense] : string.Empty)}{(voice != null ? voiceMap[voice] : string.Empty)}{(mood != null ? moodMap[mood] : string.Empty)}";
            if (!string.IsNullOrEmpty(tvm))
            {
                hints.Add(tvm);
            }

            var person = codes.FirstOrDefault(code => personSet.Contains(code));
            var number = codes.FirstOrDefault(code => numberSet.Contains(code));
            if (!string.IsNullOrEmpty(person) && !string.IsNullOrEmpty(number))
            {
                hints.Add($"{person[0]}{number}");
            }

            var grammaticalCase = codes.FirstOrDefault(code => caseMap.ContainsKey(code));
            var gender = codes.FirstOrDefault(code => genderMap.ContainsKey(code));
            if (!string.IsNullOrEmpty(grammaticalCase) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(number))
            {
                hints.Add($"{caseMap[grammaticalCase]}{genderMap[gender]}{number}");
            }

            if (hints.Count == 0)
            {
                hints.AddRange(codes.Take(3));
            }

            return hints.Distinct().ToList();
        }

        private static void CollectFeatureIds(UnitNode unit, ISet<int> grammarFeatureIds, ISet<int> syntaxFeatureIds)
        {
            if (unit.GramFeatureIds != null)
            {
                foreach (var id in unit.GramFeatureIds.Where(id => id > 0))
                {
                    grammarFeatureIds.Add(id);
                }
            }

            if (unit.SynFeatureIds != null)
            {
                foreach (var id in unit.SynFeatureIds.Where(id => id > 0))
                {
                    syntaxFeatureIds.Add(id);
                }
            }

            if (unit.Children == null)
            {
                return;
            }

            foreach (var child in unit.Children)
            {
                CollectFeatureIds(child, grammarFeatureIds, syntaxFeatureIds);
            }
        }
    }
}
