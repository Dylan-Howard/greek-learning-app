private static List<object> GetChapter9()
{
    // 1 Corinthians 9:25-27
    return new List<object>
    {
        // Verse 25
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
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "moreover", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγωνιζόμενος", Transliteration = "agōnizomenos", Gloss = "striving", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "the one striving"
                        }
                    },
                    Translation = "Every one who competes"
                },
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "in all things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐγκρατεύεται", Transliteration = "egkrateuetai", Gloss = "exercises self-control", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Every athlete exercises self-control in all things."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐκεῖνοι", Transliteration = "ekeinoi", Gloss = "they", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "φθαρτὸν", Transliteration = "phtharton", Gloss = "perishable", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "στέφανον", Transliteration = "stephanon", Gloss = "crown", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a perishable crown"
                        },
                        new Word { Greek = "λάβωσιν", Transliteration = "labōsin", Gloss = "they might receive", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that they might receive a perishable crown"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we", GrammarCodes = new List<string> { "PRON", "NOM", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "but we"
                },
                new Word { Greek = "ἄφθαρτον", Transliteration = "aphtharton", Gloss = "imperishable", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
            },
            Translation = "They indeed do it to receive a perishable crown, but we an imperishable."
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "τοίνυν", Transliteration = "toinun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "τρέχω", Transliteration = "trechō", Gloss = "run", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀδήλως", Transliteration = "adēlōs", Gloss = "uncertainly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "as not uncertainly"
                }
            },
            Translation = "I therefore so run as not uncertainly;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "πυκτεύω", Transliteration = "pykteuō", Gloss = "box", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀέρα", Transliteration = "aera", Gloss = "air", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the air"
                        },
                        new Word { Greek = "δέρων", Transliteration = "derōn", Gloss = "beating", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "as not beating the air"
                }
            },
            Translation = "so I box as not beating the air;"
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑπωπιάζω", Transliteration = "hypōpiazō", Gloss = "I buffet", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῶμα", Transliteration = "sōma", Gloss = "body", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "my body"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δουλαγωγῶ", Transliteration = "doulagōgō", Gloss = "make it a slave", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but I discipline my body and make it my slave,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μή", Transliteration = "mē", Gloss = "lest", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "prep" },
                new Word { Greek = "πως", Transliteration = "pōs", Gloss = "somehow", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄλλοις", Transliteration = "allois", Gloss = "to others", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κηρύξας", Transliteration = "kēryxas", Gloss = "having preached", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having preached to others"
                },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "myself", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀδόκιμος", Transliteration = "adokimos", Gloss = "disqualified", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "γένωμαι", Transliteration = "genōmai", Gloss = "I might become", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "lest somehow, after having preached to others, I myself should be disqualified."
        }
    };
}

/*
Constructions identified:
- PTCP (Substantival Participle): ὁ ἀγωνιζόμενος (v25)
- PURPOSE_CLAUSE: ἵνα ... λάβωσιν (v25)
- PTCP (Circumstantial Participle): δέρων (v26)
- PTCP (Adverbial Participle): κηρύξας (v27)
- PURPOSE_CLAUSE (Negative): μή πως ... γένωμαι (v27)
*/
