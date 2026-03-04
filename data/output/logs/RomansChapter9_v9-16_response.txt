private static List<object> GetChapter9()
{
    // Romans 9:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπαγγελίας", Transliteration = "epangelias", Gloss = "of promise", 
                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "word", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "this word"
                },
                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", 
                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καιρὸν", Transliteration = "kairon", Gloss = "time", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "this time"
                },
                new Word { Greek = "ἐλεύσομαι", Transliteration = "eleusomai", Gloss = "I will come", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "there shall be", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Σάρρᾳ", Transliteration = "Sarra", Gloss = "Sarah", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Sarah"
                },
                new Word { Greek = "υἱός", Transliteration = "huios", Gloss = "a son", 
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "For this is the word of promise: At this time I will come, and Sarah shall have a son."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐ", Transliteration = "Ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "μόνον", Transliteration = "monon", Gloss = "only", 
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Ῥεβέκκα", Transliteration = "Rebekka", Gloss = "Rebekah", 
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
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
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἑνὸς", Transliteration = "henos", Gloss = "one", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "from one"
                        },
                        new Word { Greek = "κοίτην", Transliteration = "koitēn", Gloss = "conception", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἔχουσα", Transliteration = "echousa", Gloss = "having", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having conceived by one"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰσαὰκ", Transliteration = "Isaak", Gloss = "Isaac", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατρὸς", Transliteration = "patros", Gloss = "father", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "Isaac our father"
                }
            },
            Translation = "And not only this, but when Rebekah also had conceived by one man, even by our father Isaac"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μήπω", Transliteration = "mēpō", Gloss = "not yet", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γεννηθέντων", Transliteration = "gennēthentōn", Gloss = "having been born", 
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πραξάντων", Transliteration = "praxantōn", Gloss = "having done", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "though they were not yet born and had done nothing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τι", Transliteration = "ti", Gloss = "anything", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἀγαθὸν", Transliteration = "agathon", Gloss = "good", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φαῦλον", Transliteration = "phaulon", Gloss = "bad", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "either good or bad"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "according to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐκλογὴν", Transliteration = "eklogēn", Gloss = "election", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "πρόθεσις", Transliteration = "prothesis", Gloss = "purpose", 
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God's purpose according to election"
                        },
                        new Word { Greek = "μένῃ", Transliteration = "menē", Gloss = "might stand", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "so that God's purpose according to election might stand"
                }
            },
            Translation = "For though they were not yet born and had done nothing either good or bad—in order that God's purpose of election might continue"
        },

        // Verse 12
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
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                            GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔργων", Transliteration = "ergōn", Gloss = "works", 
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "not because of works"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the [one]", 
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καλοῦντος", Transliteration = "kalountos", Gloss = "calling", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "because of him who calls"
                },
                new Word { Greek = "ἐρρέθη", Transliteration = "errethē", Gloss = "it was said", 
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "to her", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "μείζων", Transliteration = "meizōn", Gloss = "older", 
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the older"
                        },
                        new Word { Greek = "δουλεύσει", Transliteration = "douleusei", Gloss = "shall serve", 
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐλάσσονι", Transliteration = "elassoni", Gloss = "younger", 
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the younger"
                        }
                    },
                    Translation = "The older shall serve the younger"
                }
            },
            Translation = "not by works but by him who calls—she was told, 'The older will serve the younger.'"
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "just as", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", 
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰακὼβ", Transliteration = "Iakōb", Gloss = "Jacob", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Jacob"
                },
                new Word { Greek = "ἠγάπησα", Transliteration = "ēgapēsa", Gloss = "I loved", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Ἠσαῦ", Transliteration = "Ēsau", Gloss = "Esau", 
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐμίσησα", Transliteration = "emisēsa", Gloss = "I hated", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "As it is written, 'Jacob I loved, but Esau I hated.'"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τί", Transliteration = "Ti", Gloss = "What", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐροῦμεν", Transliteration = "eroumen", Gloss = "shall we say", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not [implies No]", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἀδικία", Transliteration = "adikia", Gloss = "unrighteousness", 
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "with", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with God"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "γένοιτο", Transliteration = "genoito", Gloss = "may it be", 
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "OPT", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "What shall we say then? Is there injustice on God's part? By no means!"
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Μωϋσεῖ", Transliteration = "Mōusei", Gloss = "Moses", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Moses"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "he says", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐλεήσω", Transliteration = "eleēsō", Gloss = "I will have mercy on", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever", 
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἐλεῶ", Transliteration = "eleō", Gloss = "I have mercy", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whomever I have mercy"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οἰκτιρήσω", Transliteration = "oiktirēsō", Gloss = "I will have compassion on", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever", 
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "οἰκτίρω", Transliteration = "oiktirō", Gloss = "I have compassion", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whomever I have compassion"
                }
            },
            Translation = "For he says to Moses, 'I will have mercy on whom I have mercy, and I will have compassion on whom I have compassion.'"
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄρα", Transliteration = "ara", Gloss = "so", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "it [is] not", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θέλοντος", Transliteration = "thelontos", Gloss = "willing", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "of the one who wills"
                },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τρέχοντος", Transliteration = "trechontos", Gloss = "running", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "of the one who runs"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐλεῶντος", Transliteration = "eleōntos", Gloss = "showing mercy", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of God who shows mercy"
                }
            },
            Translation = "So then it depends not on human will or exertion, but on God, who has mercy."
        }
    };
}

/*
Constructions Identified:
- GEN_ABS: Verse 11 (γεννηθέντων ... πραξάντων)
- REL_CLAUSE: Verse 15 (ὃν ἂν ἐλεῶ, ὃν ἂν οἰκτίρω)
- GEN_SUBJ: Verse 16 (τοῦ θέλοντος, τοῦ τρέχοντος, τοῦ ἐλεῶντος θεοῦ - substantival participles in subjective genitive relationship to implied 'mercy')
*/
