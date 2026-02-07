// GreekParser.Application/DTOs/Progress/VocabularyProgressDto.cs
namespace GreekParser.Application.DTOs.Progress
{
    public class VocabularyProgressDto
    {
        public int MasteryLevel { get; set; }
        public bool NeedsPractice { get; set; }
        public DateTime LastPracticed { get; set; }
        public int TimesSeen { get; set; }
    }
}
