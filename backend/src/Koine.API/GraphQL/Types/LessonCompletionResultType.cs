using GraphQL.Types;
using Koine.Application.DTOs.Lessons;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="LessonCompletionResponseDto"/>.</summary>
public class LessonCompletionResultType : ObjectGraphType<LessonCompletionResponseDto>
{
    public LessonCompletionResultType()
    {
        Name = "LessonCompletionResult";
        Description = "Result returned after a user completes a lesson.";

        Field<NonNullGraphType<StringGraphType>>("message").Resolve(ctx => ctx.Source.Message);
        Field<NonNullGraphType<IntGraphType>>("xpGained").Resolve(ctx => ctx.Source.XpGained);
        Field<NonNullGraphType<IntGraphType>>("totalExperience").Resolve(ctx => ctx.Source.TotalExperience);
        Field<NonNullGraphType<BooleanGraphType>>("firstCompletion").Resolve(ctx => ctx.Source.FirstCompletion);
    }
}
