// GreekParser.Infrastructure/Data/Seed/GrammaticalFeaturesData.cs
namespace GreekParser.Infrastructure.Data.Seed
{
    public static class GrammaticalFeaturesData
    {
        public static List<(string Code, string Name, string Category, string Definition, int SortOrder)> GetFeatures()
        {
            return new List<(string, string, string, string, int)>
            {
                // Parts of Speech
                ("N", "Noun", "part_of_speech", "A person, place, thing, or idea", 1),
                ("V", "Verb", "part_of_speech", "An action or state of being", 2),
                ("ADJ", "Adjective", "part_of_speech", "Describes a noun", 3),
                ("ART", "Article", "part_of_speech", "Definite or indefinite article", 4),
                ("PRON", "Pronoun", "part_of_speech", "Replaces a noun", 5),
                ("PREP", "Preposition", "part_of_speech", "Shows relationship between words", 6),
                ("CONJ", "Conjunction", "part_of_speech", "Connects words or clauses", 7),
                ("ADV", "Adverb", "part_of_speech", "Describes a verb, adjective, or adverb", 8),
                ("PART", "Particle", "part_of_speech", "Adds emphasis or nuance", 9),
                ("INTERJ", "Interjection", "part_of_speech", "Expresses emotion", 10),

                // Cases
                ("NOM", "Nominative", "case", "Subject case", 20),
                ("GEN", "Genitive", "case", "Possessive case", 21),
                ("DAT", "Dative", "case", "Indirect object case", 22),
                ("ACC", "Accusative", "case", "Direct object case", 23),
                ("VOC", "Vocative", "case", "Direct address case", 24),

                // Gender
                ("M", "Masculine", "gender", "Masculine gender", 30),
                ("F", "Feminine", "gender", "Feminine gender", 31),
                ("N", "Neuter", "gender", "Neuter gender", 32),

                // Number
                ("S", "Singular", "number", "Singular number", 40),
                ("P", "Plural", "number", "Plural number", 41),

                // Tense
                ("PRES", "Present", "tense", "Present tense", 50),
                ("IMPF", "Imperfect", "tense", "Imperfect tense", 51),
                ("FUT", "Future", "tense", "Future tense", 52),
                ("AOR", "Aorist", "tense", "Aorist tense", 53),
                ("PERF", "Perfect", "tense", "Perfect tense", 54),
                ("PLUP", "Pluperfect", "tense", "Pluperfect tense", 55),

                // Voice
                ("ACT", "Active", "voice", "Active voice", 60),
                ("MID", "Middle", "voice", "Middle voice", 61),
                ("PASS", "Passive", "voice", "Passive voice", 62),

                // Mood
                ("IND", "Indicative", "mood", "Indicative mood", 70),
                ("SUBJ", "Subjunctive", "mood", "Subjunctive mood", 71),
                ("OPT", "Optative", "mood", "Optative mood", 72),
                ("IMP", "Imperative", "mood", "Imperative mood", 73),
                ("INF", "Infinitive", "mood", "Infinitive mood", 74),
                ("PTCP", "Participle", "mood", "Participle", 75),

                // Person
                ("1P", "First Person", "person", "First person", 80),
                ("2P", "Second Person", "person", "Second person", 81),
                ("3P", "Third Person", "person", "Third person", 82),

                // Degree
                ("POS", "Positive", "degree", "Positive degree", 90),
                ("COMP", "Comparative", "degree", "Comparative degree", 91),
                ("SUPER", "Superlative", "degree", "Superlative degree", 92)
            };
        }
    }
}

