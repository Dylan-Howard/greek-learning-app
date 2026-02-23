namespace Koine.Application.DTOs.Study
{
    public class VocabularySetDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<VocabularySetItemDto> Items { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime? LastPracticed { get; set; }
    }

    public class VocabularySetItemDto
    {
        public int Id { get; set; }
        public int VocabularyId { get; set; }
        public string Root { get; set; } = string.Empty;
        public string Gloss { get; set; } = string.Empty;
        public int MasteryLevel { get; set; }
        public DateTime? LastSeen { get; set; }
    }

    public class CreateVocabularySetDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<int> VocabularyIds { get; set; } = new();
    }
}
