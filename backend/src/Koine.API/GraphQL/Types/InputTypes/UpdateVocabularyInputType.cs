using GraphQL.Types;
using Koine.Application.DTOs.Vocabulary;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="UpdateVocabularyDto"/>.</summary>
public class UpdateVocabularyInputType : InputObjectGraphType<UpdateVocabularyDto>
{
    public UpdateVocabularyInputType()
    {
        Name = "UpdateVocabularyInput";
        Description = "Input for updating an existing vocabulary word. All fields are optional.";

        Field<StringGraphType>("root")
            .Description("New Greek root form.");
        Field<StringGraphType>("transliteration")
            .Description("New Latin transliteration.");
        Field<StringGraphType>("gloss")
            .Description("New English gloss.");
        Field<StringGraphType>("partOfSpeech")
            .Description("New part of speech.");
        Field<IntGraphType>("occurrences")
            .Description("Updated occurrence count.");
    }
}
