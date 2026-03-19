using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="CardDto"/>.</summary>
public class CardType : ObjectGraphType<CardDto>
{
    public CardType()
    {
        Name = "Card";
        Description = "A flashcard presented during a study session.";

        Field<NonNullGraphType<IntGraphType>>("sessionCardId").Resolve(ctx => ctx.Source.SessionCardId);
        Field<NonNullGraphType<IntGraphType>>("vocabularyId").Resolve(ctx => ctx.Source.VocabularyId);
        Field<NonNullGraphType<IntGraphType>>("position").Resolve(ctx => ctx.Source.Position);
        Field<NonNullGraphType<IntGraphType>>("totalCards").Resolve(ctx => ctx.Source.TotalCards);
        Field<NonNullGraphType<CardFrontType>>("front").Resolve(ctx => ctx.Source.Front);
        Field<NonNullGraphType<CardBackType>>("back").Resolve(ctx => ctx.Source.Back);
        Field<NonNullGraphType<StringGraphType>>("interactionMode")
            .Resolve(ctx => ctx.Source.InteractionMode.ToString());
        Field<NonNullGraphType<StringGraphType>>("direction")
            .Resolve(ctx => ctx.Source.Direction.ToString());
        Field<ListGraphType<NonNullGraphType<StringGraphType>>>("choices")
            .Resolve(ctx => ctx.Source.Choices);
    }
}
