using GraphQL.Types;
using Koine.Application.Study.DTOs;

namespace Koine.API.GraphQL.Types.InputTypes;

/// <summary>GraphQL input type for <see cref="StartSessionRequest"/>.</summary>
public class StartSessionInputType : InputObjectGraphType<StartSessionRequest>
{
    public StartSessionInputType()
    {
        Name = "StartSessionInput";
        Description = "Input for starting a new spaced-repetition study session.";

        Field<IntGraphType>("cardCount")
            .Description("Number of cards to include (-1 for all due cards). Defaults to 10.");
        Field<NonNullGraphType<StringGraphType>>("pool")
            .Description("Card pool to draw from (e.g. Mixed, NewOnly, DueOnly).");
        Field<NonNullGraphType<StringGraphType>>("direction")
            .Description("Study direction (e.g. GreekToEnglish, EnglishToGreek).");
        Field<NonNullGraphType<StringGraphType>>("mode")
            .Description("Interaction mode (e.g. Flashcard, MultipleChoice, Mix).");
        Field<NonNullGraphType<StringGraphType>>("source")
            .Description("Session source (e.g. StandardStudy, VocabularySet).");
        Field<IntGraphType>("vocabularySetId")
            .Description("Optional vocabulary set to restrict cards to.");
        Field<ListGraphType<NonNullGraphType<IntGraphType>>>("vocabularyIds")
            .Description("Optional explicit list of vocabulary IDs to study.");
    }
}
