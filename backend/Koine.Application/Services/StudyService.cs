using Koine.Application.DTOs.Study;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;
using System.Text.Json;

namespace Koine.Application.Services
{
    public class StudyService : IStudyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<VocabularySetDto>> GetUserSetsAsync(int userId)
        {
            var progressMap = await LoadVocabularyProgressAsync(userId);
            var sets = await _unitOfWork.VocabularySets.GetVisibleToUserAsync(userId);
            return sets.Select(s => ToDto(s, progressMap, includeItems: false)).ToList();
        }

        public async Task<VocabularySetDto?> GetSetByIdAsync(int setId, int userId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdWithItemsAsync(setId);
            if (!IsVisibleToUser(set, userId)) return null;

            var progressMap = await LoadVocabularyProgressAsync(userId);
            return ToDto(set!, progressMap, includeItems: true);
        }

        public async Task<VocabularySetDto> CreateSetAsync(int userId, CreateVocabularySetDto createDto)
        {
            var set = new VocabularySet
            {
                OwnerUserId = userId,
                IsSystem = false,
                Slug = BuildUserSetSlug(createDto.Title, userId),
                Title = createDto.Title,
                Description = createDto.Description,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.VocabularySets.AddAsync(set);
            await _unitOfWork.SaveChangesAsync();

            var distinctVocabularyIds = createDto.VocabularyIds.Distinct().ToList();
            foreach (var vocabId in distinctVocabularyIds)
            {
                await _unitOfWork.VocabularySetItems.AddAsync(new VocabularySetItem
                {
                    VocabularySetId = set.Id,
                    VocabularyId = vocabId,
                    MasteryLevel = 0,
                    AddedAt = DateTime.UtcNow
                });
            }

            await _unitOfWork.SaveChangesAsync();
            return await GetSetByIdAsync(set.Id, userId) ?? new VocabularySetDto();
        }

        public async Task<VocabularySetDto?> UpdateSetAsync(int setId, int userId, UpdateVocabularySetDto updateDto)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (set == null || set.OwnerUserId != userId || set.IsSystem) return null;

            set.Title = updateDto.Title;
            set.Description = updateDto.Description;
            set.Slug = BuildUserSetSlug(updateDto.Title, userId);

            await _unitOfWork.VocabularySets.UpdateAsync(set);
            await _unitOfWork.SaveChangesAsync();

            return await GetSetByIdAsync(setId, userId);
        }

        public async Task<bool> DeleteSetAsync(int setId, int userId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (set == null || set.OwnerUserId != userId || set.IsSystem) return false;

            await _unitOfWork.VocabularySets.DeleteAsync(set);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateItemMasteryAsync(int itemId, int userId, int masteryLevel)
        {
            var item = await _unitOfWork.VocabularySetItems.GetByIdAsync(itemId);
            if (item == null) return false;

            var set = await _unitOfWork.VocabularySets.GetByIdAsync(item.VocabularySetId);
            if (!IsVisibleToUser(set, userId)) return false;

            return await UpdateVocabularyProgressAsync(set!.Id, userId, item.VocabularyId, masteryLevel);
        }

        public async Task<bool> AddVocabularyToSetAsync(int setId, int userId, int vocabularyId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (set == null || set.OwnerUserId != userId || set.IsSystem) return false;

            var existing = await _unitOfWork.VocabularySetItems.GetBySetAndVocabAsync(setId, vocabularyId);
            if (existing != null) return true;

            await _unitOfWork.VocabularySetItems.AddAsync(new VocabularySetItem
            {
                VocabularySetId = setId,
                VocabularyId = vocabularyId,
                MasteryLevel = 0,
                AddedAt = DateTime.UtcNow
            });

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveVocabularyFromSetAsync(int setId, int userId, int vocabularyId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (set == null || set.OwnerUserId != userId || set.IsSystem) return false;

            var existing = await _unitOfWork.VocabularySetItems.GetBySetAndVocabAsync(setId, vocabularyId);
            if (existing == null) return true;

            await _unitOfWork.VocabularySetItems.DeleteAsync(existing);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateVocabularyProgressAsync(int setId, int userId, int vocabularyId, int masteryLevel)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (!IsVisibleToUser(set, userId)) return false;

            var item = await _unitOfWork.VocabularySetItems.GetBySetAndVocabAsync(setId, vocabularyId);
            if (item == null) return false;

            var boundedMastery = Math.Clamp(masteryLevel, 0, 100);
            var progressEntity = await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(userId);
            var progressMap = DeserializeVocabularyProgress(progressEntity.VocabularyProgressJson);
            var now = DateTime.UtcNow;

            progressMap[vocabularyId] = new VocabularyProgress
            {
                MasteryLevel = boundedMastery,
                NeedsPractice = boundedMastery < 80,
                LastPracticed = now,
                TimesSeen = progressMap.TryGetValue(vocabularyId, out var previous)
                    ? previous.TimesSeen + 1
                    : 1
            };

            progressEntity.VocabularyProgressJson = JsonSerializer.Serialize(progressMap);
            progressEntity.UpdatedAt = now;
            item.LastSeen = DateTime.UtcNow;
            set!.LastPracticed = now;

            await _unitOfWork.UserProgress.UpdateAsync(progressEntity);
            await _unitOfWork.VocabularySetItems.UpdateAsync(item);
            await _unitOfWork.VocabularySets.UpdateAsync(set);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        private static bool IsVisibleToUser(VocabularySet? set, int userId)
        {
            return set != null && (set.IsSystem || set.OwnerUserId == userId);
        }

        private static string BuildUserSetSlug(string title, int userId)
        {
            var normalized = new string(
                title.Trim().ToLowerInvariant().Select(c => char.IsLetterOrDigit(c) ? c : '-').ToArray());
            while (normalized.Contains("--"))
            {
                normalized = normalized.Replace("--", "-");
            }

            normalized = normalized.Trim('-');
            if (string.IsNullOrWhiteSpace(normalized))
            {
                normalized = "set";
            }

            return $"user-{userId}-{normalized}";
        }

        private async Task<Dictionary<int, VocabularyProgress>> LoadVocabularyProgressAsync(int userId)
        {
            var userProgress = await _unitOfWork.UserProgress.GetByUserIdAsync(userId);
            if (userProgress == null) return new Dictionary<int, VocabularyProgress>();
            return DeserializeVocabularyProgress(userProgress.VocabularyProgressJson);
        }

        private static Dictionary<int, VocabularyProgress> DeserializeVocabularyProgress(string? json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return new Dictionary<int, VocabularyProgress>();
            }

            return JsonSerializer.Deserialize<Dictionary<int, VocabularyProgress>>(json)
                   ?? new Dictionary<int, VocabularyProgress>();
        }

        private static VocabularySetDto ToDto(
            VocabularySet set,
            IReadOnlyDictionary<int, VocabularyProgress> progressMap,
            bool includeItems)
        {
            var items = set.Items
                .OrderBy(i => i.Vocabulary?.Root ?? string.Empty)
                .Select(i =>
                {
                    var progress = progressMap.TryGetValue(i.VocabularyId, out var p) ? p : null;
                    return new VocabularySetItemDto
                    {
                        Id = i.Id,
                        VocabularyId = i.VocabularyId,
                        Root = i.Vocabulary?.Root ?? "Unknown",
                        Gloss = i.Vocabulary?.Gloss ?? string.Empty,
                        MasteryLevel = progress?.MasteryLevel ?? i.MasteryLevel,
                        LastSeen = i.LastSeen
                    };
                })
                .ToList();

            var totalCount = set.Items.Count;
            var knownCount = set.Items.Count(i =>
                progressMap.TryGetValue(i.VocabularyId, out var p) && p.MasteryLevel >= 80);
            var learningCount = Math.Max(totalCount - knownCount, 0);
            var percentComplete = totalCount == 0 ? 0 : (double)knownCount / totalCount * 100.0;

            return new VocabularySetDto
            {
                Id = set.Id,
                OwnerUserId = set.OwnerUserId,
                IsSystem = set.IsSystem,
                Slug = set.Slug,
                BookId = set.BookId,
                Title = set.Title,
                Description = set.Description,
                CreatedAt = set.CreatedAt,
                LastPracticed = set.LastPracticed,
                TotalCount = totalCount,
                KnownCount = knownCount,
                LearningCount = learningCount,
                PercentComplete = percentComplete,
                Items = includeItems ? items : new List<VocabularySetItemDto>()
            };
        }
    }
}
