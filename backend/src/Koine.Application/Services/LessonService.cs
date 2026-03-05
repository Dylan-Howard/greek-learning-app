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

        public async Task<List<LessonTrackDto>> GetLessonTracksAsync(int userId, bool includeLessons = false)
        {
            var tracks = await _unitOfWork.LessonTracks.GetAllOrderedAsync();
            var lessons = await _unitOfWork.Lessons.GetAllOrderedAsync();
            var completions = await _unitOfWork.LessonCompletions.GetByUserIdAsync(userId);
            var completedLessonIds = completions.Select(c => c.LessonId).ToHashSet();

            return tracks.Select(track =>
            {
                var trackLessons = lessons.Where(l => l.TrackId == track.Id).OrderBy(l => l.LessonIndex).ToList();
                var completed = trackLessons.Count(l => completedLessonIds.Contains(l.Id));
                var next = trackLessons.FirstOrDefault(l => !completedLessonIds.Contains(l.Id));

                return new LessonTrackDto
                {
                    Id = track.Id,
                    Slug = track.Slug,
                    Title = track.Title,
                    Description = track.Description,
                    SortOrder = track.SortOrder,
                    TotalLessons = trackLessons.Count,
                    CompletedLessons = completed,
                    PercentComplete = trackLessons.Count == 0
                        ? 0
                        : Math.Round((decimal)completed * 100m / trackLessons.Count, 2),
                    NextLessonId = next?.Id,
                    NextLessonSlug = next?.Slug,
                    NextLessonTitle = next?.Title,
                    Lessons = includeLessons
                        ? trackLessons.Select(l => MapLesson(l, completedLessonIds.Contains(l.Id), track.Slug)).ToList()
                        : new List<LessonDto>()
                };
            }).ToList();
        }

        public async Task<LessonTrackDto?> GetLessonTrackAsync(string trackSlug, int userId)
        {
            var normalizedSlug = trackSlug.Trim().ToLowerInvariant();
            var track = await _unitOfWork.LessonTracks.GetBySlugAsync(normalizedSlug);
            if (track == null)
            {
                return null;
            }

            var lessons = await _unitOfWork.Lessons.GetByTrackIdAsync(track.Id);
            var completions = await _unitOfWork.LessonCompletions.GetByUserIdAsync(userId);
            var completedLessonIds = completions.Select(c => c.LessonId).ToHashSet();

            var completed = lessons.Count(l => completedLessonIds.Contains(l.Id));
            var next = lessons.OrderBy(l => l.LessonIndex).FirstOrDefault(l => !completedLessonIds.Contains(l.Id));

            return new LessonTrackDto
            {
                Id = track.Id,
                Slug = track.Slug,
                Title = track.Title,
                Description = track.Description,
                SortOrder = track.SortOrder,
                TotalLessons = lessons.Count,
                CompletedLessons = completed,
                PercentComplete = lessons.Count == 0 ? 0 : Math.Round((decimal)completed * 100m / lessons.Count, 2),
                NextLessonId = next?.Id,
                NextLessonSlug = next?.Slug,
                NextLessonTitle = next?.Title,
                Lessons = lessons
                    .OrderBy(l => l.LessonIndex)
                    .Select(l => MapLesson(l, completedLessonIds.Contains(l.Id), track.Slug))
                    .ToList()
            };
        }

        public async Task<LessonDto?> GetNextLessonAsync(int userId, string trackSlug)
        {
            var normalizedSlug = trackSlug.Trim().ToLowerInvariant();
            var track = await _unitOfWork.LessonTracks.GetBySlugAsync(normalizedSlug);
            if (track == null)
            {
                return null;
            }

            var lessons = await _unitOfWork.Lessons.GetByTrackIdAsync(track.Id);
            var completions = await _unitOfWork.LessonCompletions.GetByUserIdAsync(userId);
            var completedLessonIds = completions.Select(c => c.LessonId).ToHashSet();
            var next = lessons
                .OrderBy(l => l.LessonIndex)
                .FirstOrDefault(l => !completedLessonIds.Contains(l.Id));

            if (next == null)
            {
                return null;
            }

            return MapLesson(next, false, track.Slug);
        }

        public async Task<List<LessonDto>> GetAllLessonsAsync(int userId)
        {
            var lessons = await _unitOfWork.Lessons.GetAllOrderedAsync();
            var completions = await _unitOfWork.LessonCompletions.GetByUserIdAsync(userId);
            var completedLessonIds = completions.Select(c => c.LessonId).ToHashSet();

            return lessons.Select(l =>
                MapLesson(
                    l,
                    completedLessonIds.Contains(l.Id),
                    l.Track?.Slug ?? string.Empty)).ToList();
        }

        public async Task<List<LessonDto>> GetLessonsByTrackAsync(int userId, string trackSlug)
        {
            var track = await _unitOfWork.LessonTracks.GetBySlugAsync(trackSlug.Trim().ToLowerInvariant());
            if (track == null)
            {
                return new List<LessonDto>();
            }

            var lessons = await _unitOfWork.Lessons.GetByTrackIdAsync(track.Id);
            var completions = await _unitOfWork.LessonCompletions.GetByUserIdAsync(userId);
            var completedLessonIds = completions.Select(c => c.LessonId).ToHashSet();

            return lessons
                .OrderBy(l => l.LessonIndex)
                .Select(l => MapLesson(l, completedLessonIds.Contains(l.Id), track.Slug))
                .ToList();
        }

        public async Task<LessonDto?> GetLessonByIdAsync(int lessonId, int userId)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(lessonId);
            if (lesson == null)
            {
                return null;
            }

            var completion = await _unitOfWork.LessonCompletions.GetByUserAndLessonAsync(userId, lessonId);
            var trackSlug = string.Empty;
            if (lesson.TrackId > 0)
            {
                var track = await _unitOfWork.LessonTracks.GetByIdAsync(lesson.TrackId);
                trackSlug = track?.Slug ?? string.Empty;
            }

            return MapLesson(lesson, completion != null, trackSlug);
        }

        public async Task<LessonCompletionResponseDto?> CompleteLessonAsync(int userId, CompleteLessonDto completionDto)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(completionDto.LessonId);
            if (lesson == null) return null;

            var existingCompletion = await _unitOfWork.LessonCompletions.GetByUserAndLessonAsync(userId, completionDto.LessonId);
            var firstCompletion = existingCompletion == null;
            if (existingCompletion != null)
            {
                existingCompletion.Score = completionDto.Score;
                existingCompletion.CompletedAt = DateTime.UtcNow;
                await _unitOfWork.LessonCompletions.UpdateAsync(existingCompletion);
            }
            else
            {
                var completion = new LessonCompletion
                {
                    UserId = userId,
                    LessonId = completionDto.LessonId,
                    Score = completionDto.Score,
                    CompletedAt = DateTime.UtcNow
                };
                await _unitOfWork.LessonCompletions.AddAsync(completion);
            }

            var userProgress = await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(userId);
            var user = await _unitOfWork.Users.GetByIdAsync(userId);
            if (user == null)
            {
                return null;
            }

            var completedLessonIds = JsonSerializer.Deserialize<List<int>>(userProgress.CompletedLessonIdsJson) ?? new();
            if (!completedLessonIds.Contains(completionDto.LessonId))
            {
                completedLessonIds.Add(completionDto.LessonId);
                userProgress.CompletedLessonIdsJson = JsonSerializer.Serialize(completedLessonIds);
            }

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

            const int lessonCompletionXp = 100;
            var xpGained = firstCompletion ? lessonCompletionXp : 0;
            if (xpGained > 0)
            {
                user.TotalExperience += xpGained;
                await _unitOfWork.Users.UpdateAsync(user);
            }

            await _unitOfWork.SaveChangesAsync();

            return new LessonCompletionResponseDto
            {
                Message = "Lesson completed successfully",
                XpGained = xpGained,
                TotalExperience = user.TotalExperience,
                FirstCompletion = firstCompletion
            };
        }

        public async Task<LessonDto> CreateLessonAsync(CreateLessonDto createDto)
        {
            var lesson = new Lesson
            {
                TrackId = createDto.TrackId,
                Slug = NormalizeSlug(createDto.Slug, createDto.Title),
                Title = createDto.Title,
                LessonIndex = createDto.LessonIndex,
                ContentMarkdown = createDto.ContentMarkdown,
                ContentPath = createDto.ContentPath,
                LessonType = createDto.LessonType,
                GrammaticalFeatureIdsJson = JsonSerializer.Serialize(createDto.GrammaticalFeatureIds),
                SyntacticalFeatureIdsJson = JsonSerializer.Serialize(createDto.SyntacticalFeatureIds),
                VocabularyIdsJson = JsonSerializer.Serialize(createDto.VocabularyIds),
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Lessons.AddAsync(lesson);
            await _unitOfWork.SaveChangesAsync();

            if (lesson.TrackId <= 0)
            {
                return MapLesson(lesson, false, string.Empty);
            }

            var track = await _unitOfWork.LessonTracks.GetByIdAsync(lesson.TrackId);
            return MapLesson(lesson, false, track?.Slug ?? string.Empty);
        }

        public async Task<LessonDto?> UpdateLessonAsync(int lessonId, UpdateLessonDto updateDto)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(lessonId);
            if (lesson == null) return null;

            lesson.TrackId = updateDto.TrackId;
            lesson.Slug = NormalizeSlug(updateDto.Slug, updateDto.Title);
            lesson.Title = updateDto.Title;
            lesson.LessonIndex = updateDto.LessonIndex;
            lesson.ContentMarkdown = updateDto.ContentMarkdown;
            lesson.ContentPath = updateDto.ContentPath;
            lesson.LessonType = updateDto.LessonType;
            lesson.GrammaticalFeatureIdsJson = JsonSerializer.Serialize(updateDto.GrammaticalFeatureIds);
            lesson.SyntacticalFeatureIdsJson = JsonSerializer.Serialize(updateDto.SyntacticalFeatureIds);
            lesson.VocabularyIdsJson = JsonSerializer.Serialize(updateDto.VocabularyIds);

            await _unitOfWork.Lessons.UpdateAsync(lesson);
            await _unitOfWork.SaveChangesAsync();

            if (lesson.TrackId <= 0)
            {
                return MapLesson(lesson, false, string.Empty);
            }

            var track = await _unitOfWork.LessonTracks.GetByIdAsync(lesson.TrackId);
            return MapLesson(lesson, false, track?.Slug ?? string.Empty);
        }

        public async Task<bool> DeleteLessonAsync(int lessonId)
        {
            var lesson = await _unitOfWork.Lessons.GetByIdAsync(lessonId);
            if (lesson == null) return false;

            await _unitOfWork.Lessons.DeleteAsync(lesson);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        private static LessonDto MapLesson(Lesson lesson, bool isCompleted, string trackSlug)
        {
            return new LessonDto
            {
                Id = lesson.Id,
                TrackId = lesson.TrackId,
                TrackSlug = trackSlug,
                Slug = lesson.Slug,
                Title = lesson.Title,
                LessonIndex = lesson.LessonIndex,
                ContentMarkdown = lesson.ContentMarkdown,
                ContentPath = lesson.ContentPath,
                LessonType = lesson.LessonType,
                GrammaticalFeatureIds = JsonSerializer.Deserialize<List<int>>(lesson.GrammaticalFeatureIdsJson) ?? new(),
                SyntacticalFeatureIds = JsonSerializer.Deserialize<List<int>>(lesson.SyntacticalFeatureIdsJson) ?? new(),
                VocabularyIds = JsonSerializer.Deserialize<List<int>>(lesson.VocabularyIdsJson) ?? new(),
                IsCompleted = isCompleted
            };
        }

        private static string NormalizeSlug(string candidate, string fallbackTitle)
        {
            var raw = string.IsNullOrWhiteSpace(candidate) ? fallbackTitle : candidate;
            var normalized = new string(raw
                .Trim()
                .ToLowerInvariant()
                .Select(ch => char.IsLetterOrDigit(ch) ? ch : '-')
                .ToArray());

            while (normalized.Contains("--"))
            {
                normalized = normalized.Replace("--", "-");
            }

            normalized = normalized.Trim('-');
            return string.IsNullOrWhiteSpace(normalized) ? "lesson" : normalized;
        }
    }
}
