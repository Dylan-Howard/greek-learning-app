// GreekParser.Application/DTOs/Lessons/CreateLessonDto.cs
namespace GreekParser.Application.DTOs.Lessons
{
    public class CreateLessonDto
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
