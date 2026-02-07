// GreekParser.Application/Services/VocabularyService.cs (Enhanced)
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.DTOs.Common;
using GreekParser.Application.DTOs.Vocabulary;
using GreekParser.Application.Interfaces;
using GreekParser.Domain.Entities;

namespace GreekParser.Application.Services
{
    public class VocabularyService : IVocabularyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VocabularyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PaginatedResultDto<VocabularyDto>> GetVocabularyAsync(int page = 1, int pageSize = 50)
        {
            var allVocabulary = await _unitOfWork.Vocabulary.GetAllAsync();
            var vocabList = allVocabulary.ToList();

            var totalCount = vocabList.Count;
            var items = vocabList
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(v => new VocabularyDto
                {
                    Id = v.Id,
                    Root = v.Root,
                    Transliteration = v.Transliteration,
                    Gloss = v.Gloss,
                    PartOfSpeech = v.PartOfSpeech,
                    FrequencyRank = v.FrequencyRank
                })
                .ToList();

            return new PaginatedResultDto<VocabularyDto>
            {
                Items = items,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize
            };
        }

        public async Task<PaginatedResultDto<VocabularyDto>> SearchVocabularyAsync(VocabularySearchDto searchDto)
        {
            var allVocabulary = await _unitOfWork.Vocabulary.GetAllAsync();
            var query = allVocabulary.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchDto.SearchTerm))
            {
                query = query.Where(v =>
                    v.Root.Contains(searchDto.SearchTerm) ||
                    (v.Transliteration != null && v.Transliteration.Contains(searchDto.SearchTerm)) ||
                    v.Gloss.Contains(searchDto.SearchTerm));
            }

            if (!string.IsNullOrWhiteSpace(searchDto.PartOfSpeech))
            {
                query = query.Where(v => v.PartOfSpeech == searchDto.PartOfSpeech);
            }

            var totalCount = query.Count();
            var items = query
                .Skip((searchDto.Page - 1) * searchDto.PageSize)
                .Take(searchDto.PageSize)
                .Select(v => new VocabularyDto
                {
                    Id = v.Id,
                    Root = v.Root,
                    Transliteration = v.Transliteration,
                    Gloss = v.Gloss,
                    PartOfSpeech = v.PartOfSpeech,
                    FrequencyRank = v.FrequencyRank
                })
                .ToList();

            return new PaginatedResultDto<VocabularyDto>
            {
                Items = items,
                TotalCount = totalCount,
                Page = searchDto.Page,
                PageSize = searchDto.PageSize
            };
        }

        public async Task<VocabularyDto?> GetVocabularyByIdAsync(int vocabId)
        {
            var vocab = await _unitOfWork.Vocabulary.GetByIdAsync(vocabId);
            if (vocab == null) return null;

            return new VocabularyDto
            {
                Id = vocab.Id,
                Root = vocab.Root,
                Transliteration = vocab.Transliteration,
                Gloss = vocab.Gloss,
                PartOfSpeech = vocab.PartOfSpeech,
                FrequencyRank = vocab.FrequencyRank
            };
        }

        public async Task<List<VocabularyDto>> GetVocabularyForPracticeAsync(int userId, int count = 20)
        {
            // This would be implemented based on user progress
            // For now, return most frequent words
            var allVocabulary = await _unitOfWork.Vocabulary.GetAllAsync();
            
            var vocabList = allVocabulary
                .OrderBy(v => v.FrequencyRank ?? int.MaxValue)
                .Take(count)
                .Select(v => new VocabularyDto
                {
                    Id = v.Id,
                    Root = v.Root,
                    Transliteration = v.Transliteration,
                    Gloss = v.Gloss,
                    PartOfSpeech = v.PartOfSpeech,
                    FrequencyRank = v.FrequencyRank
                })
                .ToList();

            return vocabList;
        }

        public async Task<VocabularyDto> CreateVocabularyAsync(CreateVocabularyDto createDto)
        {
            var vocab = new Vocabulary
            {
                Root = createDto.Root,
                Transliteration = createDto.Transliteration,
                Gloss = createDto.Gloss,
                PartOfSpeech = createDto.PartOfSpeech,
                FrequencyRank = createDto.FrequencyRank,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Vocabulary.AddAsync(vocab);
            await _unitOfWork.SaveChangesAsync();

            return new VocabularyDto
            {
                Id = vocab.Id,
                Root = vocab.Root,
                Transliteration = vocab.Transliteration,
                Gloss = vocab.Gloss,
                PartOfSpeech = vocab.PartOfSpeech,
                FrequencyRank = vocab.FrequencyRank
            };
        }

        public async Task<VocabularyDto?> UpdateVocabularyAsync(int vocabId, UpdateVocabularyDto updateDto)
        {
            var vocab = await _unitOfWork.Vocabulary.GetByIdAsync(vocabId);
            if (vocab == null) return null;

            vocab.Root = updateDto.Root;
            vocab.Transliteration = updateDto.Transliteration;
            vocab.Gloss = updateDto.Gloss;
            vocab.PartOfSpeech = updateDto.PartOfSpeech;
            vocab.FrequencyRank = updateDto.FrequencyRank;

            await _unitOfWork.Vocabulary.UpdateAsync(vocab);
            await _unitOfWork.SaveChangesAsync();

            return new VocabularyDto
            {
                Id = vocab.Id,
                Root = vocab.Root,
                Transliteration = vocab.Transliteration,
                Gloss = vocab.Gloss,
                PartOfSpeech = vocab.PartOfSpeech,
                FrequencyRank = vocab.FrequencyRank
            };
        }

        public async Task<bool> DeleteVocabularyAsync(int vocabId)
        {
            var vocab = await _unitOfWork.Vocabulary.GetByIdAsync(vocabId);
            if (vocab == null) return false;

            await _unitOfWork.Vocabulary.DeleteAsync(vocab);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
