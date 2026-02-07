// GreekParser.Domain/Entities/Lesson.cs
namespace GreekParser.Domain.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int LessonIndex { get; set; }
        public string ContentMarkdown { get; set; } = string.Empty;
        public string LessonType { get; set; } = string.Empty;
        public string GrammaticalFeatureIdsJson { get; set; } = "[]"; // Stored as JSON array
        public string SyntacticalFeatureIdsJson { get; set; } = "[]";
        public string VocabularyIdsJson { get; set; } = "[]";
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public virtual ICollection<LessonCompletion> Completions { get; set; } = new List<LessonCompletion>();
    }
}
