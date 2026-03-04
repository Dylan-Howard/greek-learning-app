private static List<object> GetChapter7()
{
    // Romans 7:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔζων", Transliteration = "ezōn", Gloss = "was alive", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χωρὶς", Transliteration = "chōris", Gloss = "apart from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "apart from the law"
                },
                new Word { Greek = "ποτέ", Transliteration = "pote", Gloss = "once", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" }
            },
            Translation = "I was once alive apart from the law"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθούσης", Transliteration = "elthousēs", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἐντολῆς", Transliteration = "entolēs", Gloss = "commandment", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the commandment"
                        }
                    },
                    Translation = "but when the commandment came"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "sin"
                },
                new Word { Greek = "ἀνέζησεν", Transliteration = "anezēsen", Gloss = "revived", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "but when the commandment came, sin revived"
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἀπέθανον", Transliteration = "apethanon", Gloss = "died", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "and I died"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εὑρέθη", Transliteration = "heurethē", Gloss = "was found", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐντολὴ", Transliteration = "entolē", Gloss = "commandment", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "ζωήν", Transliteration = "zōēn", Gloss = "life", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "for life"
                                }
                            },
                            Translation = "which was for life"
                        }
                    },
                    Translation = "the commandment which was for life"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὕτη", Transliteration = "hautē", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "θάνατον", Transliteration = "thanaton", Gloss = "death", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "to death"
                        }
                    },
                    Translation = "this [was found to be] to death"
                }
            },
            Translation = "and the commandment which was for life, this was found to be for death to me"
        },
        // Verse 11
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "for sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀφορμὴν", Transliteration = "aphormēn", Gloss = "opportunity", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "λαβοῦσα", Transliteration = "labousa", Gloss = "having taken", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἐντολῆς", Transliteration = "entolēs", Gloss = "commandment", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the commandment"
                                }
                            },
                            Translation = "through the commandment"
                        }
                    },
                    Translation = "having taken opportunity through the commandment"
                },
                new Word { Greek = "ἐξηπάτησέν", Transliteration = "exēpatēsen", Gloss = "deceived", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", GrammarCodes = new List<string> { "PRON", "ACC", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "it", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "through it"
                },
                new Word { Greek = "ἀπέκτεινεν", Transliteration = "apekteinen", Gloss = "killed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "For sin, having taken opportunity through the commandment, deceived me and through it killed me"
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "νόμος", Transliteration = "nomos", Gloss = "law", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the law indeed"
                },
                new Word { Greek = "ἅγιος", Transliteration = "hagios", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
            },
            Translation = "So the law indeed is holy"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐντολὴ", Transliteration = "entolē", Gloss = "commandment", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the commandment"
                },
                new Word { Greek = "ἁγία", Transliteration = "hagia", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "δικαία", Transliteration = "dikaia", Gloss = "righteous", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἀγαθή", Transliteration = "agathē", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" }
            },
            Translation = "and the commandment is holy and righteous and good"
        },
        // Verse 13
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
                        new Word { Greek = "Τὸ", Transliteration = "To", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἀγαθὸν", Transliteration = "agathon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the good then"
                },
                new Word { Greek = "ἐμοὶ", Transliteration = "emoi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "become", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "death", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
            },
            Translation = "Did that which is good then become death to me?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "γένοιτο", Transliteration = "genoito", Gloss = "may it be", GrammarCodes = new List<string> { "V", "AOR", "MID", "OPT", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "May it not be!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "φανῇ", Transliteration = "phanē", Gloss = "it might be shown", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in order that it might be shown to be sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἀγαθοῦ", Transliteration = "agathou", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "the good"
                                }
                            },
                            Translation = "through the good"
                        },
                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "κατεργαζομένη", Transliteration = "katergazomenē", Gloss = "producing", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "θάνατον", Transliteration = "thanaton", Gloss = "death", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "producing death in me through the good"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "γένηται", Transliteration = "genētai", Gloss = "it might become", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑπερβολὴν", Transliteration = "hyperbolēn", Gloss = "excess", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "beyond measure"
                        },
                        new Word { Greek = "ἁμαρτωλὸς", Transliteration = "hamartōlos", Gloss = "sinful", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "sin"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἐντολῆς", Transliteration = "entolēs", Gloss = "commandment", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the commandment"
                                }
                            },
                            Translation = "through the commandment"
                        }
                    },
                    Translation = "in order that through the commandment sin might become sinful beyond measure"
                }
            },
            Translation = "But it was sin, producing death in me through what is good, in order that sin might be shown to be sin, and through the commandment might become sinful beyond measure."
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οἴδαμεν", Transliteration = "Oidamen", Gloss = "we know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "νόμος", Transliteration = "nomos", Gloss = "law", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the law"
                        },
                        new Word { Greek = "πνευματικός", Transliteration = "pneumatikos", Gloss = "spiritual", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that the law is spiritual"
                }
            },
            Translation = "For we know that the law is spiritual"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "σάρκινός", Transliteration = "sarkinos", Gloss = "fleshly", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                new Word { Greek = "εἰμι", Transliteration = "eimi", Gloss = "am", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πεπραμένος", Transliteration = "pepramenos", Gloss = "having been sold", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian", Gloss = "sin", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "sin"
                                }
                            },
                            Translation = "under sin"
                        }
                    },
                    Translation = "sold under sin"
                }
            },
            Translation = "but I am fleshly, sold under sin"
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "κατεργάζομαι", Transliteration = "katergazomai", Gloss = "I do", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "for what I do"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "γινώσκω", Transliteration = "ginōskō", Gloss = "I understand", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "For I do not understand what I am doing"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I want", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "what I want"
                },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "πράσσω", Transliteration = "prassō", Gloss = "I do", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "for I do not do what I want"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "μισῶ", Transliteration = "misō", Gloss = "I hate", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "what I hate"
                },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ποιῶ", Transliteration = "poiō", Gloss = "I do", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "but I do the very thing I hate"
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                                new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I want", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "what I do not want"
                        },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ποιῶ", Transliteration = "poiō", Gloss = "I do", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "Now if I do what I do not want"
                },
                new Word { Greek = "σύμφημι", Transliteration = "symphēmi", Gloss = "I agree with", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "νόμῳ", Transliteration = "nomō", Gloss = "law", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "with the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "καλός", Transliteration = "kalos", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "that it is good"
                }
            },
            Translation = "Now if I do what I do not want, I agree with the law, that it is good"
        }
    };
}
/*
Constructions identified:
- GEN_ABS: ἐλθούσης δὲ τῆς ἐντολῆς (v9)
*/
