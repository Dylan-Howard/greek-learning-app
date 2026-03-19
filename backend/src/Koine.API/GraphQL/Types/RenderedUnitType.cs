using GraphQL.Types;
using Koine.Application.DTOs.Reader;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="RenderedUnitDto"/>.</summary>
public class RenderedUnitType : ObjectGraphType<RenderedUnitDto>
{
    public RenderedUnitType()
    {
        Name = "RenderedUnit";
        Description = "A single rendered unit node within a chapter (word, phrase, or structural marker).";

        Field<NonNullGraphType<StringGraphType>>("type").Resolve(ctx => ctx.Source.Type);
        Field<StringGraphType>("text").Resolve(ctx => ctx.Source.Text);
        Field<StringGraphType>("original").Resolve(ctx => ctx.Source.Original);
        Field<StringGraphType>("path").Resolve(ctx => ctx.Source.Path);
        Field<StringGraphType>("marker").Resolve(ctx => ctx.Source.Marker);
        Field<IntGraphType>("vocabId").Resolve(ctx => ctx.Source.VocabId);

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<StringGraphType>>>>("hints")
            .Resolve(ctx => ctx.Source.Hints ?? new List<string>());

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("gramFeatureIds")
            .Resolve(ctx => ctx.Source.GramFeatureIds ?? new List<int>());

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("synFeatureIds")
            .Resolve(ctx => ctx.Source.SynFeatureIds ?? new List<int>());

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<RenderedUnitType>>>>("children")
            .Resolve(ctx => ctx.Source.Children ?? new List<RenderedUnitDto>());
    }
}
