// Koine.Application/Services/LessonService.cs (Enhanced)
using System.Text.Json;
using Koine.Application.DTOs.Lessons;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;

namespace Koine.Application.Services
{
    public class LessonService : ILessonService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LessonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<LessonDto>> GetAllLessonsAsync(int userId)
        {
            var lessons = await _unitOfWork.Lessons.GetAllOrderedAsync();
            var completions = await _unitOfWork.LessonCompletions.GetByUserIdAsync(userId);
            var completedLessonIds = completions.Select(c => c.LessonId).ToHashSet();

            return lessons.Select(l => new LessonDto
            {
                Id = l.Id,
                Title = l.Title,
                LessonIndex = l.LessonIndex,
                ContentMarkdown = l.ContentMarkdown,
                LessonType = l.LessonType,
                GrammaticalFeatureIds = JsonSerializer.Deserialize<List<int>>(l.GrammaticalFeatureIdsJson) ?? new(),
                SyntacticalFeatureIds = JsonSerializer.Deserialize<List<int>>(l.SyntacticalFeatureIdsJson) ?? new(),
                VocabularyIds = JsonSerializer.Deserialize<List<int>>(l.VocabularyIdsJson) ?? new(),
                IsCompleted = completedLessonIds.Contains(l.Id)
            }).ToList();
        }

        public async Task<LessonDto?> GetLessonByIdAsync(int lessonId, int userId)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(lessonId);
            if (lesson == null) return null;

            var completion = await _unitOfWork.LessonCompletions.GetByUserAndLessonAsync(userId, lessonId);

            return new LessonDto
            {
                Id = lesson.Id,
                Title = lesson.Title,
                LessonIndex = lesson.LessonIndex,
                ContentMarkdown = lesson.ContentMarkdown,
                LessonType = lesson.LessonType,
                GrammaticalFeatureIds = JsonSerializer.Deserialize<List<int>>(lesson.GrammaticalFeatureIdsJson) ?? new(),
                SyntacticalFeatureIds = JsonSerializer.Deserialize<List<int>>(lesson.SyntacticalFeatureIdsJson) ?? new(),
                VocabularyIds = JsonSerializer.Deserialize<List<int>>(lesson.VocabularyIdsJson) ?? new(),
                IsCompleted = completion != null
            };
        }

        public async Task<bool> CompleteLessonAsync(int userId, CompleteLessonDto completionDto)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(completionDto.LessonId);
            if (lesson == null) return false;

            // Check if already completed
            var existingCompletion = await _unitOfWork.LessonCompletions.GetByUserAndLessonAsync(userId, completionDto.LessonId);
            if (existingCompletion != null)
            {
                // Update existing completion
                existingCompletion.Score = completionDto.Score;
                existingCompletion.CompletedAt = DateTime.UtcNow;
                await _unitOfWork.LessonCompletions.UpdateAsync(existingCompletion);
            }
            else
            {
                // Create new completion
                var completion = new LessonCompletion
                {
                    UserId = userId,
                    LessonId = completionDto.LessonId,
                    Score = completionDto.Score,
                    CompletedAt = DateTime.UtcNow
                };
                await _unitOfWork.LessonCompletions.AddAsync(completion);
            }

            // Update user progress
            var userProgress = await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(userId);
            
            var completedLessonIds = JsonSerializer.Deserialize<List<int>>(userProgress.CompletedLessonIdsJson) ?? new();
            if (!completedLessonIds.Contains(completionDto.LessonId))
            {
                completedLessonIds.Add(completionDto.LessonId);
                userProgress.CompletedLessonIdsJson = JsonSerializer.Serialize(completedLessonIds);
            }

            // Update feature progress based on lesson
            var gramFeatureIds = JsonSerializer.Deserialize<List<int>>(lesson.GrammaticalFeatureIdsJson) ?? new();
            var synFeatureIds = JsonSerializer.Deserialize<List<int>>(lesson.SyntacticalFeatureIdsJson) ?? new();
            var vocabIds = JsonSerializer.Deserialize<List<int>>(lesson.VocabularyIdsJson) ?? new();

            var gramProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.FeatureProgress>>(userProgress.GrammaticalFeatureProgressJson) ?? new();
            var synProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.FeatureProgress>>(userProgress.SyntacticalFeatureProgressJson) ?? new();
            var vocabProgress = JsonSerializer.Deserialize<Dictionary<int, Domain.ValueObjects.VocabularyProgress>>(userProgress.VocabularyProgressJson) ?? new();

            foreach (var featureId in gramFeatureIds)
            {
                if (!gramProgress.ContainsKey(featureId))
                {
                    gramProgress[featureId] = new Domain.ValueObjects.FeatureProgress();
                }
                gramProgress[featureId].MasteryLevel = Math.Min(100, gramProgress[featureId].MasteryLevel + 20);
                gramProgress[featureId].LastPracticed = DateTime.UtcNow;
                gramProgress[featureId].NeedsPractice = gramProgress[featureId].MasteryLevel < 70;
            }

            foreach (var featureId in synFeatureIds)
            {
                if (!synProgress.ContainsKey(featureId))
                {
                    synProgress[featureId] = new Domain.ValueObjects.FeatureProgress();
                }
                synProgress[featureId].MasteryLevel = Math.Min(100, synProgress[featureId].MasteryLevel + 20);
                synProgress[featureId].LastPracticed = DateTime.UtcNow;
                synProgress[featureId].NeedsPractice = synProgress[featureId].MasteryLevel < 70;
            }

            foreach (var vocabId in vocabIds)
            {
                if (!vocabProgress.ContainsKey(vocabId))
                {
                    vocabProgress[vocabId] = new Domain.ValueObjects.VocabularyProgress();
                }
                vocabProgress[vocabId].MasteryLevel = Math.Min(100, vocabProgress[vocabId].MasteryLevel + 20);
                vocabProgress[vocabId].LastPracticed = DateTime.UtcNow;
                vocabProgress[vocabId].TimesSeen++;
                vocabProgress[vocabId].NeedsPractice = vocabProgress[vocabId].MasteryLevel < 70;
            }

            userProgress.GrammaticalFeatureProgressJson = JsonSerializer.Serialize(gramProgress);
            userProgress.SyntacticalFeatureProgressJson = JsonSerializer.Serialize(synProgress);
            userProgress.VocabularyProgressJson = JsonSerializer.Serialize(vocabProgress);
            userProgress.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.UserProgress.UpdateAsync(userProgress);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<LessonDto> CreateLessonAsync(CreateLessonDto createDto)
        {
            var lesson = new Lesson
            {
                Title = createDto.Title,
                LessonIndex = createDto.LessonIndex,
                ContentMarkdown = createDto.ContentMarkdown,
                LessonType = createDto.LessonType,
                GrammaticalFeatureIdsJson = JsonSerializer.Serialize(createDto.GrammaticalFeatureIds),
                SyntacticalFeatureIdsJson = JsonSerializer.Serialize(createDto.SyntacticalFeatureIds),
                VocabularyIdsJson = JsonSerializer.Serialize(createDto.VocabularyIds),
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Lessons.AddAsync(lesson);
            await _unitOfWork.SaveChangesAsync();

            return new LessonDto
            {
                Id = lesson.Id,
                Title = lesson.Title,
                LessonIndex = lesson.LessonIndex,
                ContentMarkdown = lesson.ContentMarkdown,
                LessonType = lesson.LessonType,
                GrammaticalFeatureIds = createDto.GrammaticalFeatureIds,
                SyntacticalFeatureIds = createDto.SyntacticalFeatureIds,
                VocabularyIds = createDto.VocabularyIds,
                IsCompleted = false
            };
        }

        public async Task<LessonDto?> UpdateLessonAsync(int lessonId, UpdateLessonDto updateDto)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(lessonId);
            if (lesson == null) return null;

            lesson.Title = updateDto.Title;
            lesson.LessonIndex = updateDto.LessonIndex;
            lesson.ContentMarkdown = updateDto.ContentMarkdown;
            lesson.LessonType = updateDto.LessonType;
            lesson.GrammaticalFeatureIdsJson = JsonSerializer.Serialize(updateDto.GrammaticalFeatureIds);
            lesson.SyntacticalFeatureIdsJson = JsonSerializer.Serialize(updateDto.SyntacticalFeatureIds);
            lesson.VocabularyIdsJson = JsonSerializer.Serialize(updateDto.VocabularyIds);

            await _unitOfWork.Lessons.UpdateAsync(lesson);
            await _unitOfWork.SaveChangesAsync();

            return new LessonDto
            {
                Id = lesson.Id,
                Title = lesson.Title,
                LessonIndex = lesson.LessonIndex,
                ContentMarkdown = lesson.ContentMarkdown,
                LessonType = lesson.LessonType,
                GrammaticalFeatureIds = updateDto.GrammaticalFeatureIds,
                SyntacticalFeatureIds = updateDto.SyntacticalFeatureIds,
                VocabularyIds = updateDto.VocabularyIds,
                IsCompleted = false
            };
        }

        public async Task<bool> DeleteLessonAsync(int lessonId)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(lessonId);
            if (lesson == null) return false;

            await _unitOfWork.Lessons.DeleteAsync(lesson);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
