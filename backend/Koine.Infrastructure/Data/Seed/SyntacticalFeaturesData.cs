// Koine.Infrastructure/Data/Seed/SyntacticalFeaturesData.cs
namespace Koine.Infrastructure.Data.Seed
{
    public static class SyntacticalFeaturesData
    {
        public static List<(string Code, string Name, string Definition, int SortOrder)> GetFeatures()
        {
            return new List<(string, string, string, int)>
            {
                ("SUBJ", "Subject", "The subject of the clause", 1),
                ("PRED", "Predicate", "The predicate of the clause", 2),
                ("OBJ", "Object", "Direct or indirect object", 3),
                ("ATTR", "Attributive", "Attributive modifier", 4),
                ("PREP_PHRASE", "Prepositional Phrase", "Phrase beginning with preposition", 5),
                ("REL_CLAUSE", "Relative Clause", "Relative clause", 6),
                ("SUBORD_CLAUSE", "Subordinate Clause", "Subordinate clause", 7),
                ("COORD", "Coordination", "Coordinated elements", 8),
                ("APPOS", "Apposition", "Appositional phrase", 9),
                ("NOUN_PHRASE", "Noun Phrase", "Noun with modifiers", 10),
                ("VERB_PHRASE", "Verb Phrase", "Verb with complements", 11),
                ("ADJ_PHRASE", "Adjective Phrase", "Adjective with modifiers", 12),
                ("INDEP_CLAUSE", "Independent Clause", "Main independent clause", 13),
                ("COND_CLAUSE", "Conditional Clause", "Conditional (if) clause", 14),
                ("PURPOSE_CLAUSE", "Purpose Clause", "Purpose clause", 15)
            };
        }
    }
}