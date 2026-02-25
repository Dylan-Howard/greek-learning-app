// Koine.Application/DTOs/Lessons/CreateLessonDto.cs
namespace Koine.Application.DTOs.Lessons
{
    public class CreateLessonDto
    {
        public int TrackId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int LessonIndex { get; set; }
        public string ContentMarkdown { get; set; } = string.Empty;
        public string? ContentPath { get; set; }
        public string LessonType { get; set; } = string.Empty;
        public List<int> GrammaticalFeatureIds { get; set; } = new();
        public List<int> SyntacticalFeatureIds { get; set; } = new();
        public List<int> VocabularyIds { get; set; } = new();
    }
}
