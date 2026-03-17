private static List<object> GetChapter11()
{
    // 1 Corinthians 11:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τοῦτο", Transliteration = "Touto", Gloss = "this",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραγγέλλων", Transliteration = "parangellōn", Gloss = "ordering",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "in giving this instruction"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐπαινῶ", Transliteration = "epainō", Gloss = "I praise",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κρεῖσσον", Transliteration = "kreisson", Gloss = "better",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "the better"
                                }
                            },
                            Translation = "for the better"
                        },
                        new Word { Greek = "ἀλλ᾽", Transliteration = "all’", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἧσσον", Transliteration = "hēsson", Gloss = "worse",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "the worse"
                                }
                            },
                            Translation = "for the worse"
                        },
                        new Word { Greek = "συνέρχεσθε", Transliteration = "synerchesthe", Gloss = "you come together",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "because you come together not for the better but for the worse"
                }
            },
            Translation = "But in giving this instruction, I do not praise you, because you come together not for the better but for the worse."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συνερχομένων", Transliteration = "synerchomenōn", Gloss = "coming together",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "when you come together"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐκκλησίᾳ", Transliteration = "ekklēsia", Gloss = "church",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "as a church"
                },
                new Word { Greek = "ἀκούω", Transliteration = "akouō", Gloss = "I hear",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σχίσματα", Transliteration = "schismata", Gloss = "divisions",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "among you"
                        },
                        new Word { Greek = "ὑπάρχειν", Transliteration = "hyparchein", Gloss = "to exist",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that divisions exist among you"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μέρος", Transliteration = "meros", Gloss = "part",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τι", Transliteration = "ti", Gloss = "some",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "part" }
                    },
                    Translation = "in part"
                },
                new Word { Greek = "πιστεύω", Transliteration = "pisteuō", Gloss = "I believe",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "For, in the first place, when you come together as a church, I hear that divisions exist among you; and I believe it in part."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱρέσεις", Transliteration = "haireseis", Gloss = "factions",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "among you"
                        },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "factions to exist among you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δόκιμοι", Transliteration = "dokimoi", Gloss = "approved",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "those who are approved"
                        },
                        new Word { Greek = "φανεροὶ", Transliteration = "phaneroi", Gloss = "evident",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "γένωνται", Transliteration = "genōntai", Gloss = "might become",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "among you"
                        }
                    },
                    Translation = "so that those who are approved may become evident among you"
                }
            },
            Translation = "For it is necessary for factions to exist among you, so that those who are approved may become evident among you."
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Συνερχομένων", Transliteration = "Synerchomenōn", Gloss = "coming together",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "Therefore, when you come together"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αὐτὸ", Transliteration = "auto", Gloss = "same place",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "the same place"
                        }
                    },
                    Translation = "in one place"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "it is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κυριακὸν", Transliteration = "kyriakon", Gloss = "the Lord's",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "δεῖπνον", Transliteration = "deipnon", Gloss = "supper",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Lord's Supper"
                },
                new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "to eat",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "Therefore, when you come together in one place, it is not to eat the Lord’s Supper."
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "each one",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἴδιον", Transliteration = "idion", Gloss = "own",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "δεῖπνον", Transliteration = "deipnon", Gloss = "supper",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "his own supper"
                },
                new Word { Greek = "προλαμβάνει", Transliteration = "prolambanei", Gloss = "takes beforehand",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "eating",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "in the eating"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "one",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πεινᾷ", Transliteration = "peina", Gloss = "is hungry",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "one is hungry"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "another",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μεθύει", Transliteration = "methyei", Gloss = "gets drunk",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "another gets drunk"
                }
            },
            Translation = "For in the eating, each one takes his own supper beforehand; and one is hungry while another gets drunk."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οἰκίας", Transliteration = "oikias", Gloss = "houses",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἔχετε", Transliteration = "echete", Gloss = "you have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐσθίειν", Transliteration = "esthiein", Gloss = "eating",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πίνειν", Transliteration = "pinein", Gloss = "drinking",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to eat and drink in"
                },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκκλησίας", Transliteration = "ekklēsias", Gloss = "church",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the church of God"
                },
                new Word { Greek = "καταφρονεῖτε", Transliteration = "kataphroneite", Gloss = "do you despise",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καταισχύνετε", Transliteration = "kataischynete", Gloss = "humiliate",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἔχοντας", Transliteration = "echontas", Gloss = "having",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "those who have nothing"
                },
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "εἴπω", Transliteration = "eipō", Gloss = "should I say",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐπαινέσω", Transliteration = "epainesō", Gloss = "should I praise",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "in this"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐπαινῶ", Transliteration = "epainō", Gloss = "I praise",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "What? Do you not have houses to eat and drink in? Or do you despise the church of God and humiliate those who have nothing? What shall I say to you? Shall I praise you in this? I do not praise you."
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐγὼ", Transliteration = "Egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παρέλαβον", Transliteration = "parelabon", Gloss = "received",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Lord"
                        }
                    },
                    Translation = "from the Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "παρέδωκα", Transliteration = "paredōka", Gloss = "I delivered",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "which I also delivered to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Lord Jesus"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "νυκτὶ", Transliteration = "nykti", Gloss = "night",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the night"
                                }
                            },
                            Translation = "on the night"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ᾗ", Transliteration = "hē", Gloss = "in which",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "παρεδίδετο", Transliteration = "paredideto", Gloss = "he was betrayed",
                                    GrammarCodes = new List<string> { "V", "IMPF", "PASS", "IND", "3P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "when He was betrayed"
                        },
                        new Word { Greek = "ἔλαβεν", Transliteration = "elaben", Gloss = "took",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἄρτον", Transliteration = "arton", Gloss = "bread",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "that the Lord Jesus on the night when He was betrayed took bread"
                }
            },
            Translation = "For I received from the Lord what I also delivered to you, that the Lord Jesus on the night when He was betrayed took bread."
        },

        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐχαριστήσας", Transliteration = "eucharistēsas", Gloss = "having given thanks",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "when He had given thanks"
                },
                new Word { Greek = "ἔκλασεν", Transliteration = "eklasen", Gloss = "He broke",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "He said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦτό", Transliteration = "touto", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "μού", Transliteration = "mou", Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σῶμα", Transliteration = "sōma", Gloss = "body",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the body"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "for you"
                                }
                            },
                            Translation = "which is for you"
                        }
                    },
                    Translation = "This is my body which is for you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "ποιεῖτε", Transliteration = "poieite", Gloss = "do",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐμὴν", Transliteration = "emēn", Gloss = "my",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                            PartOfSpeech = "s" },
                                        new Word { Greek = "ἀνάμνησιν", Transliteration = "anamnēsin", Gloss = "remembrance",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "my remembrance"
                                }
                            },
                            Translation = "in remembrance of me"
                        }
                    },
                    Translation = "do this in remembrance of me"
                }
            },
            Translation = "and when He had given thanks, He broke it and said, “This is My body, which is for you; do this in remembrance of Me.”"
        }
    };
}

/* Identified Constructions:
   - GEN_ABS: Verse 18 (συνερχομένων ὑμῶν), Verse 20 (Συνερχομένων οὖν ὑμῶν)
   - INF_PHRASE: Verse 19 (αἱρέσεις... εἶναι)
   - APPOS: Verse 24 (τὸ ὑπὲρ ὑμῶν)
*/
