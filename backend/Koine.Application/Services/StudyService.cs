using Koine.Application.DTOs.Study;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;

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
            var sets = await _unitOfWork.VocabularySets.GetByUserIdAsync(userId);
            return sets.Select(s => new VocabularySetDto
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                CreatedAt = s.CreatedAt,
                LastPracticed = s.LastPracticed
            }).ToList();
        }

        public async Task<VocabularySetDto?> GetSetByIdAsync(int setId, int userId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdWithItemsAsync(setId);
            if (set == null || set.UserId != userId) return null;

            return new VocabularySetDto
            {
                Id = set.Id,
                Title = set.Title,
                Description = set.Description,
                CreatedAt = set.CreatedAt,
                LastPracticed = set.LastPracticed,
                Items = set.Items.Select(i => new VocabularySetItemDto
                {
                    Id = i.Id,
                    VocabularyId = i.VocabularyId,
                    Root = i.Vocabulary?.Root ?? "Unknown",
                    Gloss = i.Vocabulary?.Gloss ?? string.Empty,
                    MasteryLevel = i.MasteryLevel,
                    LastSeen = i.LastSeen
                }).ToList()
            };
        }

        public async Task<VocabularySetDto> CreateSetAsync(int userId, CreateVocabularySetDto createDto)
        {
            var set = new VocabularySet
            {
                UserId = userId,
                Title = createDto.Title,
                Description = createDto.Description,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.VocabularySets.AddAsync(set);
            await _unitOfWork.SaveChangesAsync(); // Save to get set.Id

            foreach (var vocabId in createDto.VocabularyIds)
            {
                var item = new VocabularySetItem
                {
                    VocabularySetId = set.Id,
                    VocabularyId = vocabId,
                    MasteryLevel = 0,
                    AddedAt = DateTime.UtcNow
                };
                await _unitOfWork.VocabularySetItems.AddAsync(item);
            }

            await _unitOfWork.SaveChangesAsync();

            return await GetSetByIdAsync(set.Id, userId) ?? new VocabularySetDto();
        }

        public async Task<bool> DeleteSetAsync(int setId, int userId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (set == null || set.UserId != userId) return false;

            await _unitOfWork.VocabularySets.DeleteAsync(set);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateItemMasteryAsync(int itemId, int userId, int masteryLevel)
        {
            var item = await _unitOfWork.VocabularySetItems.GetByIdAsync(itemId);
            if (item == null) return false;

            var set = await _unitOfWork.VocabularySets.GetByIdAsync(item.VocabularySetId);
            if (set == null || set.UserId != userId) return false;

            item.MasteryLevel = masteryLevel;
            item.LastSeen = DateTime.UtcNow;
            
            await _unitOfWork.VocabularySetItems.UpdateAsync(item);
            
            set.LastPracticed = DateTime.UtcNow;
            await _unitOfWork.VocabularySets.UpdateAsync(set);
            
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddVocabularyToSetAsync(int setId, int userId, int vocabularyId)
        {
            var set = await _unitOfWork.VocabularySets.GetByIdAsync(setId);
            if (set == null || set.UserId != userId) return false;

            var existing = await _unitOfWork.VocabularySetItems.GetBySetAndVocabAsync(setId, vocabularyId);
            if (existing != null) return true;

            var item = new VocabularySetItem
            {
                VocabularySetId = setId,
                VocabularyId = vocabularyId,
                MasteryLevel = 0,
                AddedAt = DateTime.UtcNow
            };

            await _unitOfWork.VocabularySetItems.AddAsync(item);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
