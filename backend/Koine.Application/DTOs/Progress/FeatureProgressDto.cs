// GreekParser.Application/DTOs/Progress/FeatureProgressDto.cs
namespace GreekParser.Application.DTOs.Progress
{
    public class FeatureProgressDto
    {
        public int MasteryLevel { get; set; }
        public bool NeedsPractice { get; set; }
        public DateTime LastPracticed { get; set; }
    }
}
