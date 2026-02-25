private static List<object> GetChapter5()
{
    // Matthew 5:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μακάριοι", Transliteration = "makarioi", Gloss = "blessed",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εἰρηνοποιοί", Transliteration = "eirēnopoioi", Gloss = "peacemakers",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the peacemakers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "they",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱοὶ", Transliteration = "huioi", Gloss = "sons",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "sons of God"
                        },
                        new Word { Greek = "κληθήσονται", Transliteration = "klēthēsontai", Gloss = "shall be called",
                            GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "for they shall be called sons of God"
                }
            },
            Translation = "Blessed are the peacemakers, for they shall be called sons of God."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μακάριοι", Transliteration = "makarioi", Gloss = "blessed",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the ones",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δεδιωγμένοι", Transliteration = "dediōgmenoi", Gloss = "having been persecuted",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "those who have been persecuted"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕνεκεν", Transliteration = "heneken", Gloss = "for the sake of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs", Gloss = "righteousness",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "for righteousness' sake"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "theirs",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "βασιλεία", Transliteration = "basileia", Gloss = "kingdom",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανῶν", Transliteration = "ouranōn", Gloss = "heavens",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the heavens"
                                }
                            },
                            Translation = "the kingdom of the heavens"
                        }
                    },
                    Translation = "for theirs is the kingdom of the heavens"
                }
            },
            Translation = "Blessed are those who are persecuted for righteousness' sake, for theirs is the kingdom of heaven."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μακάριοί", Transliteration = "makarioi", Gloss = "blessed",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are you",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὀνειδίσωσιν", Transliteration = "oneidisōsin", Gloss = "they revile",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "διώξωσιν", Transliteration = "diōksōsin", Gloss = "persecute",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "εἴπωσιν", Transliteration = "eipōsin", Gloss = "say",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "every",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "πονηρὸν", Transliteration = "ponēron", Gloss = "evil",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "every evil"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "against",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "against you"
                        },
                        new Word { Greek = "ψευδόμενοι", Transliteration = "pseudomenoi", Gloss = "falsely",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἕνεκεν", Transliteration = "heneken", Gloss = "for the sake of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "for my sake"
                        }
                    },
                    Translation = "when they revile you and persecute you and say all evil against you falsely for my sake"
                }
            },
            Translation = "Blessed are you when they revile you and persecute you and utter all kinds of evil against you falsely on my account."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "χαίρετε", Transliteration = "chairete", Gloss = "rejoice",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀγαλλιᾶσθε", Transliteration = "agalliasthe", Gloss = "be glad",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μισθὸς", Transliteration = "misthos", Gloss = "reward",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "your reward"
                        },
                        new Word { Greek = "πολὺς", Transliteration = "polys", Gloss = "is great",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
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
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανοῖς", Transliteration = "ouranois", Gloss = "heavens",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the heavens"
                                }
                            },
                            Translation = "in the heavens"
                        }
                    },
                    Translation = "for your reward is great in the heavens"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐδίωξαν", Transliteration = "ediōksan", Gloss = "they persecuted",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "προφήτας", Transliteration = "prophētas", Gloss = "prophets",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "REL_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "who [were]",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πρὸ", Transliteration = "pro", Gloss = "before",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "who were before you"
                                }
                            },
                            Translation = "the prophets who were before you"
                        }
                    },
                    Translation = "for thus they persecuted the prophets who were before you"
                }
            },
            Translation = "Rejoice and be glad, for your reward is great in heaven, for so they persecuted the prophets who were before you."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἅλας", Transliteration = "halas", Gloss = "salt",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the earth"
                        }
                    },
                    Translation = "the salt of the earth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἅλας", Transliteration = "halas", Gloss = "salt",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = " the salt"
                        },
                        new Word { Greek = "μωρανθῇ", Transliteration = "mōranthē", Gloss = "becomes tasteless",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "but if the salt becomes tasteless"
                },
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
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τίνι", Transliteration = "tini", Gloss = "what",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "with what"
                        },
                        new Word { Greek = "ἁλισθήσεται", Transliteration = "halisthēsetai", Gloss = "shall it be salted?",
                            GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "with what shall it be salted?"
                },
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
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "οὐδὲν", Transliteration = "ouden", Gloss = "nothing",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "for nothing"
                        },
                        new Word { Greek = "ἰσχύει", Transliteration = "ischyei", Gloss = "it is strong",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἔτι", Transliteration = "eti", Gloss = "any longer",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "it is no longer good for anything"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "part" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "βληθὲν", Transliteration = "blēthen", Gloss = "having been thrown",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "ἔξω", Transliteration = "eksō", Gloss = "outside",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "except having been thrown out"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καταπατεῖσθαι", Transliteration = "katapateisthai", Gloss = "to be trampled",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "people",
                                                    GrammarCodes = new List<string> {
