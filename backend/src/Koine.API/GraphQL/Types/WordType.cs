using GraphQL.Types;
using Koine.Application.DTOs.Vocabulary;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="VocabularyDto"/>.</summary>
public class WordType : ObjectGraphType<VocabularyDto>
{
    public WordType()
    {
        Name = "Word";
        Description = "A vocabulary word with its gloss and grammatical metadata.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<StringGraphType>>("root").Resolve(ctx => ctx.Source.Root);
        Field<StringGraphType>("transliteration").Resolve(ctx => ctx.Source.Transliteration);
        Field<NonNullGraphType<StringGraphType>>("gloss").Resolve(ctx => ctx.Source.Gloss);
        Field<StringGraphType>("partOfSpeech").Resolve(ctx => ctx.Source.PartOfSpeech);
        Field<IntGraphType>("occurrences").Resolve(ctx => ctx.Source.Occurrences);
    }
}
