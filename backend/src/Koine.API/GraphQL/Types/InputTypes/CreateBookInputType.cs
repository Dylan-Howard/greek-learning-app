using GraphQL.Types;
using Koine.Application.DTOs.Books;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="CreateBookDto"/>.</summary>
public class CreateBookInputType : InputObjectGraphType<CreateBookDto>
{
    public CreateBookInputType()
    {
        Name = "CreateBookInput";
        Description = "Input for creating a new book in the corpus.";

        Field<NonNullGraphType<StringGraphType>>("title")
            .Description("Display title of the book.");
        Field<NonNullGraphType<StringGraphType>>("languageCode")
            .Description("BCP-47 language code (e.g. 'grc' for Ancient Greek).");
    }
}
