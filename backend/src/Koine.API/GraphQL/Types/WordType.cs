using GraphQL.Types;
using Koine.Application.DTOs.Vocabulary;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="SimpleWordDto"/>.</summary>
public class WordType : ObjectGraphType<SimpleWordDto>
{
    public WordType()
    {
        Name = "Word";
        Description = "A vocabulary word with its gloss and occurrence count.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.RootId);
        Field<NonNullGraphType<StringGraphType>>("root").Resolve(ctx => ctx.Source.Content);
        Field<NonNullGraphType<StringGraphType>>("gloss").Resolve(ctx => ctx.Source.Gloss ?? string.Empty);
        Field<NonNullGraphType<IntGraphType>>("occurrences").Resolve(ctx => ctx.Source.Occurrences);
    }
}
