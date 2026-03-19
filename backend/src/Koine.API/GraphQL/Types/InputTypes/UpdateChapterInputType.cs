using GraphQL.Types;
using Koine.Application.DTOs.Chapters;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="UpdateChapterDto"/>.</summary>
public class UpdateChapterInputType : InputObjectGraphType<UpdateChapterDto>
{
    public UpdateChapterInputType()
    {
        Name = "UpdateChapterInput";
        Description = "Input for updating an existing chapter. All fields are optional.";

        Field<IntGraphType>("chapterIndex")
            .Description("New 1-based position of the chapter within the book.");
        Field<StringGraphType>("title")
            .Description("New display title for the chapter.");
    }
}
