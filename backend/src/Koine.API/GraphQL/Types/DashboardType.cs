using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="DashboardDto"/>.</summary>
public class DashboardType : ObjectGraphType<DashboardDto>
{
    public DashboardType()
    {
        Name = "Dashboard";
        Description = "Study dashboard showing card counts and review history for the current user.";

        Field<NonNullGraphType<IntGraphType>>("totalCards").Resolve(ctx => ctx.Source.TotalCards);
        Field<NonNullGraphType<IntGraphType>>("dueToday").Resolve(ctx => ctx.Source.DueToday);
        Field<NonNullGraphType<IntGraphType>>("newCards").Resolve(ctx => ctx.Source.NewCards);
        Field<NonNullGraphType<IntGraphType>>("learningCards").Resolve(ctx => ctx.Source.LearningCards);
        Field<NonNullGraphType<IntGraphType>>("reviewCards").Resolve(ctx => ctx.Source.ReviewCards);
        Field<NonNullGraphType<IntGraphType>>("relearningCards").Resolve(ctx => ctx.Source.RelearningCards);
        Field<NonNullGraphType<IntGraphType>>("currentStreak").Resolve(ctx => ctx.Source.CurrentStreak);
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<ReviewHistoryPointType>>>>("reviewHistory")
            .Resolve(ctx => ctx.Source.ReviewHistory);
    }
}
