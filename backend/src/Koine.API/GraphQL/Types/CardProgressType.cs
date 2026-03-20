using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="CardProgressDto"/>.</summary>
public class CardProgressType : ObjectGraphType<CardProgressDto>
{
    public CardProgressType()
    {
        Name = "CardProgress";
        Description = "Spaced-repetition progress record for a single vocabulary card.";

        Field<NonNullGraphType<IntGraphType>>("vocabularyId").Resolve(ctx => ctx.Source.VocabularyId);
        Field<NonNullGraphType<StringGraphType>>("root").Resolve(ctx => ctx.Source.Root);
        Field<NonNullGraphType<StringGraphType>>("gloss").Resolve(ctx => ctx.Source.Gloss);
        Field<NonNullGraphType<StringGraphType>>("state").Resolve(ctx => ctx.Source.State.ToString());
        Field<NonNullGraphType<FloatGraphType>>("difficulty").Resolve(ctx => (double)ctx.Source.Difficulty);
        Field<NonNullGraphType<FloatGraphType>>("stability").Resolve(ctx => (double)ctx.Source.Stability);
        Field<NonNullGraphType<StringGraphType>>("nextReviewDate")
            .Resolve(ctx => ctx.Source.NextReviewDate.ToString("O"));
        Field<NonNullGraphType<IntGraphType>>("reviewCount").Resolve(ctx => ctx.Source.ReviewCount);
        Field<NonNullGraphType<IntGraphType>>("lapses").Resolve(ctx => ctx.Source.Lapses);
    }
}
