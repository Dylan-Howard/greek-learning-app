// Koine.Domain/Entities/Lesson.cs
namespace Koine.Domain.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int LessonIndex { get; set; }
        public string ContentMarkdown { get; set; } = string.Empty;
        public string? ContentPath { get; set; }
        public string LessonType { get; set; } = string.Empty;
        public string GrammaticalFeatureIdsJson { get; set; } = "[]"; // Stored as JSON array
        public string SyntacticalFeatureIdsJson { get; set; } = "[]";
        public string VocabularyIdsJson { get; set; } = "[]";
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public virtual LessonTrack? Track { get; set; }
        public virtual ICollection<LessonCompletion> Completions { get; set; } = new List<LessonCompletion>();
    }
}
