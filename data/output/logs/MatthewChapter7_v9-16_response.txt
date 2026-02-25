private static List<object> GetChapter7()
{
    // Matthew 7:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τίς", Transliteration = "tis",
                    Gloss = "what",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἐστιν", Transliteration = "estin",
                    Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex",
                            Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "of you"
                },
                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos",
                    Gloss = "man",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon",
                            Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "αἰτήσει", Transliteration = "aitēsei",
                            Gloss = "will ask",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "υἱὸς", Transliteration = "huios",
                                    Gloss = "son",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                    Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "his son"
                        },
                        new Word { Greek = "ἄρτον", Transliteration = "arton",
                            Gloss = "bread",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "whom his son will ask for bread"
                },
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "λίθον", Transliteration = "lithon",
                    Gloss = "stone",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἐπιδώσει", Transliteration = "epidōsei",
                    Gloss = "will give",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "Or what man is there of you, whom his son will ask for bread, will he give him a stone?"
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἰχθὺν", Transliteration = "ichthyn",
                    Gloss = "fish",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "αἰτήσει", Transliteration = "aitēsei",
                    Gloss = "he will ask",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ὄφιν", Transliteration = "ophin",
                    Gloss = "serpent",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἐπιδώσει", Transliteration = "epidōsei",
                    Gloss = "will give",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "Or if also he will ask for a fish, will he give him a serpent?"
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei",
                    Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "then",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πονηροὶ", Transliteration = "ponēroi",
                            Gloss = "evil",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ὄντες", Transliteration = "ontes",
                            Gloss = "being",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "being evil"
                },
                new Word { Greek = "οἴδατε", Transliteration = "oidate",
                    Gloss = "know how",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δόματα", Transliteration = "domata",
                            Gloss = "gifts",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἀγαθὰ", Transliteration = "agatha",
                            Gloss = "good",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "good gifts"
                },
                new Word { Greek = "διδόναι", Transliteration = "didonai",
                    Gloss = "to give",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τέκνοις", Transliteration = "teknois",
                            Gloss = "children",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to your children"
                }
            },
            Translation = "If you then, being evil, know how to give good gifts to your children,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 11)
                new Word { Greek = "πόσῳ", Transliteration = "posō",
                    Gloss = "how much",
                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                    PartOfSpeech = "q" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon",
                    Gloss = "more",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πατὴρ", Transliteration = "patēr",
                            Gloss = "Father",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανοῖς", Transliteration = "ouranois",
                                            Gloss = "heavens",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the heavens"
                                }
                            },
                            Translation = "who is in the heavens"
                        }
                    },
                    Translation = "your Father who is in the heavens"
                },
                new Word { Greek = "δώσει", Transliteration = "dōsei",
                    Gloss = "will give",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀγαθὰ", Transliteration = "agatha",
                    Gloss = "good things",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois",
                            Gloss = "to those",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αἰτοῦσιν", Transliteration = "aitousin",
                                    Gloss = "who ask",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton",
                                    Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "who ask him"
                        }
                    },
                    Translation = "to those who ask him"
                }
            },
            Translation = "how much more will your Father who is in the heavens give good things to those who ask him!"
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πάντα", Transliteration = "Panta",
                            Gloss = "all things",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "οὖν", Transliteration = "oun",
                            Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅσα", Transliteration = "hosa",
                                    Gloss = "whatever",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                                    PartOfSpeech = "k" },
                                new Word { Greek = "ἐὰν", Transliteration = "ean",
                                    Gloss = "if",
                                    GrammarCodes = new List<string> { "PART" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "θέλητε", Transliteration = "thelēte",
                                    Gloss = "you might wish",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἵνα", Transliteration = "hina",
                                            Gloss = "that",
                                            GrammarCodes = new List<string> { "CONJ" },
                                            PartOfSpeech = "conj" },
                                        new Word { Greek = "ποιῶσιν", Transliteration = "poiōsin",
                                            Gloss = "they should do",
                                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" },
                                            PartOfSpeech = "v" },
                                        new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                                            Gloss = "to you",
                                            GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "οἱ", Transliteration = "hoi",
                                                    Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                               
