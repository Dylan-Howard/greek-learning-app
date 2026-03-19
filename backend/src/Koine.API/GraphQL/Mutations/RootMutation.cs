using GraphQL.Types;

namespace Koine.API.GraphQL.Mutations;

/// <summary>
/// Root mutation type — aggregates all domain write operations.
/// Fields are added incrementally in subsequent tasks.
/// </summary>
public class RootMutation : ObjectGraphType
{
    public RootMutation()
    {
        Name = "Mutation";
        Description = "Root mutation type for the Koine GraphQL API.";

        // Stub field required to produce a valid schema (a schema must have at least one mutation field).
        Field<BooleanGraphType>("_noop")
            .Description("No-op stub — replaced by real mutations in subsequent tasks.")
            .Resolve(_ => true);
    }
}
