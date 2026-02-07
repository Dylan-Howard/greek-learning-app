// GreekParser.Domain/Entities/UserProgress.cs
namespace GreekParser.Domain.Entities
{
    public class UserProgress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompletedLessonIdsJson { get; set; } = "[]";
        public string GrammaticalFeatureProgressJson { get; set; } = "{}";
        public string SyntacticalFeatureProgressJson { get; set; } = "{}";
        public string VocabularyProgressJson { get; set; } = "{}";
        public DateTime UpdatedAt { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
    }
}
