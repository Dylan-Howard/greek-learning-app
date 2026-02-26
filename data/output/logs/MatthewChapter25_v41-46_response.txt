private static List<object> GetChapter25()
{
    // Matthew 25:41-46
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τότε", Transliteration = "Tote", Gloss = "then", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἐρεῖ", Transliteration = "erei", Gloss = "he will say", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to those", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "on", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "εὐωνύμων", Transliteration = "euōnymōn", Gloss = "left", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "on the left"
                        }
                    },
                    Translation = "to those on the left"
                }
            },
            Translation = "Then he will say also to those on the left,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πορεύεσθε", Transliteration = "poreuesthe", Gloss = "depart", 
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ’", Transliteration = "ap'", Gloss = "from", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, 
                            PartOfSpeech = "prep" }
                    },
                    Translation = "from me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "VOC", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "κατηραμένοι", Transliteration = "katēramenoi", Gloss = "cursed ones", 
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "VOC", "M", "P" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "you cursed ones"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πῦρ", Transliteration = "pyr", Gloss = "fire", 
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αἰώνιον", Transliteration = "aiōnion", Gloss = "eternal", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the eternal fire"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἡτοιμασμένον", Transliteration = "hētoimasmenon", Gloss = "prepared", 
                                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "N", "S" }, 
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, 
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "διαβόλῳ", Transliteration = "diabolō", Gloss = "devil", 
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, 
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "for the devil"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                                    GrammarCodes = new List<string> { "CONJ" }, 
                                    PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, 
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀγγέλοις", Transliteration = "angelois", Gloss = "angels", 
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, 
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", 
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, 
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "his angels"
                                }
                            },
                            Translation = "prepared for the devil and his angels"
                        }
                    },
                    Translation = "into the eternal fire prepared for the devil and his angels"
                }
            },
            Translation = "Depart from me, you cursed ones, into the eternal fire prepared for the devil and his angels."
        },
        // Verse 42
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπείνασα", Transliteration = "epeinasa", Gloss = "I was hungry", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" }
            },
            Translation = "For I was hungry"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐδώκατέ", Transliteration = "edōkate", Gloss = "you gave", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "me", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, 
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "to eat", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "to eat"
                }
            },
            Translation = "and you gave me nothing to eat"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐδίψησα", Transliteration = "edipsēsa", Gloss = "I was thirsty", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "I was thirsty"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐποτίσατέ", Transliteration = "epotisate", Gloss = "you gave a drink", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "and you gave me no drink"
        },
        // Verse 43
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ξένος", Transliteration = "xenos", Gloss = "a stranger", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἤμην", Transliteration = "ēmēn", Gloss = "I was", 
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "I was a stranger"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "συνηγάγετέ", Transliteration = "synēgagete", Gloss = "you welcomed", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "and you did not welcome me"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γυμνὸς", Transliteration = "gymnos", Gloss = "naked", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, 
                    PartOfSpeech = "adj" }
            },
            Translation = "naked"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "περιεβάλετέ", Transliteration = "periebalete", Gloss = "you clothed", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "and you did not clothe me"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσθενὴς", Transliteration = "asthenēs", Gloss = "sick", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "φυλακῇ", Transliteration = "phylakē", Gloss = "prison", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "in prison"
                }
            },
            Translation = "sick and in prison"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐπεσκέψασθέ", Transliteration = "epeskepsasthe", Gloss = "you visited", 
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "and you did not visit me"
        },
        // Verse 44
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἀποκριθήσονται", Transliteration = "apokrithēsontai", Gloss = "they will answer", 
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "they", 
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, 
                            PartOfSpeech = "prep" }
                    },
                    Translation = "they"
                }
            },
            Translation = "Then they also will answer"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "saying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", 
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, 
                    PartOfSpeech = "n" },
                new Word { Greek = "πότε", Transliteration = "pote", Gloss = "when", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "σε", Transliteration = "se", Gloss = "you", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "εἴδομεν", Transliteration = "eidomen", Gloss = "did we see", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "πεινῶντα", Transliteration = "peinōnta", Gloss = "hungry", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "διψῶντα", Transliteration = "dipsōnta", Gloss = "thirsty", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ξένον", Transliteration = "xenon", Gloss = "a stranger", 
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "γυμνὸν", Transliteration = "gymnon", Gloss = "naked", 
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀσθενῆ", Transliteration = "asthenē", Gloss = "sick", 
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "φυλακῇ", Transliteration = "phylakē", Gloss = "prison", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "in prison"
                }
            },
            Translation = "Lord, when did we see you hungry or thirsty or a stranger or naked or sick or in prison"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "διηκονήσαμέν", Transliteration = "diēkonēsamen", Gloss = "minister to", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "you", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "and did not minister to you?"
        },
        // Verse 45
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἀποκριθήσεται", Transliteration = "apokrithēsetai", Gloss = "he will answer", 
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "Then he will answer them"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "saying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀμὴν", Transliteration = "amēn", Gloss = "truly", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "h" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "Truly I say to you"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐφ’", Transliteration = "eph’", Gloss = "to", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὅσον", Transliteration = "hoson", Gloss = "the extent that", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, 
                            PartOfSpeech = "k" }
                    },
                    Translation = "inasmuch as"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐποιήσατε", Transliteration = "epoiēsate", Gloss = "you did", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑνὶ", Transliteration = "heni", Gloss = "to one", 
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, 
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τούτων", Transliteration = "toutōn", Gloss = "of these", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, 
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "of these"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐλαχίστων", Transliteration = "elachistōn", Gloss = "least", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the least"
                        }
                    },
                    Translation = "to one of the least of these"
                }
            },
            Translation = "inasmuch as you did not do it to one of the least of these"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "neither", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐμοὶ", Transliteration = "emoi", Gloss = "to me", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐποιήσατε", Transliteration = "epoiēsate", Gloss = "did you do it", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "you did not do it to me either"
        },
        // Verse 46
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀπελεύσονται", Transliteration = "apeleusontai", Gloss = "they will go away", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "these", 
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, 
                            PartOfSpeech = "adv" }
                    },
                    Translation = "these"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κόλασιν", Transliteration = "kolasin", Gloss = "punishment", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αἰώνιον", Transliteration = "aiōnion", Gloss = "eternal", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "eternal punishment"
                        }
                    },
                    Translation = "into eternal punishment"
                }
            },
            Translation = "And these will go away into eternal punishment,"
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δίκαιοι", Transliteration = "dikaioi", Gloss = "righteous", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, 
                            PartOfSpeech = "adj" }
                    },
                    Translation = "but the righteous"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ζωὴν", Transliteration = "zōēn", Gloss = "life", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αἰώνιον", Transliteration = "aiōnion", Gloss = "eternal", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "eternal life"
                        }
                    },
                    Translation = "into eternal life"
                }
            },
            Translation = "but the righteous into eternal life."
        }
    };
}
// Constructions Identified:
// VOC: Verse 41 (οἱ κατηραμένοι), Verse 44 (κύριε)
// IND_OBJ: Verse 41 (τοῖς ἐξ εὐωνύμων, τῷ διαβόλῳ, τοῖς ἀγγέλοις), Verse 42 (μοι), Verse 44 (σοι), Verse 45 (αὐτοῖς, ὑμῖν, ἑνὶ τούτων..., ἐμοὶ)
// OBJ: Verse 41 (τὸ πῦρ τὸ αἰώνιον), Verse 42 (φαγεῖν), Verse 43 (με), Verse 46 (κόλασιν αἰώνιον, ζωὴν αἰώνιον)
// GEN_DESC: Verse 45 (τούτων, τῶν ἐλαχίστων)
