// Koine.Application/Services/ProgressService.cs
using System.Text.Json;
using Koine.Application.DTOs.Progress;
using Koine.Application.DTOs.Users;
using Koine.Application.Interfaces;

namespace Koine.Application.Services
{
    public class ProgressService : IProgressService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProgressService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UserProgressDto?> GetUserProgressAsync(int userId)
        {
            var progress = await _unitOfWork.UserProgress.GetByUserIdAsync(userId);
            if (progress == null) return null;
            var user = await _unitOfWork.Users.GetByIdAsync(userId);

            var gramProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.FeatureProgress>>(
                progress.GrammaticalFeatureProgressJson) ?? new();
            
            var synProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.FeatureProgress>>(
                progress.SyntacticalFeatureProgressJson) ?? new();
            
            var vocabProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.VocabularyProgress>>(
                progress.VocabularyProgressJson) ?? new();

            return new UserProgressDto
            {
                CompletedLessonIds = JsonSerializer.Deserialize<List<int>>(progress.CompletedLessonIdsJson) ?? new(),
                GrammaticalFeatureProgress = gramProgress.ToDictionary(
                    kvp => kvp.Key,
                    kvp => new FeatureProgressDto
                    {
                        MasteryLevel = kvp.Value.MasteryLevel,
                        NeedsPractice = kvp.Value.NeedsPractice,
                        LastPracticed = kvp.Value.LastPracticed
                    }),
                SyntacticalFeatureProgress = synProgress.ToDictionary(
                    kvp => kvp.Key,
                    kvp => new FeatureProgressDto
                    {
                        MasteryLevel = kvp.Value.MasteryLevel,
                        NeedsPractice = kvp.Value.NeedsPractice,
                        LastPracticed = kvp.Value.LastPracticed
                    }),
                VocabularyProgress = vocabProgress.ToDictionary(
                    kvp => kvp.Key,
                    kvp => new VocabularyProgressDto
                    {
                        MasteryLevel = kvp.Value.MasteryLevel,
                        NeedsPractice = kvp.Value.NeedsPractice,
                        LastPracticed = kvp.Value.LastPracticed,
                        TimesSeen = kvp.Value.TimesSeen
                    }),
                TotalExperience = user?.TotalExperience ?? 0,
                UpdatedAt = progress.UpdatedAt
            };
        }

        public async Task<bool> UpdateProgressAsync(int userId, UserProgressDto progressDto)
        {
            var progress = await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(userId);

            progress.CompletedLessonIdsJson = JsonSerializer.Serialize(progressDto.CompletedLessonIds);
            
            var gramProgress = progressDto.GrammaticalFeatureProgress.ToDictionary(
                kvp => kvp.Key,
                kvp => new Domain.ValueObjects.FeatureProgress
                {
                    MasteryLevel = kvp.Value.MasteryLevel,
                    NeedsPractice = kvp.Value.NeedsPractice,
                    LastPracticed = kvp.Value.LastPracticed
                });
            
            var synProgress = progressDto.SyntacticalFeatureProgress.ToDictionary(
                kvp => kvp.Key,
                kvp => new Domain.ValueObjects.FeatureProgress
                {
                    MasteryLevel = kvp.Value.MasteryLevel,
                    NeedsPractice = kvp.Value.NeedsPractice,
                    LastPracticed = kvp.Value.LastPracticed
                });
            
            var vocabProgress = progressDto.VocabularyProgress.ToDictionary(
                kvp => kvp.Key,
                kvp => new Domain.ValueObjects.VocabularyProgress
                {
                    MasteryLevel = kvp.Value.MasteryLevel,
                    NeedsPractice = kvp.Value.NeedsPractice,
                    LastPracticed = kvp.Value.LastPracticed,
                    TimesSeen = kvp.Value.TimesSeen
                });

            progress.GrammaticalFeatureProgressJson = JsonSerializer.Serialize(gramProgress);
            progress.SyntacticalFeatureProgressJson = JsonSerializer.Serialize(synProgress);
            progress.VocabularyProgressJson = JsonSerializer.Serialize(vocabProgress);
            progress.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.UserProgress.UpdateAsync(progress);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<List<UserLessonDto>> GetUserLessonsAsync(int userId)
        {
            var progress = await _unitOfWork.UserProgress.GetByUserIdAsync(userId);
            if (progress == null) return new List<UserLessonDto>();

            var completedIds = JsonSerializer.Deserialize<List<int>>(progress.CompletedLessonIdsJson) ?? new();
            var allLessons = await _unitOfWork.Lessons.GetAllAsync();

            return allLessons.Select(l => new UserLessonDto
            {
                LessonId = l.Id,
                Name = l.Title,
                IsComplete = completedIds.Contains(l.Id)
            }).ToList();
        }

        public async Task<List<UserWordDto>> GetUserVocabularyAsync(int userId)
        {
            var progress = await _unitOfWork.UserProgress.GetByUserIdAsync(userId);
            if (progress == null) return new List<UserWordDto>();

            var vocabProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.VocabularyProgress>>(
                progress.VocabularyProgressJson) ?? new();

            var vocabIds = vocabProgress.Keys.ToList();
            var vocabItems = await _unitOfWork.Vocabulary.GetByIdsAsync(vocabIds);
            var vocabMap = vocabItems.ToDictionary(v => v.Id, v => v);

            return vocabProgress.Select(kvp => new UserWordDto
            {
                WordId = kvp.Key,
                GreekWord = vocabMap.ContainsKey(kvp.Key) ? vocabMap[kvp.Key].Root : "Unknown",
                EnglishMeaning = vocabMap.ContainsKey(kvp.Key) ? vocabMap[kvp.Key].Gloss : string.Empty,
                KnowledgeLevel = kvp.Value.MasteryLevel
            }).ToList();
        }

        public async Task<bool> SeedOnboardingAsync(int userId, int? minOccurrenceThreshold)
        {
            // Beginner rank: no pre-seeding required.
            if (minOccurrenceThreshold is null)
                return true;

            // Fetch words that meet the occurrence threshold (no upper bound).
            var wordsToSeed = await _unitOfWork.Vocabulary.GetByOccurrencesAsync(minOccurrenceThreshold.Value, int.MaxValue);
            if (wordsToSeed.Count == 0)
                return true;

            var progress = await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(userId);

            var vocabProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.VocabularyProgress>>(
                progress.VocabularyProgressJson) ?? new();

            // Mark each qualifying word as mastered (level 5), preserving any existing higher state.
            const int masteredLevel = 5;
            foreach (var word in wordsToSeed)
            {
                if (!vocabProgress.TryGetValue(word.Id, out var existing) || existing.MasteryLevel < masteredLevel)
                {
                    vocabProgress[word.Id] = new Domain.ValueObjects.VocabularyProgress
                    {
                        MasteryLevel = masteredLevel,
                        NeedsPractice = false,
                        LastPracticed = DateTime.UtcNow,
                        TimesSeen = existing?.TimesSeen ?? 0,
                    };
                }
            }

            progress.VocabularyProgressJson = JsonSerializer.Serialize(vocabProgress);
            progress.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.UserProgress.UpdateAsync(progress);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
