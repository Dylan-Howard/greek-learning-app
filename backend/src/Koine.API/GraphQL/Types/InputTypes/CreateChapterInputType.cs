using GraphQL.Types;
using Koine.Application.DTOs.Chapters;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="CreateChapterDto"/>.</summary>
public class CreateChapterInputType : InputObjectGraphType<CreateChapterDto>
{
    public CreateChapterInputType()
    {
        Name = "CreateChapterInput";
        Description = "Input for creating a new chapter within a book.";

        Field<NonNullGraphType<IntGraphType>>("chapterIndex")
            .Description("1-based position of the chapter within the book.");
        Field<StringGraphType>("title")
            .Description("Optional display title for the chapter.");
    }
}
