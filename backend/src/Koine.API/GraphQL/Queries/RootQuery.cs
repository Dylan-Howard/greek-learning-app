using GraphQL.Types;

namespace Koine.API.GraphQL.Queries;

/// <summary>
/// Root query type — aggregates all domain query fields.
/// Fields are added incrementally in subsequent tasks.
/// </summary>
public class RootQuery : ObjectGraphType
{
    public RootQuery()
    {
        Name = "Query";
        Description = "Root query type for the Koine GraphQL API.";

        // Stub field required to produce a valid schema (a schema must have at least one query field).
        Field<StringGraphType>("_version")
            .Description("API version stub — replaced by real fields in subsequent tasks.")
            .Resolve(_ => "1.0");
    }
}
