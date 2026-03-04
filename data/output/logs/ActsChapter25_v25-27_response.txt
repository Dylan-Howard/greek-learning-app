private static List<object> GetChapter25()
{
    // Acts 25:25-27
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "κατελαβόμην", Transliteration = "katelabomēn", Gloss = "found",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲν", Transliteration = "mēden", Gloss = "nothing",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἄξιον", Transliteration = "axion", Gloss = "worthy",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "θανάτου", Transliteration = "thanatou", Gloss = "of death",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πεπραχέναι", Transliteration = "peprachenai", Gloss = "to have done",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that he had done nothing worthy of death"
                },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "he",
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this man",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "ἐπικαλεσαμένου", Transliteration = "epikalesamenou", Gloss = "having appealed to",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Σεβαστὸν", Transliteration = "Sebaston", Gloss = "Augustus",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the Emperor"
                        }
                    },
                    Translation = "and as he himself appealed to the Emperor"
                },
                new Word { Greek = "ἔκρινα", Transliteration = "ekrina", Gloss = "I decided",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "πέμπειν", Transliteration = "pempein", Gloss = "to send",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "But I found that he had done nothing worthy of death, and as he himself appealed to the Emperor, I decided to send him."
        },
        // Verse 26
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
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "concerning whom"
                },
                new Word { Greek = "ἀσφαλές", Transliteration = "asphales", Gloss = "definite",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "τι", Transliteration = "ti", Gloss = "something",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "part" },
                new Word { Greek = "γράψαι", Transliteration = "grapsai", Gloss = "to write",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "lord",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to my lord"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἔχω", Transliteration = "echō", Gloss = "I have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "I have nothing definite to write to my lord about him."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διὸ", Transliteration = "dio", Gloss = "Therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "προήγαγον", Transliteration = "proēgagon", Gloss = "I have brought forward",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐφ᾽", Transliteration = "eph'", Gloss = "before",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "before you"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μάλιστα", Transliteration = "malista", Gloss = "especially",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "before",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "before you"
                },
                new Word { Greek = "βασιλεῦ", Transliteration = "basileu", Gloss = "King",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "Ἀγρίππα", Transliteration = "Agrippa", Gloss = "Agrippa",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "hopōs", Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "GEN_ABS" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνακρίσεως", Transliteration = "anakriseōs", Gloss = "examination",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the examination"
                                },
                                new Word { Greek = "γενομένης", Transliteration = "genomenēs", Gloss = "having taken place",
                                    GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "F", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "after the examination has taken place"
                        },
                        new Word { Greek = "σχῶ", Transliteration = "schō", Gloss = "I may have",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "something",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "γράψω", Transliteration = "grapsō", Gloss = "I may write",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "so that, after the examination has taken place, I may have something to write."
                }
            },
            Translation = "Therefore I have brought him before you all, and especially before you, King Agrippa, so that, after the examination has taken place, I may have something to write."
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄλογον", Transliteration = "alogon", Gloss = "unreasonable",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me",
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δοκεῖ", Transliteration = "dokei", Gloss = "it seems",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέμποντα", Transliteration = "pemponta", Gloss = "sending",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δέσμιον", Transliteration = "desmion", Gloss = "a prisoner",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "against",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "against him"
                                },
                                new Word { Greek = "αἰτίας", Transliteration = "aitias", Gloss = "charges",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the charges against him"
                        },
                        new Word { Greek = "σημᾶναι", Transliteration = "sēmanai", Gloss = "to signify",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "sending a prisoner and not also signifying the charges against him"
                }
            },
            Translation = "For it seems to me unreasonable to send a prisoner without also indicating the charges against him."
        }
    };
}

/*
Identified Constructions:
- GEN_ABS: Acts 25:25 (τούτου ἐπικαλεσαμένου), Acts 25:26 (τῆς ἀνακρίσεως γενομένης)
- INF_PHRASE: Acts 25:25 (μηδὲν ἄξιον θανάτου αὐτὸν πεπραχέναι), Acts 25:27 (πέμποντα... σημᾶναι)
- VOC: Acts 25:26 (βασιλεῦ Ἀγρίππα)
- PURPOSE_CLAUSE: Acts 25:26 (ὅπως... σχῶ τί γράψω)
*/
