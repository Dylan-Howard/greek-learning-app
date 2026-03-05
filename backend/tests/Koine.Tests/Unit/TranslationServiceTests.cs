using Koine.Application.DTOs.Translations;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class TranslationServiceTests
{
    [Test]
    public async Task GetTranslationsByBookIdAsync_FiltersByBookId()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();

        translationRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Translation>
        {
            new() { Id = 1, BookId = 1, LanguageCode = "en", Name = "ESV" },
            new() { Id = 2, BookId = 2, LanguageCode = "en", Name = "NIV" },
        });
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);

        var service = new TranslationService(uow.Object);
        var result = await service.GetTranslationsByBookIdAsync(1);

        Assert.That(result, Has.Count.EqualTo(1));
        Assert.That(result[0].Id, Is.EqualTo(1));
    }

    [Test]
    public async Task GetTranslationByIdAsync_ReturnsNull_WhenMissing()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();

        translationRepo.Setup(r => r.GetByIdAsync(5)).ReturnsAsync((Translation?)null);
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);

        var service = new TranslationService(uow.Object);
        var result = await service.GetTranslationByIdAsync(5);

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task CreateTranslationAsync_CreatesEntity()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();

        translationRepo.Setup(r => r.AddAsync(It.IsAny<Translation>()))
            .ReturnsAsync((Translation t) =>
            {
                t.Id = 77;
                return t;
            });
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new TranslationService(uow.Object);
        var result = await service.CreateTranslationAsync(3, new CreateTranslationDto
        {
            LanguageCode = "en",
            Name = "NET",
        });

        Assert.That(result.Id, Is.EqualTo(77));
        Assert.That(result.BookId, Is.EqualTo(3));
        Assert.That(result.Name, Is.EqualTo("NET"));
    }

    [Test]
    public async Task DeleteTranslationAsync_ReturnsFalse_WhenMissing()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();

        translationRepo.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Translation?)null);
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);

        var service = new TranslationService(uow.Object);
        var result = await service.DeleteTranslationAsync(99);

        Assert.That(result, Is.False);
    }

    [Test]
    public async Task GetTranslationByIdAsync_ReturnsDto_WhenFound()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();

        translationRepo.Setup(r => r.GetByIdAsync(8))
            .ReturnsAsync(new Translation { Id = 8, BookId = 1, LanguageCode = "en", Name = "ESV" });
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);

        var service = new TranslationService(uow.Object);
        var result = await service.GetTranslationByIdAsync(8);

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Name, Is.EqualTo("ESV"));
    }

    [Test]
    public async Task UpdateTranslationAsync_ReturnsNull_WhenMissing()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();

        translationRepo.Setup(r => r.GetByIdAsync(4)).ReturnsAsync((Translation?)null);
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);

        var service = new TranslationService(uow.Object);
        var result = await service.UpdateTranslationAsync(4, new UpdateTranslationDto { LanguageCode = "en", Name = "NIV" });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task UpdateTranslationAsync_UpdatesAndReturnsDto()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();
        var entity = new Translation { Id = 12, BookId = 2, LanguageCode = "grc", Name = "Old" };

        translationRepo.Setup(r => r.GetByIdAsync(12)).ReturnsAsync(entity);
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new TranslationService(uow.Object);
        var result = await service.UpdateTranslationAsync(12, new UpdateTranslationDto { LanguageCode = "en", Name = "Updated" });

        Assert.That(result, Is.Not.Null);
        Assert.That(entity.Name, Is.EqualTo("Updated"));
        translationRepo.Verify(r => r.UpdateAsync(entity), Times.Once);
    }

    [Test]
    public async Task DeleteTranslationAsync_DeletesAndReturnsTrue()
    {
        var translationRepo = new Mock<ITranslationRepository>();
        var uow = new Mock<IUnitOfWork>();
        var entity = new Translation { Id = 30, Name = "Delete" };

        translationRepo.Setup(r => r.GetByIdAsync(30)).ReturnsAsync(entity);
        uow.SetupGet(x => x.Translations).Returns(translationRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new TranslationService(uow.Object);
        var result = await service.DeleteTranslationAsync(30);

        Assert.That(result, Is.True);
        translationRepo.Verify(r => r.DeleteAsync(entity), Times.Once);
    }
}
