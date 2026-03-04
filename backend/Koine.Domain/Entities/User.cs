// Koine.Domain/Entities/User.cs
namespace Koine.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? DisplayName { get; set; }
        public int TotalExperience { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        
        // Navigation properties
        public virtual UserProgress? Progress { get; set; }
        public virtual ICollection<LessonCompletion> LessonCompletions { get; set; } = new List<LessonCompletion>();
        public virtual ICollection<UserSetting> Settings { get; set; } = new List<UserSetting>();
        public virtual ICollection<VocabularySet> OwnedVocabularySets { get; set; } = new List<VocabularySet>();
    }
}
