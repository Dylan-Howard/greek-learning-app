using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="CardDto.CardFront"/>.</summary>
public class CardFrontType : ObjectGraphType<CardDto.CardFront>
{
    public CardFrontType()
    {
        Name = "CardFront";
        Description = "The front (prompt) side of a flashcard.";

        Field<NonNullGraphType<StringGraphType>>("root").Resolve(ctx => ctx.Source.Root);
        Field<StringGraphType>("transliteration").Resolve(ctx => ctx.Source.Transliteration);
        Field<StringGraphType>("partOfSpeech").Resolve(ctx => ctx.Source.PartOfSpeech);
        Field<IntGraphType>("occurrences").Resolve(ctx => ctx.Source.Occurrences);
    }
}
