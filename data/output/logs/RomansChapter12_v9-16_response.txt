private static List<object> GetChapter12()
{
    // Romans 12:9-16
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγάπη", Transliteration = "agapē", Gloss = "love", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "The love"
                },
                new Word { Greek = "ἀνυπόκριτος", Transliteration = "anypokritos", Gloss = "sincere", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποστυγοῦντες", Transliteration = "apostygountes", Gloss = "abhorring", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πονηρόν", Transliteration = "ponēron", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the evil"
                        }
                    },
                    Translation = "abhorring the evil"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κολλώμενοι", Transliteration = "kollōmenoi", Gloss = "clinging", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαθῷ", Transliteration = "agathō", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "to the good"
                        }
                    },
                    Translation = "clinging to the good"
                }
            },
            Translation = "Let love be sincere, abhorring evil, clinging to what is good."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φιλαδελφίᾳ", Transliteration = "philadelphia", Gloss = "brotherly love", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in brotherly love"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "toward", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "conj" }
                    },
                    Translation = "toward one another"
                },
                new Word { Greek = "φιλόστοργοι", Transliteration = "philostorgoi", Gloss = "devoted", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "τιμῇ", Transliteration = "timē", Gloss = "honor", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in honor"
                        },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "conj" },
                        new Word { Greek = "προηγούμενοι", Transliteration = "proēgoumenoi", Gloss = "outdoing", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "outdoing one another in honor"
                }
            },
            Translation = "Be devoted to one another in brotherly love, outdoing one another in honor."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σπουδῇ", Transliteration = "spoudē", Gloss = "zeal", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in zeal"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ὀκνηροί", Transliteration = "oknēroi", Gloss = "lazy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "spirit", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in spirit"
                },
                new Word { Greek = "ζέοντες", Transliteration = "zeontes", Gloss = "burning", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                },
                new Word { Greek = "δουλεύοντες", Transliteration = "douleuontes", Gloss = "serving", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Do not be lazy in zeal, be fervent in spirit, serving the Lord."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐλπίδι", Transliteration = "elpidi", Gloss = "hope", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in hope"
                },
                new Word { Greek = "χαίροντες", Transliteration = "chairontes", Gloss = "rejoicing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θλίψει", Transliteration = "thlipsei", Gloss = "tribulation", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in tribulation"
                },
                new Word { Greek = "ὑπομένοντες", Transliteration = "hypomenontes", Gloss = "enduring", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "προσευχῇ", Transliteration = "proseuchē", Gloss = "prayer", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in prayer"
                },
                new Word { Greek = "προσκαρτεροῦντες", Transliteration = "proskarterountes", Gloss = "constantly joining", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Rejoice in hope, be patient in tribulation, be constant in prayer."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "χρείαις", Transliteration = "chreiais", Gloss = "needs", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἁγίων", Transliteration = "hagiōn", Gloss = "saints", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of the saints"
                        }
                    },
                    Translation = "to the needs of the saints"
                },
                new Word { Greek = "κοινωνοῦντες", Transliteration = "koinōnountes", Gloss = "contributing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φιλοξενίαν", Transliteration = "philoxenian", Gloss = "hospitality", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "hospitality"
                },
                new Word { Greek = "διώκοντες", Transliteration = "diōkontes", Gloss = "pursuing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Contributing to the needs of the saints, pursuing hospitality."
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εὐλογεῖτε", Transliteration = "eulogeite", Gloss = "bless", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "διώκοντας", Transliteration = "diōkontas", Gloss = "persecuting", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμας", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "those who persecute you"
                },
                new Word { Greek = "εὐλογεῖτε", Transliteration = "eulogeite", Gloss = "bless", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "καταρᾶσθε", Transliteration = "katarasthe", Gloss = "curse", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Bless those who persecute you; bless and do not curse them."
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "χαίρειν", Transliteration = "chairein", Gloss = "to rejoice", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "χαιρόντων", Transliteration = "chairontōn", Gloss = "those who rejoice", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "with those who rejoice"
                },
                new Word { Greek = "κλαίειν", Transliteration = "klaiein", Gloss = "to weep", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "κλαιόντων", Transliteration = "klaiontōn", Gloss = "those who weep", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "with those who weep"
                }
            },
            Translation = "Rejoice with those who rejoice, weep with those who weep."
        },
        // Verse 16
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
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "αὐτὸ", Transliteration = "auto", Gloss = "same thing", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "the same thing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "toward", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "conj" }
                    },
                    Translation = "toward one another"
                },
                new Word { Greek = "φρονοῦντες", Transliteration = "phronountes", Gloss = "thinking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὑψηλὰ", Transliteration = "hypsēla", Gloss = "haughty things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "haughty things"
                },
                new Word { Greek = "φρονοῦντες", Transliteration = "phronountes", Gloss = "thinking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "with the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ταπεινοῖς", Transliteration = "tapeinois", Gloss = "lowly", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "with the lowly"
                },
                new Word { Greek = "συναπαγόμενοι", Transliteration = "synapagomenoi", Gloss = "associating", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "be", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "φρόνιμοι", Transliteration = "phronimoi", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "in your own", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois", Gloss = "estimation", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "f" }
                    },
                    Translation = "in your own estimation"
                }
            },
            Translation = "Live in harmony with one another. Do not be haughty, but associate with the lowly. Never be wise in your own sight."
        }
    };
}

/*
Identified Constructions:
- GEN_SUBJ: v13 (τῶν ἁγίων)
- DAT_REF: v10 (τῇ φιλαδελφίᾳ, τῇ τιμῇ), v11 (τῇ σπουδῇ, τῷ πνεύματι), v12 (τῇ ἐλπίδι, τῇ θλίψει, τῇ προσευχῇ), v13 (ταῖς χρείαις)
- DAT_INSTR: v16 (τοῖς ταπεινοῖς)
*/
