// Koine.Application/DTOs/Lessons/UpdateLessonDto.cs
namespace Koine.Application.DTOs.Lessons
{
    public class UpdateLessonDto
    {
        public string Title { get; set; } = string.Empty;
        public int LessonIndex { get; set; }
        public string ContentMarkdown { get; set; } = string.Empty;
        public string LessonType { get; set; } = string.Empty;
        public List<int> GrammaticalFeatureIds { get; set; } = new();
        public List<int> SyntacticalFeatureIds { get; set; } = new();
        public List<int> VocabularyIds { get; set; } = new();
    }
}
