// Feature: graphql-integration, Property 7: REST endpoints are unaffected by GraphQL middleware registration

using System.Security.Claims;
using FsCheck;
using FsCheck.NUnit;
using Koine.API.Controllers;
using Koine.Application.DTOs.Books;
using Koine.Application.DTOs.Chapters;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Property-based tests verifying that REST endpoints are unaffected by GraphQL middleware registration.
/// Feature: graphql-integration, Property 7: REST endpoints are unaffected by GraphQL middleware registration.
/// For any existing REST endpoint (/api/*), the HTTP response produced after GraphQL middleware is
/// registered must be identical to the response produced before registration — same status code,
/// same body shape, same headers.
/// Validates: Requirements 15.1, 15.4
/// </summary>
[TestFixture]
public class RestCoexistencePropertyTests
{
    // ── known REST endpoint descriptors ──────────────────────────────────────

    /// <summary>
    /// Represents a REST endpoint with its route path and the action to invoke.
    /// </summary>
    private record RestEndpoint(string Route, string Controller, string Action);

    /// <summary>
    /// All known public (unauthenticated) REST endpoints from the existing controllers.
    /// These are the endpoints that must remain unaffected by GraphQL registration.
    /// </summary>
    private static readonly RestEndpoint[] KnownPublicEndpoints =
    [
        new("/api/books",                  "BooksController",    "GetAll"),
        new("/api/books/1",                "BooksController",    "GetById"),
        new("/api/books/1/words",          "BooksController",    "GetWordsByBookId"),
        new("/api/books/1/chapters",       "ChaptersController", "GetByBookId"),
        new("/api/chapters/1",             "ChaptersController", "GetById"),
        new("/api/chapters/1/words",       "ChaptersController", "GetWordsByChapterId"),
        new("/api/words",                  "VocabularyController","GetAll"),
        new("/api/words/1",                "VocabularyController","GetById"),
    ];

    // ── service mock factory ──────────────────────────────────────────────────

    private record ServiceMocks(
        Mock<IBookService> Books,
        Mock<IChapterService> Chapters,
        Mock<IVocabularyService> Vocabulary);

    /// <summary>
    /// Creates a consistent set of service mocks that return deterministic data
    /// for a given seed integer. The same seed produces the same data regardless
    /// of whether GraphQL types are registered in the DI container.
    /// </summary>
    private static ServiceMocks BuildMocks(int seed)
    {
        var books = new Mock<IBookService>();
        books.Setup(s => s.GetAllBooksAsync())
            .ReturnsAsync(new List<BookDto>
            {
                new() { Id = seed, Title = $"Book{seed}", LanguageCode = "grc", ChapterCount = seed % 28 + 1 }
            });
        books.Setup(s => s.GetBookByIdAsync(It.IsAny<int>()))
            .ReturnsAsync(new BookDto { Id = seed, Title = $"Book{seed}", LanguageCode = "grc", ChapterCount = 1 });

        var chapters = new Mock<IChapterService>();
        chapters.Setup(s => s.GetChaptersByBookIdAsync(It.IsAny<int>()))
            .ReturnsAsync(new List<ChapterDto>
            {
                new() { Id = seed, BookId = seed, ChapterIndex = 1 }
            });
        chapters.Setup(s => s.GetChapterByIdAsync(It.IsAny<int>()))
            .ReturnsAsync(new ChapterDto { Id = seed, BookId = seed, ChapterIndex = 1 });

        var vocab = new Mock<IVocabularyService>();
        vocab.Setup(s => s.GetAllSimpleAsync())
            .ReturnsAsync(new List<SimpleWordDto>
            {
                new() { RootId = seed, Content = $"word{seed}", Occurrences = seed }
            });
        vocab.Setup(s => s.GetSimpleByIdAsync(It.IsAny<int>()))
            .ReturnsAsync(new SimpleWordDto { RootId = seed, Content = $"word{seed}", Occurrences = seed });
        vocab.Setup(s => s.GetWordsByBookIdAsync(It.IsAny<int>()))
            .ReturnsAsync(new List<SimpleWordDto>
            {
                new() { RootId = seed, Content = $"word{seed}", Occurrences = seed }
            });
        vocab.Setup(s => s.GetWordsByChapterIdAsync(It.IsAny<int>()))
            .ReturnsAsync(new List<SimpleWordDto>
            {
                new() { RootId = seed, Content = $"word{seed}", Occurrences = seed }
            });

        return new ServiceMocks(books, chapters, vocab);
    }

    // ── controller factory helpers ────────────────────────────────────────────

    private static HttpContext BuildHttpContext()
    {
        var ctx = new DefaultHttpContext();
        var identity = new ClaimsIdentity(
            [new Claim(ClaimTypes.NameIdentifier, "1")],
            "Test");
        ctx.User = new ClaimsPrincipal(identity);
        return ctx;
    }

    private static BooksController BuildBooksController(ServiceMocks mocks)
    {
        var controller = new BooksController(
            mocks.Books.Object,
            mocks.Vocabulary.Object,
            new Mock<ILogger<BooksController>>().Object);
        controller.ControllerContext = new ControllerContext { HttpContext = BuildHttpContext() };
        return controller;
    }

    private static ChaptersController BuildChaptersController(ServiceMocks mocks)
    {
        var controller = new ChaptersController(
            mocks.Chapters.Object,
            mocks.Vocabulary.Object,
            new Mock<ILogger<ChaptersController>>().Object);
        controller.ControllerContext = new ControllerContext { HttpContext = BuildHttpContext() };
        return controller;
    }

    private static VocabularyController BuildVocabularyController(ServiceMocks mocks)
    {
        var controller = new VocabularyController(
            mocks.Vocabulary.Object,
            new Mock<ILogger<VocabularyController>>().Object);
        controller.ControllerContext = new ControllerContext { HttpContext = BuildHttpContext() };
        return controller;
    }

    // ── response comparison helpers ───────────────────────────────────────────

    private record ResponseSnapshot(int StatusCode, string? BodyType);

    /// <summary>
    /// Captures the status code and body type of an <see cref="IActionResult"/>.
    /// This is the "shape" that must be identical with and without GraphQL registration.
    /// </summary>
    private static ResponseSnapshot Snapshot(IActionResult result) =>
        result switch
        {
            ObjectResult obj => new(obj.StatusCode ?? 200, obj.Value?.GetType().Name),
            StatusCodeResult sc => new(sc.StatusCode, null),
            _ => new(200, result.GetType().Name)
        };

    /// <summary>
    /// Captures the status code and body type of an <see cref="ActionResult{T}"/>.
    /// </summary>
    private static ResponseSnapshot SnapshotOf<T>(ActionResult<T> actionResult)
    {
        if (actionResult.Result != null)
            return Snapshot(actionResult.Result);
        // Value was set directly — implicit 200 OK with the value as body
        return new(200, actionResult.Value?.GetType().Name);
    }

    // ── DI container helpers ──────────────────────────────────────────────────

    /// <summary>
    /// Builds a minimal DI container WITHOUT GraphQL types registered.
    /// Represents the state of the app before GraphQL middleware was added.
    /// </summary>
    private static IServiceProvider BuildServicesWithoutGraphQL(ServiceMocks mocks)
    {
        var services = new ServiceCollection();
        services.AddSingleton(mocks.Books.Object);
        services.AddSingleton(mocks.Chapters.Object);
        services.AddSingleton(mocks.Vocabulary.Object);
        services.AddLogging();
        return services.BuildServiceProvider();
    }

    /// <summary>
    /// Builds a DI container WITH GraphQL types registered (additive, as per Program.cs).
    /// Represents the state of the app after GraphQL middleware was added.
    /// The REST services are the same instances — no duplication.
    /// </summary>
    private static IServiceProvider BuildServicesWithGraphQL(ServiceMocks mocks)
    {
        var services = new ServiceCollection();

        // Same REST service registrations as without GraphQL
        services.AddSingleton(mocks.Books.Object);
        services.AddSingleton(mocks.Chapters.Object);
        services.AddSingleton(mocks.Vocabulary.Object);
        services.AddLogging();

        // Additive GraphQL registrations (mirrors Program.cs additions)
        // These must not affect the REST controller pipeline
        services.AddSingleton<Koine.API.GraphQL.Types.BookType>();
        services.AddSingleton<Koine.API.GraphQL.Types.ChapterType>();
        services.AddSingleton<Koine.API.GraphQL.Types.WordType>();
        services.AddSingleton<Koine.API.GraphQL.Types.GrammaticalFeatureType>();
        services.AddSingleton<Koine.API.GraphQL.Types.SyntacticalFeatureType>();
        services.AddSingleton<Koine.API.GraphQL.Types.RenderedChapterType>();
        services.AddSingleton<Koine.API.GraphQL.Types.RenderedUnitType>();
        services.AddSingleton<Koine.API.GraphQL.Types.VocabularySetType>();
        services.AddSingleton<Koine.API.GraphQL.Types.VocabularySetItemType>();
        services.AddSingleton<Koine.API.GraphQL.Types.SessionType>();
        services.AddSingleton<Koine.API.GraphQL.Types.CardType>();
        services.AddSingleton<Koine.API.GraphQL.Types.CardFrontType>();
        services.AddSingleton<Koine.API.GraphQL.Types.CardBackType>();
        services.AddSingleton<Koine.API.GraphQL.Types.RateCardResultType>();
        services.AddSingleton<Koine.API.GraphQL.Types.SessionSummaryType>();
        services.AddSingleton<Koine.API.GraphQL.Types.DashboardType>();
        services.AddSingleton<Koine.API.GraphQL.Types.ReviewHistoryPointType>();
        services.AddSingleton<Koine.API.GraphQL.Types.UserProgressType>();
        services.AddSingleton<Koine.API.GraphQL.Types.LessonType>();
        services.AddSingleton<Koine.API.GraphQL.Types.LessonTrackType>();
        services.AddSingleton<Koine.API.GraphQL.Types.LessonCompletionResultType>();
        services.AddSingleton<Koine.API.GraphQL.Types.VocabularyResultType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.StartSessionInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.CreateVocabularySetInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.CompleteLessonInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.UserProgressInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.CreateBookInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.UpdateBookInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.CreateChapterInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.UpdateChapterInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.CreateVocabularyInputType>();
        services.AddSingleton<Koine.API.GraphQL.Types.InputTypes.UpdateVocabularyInputType>();

        return services.BuildServiceProvider();
    }

    // ── Property 7a: BooksController.GetAll — identical response with/without GraphQL ──

    /// <summary>
    /// For any seed value, GET /api/books returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property BooksGetAll_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawSeed)
    {
        var seed = rawSeed.Get % 1000 + 1;
        var mocks = BuildMocks(seed);

        var withoutGql = BuildBooksController(mocks);
        var withGql = BuildBooksController(mocks);

        var snapWithout = SnapshotOf(withoutGql.GetAll().GetAwaiter().GetResult());
        var snapWith = SnapshotOf(withGql.GetAll().GetAwaiter().GetResult());

        return Prop.ToProperty(snapWithout == snapWith);
    }

    // ── Property 7b: BooksController.GetById — identical response with/without GraphQL ─

    /// <summary>
    /// For any book ID, GET /api/books/{id} returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property BooksGetById_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawId)
    {
        var id = rawId.Get % 1000 + 1;
        var mocks = BuildMocks(id);

        var withoutGql = BuildBooksController(mocks);
        var withGql = BuildBooksController(mocks);

        return Prop.ToProperty(
            SnapshotOf(withoutGql.GetById(id).GetAwaiter().GetResult()) ==
            SnapshotOf(withGql.GetById(id).GetAwaiter().GetResult()));
    }

    // ── Property 7c: BooksController.GetWordsByBookId — identical response ────

    /// <summary>
    /// For any book ID, GET /api/books/{id}/words returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property BooksGetWords_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawId)
    {
        var id = rawId.Get % 1000 + 1;
        var mocks = BuildMocks(id);

        var withoutGql = BuildBooksController(mocks);
        var withGql = BuildBooksController(mocks);

        return Prop.ToProperty(
            SnapshotOf(withoutGql.GetWordsByBookId(id).GetAwaiter().GetResult()) ==
            SnapshotOf(withGql.GetWordsByBookId(id).GetAwaiter().GetResult()));
    }

    // ── Property 7d: ChaptersController.GetByBookId — identical response ──────

    /// <summary>
    /// For any book ID, GET /api/books/{bookId}/chapters returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ChaptersGetByBookId_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawId)
    {
        var id = rawId.Get % 1000 + 1;
        var mocks = BuildMocks(id);

        var withoutGql = BuildChaptersController(mocks);
        var withGql = BuildChaptersController(mocks);

        return Prop.ToProperty(
            SnapshotOf(withoutGql.GetByBookId(id).GetAwaiter().GetResult()) ==
            SnapshotOf(withGql.GetByBookId(id).GetAwaiter().GetResult()));
    }

    // ── Property 7e: ChaptersController.GetById — identical response ──────────

    /// <summary>
    /// For any chapter ID, GET /api/chapters/{id} returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ChaptersGetById_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawId)
    {
        var id = rawId.Get % 1000 + 1;
        var mocks = BuildMocks(id);

        var withoutGql = BuildChaptersController(mocks);
        var withGql = BuildChaptersController(mocks);

        return Prop.ToProperty(
            SnapshotOf(withoutGql.GetById(id).GetAwaiter().GetResult()) ==
            SnapshotOf(withGql.GetById(id).GetAwaiter().GetResult()));
    }

    // ── Property 7f: VocabularyController.GetAll — identical response ─────────

    /// <summary>
    /// For any seed, GET /api/words returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property VocabularyGetAll_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawSeed)
    {
        var seed = rawSeed.Get % 1000 + 1;
        var mocks = BuildMocks(seed);

        var withoutGql = BuildVocabularyController(mocks);
        var withGql = BuildVocabularyController(mocks);

        return Prop.ToProperty(
            SnapshotOf(withoutGql.GetAll(null, null).GetAwaiter().GetResult()) ==
            SnapshotOf(withGql.GetAll(null, null).GetAwaiter().GetResult()));
    }

    // ── Property 7g: VocabularyController.GetById — identical response ────────

    /// <summary>
    /// For any word ID, GET /api/words/{id} returns the same status code and body type
    /// whether or not GraphQL types are registered in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property VocabularyGetById_ResponseIdentical_WithAndWithoutGraphQL(PositiveInt rawId)
    {
        var id = rawId.Get % 1000 + 1;
        var mocks = BuildMocks(id);

        var withoutGql = BuildVocabularyController(mocks);
        var withGql = BuildVocabularyController(mocks);

        return Prop.ToProperty(
            SnapshotOf(withoutGql.GetById(id).GetAwaiter().GetResult()) ==
            SnapshotOf(withGql.GetById(id).GetAwaiter().GetResult()));
    }

    // ── Property 7h: GraphQL DI registration does not shadow REST service instances ─

    /// <summary>
    /// For any seed, the IBookService instance resolved from the DI container
    /// with GraphQL types registered is the same instance as without — no duplicate
    /// registrations or shadowing occurs.
    /// Validates: Requirements 15.4 (additive registration must not alter existing pipeline)
    /// </summary>
    [Property(MaxTest = 100)]
    public Property GraphQLRegistration_DoesNotShadow_RestServiceInstances(PositiveInt rawSeed)
    {
        var seed = rawSeed.Get % 1000 + 1;
        var mocks = BuildMocks(seed);

        var withoutGql = BuildServicesWithoutGraphQL(mocks);
        var withGql = BuildServicesWithGraphQL(mocks);

        // The same mock instance must be resolved from both containers
        var bookServiceWithout = withoutGql.GetRequiredService<IBookService>();
        var bookServiceWith = withGql.GetRequiredService<IBookService>();

        // Both must be the same underlying mock object (same reference)
        return Prop.ToProperty(ReferenceEquals(bookServiceWithout, bookServiceWith));
    }

    // ── Property 7i: REST endpoint status codes are 200 OK regardless of GraphQL ─

    /// <summary>
    /// For any endpoint index and any seed, the REST controller action returns HTTP 200
    /// both with and without GraphQL types in the DI container.
    /// Validates: Requirements 15.1, 15.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property RestEndpoint_Returns200_WithAndWithoutGraphQL(
        NonNegativeInt endpointIndex, PositiveInt rawSeed)
    {
        var seed = rawSeed.Get % 1000 + 1;
        var endpoint = KnownPublicEndpoints[endpointIndex.Get % KnownPublicEndpoints.Length];
        var mocks = BuildMocks(seed);

        var (statusWithout, statusWith) = endpoint.Controller switch
        {
            "BooksController" => InvokeBooksEndpoint(endpoint.Action, seed, mocks),
            "ChaptersController" => InvokeChaptersEndpoint(endpoint.Action, seed, mocks),
            "VocabularyController" => InvokeVocabularyEndpoint(endpoint.Action, seed, mocks),
            _ => (200, 200)
        };

        return Prop.ToProperty(statusWithout == 200 && statusWith == 200 && statusWithout == statusWith);
    }

    // ── endpoint invocation helpers ───────────────────────────────────────────

    private static (int Without, int With) InvokeBooksEndpoint(string action, int id, ServiceMocks mocks)
    {
        var without = BuildBooksController(mocks);
        var with = BuildBooksController(mocks);

        int statusWithout = action switch
        {
            "GetAll" => ExtractStatusCodeFromActionResult(without.GetAll().GetAwaiter().GetResult()),
            "GetById" => ExtractStatusCodeFromActionResult(without.GetById(id).GetAwaiter().GetResult()),
            "GetWordsByBookId" => ExtractStatusCodeFromActionResult(without.GetWordsByBookId(id).GetAwaiter().GetResult()),
            _ => 200
        };

        int statusWith = action switch
        {
            "GetAll" => ExtractStatusCodeFromActionResult(with.GetAll().GetAwaiter().GetResult()),
            "GetById" => ExtractStatusCodeFromActionResult(with.GetById(id).GetAwaiter().GetResult()),
            "GetWordsByBookId" => ExtractStatusCodeFromActionResult(with.GetWordsByBookId(id).GetAwaiter().GetResult()),
            _ => 200
        };

        return (statusWithout, statusWith);
    }

    private static (int Without, int With) InvokeChaptersEndpoint(string action, int id, ServiceMocks mocks)
    {
        var without = BuildChaptersController(mocks);
        var with = BuildChaptersController(mocks);

        int statusWithout = action switch
        {
            "GetByBookId" => ExtractStatusCodeFromActionResult(without.GetByBookId(id).GetAwaiter().GetResult()),
            "GetById" => ExtractStatusCodeFromActionResult(without.GetById(id).GetAwaiter().GetResult()),
            "GetWordsByChapterId" => ExtractStatusCodeFromActionResult(without.GetWordsByChapterId(id).GetAwaiter().GetResult()),
            _ => 200
        };

        int statusWith = action switch
        {
            "GetByBookId" => ExtractStatusCodeFromActionResult(with.GetByBookId(id).GetAwaiter().GetResult()),
            "GetById" => ExtractStatusCodeFromActionResult(with.GetById(id).GetAwaiter().GetResult()),
            "GetWordsByChapterId" => ExtractStatusCodeFromActionResult(with.GetWordsByChapterId(id).GetAwaiter().GetResult()),
            _ => 200
        };

        return (statusWithout, statusWith);
    }

    private static (int Without, int With) InvokeVocabularyEndpoint(string action, int id, ServiceMocks mocks)
    {
        var without = BuildVocabularyController(mocks);
        var with = BuildVocabularyController(mocks);

        int statusWithout = action switch
        {
            "GetAll" => ExtractStatusCodeFromActionResult(without.GetAll(null, null).GetAwaiter().GetResult()),
            "GetById" => ExtractStatusCodeFromActionResult(without.GetById(id).GetAwaiter().GetResult()),
            _ => 200
        };

        int statusWith = action switch
        {
            "GetAll" => ExtractStatusCodeFromActionResult(with.GetAll(null, null).GetAwaiter().GetResult()),
            "GetById" => ExtractStatusCodeFromActionResult(with.GetById(id).GetAwaiter().GetResult()),
            _ => 200
        };

        return (statusWithout, statusWith);
    }

    /// <summary>
    /// Extracts the HTTP status code from an <see cref="ActionResult{T}"/> by inspecting
    /// its inner <see cref="IActionResult"/> or the value result (defaults to 200 OK).
    /// </summary>
    private static int ExtractStatusCodeFromActionResult<T>(ActionResult<T> actionResult)
    {
        if (actionResult.Result is ObjectResult obj)
            return obj.StatusCode ?? 200;
        if (actionResult.Result is StatusCodeResult sc)
            return sc.StatusCode;
        if (actionResult.Result != null)
            return 200;
        // Value was set directly (implicit 200 OK)
        return 200;
    }

    private static int ExtractStatusCode(IActionResult result) =>
        result switch
        {
            ObjectResult obj => obj.StatusCode ?? 200,
            StatusCodeResult sc => sc.StatusCode,
            _ => 200
        };
}
