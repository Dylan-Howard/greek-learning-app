private static List<object> GetChapter3()
{
    // Romans 3:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τί", Transliteration = "Ti", Gloss = "What", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "προεχόμεθα", Transliteration = "proechometha", Gloss = "are we better off", Grammar_Codes = new List<string> { "V", "PRES", "MID", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "No", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "πάντως", Transliteration = "pantōs", Gloss = "at all", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" }
            },
            Translation = "What then? Are we better off? No, not at all."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "προῃτιασάμεθα", Transliteration = "proēitiasametha", Gloss = "we have already charged", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰουδαίους", Transliteration = "Ioudaious", Gloss = "Jews", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "both", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Ἕλληνας", Transliteration = "Hellēnas", Gloss = "Greeks", Grammar_Codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "both Jews and Greeks all"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑφ᾽", Transliteration = "hyph'", Gloss = "under", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian", Gloss = "sin", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "under sin"
                        },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to be under sin"
                }
            },
            Translation = "For we have already charged that all, both Jews and Greeks, are under sin,"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "None", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "δίκαιος", Transliteration = "dikaios", Gloss = "righteous", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "not even", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "that none is righteous, no, not one"
                }
            },
            Translation = "as it is written: 'None is righteous, no, not one;'"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "no one", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "συνίων", Transliteration = "syniōn", Gloss = "understanding", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "the one who understands"
                }
            },
            Translation = "no one understands;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "no one", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐκζητῶν", Transliteration = "ekzētōn", Gloss = "seeking", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "God"
                        }
                    },
                    Translation = "the one who seeks for God"
                }
            },
            Translation = "no one seeks for God."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "All", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐξέκλιναν", Transliteration = "exeklinan", Gloss = "have turned aside", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἅμα", Transliteration = "hama", Gloss = "together", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἠχρεώθησαν", Transliteration = "ēchreōthēsan", Gloss = "they have become worthless", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "All have turned aside; together they have become worthless;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "no one", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "doing", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "χρηστότητα", Transliteration = "chrēstotēta", Gloss = "good", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the one who does good"
                }
            },
            Translation = "no one does good,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "no", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is [there]", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "even", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἑνός", Transliteration = "henos", Gloss = "one", Grammar_Codes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "even one"
                }
            },
            Translation = "not even one."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τάφος", Transliteration = "taphos", Gloss = "grave", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἀνεῳγμένος", Transliteration = "aneōigmenos", Gloss = "opened", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "an open grave"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λάρυγξ", Transliteration = "laryngx", Gloss = "throat", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "their throat"
                }
            },
            Translation = "Their throat is an open grave;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "with the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "γλώσσαις", Transliteration = "glōssais", Gloss = "tongues", Grammar_Codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "with their tongues"
                },
                new Word { Greek = "ἐδολιοῦσαν", Transliteration = "edoliousan", Gloss = "they were deceiving", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "they use their tongues to deceive."
        },
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
                        new Word { Greek = "ἰὸς", Transliteration = "ios", Gloss = "poison", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἀσπίδων", Transliteration = "aspidōn", Gloss = "of asps", Grammar_Codes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the poison of asps"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "χείλη", Transliteration = "cheilē", Gloss = "lips", Grammar_Codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "their lips"
                        }
                    },
                    Translation = "under their lips"
                }
            },
            Translation = "The poison of asps is under their lips."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "Whose", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", Grammar_Codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "mouth"
                },
                new Word { Greek = "γέμει", Transliteration = "gemei", Gloss = "is full", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀρᾶς", Transliteration = "aras", Gloss = "of cursing", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πικρίας", Transliteration = "pikrias", Gloss = "bitterness", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "of cursing and bitterness"
                }
            },
            Translation = "Whose mouth is full of cursing and bitterness."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὀξεῖς", Transliteration = "oxeis", Gloss = "Swift [are]", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πόδες", Transliteration = "podes", Gloss = "feet", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "their feet"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκχέαι", Transliteration = "ekcheai", Gloss = "to shed", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αἷμα", Transliteration = "haima", Gloss = "blood", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "to shed blood"
                }
            },
            Translation = "Their feet are swift to shed blood;"
        },

        // Verse 16
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
                        new Word { Greek = "σύντριμμα", Transliteration = "syntrimma", Gloss = "ruin", Grammar_Codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ταλαιπωρία", Transliteration = "talaipōria", Gloss = "misery", Grammar_Codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "ruin and misery"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὁδοῖς", Transliteration = "hodois", Gloss = "ways", Grammar_Codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "their ways"
                        }
                    },
                    Translation = "in their ways"
                }
            },
            Translation = "in their ways are ruin and misery,"
        }
    };
}

/*
Constructions Identified:
- DAT_INSTR: ταῖς γλώσσαις αὐτῶν (v13) - Dative of instrument.
- NOUN_PHRASE (SUBSTITUTE): ὁ συνίων (v11), ὁ ἐκζητῶν (v11), ὁ ποιῶν (v12) - Substantival participles.
- PREDICATIVE ADJECTIVE: ὀξεῖς οἱ πόδες (v15) - Predicate position.
*/
