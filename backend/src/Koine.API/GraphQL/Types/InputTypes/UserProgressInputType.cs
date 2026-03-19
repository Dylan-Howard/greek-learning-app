using GraphQL.Types;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for updating user progress.</summary>
public class UserProgressInputType : InputObjectGraphType
{
    public UserProgressInputType()
    {
        Name = "UserProgressInput";
        Description = "Input for updating a user's overall progress record.";

        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("completedLessonIds")
            .Description("Full list of lesson IDs the user has completed.");
        Field<NonNullGraphType<IntGraphType>>("totalExperience")
            .Description("Total XP accumulated by the user.");
    }
}
