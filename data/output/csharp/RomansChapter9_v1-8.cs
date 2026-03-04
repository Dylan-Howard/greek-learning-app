private static List<object> GetChapter9()
{
    // Romans 9:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀλήθεια", Transliteration = "Alētheian", Gloss = "truth", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in Christ"
                }
            },
            Translation = "I am speaking the truth in Christ"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "prep" },
                new Word { Greek = "ψεύδομαι", Transliteration = "pseudomai", Gloss = "I lie", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "I am not lying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP", "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "συμμαρτυρούσης", Transliteration = "symmartyrousēs", Gloss = "bearing witness with", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "me", GrammarCodes = new List<string> { "PRON", "DAT", "M", "1S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "συνειδήσεώς", Transliteration = "syneidēseōs", Gloss = "conscience", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "M", "1S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "my conscience"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἁγίῳ", Transliteration = "hagiō", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the Holy Spirit"
                        }
                    },
                    Translation = "in the Holy Spirit"
                }
            },
            Translation = "my conscience bearing witness with me in the Holy Spirit"
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "adj" },
                new Word { Greek = "λύπη", Transliteration = "lypē", Gloss = "sorrow", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "μοί", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μεγάλη", Transliteration = "megalē", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀδιάλειπτος", Transliteration = "adialeiptos", Gloss = "unceasing", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ὀδύνη", Transliteration = "odynē", Gloss = "anguish", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρδίᾳ", Transliteration = "kardia", Gloss = "heart", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "my heart"
                        }
                    },
                    Translation = "in my heart"
                }
            },
            Translation = "that I have great sorrow and unceasing anguish in my heart"
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ηὐχόμην", Transliteration = "ēuchomēn", Gloss = "I was wishing", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀνάθεμα", Transliteration = "anathema", Gloss = "accursed", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Christ"
                        }
                    },
                    Translation = "from Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for the sake of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφῶν", Transliteration = "adelphōn", Gloss = "brothers", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "my brothers"
                        }
                    },
                    Translation = "for the sake of my brothers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "συγγενῶν", Transliteration = "syngenōn", Gloss = "kinsmen", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "flesh", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "according to the flesh"
                        }
                    },
                    Translation = "my kinsmen according to the flesh"
                }
            },
            Translation = "For I could wish that I myself were accursed and cut off from Christ for the sake of my brothers, my kinsmen according to the flesh."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἵτινές", Transliteration = "hoitines", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "Ἰσραηλῖται", Transliteration = "Israilītai", Gloss = "Israelites", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
            },
            Translation = "who are Israelites"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "to whom belong", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" },
                new Phrase { SyntaxCodes = new List<string> { "NOUN_PHRASE" }, Content = new List<object> { new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" }, new Word { Greek = "υἱοθεσία", Transliteration = "hyiothesia", Gloss = "adoption", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" } }, Translation = "the adoption" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase { SyntaxCodes = new List<string> { "NOUN_PHRASE" }, Content = new List<object> { new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" }, new Word { Greek = "δόξα", Transliteration = "doxa", Gloss = "glory", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" } }, Translation = "the glory" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase { SyntaxCodes = new List<string> { "NOUN_PHRASE" }, Content = new List<object> { new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "art" }, new Word { Greek = "διαθῆκαι", Transliteration = "diathēkai", Gloss = "covenants", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" } }, Translation = "the covenants" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase { SyntaxCodes = new List<string> { "NOUN_PHRASE" }, Content = new List<object> { new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" }, new Word { Greek = "νομοθεσία", Transliteration = "nomothesia", Gloss = "giving of the law", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" } }, Translation = "the law" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase { SyntaxCodes = new List<string> { "NOUN_PHRASE" }, Content = new List<object> { new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" }, new Word { Greek = "λατρεία", Transliteration = "latreia", Gloss = "worship", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" } }, Translation = "the worship" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase { SyntaxCodes = new List<string> { "NOUN_PHRASE" }, Content = new List<object> { new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "art" }, new Word { Greek = "ἐπαγγελίαι", Transliteration = "epangeliai", Gloss = "promises", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" } }, Translation = "the promises" }
            },
            Translation = "to whom belong the adoption, the glory, the covenants, the giving of the law, the worship, and the promises"
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "to whom belong", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατέρες", Transliteration = "pateres", Gloss = "patriarchs", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the patriarchs"
                }
            },
            Translation = "to whom belong the patriarchs"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "from whom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "flesh", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "according to the flesh"
                        }
                    },
                    Translation = "according to the flesh"
                },
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "ὢν", Transliteration = "ōn", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "over", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "over all"
                },
                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "εὐλογητὸς", Transliteration = "eulogētos", Gloss = "blessed", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "αἰῶνας", Transliteration = "aiōnas", Gloss = "ages", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the ages"
                        }
                    },
                    Translation = "forever"
                },
                new Word { Greek = "ἀμήν", Transliteration = "amēn", Gloss = "Amen", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "h" }
            },
            Translation = "and from whom, according to the flesh, is the Christ, who is God over all, blessed forever. Amen."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐχ", Transliteration = "Ouch", Gloss = "not", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "prep" },
                new Word { Greek = "οἷον", Transliteration = "hoion", Gloss = "as though", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "k" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐκπέπτωκεν", Transliteration = "ekpeptōken", Gloss = "has failed", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "word", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the word of God"
                        }
                    },
                    Translation = "that the word of God has failed"
                }
            },
            Translation = "But it is not as though the word of God has failed."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἰσραὴλ", Transliteration = "Israēl", Gloss = "Israel", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from Israel"
                        }
                    },
                    Translation = "those from Israel"
                },
                new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "these", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "Ἰσραήλ", Transliteration = "Israēl", Gloss = "Israel", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "For not all who are descended from Israel belong to Israel."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδ᾽", Transliteration = "oud'", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "they are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σπέρμα", Transliteration = "sperma", Gloss = "seed", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ἀβραὰμ", Transliteration = "Abraam", Gloss = "of Abraham", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Abraham's offspring"
                },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
            },
            Translation = "and not all are children of Abraham because they are his offspring"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Ἰσαὰκ", Transliteration = "Isaak", Gloss = "Isaac", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "through Isaac"
                },
                new Word { Greek = "κληθήσεταί", Transliteration = "klēthēsetai", Gloss = "shall be called", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2S" }, PartOfSpeech = "prep" },
                new Word { Greek = "σπέρμα", Transliteration = "sperma", Gloss = "offspring", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
            },
            Translation = "but \"Through Isaac shall your offspring be named.\""
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦτ᾽", Transliteration = "tout'", Gloss = "This", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "of the flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the flesh"
                        }
                    },
                    Translation = "the children of the flesh"
                },
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of God"
                }
            },
            Translation = "This means that it is not the children of the flesh who are the children of God"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐπαγγελίας", Transliteration = "epangelias", Gloss = "of the promise", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the promise"
                        }
                    },
                    Translation = "the children of the promise"
                },
                new Word { Greek = "λογίζεται", Transliteration = "logizetai", Gloss = "are counted", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "as", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σπέρμα", Transliteration = "sperma", Gloss = "offspring", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "as offspring"
                }
            },
            Translation = "but the children of the promise are counted as offspring"
        }
    };
}

/*
Constructions Identified:
- GEN_ABS (Genitive Absolute): Verse 1 (συμμαρτυρούσης... συνειδήσεώς μου)
- APPOS (Appositive): Verse 3 (τῶν συγγενῶν μου), Verse 5 (τὸ κατὰ σάρκα)
- GEN_DESC (Descriptive Genitive): Verse 6 (τοῦ θεοῦ), Verse 8 (τῆς σαρκὸς, τοῦ θεοῦ, τῆς ἐπαγγελίας)
- PRED (Predicate Nominative): Verse 7 (σπέρμα Ἀβραὰμ)
*/
