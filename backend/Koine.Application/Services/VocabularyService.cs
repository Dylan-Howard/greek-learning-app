// Koine.Application/Services/VocabularyService.cs (Enhanced)
using Microsoft.EntityFrameworkCore;
using Koine.Application.DTOs.Common;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;

namespace Koine.Application.Services
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

        public async Task<List<SimpleWordDto>> GetAllSimpleAsync()
        {
            var allVocabulary = await _unitOfWork.Vocabulary.GetAllAsync();
            return allVocabulary.Select(v => new SimpleWordDto
            {
                RootId = v.Id,
                Content = v.Root,
                Occurances = v.FrequencyRank ?? 0,
                Gloss = v.Gloss,
                RootGUID = Guid.NewGuid() // Temporary placeholder
            }).ToList();
        }

        public async Task<SimpleWordDto?> GetSimpleByIdAsync(int id)
        {
            var v = await _unitOfWork.Vocabulary.GetByIdAsync(id);
            if (v == null) return null;

            return new SimpleWordDto
            {
                RootId = v.Id,
                Content = v.Root,
                Occurances = v.FrequencyRank ?? 0,
                Gloss = v.Gloss,
                RootGUID = Guid.NewGuid() // Temporary placeholder
            };
        }

        public async Task<List<SimpleWordDto>> GetWordsByBookIdAsync(int bookId)
        {
            // Simplified implementation: returning all words for now
            // To properly implement this, we'd need to parse all UnitTrees in the book
            return await GetAllSimpleAsync();
        }

        public async Task<List<SimpleWordDto>> GetWordsByChapterIdAsync(int chapterId)
        {
            // Simplified implementation: returning all words for now
            return await GetAllSimpleAsync();
        }

        public async Task<bool> UpdateSimpleWordAsync(SimpleWordDto wordDto)
        {
            var vocab = await _unitOfWork.Vocabulary.GetByIdAsync(wordDto.RootId);
            if (vocab == null) return false;

            vocab.Root = wordDto.Content;
            vocab.Gloss = wordDto.Gloss ?? string.Empty;
            vocab.FrequencyRank = wordDto.Occurances;

            await _unitOfWork.Vocabulary.UpdateAsync(vocab);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
