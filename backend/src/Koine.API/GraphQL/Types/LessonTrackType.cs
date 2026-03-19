using GraphQL.Types;
using Koine.Application.DTOs.Lessons;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="LessonTrackDto"/>.</summary>
public class LessonTrackType : ObjectGraphType<LessonTrackDto>
{
    public LessonTrackType()
    {
        Name = "LessonTrack";
        Description = "An ordered collection of lessons forming a study track.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<StringGraphType>>("slug").Resolve(ctx => ctx.Source.Slug);
        Field<NonNullGraphType<StringGraphType>>("title").Resolve(ctx => ctx.Source.Title);
        Field<NonNullGraphType<StringGraphType>>("description").Resolve(ctx => ctx.Source.Description);
        Field<NonNullGraphType<IntGraphType>>("sortOrder").Resolve(ctx => ctx.Source.SortOrder);
        Field<NonNullGraphType<IntGraphType>>("totalLessons").Resolve(ctx => ctx.Source.TotalLessons);
        Field<NonNullGraphType<IntGraphType>>("completedLessons").Resolve(ctx => ctx.Source.CompletedLessons);
        Field<NonNullGraphType<FloatGraphType>>("percentComplete")
            .Resolve(ctx => (double)ctx.Source.PercentComplete);
        Field<IntGraphType>("nextLessonId").Resolve(ctx => ctx.Source.NextLessonId);
        Field<StringGraphType>("nextLessonSlug").Resolve(ctx => ctx.Source.NextLessonSlug);
        Field<StringGraphType>("nextLessonTitle").Resolve(ctx => ctx.Source.NextLessonTitle);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<LessonType>>>>("lessons")
            .Resolve(ctx => ctx.Source.Lessons);
    }
}
