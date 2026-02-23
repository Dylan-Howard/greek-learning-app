// Koine.Domain/ValueObjects/VocabularyProgress.cs
namespace Koine.Domain.ValueObjects
{
    public class VocabularyProgress
    {
        public int MasteryLevel { get; set; } // 0-100
        public bool NeedsPractice { get; set; }
        public DateTime LastPracticed { get; set; }
        public int TimesSeen { get; set; }
    }
}
