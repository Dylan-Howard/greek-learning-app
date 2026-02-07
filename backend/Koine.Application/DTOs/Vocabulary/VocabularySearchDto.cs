// GreekParser.Application/DTOs/Vocabulary/VocabularySearchDto.cs
namespace GreekParser.Application.DTOs.Vocabulary
{
    public class VocabularySearchDto
    {
        public string? SearchTerm { get; set; }
        public string? PartOfSpeech { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 50;
    }
}
