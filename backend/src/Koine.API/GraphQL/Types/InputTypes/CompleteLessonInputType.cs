using GraphQL.Types;
using Koine.Application.DTOs.Lessons;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="CompleteLessonDto"/>.</summary>
public class CompleteLessonInputType : InputObjectGraphType<CompleteLessonDto>
{
    public CompleteLessonInputType()
    {
        Name = "CompleteLessonInput";
        Description = "Input for marking a lesson as completed.";

        Field<NonNullGraphType<IntGraphType>>("lessonId")
            .Description("ID of the lesson being completed.");
        Field<IntGraphType>("score")
            .Description("Optional score achieved in the lesson (0–100).");
    }
}
