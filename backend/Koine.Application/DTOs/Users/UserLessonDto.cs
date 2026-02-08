// GreekParser.Application/DTOs/Users/UserLessonDto.cs
namespace GreekParser.Application.DTOs.Users
{
    public class UserLessonDto
    {
        public int LessonId { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
