namespace Koine.Application.DTOs.Lessons
{
    public class LessonCompletionResponseDto
    {
        public string Message { get; set; } = "Lesson completed successfully";
        public int XpGained { get; set; }
        public int TotalExperience { get; set; }
        public bool FirstCompletion { get; set; }
    }
}
