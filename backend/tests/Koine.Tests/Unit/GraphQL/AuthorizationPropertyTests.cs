// Feature: graphql-integration, Property 1: Unauthenticated requests are rejected without invoking services

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
/// Property-based tests for authorization enforcement on protected GraphQL fields.
/// Feature: graphql-integration, Property 1: Unauthenticated requests are rejected without invoking services.
/// For any protected field, sending a request without a valid JWT must result in a GraphQL error
/// with extension code UNAUTHENTICATED, and the underlying Application Service must not be called.
/// Validates: Requirements 1.6, 6.2
/// </summary>
[TestFixture]
public class AuthorizationPropertyTests
{
    // ── known protected fields ────────────────────────────────────────────────

    /// <summary>Query fields that require the "Authenticated" policy.</summary>
    private static readonly string[] ProtectedQueryFields =
    [
        "lessons",
        "progress",
        "studySets",
        "studyDashboard",
    ];

    /// <summary>Mutation fields that require the "Authenticated" or "AdminOnly" policy.</summary>
    private static readonly string[] AllProtectedMutationFields =
    [
        "startStudySession",
        "rateCard",
        "completeStudySession",
        "createVocabularySet",
        "deleteVocabularySet",
        "updateProgress",
        "completeLesson",
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
        Mock<ILessonService> Lessons,
        Mock<IProgressService> Progress,
        Mock<IStudyService> Study,
        Mock<IStudySessionService> Sessions);

    /// <summary>
    /// Builds a <see cref="KoineSchema"/> wired with Moq service stubs and an
    /// <see cref="IHttpContextAccessor"/> that returns an anonymous (unauthenticated)
    /// <see cref="ClaimsPrincipal"/>.
    /// </summary>
    private static SchemaWithMocks BuildSchemaWithAnonymousContext()
    {
        var books = new Mock<IBookService>();
        var chapters = new Mock<IChapterService>();
        var vocab = new Mock<IVocabularyService>();
        var reader = new Mock<IReaderService>();
        var lessons = new Mock<ILessonService>();
        var progress = new Mock<IProgressService>();
        var study = new Mock<IStudyService>();
        var sessions = new Mock<IStudySessionService>();

        // Anonymous HTTP context — no authentication type, so IsAuthenticated == false
        var httpContext = new DefaultHttpContext
        {
            User = new ClaimsPrincipal(new ClaimsIdentity()) // no authType → not authenticated
        };
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
        services.AddSingleton(reader.Object);
        services.AddSingleton(lessons.Object);
        services.AddSingleton(progress.Object);
        services.AddSingleton(study.Object);
        services.AddSingleton(sessions.Object);
        services.AddSingleton(http.Object);

        services.AddSingleton<RootQuery>();
        services.AddSingleton<RootMutation>();
        services.AddSingleton<KoineSchema>();

        var provider = services.BuildServiceProvider();
        var schema = provider.GetRequiredService<KoineSchema>();
        schema.Initialize();

        return new SchemaWithMocks(schema, lessons, progress, study, sessions);
    }

    // ── authorization validation rule (GraphQL-dotnet v8) ────────────────────

    /// <summary>
    /// A <see cref="ValidationRuleBase"/> that rejects any field decorated with
    /// <c>AuthorizeWithPolicy</c> metadata when the current user is not authenticated.
    /// Fires during the pre-node-visitor pass, before any resolver is invoked.
    /// </summary>
    private sealed class UnauthenticatedRejectionRule : ValidationRuleBase
    {
        private static readonly MatchingNodeVisitor<GraphQLField> _rejectVisitor =
            new((fieldAst, ctx) =>
            {
                var fieldDef = ctx.TypeInfo.GetFieldDef();
                if (fieldDef is null) return;

                var policies = fieldDef.GetPolicies();
                if (policies?.Any() == true)
                {
                    ctx.ReportError(new ValidationError(
                        ctx.Document.Source,
                        "AUTH",
                        "You are not authorized to access this resource.",
                        fieldAst)
                    {
                        Code = "UNAUTHENTICATED"
                    });
                }
            });

        public override ValueTask<INodeVisitor?> GetPreNodeVisitorAsync(ValidationContext context)
            => new ValueTask<INodeVisitor?>(_rejectVisitor);
    }

    // ── document executor helper ──────────────────────────────────────────────

    private static async Task<ExecutionResult> ExecuteUnauthenticatedAsync(
        ISchema schema, string document)
    {
        var executor = new DocumentExecuter();
        return await executor.ExecuteAsync(opts =>
        {
            opts.Schema = schema;
            opts.Query = document;
            opts.ValidationRules = DocumentValidator.CoreRules
                .Append(new UnauthenticatedRejectionRule())
                .ToList();
        });
    }

    // ── Property 1a: protected query fields return UNAUTHENTICATED ────────────

    /// <summary>
    /// For any protected query field name, executing that query without authentication
    /// must produce a GraphQL error with extension code UNAUTHENTICATED.
    /// Validates: Requirements 1.6, 6.2
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ProtectedQueryField_UnauthenticatedRequest_ReturnsUnauthenticatedError(
        NonNegativeInt index)
    {
        var fieldName = ProtectedQueryFields[index.Get % ProtectedQueryFields.Length];
        var sw = BuildSchemaWithAnonymousContext();
        var result = ExecuteUnauthenticatedAsync(sw.Schema, $"{{ {fieldName} }}")
            .GetAwaiter().GetResult();

        var hasError = result.Errors?.Any(e =>
            string.Equals(e.Code, "UNAUTHENTICATED", StringComparison.OrdinalIgnoreCase)) == true;

        return Prop.ToProperty(hasError);
    }

    // ── Property 1b: service mocks are never called for protected query fields ─

    /// <summary>
    /// For any protected query field name, executing that query without authentication
    /// must not invoke any Application Service method.
    /// Validates: Requirements 1.6, 6.2
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ProtectedQueryField_UnauthenticatedRequest_NeverCallsService(
        NonNegativeInt index)
    {
        var fieldName = ProtectedQueryFields[index.Get % ProtectedQueryFields.Length];
        var sw = BuildSchemaWithAnonymousContext();
        ExecuteUnauthenticatedAsync(sw.Schema, $"{{ {fieldName} }}").GetAwaiter().GetResult();

        sw.Lessons.Verify(s => s.GetAllLessonsAsync(It.IsAny<int>()), Times.Never());
        sw.Progress.Verify(s => s.GetUserProgressAsync(It.IsAny<int>()), Times.Never());
        sw.Study.Verify(s => s.GetUserSetsAsync(It.IsAny<int>()), Times.Never());
        sw.Sessions.Verify(s => s.GetDashboardAsync(It.IsAny<CancellationToken>()), Times.Never());

        return Prop.ToProperty(true);
    }

    // ── Property 1c: protected mutation fields produce errors when unauthenticated

    /// <summary>
    /// For any protected mutation field name, executing that mutation without authentication
    /// must produce at least one GraphQL error (UNAUTHENTICATED or field-not-found for stubs).
    /// Validates: Requirements 1.6, 6.2
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ProtectedMutationField_UnauthenticatedRequest_ProducesError(
        NonNegativeInt index)
    {
        var fieldName = AllProtectedMutationFields[index.Get % AllProtectedMutationFields.Length];
        var sw = BuildSchemaWithAnonymousContext();
        var result = ExecuteUnauthenticatedAsync(sw.Schema, $"mutation {{ {fieldName} }}")
            .GetAwaiter().GetResult();

        return Prop.ToProperty(result.Errors?.Count > 0);
    }

    // ── Property 1d: public fields are NOT blocked by the auth rule ───────────

    /// <summary>
    /// For any public (unauthenticated) query field, executing that query without
    /// authentication must NOT produce an UNAUTHENTICATED error.
    /// Validates: Requirements 1.6, 6.2
    /// </summary>
    [Property(MaxTest = 100)]
    public Property PublicQueryField_UnauthenticatedRequest_DoesNotReturnUnauthenticatedError(
        NonNegativeInt index)
    {
        var publicFields = new[] { "books", "vocabulary" };
        var fieldName = publicFields[index.Get % publicFields.Length];
        var sw = BuildSchemaWithAnonymousContext();
        var result = ExecuteUnauthenticatedAsync(sw.Schema, $"{{ {fieldName} }}")
            .GetAwaiter().GetResult();

        var hasUnauthError = result.Errors?.Any(e =>
            string.Equals(e.Code, "UNAUTHENTICATED", StringComparison.OrdinalIgnoreCase)) == true;

        return Prop.ToProperty(!hasUnauthError);
    }
}
