// Koine.Domain/ValueObjects/SessionConfig.cs
using Koine.Domain.Entities;

namespace Koine.Domain.ValueObjects
{
    public class SessionConfig
    {
        /// <summary>Card count (-1 for all due).</summary>
        public int CardCount { get; set; }
        /// <summary>Card pool selection.</summary>
        public CardPool Pool { get; set; }
        /// <summary>Study direction preference.</summary>
        public StudyDirection Direction { get; set; }
        /// <summary>Interaction mode preference.</summary>
        public InteractionMode Mode { get; set; }
        /// <summary>Optional vocabulary set id to scope cards.</summary>
        public int? VocabularySetId { get; set; }
    }

    public enum CardPool
    {
        DueOnly = 0,
        NewOnly = 1,
        Mixed = 2
    }

    public enum StudyDirection
    {
        GreekToEnglish = 0,
        EnglishToGreek = 1,
        Random = 2
    }
}
