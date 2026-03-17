private static List<object> GetChapter3()
{
    // 1 Peter 3:17-22
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κρεῖττον", Transliteration = "kreitton", Gloss = "better", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγαθοποιοῦντας", Transliteration = "agathopoiountas", Gloss = "doing good", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "πάσχειν", Transliteration = "paschein", Gloss = "to suffer", Grammar_codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to suffer for doing good"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "θέλοι", Transliteration = "theloi", Gloss = "should will", Grammar_codes = new List<string> { "V", "PRES", "ACT", "OPT", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θέλημα", Transliteration = "thelēma", Gloss = "will", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the will of God"
                        }
                    },
                    Translation = "if the will of God should so will"
                },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κακοποιοῦντας", Transliteration = "kakopoiountas", Gloss = "doing evil", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "for doing evil"
                }
            },
            Translation = "For it is better to suffer for doing good, if the will of God should so will, than for doing evil."
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἅπαξ", Transliteration = "hapax", Gloss = "once for all", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "for", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἁμαρτιῶν", Transliteration = "hamartiōn", Gloss = "sins", Grammar_codes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "for sins"
                },
                new Word { Greek = "ἔπαθεν", Transliteration = "epathen", Gloss = "suffered", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δίκαιος", Transliteration = "dikaios", Gloss = "the righteous", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀδίκων", Transliteration = "adikōn", Gloss = "the unrighteous", Grammar_codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "for the unrighteous"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "προσαγάγῃ", Transliteration = "prosagagē", Gloss = "he might bring", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to God"
                        }
                    },
                    Translation = "that he might bring you to God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θανατωθεὶς", Transliteration = "thanatōtheis", Gloss = "being put to death", Grammar_codes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σαρκί", Transliteration = "sarki", Gloss = "in the flesh", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "being put to death in the flesh"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζῳοποιηθεὶς", Transliteration = "zōopoiētheis", Gloss = "but being made alive", Grammar_codes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "in the spirit", Grammar_codes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "but being made alive in the spirit"
                }
            },
            Translation = "For Christ also suffered once for sins, the righteous for the unrighteous, that he might bring us to God, being put to death in the flesh but made alive in the spirit,"
        },
        // Verse 19
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "which", Grammar_codes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "in which"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "φυλακῇ", Transliteration = "phylakē", Gloss = "prison", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in prison"
                        },
                        new Word { Greek = "πνεύμασιν", Transliteration = "pneumasin", Gloss = "spirits", Grammar_codes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the spirits in prison"
                },
                new Word { Greek = "πορευθεὶς", Transliteration = "poreutheis", Gloss = "having gone", Grammar_codes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐκήρυξεν", Transliteration = "ekēryxen", Gloss = "he preached", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "in which also he went and preached to the spirits in prison,"
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπειθήσασίν", Transliteration = "apeithēsasin", Gloss = "who disobeyed", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ποτε", Transliteration = "pote", Gloss = "formerly", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀπεξεδέχετο", Transliteration = "apexedecheto", Gloss = "was waiting", Grammar_codes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                },
                                new Word { Greek = "μακροθυμία", Transliteration = "makrothymia", Gloss = "patience", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the patience of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "the days of", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "Νῶε", Transliteration = "Nōe", Gloss = "Noah", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the days of Noah"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "GEN_ABS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατασκευαζομένης", Transliteration = "kataskeuazomenēs", Gloss = "being prepared", Grammar_codes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "κιβωτοῦ", Transliteration = "kibōtou", Gloss = "an ark", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "while the ark was being prepared"
                        }
                    },
                    Translation = "when the patience of God was waiting in the days of Noah while the ark was being prepared"
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
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which", Grammar_codes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "into which"
                        },
                        new Word { Greek = "ὀλίγοι", Transliteration = "oligoi", Gloss = "a few", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτ᾽", Transliteration = "tout'", Gloss = "that", Grammar_codes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ὀκτὼ", Transliteration = "oktō", Gloss = "eight", Grammar_codes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ψυχαί", Transliteration = "psychai", Gloss = "souls", Grammar_codes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "that is, eight souls"
                        },
                        new Word { Greek = "διεσώθησαν", Transliteration = "diesōthēsan", Gloss = "were brought safely", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὕδατος", Transliteration = "hydatos", Gloss = "water", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "through water"
                        }
                    },
                    Translation = "into which a few, that is, eight souls, were brought safely through water."
                }
            },
            Translation = "because they formerly disobeyed, when the patience of God waited in the days of Noah, while the ark was being prepared, in which a few, that is, eight persons, were brought safely through water."
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", Grammar_codes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀντίτυπον", Transliteration = "antitypon", Gloss = "as a counterpart", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "σῴζει", Transliteration = "sōzei", Gloss = "saves", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "βάπτισμα", Transliteration = "baptisma", Gloss = "baptism", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Baptism, which corresponds to this, now saves you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "of the flesh", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἀπόθεσις", Transliteration = "apothesis", Gloss = "a removal", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ῥύπου", Transliteration = "rhypou", Gloss = "of dirt", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "not a removal of dirt from the body"
                        },
                        new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "συνειδήσεως", Transliteration = "syneidēseōs", Gloss = "of a conscience", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἀγαθῆς", Transliteration = "agathēs", Gloss = "good", Grammar_codes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "of a good conscience"
                                },
                                new Word { Greek = "ἐπερώτημα", Transliteration = "eperōtēma", Gloss = "as an appeal", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "to God"
                                }
                            },
                            Translation = "but as an appeal to God for a good conscience"
                        }
                    },
                    Translation = "not as a removal of dirt from the body but as an appeal to God for a good conscience"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀναστάσεως", Transliteration = "anastaseōs", Gloss = "the resurrection", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "of Jesus", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the resurrection of Jesus Christ"
                        }
                    },
                    Translation = "through the resurrection of Jesus Christ"
                }
            },
            Translation = "Baptism, which corresponds to this, now saves you, not as a removal of dirt from the body but as an appeal to God for a good conscience, through the resurrection of Jesus Christ,"
        },
        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅς", Transliteration = "hos", Gloss = "who", Grammar_codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "at", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δεξιᾷ", Transliteration = "dexia", Gloss = "the right hand", Grammar_codes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the right hand of God"
                        }
                    },
                    Translation = "at the right hand of God"
                },
                new Word { Greek = "πορευθεὶς", Transliteration = "poreutheis", Gloss = "having gone", Grammar_codes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὐρανὸν", Transliteration = "ouranon", Gloss = "heaven", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into heaven"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑποταγέντων", Transliteration = "hypotagentōn", Gloss = "having been subjected", Grammar_codes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", Grammar_codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀγγέλων", Transliteration = "angelōn", Gloss = "angels", Grammar_codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ἐξουσιῶν", Transliteration = "exousiōn", Gloss = "authorities", Grammar_codes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "δυνάμεων", Transliteration = "dynameōn", Gloss = "powers", Grammar_codes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "angels and authorities and powers"
                        }
                    },
                    Translation = "with angels, authorities, and powers having been subjected to him"
                }
            },
            Translation = "who has gone into heaven and is at the right hand of God, with angels, authorities, and powers having been subjected to him."
        }
    };
}

/*
Constructions identified:
- GEN_ABS: κατασκευαζομένης κιβωτοῦ (3:20) - Genitive participle and noun functioning as a temporal clause.
- DAT_INSTR: δι᾽ ὕδατος (3:20) - Though using 'dia', it functions instrumentally in the context of salvation/passage.
- GEN_SUBJ: τοῦ θεοῦ (3:20) - Subjective genitive with 'μακροθυμία'.
- GEN_OBJ: συνειδήσεως ἀγαθῆς (3:21) - Objective genitive with 'ἐπερώτημα'.
*/
