private static List<object> GetChapter14()
{
    // Matthew 14:33-36
    return new List<object>
    {
        // Verse 33
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "And those"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πλοίῳ", Transliteration = "ploiō", Gloss = "boat", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in the boat"
                },
                new Word { Greek = "προσεκύνησαν", Transliteration = "prosekynēsan", Gloss = "worshiped", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀληθῶς", Transliteration = "alēthōs", Gloss = "truly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God's", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "υἱὸς", Transliteration = "huios", Gloss = "Son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Son of God"
                        },
                        new Word { Greek = "εἶ", Transliteration = "ei", Gloss = "you are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "Truly you are the Son of God"
                }
            },
            Translation = "And those in the boat worshiped him, saying, 'Truly you are the Son of God.'"
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαπεράσαντες", Transliteration = "diaperasantes", Gloss = "having crossed over", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "having crossed over"
                },
                new Word { Greek = "ἦλθον", Transliteration = "ēlthon", Gloss = "they came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "land", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the land"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Γεννησαρέτ", Transliteration = "Gennēsaret", Gloss = "Gennesaret", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into Gennesaret"
                }
            },
            Translation = "And when they had crossed over, they came to land at Gennesaret."
        },

        // Verse 35
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
                        new Word { Greek = "ἐπιγνόντες", Transliteration = "epignontes", Gloss = "having recognized", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "having recognized him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄνδρες", Transliteration = "andres", Gloss = "men", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "τόπου", Transliteration = "topou", Gloss = "place", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἐκείνου", Transliteration = "ekeinou", Gloss = "that", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "of that place"
                        }
                    },
                    Translation = "the men of that place"
                },
                new Word { Greek = "ἀπέστειλαν", Transliteration = "apesteilan", Gloss = "sent", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὅλην", Transliteration = "holēn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "περίχωρον", Transliteration = "perichōron", Gloss = "surrounding region", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐκείνην", Transliteration = "ekeinēn", Gloss = "that", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "into all that surrounding region"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "προσήνεγκαν", Transliteration = "prosēnegkan", Gloss = "they brought", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κακῶς", Transliteration = "kakōs", Gloss = "badly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                                new Word { Greek = "ἔχοντας", Transliteration = "echontas", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "who were sick"
                        }
                    },
                    Translation = "all those who were sick"
                }
            },
            Translation = "And when the men of that place recognized him, they sent word into all that surrounding region and brought to him all who were sick,"
        },

        // Verse 36
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "παρεκάλουν", Transliteration = "parekaloun", Gloss = "implored", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μόνον", Transliteration = "monon", Gloss = "only", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἅψωνται", Transliteration = "hapsōntai", Gloss = "they might touch", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κρασπέδου", Transliteration = "kraspedou", Gloss = "fringe", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἱματίου", Transliteration = "himatiou", Gloss = "garment", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "of his garment"
                                }
                            },
                            Translation = "the fringe of his garment"
                        }
                    },
                    Translation = "that they might only touch the fringe of his garment"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσοι", Transliteration = "hosoi", Gloss = "as many as", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἥψαντο", Transliteration = "hēpsanto", Gloss = "touched", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "as many as touched it"
                },
                new Word { Greek = "διεσώθησαν", Transliteration = "diesōthēsan", Gloss = "were made well", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "and implored him that they might only touch the fringe of his garment. And as many as touched it were made well."
        }
    };
}

/*
Constructions identified:
- GEN_DESC: v35 (τοῦ τόπου ἐκείνου), v36 (τοῦ ἱματίου αὐτοῦ)
- PTCP: v33 (λέγοντες), v34 (διαπεράσαντες), v35 (ἐπιγνόντες, κακῶς ἔχοντας)
- PURPOSE_CLAUSE: v36 (ἵνα ... ἅψωνται)
- REL_CLAUSE: v36 (ὅσοι ἥψαντο)
*/
