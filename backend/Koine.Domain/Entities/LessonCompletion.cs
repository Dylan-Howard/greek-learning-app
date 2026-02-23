// Koine.Domain/Entities/LessonCompletion.cs
namespace Koine.Domain.Entities
{
    public class LessonCompletion
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public int? Score { get; set; }
        public DateTime CompletedAt { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual Lesson Lesson { get; set; } = null!;
    }
}
