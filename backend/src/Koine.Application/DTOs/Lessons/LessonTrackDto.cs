namespace Koine.Application.DTOs.Lessons
{
    public class LessonTrackDto
    {
        public int Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public int TotalLessons { get; set; }
        public int CompletedLessons { get; set; }
        public decimal PercentComplete { get; set; }
        public int? NextLessonId { get; set; }
        public string? NextLessonSlug { get; set; }
        public string? NextLessonTitle { get; set; }
        public List<LessonDto> Lessons { get; set; } = new();
    }
}
