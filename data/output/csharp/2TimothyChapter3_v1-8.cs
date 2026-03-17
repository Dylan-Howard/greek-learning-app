private static List<object> GetChapter3()
{
    // 2 Timothy 3:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τοῦτο", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γίνωσκε", Transliteration = "", Gloss = "to know", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐσχάταις", Transliteration = "", Gloss = "last", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἡμέραις", Transliteration = "", Gloss = "day", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the last days"
                                }
                            },
                            Translation = "in the last days"
                        },
                        new Word { Greek = "ἐνστήσονται", Transliteration = "", Gloss = "to be present", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καιροὶ", Transliteration = "", Gloss = "time", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "χαλεποί", Transliteration = "", Gloss = "difficult", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "difficult times"
                        }
                    },
                    Translation = "that difficult times will come in the last days"
                }
            },
            Translation = "But understand this, that in the last days there will come times of difficulty."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔσονται", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄνθρωποι", Transliteration = "", Gloss = "human being", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "people"
                },
                new Word { Greek = "φίλαυτοι", Transliteration = "", Gloss = "loving oneself", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "φιλάργυροι", Transliteration = "", Gloss = "money-loving", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀλαζόνες", Transliteration = "", Gloss = "boaster", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "ὑπερήφανοι", Transliteration = "", Gloss = "proud", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "βλάσφημοι", Transliteration = "", Gloss = "blasphemous", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γονεῦσιν", Transliteration = "", Gloss = "parents", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀπειθεῖς", Transliteration = "", Gloss = "disobedient", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "disobedient to parents"
                },
                new Word { Greek = "ἀχάριστοι", Transliteration = "", Gloss = "ungrateful", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀνόσιοι", Transliteration = "", Gloss = "unholy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },

                // Verse 3 (continues verse 2)
                new Word { Greek = "ἄστοργοι", Transliteration = "", Gloss = "without love", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἄσπονδοι", Transliteration = "", Gloss = "unforgiving", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "διάβολοι", Transliteration = "", Gloss = "devilish", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀκρατεῖς", Transliteration = "", Gloss = "without self-control", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀνήμεροι", Transliteration = "", Gloss = "brutal", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀφιλάγαθοι", Transliteration = "", Gloss = "not loving good", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },

                // Verse 4 (continues verse 2)
                new Word { Greek = "προδόται", Transliteration = "", Gloss = "traitor", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "προπετεῖς", Transliteration = "", Gloss = "rash", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "τετυφωμένοι", Transliteration = "", Gloss = "to be conceited", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φιλήδονοι", Transliteration = "", Gloss = "loving pleasure", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "μᾶλλον", Transliteration = "", Gloss = "more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἢ", Transliteration = "", Gloss = "either...or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φιλόθεοι", Transliteration = "", Gloss = "loving God", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "lovers of pleasure rather than lovers of God"
                },

                // Verse 5 (continues verse 2)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχοντες", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μόρφωσιν", Transliteration = "", Gloss = "embodiment", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "εὐσεβείας", Transliteration = "", Gloss = "godliness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the appearance of godliness"
                        }
                    },
                    Translation = "having the appearance of godliness"
                },
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
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "δύναμιν", Transliteration = "", Gloss = "power", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῆς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "its power"
                        },
                        new Word { Greek = "ἠρνημένοι", Transliteration = "", Gloss = "to deny", GrammarCodes = new List<string> { "V", "PERF", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "but denying its power"
                }
            },
            Translation = "For people will be lovers of self, lovers of money, proud, arrogant, abusive, disobedient to parents, ungrateful, unholy, heartless, unappeasable, slanderous, without self-control, brutal, not loving good, treacherous, reckless, swollen with conceit, lovers of pleasure rather than lovers of God, having the appearance of godliness, but denying its power."
        },

        // Verse 5 (new sentence)
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τούτους", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἀποτρέπου", Transliteration = "", Gloss = "to have nothing to do with", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Avoid such people."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἐκ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τούτων", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "among them"
                },
                new Word { Greek = "γάρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἰσιν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐνδύνοντες", Transliteration = "", Gloss = "to worm one's way", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὰς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "οἰκίας", Transliteration = "", Gloss = "house", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "households"
                                        }
                                    },
                                    Translation = "into households"
                                }
                            },
                            Translation = "creeping into households"
                        }
                    },
                    Translation = "those who creep into households"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἰχμαλωτίζοντες", Transliteration = "", Gloss = "to take captive", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γυναικάρια", Transliteration = "", Gloss = "weak-willed woman", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "σεσωρευμένα", Transliteration = "", Gloss = "to heap up", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" },
                                        new Word { Greek = "ἁμαρτίαις", Transliteration = "", Gloss = "sin", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "burdened with sins"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀγόμενα", Transliteration = "", Gloss = "to bring", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐπιθυμίαις", Transliteration = "", Gloss = "desire", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ποικίλαις", Transliteration = "", Gloss = "of various kinds", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" }
                                            },
                                            Translation = "various passions"
                                        }
                                    },
                                    Translation = "led by various passions"
                                },

                                // Verse 7 (continues description of women)
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πάντοτε", Transliteration = "", Gloss = "always", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "μανθάνοντα", Transliteration = "", Gloss = "to learn", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "always learning"
                                },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μηδέποτε", Transliteration = "", Gloss = "never", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                                            Content = new List<object>
                                            {
