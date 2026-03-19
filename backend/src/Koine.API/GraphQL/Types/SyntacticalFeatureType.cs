using GraphQL.Types;
using Koine.Application.DTOs.Features;

namespace Koine.API.GraphQL.Types;

/// <summary>GraphQL object type for <see cref="SyntacticalFeatureDto"/>.</summary>
public class SyntacticalFeatureType : ObjectGraphType<SyntacticalFeatureDto>
{
    public SyntacticalFeatureType()
    {
        Name = "SyntacticalFeature";
        Description = "A syntactical feature (e.g. clause type, function) associated with a unit.";

        Field<NonNullGraphType<IntGraphType>>("id").Resolve(ctx => ctx.Source.Id);
        Field<NonNullGraphType<StringGraphType>>("code").Resolve(ctx => ctx.Source.Code);
        Field<NonNullGraphType<StringGraphType>>("name").Resolve(ctx => ctx.Source.Name);
        Field<StringGraphType>("definition").Resolve(ctx => ctx.Source.Definition);
    }
}
