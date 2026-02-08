// GreekParser.Application/DTOs/Lessons/SimpleLessonDto.cs
using System;

namespace GreekParser.Application.DTOs.Lessons
{
    public class SimpleLessonDto
    {
        public Guid LessonGUID { get; set; }
        public int LessonId { get; set; }
        public string Title { get; set; }
    }
}
