using GraphQL.Types;
using Koine.Application.DTOs.Study;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="VocabularySetItemDto"/>.</summary>
public class VocabularySetItemType : ObjectGraphType<VocabularySetItemDto>
{
    public VocabularySetItemType()
    {
        Name = "VocabularySetItem";
        Description = "A single vocabulary item within a vocabulary set, including mastery state.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<IntGraphType>>("vocabularyId").Resolve(ctx => ctx.Source.VocabularyId);
        Field<NonNullGraphType<StringGraphType>>("root").Resolve(ctx => ctx.Source.Root);
        Field<NonNullGraphType<StringGraphType>>("gloss").Resolve(ctx => ctx.Source.Gloss);
        Field<NonNullGraphType<IntGraphType>>("masteryLevel").Resolve(ctx => ctx.Source.MasteryLevel);
        Field<StringGraphType>("lastSeen")
            .Resolve(ctx => ctx.Source.LastSeen?.ToString("O"));
    }
}
