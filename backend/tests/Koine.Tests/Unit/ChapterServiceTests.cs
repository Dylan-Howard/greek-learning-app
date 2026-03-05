using Koine.Application.DTOs.Chapters;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class ChapterServiceTests
{
    [Test]
    public async Task GetChapterByIdAsync_ReturnsParsedUnitTree()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        chapterRepo.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(new Chapter
        {
            Id = 2,
            BookId = 1,
            ChapterIndex = 2,
            Title = "Chapter 2",
            UnitTreeJson = "[{\"Id\":\"u1\",\"Type\":\"original\"}]",
        });
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new ChapterService(uow.Object);
        var result = await service.GetChapterByIdAsync(2);

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.UnitTree, Has.Count.EqualTo(1));
        Assert.That(result.UnitTree[0].Id, Is.EqualTo("u1"));
    }

    [Test]
    public async Task CreateChapterAsync_SerializesUnitTree()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        chapterRepo
            .Setup(r => r.AddAsync(It.IsAny<Chapter>()))
            .ReturnsAsync((Chapter c) =>
            {
                c.Id = 4;
                return c;
            });
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new ChapterService(uow.Object);
        var result = await service.CreateChapterAsync(3, new CreateChapterDto
        {
            ChapterIndex = 5,
            Title = "Created",
            UnitTree = new List<UnitNodeDto> { new() { Id = "node-1", Type = "original" } },
        });

        Assert.That(result.Id, Is.EqualTo(4));
        Assert.That(result.UnitTree, Has.Count.EqualTo(1));
        chapterRepo.Verify(r => r.AddAsync(It.Is<Chapter>(c => c.UnitTreeJson.Contains("node-1"))), Times.Once);
    }

    [Test]
    public async Task UpdateChapterAsync_ReturnsNull_WhenChapterMissing()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        chapterRepo.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Chapter?)null);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new ChapterService(uow.Object);
        var result = await service.UpdateChapterAsync(99, new UpdateChapterDto
        {
            ChapterIndex = 1,
            Title = "Updated",
            UnitTree = new List<UnitNodeDto>(),
        });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GetChaptersByBookIdAsync_ReturnsMappedList()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        chapterRepo.Setup(r => r.GetByBookIdAsync(1)).ReturnsAsync(new List<Chapter>
        {
            new() { Id = 1, BookId = 1, ChapterIndex = 1, Title = "One", UnitTreeJson = "[]" },
            new() { Id = 2, BookId = 1, ChapterIndex = 2, Title = "Two", UnitTreeJson = "[]" },
        });
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new ChapterService(uow.Object);
        var result = await service.GetChaptersByBookIdAsync(1);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result[0].BookId, Is.EqualTo(1));
    }

    [Test]
    public async Task GetChapterByIdAsync_ReturnsNull_WhenMissing()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        chapterRepo.Setup(r => r.GetByIdAsync(404)).ReturnsAsync((Chapter?)null);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new ChapterService(uow.Object);
        var result = await service.GetChapterByIdAsync(404);

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task UpdateChapterAsync_UpdatesAndReturnsDto_WhenFound()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();
        var chapter = new Chapter
        {
            Id = 7,
            BookId = 3,
            ChapterIndex = 1,
            Title = "Old",
            UnitTreeJson = "[]",
        };

        chapterRepo.Setup(r => r.GetByIdAsync(7)).ReturnsAsync(chapter);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new ChapterService(uow.Object);
        var result = await service.UpdateChapterAsync(7, new UpdateChapterDto
        {
            ChapterIndex = 9,
            Title = "Updated",
            UnitTree = new List<UnitNodeDto> { new() { Id = "z" } },
        });

        Assert.That(result, Is.Not.Null);
        Assert.That(chapter.Title, Is.EqualTo("Updated"));
        Assert.That(chapter.ChapterIndex, Is.EqualTo(9));
        chapterRepo.Verify(r => r.UpdateAsync(chapter), Times.Once);
    }

    [Test]
    public async Task DeleteChapterAsync_ReturnsTrue_WhenDeleted()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();
        var chapter = new Chapter { Id = 5 };

        chapterRepo.Setup(r => r.GetByIdAsync(5)).ReturnsAsync(chapter);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new ChapterService(uow.Object);
        var result = await service.DeleteChapterAsync(5);

        Assert.That(result, Is.True);
        chapterRepo.Verify(r => r.DeleteAsync(chapter), Times.Once);
    }

    [Test]
    public async Task DeleteChapterAsync_ReturnsFalse_WhenMissing()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        chapterRepo.Setup(r => r.GetByIdAsync(6)).ReturnsAsync((Chapter?)null);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new ChapterService(uow.Object);
        var result = await service.DeleteChapterAsync(6);

        Assert.That(result, Is.False);
    }
}
