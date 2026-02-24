import json, re, sys

# Load JSON passed via stdin
data = json.load(sys.stdin)

VALID_POS     = {"noun","verb","adjective","adverb","pronoun","article",
                 "preposition","conjunction","particle","proper noun","interjection","unknown"}
VALID_CASES   = {"NOM","GEN","DAT","ACC","VOC"}
VALID_GENDERS = {"M","F","N"}
VALID_NUMBERS = {"S","P","DUAL"}
VALID_TENSES  = {"PRES","IMPF","FUT","AOR","PERF","PLPF"}
VALID_VOICES  = {"ACT","MID","PASS"}
VALID_MOODS   = {"IND","SUBJ","OPT","IMP","INF","PTCP"}

errors = []; warnings = []; notes = []

def E(vs,wp,g,f,m): errors.append(  f"  v{vs} w{wp:02d} {g:<20} [{f}] {m}")
def W(vs,wp,g,f,m): warnings.append(f"  v{vs} w{wp:02d} {g:<20} [{f}] {m}")
def N(vs,wp,g,m):   notes.append(   f"  v{vs} w{wp:02d} {g:<20} {m}")

total = 0
for ch_key, chapter in data["chapters"].items():
    for vs_key, tokens in chapter.items():
        vs = int(vs_key)
        for tok in tokens:
            total += 1
            wp=tok["word_pos"]; greek=tok.get("greek",""); rmac=tok.get("rmac","")
            pos=tok.get("part_of_speech",""); codes=tok.get("grammar_codes",[])
            gloss=tok.get("gloss",""); strongs=tok.get("strongs",""); cid=tok.get("clause_id","")

            if not greek.strip():
                N(vs,wp,"(empty)","Empty Greek — textual variant / apparatus placeholder"); continue

            if strongs and not re.match(r"^G\d{4}$", strongs):
                E(vs,wp,greek,"strongs",f"Bad format '{strongs}'")
            if not cid:
                W(vs,wp,greek,"clause_id","Empty")
            elif not re.match(r"^c\d+$", cid):
                E(vs,wp,greek,"clause_id",f"Bad format '{cid}'")
            if not gloss.strip():
                W(vs,wp,greek,"gloss","Empty")
            if pos not in VALID_POS:
                E(vs,wp,greek,"part_of_speech",f"Unknown value '{pos}'")
            if not codes and rmac:
                E(vs,wp,greek,"grammar_codes",f"Empty but rmac='{rmac}'"); continue
            if not codes: continue

            first = codes[0]

            # Bare digit = un-stripped 2nd-aorist prefix
            if any(c.isdigit() for c in codes):
                E(vs,wp,greek,"grammar_codes",f"Bare digit in {codes} (rmac={rmac})")

            if rmac.startswith("T"):
                if pos not in ("article","unknown"):
                    W(vs,wp,greek,"part_of_speech",f"T-prefix: got '{pos}', expected 'article'")
                if first not in ("T","ART"):
                    E(vs,wp,greek,"grammar_codes",f"T-prefix first='{first}', expected T/ART")
                if not any(c in VALID_CASES   for c in codes): E(vs,wp,greek,"grammar_codes",f"No case in {codes}")
                if not any(c in VALID_GENDERS  for c in codes): E(vs,wp,greek,"grammar_codes",f"No gender in {codes}")
                if not any(c in VALID_NUMBERS  for c in codes): E(vs,wp,greek,"grammar_codes",f"No number in {codes}")

            elif rmac.startswith("V"):
                if first != "V": E(vs,wp,greek,"grammar_codes",f"V-prefix first='{first}', expected V")
                if pos != "verb": E(vs,wp,greek,"part_of_speech",f"V-prefix: got '{pos}', expected 'verb'")
                if not any(c in VALID_TENSES for c in codes):
                    E(vs,wp,greek,"grammar_codes",f"No tense in {codes} (rmac={rmac})")
                if not any(c in VALID_VOICES for c in codes):
                    E(vs,wp,greek,"grammar_codes",f"No voice in {codes} (rmac={rmac})")
                if not any(c in VALID_MOODS  for c in codes):
                    E(vs,wp,greek,"grammar_codes",f"No mood in {codes} (rmac={rmac})")

            elif rmac.startswith("N"):
                if first != "N": E(vs,wp,greek,"grammar_codes",f"N-prefix first='{first}', expected N")
                if pos != "noun": E(vs,wp,greek,"part_of_speech",f"N-prefix: got '{pos}', expected 'noun'")
                if not any(c in VALID_CASES for c in codes): E(vs,wp,greek,"grammar_codes",f"No case in {codes}")
                if not any(c in VALID_GENDERS for c in codes): E(vs,wp,greek,"grammar_codes",f"No gender in {codes}")
                if not any(c in VALID_NUMBERS for c in codes): E(vs,wp,greek,"grammar_codes",f"No number in {codes}")

            elif rmac.startswith("A-"):
                if first != "ADJ": E(vs,wp,greek,"grammar_codes",f"A-prefix first='{first}', expected ADJ")
                if pos != "adjective": E(vs,wp,greek,"part_of_speech",f"A-prefix: got '{pos}', expected 'adjective'")
                if not any(c in VALID_CASES for c in codes): E(vs,wp,greek,"grammar_codes",f"No case in {codes}")

            elif rmac.startswith("R"):
                if first != "PRON": E(vs,wp,greek,"grammar_codes",f"R-prefix first='{first}', expected PRON")
                if pos not in ("pronoun","article","unknown"):
                    W(vs,wp,greek,"part_of_speech",f"R-prefix: got '{pos}'")
                if not any(c in VALID_CASES for c in codes): E(vs,wp,greek,"grammar_codes",f"No case in {codes}")

            elif rmac in ("PREP", "PRT-N", "PRT"):
                pass  # handled in indeclinable block below

            elif rmac.startswith("P"):
                if first not in ("P","PRON"): E(vs,wp,greek,"grammar_codes",f"P-prefix first='{first}', expected P/PRON")
                if pos not in ("pronoun","unknown"): W(vs,wp,greek,"part_of_speech",f"P-prefix: got '{pos}'")

            elif rmac.startswith("D"):
                if first not in ("ADV","D","PRON"):
                    W(vs,wp,greek,"grammar_codes",f"D-prefix first='{first}' (expected ADV/D/PRON)")

            elif rmac.startswith("F"):
                if pos not in ("pronoun","unknown"): W(vs,wp,greek,"part_of_speech",f"F-prefix reflexive: got '{pos}'")

            elif rmac.startswith("C-"):
                if pos not in ("pronoun","unknown"): W(vs,wp,greek,"part_of_speech",f"C-prefix correlative: got '{pos}'")
                if not any(c in VALID_CASES for c in codes): E(vs,wp,greek,"grammar_codes",f"No case in {codes}")

            elif rmac.startswith("S-"):
                N(vs,wp,greek,f"Possessive S-: codes={codes} (compact notation, not expanded)")

            elif rmac == "CONJ":
                if pos != "conjunction": E(vs,wp,greek,"part_of_speech",f"CONJ: got '{pos}'")
            elif rmac == "PREP":
                if pos != "preposition": E(vs,wp,greek,"part_of_speech",f"PREP: got '{pos}'")
            elif rmac == "PRT-N":
                if pos != "particle": E(vs,wp,greek,"part_of_speech",f"PRT-N: got '{pos}'")
                N(vs,wp,greek,"PRT-N: second code 'N' = negation marker, not neuter gender")
            elif rmac == "ADV":
                if pos not in ("adverb","adjective","conjunction","unknown"):
                    W(vs,wp,greek,"part_of_speech",f"ADV rmac: got '{pos}'")

print(f"Validated {total} tokens — {data['meta']['book_name']} ch{data['meta']['chapter_filter']}\n")
print(f"ERRORS ({len(errors)}):" if errors else "ERRORS: none ✓")
for e in errors: print(e)
print(f"\nWARNINGS ({len(warnings)}):" if warnings else "\nWARNINGS: none ✓")
for w in warnings: print(w)
print(f"\nNOTES / KNOWN QUIRKS ({len(notes)}):" if notes else "\nNOTES: none")
for n in notes: print(n)
print(f"\n{'='*65}")
print(f"Summary: {len(errors)} errors  |  {len(warnings)} warnings  |  {len(notes)} notes  |  {total} tokens")