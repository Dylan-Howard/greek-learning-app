private static List<object> GetChapter15()
{
    // Mark 15:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Πιλᾶτος", Transliteration = "Pilatos", Gloss = "Pilate",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē", Gloss = "answered",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "pron" },
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
                        new Word { Greek = "θέλετε", Transliteration = "thelete", Gloss = "do you wish",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἀπολύσω", Transliteration = "apolysō", Gloss = "that I release",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                            PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "βασιλέα", Transliteration = "basilea", Gloss = "king",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "of the Jews"
                                }
                            },
                            Translation = "the King of the Jews"
                        }
                    },
                    Translation = "\"Do you want me to release for you the King of the Jews?\""
                }
            },
            Translation = "And Pilate answered them, saying, \"Do you want me to release for you the King of the Jews?\""
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγίνωσκεν", Transliteration = "eginōsken", Gloss = "he perceived",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "out of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "φθόνον", Transliteration = "phthonon", Gloss = "envy",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "out of envy"
                        },
                        new Word { Greek = "παραδεδώκεισαν", Transliteration = "paradedōkeisan", Gloss = "had delivered up",
                            GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis", Gloss = "chief priests",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the chief priests"
                        }
                    },
                    Translation = "that the chief priests had delivered him up out of envy"
                }
            },
            Translation = "For he perceived that it was out of envy that the chief priests had delivered him up."
        },
        // Verse 11
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
                            PartOfSpeech = "art" }
                    },
                    Translation = "the"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis", Gloss = "chief priests",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "chief priests"
                },
                new Word { Greek = "ἀνέσεισαν", Transliteration = "aneseisan", Gloss = "stirred up",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὄχλον", Transliteration = "ochlon", Gloss = "crowd",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the crowd"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Βαραββᾶν", Transliteration = "Barabbān", Gloss = "Barabbas",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Barabbas"
                        },
                        new Word { Greek = "ἀπολύσῃ", Transliteration = "apolysē", Gloss = "he should release",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "for them",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "to have him release Barabbas for them instead"
                }
            },
            Translation = "But the chief priests stirred up the crowd to have him release Barabbas for them instead."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Πιλᾶτος", Transliteration = "Pilatos", Gloss = "Pilate",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "answering",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "answering"
                },
                new Word { Greek = "ἔλεγεν", Transliteration = "elegen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "θέλετε", Transliteration = "thelete", Gloss = "do you wish",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ποιήσω", Transliteration = "poiēsō", Gloss = "I should do",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "λέγετε", Transliteration = "legete", Gloss = "you call",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "βασιλέα", Transliteration = "basilea", Gloss = "king",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn
