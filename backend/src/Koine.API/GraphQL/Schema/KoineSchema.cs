using Koine.API.GraphQL.Queries;
using Koine.API.GraphQL.Mutations;
using GraphQLSchema = GraphQL.Types.Schema;
using GraphQLIObjectGraphType = GraphQL.Types.IObjectGraphType;

namespace Koine.API.GraphQL.Schema;

/// <summary>
/// Root GraphQL schema wiring together the query and mutation entry points.
/// Registered as scoped via AddSchema so Query/Mutation are resolved from the
/// per-request DI scope, avoiding root-provider resolution of scoped services.
/// </summary>
public class KoineSchema : GraphQLSchema
{
    public KoineSchema(IServiceProvider provider) : base(provider)
    {
        Query = (GraphQLIObjectGraphType)provider.GetRequiredService(typeof(RootQuery));
        Mutation = (GraphQLIObjectGraphType)provider.GetRequiredService(typeof(RootMutation));
    }
}
