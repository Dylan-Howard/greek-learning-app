using GraphQL.Types;
using Koine.Application.DTOs.Lessons;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="LessonDto"/>.</summary>
public class LessonType : ObjectGraphType<LessonDto>
{
    public LessonType()
    {
        Name = "Lesson";
        Description = "A single lesson within a lesson track.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<IntGraphType>>("trackId").Resolve(ctx => ctx.Source.TrackId);
        Field<NonNullGraphType<StringGraphType>>("trackSlug").Resolve(ctx => ctx.Source.TrackSlug);
        Field<NonNullGraphType<StringGraphType>>("slug").Resolve(ctx => ctx.Source.Slug);
        Field<NonNullGraphType<StringGraphType>>("title").Resolve(ctx => ctx.Source.Title);
        Field<NonNullGraphType<IntGraphType>>("lessonIndex").Resolve(ctx => ctx.Source.LessonIndex);
        Field<NonNullGraphType<StringGraphType>>("contentMarkdown").Resolve(ctx => ctx.Source.ContentMarkdown);
        Field<NonNullGraphType<StringGraphType>>("lessonType").Resolve(ctx => ctx.Source.LessonType);
        Field<NonNullGraphType<BooleanGraphType>>("isCompleted").Resolve(ctx => ctx.Source.IsCompleted);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("grammaticalFeatureIds")
            .Resolve(ctx => ctx.Source.GrammaticalFeatureIds);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("syntacticalFeatureIds")
            .Resolve(ctx => ctx.Source.SyntacticalFeatureIds);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("vocabularyIds")
            .Resolve(ctx => ctx.Source.VocabularyIds);
    }
}
