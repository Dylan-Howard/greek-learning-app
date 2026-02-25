// Koine.Application/DTOs/Lessons/LessonDto.cs
namespace Koine.Application.DTOs.Lessons
{
    public class LessonDto
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public string TrackSlug { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int LessonIndex { get; set; }
        public string ContentMarkdown { get; set; } = string.Empty;
        public string? ContentPath { get; set; }
        public string LessonType { get; set; } = string.Empty;
        public List<int> GrammaticalFeatureIds { get; set; } = new();
        public List<int> SyntacticalFeatureIds { get; set; } = new();
        public List<int> VocabularyIds { get; set; } = new();
        public bool IsCompleted { get; set; }
    }
}
