// GreekParser.Application/Services/ProgressService.cs
using System.Text.Json;
using GreekParser.Application.DTOs.Progress;
using GreekParser.Application.Interfaces;

namespace GreekParser.Application.Services
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
    }
}
