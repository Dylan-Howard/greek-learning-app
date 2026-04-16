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
                new Word { Greek = "ἔχω", Transliteration = "echō", Gloss = "I have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "καύχησιν", Transliteration = "kauchēsin", Gloss = "boasting", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the boasting"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in Christ Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the [things]", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
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
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "τολμήσω", Transliteration = "tolmēsō", Gloss = "I will dare", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "τι", Transliteration = "ti", Gloss = "anything", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαλεῖν", Transliteration = "lalein", Gloss = "to speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to speak"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of which", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "κατειργάσατο", Transliteration = "kateirgasato", Gloss = "produced", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "through me"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑπακοὴν", Transliteration = "hypakoēn", Gloss = "obedience", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "of [the] Gentiles", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "for the obedience of the Gentiles"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λόγῳ", Transliteration = "logō", Gloss = "by word", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "ἔργῳ", Transliteration = "ergō", Gloss = "by deed", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "σημείων", Transliteration = "sēmeiōn", Gloss = "of signs", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "τεράτων", Transliteration = "teratōn", Gloss = "wonders", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the power of signs and wonders"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "of [the] Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
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
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Ierousalēm", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "from Jerusalem"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "κύκλῳ", Transliteration = "kyklō", Gloss = "round about", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μέχρι", Transliteration = "mechri", Gloss = "as far as", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Ἰλλυρικοῦ", Transliteration = "Illyrikou", Gloss = "Illyricum", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "as far as Illyricum"
                },
                new Word { Greek = "πεπληρωκέναι", Transliteration = "peplērōkenai", Gloss = "to have fulfilled", GrammarCodes = new List<string> { "V", "PERF", "ACT", "INF" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion", Gloss = "gospel", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
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
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φιλοτιμούμενον", Transliteration = "philotimoumenon", Gloss = "making it my ambition", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "making it my ambition"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐαγγελίζεσθαι", Transliteration = "euangelizesthai", Gloss = "to preach the gospel", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to preach the gospel"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ὠνομάσθη", Transliteration = "ōnomasthē", Gloss = "was named", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "Χριστός", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "where Christ was named"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἀλλότριον", Transliteration = "allotrion", Gloss = "another's", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "θεμέλιον", Transliteration = "themelion", Gloss = "foundation", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "upon another's foundation"
                        },
                        new Word { Greek = "οἰκοδομῶ", Transliteration = "oikodomō", Gloss = "I might build", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
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
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
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
                                new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "to whom", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "ἀνηγγέλη", Transliteration = "anēngelē", Gloss = "it was told", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "concerning him"
                                }
                            },
                            Translation = "Those to whom it was not told concerning him"
                        },
                        new Word { Greek = "ὄψονται", Transliteration = "opsontai", Gloss = "they shall see", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "They to whom it was not told concerning him shall see"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
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
                                new Word { Greek = "οἳ", Transliteration = "hoi", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "ἀκηκόασιν", Transliteration = "akēkoasin", Gloss = "have heard", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "they who have not heard"
                        },
                        new Word { Greek = "συνήσουσιν", Transliteration = "synēsousin", Gloss = "they shall understand", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
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
                new Word { Greek = "Διὸ", Transliteration = "Dio", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐνεκοπτόμην", Transliteration = "enekoptomēn", Gloss = "I was hindered", GrammarCodes = new List<string> { "V", "IMPF", "PASS", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πολλὰ", Transliteration = "polla", Gloss = "many [times]", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "these many times"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
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
                new Word { Greek = "νυνὶ", Transliteration = "nyni", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "μηκέτι", Transliteration = "mēketi", Gloss = "no longer", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "τόπον", Transliteration = "topon", Gloss = "place", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "κλίμασιν", Transliteration = "klimasin", Gloss = "regions", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τούτοις", Transliteration = "toutois", Gloss = "these", GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "in these regions"
                        }
                    },
                    Translation = "having no longer a place in these regions"
                },
                new Word { Greek = "ἐπιποθίαν", Transliteration = "epipothian", Gloss = "a longing", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "having"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
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
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐτῶν", Transliteration = "etōn", Gloss = "years", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
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
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "whenever", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "[potential]", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "πορεύωμαι", Transliteration = "poreuōmai", Gloss = "I may go", GrammarCodes = new List<string> { "V", "PRES", "MID", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Σπανίαν", Transliteration = "Spanian", Gloss = "Spain", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "to Spain"
                        }
                    },
                    Translation = "whenever I go to Spain"
                },
                new Word { Greek = "ἐλπίζω", Transliteration = "elpizō", Gloss = "I hope", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαπορευόμενος", Transliteration = "diaporeuomenos", Gloss = "passing through", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "as I pass through"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεάσασθαι", Transliteration = "theasasthai", Gloss = "to see", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to see you"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
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
                                new Word { Greek = "ὑφ᾽", Transliteration = "hyph'", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "by you"
                        },
                        new Word { Greek = "προπεμφθῆναι", Transliteration = "propemphthēnai", Gloss = "to be helped on my way", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἐκεῖ", Transliteration = "ekei", Gloss = "there", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" }
                    },
                    Translation = "to be helped on my way there by you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "μέρους", Transliteration = "merous", Gloss = "part", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in part"
                        },
                        new Word { Greek = "ἐμπλησθῶ", Transliteration = "emplēsthō", Gloss = "I may be satisfied", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
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
