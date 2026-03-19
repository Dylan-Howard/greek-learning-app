using GraphQL.Types;
using Koine.Application.DTOs.Books;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="UpdateBookDto"/>.</summary>
public class UpdateBookInputType : InputObjectGraphType<UpdateBookDto>
{
    public UpdateBookInputType()
    {
        Name = "UpdateBookInput";
        Description = "Input for updating an existing book. All fields are optional.";

        Field<StringGraphType>("title")
            .Description("New display title for the book.");
        Field<StringGraphType>("languageCode")
            .Description("New BCP-47 language code.");
    }
}
