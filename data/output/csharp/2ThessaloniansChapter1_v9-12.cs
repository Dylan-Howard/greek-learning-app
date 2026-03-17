private static List<object> GetChapter1()
{
    // 2 Thessalonians 1:9-12
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἵτινες", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δίκην", Transliteration = "", Gloss = "punishment", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the penalty"
                        },
                        new Word { Greek = "τίσουσιν", Transliteration = "", Gloss = "to pay", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὄλεθρον", Transliteration = "", Gloss = "destruction", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αἰώνιον", Transliteration = "", Gloss = "eternal", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "eternal destruction"
                        }
                    },
                    Translation = "will pay the penalty, eternal destruction"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "προσώπου", Transliteration = "", Gloss = "face", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "κυρίου", Transliteration = "", Gloss = "lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of the Lord"
                                }
                            },
                            Translation = "the face"
                        }
                    },
                    Translation = "away from the presence of the Lord"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "δόξης", Transliteration = "", Gloss = "glory", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἰσχύος", Transliteration = "", Gloss = "strength", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "of his strength"
                                }
                            },
                            Translation = "the glory"
                        }
                    },
                    Translation = "from the glory of his strength"
                }
            },
            Translation = "who will pay the penalty of eternal destruction, away from the presence of the Lord and from the glory of his might"
        },

        // Verse 10
        // (continues relative clause context, but syntactically starts with Temporal Clause modifying the previous or implying 'in that day')
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅταν", Transliteration = "", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔλθῃ", Transliteration = "", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνδοξασθῆναι", Transliteration = "", Gloss = "to be glorified", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἁγίοις", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his saints"
                                }
                            },
                            Translation = "in his saints"
                        }
                    },
                    Translation = "to be glorified in his saints"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θαυμασθῆναι", Transliteration = "", Gloss = "to be amazed", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πᾶσιν", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "πιστεύσασιν", Transliteration = "", Gloss = "to believe", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "verb" }
                                    },
                                    Translation = "all who have believed"
                                }
                            },
                            Translation = "among all who have believed"
                        }
                    },
                    Translation = "and to be marveled at among all who have believed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "because", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐπιστεύθη", Transliteration = "", Gloss = "to believe", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "μαρτύριον", Transliteration = "", Gloss = "testimony", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "our testimony"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐφ᾽", Transliteration = "", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to you"
                        }
                    },
                    Translation = "because our testimony to you was believed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἡμέρᾳ", Transliteration = "", Gloss = "day", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἐκείνῃ", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "that day"
                        }
                    },
                    Translation = "on that day"
                }
            },
            Translation = "when he comes on that day to be glorified in his saints, and to be marveled at among all who have believed, because our testimony to you was believed."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὃ", Transliteration = "", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to this end"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "προσευχόμεθα", Transliteration = "", Gloss = "we pray", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "πάντοτε", Transliteration = "", Gloss = "always", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὑμῶν", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "for you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑμᾶς", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἀξιώσῃ", Transliteration = "", Gloss = "to consider worthy", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "κλήσεως", Transliteration = "", Gloss = "call", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of the calling"
                                }
                            },
                            Translation = "may count you worthy of the calling"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεὸς", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "our God"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πληρώσῃ", Transliteration = "", Gloss = "to fulfill", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πᾶσαν", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "εὐδοκίαν", Transliteration = "", Gloss = "goodwill", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "ἀγαθωσύνης", Transliteration = "", Gloss = "goodness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "every desire for goodness"
                                },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἔργον", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "πίστεως", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "work of faith"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "δυνάμει", Transliteration = "", Gloss = "power", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "by power"
                                }
                            },
                            Translation = "and may fulfill every desire for goodness and the work of faith with power"
                        }
                    },
                    Translation = "that our God may count you worthy of his calling, and may fulfill every desire for goodness and the work of faith with power"
                }
            },
            Translation = "To this end we always pray for you, that our God may make you worthy of his calling and may fulfill every resolve for good and every work of faith by his power,"
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅπως", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐνδοξασθῇ", Transliteration = "", Gloss = "to be glorified", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ὄνομα", Transliteration = "", Gloss = "name", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "κυρίου", Transliteration = "", Gloss = "lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of our Lord Jesus"
                        }
                    },
                    Translation = "the name of our Lord Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὑμῖν", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "in you"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμεῖς", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτῷ", Transliteration = "", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "in him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "χάριν", Transliteration = "", Gloss = "grace", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "θεοῦ", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pronoun" },
                                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                        new Word { Greek = "κυρίου", Transliteration = "", Gloss = "lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "Χριστοῦ", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of our God and the Lord Jesus Christ"
                                }
                            },
                            Translation = "the grace"
                        }
                    },
                    Translation = "according to the grace of our God and the Lord Jesus Christ"
                }
            },
            Translation = "so that the name of our Lord Jesus may be glorified in you, and you in him, according to the grace of our God and the Lord Jesus Christ"
        }
    };
}
// Constructions identified:
// V12: TSKS - τοῦ θεοῦ ἡμῶν καὶ κυρίου Ἰησοῦ Χριστοῦ (Sharp's Rule: Article-Substantive-Kai-Substantive referring to same person)
