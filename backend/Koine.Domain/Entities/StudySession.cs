// Koine.Domain/Entities/StudySession.cs
using Koine.Domain.ValueObjects;

namespace Koine.Domain.Entities
{
    public class StudySession
    {
        /// <summary>Session id.</summary>
        public Guid Id { get; set; }
        /// <summary>User id owning the session.</summary>
        public int UserId { get; set; }
        /// <summary>Session start timestamp.</summary>
        public DateTime StartedAt { get; set; }
        /// <summary>Session completion timestamp.</summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>Session configuration.</summary>
        public SessionConfig Config { get; set; } = null!;
        /// <summary>Ordered cards in this session.</summary>
        public ICollection<SessionCard> Cards { get; set; } = new List<SessionCard>();
    }

    public class SessionCard
    {
        /// <summary>Primary key.</summary>
        public int Id { get; set; }
        /// <summary>Parent session id.</summary>
        public Guid SessionId { get; set; }
        /// <summary>Vocabulary id for the card.</summary>
        public int VocabularyId { get; set; }
        /// <summary>Card position within the session.</summary>
        public int Position { get; set; }
        /// <summary>Rating given by the user.</summary>
        public Rating? GivenRating { get; set; }
        /// <summary>Reviewed timestamp.</summary>
        public DateTime? ReviewedAt { get; set; }
        /// <summary>Interaction mode for this card.</summary>
        public InteractionMode Mode { get; set; }
        /// <summary>Serialized multiple choice options.</summary>
        public string? ChoicesJson { get; set; }
        /// <summary>Direction used for this card.</summary>
        public StudyDirection Direction { get; set; }
    }

    public enum Rating
    {
        Again = 1,
        Hard = 2,
        Good = 3,
        Easy = 4
    }

    public enum InteractionMode
    {
        Flip = 0,
        MultipleChoice = 1,
        Mix = 2
    }
}
