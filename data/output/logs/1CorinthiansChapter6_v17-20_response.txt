private static List<object> GetChapter6()
{
    // 1 Corinthians 6:17-20
    return new List<object>
    {
        // Verse 17
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κολλώμενος", Transliteration = "kollōmenos", Gloss = "joining", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "to the Lord"
                                }
                            },
                            Translation = "who is joined to the Lord"
                        }
                    },
                    Translation = "But the one who is joined to the Lord"
                },
                new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "πνεῦμά", Transliteration = "pneuma", Gloss = "spirit", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But he who is joined to the Lord is one spirit with him."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Φεύγετε", Transliteration = "Pheujete", Gloss = "flee", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πορνείαν", Transliteration = "porneian", Gloss = "sexual immorality", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "sexual immorality"
                }
            },
            Translation = "Flee from sexual immorality."
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
                        new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἁμάρτημα", Transliteration = "hamartēma", Gloss = "sin", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Every sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ποιήσῃ", Transliteration = "poiēsē", Gloss = "might do", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "a person", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "that a person commits"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκτὸς", Transliteration = "ektos", Gloss = "outside", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σώματός", Transliteration = "sōmatos", Gloss = "body", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the body"
                        }
                    },
                    Translation = "is outside the body"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Every sin that a person commits is outside the body,"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πορνεύων", Transliteration = "porneuōn", Gloss = "committing sexual immorality", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but the one committing sexual immorality"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἴδιον", Transliteration = "idion", Gloss = "own", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σῶμα", Transliteration = "sōma", Gloss = "body", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "his own body"
                        }
                    },
                    Translation = "against his own body"
                },
                new Word { Greek = "ἁμαρτάνει", Transliteration = "hamartanei", Gloss = "sins", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but the sexually immoral person sins against his own body."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οἴδατε", Transliteration = "oidate", Gloss = "do you know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σῶμα", Transliteration = "sōma", Gloss = "body", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your body"
                        },
                        new Word { Greek = "ναὸς", Transliteration = "naos", Gloss = "a temple", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "in you"
                                },
                                new Word { Greek = "ἁγίου", Transliteration = "hagiou", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "πνεύματός", Transliteration = "pneumatos", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the Holy Spirit within you"
                        },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that your body is a temple of the Holy Spirit within you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἔχετε", Transliteration = "echete", Gloss = "you have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from God"
                        }
                    },
                    Translation = "whom you have from God?"
                }
            },
            Translation = "Or do you not know that your body is a temple of the Holy Spirit within you, whom you have from God?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐστὲ", Transliteration = "este", Gloss = "you are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "your own", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "f" }
            },
            Translation = "You are not your own,"
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἠγοράσθητε", Transliteration = "ēgorasthēte", Gloss = "you were bought", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τιμῆς", Transliteration = "timēs", Gloss = "at a price", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
            },
            Translation = "for you were bought with a price."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δοξάσατε", Transliteration = "doxasate", Gloss = "glorify", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὴ", Transliteration = "dē", Gloss = "therefore", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σώματι", Transliteration = "sōmati", Gloss = "body", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your body"
                        }
                    },
                    Translation = "in your body"
                }
            },
            Translation = "So glorify God in your body."
        }
    };
}

/*
Constructions identified:
- Substantival Participle: v17 (ὁ κολλώμενος), v18 (ὁ πορνεύων)
- Genitive of Price: v20 (τιμῆς)
- Genitive of Possession/Source: v19 (θεοῦ)
- Attributive Genitive: v19 (ἁγίου πνεύματος)
*/
