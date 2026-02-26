private static List<object> GetChapter5()
{
    // Mark 5:41-43
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κρατήσας", Transliteration = "kratēsas", Gloss = "taking hold of", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χειρὸς", Transliteration = "cheiros", Gloss = "hand", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "παιδίου", Transliteration = "paidiou", Gloss = "child", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the child"
                                }
                            },
                            Translation = "the hand of the child"
                        }
                    },
                    Translation = "taking hold of the hand of the child"
                },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "he says", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "to her", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταλιθα", Transliteration = "talitha", Gloss = "Talitha", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "κουμ", Transliteration = "koum", Gloss = "koum", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Talitha koum"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "μεθερμηνευόμενον", Transliteration = "methermēneuomenon", Gloss = "being translated", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "VOC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κοράσιον", Transliteration = "korasion", Gloss = "little girl", GrammarCodes = new List<string> { "N", "VOC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Little girl"
                        },
                        new Word { Greek = "σοὶ", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἔγειρε", Transliteration = "egeire", Gloss = "arise", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "which is translated, 'Little girl, I say to you, arise.'"
                }
            },
            Translation = "Taking the child by the hand, he said to her, 'Talitha koum,' which means, 'Little girl, I say to you, arise.'"
        },

        // Verse 42
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εὐθὺς", Transliteration = "euthys", Gloss = "immediately", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀνέστη", Transliteration = "anestē", Gloss = "stood up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κοράσιον", Transliteration = "korasion", Gloss = "little girl", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the little girl"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "περιεπάτει", Transliteration = "periepatei", Gloss = "was walking", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And immediately the little girl stood up and began to walk,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "she was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐτῶν", Transliteration = "etōn", Gloss = "of years", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "twelve years old"
                }
            },
            Translation = "for she was twelve years old."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐξέστησαν", Transliteration = "exestēsan", Gloss = "they were amazed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "εὐθὺς", Transliteration = "euthys", Gloss = "immediately", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκστάσει", Transliteration = "ekstasei", Gloss = "with amazement", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλῃ", Transliteration = "megalē", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "with great amazement"
                }
            },
            Translation = "And they were immediately overcome with great amazement."
        },

        // Verse 43
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "διεστείλατο", Transliteration = "diesteilato", Gloss = "he strictly ordered", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "πολλὰ", Transliteration = "polla", Gloss = "greatly", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μηδεὶς", Transliteration = "mēdeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "γνοῖ", Transliteration = "gnoi", Gloss = "should know", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "that no one should know this"
                }
            },
            Translation = "And he strictly ordered them that no one should know this,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he told [them]", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοθῆναι", Transliteration = "dothēnai", Gloss = "to be given", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "to her", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "to eat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to give her something to eat"
                }
            },
            Translation = "and he told them to give her something to eat."
        }
    };
}

/*
Identified Constructions:
- VOC: "ταλιθα" (Mark 5:41), "τὸ κοράσιον" (Mark 5:41)
- DAT_MANNER: "ἐκστάσει μεγάλῃ" (Mark 5:42)
- PURPOSE_CLAUSE: "ἵνα μηδεὶς γνοῖ τοῦτο" (Mark 5:43)
- INF_PHRASE: "δοθῆναι αὐτῇ φαγεῖν" (Mark 5:43)
*/
