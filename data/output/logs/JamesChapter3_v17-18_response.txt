private static List<object> GetChapter3()
{
    // James 3:17-18
    return new List<object>
    {
        // Verse 17
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
                        new Word { Greek = "ἡ", Transliteration = "Hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἄνωθεν", Transliteration = "anōthen", Gloss = "from above", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "σοφία", Transliteration = "sophia", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "But the wisdom from above"
                },
                new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "often untranslated", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἁγνή", Transliteration = "hagnē", Gloss = "pure", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "pure"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔπειτα", Transliteration = "epeita", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰρηνική", Transliteration = "eirēnikē", Gloss = "peace-loving", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "peace-loving"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιεικής", Transliteration = "epieikēs", Gloss = "gentle", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "gentle"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐπειθής", Transliteration = "eupeithēs", Gloss = "submissive", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "submissive"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεστὴ", Transliteration = "mestē", Gloss = "full", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐλέους", Transliteration = "eleous", Gloss = "mercy", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of mercy"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καρπῶν", Transliteration = "karpōn", Gloss = "fruit", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἀγαθῶν", Transliteration = "agathōn", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of good fruits"
                        }
                    },
                    Translation = "full of mercy and good fruits"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀδιάκριτος", Transliteration = "adiakritos", Gloss = "impartial", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "impartial"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνυπόκριτος", Transliteration = "anypokritos", Gloss = "sincere", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "sincere"
                }
            },
            Translation = "But the wisdom from above is first pure, then peaceable, gentle, open to reason, full of mercy and good fruits, impartial and sincere."
        },

        // Verse 18
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
                        new Word { Greek = "καρπὸς", Transliteration = "Karpos", Gloss = "fruit", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs", Gloss = "righteousness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of righteousness"
                        }
                    },
                    Translation = "And a harvest of righteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "εἰρήνῃ", Transliteration = "eirēnē", Gloss = "peace", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in peace"
                },
                new Word { Greek = "σπείρεται", Transliteration = "speiretai", Gloss = "is sown", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "by those", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ποιοῦσιν", Transliteration = "poiousin", Gloss = "who make", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰρήνην", Transliteration = "eirēnēn", Gloss = "peace", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "peace"
                        }
                    },
                    Translation = "by those who make peace"
                }
            },
            Translation = "And a harvest of righteousness is sown in peace by those who make peace."
        }
    };
}

// Constructions:
// GEN_DESC: James 3:17 (ἐλέους, καρπῶν), James 3:18 (δικαιοσύνης)
