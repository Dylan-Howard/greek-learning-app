private static List<object> GetChapter13()
{
    // Hebrews 13:1-8
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "φιλαδελφία", Transliteration = "philadelphia", Gloss = "brotherly love", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "brotherly love"
                },
                new Word { Greek = "μενέτω", Transliteration = "menetō", Gloss = "let remain", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, Part_of_speech = "v" }
            },
            Translation = "Let brotherly love remain."
        },

        // Verse 2
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
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "φιλοξενίας", Transliteration = "philoxenias", Gloss = "hospitality", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "hospitality"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, Part_of_speech = "prep" },
                new Word { Greek = "ἐπιλανθάνεσθε", Transliteration = "epilanthanesthe", Gloss = "do forget", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, Part_of_speech = "v" },
            },
            Translation = "Do not neglect hospitality,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "ταύτης", Transliteration = "tautēs", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, Part_of_speech = "adv" }
                    },
                    Translation = "through this"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "ἔλαθόν", Transliteration = "elathon", Gloss = "unaware", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, Part_of_speech = "v" },
                new Word { Greek = "τινες", Transliteration = "tines", Gloss = "some", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, Part_of_speech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ξενίσαντες", Transliteration = "xenisantes", Gloss = "having entertained", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" },
                        new Word { Greek = "ἀγγέλους", Transliteration = "angelous", Gloss = "angels", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, Part_of_speech = "n" }
                    },
                    Translation = "having entertained angels"
                }
            },
            Translation = "for through this some have entertained angels unawares."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μιμνῄσκεσθε", Transliteration = "mimnēskesthe", Gloss = "remember", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "δεσμίων", Transliteration = "desmiōn", Gloss = "prisoners", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, Part_of_speech = "n" }
                    },
                    Translation = "the prisoners"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "συνδεδεμένοι", Transliteration = "syndedemenoi", Gloss = "being bound with [them]", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" }
            },
            Translation = "Remember the prisoners, as though in prison with them,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "those", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "κακουχουμένων", Transliteration = "kakouchoumenōn", Gloss = "being mistreated", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "M", "P" }, Part_of_speech = "v" }
                    },
                    Translation = "those being mistreated"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "yourselves", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, Part_of_speech = "prep" },
                new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "σώματι", Transliteration = "sōmati", Gloss = "the body", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "in the body"
                }
            },
            Translation = "and those who are mistreated, since you yourselves are also in the body."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τίμιος", Transliteration = "timios", Gloss = "held in honor", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, Part_of_speech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "γάμος", Transliteration = "gamos", Gloss = "marriage", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "marriage"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "πᾶσιν", Transliteration = "pasin", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, Part_of_speech = "adj" }
                    },
                    Translation = "among all"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "κοίτη", Transliteration = "koitē", Gloss = "bed", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "the bed"
                },
                new Word { Greek = "ἀμίαντος", Transliteration = "amiantos", Gloss = "undefiled", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, Part_of_speech = "adj" }
            },
            Translation = "Let marriage be held in honor among all, and let the marriage bed be undefiled,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πόρνους", Transliteration = "pornous", Gloss = "the sexually immoral", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, Part_of_speech = "n" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "μοιχοὺς", Transliteration = "moichous", Gloss = "adulterers", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, Part_of_speech = "n" }
                    },
                    Translation = "for the sexually immoral and adulterers"
                },
                new Word { Greek = "κρινεῖ", Transliteration = "krinei", Gloss = "will judge", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "for God will judge the sexually immoral and adulterous."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀφιλάργυρος", Transliteration = "aphilargyros", Gloss = "free from love of money", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, Part_of_speech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "τρόπος", Transliteration = "tropos", Gloss = "manner [of life]", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "your manner of life"
                },
                new Word { Greek = "ἀρκούμενοι", Transliteration = "arkoumenoi", Gloss = "being content", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "with the [things]", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "παροῦσιν", Transliteration = "parousin", Gloss = "present", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "N", "P" }, Part_of_speech = "v" }
                    },
                    Translation = "with what you have"
                }
            },
            Translation = "Keep your life free from love of money, and be content with what you have,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "He", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, Part_of_speech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "εἴρηκεν", Transliteration = "eirēken", Gloss = "has said", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, Part_of_speech = "prep" },
                        new Word { Greek = "μή", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, Part_of_speech = "prep" },
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, Part_of_speech = "prep" },
                        new Word { Greek = "ἀνῶ", Transliteration = "anō", Gloss = "will I leave", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, Part_of_speech = "v" }
                    },
                    Translation = "I will never leave you"
                },
                new Word { Greek = "οὐδ᾽", Transliteration = "oud'", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, Part_of_speech = "prep" },
                        new Word { Greek = "μή", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, Part_of_speech = "prep" },
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, Part_of_speech = "prep" },
                        new Word { Greek = "ἐγκαταλίπω", Transliteration = "enkatalipō", Gloss = "will I forsake", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, Part_of_speech = "v" }
                    },
                    Translation = "will I forsake you"
                }
            },
            Translation = "for he has said, 'I will never leave you nor forsake you.'"
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "θαρροῦντας", Transliteration = "tharrountas", Gloss = "being confident", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, Part_of_speech = "v" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "we", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, Part_of_speech = "prep" },
                new Word { Greek = "λέγειν", Transliteration = "legein", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "the Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" },
                        new Word { Greek = "ἐμοὶ", Transliteration = "emoi", Gloss = "[is] to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, Part_of_speech = "prep" },
                        new Word { Greek = "βοηθός", Transliteration = "boēthos", Gloss = "a helper", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, Part_of_speech = "adj" }
                    },
                    Translation = "The Lord is my helper"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, Part_of_speech = "prep" },
                        new Word { Greek = "φοβηθήσομαι", Transliteration = "phobēthēsomai", Gloss = "I will fear", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "1P", "S" }, Part_of_speech = "v" }
                    },
                    Translation = "I will not fear"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, Part_of_speech = "interj" },
                        new Word { Greek = "ποιήσει", Transliteration = "poiēsei", Gloss = "will do", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, Part_of_speech = "v" },
                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, Part_of_speech = "prep" },
                        new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "what can man do to me?"
                }
            },
            Translation = "So we can confidently say, 'The Lord is my helper; I will not fear; what can man do to me?'"
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μνημονεύετε", Transliteration = "mnēmoneuete", Gloss = "remember", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "ἡγουμένων", Transliteration = "hēgoumenōn", Gloss = "leaders", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "GEN", "M", "P" }, Part_of_speech = "v" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, Part_of_speech = "prep" }
                    },
                    Translation = "your leaders"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἵτινες", Transliteration = "hoitines", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, Part_of_speech = "pron" },
                        new Word { Greek = "ἐλάλησαν", Transliteration = "elalēsan", Gloss = "spoke", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, Part_of_speech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, Part_of_speech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "λόγον", Transliteration = "logon", Gloss = "word", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, Part_of_speech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, Part_of_speech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, Part_of_speech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the word of God"
                        }
                    },
                    Translation = "who spoke to you the word of God"
                }
            },
            Translation = "Remember your leaders, those who spoke to you the word of God."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "whose", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, Part_of_speech = "pron" },
                        new Word { Greek = "ἀναθεωροῦντες", Transliteration = "anatheōrountes", Gloss = "considering", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "ἔκβασιν", Transliteration = "ekbasin", Gloss = "outcome", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, Part_of_speech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                        new Word { Greek = "ἀναστροφῆς", Transliteration = "anastrophēs", Gloss = "way of life", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                                    },
                                    Translation = "of [their] way of life"
                                }
                            },
                            Translation = "the outcome of their way of life"
                        }
                    },
                    Translation = "Considering the outcome of their way of life"
                },
                new Word { Greek = "μιμεῖσθε", Transliteration = "mimeisthe", Gloss = "imitate", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "πίστιν", Transliteration = "pistin", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "their faith"
                }
            },
            Translation = "Consider the outcome of their way of life, and imitate their faith."
        },

        // Verse 8
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
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" },
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "Jesus Christ"
                },
                new Word { Greek = "ἐχθὲς", Transliteration = "echthes", Gloss = "yesterday", GrammarCodes = new List<string> { "ADV" }, Part_of_speech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "σήμερον", Transliteration = "sēmeron", Gloss = "today", GrammarCodes = new List<string> { "ADV" }, Part_of_speech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "same", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, Part_of_speech = "prep" }
                    },
                    Translation = "the same"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "αἰῶνας", Transliteration = "aiōnas", Gloss = "ages", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, Part_of_speech = "n" }
                    },
                    Translation = "forever"
                }
            },
            Translation = "Jesus Christ is the same yesterday and today and forever."
        }
    };
}

/* Identified Constructions:
 * v2: PTCP (ξενίσαντες)
 * v3: PTCP (συνδεδεμένοι, κακουχουμένων, ὄντες)
 * v5: PTCP (ἀρκούμενοι, παροῦσιν)
 * v6: RESULT_CLAUSE (ὥστε), PTCP (θαρροῦντας)
 * v7: REL_CLAUSE (οἵτινες), GEN_DESC (τοῦ θεοῦ), PTCP (ἀναθεωροῦντες), GEN_DESC (τῆς ἀναστροφῆς)
 */
