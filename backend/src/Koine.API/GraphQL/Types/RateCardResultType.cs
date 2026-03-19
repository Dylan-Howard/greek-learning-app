using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="RateCardResponse"/>.</summary>
public class RateCardResultType : ObjectGraphType<RateCardResponse>
{
    public RateCardResultType()
    {
        Name = "RateCardResult";
        Description = "Result returned after rating a flashcard, including the next scheduled review.";

        Field<NonNullGraphType<StringGraphType>>("nextReviewDate")
            .Resolve(ctx => ctx.Source.NextReviewDate.ToString("O"));
        Field<NonNullGraphType<FloatGraphType>>("scheduledDays")
            .Resolve(ctx => (double)ctx.Source.ScheduledDays);
        Field<NonNullGraphType<StringGraphType>>("newState")
            .Resolve(ctx => ctx.Source.NewState.ToString());
        Field<NonNullGraphType<BooleanGraphType>>("sessionComplete")
            .Resolve(ctx => ctx.Source.SessionComplete);
    }
}
