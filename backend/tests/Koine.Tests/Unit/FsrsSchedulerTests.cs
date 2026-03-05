using Koine.Application.Study.Services;
using Koine.Domain.Entities;

namespace Koine.Tests.Unit;

[TestFixture]
public class FsrsSchedulerTests
{
    [TestCase(Rating.Again)]
    [TestCase(Rating.Hard)]
    [TestCase(Rating.Good)]
    [TestCase(Rating.Easy)]
    public void NewCard_Ratings_SetInitialStabilityAndState(Rating rating)
    {
        var card = new UserCardProgress
        {
            Stability = 0,
            Difficulty = 0,
            State = CardState.New
        };

        var output = FsrsScheduler.Schedule(new FsrsInput(card, rating, DateTime.UtcNow));

        Assert.That(output.Stability, Is.GreaterThan(0));
        Assert.That(output.Difficulty, Is.InRange(1f, 10f));
        Assert.That(output.NextState, Is.EqualTo(CardState.Learning).Or.EqualTo(CardState.Review));
    }

    [Test]
    public void ReviewCard_Again_TransitionsToRelearning_AndIncrementsLapseFormula()
    {
        var card = new UserCardProgress
        {
            Stability = 5,
            Difficulty = 5,
            State = CardState.Review,
            LastReviewDate = DateTime.UtcNow.AddDays(-3)
        };

        var output = FsrsScheduler.Schedule(new FsrsInput(card, Rating.Again, DateTime.UtcNow));

        Assert.That(output.NextState, Is.EqualTo(CardState.Relearning));
        Assert.That(output.Stability, Is.GreaterThan(0));
    }

    [Test]
    public void ReviewCard_Easy_ProducesLongerInterval()
    {
        var card = new UserCardProgress
        {
            Stability = 5,
            Difficulty = 5,
            State = CardState.Review,
            LastReviewDate = DateTime.UtcNow.AddDays(-3)
        };

        var good = FsrsScheduler.Schedule(new FsrsInput(card, Rating.Good, DateTime.UtcNow));
        var easy = FsrsScheduler.Schedule(new FsrsInput(card, Rating.Easy, DateTime.UtcNow));

        Assert.That(easy.ScheduledDays, Is.GreaterThan(good.ScheduledDays));
    }

    [Test]
    public void Difficulty_IsClamped()
    {
        var card = new UserCardProgress
        {
            Stability = 0.1f,
            Difficulty = 100,
            State = CardState.Review,
            LastReviewDate = DateTime.UtcNow.AddDays(-1)
        };

        var output = FsrsScheduler.Schedule(new FsrsInput(card, Rating.Easy, DateTime.UtcNow));
        Assert.That(output.Difficulty, Is.InRange(1f, 10f));
    }
}
