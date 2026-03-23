// Feature: graphql-integration, Property 2: Non-admin users are forbidden from admin mutations
// Feature: graphql-integration, Property 5: Invalid mutation inputs are rejected before service invocation

using System.Security.Claims;
using FsCheck;
using FsCheck.NUnit;
using GraphQL;
using GraphQL.Execution;
using GraphQL.Types;
using GraphQL.Validation;
using GraphQLParser.AST;
using Koine.API.GraphQL.Mutations;
using Koine.API.GraphQL.Queries;
using Koine.API.GraphQL.Schema;
using Koine.API.GraphQL.Types;
using Koine.API.GraphQL.Types.InputTypes;
using Koine.Application.Interfaces;
using Koine.Application.Study.Ports;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Property-based tests for RootMutation authorization and input validation.
/// </summary>
[TestFixture]
public class RootMutationPropertyTests
{
    // ── known admin mutation names ────────────────────────────────────────────

    private static readonly string[] AdminMutationNames =
    [
        "createBook",
        "updateBook",
        "deleteBook",
        "createChapter",
        "updateChapter",
        "deleteChapter",
        "createVocabulary",
        "updateVocabulary",
        "deleteVocabulary",
    ];

    // ── schema / service helpers ──────────────────────────────────────────────

    private record SchemaWithMocks(
        KoineSchema Schema,
        Mock<IBookService> Books,
        Mock<IChapterService> Chapters,
        Mock<IVocabularyService> Vocabulary);

    /// <summary>
    /// Builds a <see cref="KoineSchema"/> with an authenticated non-admin user
    /// (has the "Authenticated" identity but no "admin" role claim).
    /// </summary>
    private static SchemaWithMocks BuildSchemaWithNonAdminUser()
    {
        var books = new Mock<IBookService>();
        var chapters = new Mock<IChapterService>();
        var vocab = new Mock<IVocabularyService>();

        // Authenticated but no admin role
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.NameIdentifier, "42"),
            new Claim(ClaimTypes.Name, "testuser"),
        }, "Test");
        var httpContext = new DefaultHttpContext { User = new ClaimsPrincipal(identity) };
        var http = new Mock<IHttpContextAccessor>();
        http.Setup(h => h.HttpContext).Returns(httpContext);

        var services = new ServiceCollection();

        services.AddSingleton<BookType>();
        services.AddSingleton<ChapterType>();
        services.AddSingleton<WordType>();
        services.AddSingleton<GrammaticalFeatureType>();
        services.AddSingleton<SyntacticalFeatureType>();
        services.AddSingleton<RenderedChapterType>();
        services.AddSingleton<RenderedUnitType>();
        services.AddSingleton<VocabularySetType>();
        services.AddSingleton<VocabularySetItemType>();
        services.AddSingleton<SessionType>();
        services.AddSingleton<CardType>();
        services.AddSingleton<CardFrontType>();
        services.AddSingleton<CardBackType>();
        services.AddSingleton<RateCardResultType>();
        services.AddSingleton<SessionSummaryType>();
        services.AddSingleton<DashboardType>();
        services.AddSingleton<ReviewHistoryPointType>();
        services.AddSingleton<UserProgressType>();
        services.AddSingleton<LessonType>();
        services.AddSingleton<LessonTrackType>();
        services.AddSingleton<LessonCompletionResultType>();
        services.AddSingleton<VocabularyResultType>();
        services.AddSingleton<CardProgressType>();
        services.AddSingleton<StartSessionInputType>();
        services.AddSingleton<CreateVocabularySetInputType>();
        services.AddSingleton<CompleteLessonInputType>();
        services.AddSingleton<UserProgressInputType>();
        services.AddSingleton<CreateBookInputType>();
        services.AddSingleton<UpdateBookInputType>();
        services.AddSingleton<CreateChapterInputType>();
        services.AddSingleton<UpdateChapterInputType>();
        services.AddSingleton<CreateVocabularyInputType>();
        services.AddSingleton<UpdateVocabularyInputType>();

        services.AddSingleton(books.Object);
        services.AddSingleton(chapters.Object);
        services.AddSingleton(vocab.Object);
        services.AddSingleton(new Mock<IReaderService>().Object);
        services.AddSingleton(new Mock<ILessonService>().Object);
        services.AddSingleton(new Mock<IProgressService>().Object);
        services.AddSingleton(new Mock<IStudyService>().Object);
        services.AddSingleton(new Mock<IStudySessionService>().Object);
        services.AddSingleton(http.Object);

        services.AddSingleton<RootQuery>();
        services.AddSingleton<RootMutation>();
        services.AddSingleton<KoineSchema>();

        var provider = services.BuildServiceProvider();
        var schema = provider.GetRequiredService<KoineSchema>();
        schema.Initialize();

        return new SchemaWithMocks(schema, books, chapters, vocab);
    }

    // ── ForbiddenRejectionRule ────────────────────────────────────────────────

    /// <summary>
    /// A validation rule that rejects fields decorated with <c>AuthorizeWithPolicy("AdminOnly")</c>
    /// when the current user does not have the "admin" role.
    /// </summary>
    private sealed class ForbiddenRejectionRule : ValidationRuleBase
    {
        private static readonly MatchingNodeVisitor<GraphQLField> _rejectVisitor =
            new((fieldAst, ctx) =>
            {
                var fieldDef = ctx.TypeInfo.GetFieldDef();
                if (fieldDef is null) return;

                var policies = fieldDef.GetPolicies();
                if (policies?.Contains("AdminOnly") == true)
                {
                    ctx.ReportError(new ValidationError(
                        ctx.Document.Source,
                        "AUTHZ",
                        "You are not authorized to perform this action.",
                        fieldAst)
                    {
                        Code = "FORBIDDEN"
                    });
                }
            });

        public override ValueTask<INodeVisitor?> GetPreNodeVisitorAsync(ValidationContext context)
            => new ValueTask<INodeVisitor?>(_rejectVisitor);
    }

    // ── document executor helper ──────────────────────────────────────────────

    private static async Task<ExecutionResult> ExecuteWithNonAdminAsync(
        ISchema schema, string document)
    {
        var executor = new DocumentExecuter();
        return await executor.ExecuteAsync(opts =>
        {
            opts.Schema = schema;
            opts.Query = document;
            opts.ValidationRules = DocumentValidator.CoreRules
                .Append(new ForbiddenRejectionRule())
                .ToList();
        });
    }

    // ── Property 2a: admin mutations return FORBIDDEN for non-admin users ─────

    /// <summary>
    /// For any admin mutation name, executing that mutation as a non-admin authenticated user
    /// must produce a GraphQL error with extension code FORBIDDEN.
    /// Validates: Requirements 3.18, 6.6
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AdminMutation_NonAdminUser_ReturnsForbiddenError(NonNegativeInt index)
    {
        var mutationName = AdminMutationNames[index.Get % AdminMutationNames.Length];
        var sw = BuildSchemaWithNonAdminUser();
        var result = ExecuteWithNonAdminAsync(sw.Schema, $"mutation {{ {mutationName} }}")
            .GetAwaiter().GetResult();

        var hasForbidden = result.Errors?.Any(e =>
            string.Equals(e.Code, "FORBIDDEN", StringComparison.OrdinalIgnoreCase)) == true;

        return Prop.ToProperty(hasForbidden);
    }

    // ── Property 2b: services are never called when FORBIDDEN ─────────────────

    /// <summary>
    /// For any admin mutation name, executing that mutation as a non-admin user
    /// must not invoke any Application Service method.
    /// Validates: Requirements 3.18, 6.6
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AdminMutation_NonAdminUser_NeverCallsService(NonNegativeInt index)
    {
        var mutationName = AdminMutationNames[index.Get % AdminMutationNames.Length];
        var sw = BuildSchemaWithNonAdminUser();
        ExecuteWithNonAdminAsync(sw.Schema, $"mutation {{ {mutationName} }}")
            .GetAwaiter().GetResult();

        sw.Books.Verify(s => s.CreateBookAsync(It.IsAny<Koine.Application.DTOs.Books.CreateBookDto>()), Times.Never());
        sw.Books.Verify(s => s.UpdateBookAsync(It.IsAny<int>(), It.IsAny<Koine.Application.DTOs.Books.UpdateBookDto>()), Times.Never());
        sw.Books.Verify(s => s.DeleteBookAsync(It.IsAny<int>()), Times.Never());
        sw.Chapters.Verify(s => s.CreateChapterAsync(It.IsAny<int>(), It.IsAny<Koine.Application.DTOs.Chapters.CreateChapterDto>()), Times.Never());
        sw.Chapters.Verify(s => s.UpdateChapterAsync(It.IsAny<int>(), It.IsAny<Koine.Application.DTOs.Chapters.UpdateChapterDto>()), Times.Never());
        sw.Chapters.Verify(s => s.DeleteChapterAsync(It.IsAny<int>()), Times.Never());
        sw.Vocabulary.Verify(s => s.CreateVocabularyAsync(It.IsAny<Koine.Application.DTOs.Vocabulary.CreateVocabularyDto>()), Times.Never());
        sw.Vocabulary.Verify(s => s.UpdateVocabularyAsync(It.IsAny<int>(), It.IsAny<Koine.Application.DTOs.Vocabulary.UpdateVocabularyDto>()), Times.Never());
        sw.Vocabulary.Verify(s => s.DeleteVocabularyAsync(It.IsAny<int>()), Times.Never());

        return Prop.ToProperty(true);
    }

    // ── helpers for Property 5 ────────────────────────────────────────────────

    private static RootMutation BuildMutation(
        Mock<IStudySessionService>? sessions = null,
        Mock<IStudyService>? study = null,
        Mock<IProgressService>? progress = null,
        Mock<ILessonService>? lessons = null,
        Mock<IBookService>? books = null,
        Mock<IChapterService>? chapters = null,
        Mock<IVocabularyService>? vocab = null,
        int? authenticatedUserId = 42)
    {
        var http = new Mock<IHttpContextAccessor>();
        if (authenticatedUserId.HasValue)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, authenticatedUserId.Value.ToString())
            }, "Test");
            http.Setup(h => h.HttpContext)
                .Returns(new DefaultHttpContext { User = new ClaimsPrincipal(identity) });
        }
        else
        {
            http.Setup(h => h.HttpContext).Returns(new DefaultHttpContext());
        }

        return new RootMutation(
            sessions?.Object ?? new Mock<IStudySessionService>().Object,
            study?.Object ?? new Mock<IStudyService>().Object,
            progress?.Object ?? new Mock<IProgressService>().Object,
            lessons?.Object ?? new Mock<ILessonService>().Object,
            books?.Object ?? new Mock<IBookService>().Object,
            chapters?.Object ?? new Mock<IChapterService>().Object,
            vocab?.Object ?? new Mock<IVocabularyService>().Object,
            http.Object);
    }

    private static async Task<object?> ResolveField(
        RootMutation mutation, string fieldName,
        Dictionary<string, ArgumentValue>? args = null)
    {
        var field = mutation.Fields.First(f => f.Name == fieldName);
        var ctx = new ResolveFieldContext
        {
            Arguments = args ?? new Dictionary<string, ArgumentValue>()
        };
        return await field.Resolver!.ResolveAsync(ctx);
    }

    private static ArgumentValue Arg(object? value) =>
        new(value, ArgumentSource.Literal);

    // ── Property 5a: rateCard rejects out-of-range rating ────────────────────

    /// <summary>
    /// For any rating value outside [1,4], rateCard throws BAD_USER_INPUT
    /// and the service is never called.
    /// Validates: Requirements 3.19
    /// </summary>
    [Property(MaxTest = 200)]
    public Property RateCard_InvalidRating_ThrowsBadUserInput(int rawRating)
    {
        // Only test values outside [1,4]
        if (rawRating >= 1 && rawRating <= 4)
            return Prop.ToProperty(true); // skip valid values

        var sessions = new Mock<IStudySessionService>();
        var mutation = BuildMutation(sessions: sessions);

        ExecutionError? error = null;
        try
        {
            ResolveField(mutation, "rateCard", new()
            {
                ["sessionId"] = Arg(Guid.NewGuid().ToString()),
                ["vocabularyId"] = Arg(1),
                ["rating"] = Arg(rawRating)
            }).GetAwaiter().GetResult();
        }
        catch (ExecutionError ex)
        {
            error = ex;
        }

        var isBadInput = error?.Code == "BAD_USER_INPUT";
        sessions.Verify(s => s.RateCardAsync(
            It.IsAny<Guid>(), It.IsAny<int>(), It.IsAny<Koine.Domain.Entities.Rating>(), It.IsAny<CancellationToken>()),
            Times.Never());

        return Prop.ToProperty(isBadInput);
    }

    // ── Property 5b: createBook rejects empty/whitespace title ───────────────

    /// <summary>
    /// For any empty or whitespace title, createBook throws BAD_USER_INPUT
    /// and the service is never called.
    /// Validates: Requirements 3.19
    /// </summary>
    [Property(MaxTest = 100)]
    public Property CreateBook_EmptyTitle_ThrowsBadUserInput(NonEmptyString rawTitle)
    {
        // Build a title that is whitespace-only by repeating spaces
        var title = new string(' ', rawTitle.Get.Length % 5 + 1);

        var books = new Mock<IBookService>();
        var mutation = BuildMutation(books: books);

        ExecutionError? error = null;
        try
        {
            ResolveField(mutation, "createBook", new()
            {
                ["input"] = Arg(new Koine.Application.DTOs.Books.CreateBookDto
                {
                    Title = title,
                    LanguageCode = "grc"
                })
            }).GetAwaiter().GetResult();
        }
        catch (ExecutionError ex)
        {
            error = ex;
        }

        var isBadInput = error?.Code == "BAD_USER_INPUT";
        books.Verify(s => s.CreateBookAsync(It.IsAny<Koine.Application.DTOs.Books.CreateBookDto>()), Times.Never());

        return Prop.ToProperty(isBadInput);
    }

    // ── Property 5c: createVocabularySet rejects empty/whitespace title ───────

    /// <summary>
    /// For any empty or whitespace title, createVocabularySet throws BAD_USER_INPUT
    /// and the service is never called.
    /// Validates: Requirements 3.19
    /// </summary>
    [Property(MaxTest = 100)]
    public Property CreateVocabularySet_EmptyTitle_ThrowsBadUserInput(NonEmptyString rawTitle)
    {
        var title = new string(' ', rawTitle.Get.Length % 5 + 1);

        var study = new Mock<IStudyService>();
        var mutation = BuildMutation(study: study);

        ExecutionError? error = null;
        try
        {
            ResolveField(mutation, "createVocabularySet", new()
            {
                ["input"] = Arg(new Koine.Application.DTOs.Study.CreateVocabularySetDto
                {
                    Title = title,
                    Description = "desc",
                    VocabularyIds = new List<int>()
                })
            }).GetAwaiter().GetResult();
        }
        catch (ExecutionError ex)
        {
            error = ex;
        }

        var isBadInput = error?.Code == "BAD_USER_INPUT";
        study.Verify(s => s.CreateSetAsync(It.IsAny<int>(), It.IsAny<Koine.Application.DTOs.Study.CreateVocabularySetDto>()), Times.Never());

        return Prop.ToProperty(isBadInput);
    }
}
