private static List<object> GetChapter6()
{
    // John 6:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔστιν", Transliteration = "estin",
                    Gloss = "there is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παιδάριον", Transliteration = "paidarion",
                            Gloss = "a little boy",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a little boy"
                },
                new Word { Greek = "ὧδε", Transliteration = "hōde",
                    Gloss = "here",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἔχει", Transliteration = "echei",
                            Gloss = "has",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πέντε", Transliteration = "pente",
                                    Gloss = "five",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἄρτους", Transliteration = "artous",
                                    Gloss = "loaves",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "κριθίνους", Transliteration = "krithinous",
                                    Gloss = "of barley",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "five barley loaves"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δύο", Transliteration = "duo",
                                    Gloss = "two",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ὀψάρια", Transliteration = "opsaria",
                                    Gloss = "fish",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "two fish"
                        }
                    },
                    Translation = "who has five barley loaves and two fish"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῦτα", Transliteration = "tauta",
                            Gloss = "these things",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "these"
                },
                new Word { Greek = "τί", Transliteration = "ti",
                    Gloss = "what",
                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin",
                    Gloss = "are they",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοσούτους", Transliteration = "tosoutous",
                            Gloss = "so many",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "for so many"
                }
            },
            Translation = "There is a boy here who has five barley loaves and two fish, but what are these for so many?"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποιήσατε", Transliteration = "poiēsate",
                            Gloss = "make",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθρώπους", Transliteration = "anthrōpous",
                                    Gloss = "people",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the people"
                        },
                        new Word { Greek = "ἀναπεσεῖν", Transliteration = "anapesein",
                            Gloss = "sit down",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "Make the people sit down"
                }
            },
            Translation = "Jesus said, 'Make the people sit down.'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦν", Transliteration = "ēn",
                    Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "now",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χόρτος", Transliteration = "chortos",
                            Gloss = "grass",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πολὺς", Transliteration = "polus",
                            Gloss = "much",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "much grass"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "τόπῳ", Transliteration = "topō",
                                    Gloss = "place",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the place"
                        }
                    },
                    Translation = "in the place"
                }
            },
            Translation = "Now there was much grass in the place."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀνέπεσαν", Transliteration = "anepesan",
                    Gloss = "sat down",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "so",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἄνδρες", Transliteration = "andres",
                            Gloss = "men",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the men"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀριθμὸν", Transliteration = "arithmon",
                            Gloss = "number",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in number"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "about",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "πεντακισχίλιοι", Transliteration = "pentakischilioi",
                            Gloss = "five thousand",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "about five thousand"
                }
            },
            Translation = "So the men sat down, in number about five thousand."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔλαβεν", Transliteration = "elaben",
                    Gloss = "took",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "then",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἄρτους", Transliteration = "artous",
                            Gloss = "loaves",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the loaves"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐχαριστήσας", Transliteration = "eucharistēsas",
                            Gloss = "having given thanks",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having given thanks"
                },
                new Word { Greek = "διέδωκεν", Transliteration = "diedōken",
                    Gloss = "distributed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois",
                            Gloss = "to those",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀνακειμένοις", Transliteration = "anakeimenois",
                            Gloss = "reclining",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "DAT", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to those reclining"
                },
                new Word { Greek = "ὁμοίως", Transliteration = "homoiōs",
                    Gloss = "likewise",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek",
                            Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀψαρίων", Transliteration = "opsariōn",
                                    Gloss = "fish",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the fish"
                        }
                    },
                    Translation = "of the fish"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσον", Transliteration = "hoson",
                            Gloss = "as much as",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "k" },
                        new Word { Greek = "ἤθελον", Transliteration = "ēthelon",
                            Gloss = "they wanted",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as much as they wanted"
                }
            },
            Translation = "Then Jesus took the loaves, and having given thanks, distributed them to those reclining; likewise also of the fish, as much as they wanted."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐνεπλήσθησαν", Transliteration = "eneplēsthēsan",
                            Gloss = "they were filled",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "And when they were filled"
                },
                new Word { Greek = "λέγει", Transliteration = "legei",
                    Gloss = "He said",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois",
                            Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταῖς", Transliteration = "mathētais",
                            Gloss = "disciples",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "His",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to His disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συναγάγετε", Transliteration = "sunagagete",
                            Gloss = "gather",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "περισσεύσαντα", Transliteration = "perisseusanta",
                                    Gloss = "remaining",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "N", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "κλάσματα", Transliteration = "klasmata",
                                    Gloss = "fragments",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the remaining fragments"
                        }
                    },
                    Translation = "Gather the remaining fragments"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μή", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τι", Transliteration = "ti",
                            Gloss = "anything",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "ἀπόληται", Transliteration = "apolētai",
                            Gloss = "may be lost",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "so that nothing may be lost"
                }
            },
            Translation = "And when they were filled, He said to His disciples, 'Gather the remaining fragments so that nothing may be lost.'"
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "συνήγαγον", Transliteration = "sunēgagon",
                    Gloss = "they gathered",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "so",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγέμισαν", Transliteration = "egemisan",
                    Gloss = "filled",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δώδεκα", Transliteration = "dōdeka",
                            Gloss = "twelve",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "κοφίνους", Transliteration = "kophinous",
                            Gloss = "baskets",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "twelve baskets"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κλασμάτων", Transliteration = "klasmatōn",
                            Gloss = "of fragments",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of fragments"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek",
                            Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πέντε", Transliteration = "pente",
                                    Gloss = "five",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἄρτων", Transliteration = "artōn",
                                    Gloss = "loaves",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κριθίνων", Transliteration = "krithinōn",
                                    Gloss = "barley",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the five barley loaves"
                        }
                    },
                    Translation = "from the five barley loaves"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἃ", Transliteration = "ha",
                            Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐπερίσσευσαν", Transliteration = "eperisseusan",
                            Gloss = "were left over",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "by those",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "βεβρωκόσιν", Transliteration = "bebrōkosin",
                                    Gloss = "having eaten",
                                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "DAT", "M", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "by those who had eaten"
                        }
                    },
                    Translation = "which were left over by those who had eaten"
                }
            },
            Translation = "So they gathered them and filled twelve baskets with fragments from the five barley loaves which were left over by those who had eaten."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Οἱ", Transliteration = "Hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "οὖν", Transliteration = "oun",
                            Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἄνθρωποι", Transliteration = "anthrōpoi",
                            Gloss = "people",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Therefore the people"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδόντες", Transliteration = "idontes",
                            Gloss = "having seen",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen",
                                    Gloss = "He did",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "σημεῖον", Transliteration = "sēmeion",
                                    Gloss = "sign",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the sign He did"
                        }
                    },
                    Translation = "having seen the sign He did"
                },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon",
                    Gloss = "were saying",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὗτός", Transliteration = "houtos",
                            Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin",
                            Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἀληθῶς", Transliteration = "alēthōs",
                            Gloss = "truly",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "προφήτης", Transliteration = "prophētēs",
                                    Gloss = "prophet",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "ho",
                                            Gloss = "the one",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐρχόμενος", Transliteration = "erchomenos",
                                            Gloss = "coming",
                                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "S" },
                                            PartOfSpeech = "v" }
                                    },
                                    Translation = "the one coming"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis",
                                            Gloss = "into",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸν", Transliteration = "ton",
                                                    Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "κόσ
