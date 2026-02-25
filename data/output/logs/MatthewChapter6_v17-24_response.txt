private static List<object> GetChapter6()
{
    // Matthew 6:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νηστεύων", Transliteration = "nēsteuōn", Gloss = "fasting", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "when you fast"
                },
                new Word { Greek = "ἄλειψαί", Transliteration = "aleipsai", Gloss = "anoint", GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κεφαλὴν", Transliteration = "kephalēn", Gloss = "head", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "your head"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρόσωπόν", Transliteration = "prosōpon", Gloss = "face", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your face"
                },
                new Word { Greek = "νίψαι", Transliteration = "nipsai", Gloss = "wash", GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But you, when you fast, anoint your head and wash your face,"
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅπως", Transliteration = "hopōs", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "φανῇς", Transliteration = "phanēs", Gloss = "you may appear", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνθρώποις", Transliteration = "anthrōpois", Gloss = "to men", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to men"
                },
                new Word { Greek = "νηστεύων", Transliteration = "nēsteuōn", Gloss = "fasting", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατρί", Transliteration = "patri", Gloss = "Father", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κρυφαίῳ", Transliteration = "kryphaiō", Gloss = "secret", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "who is in secret"
                        }
                    },
                    Translation = "to your Father who is in secret"
                }
            },
            Translation = "so that your fasting may not be seen by men, but by your Father who is in secret."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 18)
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατήρ", Transliteration = "patēr", Gloss = "Father", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βλέπων", Transliteration = "blepōn", Gloss = "seeing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κρυφαίῳ", Transliteration = "kryphaiō", Gloss = "secret", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "in secret"
                                }
                            },
                            Translation = "who sees in secret"
                        }
                    },
                    Translation = "your Father who sees in secret"
                },
                new Word { Greek = "ἀποδώσει", Transliteration = "apodōsei", Gloss = "will reward", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "And your Father who sees in secret will reward you."
        },
        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μὴ", Transliteration = "Mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "θησαυρίζετε", Transliteration = "thēsaurizete", Gloss = "store up", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "for yourselves", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "θησαυροὺς", Transliteration = "thēsaurous", Gloss = "treasures", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "on earth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "σὴς", Transliteration = "sēs", Gloss = "moth", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "βρῶσις", Transliteration = "brōsis", Gloss = "rust", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀφανίζει", Transliteration = "aphanizei", Gloss = "destroys", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "where moth and rust destroy"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κλέπται", Transliteration = "kleptai", Gloss = "thieves", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "διορύσσουσιν", Transliteration = "dioryssousin", Gloss = "break in", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κλέπτουσιν", Transliteration = "kleptousin", Gloss = "steal", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "where thieves break in and steal"
                }
            },
            Translation = "Do not store up for yourselves treasures on earth, where moth and rust destroy and where thieves break in and steal."
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "θησαυρίζετε", Transliteration = "thēsaurizete", Gloss = "store up", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "for yourselves", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "θησαυροὺς", Transliteration = "thēsaurous", Gloss = "treasures", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὐρανῷ", Transliteration = "ouranō", Gloss = "heaven", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in heaven"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὔτε", Transliteration = "oute", Gloss = "neither", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σὴς", Transliteration = "sēs", Gloss = "moth", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "οὔτε", Transliteration = "oute", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "βρῶσις", Transliteration = "brōsis", Gloss = "rust", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀφανίζει", Transliteration = "aphanizei", Gloss = "destroys", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "where neither moth nor rust destroys"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κλέπται", Transliteration = "kleptai", Gloss = "thieves", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "διορύσσουσιν", Transliteration = "dioryssousin", Gloss = "break in", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κλέπτουσιν", Transliteration = "kleptousin", Gloss = "steal", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "where thieves do not break in nor steal"
                }
            },
            Translation = "But store up for yourselves treasures in heaven, where neither moth nor rust destroys and where thieves do not break in nor steal."
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θησαυρός", Transliteration = "thēsauros", Gloss = "treasure", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your treasure"
                },
                new Word { Greek = "ἐκεῖ", Transliteration = "ekei", Gloss = "there", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρδία", Transliteration = "kardia", Gloss = "heart", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your heart"
                }
            },
            Translation = "For where your treasure is, there your heart will be also."
        },
        // Verse 22
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
                        new Word { Greek = "Ὁ", Transliteration = "Ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λύχνος", Transliteration = "lychnos", Gloss = "lamp", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σώματός", Transliteration = "sōmatos", Gloss = "body", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the body"
                        }
                    },
                    Translation = "The lamp of the body"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀφθαλμός", Transliteration = "ophthalmos", Gloss = "eye", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the eye"
                }
            },
            Translation = "The lamp of the body is the eye."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀφθαλμός", Transliteration = "ophthalmos", Gloss = "eye", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your eye"
                },
                new Word { Greek = "ἁπλοῦς", Transliteration = "haplous", Gloss = "healthy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῶμά", Transliteration = "sōma", Gloss = "body", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your whole body"
                },
                new Word { Greek = "φωτεινὸν", Transliteration = "phōteinon", Gloss = "full of light", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "If therefore your eye is healthy, your whole body will be full of light."
        },
        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀφθαλμός", Transliteration = "ophthalmos", Gloss = "eye", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your eye"
                },
                new Word { Greek = "πονηρὸς", Transliteration = "ponēros", Gloss = "bad", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῶμά", Transliteration = "sōma", Gloss = "body", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your whole body"
                },
                new Word { Greek = "σκοτεινὸν", Transliteration = "skoteinon", Gloss = "full of darkness", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But if your eye is bad, your whole body will be full of darkness."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "light", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σοὶ", Transliteration = "soi", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "that is in you"
                        }
                    },
                    Translation = "the light that is in you"
                },
                new Word { Greek = "σκότος", Transliteration = "skotos", Gloss = "darkness", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σκότος", Transliteration = "skotos", Gloss = "darkness", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the darkness"
                },
                new Word { Greek = "πόσον", Transliteration = "poson", Gloss = "how great!", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "q" }
            },
            Translation = "If therefore the light that is in you is darkness, how great is the darkness!"
        },
        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐδεὶς", Transliteration = "Oudeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "δύναται", Transliteration = "dynatai", Gloss = "is able", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δυσὶ", Transliteration = "dysi", Gloss = "two", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κυρίοις", Transliteration = "kyriois", Gloss = "lords", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "two lords"
                },
                new Word { Greek = "δουλεύειν", Transliteration = "douleuein", Gloss = "to serve", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "No one is able to serve two lords."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "for either", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἕνα", Transliteration = "hena", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the one"
                },
                new Word { Greek = "μισήσει", Transliteration = "misēsei", Gloss = "he will hate", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἕτερον", Transliteration = "heteron", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the other"
                },
                new Word { Greek = "ἀγαπήσει", Transliteration = "agapēsei", Gloss = "he will love", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἑνὸς", Transliteration = "henos", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀνθέξεται", Transliteration = "anthexetai", Gloss = "he will be devoted to", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἑτέρου", Transliteration = "heterou", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the other"
                },
                new Word { Greek = "καταφρονήσει", Transliteration = "kataphronēsei", Gloss = "he will despise", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "for either he will hate the one and love the other, or he will be devoted to the one and despise the other."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "δύνασθε", Transliteration = "dynasthe", Gloss = "you are able", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "δουλεύειν", Transliteration = "douleuein", Gloss = "to serve", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μαμωνᾷ", Transliteration = "mamōna", Gloss = "wealth", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "You cannot serve God and wealth."
        }
    };
}

/*
Constructions Identified:
- Verse 17: PTCP (circumstantial)
- Verse 18: PURPOSE_CLAUSE (hopos), PTCP (attributive)
- Verse 19: REL_CLAUSE (hopou)
- Verse 20: REL_CLAUSE (hopou)
- Verse 21: CAUSAL_CLAUSE (gar)
- Verse 22: COND_CLAUSE (ean + subj), GEN_DESC (tou somatos)
- Verse 23: COND_CLAUSE (ean + subj), COND_CLAUSE (ei + ind)
- Verse 24: CAUSAL_CLAUSE (gar), INF_PHRASE (douleuein)
*/
