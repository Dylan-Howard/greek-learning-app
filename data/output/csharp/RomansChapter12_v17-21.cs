private static List<object> GetChapter12()
{
    // Romans 12:17-21
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μηδενὶ", Transliteration = "mēdeni", Gloss = "to no one",
                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "κακὸν", Transliteration = "kakon", Gloss = "evil",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀντὶ", Transliteration = "anti", Gloss = "in exchange for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κακοῦ", Transliteration = "kakou", Gloss = "evil",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "for evil"
                },
                new Word { Greek = "ἀποδιδόντες", Transliteration = "apodidontes", Gloss = "repaying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Repay no one evil for evil."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "προνοούμενοι", Transliteration = "pronooumenoi", Gloss = "taking thought for",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καλὰ", Transliteration = "kala", Gloss = "good things",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "all men"
                        }
                    },
                    Translation = "before all men"
                }
            },
            Translation = "Take thought for what is noble in the sight of all men."
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δυνατὸν", Transliteration = "dynaton", Gloss = "possible",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [thing]",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "as far as it depends on you"
                        }
                    },
                    Translation = "the part from you"
                }
            },
            Translation = "If it be possible, as much as lieth in you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 18)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "all men"
                        }
                    },
                    Translation = "with all men"
                },
                new Word { Greek = "εἰρηνεύοντες", Transliteration = "eirēneuontes", Gloss = "living in peace",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "live peaceably with all men."
        },
        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἑαυτοὺς", Transliteration = "heautous", Gloss = "yourselves",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "f" },
                new Word { Greek = "ἐκδικοῦντες", Transliteration = "ekdikountes", Gloss = "avenging",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀγαπητοί", Transliteration = "agapētoi", Gloss = "beloved",
                    GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" },
                    PartOfSpeech = "adj" }
            },
            Translation = "Beloved, never avenge yourselves,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 19)
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δότε", Transliteration = "dote", Gloss = "give",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τόπον", Transliteration = "topon", Gloss = "place",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὀργῇ", Transliteration = "orgē", Gloss = "wrath",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the wrath [of God]"
                }
            },
            Translation = "but leave it to the wrath of God,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 19)
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it has been written",
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐμοὶ", Transliteration = "emoi", Gloss = "to me",
                            GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐκδίκησις", Transliteration = "ekdikēsis", Gloss = "vengeance",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Vengeance is mine,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                            GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνταποδώσω", Transliteration = "antapodōsō", Gloss = "will repay",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "I will repay,"
                },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "the Lord",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "for it is written, 'Vengeance is mine, I will repay, says the Lord.'"
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πεινᾷ", Transliteration = "peina", Gloss = "is hungry",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐχθρός", Transliteration = "echthros", Gloss = "enemy",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "your enemy"
                        }
                    },
                    Translation = "if your enemy is hungry"
                },
                new Word { Greek = "ψώμιζε", Transliteration = "psōmize", Gloss = "feed",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "To the contrary, 'if your enemy is hungry, feed him;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 20)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "διψᾷ", Transliteration = "dipsa", Gloss = "is thirsty",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "if he is thirsty"
                },
                new Word { Greek = "πότιζε", Transliteration = "potize", Gloss = "give drink",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "if he is thirsty, give him drink;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 20)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "doing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "for by so doing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνθρακας", Transliteration = "anthrakas", Gloss = "coals",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πυρὸς", Transliteration = "pyros", Gloss = "of fire",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "burning coals"
                },
                new Word { Greek = "σωρεύσεις", Transliteration = "sōreuseis", Gloss = "you will heap",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on",
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
                                new Word { Greek = "κεφαλὴν", Transliteration = "kephalēn", Gloss = "head",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "his head"
                        }
                    },
                    Translation = "on his head."
                }
            },
            Translation = "for by so doing you will heap burning coals on his head.'"
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "νικῶ", Transliteration = "nikō", Gloss = "be overcome",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "2P", "S" },
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
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κακοῦ", Transliteration = "kakou", Gloss = "evil",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "evil"
                        }
                    },
                    Translation = "by evil"
                }
            },
            Translation = "Do not be overcome by evil,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 21)
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "νίκα", Transliteration = "nika", Gloss = "overcome",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαθῷ", Transliteration = "agathō", Gloss = "good",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "good"
                        }
                    },
                    Translation = "with good"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κακόν", Transliteration = "kakon", Gloss = "evil",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "evil"
                }
            },
            Translation = "but overcome evil with good."
        }
    };
}

/* 
Constructions Identified:
- Verse 18: NOUN_PHRASE as SUBJ with substantival usage of prepositional phrase (τὸ ἐξ ὑμῶν).
- Verse 19: VOC (ἀγαπητοί) direct address.
- Verse 20: COND_CLAUSE (ἐὰν + subjunctive) in a parathetic sequence.
- Verse 20: GEN_DESC (ἄνθρακας πυρὸς) descriptive genitive.
*/
