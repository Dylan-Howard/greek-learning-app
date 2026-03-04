private static List<object> GetChapter10()
{
    // Romans 10:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀδελφοί", Transliteration = "Adelphoi", Gloss = "Brothers", 
                    GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", 
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "εὐδοκία", Transliteration = "eudokia", Gloss = "goodwill", 
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐμῆς", Transliteration = "emēs", Gloss = "my", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "s" },
                                new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "heart", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of my heart"
                        }
                    },
                    Translation = "my heart's desire"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δέησις", Transliteration = "deēsis", Gloss = "prayer", 
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to God"
                        }
                    },
                    Translation = "and prayer to God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "on behalf of", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "for them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "unto", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σωτηρίαν", Transliteration = "sōtērian", Gloss = "salvation", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "is for their salvation"
                }
            },
            Translation = "Brothers, my heart's desire and prayer to God for them is for their salvation."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μαρτυρῶ", Transliteration = "martyrō", Gloss = "I testify", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ζῆλον", Transliteration = "zēlon", Gloss = "a zeal", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a zeal for God"
                        },
                        new Word { Greek = "ἔχουσιν", Transliteration = "echousin", Gloss = "they have", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                            GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "according to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐπίγνωσιν", Transliteration = "epignōsin", Gloss = "knowledge", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "according to knowledge"
                        }
                    },
                    Translation = "that they have a zeal for God, but not according to knowledge."
                }
            },
            Translation = "For I testify to them that they have a zeal for God, but not according to knowledge."
        },

        // Verse 3
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
                        new Word { Greek = "ἀγνοοῦντες", Transliteration = "agnoountes", Gloss = "being ignorant", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", 
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                },
                                new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn", Gloss = "righteousness", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the righteousness of God"
                        }
                    },
                    Translation = "For, being ignorant of the righteousness of God"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἰδίαν", Transliteration = "idian", Gloss = "one's own", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn", Gloss = "righteousness", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "their own righteousness"
                        },
                        new Word { Greek = "ζητοῦντες", Transliteration = "zētountes", Gloss = "seeking", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "στῆσαι", Transliteration = "stēsai", Gloss = "to establish", 
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to establish"
                        }
                    },
                    Translation = "and seeking to establish their own"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δικαιοσύνῃ", Transliteration = "dikaiosynē", Gloss = "righteousness", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "to the righteousness of God"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ὑπετάγησαν", Transliteration = "hypetagēsan", Gloss = "they did submit", 
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "For, being ignorant of the righteousness of God, and seeking to establish their own, they did not submit to God's righteousness."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τέλος", Transliteration = "telos", Gloss = "the end", 
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "of the law", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of the law"
                },
                new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ [is]", 
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn", Gloss = "righteousness", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for righteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παντὶ", Transliteration = "panti", Gloss = "to everyone", 
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the [one]", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πιστεύοντι", Transliteration = "pisteuonti", Gloss = "believing", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "to everyone who believes"
                }
            },
            Translation = "For Christ is the end of the law for righteousness to everyone who believes."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μωϋσῆς", Transliteration = "Mōysēs", Gloss = "Moses", 
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γράφει", Transliteration = "graphei", Gloss = "writes", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn", Gloss = "righteousness", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the [one]", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", 
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", 
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "from the law"
                                }
                            },
                            Translation = "which is based on the law"
                        }
                    },
                    Translation = "about the righteousness that is from the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ποιήσας", Transliteration = "poiēsas", Gloss = "having done", 
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτὰ", Transliteration = "auta", Gloss = "them", 
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "person", 
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the person who does them"
                        },
                        new Word { Greek = "ζήσεται", Transliteration = "zēsetai", Gloss = "shall live", 
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", 
                                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "by them"
                        }
                    },
                    Translation = "that 'the person who does them shall live by them.'"
                }
            },
            Translation = "For Moses writes about the righteousness that is from the law, that 'the person who does them shall live by them.'"
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from faith"
                        },
                        new Word { Greek = "δικαιοσύνη", Transliteration = "dikaiosynē", Gloss = "righteousness", 
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "But the righteousness based on faith"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "speaks", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "Do not", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "εἴπῃς", Transliteration = "eipēs", Gloss = "say", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρδίᾳ", Transliteration = "kardia", Gloss = "heart", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "in your heart"
                },
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "Who", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "ἀναβήσεται", Transliteration = "anabēsetai", Gloss = "will go up", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "οὐρανόν", Transliteration = "ouranon", Gloss = "heaven", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into heaven?"
                },
                new Word { Greek = "τοῦτ᾽", Transliteration = "tout'", Gloss = "that", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "Χριστὸν", Transliteration = "Christon", Gloss = "Christ", 
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καταγαγεῖν", Transliteration = "katagagein", Gloss = "to bring down", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "But the righteousness based on faith speaks thus: 'Do not say in your heart, \"Who will go up into heaven?\"' (that is, to bring Christ down)."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἤ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "Who", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "καταβήσεται", Transliteration = "katabēsetai", Gloss = "will go down", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄβυσσον", Transliteration = "abysson", Gloss = "abyss", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into the abyss?"
                },
                new Word { Greek = "τοῦτ᾽", Transliteration = "tout'", Gloss = "that", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "Χριστὸν", Transliteration = "Christon", Gloss = "Christ", 
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "νεκρῶν", Transliteration = "nekrōn", Gloss = "[the] dead", 
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "from the dead"
                },
                new Word { Greek = "ἀναγαγεῖν", Transliteration = "anagagein", Gloss = "to bring up", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "or '\"Who will go down into the abyss?\"' (that is, to bring Christ up from the dead)."
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλά", Transliteration = "alla", Gloss = "But", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "does it say", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγγύς", Transliteration = "engys", Gloss = "Near", 
                            GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "you", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "Near you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ῥῆμά", Transliteration = "rhēma", Gloss = "word", 
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the word"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "στόματί", Transliteration = "stómati", Gloss = "mouth", 
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "in your mouth"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρδίᾳ", Transliteration = "kardia", Gloss = "heart", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "in your heart"
                },
                new Word { Greek = "τοῦτ᾽", Transliteration = "tout'", Gloss = "that", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ῥῆμα", Transliteration = "rhēma", Gloss = "word", 
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of faith"
                        }
                    },
                    Translation = "the word of faith"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "κηρύσσομεν", Transliteration = "kēryssomen", Gloss = "we preach", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "which we preach"
                }
            },
            Translation = "But what does it say? 'The word is near you, in your mouth and in your heart' (that is, the word of faith which we preach)."
        }
    };
}

/*
Constructions identified:
- GEN_DESC: Romans 10:1 "τῆς ἐμῆς καρδίας" (Genitive of possession/description)
- NOUN_PHRASE/PRED: Romans 10:4 "τέλος νόμου Χριστὸς" (Christ is the end [predicate nominative])
- CAUSAL_CLAUSE: Romans 10:5 "ὅτι ὁ ποιήσας..." (Causal 'that' introducing the quotation)
*/
