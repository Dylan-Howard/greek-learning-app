private static List<object> GetChapter14()
{
    // Romans 14:1-8
    return new List<object>
    {
        // Verse 1
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
                        new Word { Greek = "Τὸν", Transliteration = "Ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀσθενοῦντα", Transliteration = "asthenounta", Gloss = "one being weak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πίστει", Transliteration = "pistei", Gloss = "faith", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the faith"
                        }
                    },
                    Translation = "the one who is weak in the faith"
                },
                new Word { Greek = "προσλαμβάνεσθε", Transliteration = "proslambanesthe", Gloss = "receive", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "διακρίσεις", Transliteration = "diakriseis", Gloss = "quarrels", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "διαλογισμῶν", Transliteration = "dialogismōn", Gloss = "over opinions", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to quarrels over opinions"
                }
            },
            Translation = "As for the one who is weak in faith, welcome him, but not for quarrels over opinions."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "one", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" }
                    },
                    Translation = "One person"
                },
                new Word { Greek = "πιστεύει", Transliteration = "pisteuei", Gloss = "believes", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "he may eat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "he may eat all things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀσθενῶν", Transliteration = "asthenōn", Gloss = "one being weak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but the one who is weak"
                },
                new Word { Greek = "λάχανα", Transliteration = "lachana", Gloss = "vegetables", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐσθίει", Transliteration = "esthiei", Gloss = "eats", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "One person believes he may eat anything, while the weak person eats only vegetables."
        },

        // Verse 3
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐσθίων", Transliteration = "esthiōn", Gloss = "one eating", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "The one who eats"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐσθίοντα", Transliteration = "esthionta", Gloss = "one not eating", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who does not eat"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐξουθενείτω", Transliteration = "exoutheneitō", Gloss = "let [him] despise", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐσθίων", Transliteration = "esthiōn", Gloss = "one not eating", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "and the one who does not eat"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐσθίοντα", Transliteration = "esthionta", Gloss = "one eating", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who eats"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "κρινέτω", Transliteration = "krinetō", Gloss = "let [him] judge", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "προσελάβετο", Transliteration = "proselabeto", Gloss = "welcomed", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "for God has welcomed him"
                }
            },
            Translation = "Let not the one who eats despise the one who abstains, and let not the one who abstains pass judgment on the one who eats, for God has welcomed him."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "εἶ", Transliteration = "ei", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κρίνων", Transliteration = "krinōn", Gloss = "one judging", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀλλότριον", Transliteration = "allotrion", Gloss = "another's", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "οἰκέτην", Transliteration = "oiketēn", Gloss = "servant", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "another's servant"
                        }
                    },
                    Translation = "the one who judges another's servant"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἰδίῳ", Transliteration = "idiō", Gloss = "own", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "master", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to his own master"
                },
                new Word { Greek = "στήκει", Transliteration = "stēkei", Gloss = "he stands", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πίπτει", Transliteration = "piptei", Gloss = "he falls", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σταθήσεται", Transliteration = "stathēsetai", Gloss = "he will be upheld", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δυνατεῖ", Transliteration = "dynatei", Gloss = "is able", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Lord"
                        },
                        new Word { Greek = "στῆσαι", Transliteration = "stēsai", Gloss = "to make stand", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "for the Lord is able to make him stand"
                }
            },
            Translation = "Who are you to pass judgment on the servant of another? It is before his own master that he stands or falls. And he will be upheld, for the Lord is able to make him stand."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ὃς", Transliteration = "Hos", Gloss = "One person", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "One person"
                },
                new Word { Greek = "κρίνει", Transliteration = "krinei", Gloss = "esteems", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "above", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "above another day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "another", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "while another"
                },
                new Word { Greek = "κρίνει", Transliteration = "krinei", Gloss = "esteems", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "πᾶσαν", Transliteration = "pasan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "Each one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἰδίῳ", Transliteration = "idiō", Gloss = "own", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "νοῒ", Transliteration = "noi", Gloss = "mind", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in his own mind"
                        },
                        new Word { Greek = "πληροφορείσθω", Transliteration = "plērophoreisthō", Gloss = "let be fully convinced", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "Each one should be fully convinced in his own mind."
                }
            },
            Translation = "One person esteems one day as better than another, while another esteems all days alike. Each one should be fully convinced in his own mind."
        },

        // Verse 6
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "The one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φρονῶν", Transliteration = "phronōn", Gloss = "observing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "The one who observes"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the day"
                },
                new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "to the Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "φρονεῖ", Transliteration = "phronei", Gloss = "observes [it]", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐσθίων", Transliteration = "esthiōn", Gloss = "eating", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who eats"
                },
                new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "to the Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐσθίει", Transliteration = "esthiei", Gloss = "eats", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "εὐχαριστεῖ", Transliteration = "eucharistei", Gloss = "he gives thanks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐσθίων", Transliteration = "esthiōn", Gloss = "abstaining", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who abstains"
                },
                new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "to the Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "does not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐσθίει", Transliteration = "esthiei", Gloss = "eat", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εὐχαριστεῖ", Transliteration = "eucharistei", Gloss = "gives thanks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                }
            },
            Translation = "The one who observes the day, observes it in honor of the Lord. The one who eats, eats in honor of the Lord, since he gives thanks to God, while the one who abstains, abstains in honor of the Lord and gives thanks to God."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "none", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἑαυτῷ", Transliteration = "heautō", Gloss = "to himself", GrammarCodes = new List<string> { "PRON", "DAT", "M", "3S" }, PartOfSpeech = "f" },
                new Word { Greek = "ζῇ", Transliteration = "zē", Gloss = "lives", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "none", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἑαυτῷ", Transliteration = "heautō", Gloss = "to himself", GrammarCodes = new List<string> { "PRON", "DAT", "M", "3S" }, PartOfSpeech = "f" },
                new Word { Greek = "ἀποθνῄσκει", Transliteration = "apothnēskei", Gloss = "dies", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For none of us lives to himself, and none of us dies to himself."
        },

        // Verse 8
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
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "both", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ζῶμεν", Transliteration = "zōmen", Gloss = "we live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "For if we live"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the Lord"
                },
                new Word { Greek = "ζῶμεν", Transliteration = "zōmen", Gloss = "we live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀποθνῄσκωμεν", Transliteration = "apothnēskōmen", Gloss = "we die", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "and if we die"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the Lord"
                },
                new Word { Greek = "ἀποθνῄσκομεν", Transliteration = "apothnēskomen", Gloss = "we die", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ζῶμεν", Transliteration = "zōmen", Gloss = "we live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀποθνῄσκωμεν", Transliteration = "apothnēskōmen", Gloss = "we die", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord's", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Lord's"
                        },
                        new Word { Greek = "ἐσμέν", Transliteration = "esmen", Gloss = "we are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "So then, whether we live or whether we die, we are the Lord's."
                }
            },
            Translation = "For if we live, we live to the Lord, and if we die, we die to the Lord. So then, whether we live or whether we die, we are the Lord's."
        }
    };
}

/*
Constructions Identified:
- DAT_REF: τῇ πίστει (v1), τῷ ἰδίῳ κυρίῳ (v4), τῷ κυρίῳ (v8)
- COND_CLAUSE: ἐάν τε γὰρ ζῶμεν... (v8)
- NOUN_PHRASE (Substantival Participle): Τὸν ἀσθενοῦντα (v1), ὁ ἀσθενῶν (v2), ὁ ἐσθίων (v3)
*/
