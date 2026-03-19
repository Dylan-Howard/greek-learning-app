using Koine.API.GraphQL.Queries;
using Koine.API.GraphQL.Mutations;

namespace Koine.API.GraphQL.Schema;

/// <summary>
/// Root GraphQL schema wiring together the query and mutation entry points.
/// </summary>
public class KoineSchema : global::GraphQL.Types.Schema
{
    public KoineSchema(IServiceProvider provider) : base(provider)
    {
        Query = provider.GetRequiredService<RootQuery>();
        Mutation = provider.GetRequiredService<RootMutation>();
    }
}
