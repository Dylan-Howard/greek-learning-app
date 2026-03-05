// Koine.Domain/Entities/UserCardProgress.cs
namespace Koine.Domain.Entities
{
    public class UserCardProgress
    {
        /// <summary>Primary key.</summary>
        public int Id { get; set; }
        /// <summary>User id owning this progress record.</summary>
        public int UserId { get; set; }
        /// <summary>Vocabulary id for the card.</summary>
        public int VocabularyId { get; set; }
        /// <summary>Navigation to vocabulary.</summary>
        public Vocabulary Vocabulary { get; set; } = null!;
        /// <summary>FSRS stability (days).</summary>
        public float Stability { get; set; }
        /// <summary>FSRS difficulty (0-10 scale).</summary>
        public float Difficulty { get; set; }
        /// <summary>Elapsed days since last review.</summary>
        public float ElapsedDays { get; set; }
        /// <summary>Scheduled days until next review.</summary>
        public float ScheduledDays { get; set; }
        /// <summary>Total number of reviews.</summary>
        public int ReviewCount { get; set; }
        /// <summary>Total number of lapses.</summary>
        public int Lapses { get; set; }
        /// <summary>Current card state.</summary>
        public CardState State { get; set; }
        /// <summary>Last review timestamp.</summary>
        public DateTime? LastReviewDate { get; set; }
        /// <summary>Next scheduled review timestamp.</summary>
        public DateTime NextReviewDate { get; set; }
    }

    public enum CardState
    {
        New = 0,
        Learning = 1,
        Review = 2,
        Relearning = 3
    }
}
