namespace Koine.Application.DTOs.Study
{
    public class VocabularySetDto
    {
        public int Id { get; set; }
        public int? OwnerUserId { get; set; }
        public bool IsSystem { get; set; }
        public string Slug { get; set; } = string.Empty;
        public int? BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<VocabularySetItemDto> Items { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime? LastPracticed { get; set; }
        public int TotalCount { get; set; }
        public int KnownCount { get; set; }
        public int LearningCount { get; set; }
        public double PercentComplete { get; set; }
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

    public class UpdateVocabularySetDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class AddVocabularySetItemDto
    {
        public int VocabularyId { get; set; }
    }

    public class UpdateVocabularySetProgressDto
    {
        public int MasteryLevel { get; set; }
    }
}
