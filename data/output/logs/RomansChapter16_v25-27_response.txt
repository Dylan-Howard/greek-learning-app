private static List<object> GetChapter16()
{
    // Romans 16:25-27
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τῷ", Transliteration = "Tō", Gloss = "to the one", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δυναμένῳ", Transliteration = "dynamenō", Gloss = "being able", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                                new Word { Greek = "στηρίξαι", Transliteration = "stērixai", Gloss = "to strengthen", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to strengthen you"
                        }
                    },
                    Translation = "Now to him who is able to strengthen you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "εὐαγγέλιόν", Transliteration = "euangelion", Gloss = "gospel", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "my gospel"
                        }
                    },
                    Translation = "according to my gospel"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κήρυγμα", Transliteration = "kērygma", Gloss = "preaching", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "of Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the preaching of Jesus Christ"
                        }
                    },
                    Translation = "and the preaching of Jesus Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀποκάλυψιν", Transliteration = "apokalypsin", Gloss = "revelation", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μυστηρίου", Transliteration = "mystēriou", Gloss = "of [the] mystery", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the revelation of the mystery"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χρόνοις", Transliteration = "chronois", Gloss = "for ages", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αἰωνίοις", Transliteration = "aiōniois", Gloss = "eternal", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σεσιγημένου", Transliteration = "sesigēmenou", Gloss = "having been kept secret", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "GEN", "N", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "which was kept secret for long ages"
                        }
                    },
                    Translation = "according to the revelation of the mystery which was kept secret for long ages"
                },
                // Verse 26
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        // (continues verse 25)
                        new Word { Greek = "φανερωθέντος", Transliteration = "phanerōthentos", Gloss = "having been revealed", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "N", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διά", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τε", Transliteration = "te", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "γραφῶν", Transliteration = "graphōn", Gloss = "scriptures", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "προφητικῶν", Transliteration = "prophētikōn", Gloss = "prophetic", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "the prophetic scriptures"
                                }
                            },
                            Translation = "and through the prophetic scriptures"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐπιταγὴν", Transliteration = "epitagēn", Gloss = "command", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "αἰωνίου", Transliteration = "aiōniou", Gloss = "eternal", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the command of the eternal God"
                                }
                            },
                            Translation = "according to the command of the eternal God"
                        },
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
                                        new Word { Greek = "ὑπακοὴν", Transliteration = "hypakoēn", Gloss = "obedience", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "of faith", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the obedience of faith"
                                }
                            },
                            Translation = "for the obedience of faith"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "nations", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "all the nations"
                                }
                            },
                            Translation = "to all the nations"
                        },
                        new Word { Greek = "γνωρισθέντος", Transliteration = "gnōristhentos", Gloss = "having been made known", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "N", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but now has been manifested and through the prophetic scriptures according to the command of the eternal God has been made known to all nations for the obedience of faith"
                },
                // Verse 27
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ", "APPOS" },
                    Content = new List<object>
                    {
                        // (continues verse 25)
                        new Word { Greek = "μόνῳ", Transliteration = "monō", Gloss = "only", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "σοφῷ", Transliteration = "sophō", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "Jesus Christ"
                                }
                            },
                            Translation = "through Jesus Christ"
                        }
                    },
                    Translation = "to the only wise God through Jesus Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "to whom", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δόξα", Transliteration = "doxa", Gloss = "glory", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the glory"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
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
                        }
                    },
                    Translation = "to whom be glory forever"
                },
                new Word { Greek = "ἀμήν", Transliteration = "amēn", Gloss = "amen", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "h" }
            },
            Translation = "Now to him who is able to strengthen you according to my gospel and the preaching of Jesus Christ, according to the revelation of the mystery which was kept secret for long ages but now has been manifested and through the prophetic scriptures according to the command of the eternal God has been made known to all nations for the obedience of faith, to the only wise God through Jesus Christ, to whom be glory forever. Amen."
        }
    };
}

/*
Constructions Identified:
- Substantival Participle: Τῷ δυναμένῳ (v25) - functioning as the primary indirect object of the doxology.
- Infinitival Complement: ὑμᾶς στηρίξαι (v25) - following δυναμένῳ.
- Attributive Participles: σεσιγημένου (v25), φανερωθέντος (v26), γνωρισθέντος (v26) - all modifying μυστηρίου (the mystery).
- Apposition: μόνῳ σοφῷ θεῷ (v27) - in apposition to the implied "Him" of verse 25.
- Relative Clause: ᾧ ἡ δόξα... (v27) - closing the doxology.
*/
