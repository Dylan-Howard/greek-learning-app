private static List<object> GetChapter15()
{
    // Romans 15:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔχω", Transliteration = "echō", Gloss = "I have", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "καύχησιν", Transliteration = "kauchēsin", Gloss = "boasting", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the boasting"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in Christ Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the [things]", Grammar_codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "pertaining to God"
                        }
                    },
                    Translation = "in things pertaining to God"
                }
            },
            Translation = "I have therefore my boasting in Christ Jesus in things pertaining to God."
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "τολμήσω", Transliteration = "tolmēsō", Gloss = "I will dare", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "τι", Transliteration = "ti", Gloss = "anything", Grammar_codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαλεῖν", Transliteration = "lalein", Gloss = "to speak", Grammar_codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to speak"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of which", Grammar_codes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "κατειργάσατο", Transliteration = "kateirgasato", Gloss = "produced", Grammar_codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me", Grammar_codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "through me"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑπακοὴν", Transliteration = "hypakoēn", Gloss = "obedience", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "of [the] Gentiles", Grammar_codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "for the obedience of the Gentiles"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λόγῳ", Transliteration = "logō", Gloss = "by word", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "ἔργῳ", Transliteration = "ergō", Gloss = "by deed", Grammar_codes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "by word and deed"
                        }
                    },
                    Translation = "of those things which Christ has not accomplished through me for the obedience of the Gentiles, by word and deed"
                }
            },
            Translation = "For I will not dare to speak of any of those things which Christ has not accomplished through me for the obedience of the Gentiles, by word and deed,"
        },
        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "σημείων", Transliteration = "sēmeiōn", Gloss = "of signs", Grammar_codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "τεράτων", Transliteration = "teratōn", Gloss = "wonders", Grammar_codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the power of signs and wonders"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "of [the] Spirit", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the power of the Spirit of God"
                }
            },
            Translation = "in the power of signs and wonders, in the power of the Spirit of God;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", Grammar_codes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Ierousalēm", Gloss = "Jerusalem", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "from Jerusalem"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "κύκλῳ", Transliteration = "kyklō", Gloss = "round about", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μέχρι", Transliteration = "mechri", Gloss = "as far as", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Ἰλλυρικοῦ", Transliteration = "Illyrikou", Gloss = "Illyricum", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "as far as Illyricum"
                },
                new Word { Greek = "πεπληρωκέναι", Transliteration = "peplērōkenai", Gloss = "to have fulfilled", Grammar_codes = new List<string> { "V", "PERF", "ACT", "INF" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion", Gloss = "gospel", Grammar_codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the gospel of Christ"
                }
            },
            Translation = "so that from Jerusalem and round about as far as Illyricum I have fully preached the gospel of Christ."
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φιλοτιμούμενον", Transliteration = "philotimoumenon", Gloss = "making it my ambition", Grammar_codes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "making it my ambition"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐαγγελίζεσθαι", Transliteration = "euangelizesthai", Gloss = "to preach the gospel", Grammar_codes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to preach the gospel"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ὠνομάσθη", Transliteration = "ōnomasthē", Gloss = "was named", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "Χριστός", Transliteration = "Christos", Gloss = "Christ", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "where Christ was named"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "upon", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἀλλότριον", Transliteration = "allotrion", Gloss = "another's", Grammar_codes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "θεμέλιον", Transliteration = "themelion", Gloss = "foundation", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "upon another's foundation"
                        },
                        new Word { Greek = "οἰκοδομῶ", Transliteration = "oikodomō", Gloss = "I might build", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "lest I should build upon another man's foundation"
                }
            },
            Translation = "and thus making it my ambition to preach the gospel, not where Christ has already been named, lest I should build upon another man's foundation,"
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", Grammar_codes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "to whom", Grammar_codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "ἀνηγγέλη", Transliteration = "anēngelē", Gloss = "it was told", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", Grammar_codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "concerning him"
                                }
                            },
                            Translation = "Those to whom it was not told concerning him"
                        },
                        new Word { Greek = "ὄψονται", Transliteration = "opsontai", Gloss = "they shall see", Grammar_codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "They to whom it was not told concerning him shall see"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἳ", Transliteration = "hoi", Gloss = "who", Grammar_codes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "ἀκηκόασιν", Transliteration = "akēkoasin", Gloss = "have heard", Grammar_codes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "they who have not heard"
                        },
                        new Word { Greek = "συνήσουσιν", Transliteration = "synēsousin", Gloss = "they shall understand", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and they who have not heard shall understand."
                }
            },
            Translation = "but as it is written: 'They to whom it was not told concerning him shall see, and they who have not heard shall understand.'"
        },
        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Διὸ", Transliteration = "Dio", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐνεκοπτόμην", Transliteration = "enekoptomēn", Gloss = "I was hindered", Grammar_codes = new List<string> { "V", "IMPF", "PASS", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πολλὰ", Transliteration = "polla", Gloss = "many [times]", Grammar_codes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "these many times"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "to come", Grammar_codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to you"
                        }
                    },
                    Translation = "from coming to you"
                }
            },
            Translation = "For this reason I have often been hindered from coming to you."
        },
        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νυνὶ", Transliteration = "nyni", Gloss = "now", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "μηκέτι", Transliteration = "mēketi", Gloss = "no longer", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "τόπον", Transliteration = "topon", Gloss = "place", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "κλίμασιν", Transliteration = "klimasin", Gloss = "regions", Grammar_codes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τούτοις", Transliteration = "toutois", Gloss = "these", Grammar_codes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "in these regions"
                        }
                    },
                    Translation = "having no longer a place in these regions"
                },
                new Word { Greek = "ἐπιποθίαν", Transliteration = "epipothian", Gloss = "a longing", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "having"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "to come", Grammar_codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to you"
                        }
                    },
                    Translation = "to come to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many", Grammar_codes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐτῶν", Transliteration = "etōn", Gloss = "years", Grammar_codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "for many years"
                }
            },
            Translation = "But now, since I no longer have any place in these regions, and since I have had for many years a longing to come to you,"
        },
        // Verse 24
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
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "whenever", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "[potential]", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "πορεύωμαι", Transliteration = "poreuōmai", Gloss = "I may go", Grammar_codes = new List<string> { "V", "PRES", "MID", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Σπανίαν", Transliteration = "Spanian", Gloss = "Spain", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "to Spain"
                        }
                    },
                    Translation = "whenever I go to Spain"
                },
                new Word { Greek = "ἐλπίζω", Transliteration = "elpizō", Gloss = "I hope", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαπορευόμενος", Transliteration = "diaporeuomenos", Gloss = "passing through", Grammar_codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "as I pass through"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεάσασθαι", Transliteration = "theasasthai", Gloss = "to see", Grammar_codes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to see you"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
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
                                new Word { Greek = "ὑφ᾽", Transliteration = "hyph'", Gloss = "by", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "by you"
                        },
                        new Word { Greek = "προπεμφθῆναι", Transliteration = "propemphthēnai", Gloss = "to be helped on my way", Grammar_codes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἐκεῖ", Transliteration = "ekei", Gloss = "there", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" }
                    },
                    Translation = "to be helped on my way there by you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "μέρους", Transliteration = "merous", Gloss = "part", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in part"
                        },
                        new Word { Greek = "ἐμπλησθῶ", Transliteration = "emplēsthō", Gloss = "I may be satisfied", Grammar_codes = new List<string> { "V", "AOR", "PASS", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "once I have enjoyed your company for a while"
                }
            },
            Translation = "I hope to see you in passing as I go to Spain, and to be helped on my journey there by you, once I have enjoyed your company for a while."
        }
    };
}
/*
Constructions identified:
- DAT_INSTR: λόγῳ καὶ ἔργῳ (v18)
- RESULT_CLAUSE: ὥστε... πεπληρωκέναι (v19)
- INF_PHRASE: used as object of verb (v18, v20, v24) or with article (v22, v23)
- PURPOSE_CLAUSE: ἵνα μὴ... οἰκοδομῶ (v20)
- TEMP_CLAUSE: ὡς ἂν πορεύωμαι (v24)
- COND_CLAUSE: ἐὰν... ἐμπλησθῶ (v24)
*/
