using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="ReviewHistoryDto"/>.</summary>
public class ReviewHistoryPointType : ObjectGraphType<ReviewHistoryDto>
{
    public ReviewHistoryPointType()
    {
        Name = "ReviewHistoryPoint";
        Description = "The number of cards reviewed on a specific date.";

        Field<NonNullGraphType<StringGraphType>>("date")
            .Resolve(ctx => ctx.Source.Date.ToString("O"));
        Field<NonNullGraphType<IntGraphType>>("count").Resolve(ctx => ctx.Source.Count);
    }
}
