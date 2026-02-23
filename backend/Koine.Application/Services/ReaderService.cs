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
                .Select(unit => RenderUnit(unit, translationMap, gramProgress, synProgress, vocabProgress))
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
            Dictionary<int, VocabularyProgress> vocabProgress)
        {
            // Handle meta nodes
            if (unit.Type == "meta")
            {
                return new RenderedUnitDto
                {
                    Type = "meta",
                    Text = unit.Content,
                    Marker = unit.Marker
                };
            }

            // Check feature knowledge
            var knowsGrammar = unit.GramFeatureIds?.All(id =>
                gramProgress.TryGetValue(id, out var prog) && prog.MasteryLevel >= 70) ?? true;

            var knowsSyntax = unit.SynFeatureIds?.All(id =>
                synProgress.TryGetValue(id, out var prog) && prog.MasteryLevel >= 70) ?? true;

            var knowsVocab = unit.VocabId.HasValue
                ? (vocabProgress.TryGetValue(unit.VocabId.Value, out var vp) && vp.MasteryLevel >= 70)
                : true;

            var needsPractice =
                (unit.GramFeatureIds?.Any(id => gramProgress.TryGetValue(id, out var p) && p.NeedsPractice) ?? false) ||
                (unit.SynFeatureIds?.Any(id => synProgress.TryGetValue(id, out var p) && p.NeedsPractice) ?? false) ||
                (unit.VocabId.HasValue && vocabProgress.TryGetValue(unit.VocabId.Value, out var vpNeeds) && vpNeeds.NeedsPractice);

            // Rendering logic
            if (!knowsSyntax && unit.Children != null && unit.Children.Any())
            {
                // Show translation for the whole phrase
                var translatedText = translationMap.TryGetValue(unit.Path!, out var mapping)
                    ? mapping.Text
                    : unit.Translation;

                return new RenderedUnitDto
                {
                    Type = "translated",
                    Text = translatedText,
                    Original = unit.Root
                };
            }

            if (knowsSyntax && unit.Children != null && unit.Children.Any())
            {
                // Expand children
                var children = unit.Children
                    .Select(child => RenderUnit(child, translationMap, gramProgress, synProgress, vocabProgress))
                    .ToList();

                return new RenderedUnitDto
                {
                    Type = "expanded",
                    Children = children
                };
            }

            // Leaf node
            if (knowsGrammar && knowsVocab && !needsPractice)
            {
                return new RenderedUnitDto
                {
                    Type = "original",
                    Text = unit.Root,
                    VocabId = unit.VocabId
                };
            }

            if (needsPractice)
            {
                var hints = BuildParsingHints(unit, gramProgress);
                return new RenderedUnitDto
                {
                    Type = "original_with_hints",
                    Text = unit.Root,
                    Hints = hints,
                    VocabId = unit.VocabId
                };
            }

            // Show translation
            var text = translationMap.TryGetValue(unit.Path!, out var map)
                ? map.Text
                : unit.Translation;

            return new RenderedUnitDto
            {
                Type = "translated",
                Text = text,
                Original = unit.Root
            };
        }

        private List<string> BuildParsingHints(UnitNode unit, Dictionary<int, FeatureProgress> gramProgress)
        {
            var hints = new List<string>();

            if (unit.GramFeatureIds != null)
            {
                foreach (var id in unit.GramFeatureIds)
                {
                    if (gramProgress.TryGetValue(id, out var progress) && progress.NeedsPractice)
                    {
                        // In real implementation, fetch the code from database
                        hints.Add($"Feature{id}");
                    }
                }
            }

            return hints;
        }
    }
}