private static List<object> GetChapter3()
{
    // Philippians 3:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                new Word { Greek = "λοιπόν", Transliteration = "", Gloss = "remaining", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀδελφοί", Transliteration = "", Gloss = "brother", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "μου", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "my brothers"
                },
                new Word { Greek = "χαίρετε", Transliteration = "", Gloss = "to rejoice", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "κυρίῳ", Transliteration = "", Gloss = "lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the Lord"
                }
            },
            Translation = "Finally, my brothers, rejoice in the Lord."
        },
        // (continues verse 1)
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "αὐτὰ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "the same things"
                        },
                        new Word { Greek = "γράφειν", Transliteration = "", Gloss = "to write", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμῖν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "To write the same things to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐμοὶ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "μὲν", Transliteration = "", Gloss = "often untranslated", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" }
                    },
                    Translation = "to me indeed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐκ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "ὀκνηρόν", Transliteration = "", Gloss = "lazy", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "is not irksome"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμῖν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" }
                    },
                    Translation = "but for you"
                },
                new Word { Greek = "ἀσφαλές", Transliteration = "", Gloss = "safe", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adjective" }
            },
            Translation = "To write the same things to you is not irksome to me, and is safe for you."
        },
        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Βλέπετε", Transliteration = "", Gloss = "to see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "κύνας", Transliteration = "", Gloss = "dog", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the dogs"
                }
            },
            Translation = "Look out for the dogs"
        },
        // (continues verse 2)
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "βλέπετε", Transliteration = "", Gloss = "to see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "κακοὺς", Transliteration = "", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐργάτας", Transliteration = "", Gloss = "worker", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the evil workers"
                }
            },
            Translation = "look out for the evil workers"
        },
        // (continues verse 2)
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "βλέπετε", Transliteration = "", Gloss = "to see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "κατατομήν", Transliteration = "", Gloss = "mutilation", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the mutilation"
                }
            },
            Translation = "look out for the mutilation"
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἡμεῖς", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "γάρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐσμεν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "περιτομή", Transliteration = "", Gloss = "circumcision", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the circumcision"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "DAT_INSTR" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πνεύματι", Transliteration = "", Gloss = "wind", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "θεοῦ", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "by the Spirit of God"
                                },
                                new Word { Greek = "λατρεύοντες", Transliteration = "", Gloss = "to serve", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "who worship by the Spirit of God"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καυχώμενοι", Transliteration = "", Gloss = "to boast", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "Χριστῷ", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "in Christ Jesus"
                                }
                            },
                            Translation = "and glory in Christ Jesus"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὐκ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "σαρκὶ", Transliteration = "", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "in the flesh"
                                },
                                new Word { Greek = "πεποιθότες", Transliteration = "", Gloss = "to convince", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "and put no confidence in the flesh"
                        }
                    },
                    Translation = "who worship by the Spirit of God and glory in Christ Jesus and put no confidence in the flesh"
                }
            },
            Translation = "For we are the circumcision, who worship by the Spirit of God and glory in Christ Jesus and put no confidence in the flesh"
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καίπερ", Transliteration = "", Gloss = "though", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἔχων", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πεποίθησιν", Transliteration = "", Gloss = "confidence", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "confidence"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "σαρκί", Transliteration = "", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "even in the flesh"
                }
            },
            Translation = "though I myself have reason for confidence in the flesh also"
        },
        // (continues verse 4)
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εἴ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἄλλος", Transliteration = "", Gloss = "another", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "anyone else"
                },
                new Word { Greek = "δοκεῖ", Transliteration = "", Gloss = "to think", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πεποιθέναι", Transliteration = "", Gloss = "to convince", GrammarCodes = new List<string> { "V", "PERF", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "σαρκί", Transliteration = "", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in the flesh"
                        }
                    },
                    Translation = "to have confidence in the flesh"
                }
            },
            Translation = "If anyone else thinks he has reason for confidence in the flesh"
        },
        // (continues verse 4)
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "μᾶλλον", Transliteration = "", Gloss = "more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" }
            },
            Translation = "I have more"
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περιτομῇ", Transliteration = "", Gloss = "circumcision", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ὀκταήμερος", Transliteration = "", Gloss = "eighth day", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "circumcised on the eighth day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "γένους", Transliteration = "", Gloss = "family", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Ἰσραήλ", Transliteration = "", Gloss = "Israel", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "of the people of Israel"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φυλῆς", Transliteration = "", Gloss = "tribe", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Βενιαμίν", Transliteration = "", Gloss = "Benjamin", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "of the tribe of Benjamin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἑβραῖος", Transliteration = "", Gloss = "a Hebrew", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "Ἑβραίων", Transliteration = "", Gloss = "a Hebrew", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of Hebrews"
                        }
                    },
                    Translation = "a Hebrew of Hebrews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "νόμον", Transliteration = "", Gloss = "law", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "as to the law"
                },
                new Word { Greek = "Φαρισαῖος", Transliteration = "", Gloss = "Pharisee", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
            },
            Translation = "circumcised on the eighth day, of the people of Israel, of the tribe of Benjamin, a Hebrew of Hebrews; as to the law, a Pharisee;"
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ζῆλος", Transliteration = "", Gloss = "zeal", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "as to zeal"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διώκων", Transliteration = "", Gloss = "to pursue", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἐκκλησίαν", Transliteration = "", Gloss = "church", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the church"
                        }
                    },
                    Translation = "a persecutor of the church"
                }
            },
            Translation = "as to zeal, a persecutor of the church;"
        },
        // (continues verse 6)
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δικαιοσύνην", Transliteration = "", Gloss = "righteousness", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "νόμῳ", Transliteration = "", Gloss = "law", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "that is in the law"
                                }
                            },
                            Translation = "righteousness under the law"
                        }
                    },
                    Translation = "as to righteousness under the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενόμενος", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἄμεμπτος", Transliteration = "", Gloss = "blameless", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "found blameless"
                }
            },
            Translation = "as to righteousness under the law, blameless."
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀλλ᾽", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἅτινα", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἦν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "μοι", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "κέρδη", Transliteration = "", Gloss = "gain", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "whatever gain I had"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῦτα", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "these"
                },
                new Word { Greek = "ἥγημαι", Transliteration = "", Gloss = "to lead", GrammarCodes = new List<string> { "V", "PERF", "MID", "IND", "1S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Χριστὸν", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "Christ"
                        }
                    },
                    Translation = "for the sake of Christ"
                },
                new Word { Greek = "ζημίαν", Transliteration = "", Gloss = "loss", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
            },
            Translation = "But whatever gain I had, I counted as loss for the sake of Christ."
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "μενοῦνγε", Transliteration = "", Gloss = "rather", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἡγοῦμαι", Transliteration = "", Gloss = "to lead", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1S" }, PartOfSpeech = "verb" },
                new Word { Greek = "πάντα", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζημίαν", Transliteration = "", Gloss = "loss", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "εἶναι", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to be loss"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ὑπερέχον", Transliteration = "", Gloss = "to govern", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "N", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "γνώσεως", Transliteration = "", Gloss = "knowledge", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                        new Phrase
                                            {
                                                SyntaxCodes = new List<string> { "GEN_OBJ" },
                                                Content = new List<object>
                                                {
                                                    new Word { Greek = "Χριστοῦ", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                                    new Word { Greek = "Ἰησοῦ", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                                },
                                                Translation = "of Christ Jesus"
                                            },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                                new Word { Greek = "κυρίου", Transliteration = "", Gloss = "lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                                new Word { Greek = "μου", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                                            },
                                            Translation = "my Lord"
                                        }
                                    },
                                    Translation = "the knowledge of Christ Jesus my Lord"
                                }
                            },
                            Translation = "the surpassing worth of the knowledge of Christ Jesus my Lord"
                        }
                    },
                    Translation = "because of the surpassing worth of the knowledge of Christ Jesus my Lord"
                }
            },
            Translation = "Indeed, I count everything as loss because of the surpassing worth of knowing Christ Jesus my Lord."
        },
        // (continues verse 8)
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὃν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "for whom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πάντα", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "all things"
                },
                new Word { Greek = "ἐζημιώθην", Transliteration = "", Gloss = "to forfeit", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1S" }, PartOfSpeech = "verb" }
            },
            Translation = "for whom I have suffered the loss of all things"
        },
        // (continues verse 8)
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἡγοῦμαι", Transliteration = "", Gloss = "to lead", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1S" }, PartOfSpeech = "verb" },
                new Word { Greek = "σκύβαλα", Transliteration = "", Gloss = "rubbish", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
            },
            Translation = "and count them as rubbish"
        },
        // (continues verse 8)
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "Χριστὸν", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "κερδήσω", Transliteration = "", Gloss = "to gain", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1S" }, PartOfSpeech = "verb" }
            },
            Translation = "that I may gain Christ"
        }
    };
}

// Constructions identified:
// Verse 3: APPOS/REL_CLAUSE (Substantive Participles) "οἱ ... λατρεύοντες ... καὶ καυχώμενοι ... καὶ ... πεποιθότες" describing "ἡμεῖς".
// Verse 3: DAT_INSTR "πνεύματι θεοῦ" (worship by the Spirit).
// Verse 5: APPOS Series (Circumcised..., of the people..., etc.)
// Verse 6: APPOS Series (As to zeal..., as to righteousness...)
// Verse 8: INF_PHRASE (Indirect Statement) "ἡγοῦμαι ... ζημίαν εἶναι" (count ... to be loss).
// Verse 8: GEN_OBJ "τῆς γνώσεως Χριστοῦ Ἰησοῦ" (knowledge of Christ Jesus).
