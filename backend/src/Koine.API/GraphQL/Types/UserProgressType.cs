using GraphQL.Types;
using Koine.Application.DTOs.Progress;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="UserProgressDto"/>.</summary>
public class UserProgressType : ObjectGraphType<UserProgressDto>
{
    public UserProgressType()
    {
        Name = "UserProgress";
        Description = "Aggregated progress record for an authenticated user.";

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("completedLessonIds")
            .Resolve(ctx => ctx.Source.CompletedLessonIds);
        Field<NonNullGraphType<IntGraphType>>("totalExperience").Resolve(ctx => ctx.Source.TotalExperience);
        Field<NonNullGraphType<StringGraphType>>("updatedAt")
            .Resolve(ctx => ctx.Source.UpdatedAt.ToString("O"));
    }
}
