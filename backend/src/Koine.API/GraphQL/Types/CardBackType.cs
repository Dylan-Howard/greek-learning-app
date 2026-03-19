using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="CardDto.CardBack"/>.</summary>
public class CardBackType : ObjectGraphType<CardDto.CardBack>
{
    public CardBackType()
    {
        Name = "CardBack";
        Description = "The back (answer) side of a flashcard.";

        Field<NonNullGraphType<StringGraphType>>("gloss").Resolve(ctx => ctx.Source.Gloss);
    }
}
