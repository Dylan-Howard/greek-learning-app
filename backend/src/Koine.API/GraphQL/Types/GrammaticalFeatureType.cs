using GraphQL.Types;
using Koine.Application.DTOs.Features;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="GrammaticalFeatureDto"/>.</summary>
public class GrammaticalFeatureType : ObjectGraphType<GrammaticalFeatureDto>
{
    public GrammaticalFeatureType()
    {
        Name = "GrammaticalFeature";
        Description = "A grammatical feature (e.g. tense, case, mood) associated with a word.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<StringGraphType>>("code").Resolve(ctx => ctx.Source.Code);
        Field<NonNullGraphType<StringGraphType>>("name").Resolve(ctx => ctx.Source.Name);
        Field<NonNullGraphType<StringGraphType>>("category").Resolve(ctx => ctx.Source.Category);
        Field<StringGraphType>("definition").Resolve(ctx => ctx.Source.Definition);
    }
}
