#!/usr/bin/env python3
"""Compile chapter-range C# snippets into a book-level seed wrapper class."""

from __future__ import annotations

import argparse
import json
import re
import sys
import textwrap
from collections import OrderedDict
from dataclasses import dataclass
from pathlib import Path
from typing import Iterable


@dataclass(frozen=True)
class Segment:
    path: Path
    chapter: int
    verse_start: int
    verse_end: int
    chapter_from_method: int
    body: str


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Compile chapter-range C# seed snippets into a single book wrapper."
    )
    parser.add_argument(
        "--input-dir",
        default="data/output/csharp",
        help="Directory containing chapter-range C# snippets.",
    )
    parser.add_argument(
        "--book",
        required=True,
        help="Book prefix used in snippet file names (e.g., 1John, Matthew, Revelation).",
    )
    parser.add_argument(
        "--output",
        required=True,
        help="Output C# file path (e.g., backend/.../FirstJohnTextData.cs).",
    )
    parser.add_argument(
        "--namespace",
        dest="namespace_name",
        default="Koine.Infrastructure.Data.Seed",
        help="C# namespace to generate.",
    )
    parser.add_argument(
        "--class-name",
        default=None,
        help="C# class name to generate. Defaults to '<book>TextData'.",
    )
    parser.add_argument(
        "--occurrences-json",
        default="backend/src/Koine.Infrastructure/Data/Seed/greeknt-occurrences.json",
        help="Optional JSON dictionary of root -> occurrences for vocabulary fallback values.",
    )
    parser.add_argument(
        "--fallback-log-dir",
        default="data/output/logs",
        help="Optional logs directory with *_response.txt snippets to use when .cs snippets are missing or malformed.",
    )
    parser.add_argument(
        "--strict-ranges",
        action="store_true",
        help="Fail if a chapter has gaps in verse ranges.",
    )
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Print summary only; do not write output.",
    )
    return parser.parse_args()


def find_matching_brace(text: str, open_index: int) -> int:
    depth = 0
    in_string = False
    in_char = False
    escaped = False
    in_line_comment = False
    in_block_comment = False

    i = open_index
    while i < len(text):
        ch = text[i]
        nxt = text[i + 1] if i + 1 < len(text) else ""

        if in_line_comment:
            if ch == "\n":
                in_line_comment = False
            i += 1
            continue

        if in_block_comment:
            if ch == "*" and nxt == "/":
                in_block_comment = False
                i += 2
                continue
            i += 1
            continue

        if in_string:
            if escaped:
                escaped = False
            elif ch == "\\":
                escaped = True
            elif ch == '"':
                in_string = False
            i += 1
            continue

        if in_char:
            if escaped:
                escaped = False
            elif ch == "\\":
                escaped = True
            elif ch == "'":
                in_char = False
            i += 1
            continue

        if ch == "/" and nxt == "/":
            in_line_comment = True
            i += 2
            continue
        if ch == "/" and nxt == "*":
            in_block_comment = True
            i += 2
            continue
        if ch == '"':
            in_string = True
            i += 1
            continue
        if ch == "'":
            in_char = True
            i += 1
            continue

        if ch == "{":
            depth += 1
        elif ch == "}":
            depth -= 1
            if depth == 0:
                return i

        i += 1

    raise ValueError("Unbalanced braces while parsing C# snippet.")


def extract_chapter_body_from_text(text: str, source: Path) -> tuple[int, str]:
    method_match = re.search(
        r"private\s+static\s+List<object>\s+GetChapter(?P<chapter>\d+)\s*\(\s*\)",
        text,
    )
    if method_match is None:
        raise ValueError(f"No GetChapter method found in {source}")

    chapter = int(method_match.group("chapter"))
    return_match = re.search(r"return\s+new\s+List<object>\s*", text[method_match.end() :])
    if return_match is None:
        raise ValueError(f"No return new List<object> block found in {source}")

    return_index = method_match.end() + return_match.start()
    open_brace_index = text.find("{", return_index)
    if open_brace_index < 0:
        raise ValueError(f"Could not locate list initializer in {source}")

    close_brace_index = find_matching_brace(text, open_brace_index)
    body = text[open_brace_index + 1 : close_brace_index]
    normalized = textwrap.dedent(body).strip()
    if normalized.endswith(","):
        normalized = normalized[:-1].rstrip()
    return chapter, normalized


def collect_segments(input_dir: Path, log_dir: Path, book: str) -> tuple[list[Segment], list[str]]:
    book_key = book.replace(" ", "")
    csharp_filename_re = re.compile(
        rf"^{re.escape(book_key)}Chapter(?P<chapter>\d+)_v(?P<start>\d+)-(?P<end>\d+)\.cs$"
    )
    log_filename_re = re.compile(
        rf"^{re.escape(book_key)}Chapter(?P<chapter>\d+)_v(?P<start>\d+)-(?P<end>\d+)_response\.txt$"
    )

    candidates: dict[tuple[int, int, int], dict[str, Path]] = {}
    warnings: list[str] = []

    for path in sorted(input_dir.glob(f"{book_key}Chapter*_v*-*.cs")):
        match = csharp_filename_re.match(path.name)
        if match is None:
            continue
        key = (int(match.group("chapter")), int(match.group("start")), int(match.group("end")))
        candidates.setdefault(key, {})["csharp"] = path

    if log_dir.exists():
        for path in sorted(log_dir.glob(f"{book_key}Chapter*_v*-*_response.txt")):
            match = log_filename_re.match(path.name)
            if match is None:
                continue
            key = (int(match.group("chapter")), int(match.group("start")), int(match.group("end")))
            candidates.setdefault(key, {})["log"] = path

    segments: list[Segment] = []
    for (chapter, verse_start, verse_end), sources in sorted(candidates.items()):
        source_path = sources.get("csharp") or sources.get("log")
        if source_path is None:
            continue

        try:
            text = source_path.read_text(encoding="utf-8")
            chapter_from_method, body = extract_chapter_body_from_text(text, source_path)
        except ValueError as source_error:
            fallback_path = sources.get("log")
            if source_path.suffix == ".cs" and fallback_path is not None:
                try:
                    text = fallback_path.read_text(encoding="utf-8")
                    chapter_from_method, body = extract_chapter_body_from_text(text, fallback_path)
                    warnings.append(
                        f"Used fallback log snippet for {book_key} chapter {chapter} verses {verse_start}-{verse_end} "
                        f"because {source_path.name} was malformed."
                    )
                    source_path = fallback_path
                except ValueError as fallback_error:
                    warnings.append(
                        f"Skipped malformed snippet for {book_key} chapter {chapter} verses {verse_start}-{verse_end}: "
                        f"{source_path.name} ({source_error}); {fallback_path.name} ({fallback_error})."
                    )
                    continue
            else:
                warnings.append(
                    f"Skipped malformed snippet for {book_key} chapter {chapter} verses {verse_start}-{verse_end}: "
                    f"{source_path.name} ({source_error})."
                )
                continue

        if source_path.suffix != ".cs":
            warnings.append(
                f"Used log-only snippet for {book_key} chapter {chapter} verses {verse_start}-{verse_end} "
                f"({source_path.name}) because no .cs snippet was found."
            )

        segments.append(
            Segment(
                path=source_path,
                chapter=chapter,
                verse_start=verse_start,
                verse_end=verse_end,
                chapter_from_method=chapter_from_method,
                body=body,
            )
        )

    return segments, warnings


def validate_segments(segments: list[Segment], strict_ranges: bool) -> list[str]:
    if not segments:
        raise ValueError("No matching snippet files found for the selected book.")

    warnings: list[str] = []
    grouped: OrderedDict[int, list[Segment]] = OrderedDict()
    for seg in sorted(segments, key=lambda s: (s.chapter, s.verse_start, s.verse_end, s.path.name)):
        if seg.chapter != seg.chapter_from_method:
            raise ValueError(
                f"Chapter mismatch in {seg.path.name}: filename chapter={seg.chapter}, "
                f"method chapter={seg.chapter_from_method}"
            )
        grouped.setdefault(seg.chapter, []).append(seg)

    for chapter, chapter_segments in grouped.items():
        previous_end = None
        for segment in chapter_segments:
            if previous_end is not None:
                if segment.verse_start <= previous_end:
                    raise ValueError(
                        f"Overlapping ranges in chapter {chapter}: "
                        f"previous end={previous_end}, next start={segment.verse_start} ({segment.path.name})"
                    )
                if segment.verse_start > previous_end + 1:
                    msg = (
                        f"Gap in chapter {chapter}: missing verses "
                        f"{previous_end + 1}-{segment.verse_start - 1}"
                    )
                    if strict_ranges:
                        raise ValueError(msg)
                    warnings.append(msg)
            previous_end = segment.verse_end

    return warnings


def merge_segments_by_chapter(segments: Iterable[Segment]) -> OrderedDict[int, str]:
    chapter_map: OrderedDict[int, list[str]] = OrderedDict()
    for segment in sorted(segments, key=lambda s: (s.chapter, s.verse_start, s.verse_end, s.path.name)):
        chapter_map.setdefault(segment.chapter, []).append(segment.body)

    merged: OrderedDict[int, str] = OrderedDict()
    for chapter, parts in chapter_map.items():
        normalized_parts = [p.strip() for p in parts if p.strip()]
        merged_body = ",\n\n".join(normalized_parts)
        if merged_body and not merged_body.endswith(","):
            merged_body += ","
        merged[chapter] = merged_body

    return merged


def extract_words_in_order(chapter_bodies: Iterable[str]) -> OrderedDict[str, tuple[str, str, str]]:
    words: OrderedDict[str, tuple[str, str, str]] = OrderedDict()
    prop_patterns = {
        "Greek": re.compile(r'Greek\s*=\s*"((?:\\.|[^"\\])*)"'),
        "Transliteration": re.compile(r'Transliteration\s*=\s*"((?:\\.|[^"\\])*)"'),
        "Gloss": re.compile(r'Gloss\s*=\s*"((?:\\.|[^"\\])*)"'),
        "PartOfSpeech": re.compile(r'PartOfSpeech\s*=\s*"((?:\\.|[^"\\])*)"'),
    }

    for body in chapter_bodies:
        search_index = 0
        while True:
            word_index = body.find("new Word", search_index)
            if word_index < 0:
                break
            open_brace = body.find("{", word_index)
            if open_brace < 0:
                break
            close_brace = find_matching_brace(body, open_brace)
            block = body[open_brace + 1 : close_brace]

            greek_match = prop_patterns["Greek"].search(block)
            if greek_match:
                root = greek_match.group(1)
                transliteration = (
                    prop_patterns["Transliteration"].search(block).group(1)
                    if prop_patterns["Transliteration"].search(block)
                    else ""
                )
                gloss = (
                    prop_patterns["Gloss"].search(block).group(1)
                    if prop_patterns["Gloss"].search(block)
                    else ""
                )
                part_of_speech = (
                    prop_patterns["PartOfSpeech"].search(block).group(1)
                    if prop_patterns["PartOfSpeech"].search(block)
                    else "unknown"
                )

                existing = words.get(root)
                if existing is None:
                    words[root] = (transliteration, gloss, part_of_speech)
                else:
                    old_trans, old_gloss, old_pos = existing
                    words[root] = (
                        old_trans or transliteration,
                        old_gloss or gloss,
                        old_pos if old_pos and old_pos != "unknown" else part_of_speech,
                    )

            search_index = close_brace + 1

    return words


def load_occurrences(path: Path) -> dict[str, int]:
    if not path.exists():
        return {}
    data = json.loads(path.read_text(encoding="utf-8"))
    if not isinstance(data, dict):
        return {}
    parsed: dict[str, int] = {}
    for key, value in data.items():
        try:
            parsed[str(key)] = int(value)
        except (TypeError, ValueError):
            continue
    return parsed


def cs_escape(value: str) -> str:
    return value.replace("\\", "\\\\").replace('"', '\\"')


def indent_block(text: str, spaces: int) -> str:
    pad = " " * spaces
    return "\n".join(f"{pad}{line}" if line else line for line in text.splitlines())


def render_wrapper(
    namespace_name: str,
    class_name: str,
    merged_chapters: OrderedDict[int, str],
    chapter_segments: list[Segment],
    vocabulary_words: OrderedDict[str, tuple[str, str, str]],
    occurrences_by_root: dict[str, int],
) -> str:
    lines: list[str] = []
    lines.append("// AUTO-GENERATED by data/scripts/compile_book_wrappers.py")
    lines.append("using System.Collections.Generic;")
    lines.append("")
    lines.append(f"namespace {namespace_name}")
    lines.append("{")
    lines.append(f"    public static class {class_name}")
    lines.append("    {")
    lines.append("        public static Dictionary<int, List<object>> GetChapters()")
    lines.append("        {")
    lines.append("            return new Dictionary<int, List<object>>")
    lines.append("            {")
    for chapter in merged_chapters.keys():
        lines.append(f"                {{ {chapter}, GetChapter{chapter}() }},")
    lines.append("            };")
    lines.append("        }")
    lines.append("")

    grouped_segments: OrderedDict[int, list[Segment]] = OrderedDict()
    for seg in sorted(chapter_segments, key=lambda s: (s.chapter, s.verse_start, s.verse_end, s.path.name)):
        grouped_segments.setdefault(seg.chapter, []).append(seg)

    for chapter, body in merged_chapters.items():
        ranges = ", ".join(
            f"{seg.verse_start}-{seg.verse_end}" for seg in grouped_segments.get(chapter, [])
        )
        lines.append(f"        private static List<object> GetChapter{chapter}()")
        lines.append("        {")
        lines.append(f"            // Compiled ranges: {ranges}")
        lines.append("            return new List<object>")
        lines.append("            {")
        if body.strip():
            lines.append(indent_block(body, 16))
        lines.append("            };")
        lines.append("        }")
        lines.append("")

    lines.append(
        "        public static List<(string Root, string Transliteration, string Gloss, string PartOfSpeech, int Occurrences)> GetVocabulary()"
    )
    lines.append("        {")
    lines.append("            return new List<(string, string, string, string, int)>")
    lines.append("            {")
    for root, (translit, gloss, pos) in vocabulary_words.items():
        occurrences = occurrences_by_root.get(root, 1)
        lines.append(
            '                ("{0}", "{1}", "{2}", "{3}", {4}),'.format(
                cs_escape(root),
                cs_escape(translit),
                cs_escape(gloss),
                cs_escape(pos),
                occurrences,
            )
        )
    lines.append("            };")
    lines.append("        }")
    lines.append("    }")
    lines.append("}")

    return "\n".join(lines) + "\n"


def main() -> int:
    args = parse_args()
    input_dir = Path(args.input_dir)
    output_path = Path(args.output)
    book = args.book.replace(" ", "")
    class_name = args.class_name or f"{book}TextData"

    segments, source_warnings = collect_segments(input_dir, Path(args.fallback_log_dir), book)
    warnings = source_warnings + validate_segments(segments, strict_ranges=args.strict_ranges)
    merged = merge_segments_by_chapter(segments)
    words = extract_words_in_order(merged.values())
    occurrences = load_occurrences(Path(args.occurrences_json))

    content = render_wrapper(
        namespace_name=args.namespace_name,
        class_name=class_name,
        merged_chapters=merged,
        chapter_segments=segments,
        vocabulary_words=words,
        occurrences_by_root=occurrences,
    )

    print(f"Book: {book}")
    print(f"Chapters compiled: {len(merged)}")
    print(f"Segments merged: {len(segments)}")
    print(f"Vocabulary entries generated: {len(words)}")
    for warning in warnings:
        print(f"Warning: {warning}")

    if args.dry_run:
        return 0

    output_path.parent.mkdir(parents=True, exist_ok=True)
    output_path.write_text(content, encoding="utf-8")
    print(f"Wrote: {output_path}")
    return 0


if __name__ == "__main__":
    try:
        raise SystemExit(main())
    except ValueError as exc:
        print(f"Error: {exc}", file=sys.stderr)
        raise SystemExit(1)
