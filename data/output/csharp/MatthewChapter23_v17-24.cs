private static List<object> GetChapter23()
{
    // Matthew 23:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "VOC_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "μωροὶ", Transliteration = "mōroi", Gloss = "blind fools", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τυφλοί", Transliteration = "typhloi", Gloss = "blind", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "You blind fools!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μείζων", Transliteration = "meizōn", Gloss = "greater", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "χρυσὸς", Transliteration = "chrysos", Gloss = "gold", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ναὸς", Transliteration = "naos", Gloss = "temple", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἁγιάσας", Transliteration = "hagiasas", Gloss = "having sanctified", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "χρυσόν", Transliteration = "chryson", Gloss = "gold", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the gold"
                                }
                            },
                            Translation = "the one that sanctifies the gold"
                        }
                    },
                    Translation = "the gold or the temple that sanctifies the gold"
                }
            },
            Translation = "For which is greater, the gold or the temple that has sanctified the gold?"
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καί", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "whoever", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "ὀμόσῃ", Transliteration = "omosē", Gloss = "should swear", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θυσιαστηρίῳ", Transliteration = "thysiastēriō", Gloss = "altar", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "by the altar"
                        }
                    },
                    Translation = "Whoever swears by the altar"
                },
                new Word { Greek = "οὐδέν", Transliteration = "ouden", Gloss = "nothing", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "it is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "And, ‘Whoever swears by the altar, it is nothing;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "whoever", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "δ᾽", Transliteration = "d'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "ὀμόσῃ", Transliteration = "omosē", Gloss = "should swear", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δώρῳ", Transliteration = "dōrō", Gloss = "gift", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐπάνω", Transliteration = "epanō", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "it", GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "the one upon it"
                                }
                            },
                            Translation = "by the gift that is on it"
                        }
                    },
                    Translation = "but whoever swears by the gift that is on it"
                },
                new Word { Greek = "ὀφείλει", Transliteration = "opheilei", Gloss = "is bound", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "but whoever swears by the gift that is on it, he is bound.’"
        },
        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "VOC_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "τυφλοί", Transliteration = "typhloi", Gloss = "You blind men", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "You blind men!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μεῖζον", Transliteration = "meizon", Gloss = "greater", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δῶρον", Transliteration = "dōron", Gloss = "gift", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θυσιαστήριον", Transliteration = "thysiastērion", Gloss = "altar", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἁγιάζον", Transliteration = "hagiazon", Gloss = "sanctifying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δῶρον", Transliteration = "dōron", Gloss = "gift", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the gift"
                                }
                            },
                            Translation = "that sanctifies the gift"
                        }
                    },
                    Translation = "the gift or the altar that sanctifies the gift"
                }
            },
            Translation = "For which is greater, the gift or the altar that sanctifies the gift?"
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὀμόσας", Transliteration = "omosas", Gloss = "having sworn", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θυσιαστηρίῳ", Transliteration = "thysiastēriō", Gloss = "altar", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "by the altar"
                        }
                    },
                    Translation = "So whoever swears by the altar"
                },
                new Word { Greek = "ὀμνύει", Transliteration = "omnyei", Gloss = "swears", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "it", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "by it"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πᾶσιν", Transliteration = "pasin", Gloss = "everything", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the [things]", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐπάνω", Transliteration = "epanō", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "it", GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "everything on it"
                        }
                    },
                    Translation = "by everything on it"
                }
            },
            Translation = "So whoever swears by the altar swears by it and by everything on it."
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀμόσας", Transliteration = "omosas", Gloss = "having sworn", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ναῷ", Transliteration = "naō", Gloss = "temple", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "by the temple"
                        }
                    },
                    Translation = "whoever swears by the temple"
                },
                new Word { Greek = "ὀμνύει", Transliteration = "omnyei", Gloss = "swears", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "it", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "by it"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κατοικοῦντι", Transliteration = "katoikounti", Gloss = "dwelling in", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "him who dwells in it"
                        }
                    },
                    Translation = "by him who dwells in it"
                }
            },
            Translation = "And whoever swears by the temple swears by it and by him who dwells in it."
        },
        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀμόσας", Transliteration = "omosas", Gloss = "having sworn", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανῷ", Transliteration = "ouranō", Gloss = "heaven", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "by heaven"
                        }
                    },
                    Translation = "whoever swears by heaven"
                },
                new Word { Greek = "ὀμνύει", Transliteration = "omnyei", Gloss = "swears", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνῳ", Transliteration = "thronō", Gloss = "throne", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the throne of God"
                        }
                    },
                    Translation = "by the throne of God"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καθημένῳ", Transliteration = "kathēmenō", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ἐπάνω", Transliteration = "epanō", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "it", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "him who sits on it"
                        }
                    },
                    Translation = "by him who sits on it"
                }
            },
            Translation = "And whoever swears by heaven swears by the throne of God and by him who sits on it."
        },
        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐαὶ", Transliteration = "Ouai", Gloss = "Woe", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γραμματεῖς", Transliteration = "grammateis", Gloss = "scribes", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Φαρισαῖοι", Transliteration = "Pharisaioi", Gloss = "Pharisees", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ὑποκριταί", Transliteration = "hypokritai", Gloss = "hypocrites", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "scribes and Pharisees, hypocrites!"
                }
            },
            Translation = "Woe to you, scribes and Pharisees, hypocrites!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀποδεκατοῦτε", Transliteration = "apodekatoute", Gloss = "you tithe", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἡδύοσμον", Transliteration = "hēdyosmon", Gloss = "mint", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄνηθον", Transliteration = "anēthon", Gloss = "dill", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύμινον", Transliteration = "kyminon", Gloss = "cummin", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "mint and dill and cummin"
                }
            },
            Translation = "For you tithe mint and dill and cummin,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀφήκατε", Transliteration = "aphēkate", Gloss = "have neglected", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "βαρύτερα", Transliteration = "barytera", Gloss = "weightier matters", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of the law"
                        }
                    },
                    Translation = "the weightier matters of the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κρίσιν", Transliteration = "krisin", Gloss = "justice", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔλεος", Transliteration = "eleos", Gloss = "mercy", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πίστιν", Transliteration = "pistin", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "justice and mercy and faithfulness"
                }
            },
            Translation = "and have neglected the weightier matters of the law: justice and mercy and faithfulness."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔδει", Transliteration = "edei", Gloss = "it was necessary", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποιῆσαι", Transliteration = "poiēsai", Gloss = "to have done", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to have done"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κἀκεῖνα", Transliteration = "kakeina", Gloss = "and those others", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "ἀφιέναι", Transliteration = "aphienai", Gloss = "to leave undone", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and not to leave those others undone"
                }
            },
            Translation = "These you ought to have done, without neglecting the others."
        },
        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "VOC_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁδηγοὶ", Transliteration = "hodēgoi", Gloss = "guides", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "τυφλοί", Transliteration = "typhloi", Gloss = "blind", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "You blind guides!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the [ones]", GrammarCodes = new List<string> { "ART", "VOC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "διϋλίζοντες", Transliteration = "diylizontes", Gloss = "straining out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κώνωπα", Transliteration = "kōnōpa", Gloss = "gnat", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the gnat"
                        }
                    },
                    Translation = "straining out the gnat"
                },
                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κάμηλον", Transliteration = "kamēlon", Gloss = "camel", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "καταπίνοντες", Transliteration = "katapinontes", Gloss = "swallowing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "straining out a gnat and swallowing a camel!"
        }
    };
}

/*
Constructions identified:
- VOC_PHRASE: Matthew 23:17, 19, 23, 24
- REL_CLAUSE (ὃς ἂν + Subjunctive): Matthew 23:18
- Attributive Participle (ὁ ἁγιάσας): Matthew 23:17
- Substantival Participle (ὁ ὀμόσας): Matthew 23:20, 21, 22
- Causal Clause (ὅτι): Matthew 23:23
- Appositive (τὴν κρίσιν...): Matthew 23:23
- Infinitival Phrase (ἔδει ποιῆσαι): Matthew 23:23
*/
