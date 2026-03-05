using Koine.Application.DTOs.Books;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class BookServiceTests
{
    [Test]
    public async Task GetAllBooksAsync_MapsChapterCounts()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        bookRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Book>
        {
            new() { Id = 1, Title = "John", LanguageCode = "grc" },
            new() { Id = 2, Title = "Mark", LanguageCode = "grc" },
        });
        chapterRepo.Setup(r => r.GetByBookIdAsync(1)).ReturnsAsync(new List<Chapter> { new(), new() });
        chapterRepo.Setup(r => r.GetByBookIdAsync(2)).ReturnsAsync(new List<Chapter> { new() });

        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new BookService(uow.Object);
        var result = await service.GetAllBooksAsync();

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Single(x => x.Id == 1).ChapterCount, Is.EqualTo(2));
        Assert.That(result.Single(x => x.Id == 2).ChapterCount, Is.EqualTo(1));
    }

    [Test]
    public async Task GetBookByIdAsync_ReturnsNull_WhenBookMissing()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        bookRepo.Setup(r => r.GetByIdAsync(9)).ReturnsAsync((Book?)null);
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new BookService(uow.Object);
        var result = await service.GetBookByIdAsync(9);

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task CreateBookAsync_CreatesAndReturnsDto()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        bookRepo
            .Setup(r => r.AddAsync(It.IsAny<Book>()))
            .ReturnsAsync((Book b) =>
            {
                b.Id = 12;
                return b;
            });
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new BookService(uow.Object);
        var result = await service.CreateBookAsync(new CreateBookDto { Title = "Luke", LanguageCode = "grc" });

        Assert.That(result.Id, Is.EqualTo(12));
        Assert.That(result.Title, Is.EqualTo("Luke"));
        Assert.That(result.ChapterCount, Is.EqualTo(0));
        uow.Verify(x => x.SaveChangesAsync(), Times.Once);
    }

    [Test]
    public async Task DeleteBookAsync_ReturnsFalse_WhenBookMissing()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        bookRepo.Setup(r => r.GetByIdAsync(7)).ReturnsAsync((Book?)null);
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new BookService(uow.Object);
        var result = await service.DeleteBookAsync(7);

        Assert.That(result, Is.False);
    }

    [Test]
    public async Task GetBookByIdAsync_ReturnsMappedDto_WhenFound()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        bookRepo.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(new Book { Id = 2, Title = "Romans", LanguageCode = "grc" });
        chapterRepo.Setup(r => r.GetByBookIdAsync(2)).ReturnsAsync(new List<Chapter> { new(), new(), new() });
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new BookService(uow.Object);
        var result = await service.GetBookByIdAsync(2);

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.ChapterCount, Is.EqualTo(3));
        Assert.That(result.Title, Is.EqualTo("Romans"));
    }

    [Test]
    public async Task UpdateBookAsync_ReturnsNull_WhenBookMissing()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();

        bookRepo.Setup(r => r.GetByIdAsync(3)).ReturnsAsync((Book?)null);
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);

        var service = new BookService(uow.Object);
        var result = await service.UpdateBookAsync(3, new UpdateBookDto { Title = "Updated", LanguageCode = "en" });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task UpdateBookAsync_UpdatesAndReturnsDto()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();
        var book = new Book { Id = 4, Title = "Old", LanguageCode = "grc" };

        bookRepo.Setup(r => r.GetByIdAsync(4)).ReturnsAsync(book);
        chapterRepo.Setup(r => r.GetByBookIdAsync(4)).ReturnsAsync(new List<Chapter> { new() });
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new BookService(uow.Object);
        var result = await service.UpdateBookAsync(4, new UpdateBookDto { Title = "New", LanguageCode = "en" });

        Assert.That(result, Is.Not.Null);
        Assert.That(book.Title, Is.EqualTo("New"));
        Assert.That(book.LanguageCode, Is.EqualTo("en"));
        bookRepo.Verify(r => r.UpdateAsync(book), Times.Once);
    }

    [Test]
    public async Task DeleteBookAsync_DeletesAndReturnsTrue_WhenFound()
    {
        var bookRepo = new Mock<IBookRepository>();
        var chapterRepo = new Mock<IChapterRepository>();
        var uow = new Mock<IUnitOfWork>();
        var book = new Book { Id = 8, Title = "Delete Me" };

        bookRepo.Setup(r => r.GetByIdAsync(8)).ReturnsAsync(book);
        uow.SetupGet(x => x.Books).Returns(bookRepo.Object);
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new BookService(uow.Object);
        var result = await service.DeleteBookAsync(8);

        Assert.That(result, Is.True);
        bookRepo.Verify(r => r.DeleteAsync(book), Times.Once);
    }
}
