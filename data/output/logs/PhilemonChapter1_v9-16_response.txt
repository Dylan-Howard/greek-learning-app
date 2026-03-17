private static List<object> GetChapter1()
{
    // Philemon 1:9-16
    return new List<object>
    {
        // Verse 9
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
                        new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγάπην", Transliteration = "", Gloss = "love", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "love"
                        }
                    },
                    Translation = "for love's sake"
                },
                new Word { Greek = "μᾶλλον", Transliteration = "", Gloss = "more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "παρακαλῶ", Transliteration = "", Gloss = "to ask", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοιοῦτος", Transliteration = "", Gloss = "such", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ὢν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "NOM" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "Παῦλος", Transliteration = "", Gloss = "Paul", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "πρεσβύτης", Transliteration = "", Gloss = "older man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "Paul the aged"
                                }
                            },
                            Translation = "as Paul the aged"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νυνὶ", Transliteration = "", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "NOM" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "δέσμιος", Transliteration = "", Gloss = "prisoner", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "Χριστοῦ", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "a prisoner of Christ Jesus"
                                }
                            },
                            Translation = "and now also a prisoner of Christ Jesus"
                        }
                    },
                    Translation = "being such a one as Paul the aged"
                }
            },
            Translation = "yet for love's sake I prefer to appeal to you—I, Paul, an old man and now also a prisoner of Christ Jesus—"
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "παρακαλῶ", Transliteration = "", Gloss = "to ask", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σε", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "s" },
                                new Word { Greek = "τέκνου", Transliteration = "", Gloss = "child", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "my child"
                        }
                    },
                    Translation = "for my child"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐγέννησα", Transliteration = "", Gloss = "to become the father of", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δεσμοῖς", Transliteration = "", Gloss = "chain", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the chains"
                                }
                            },
                            Translation = "in my imprisonment"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS", "ACC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ὀνήσιμον", Transliteration = "", Gloss = "Onesimus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Onesimus"
                        }
                    },
                    Translation = "whom I begot in my imprisonment, Onesimus,"
                },
                // Verse 11
                // (continues verse 10)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τόν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ποτέ", Transliteration = "", Gloss = "once", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σοι", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἄχρηστον", Transliteration = "", Gloss = "useless", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "who was once useless to you"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νυνὶ", Transliteration = "", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "σοὶ", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ἐμοὶ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" },
                                new Word { Greek = "εὔχρηστον", Transliteration = "", Gloss = "useful", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "but now is useful both to you and to me"
                        }
                    },
                    Translation = "who was once useless to you, but now is useful both to you and to me"
                }
            },
            Translation = "I appeal to you for my child, Onesimus, whose father I became in my imprisonment (who was once useless to you, but now is useful both to you and to me)."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἀνέπεμψά", Transliteration = "", Gloss = "to send", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "αὐτόν", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦτ᾽", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἔστιν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC" }, // Predicate nominative functioning as acc in apposition to 'him'
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐμὰ", Transliteration = "", Gloss = "my", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, PartOfSpeech = "s" },
                                new Word { Greek = "σπλάγχνα", Transliteration = "", Gloss = "inward parts", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "my very heart"
                        }
                    },
                    Translation = "that is, my very heart"
                }
            },
            Translation = "I am sending him back to you, sending my very heart."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐβουλόμην", Transliteration = "", Gloss = "to wish", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
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
                                new Word { Greek = "πρὸς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμαυτὸν", Transliteration = "", Gloss = "myself", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "f" }
                            },
                            Translation = "with me"
                        },
                        new Word { Greek = "κατέχειν", Transliteration = "", Gloss = "to hold back", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to keep with me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "", Gloss = "above", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σοῦ", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "on your behalf"
                        },
                        new Word { Greek = "μοι", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "διακονῇ", Transliteration = "", Gloss = "to serve", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δεσμοῖς", Transliteration = "", Gloss = "chain", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "εὐαγγελίου", Transliteration = "", Gloss = "gospel", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of the gospel"
                                        }
                                    },
                                    Translation = "the bonds of the gospel"
                                }
                            },
                            Translation = "in the bonds of the gospel"
                        }
                    },
                    Translation = "that he might serve me on your behalf in the bonds of the gospel"
                }
            },
            Translation = "I would have been glad to keep him with me, in order that he might serve me on your behalf during my imprisonment for the gospel,"
        },
        // Verse 14
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
                        new Word { Greek = "χωρὶς", Transliteration = "", Gloss = "by itself", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σῆς", Transliteration = "", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "s" },
                                new Word { Greek = "γνώμης", Transliteration = "", Gloss = "purpose", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "your consent"
                        }
                    },
                    Translation = "but without your consent"
                },
                new Word { Greek = "οὐδὲν", Transliteration = "", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἠθέλησα", Transliteration = "", Gloss = "to will", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ποιῆσαι", Transliteration = "", Gloss = "to do", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἀνάγκην", Transliteration = "", Gloss = "necessity", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "as of necessity"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "NOM" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαθόν", Transliteration = "", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σου", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your goodness"
                        },
                        new Word { Greek = "ᾖ", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀλλὰ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἑκούσιον", Transliteration = "", Gloss = "spontaneous", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "by free will"
                        }
                    },
                    Translation = "that your goodness might not be by compulsion but of your own free will"
                }
            },
            Translation = "but I preferred to do nothing without your consent in order that your goodness might not be by compulsion but of your own free will."
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τάχα", Transliteration = "", Gloss = "perhaps", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦτο", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "for this reason"
                },
                new Word { Greek = "ἐχωρίσθη", Transliteration = "", Gloss = "to divide", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὥραν", Transliteration = "", Gloss = "hour", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for a while"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αἰώνιον", Transliteration = "", Gloss = "eternal", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "αὐτὸν", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀπέχῃς", Transliteration = "", Gloss = "to receive", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" },
                        // Verse 16
                        // (continues verse 15)
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὐκέτι", Transliteration = "", Gloss = "no longer", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὡς", Transliteration = "", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "δοῦλον", Transliteration = "", Gloss = "to enslave", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "as a slave"
                                },
                                new Word { Greek = "ἀλλ᾽", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὲρ", Transliteration = "", Gloss = "above", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "δοῦλον", Transliteration = "", Gloss = "to enslave", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "more than a slave"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀδελφὸν", Transliteration = "", Gloss = "brother", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἀγαπητόν", Transliteration = "", Gloss = "dearly loved one", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "a beloved brother"
                                }
                            },
                            Translation = "no longer as a slave but more than a slave, as a beloved brother"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μάλιστα", Transliteration = "", Gloss = "especially", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἐμοί", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "especially to me"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" }, // Verbless clause acting as emphatic comparison
                            Content = new List<object>
                            {
                                new Word { Greek = "πόσῳ", Transliteration = "", Gloss = "how great?", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "q" },
                                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "μᾶλλον", Transliteration = "", Gloss = "more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σοὶ", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "σαρκὶ", Transliteration = "", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in the flesh"
                                },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "κυρίῳ", Transliteration = "", Gloss = "lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in the Lord"
                                }
                            },
                            Translation = "but how much more to you, both in the flesh and in the Lord"
                        }
                    },
                    Translation = "that you might have him back forever, no longer as a slave but more than a slave, as a beloved brother—especially to me, but how much more to you, both in the flesh and in the Lord."
                }
            },
            Translation = "For this perhaps is why he was parted from you for a while, that you might have him back forever,"
        }
    };
}
// Note: 
// - v9: "τοιοῦτος ὢν" treated as Participial Phrase modifying the subject (Paul).
// - v13: "ἵνα ... διακονῇ" treated as PURPOSE_CLAUSE.
// - v16: The long appositional chain "οὐκέτι ὡς δοῦλον..." is nested inside the PURPOSE_CLAUSE of v15 as it elaborates on how he is received.
