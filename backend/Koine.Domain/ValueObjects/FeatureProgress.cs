// GreekParser.Domain/ValueObjects/FeatureProgress.cs
namespace GreekParser.Domain.ValueObjects
{
    public class FeatureProgress
    {
        public int MasteryLevel { get; set; } // 0-100
        public bool NeedsPractice { get; set; }
        public DateTime LastPracticed { get; set; }
    }
}
