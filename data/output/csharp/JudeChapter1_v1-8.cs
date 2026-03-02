private static List<object> GetChapter1()
{
    // Jude 1:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἰούδας", Transliteration = "Ioudas", Gloss = "Jude", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "of Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of Jesus Christ"
                },
                new Word { Greek = "δοῦλος", Transliteration = "doulos", Gloss = "a servant", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰακώβου", Transliteration = "Iakōbou", Gloss = "of James", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of James"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to those", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "πατρὶ", Transliteration = "patri", Gloss = "the Father", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in God the Father"
                                },
                                new Word { Greek = "ἠγαπημένοις", Transliteration = "ēgapēmenois", Gloss = "beloved", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "beloved in God the Father"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "for Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "for Jesus Christ"
                                },
                                new Word { Greek = "τετηρημένοις", Transliteration = "tetērēmenois", Gloss = "kept", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "kept for Jesus Christ"
                        },
                        new Word { Greek = "κλητοῖς", Transliteration = "klētois", Gloss = "called", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "to those who are called, beloved in God the Father and kept for Jesus Christ"
                }
            },
            Translation = "Jude, a servant of Jesus Christ and brother of James, to those who are called, beloved in God the Father and kept for Jesus Christ:"
        },

        // Verse 2
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
                        new Word { Greek = "ἔλεος", Transliteration = "eleos", Gloss = "May mercy", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀγάπη", Transliteration = "agapē", Gloss = "love", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "May mercy, peace, and love"
                },
                new Word { Greek = "πληθυνθείη", Transliteration = "plēthyntheiē", Gloss = "be multiplied", GrammarCodes = new List<string> { "V", "AOR", "PASS", "OPT", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "May mercy, peace, and love be multiplied to you."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀγαπητοί", Transliteration = "Agapētoi", Gloss = "Beloved", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πᾶσαν", Transliteration = "pasan", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σπουδὴν", Transliteration = "spoudēn", Gloss = "diligence", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "all diligence"
                        },
                        new Word { Greek = "ποιούμενος", Transliteration = "poioumenos", Gloss = "making", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "making every effort"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γράφειν", Transliteration = "graphein", Gloss = "to write", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κοινῆς", Transliteration = "koinēs", Gloss = "common", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "σωτηρίας", Transliteration = "sōtērias", Gloss = "salvation", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "our common salvation"
                                }
                            },
                            Translation = "concerning our common salvation"
                        }
                    },
                    Translation = "to write to you concerning our common salvation"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀνάγκην", Transliteration = "anagkēn", Gloss = "necessity", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "necessity"
                        },
                        new Word { Greek = "ἔσχον", Transliteration = "eschon", Gloss = "I found", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "I found it necessary"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γράψαι", Transliteration = "grapsai", Gloss = "to write", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to write to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρακαλῶν", Transliteration = "parakalōn", Gloss = "appealing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπαγωνίζεσθαι", Transliteration = "epagōnizesthai", Gloss = "to contend", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "for the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἅπαξ", Transliteration = "hapax", Gloss = "once for all", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "παραδοθείσῃ", Transliteration = "paradotheisē", Gloss = "delivered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "DAT", "F", "S" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ἁγίοις", Transliteration = "hagiois", Gloss = "saints", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                                            },
                                            Translation = "to the saints"
                                        },
                                        new Word { Greek = "πίστει", Transliteration = "pistei", Gloss = "faith", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "for the faith once for all delivered to the saints"
                                }
                            },
                            Translation = "to contend for the faith once for all delivered to the saints"
                        }
                    },
                    Translation = "appealing to you to contend for the faith"
                }
            },
            Translation = "Beloved, although I was very eager to write to you about our common salvation, I found it necessary to write appealing to you to contend for the faith that was once for all delivered to the saints."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "παρεισέδυσαν", Transliteration = "pareisedysan", Gloss = "have crept in unnoticed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τινες", Transliteration = "tines", Gloss = "certain", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἄνθρωποι", Transliteration = "anthrōpoi", Gloss = "people", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "certain people"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "who", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πάλαι", Transliteration = "palai", Gloss = "long ago", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "προγεγραμμένοι", Transliteration = "progegrammenoi", Gloss = "were designated", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
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
                                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" },
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κρίμα", Transliteration = "krima", Gloss = "judgment", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "this judgment"
                                }
                            },
                            Translation = "for this judgment"
                        }
                    },
                    Translation = "who long ago were designated for this judgment"
                },
                new Word { Greek = "ἀσεβεῖς", Transliteration = "asebeis", Gloss = "ungodly people", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "of our God"
                                },
                                new Word { Greek = "χάριτα", Transliteration = "charita", Gloss = "grace", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the grace of our God"
                        },
                        new Word { Greek = "μετατιθέντες", Transliteration = "metatithentes", Gloss = "perverting", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἀσέλγειαν", Transliteration = "aselgeian", Gloss = "sensuality", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "into sensuality"
                        }
                    },
                    Translation = "perverting the grace of our God into sensuality"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "TSKS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "μόνον", Transliteration = "monon", Gloss = "only", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "δεσπότην", Transliteration = "despotēn", Gloss = "Master", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "κύριον", Transliteration = "kyrion", Gloss = "Lord", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "our only Master and Lord"
                                },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστὸν", Transliteration = "Christon", Gloss = "Christ", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "our only Master and Lord, Jesus Christ"
                        },
                        new Word { Greek = "ἀρνούμενοι", Transliteration = "arnoumenoi", Gloss = "denying", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "denying our only Master and Lord, Jesus Christ"
                }
            },
            Translation = "For certain people have crept in unnoticed who long ago were designated for this judgment, ungodly people, who pervert the grace of our God into sensuality and deny our only Master and Lord, Jesus Christ."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὑπομνῆσαι", Transliteration = "Hypomnēsai", Gloss = "to remind", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "Now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "βούλομαι", Transliteration = "boulomai", Gloss = "I want", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰδότας", Transliteration = "eidotas", Gloss = "knowing", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἅπαξ", Transliteration = "hapax", Gloss = "once for all", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "although you once for all knew all these things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "λαὸν", Transliteration = "laon", Gloss = "a people", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "a people"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "the land", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Αἰγύπτου", Transliteration = "Aigyptou", Gloss = "of Egypt", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the land of Egypt"
                                        }
                                    },
                                    Translation = "out of the land of Egypt"
                                },
                                new Word { Greek = "σώσας", Transliteration = "sōsas", Gloss = "having saved", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "after saving a people out of the land of Egypt"
                        },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δεύτερον", Transliteration = "deuteron", Gloss = "afterward", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those who", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πιστεύσαντας", Transliteration = "pisteusantas", Gloss = "believed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "those who did not believe"
                        },
                        new Word { Greek = "ἀπώλεσεν", Transliteration = "apōlesen", Gloss = "he destroyed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that Jesus, after saving a people out of the land of Egypt, afterward destroyed those who did not believe."
                }
            },
            Translation = "Now I want to remind you, although you once fully knew it, that Jesus, who saved a people out of the land of Egypt, afterward destroyed those who did not believe."
        },

        // Verse 6
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
                        new Word { Greek = "ἀγγέλους", Transliteration = "aggelous", Gloss = "angels", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "who", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "did not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τηρήσαντας", Transliteration = "tērēsantas", Gloss = "keep", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "their own", GrammarCodes = new List<string> { "PRON", "GEN", "3P", "P" }, PartOfSpeech = "f" },
                                        new Word { Greek = "ἀρχὴν", Transliteration = "archēn", Gloss = "position of authority", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "their own position of authority"
                                }
                            },
                            Translation = "the angels who did not stay within their own position of authority"
                        },
                        new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπολιπόντας", Transliteration = "apolipontas", Gloss = "left", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἴδιον", Transliteration = "idion", Gloss = "proper", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "οἰκητήριον", Transliteration = "oikētērion", Gloss = "dwelling", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "their proper dwelling"
                                }
                            },
                            Translation = "but left their proper dwelling"
                        }
                    },
                    Translation = "the angels who did not stay within their own position of authority, but left their proper dwelling"
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
                                new Word { Greek = "κρίσιν", Transliteration = "krisin", Gloss = "the judgment", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μεγάλης", Transliteration = "megalēs", Gloss = "of the great", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "Day", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the great Day"
                                }
                            },
                            Translation = "the judgment of the great Day"
                        }
                    },
                    Translation = "for the judgment of the great Day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δεσμοῖς", Transliteration = "desmois", Gloss = "with chains", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀϊδίοις", Transliteration = "aidiois", Gloss = "eternal", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "in eternal chains"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ζόφον", Transliteration = "zophon", Gloss = "gloomy darkness", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "under gloomy darkness"
                },
                new Word { Greek = "τετήρηκεν", Transliteration = "tetērēken", Gloss = "he has kept", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And the angels who did not stay within their own position of authority, but left their proper dwelling, he has kept in eternal chains under gloomy darkness for the judgment of the great day—"
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "just as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Σόδομα", Transliteration = "Sodoma", Gloss = "Sodom", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Γόμορρα", Transliteration = "Gomorra", Gloss = "Gomorrah", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "surrounding", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτὰς", Transliteration = "autas", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "F", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "surrounding them"
                        },
                        new Word { Greek = "πόλεις", Transliteration = "poleis", Gloss = "cities", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the surrounding cities"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὅμοιον", Transliteration = "homoion", Gloss = "similar", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τρόπον", Transliteration = "tropon", Gloss = "manner", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τούτοις", Transliteration = "toutois", Gloss = "to these", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "in the same manner as these"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκπορνεύσασαι", Transliteration = "ekporneusasai", Gloss = "having indulged in sexual immorality", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀπελθοῦσαι", Transliteration = "apelthousai", Gloss = "pursued", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὀπίσω", Transliteration = "opisō", Gloss = "after", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἑτέρας", Transliteration = "heteras", Gloss = "unnatural", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "unnatural flesh"
                                }
                            },
                            Translation = "after unnatural flesh"
                        }
                    },
                    Translation = "having indulged in sexual immorality and pursued unnatural desire"
                },
                new Word { Greek = "πρόκεινται", Transliteration = "prokeintai", Gloss = "serve", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δεῖγμα", Transliteration = "deigma", Gloss = "as an example", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πυρὸς", Transliteration = "pyros", Gloss = "of a fire", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αἰωνίου", Transliteration = "aiōniou", Gloss = "eternal", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of eternal fire"
                        },
                        new Word { Greek = "δίκην", Transliteration = "dikēn", Gloss = "punishment", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "as an example of the punishment of eternal fire"
                },
                new Word { Greek = "ὑπέχουσαι", Transliteration = "hypechousai", Gloss = "undergoing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" }
            },
            Translation = "just as Sodom and Gomorrah and the surrounding cities, which likewise indulged in sexual immorality and pursued unnatural desire, serve as an example by undergoing a punishment of eternal fire."
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὁμοίως", Transliteration = "Homoiōs", Gloss = "Yet in like manner", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "μέντοι", Transliteration = "mentoi", Gloss = "nevertheless", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "these people", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἐνυπνιαζόμενοι", Transliteration = "enypniazomenoi", Gloss = "relying on their dreams", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "these people, relying on their dreams"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "the flesh", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μιαίνουσιν", Transliteration = "miainousin", Gloss = "defile", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "defile the flesh"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κυριότητα", Transliteration = "kyriotēta", Gloss = "authority", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀθετοῦσιν", Transliteration = "athetousin", Gloss = "reject", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "reject authority"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δόξας", Transliteration = "doxas", Gloss = "the glorious ones", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "βλασφημοῦσιν", Transliteration = "blasphēmousin", Gloss = "blaspheme", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "blaspheme the glorious ones"
                }
            },
            Translation = "Yet in like manner these people also, relying on their dreams, defile the flesh, reject authority, and blaspheme the glorious ones."
        }
    };
}

/*
Constructions identified:
- TSKS: Verse 4 (τὸν μόνον δεσπότην καὶ κύριον)
- DAT_INSTR: Verse 6 (δεσμοῖς ἀϊδίοις)
- DAT_MANNER: Verse 7 (τὸν ὅμοιον τρόπον)
- GEN_DESC: Verse 1 (Ἰησοῦ Χριστοῦ), Verse 4 (τοῦ θεοῦ ἡμῶν), Verse 6 (μεγάλης ἡμέρας), Verse 7 (πυρὸς αἰωνίου)
*/
