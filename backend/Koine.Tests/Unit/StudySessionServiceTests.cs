using Koine.Application.Study.DTOs;
using Koine.Application.Study.Ports;
using Koine.Application.Study.Services;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class StudySessionServiceTests
{
    [Test]
    public async Task StartSession_DueOnly_DoesNotRequestNewCards()
    {
        var unitOfWork = new Mock<Koine.Application.Interfaces.IUnitOfWork>();
        var userProvider = new Mock<ICurrentUserProvider>();
        var progressRepo = new Mock<IUserCardProgressRepository>();
        var sessionRepo = new Mock<IStudySessionRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var setRepo = new Mock<IVocabularySetItemRepository>();

        userProvider.Setup(p => p.GetUserId()).Returns(1);
        progressRepo.Setup(r => r.GetDueCardsAsync(1, It.IsAny<int>(), It.IsAny<IEnumerable<int>?>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new List<UserCardProgress>());

        var service = new StudySessionService(unitOfWork.Object, userProvider.Object, progressRepo.Object, sessionRepo.Object, vocabRepo.Object, setRepo.Object);

        await service.StartSessionAsync(new StartSessionRequest
        {
            CardCount = 5,
            Pool = CardPool.DueOnly,
            Direction = StudyDirection.GreekToEnglish,
            Mode = InteractionMode.Flip
        }, CancellationToken.None);

        progressRepo.Verify(r => r.GetNewCardsAsync(1, It.IsAny<int>(), It.IsAny<IEnumerable<int>?>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Test]
    public async Task StartSession_LimitsCardCount()
    {
        var unitOfWork = new Mock<Koine.Application.Interfaces.IUnitOfWork>();
        var userProvider = new Mock<ICurrentUserProvider>();
        var progressRepo = new Mock<IUserCardProgressRepository>();
        var sessionRepo = new Mock<IStudySessionRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var setRepo = new Mock<IVocabularySetItemRepository>();

        userProvider.Setup(p => p.GetUserId()).Returns(1);
        progressRepo.Setup(r => r.GetDueCardsAsync(1, It.IsAny<int>(), It.IsAny<IEnumerable<int>?>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Enumerable.Range(1, 10).Select(id => new UserCardProgress { VocabularyId = id }).ToList());

        var service = new StudySessionService(unitOfWork.Object, userProvider.Object, progressRepo.Object, sessionRepo.Object, vocabRepo.Object, setRepo.Object);
        var result = await service.StartSessionAsync(new StartSessionRequest
        {
            CardCount = 5,
            Pool = CardPool.DueOnly,
            Direction = StudyDirection.GreekToEnglish,
            Mode = InteractionMode.Flip
        }, CancellationToken.None);

        Assert.That(result.TotalCards, Is.EqualTo(5));
    }

    [Test]
    public async Task RateCard_UpsertsProgress_AndCompletesSession()
    {
        var unitOfWork = new Mock<Koine.Application.Interfaces.IUnitOfWork>();
        var userProvider = new Mock<ICurrentUserProvider>();
        var progressRepo = new Mock<IUserCardProgressRepository>();
        var sessionRepo = new Mock<IStudySessionRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var setRepo = new Mock<IVocabularySetItemRepository>();

        userProvider.Setup(p => p.GetUserId()).Returns(1);
        var sessionId = Guid.NewGuid();
        var session = new StudySession
        {
            Id = sessionId,
            UserId = 1,
            StartedAt = DateTime.UtcNow,
            Config = new SessionConfig
            {
                CardCount = 1,
                Pool = CardPool.DueOnly,
                Direction = StudyDirection.GreekToEnglish,
                Mode = InteractionMode.Flip
            },
            Cards = new List<SessionCard>
            {
                new() { Id = 1, SessionId = sessionId, VocabularyId = 10, Position = 1, Mode = InteractionMode.Flip, Direction = StudyDirection.GreekToEnglish }
            }
        };

        sessionRepo.Setup(r => r.GetByIdAsync(sessionId, It.IsAny<CancellationToken>())).ReturnsAsync(session);
        progressRepo.Setup(r => r.GetByVocabularyIdAsync(1, 10, It.IsAny<CancellationToken>())).ReturnsAsync((UserCardProgress?)null);

        var service = new StudySessionService(unitOfWork.Object, userProvider.Object, progressRepo.Object, sessionRepo.Object, vocabRepo.Object, setRepo.Object);
        var response = await service.RateCardAsync(sessionId, 10, Rating.Good, CancellationToken.None);

        progressRepo.Verify(r => r.UpsertAsync(It.Is<UserCardProgress>(p => p.VocabularyId == 10), It.IsAny<CancellationToken>()), Times.Once);
        Assert.That(response?.SessionComplete, Is.True);
    }

    [Test]
    public async Task CompleteSession_AwardsXpOnce_AndIsIdempotent()
    {
        var user = new User { Id = 3, TotalExperience = 1000 };
        var userRepo = new Mock<Koine.Application.Interfaces.Repositories.IUserRepository>();
        var unitOfWork = new Mock<Koine.Application.Interfaces.IUnitOfWork>();
        var userProvider = new Mock<ICurrentUserProvider>();
        var progressRepo = new Mock<IUserCardProgressRepository>();
        var sessionRepo = new Mock<IStudySessionRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var setRepo = new Mock<IVocabularySetItemRepository>();

        unitOfWork.SetupGet(x => x.Users).Returns(userRepo.Object);
        unitOfWork.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);
        userRepo.Setup(r => r.GetByIdAsync(3)).ReturnsAsync(user);

        var sessionId = Guid.NewGuid();
        var session = new StudySession
        {
            Id = sessionId,
            UserId = 3,
            StartedAt = DateTime.UtcNow,
            ExperienceAwarded = 0,
            Config = new SessionConfig
            {
                CardCount = 2,
                Pool = CardPool.Mixed,
                Direction = StudyDirection.GreekToEnglish,
                Mode = InteractionMode.Flip,
                Source = SessionSource.ReaderMini
            },
            Cards = new List<SessionCard>
            {
                new() { VocabularyId = 1, Position = 1, GivenRating = Rating.Good },
                new() { VocabularyId = 2, Position = 2, GivenRating = Rating.Again }
            }
        };
        sessionRepo.Setup(r => r.GetByIdAsync(sessionId, It.IsAny<CancellationToken>())).ReturnsAsync(session);

        var service = new StudySessionService(unitOfWork.Object, userProvider.Object, progressRepo.Object, sessionRepo.Object, vocabRepo.Object, setRepo.Object);

        var first = await service.CompleteSessionAsync(sessionId, CancellationToken.None);
        var second = await service.CompleteSessionAsync(sessionId, CancellationToken.None);

        Assert.That(first, Is.Not.Null);
        Assert.That(first!.FirstCompletionReward, Is.True);
        Assert.That(first.XpGained, Is.GreaterThan(0));
        Assert.That(second, Is.Not.Null);
        Assert.That(second!.FirstCompletionReward, Is.False);
        Assert.That(second.XpGained, Is.EqualTo(0));
    }
}
