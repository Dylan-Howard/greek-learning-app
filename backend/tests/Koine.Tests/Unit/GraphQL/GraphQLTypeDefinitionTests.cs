using GraphQL.Types;
using Koine.API.GraphQL.Types;
using Koine.API.GraphQL.Types.InputTypes;
using Koine.API.GraphQL.Schema;
using Koine.API.GraphQL.Queries;
using Koine.API.GraphQL.Mutations;
using Koine.Application.Interfaces;
using Koine.Application.Study.Ports;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Unit tests for GraphQL type definitions.
/// Verifies that all expected types exist, have the correct field names,
/// and that non-nullable DTO fields are wrapped in NonNullGraphType.
/// Requirements: 4.1–4.9
/// </summary>
[TestFixture]
public class GraphQLTypeDefinitionTests
{
    // ── helpers ──────────────────────────────────────────────────────────────

    /// <summary>Returns true when the field's resolved type is NonNullGraphType.</summary>
    private static bool IsNonNull(FieldType field) =>
        field.Type is not null && IsNonNullType(field.Type);

    private static bool IsNonNullType(Type t) =>
        t.IsGenericType && t.GetGenericTypeDefinition() == typeof(NonNullGraphType<>);

    private static FieldType GetField(IComplexGraphType type, string name)
    {
        var field = type.Fields.FirstOrDefault(f => f.Name == name);
        Assert.That(field, Is.Not.Null, $"Expected field '{name}' on type '{type.Name}'");
        return field!;
    }

    // ── BookType ─────────────────────────────────────────────────────────────

    [Test]
    public void BookType_HasExpectedFields()
    {
        var type = new BookType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("id"));
            Assert.That(names, Does.Contain("title"));
            Assert.That(names, Does.Contain("languageCode"));
            Assert.That(names, Does.Contain("chapterCount"));
            Assert.That(names, Does.Contain("chapters"));
        });
    }

    [Test]
    public void BookType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new BookType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "Book.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "title")), Is.True, "Book.title must be non-null");
            Assert.That(IsNonNull(GetField(type, "languageCode")), Is.True, "Book.languageCode must be non-null");
            Assert.That(IsNonNull(GetField(type, "chapterCount")), Is.True, "Book.chapterCount must be non-null");
            Assert.That(IsNonNull(GetField(type, "chapters")), Is.True, "Book.chapters must be non-null");
        });
    }

    // ── ChapterType ───────────────────────────────────────────────────────────

    [Test]
    public void ChapterType_HasExpectedFields()
    {
        var type = new ChapterType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("id"));
            Assert.That(names, Does.Contain("bookId"));
            Assert.That(names, Does.Contain("chapterIndex"));
            Assert.That(names, Does.Contain("title"));
            Assert.That(names, Does.Contain("createdAt"));
            Assert.That(names, Does.Contain("words"));
        });
    }

    [Test]
    public void ChapterType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new ChapterType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "Chapter.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "bookId")), Is.True, "Chapter.bookId must be non-null");
            Assert.That(IsNonNull(GetField(type, "chapterIndex")), Is.True, "Chapter.chapterIndex must be non-null");
            Assert.That(IsNonNull(GetField(type, "createdAt")), Is.True, "Chapter.createdAt must be non-null");
            Assert.That(IsNonNull(GetField(type, "words")), Is.True, "Chapter.words must be non-null");
        });
    }

    // ── WordType ──────────────────────────────────────────────────────────────

    [Test]
    public void WordType_HasExpectedFields()
    {
        var type = new WordType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("id"));
            Assert.That(names, Does.Contain("root"));
            Assert.That(names, Does.Contain("gloss"));
        });
    }

    [Test]
    public void WordType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new WordType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "Word.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "root")), Is.True, "Word.root must be non-null");
            Assert.That(IsNonNull(GetField(type, "gloss")), Is.True, "Word.gloss must be non-null");
        });
    }

    // ── GrammaticalFeatureType ────────────────────────────────────────────────

    [Test]
    public void GrammaticalFeatureType_HasExpectedFields()
    {
        var type = new GrammaticalFeatureType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("id"));
            Assert.That(names, Does.Contain("code"));
        });
    }

    [Test]
    public void GrammaticalFeatureType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new GrammaticalFeatureType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "GrammaticalFeature.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "code")), Is.True, "GrammaticalFeature.code must be non-null");
        });
    }

    // ── SyntacticalFeatureType ────────────────────────────────────────────────

    [Test]
    public void SyntacticalFeatureType_HasExpectedFields()
    {
        var type = new SyntacticalFeatureType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("id"));
            Assert.That(names, Does.Contain("code"));
        });
    }

    [Test]
    public void SyntacticalFeatureType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new SyntacticalFeatureType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "SyntacticalFeature.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "code")), Is.True, "SyntacticalFeature.code must be non-null");
        });
    }

    // ── RenderedChapterType ───────────────────────────────────────────────────

    [Test]
    public void RenderedChapterType_HasExpectedFields()
    {
        var type = new RenderedChapterType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("chapterId"));
            Assert.That(names, Does.Contain("title"));
            Assert.That(names, Does.Contain("units"));
        });
    }

    [Test]
    public void RenderedChapterType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new RenderedChapterType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "chapterId")), Is.True, "RenderedChapter.chapterId must be non-null");
            Assert.That(IsNonNull(GetField(type, "title")), Is.True, "RenderedChapter.title must be non-null");
            Assert.That(IsNonNull(GetField(type, "units")), Is.True, "RenderedChapter.units must be non-null");
        });
    }

    // ── RenderedUnitType ──────────────────────────────────────────────────────

    [Test]
    public void RenderedUnitType_HasExpectedFields()
    {
        var type = new RenderedUnitType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("type"));
            Assert.That(names, Does.Contain("hints"));
            Assert.That(names, Does.Contain("gramFeatureIds"));
            Assert.That(names, Does.Contain("synFeatureIds"));
            Assert.That(names, Does.Contain("children"));
        });
    }

    [Test]
    public void RenderedUnitType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new RenderedUnitType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "type")), Is.True, "RenderedUnit.type must be non-null");
            Assert.That(IsNonNull(GetField(type, "hints")), Is.True, "RenderedUnit.hints must be non-null");
            Assert.That(IsNonNull(GetField(type, "gramFeatureIds")), Is.True, "RenderedUnit.gramFeatureIds must be non-null");
            Assert.That(IsNonNull(GetField(type, "synFeatureIds")), Is.True, "RenderedUnit.synFeatureIds must be non-null");
            Assert.That(IsNonNull(GetField(type, "children")), Is.True, "RenderedUnit.children must be non-null");
        });
    }

    // ── VocabularySetType ─────────────────────────────────────────────────────

    [Test]
    public void VocabularySetType_HasExpectedFields()
    {
        var type = new VocabularySetType();
        var names = type.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("id"));
            Assert.That(names, Does.Contain("title"));
            Assert.That(names, Does.Contain("items"));
        });
    }

    [Test]
    public void VocabularySetType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new VocabularySetType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "VocabularySet.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "title")), Is.True, "VocabularySet.title must be non-null");
            Assert.That(IsNonNull(GetField(type, "items")), Is.True, "VocabularySet.items must be non-null");
        });
    }

    // ── VocabularySetItemType ─────────────────────────────────────────────────

    [Test]
    public void VocabularySetItemType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new VocabularySetItemType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "VocabularySetItem.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "vocabularyId")), Is.True, "VocabularySetItem.vocabularyId must be non-null");
            Assert.That(IsNonNull(GetField(type, "root")), Is.True, "VocabularySetItem.root must be non-null");
            Assert.That(IsNonNull(GetField(type, "gloss")), Is.True, "VocabularySetItem.gloss must be non-null");
            Assert.That(IsNonNull(GetField(type, "masteryLevel")), Is.True, "VocabularySetItem.masteryLevel must be non-null");
        });
    }

    // ── SessionType ───────────────────────────────────────────────────────────

    [Test]
    public void SessionType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new SessionType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "Session.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "totalCards")), Is.True, "Session.totalCards must be non-null");
            Assert.That(IsNonNull(GetField(type, "cardsReviewed")), Is.True, "Session.cardsReviewed must be non-null");
            Assert.That(IsNonNull(GetField(type, "startedAt")), Is.True, "Session.startedAt must be non-null");
            Assert.That(IsNonNull(GetField(type, "pool")), Is.True, "Session.pool must be non-null");
            Assert.That(IsNonNull(GetField(type, "direction")), Is.True, "Session.direction must be non-null");
            Assert.That(IsNonNull(GetField(type, "mode")), Is.True, "Session.mode must be non-null");
        });
    }

    // ── CardType ──────────────────────────────────────────────────────────────

    [Test]
    public void CardType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new CardType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "sessionCardId")), Is.True, "Card.sessionCardId must be non-null");
            Assert.That(IsNonNull(GetField(type, "vocabularyId")), Is.True, "Card.vocabularyId must be non-null");
            Assert.That(IsNonNull(GetField(type, "position")), Is.True, "Card.position must be non-null");
            Assert.That(IsNonNull(GetField(type, "totalCards")), Is.True, "Card.totalCards must be non-null");
            Assert.That(IsNonNull(GetField(type, "front")), Is.True, "Card.front must be non-null");
            Assert.That(IsNonNull(GetField(type, "back")), Is.True, "Card.back must be non-null");
            Assert.That(IsNonNull(GetField(type, "interactionMode")), Is.True, "Card.interactionMode must be non-null");
            Assert.That(IsNonNull(GetField(type, "direction")), Is.True, "Card.direction must be non-null");
        });
    }

    // ── CardFrontType / CardBackType ──────────────────────────────────────────

    [Test]
    public void CardFrontType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new CardFrontType();
        Assert.That(IsNonNull(GetField(type, "root")), Is.True, "CardFront.root must be non-null");
    }

    [Test]
    public void CardBackType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new CardBackType();
        Assert.That(IsNonNull(GetField(type, "gloss")), Is.True, "CardBack.gloss must be non-null");
    }

    // ── RateCardResultType ────────────────────────────────────────────────────

    [Test]
    public void RateCardResultType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new RateCardResultType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "nextReviewDate")), Is.True, "RateCardResult.nextReviewDate must be non-null");
            Assert.That(IsNonNull(GetField(type, "scheduledDays")), Is.True, "RateCardResult.scheduledDays must be non-null");
            Assert.That(IsNonNull(GetField(type, "newState")), Is.True, "RateCardResult.newState must be non-null");
            Assert.That(IsNonNull(GetField(type, "sessionComplete")), Is.True, "RateCardResult.sessionComplete must be non-null");
        });
    }

    // ── SessionSummaryType ────────────────────────────────────────────────────

    [Test]
    public void SessionSummaryType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new SessionSummaryType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "totalReviewed")), Is.True, "SessionSummary.totalReviewed must be non-null");
            Assert.That(IsNonNull(GetField(type, "correctCount")), Is.True, "SessionSummary.correctCount must be non-null");
            Assert.That(IsNonNull(GetField(type, "correctPercentage")), Is.True, "SessionSummary.correctPercentage must be non-null");
            Assert.That(IsNonNull(GetField(type, "xpGained")), Is.True, "SessionSummary.xpGained must be non-null");
            Assert.That(IsNonNull(GetField(type, "totalExperience")), Is.True, "SessionSummary.totalExperience must be non-null");
            Assert.That(IsNonNull(GetField(type, "firstCompletionReward")), Is.True, "SessionSummary.firstCompletionReward must be non-null");
        });
    }

    // ── DashboardType ─────────────────────────────────────────────────────────

    [Test]
    public void DashboardType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new DashboardType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "totalCards")), Is.True, "Dashboard.totalCards must be non-null");
            Assert.That(IsNonNull(GetField(type, "dueToday")), Is.True, "Dashboard.dueToday must be non-null");
            Assert.That(IsNonNull(GetField(type, "newCards")), Is.True, "Dashboard.newCards must be non-null");
            Assert.That(IsNonNull(GetField(type, "currentStreak")), Is.True, "Dashboard.currentStreak must be non-null");
            Assert.That(IsNonNull(GetField(type, "reviewHistory")), Is.True, "Dashboard.reviewHistory must be non-null");
        });
    }

    // ── ReviewHistoryPointType ────────────────────────────────────────────────

    [Test]
    public void ReviewHistoryPointType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new ReviewHistoryPointType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "date")), Is.True, "ReviewHistoryPoint.date must be non-null");
            Assert.That(IsNonNull(GetField(type, "count")), Is.True, "ReviewHistoryPoint.count must be non-null");
        });
    }

    // ── UserProgressType ──────────────────────────────────────────────────────

    [Test]
    public void UserProgressType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new UserProgressType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "completedLessonIds")), Is.True, "UserProgress.completedLessonIds must be non-null");
            Assert.That(IsNonNull(GetField(type, "totalExperience")), Is.True, "UserProgress.totalExperience must be non-null");
            Assert.That(IsNonNull(GetField(type, "updatedAt")), Is.True, "UserProgress.updatedAt must be non-null");
        });
    }

    // ── LessonType ────────────────────────────────────────────────────────────

    [Test]
    public void LessonType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new LessonType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "Lesson.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "trackId")), Is.True, "Lesson.trackId must be non-null");
            Assert.That(IsNonNull(GetField(type, "slug")), Is.True, "Lesson.slug must be non-null");
            Assert.That(IsNonNull(GetField(type, "title")), Is.True, "Lesson.title must be non-null");
            Assert.That(IsNonNull(GetField(type, "lessonIndex")), Is.True, "Lesson.lessonIndex must be non-null");
            Assert.That(IsNonNull(GetField(type, "contentMarkdown")), Is.True, "Lesson.contentMarkdown must be non-null");
            Assert.That(IsNonNull(GetField(type, "lessonType")), Is.True, "Lesson.lessonType must be non-null");
            Assert.That(IsNonNull(GetField(type, "isCompleted")), Is.True, "Lesson.isCompleted must be non-null");
        });
    }

    // ── LessonTrackType ───────────────────────────────────────────────────────

    [Test]
    public void LessonTrackType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new LessonTrackType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "id")), Is.True, "LessonTrack.id must be non-null");
            Assert.That(IsNonNull(GetField(type, "slug")), Is.True, "LessonTrack.slug must be non-null");
            Assert.That(IsNonNull(GetField(type, "title")), Is.True, "LessonTrack.title must be non-null");
            Assert.That(IsNonNull(GetField(type, "lessons")), Is.True, "LessonTrack.lessons must be non-null");
        });
    }

    // ── LessonCompletionResultType ────────────────────────────────────────────

    [Test]
    public void LessonCompletionResultType_NonNullableFields_AreWrappedInNonNull()
    {
        var type = new LessonCompletionResultType();
        Assert.Multiple(() =>
        {
            Assert.That(IsNonNull(GetField(type, "message")), Is.True, "LessonCompletionResult.message must be non-null");
            Assert.That(IsNonNull(GetField(type, "xpGained")), Is.True, "LessonCompletionResult.xpGained must be non-null");
            Assert.That(IsNonNull(GetField(type, "totalExperience")), Is.True, "LessonCompletionResult.totalExperience must be non-null");
            Assert.That(IsNonNull(GetField(type, "firstCompletion")), Is.True, "LessonCompletionResult.firstCompletion must be non-null");
        });
    }

    // ── Schema type registration ──────────────────────────────────────────────
    // Build a minimal KoineSchema via ServiceProvider and verify all expected
    // named types are reachable through schema introspection.

    private static KoineSchema BuildSchema()
    {
        var services = new ServiceCollection();

        // Register all GraphQL object types
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

        // Register input types
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
        services.AddSingleton<VocabularyResultType>();

        // Register RootQuery service dependencies as mocks
        services.AddSingleton(new Mock<IBookService>().Object);
        services.AddSingleton(new Mock<IChapterService>().Object);
        services.AddSingleton(new Mock<IVocabularyService>().Object);
        services.AddSingleton(new Mock<IReaderService>().Object);
        services.AddSingleton(new Mock<ILessonService>().Object);
        services.AddSingleton(new Mock<IProgressService>().Object);
        services.AddSingleton(new Mock<IStudyService>().Object);
        services.AddSingleton(new Mock<IStudySessionService>().Object);
        services.AddSingleton(new Mock<IHttpContextAccessor>().Object);

        // Register root types and schema
        services.AddSingleton<RootQuery>();
        services.AddSingleton<RootMutation>();
        services.AddSingleton<KoineSchema>();

        var provider = services.BuildServiceProvider();
        return provider.GetRequiredService<KoineSchema>();
    }

    [Test]
    public void Schema_RegistersAllExpectedObjectTypes()
    {
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
        services.AddSingleton(new Mock<IBookService>().Object);
        services.AddSingleton(new Mock<IChapterService>().Object);
        services.AddSingleton(new Mock<IVocabularyService>().Object);
        services.AddSingleton(new Mock<IReaderService>().Object);
        services.AddSingleton(new Mock<ILessonService>().Object);
        services.AddSingleton(new Mock<IProgressService>().Object);
        services.AddSingleton(new Mock<IStudyService>().Object);
        services.AddSingleton(new Mock<IStudySessionService>().Object);
        services.AddSingleton(new Mock<IHttpContextAccessor>().Object);
        services.AddSingleton<RootQuery>();
        services.AddSingleton<RootMutation>();
        services.AddSingleton<KoineSchema>();

        var provider = services.BuildServiceProvider();
        var schema = provider.GetRequiredService<KoineSchema>();
        // This mirrors the AddGraphTypes() call in Program.cs.
        schema.RegisterType(provider.GetRequiredService<BookType>());
        schema.RegisterType(provider.GetRequiredService<ChapterType>());
        schema.RegisterType(provider.GetRequiredService<WordType>());
        schema.RegisterType(provider.GetRequiredService<GrammaticalFeatureType>());
        schema.RegisterType(provider.GetRequiredService<SyntacticalFeatureType>());
        schema.RegisterType(provider.GetRequiredService<RenderedChapterType>());
        schema.RegisterType(provider.GetRequiredService<RenderedUnitType>());
        schema.RegisterType(provider.GetRequiredService<VocabularySetType>());
        schema.RegisterType(provider.GetRequiredService<VocabularySetItemType>());
        schema.RegisterType(provider.GetRequiredService<SessionType>());
        schema.RegisterType(provider.GetRequiredService<CardType>());
        schema.RegisterType(provider.GetRequiredService<CardFrontType>());
        schema.RegisterType(provider.GetRequiredService<CardBackType>());
        schema.RegisterType(provider.GetRequiredService<RateCardResultType>());
        schema.RegisterType(provider.GetRequiredService<SessionSummaryType>());
        schema.RegisterType(provider.GetRequiredService<DashboardType>());
        schema.RegisterType(provider.GetRequiredService<ReviewHistoryPointType>());
        schema.RegisterType(provider.GetRequiredService<UserProgressType>());
        schema.RegisterType(provider.GetRequiredService<LessonType>());
        schema.RegisterType(provider.GetRequiredService<LessonTrackType>());
        schema.RegisterType(provider.GetRequiredService<LessonCompletionResultType>());

        schema.Initialize();

        var typeNames = schema.AllTypes.Select(t => t.Name).ToHashSet();

        var expected = new[]
        {
            "Book", "Chapter", "Word", "RenderedChapter", "RenderedUnit",
            "VocabularySet", "VocabularySetItem",
            "Session", "Card", "CardFront", "CardBack",
            "RateCardResult", "SessionSummary",
            "Dashboard", "ReviewHistoryPoint",
            "GrammaticalFeature", "SyntacticalFeature",
            "UserProgress", "Lesson", "LessonTrack", "LessonCompletionResult"
        };

        Assert.Multiple(() =>
        {
            foreach (var name in expected)
                Assert.That(typeNames, Does.Contain(name), $"Schema should contain type '{name}'");
        });
    }

    [Test]
    public void Schema_QueryType_HasName_Query()
    {
        var schema = BuildSchema();
        schema.Initialize();
        Assert.That(schema.Query.Name, Is.EqualTo("Query"));
    }

    [Test]
    public void Schema_MutationType_HasName_Mutation()
    {
        var schema = BuildSchema();
        schema.Initialize();
        Assert.That(schema.Mutation?.Name, Is.EqualTo("Mutation"));
    }

    [Test]
    public void Schema_TypeNames_AreCorrectlyNamed()
    {
        // Verify the Name property on each type matches the SDL name (not the C# class name)
        Assert.Multiple(() =>
        {
            Assert.That(new BookType().Name, Is.EqualTo("Book"));
            Assert.That(new ChapterType().Name, Is.EqualTo("Chapter"));
            Assert.That(new WordType().Name, Is.EqualTo("Word"));
            Assert.That(new GrammaticalFeatureType().Name, Is.EqualTo("GrammaticalFeature"));
            Assert.That(new SyntacticalFeatureType().Name, Is.EqualTo("SyntacticalFeature"));
            Assert.That(new RenderedChapterType().Name, Is.EqualTo("RenderedChapter"));
            Assert.That(new RenderedUnitType().Name, Is.EqualTo("RenderedUnit"));
            Assert.That(new VocabularySetType().Name, Is.EqualTo("VocabularySet"));
            Assert.That(new VocabularySetItemType().Name, Is.EqualTo("VocabularySetItem"));
            Assert.That(new SessionType().Name, Is.EqualTo("Session"));
            Assert.That(new CardType().Name, Is.EqualTo("Card"));
            Assert.That(new CardFrontType().Name, Is.EqualTo("CardFront"));
            Assert.That(new CardBackType().Name, Is.EqualTo("CardBack"));
            Assert.That(new RateCardResultType().Name, Is.EqualTo("RateCardResult"));
            Assert.That(new SessionSummaryType().Name, Is.EqualTo("SessionSummary"));
            Assert.That(new DashboardType().Name, Is.EqualTo("Dashboard"));
            Assert.That(new ReviewHistoryPointType().Name, Is.EqualTo("ReviewHistoryPoint"));
            Assert.That(new UserProgressType().Name, Is.EqualTo("UserProgress"));
            Assert.That(new LessonType().Name, Is.EqualTo("Lesson"));
            Assert.That(new LessonTrackType().Name, Is.EqualTo("LessonTrack"));
            Assert.That(new LessonCompletionResultType().Name, Is.EqualTo("LessonCompletionResult"));
        });
    }
}
