using GraphQL.Types;
using Koine.Application.DTOs.Study;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="CreateVocabularySetDto"/>.</summary>
public class CreateVocabularySetInputType : InputObjectGraphType<CreateVocabularySetDto>
{
    public CreateVocabularySetInputType()
    {
        Name = "CreateVocabularySetInput";
        Description = "Input for creating a new user vocabulary set.";

        Field<NonNullGraphType<StringGraphType>>("title")
            .Description("Display title for the vocabulary set.");
        Field<NonNullGraphType<StringGraphType>>("description")
            .Description("Short description of the set's content or purpose.");
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<IntGraphType>>>>("vocabularyIds")
            .Description("IDs of vocabulary words to include in the set.");
    }
}
