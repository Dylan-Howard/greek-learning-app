using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="SessionSummaryDto"/>.</summary>
public class SessionSummaryType : ObjectGraphType<SessionSummaryDto>
{
    public SessionSummaryType()
    {
        Name = "SessionSummary";
        Description = "Summary statistics returned when a study session is completed.";

        Field<NonNullGraphType<IntGraphType>>("totalReviewed").Resolve(ctx => ctx.Source.TotalReviewed);
        Field<NonNullGraphType<IntGraphType>>("correctCount").Resolve(ctx => ctx.Source.CorrectCount);
        Field<NonNullGraphType<FloatGraphType>>("correctPercentage").Resolve(ctx => ctx.Source.CorrectPercentage);
        Field<NonNullGraphType<IntGraphType>>("xpGained").Resolve(ctx => ctx.Source.XpGained);
        Field<NonNullGraphType<IntGraphType>>("totalExperience").Resolve(ctx => ctx.Source.TotalExperience);
        Field<NonNullGraphType<BooleanGraphType>>("firstCompletionReward")
            .Resolve(ctx => ctx.Source.FirstCompletionReward);
    }
}
