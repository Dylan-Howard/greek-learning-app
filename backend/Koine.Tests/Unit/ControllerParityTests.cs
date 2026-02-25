using Koine.API.Controllers;
using Koine.Application.DTOs.Books;
using Koine.Application.DTOs.Chapters;
using Koine.Application.DTOs.Features;
using Koine.Application.DTOs.Lessons;
using Koine.Application.DTOs.Study;
using Koine.Application.DTOs.Translations;
using Koine.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class ControllerParityTests
{
    [Test]
    public async Task SelectionsController_ReturnsSelectionsPayload()
    {
        var bookService = new Mock<IBookService>();
        var chapterService = new Mock<IChapterService>();
        var logger = new Mock<ILogger<SelectionsController>>();

        bookService.Setup(x => x.GetAllBooksAsync()).ReturnsAsync(new List<BookDto>
        {
            new() { Id = 1, Title = "John" },
            new() { Id = 2, Title = "Mark" },
        });
        chapterService.Setup(x => x.GetChaptersByBookIdAsync(1)).ReturnsAsync(new List<ChapterDto>
        {
            new() { Id = 9, ChapterIndex = 3 },
        });

        var controller = new SelectionsController(bookService.Object, chapterService.Object, logger.Object);
        var response = await controller.GetSelectionsByTextId(1);

        var ok = response.Result as OkObjectResult;
        Assert.That(ok, Is.Not.Null);

        var payload = ok!.Value as Koine.Application.DTOs.Selections.SelectionsDto;
        Assert.That(payload, Is.Not.Null);
        Assert.That(payload!.Texts, Has.Length.EqualTo(2));
        Assert.That(payload.Chapters[0].ChapterNumber, Is.EqualTo(3));
    }

    [Test]
    public async Task TranslationsController_CreateTranslation_ReturnsBadRequest_WhenTranslationIdMissing()
    {
        var translationService = new Mock<ITranslationService>();
        var unitService = new Mock<ITranslationUnitService>();
        var logger = new Mock<ILogger<TranslationsController>>();
        var controller = new TranslationsController(translationService.Object, unitService.Object, logger.Object);

        var response = await controller.CreateTranslation(new SimpleTranslationDto
        {
            TranslationId = 0,
            UnitId = 10,
            Content = "text",
        });

        Assert.That(response.Result, Is.InstanceOf<BadRequestObjectResult>());
    }

    [Test]
    public async Task TranslationsController_CreateTranslation_UsesTranslationUnitService()
    {
        var translationService = new Mock<ITranslationService>();
        var unitService = new Mock<ITranslationUnitService>();
        var logger = new Mock<ILogger<TranslationsController>>();

        unitService.Setup(x => x.CreateUnitAsync(3, It.IsAny<CreateTranslationUnitDto>()))
            .ReturnsAsync(new TranslationUnitDto
            {
                Id = 42,
                TranslationId = 3,
                ChapterId = 11,
                OriginalUnitPath = "legacy/unit/11",
                TranslatedText = "In the beginning",
            });

        var controller = new TranslationsController(translationService.Object, unitService.Object, logger.Object);
        var response = await controller.CreateTranslation(new SimpleTranslationDto
        {
            TranslationId = 3,
            UnitId = 11,
            Content = "In the beginning",
        });

        Assert.That(response.Result, Is.InstanceOf<CreatedAtActionResult>());
        unitService.Verify(x => x.CreateUnitAsync(3, It.IsAny<CreateTranslationUnitDto>()), Times.Once);
    }

    [Test]
    public async Task GrammaticalFeaturesController_GetAll_MapsFeaturesAndLessonIds()
    {
        var featureService = new Mock<IGrammaticalFeatureService>();
        var lessonService = new Mock<ILessonService>();
        var logger = new Mock<ILogger<GrammaticalFeaturesController>>();

        featureService.Setup(x => x.GetAllFeaturesAsync()).ReturnsAsync(new List<GrammaticalFeatureDto>
        {
            new() { Id = 2, Name = "Aorist", Code = "AOR" },
        });
        lessonService.Setup(x => x.GetAllLessonsAsync(0)).ReturnsAsync(new List<LessonDto>
        {
            new() { Id = 7, GrammaticalFeatureIds = new List<int> { 2 } },
        });

        var controller = new GrammaticalFeaturesController(featureService.Object, lessonService.Object, logger.Object);
        var response = await controller.GetAll();

        var ok = response.Result as OkObjectResult;
        Assert.That(ok, Is.Not.Null);
        var payload = ok!.Value as List<SimpleGrammaticalFormDto>;
        Assert.That(payload, Has.Count.EqualTo(1));
        Assert.That(payload![0].LessonId, Is.EqualTo(7));
    }

    [Test]
    public async Task VocabularySetsController_GetAll_ReturnsOk()
    {
        var studyService = new Mock<IStudyService>();
        var logger = new Mock<ILogger<VocabularySetsController>>();

        studyService.Setup(s => s.GetUserSetsAsync(It.IsAny<int>())).ReturnsAsync(new List<VocabularySetDto>
        {
            new() { Id = 1, Title = "All NT Vocabulary", IsSystem = true, Slug = "nt-all-vocab", TotalCount = 100 },
        });

        var controller = new VocabularySetsController(studyService.Object, logger.Object);
        var response = await controller.GetAll();

        var payload = response.Value as List<VocabularySetDto>;
        if (payload == null)
        {
            var objectResult = response.Result as ObjectResult;
            Assert.That(objectResult, Is.Not.Null);
            Assert.That(objectResult!.StatusCode, Is.Not.EqualTo(500));
            payload = objectResult.Value as List<VocabularySetDto>;
        }

        Assert.That(payload, Has.Count.EqualTo(1));
        Assert.That(payload![0].Slug, Is.EqualTo("nt-all-vocab"));
    }
}
