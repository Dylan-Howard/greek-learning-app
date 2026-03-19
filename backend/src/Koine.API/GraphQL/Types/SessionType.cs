using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="SessionDto"/>.</summary>
public class SessionType : ObjectGraphType<SessionDto>
{
    public SessionType()
    {
        Name = "Session";
        Description = "An active or completed spaced-repetition study session.";

        Field<NonNullGraphType<IdGraphType>>("id").Resolve(ctx => ctx.Source.Id.ToString());
        Field<NonNullGraphType<IntGraphType>>("totalCards").Resolve(ctx => ctx.Source.TotalCards);
        Field<NonNullGraphType<IntGraphType>>("cardsReviewed").Resolve(ctx => ctx.Source.CardsReviewed);
        Field<NonNullGraphType<StringGraphType>>("startedAt")
            .Resolve(ctx => ctx.Source.StartedAt.ToString("O"));
        Field<StringGraphType>("completedAt")
            .Resolve(ctx => ctx.Source.CompletedAt?.ToString("O"));
        // Enum values serialised as strings to match JSON convention
        Field<NonNullGraphType<StringGraphType>>("pool")
            .Resolve(ctx => ctx.Source.Pool.ToString());
        Field<NonNullGraphType<StringGraphType>>("direction")
            .Resolve(ctx => ctx.Source.Direction.ToString());
        Field<NonNullGraphType<StringGraphType>>("mode")
            .Resolve(ctx => ctx.Source.Mode.ToString());
        Field<IntGraphType>("vocabularySetId").Resolve(ctx => ctx.Source.VocabularySetId);
    }
}
