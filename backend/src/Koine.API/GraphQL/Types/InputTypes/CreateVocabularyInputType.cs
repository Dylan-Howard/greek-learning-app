using GraphQL.Types;
using Koine.Application.DTOs.Vocabulary;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="CreateVocabularyDto"/>.</summary>
public class CreateVocabularyInputType : InputObjectGraphType<CreateVocabularyDto>
{
    public CreateVocabularyInputType()
    {
        Name = "CreateVocabularyInput";
        Description = "Input for adding a new vocabulary word to the corpus.";

        Field<NonNullGraphType<StringGraphType>>("root")
            .Description("Greek root form of the word.");
        Field<StringGraphType>("transliteration")
            .Description("Optional Latin transliteration.");
        Field<NonNullGraphType<StringGraphType>>("gloss")
            .Description("English gloss (short definition).");
        Field<StringGraphType>("partOfSpeech")
            .Description("Grammatical part of speech (e.g. noun, verb).");
        Field<IntGraphType>("occurrences")
            .Description("Number of occurrences in the corpus.");
    }
}
