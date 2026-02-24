#!/usr/bin/env python3
"""
GNT Seed Data Generation Orchestrator

This script orchestrates the complete workflow for generating C# seed data
from OpenGNT token data, including:
1. Parsing OpenGNT data into JSON
2. Generating C# code via AI (Gemini CLI)
3. Tracking progress via CSV tracker
4. Assembling final class files

Usage:
    python orchestrate_gnt_generation.py --tracker tracker.csv --config config.json
    python orchestrate_gnt_generation.py --book 62 --output-dir ./output
"""

import argparse
import csv
import json
import os
import re
import subprocess
import sys
from dataclasses import dataclass, asdict
from pathlib import Path
from typing import List, Optional, Dict
import tempfile
import shutil


@dataclass
class BatchTask:
    """Represents a single batch task from the tracker"""
    row_num: int
    book: str
    book_number: int
    chapter: int
    verses: int
    verse_range: str
    batch_number: str
    status: str
    date_done: str
    notes: str

    @property
    def is_pending(self) -> bool:
        return self.status.strip() in ["⬜ Pending", "Pending", ""]

    @property
    def is_complete(self) -> bool:
        return self.status.strip() in ["✅ Complete", "Complete", "Done"]

    def mark_complete(self, date: str = None, notes: str = ""):
        """Mark this task as complete"""
        if date is None:
            from datetime import datetime
            date = datetime.now().strftime("%Y-%m-%d")
        self.status = "✅ Complete"
        self.date_done = date
        if notes:
            self.notes = notes


class GNTOrchestrator:
    """Orchestrates the GNT seed data generation workflow"""

    def __init__(
        self,
        tracker_path: str,
        output_dir: str,
        parse_script: str = "parse_opengnt.py",
        prompt_script: str = "ai_seeding_prompt.py",
        dry_run: bool = False
    ):
        self.tracker_path = Path(tracker_path)
        self.output_dir = Path(output_dir)
        self.parse_script = Path(parse_script)
        self.prompt_script = Path(prompt_script)
        self.dry_run = dry_run

        # Create output directories
        self.json_dir = self.output_dir / "json"
        self.csharp_dir = self.output_dir / "csharp"
        self.logs_dir = self.output_dir / "logs"

        for d in [self.json_dir, self.csharp_dir, self.logs_dir]:
            d.mkdir(parents=True, exist_ok=True)

        self.tasks: List[BatchTask] = []

    def load_tracker(self) -> List[BatchTask]:
        """Load tasks from the CSV tracker file"""
        tasks = []
        
        with open(self.tracker_path, 'r', encoding='utf-8') as f:
            reader = csv.reader(f)
            
            # Skip header row
            next(reader, None)
            
            for idx, row in enumerate(reader, start=2):
                # Skip empty rows and section headers (like "📖 Matthew")
                if not row or len(row) < 10 or row[0].strip() == '' or '📖' in row[0]:
                    continue
                
                try:
                    task = BatchTask(
                        row_num=idx,
                        book=row[1].strip(),
                        book_number=int(row[2]) if row[2].strip() else 0,
                        chapter=int(row[3].replace('Chapter ', '').strip()) if row[3].strip() else 0,
                        verses=int(row[4]) if row[4].strip() else 0,
                        verse_range=row[5].strip(),
                        batch_number=row[6].strip(),
                        status=row[7].strip(),
                        date_done=row[8].strip() if len(row) > 8 else "",
                        notes=row[9].strip() if len(row) > 9 else ""
                    )
                    tasks.append(task)
                except (ValueError, IndexError) as e:
                    print(f"⚠️  Warning: Skipping malformed row {idx}: {e}")
                    continue
        
        self.tasks = tasks
        return tasks

    def save_tracker(self):
        """Save updated tracker back to CSV"""
        if self.dry_run:
            print("🔍 [DRY RUN] Would save tracker updates")
            return

        # Read all rows first
        with open(self.tracker_path, 'r', encoding='utf-8') as f:
            all_rows = list(csv.reader(f))

        # Update task rows
        for task in self.tasks:
            if task.row_num < len(all_rows):
                row = all_rows[task.row_num - 1]
                if len(row) >= 10:
                    row[7] = task.status
                    row[8] = task.date_done
                    row[9] = task.notes

        # Write back
        with open(self.tracker_path, 'w', encoding='utf-8', newline='') as f:
            writer = csv.writer(f)
            writer.writerows(all_rows)

    def parse_opengnt(self, task: BatchTask) -> Optional[Path]:
        """
        Run parse_opengnt.py to extract token data for a specific task
        Returns the path to the generated JSON file
        """
        # Parse verse range (e.g., "1-8", "25-25")
        start_verse, end_verse = map(int, task.verse_range.split('–'))
        
        output_file = self.json_dir / f"{task.book.lower().replace(' ', '')}_ch{task.chapter}_v{start_verse}-{end_verse}.json"
        
        cmd = [
            sys.executable,
            str(self.parse_script),
            "--book", str(task.book_number),
            "--chapter", str(task.chapter),
            "--start-verse", str(start_verse),
            "--end-verse", str(end_verse),
            "--out", str(output_file)
        ]

        print(f"📖 Parsing {task.book} {task.chapter}:{task.verse_range}")
        
        if self.dry_run:
            print(f"🔍 [DRY RUN] Would run: {' '.join(cmd)}")
            return output_file

        try:
            result = subprocess.run(
                cmd,
                capture_output=True,
                text=True,
                check=True
            )
            print(f"✅ Generated: {output_file}")
            return output_file
        except subprocess.CalledProcessError as e:
            print(f"❌ Error parsing OpenGNT data:")
            print(f"   STDOUT: {e.stdout}")
            print(f"   STDERR: {e.stderr}")
            return None
        except FileNotFoundError:
            print(f"❌ Error: {self.parse_script} not found")
            return None

    def load_prompt_template(self) -> str:
        """Load the AI prompt template from ai_seeding_prompt.py"""
        try:
            with open(self.prompt_script, 'r', encoding='utf-8') as f:
                content = f.read()
            
            # Extract USER_PROMPT variable
            # Look for USER_PROMPT = """ or USER_PROMPT = '''
            import re
            # Try triple-quoted strings first
            match = re.search(r'USER_PROMPT\s*=\s*"""(.*?)"""', content, re.DOTALL)
            if not match:
                match = re.search(r"USER_PROMPT\s*=\s*'''(.*?)'''", content, re.DOTALL)
            if not match:
                # Try single-line strings
                match = re.search(r'USER_PROMPT\s*=\s*["\']([^"\']*)["\']', content)
            
            if match:
                return match.group(1)
            
            # Fallback: if the whole file is the prompt
            return content
        except FileNotFoundError:
            print(f"⚠️  Warning: {self.prompt_script} not found, using default prompt")
            return self._default_prompt()

    def _default_prompt(self) -> str:
        """Fallback default prompt if ai_seeding_prompt.py is not found"""
        return """You are a Greek New Testament data engineer. Convert the provided OpenGNT token data into C# seed code matching the FirstJohnTextData.cs pattern.

Requirements:
1. Group words into nested Phrase objects with appropriate SyntaxCodes
2. Label constructions like TSKS, GEN_ABS, PERIPH, DAT_INSTR
3. Write Translation strings at both phrase and clause level
4. Preserve all Greek, transliteration, gloss, and grammar data
5. Add verse comments and construction summary

Generate a GetChapter{N}() method body for this data:

<token_data>
{token_data}
</token_data>"""

    def generate_csharp_with_ai(self, task: BatchTask, json_file: Path) -> Optional[Path]:
        """
        Use Gemini CLI to generate C# code from JSON token data
        """
        # Load JSON data
        with open(json_file, 'r', encoding='utf-8') as f:
            token_data = json.load(f)

        # Load prompt template
        prompt_template = self.load_prompt_template()
        
        # Format token data as expected by the prompt
        # The prompt expects the JSON to be inside <token_data></token_data> tags
        token_data_json = json.dumps(token_data, indent=2, ensure_ascii=False)
        
        # Check if prompt already has token_data placeholder
        if '<token_data>' in prompt_template and '</token_data>' in prompt_template:
            # Replace the placeholder section with actual data
            full_prompt = re.sub(
                r'<token_data>.*?</token_data>',
                f'<token_data>\n{token_data_json}\n</token_data>',
                prompt_template,
                flags=re.DOTALL
            )
        else:
            # Append token data at the end
            full_prompt = prompt_template + f"\n\n<token_data>\n{token_data_json}\n</token_data>"
        
        # Add specific instructions for this task
        chapter_instruction = f"\n\nGenerate the GetChapter{task.chapter}() method for {task.book}, verses {task.verse_range}."
        full_prompt += chapter_instruction

        output_file = self.csharp_dir / f"{task.book.replace(' ', '')}Chapter{task.chapter}_v{task.verse_range.replace('–', '-')}.cs"

        print(f"🤖 Generating C# code with gemini CLI tool for {task.book} {task.chapter}:{task.verse_range}")

        if self.dry_run:
            print(f"🔍 [DRY RUN] Would call gemini CLI tool")
            print(f"🔍 [DRY RUN] Prompt length: {len(full_prompt)} chars")
            print(f"🔍 [DRY RUN] Output: {output_file}")
            return output_file

        # Write prompt to temp file
        with tempfile.NamedTemporaryFile(mode='w', suffix='.txt', delete=False, encoding='utf-8') as tmp:
            tmp.write(full_prompt)
            prompt_file = tmp.name

        try:
            # Call Gemini CLI tool
            # The gemini CLI reads from stdin or file
            cmd = ["gemini", "chat"]
            
            # Read the prompt content
            with open(prompt_file, 'r', encoding='utf-8') as f:
                prompt_content = f.read()

            result = subprocess.run(
                cmd,
                input=prompt_content,
                capture_output=True,
                text=True,
                check=True,
                timeout=300,  # 5 minute timeout
                encoding='utf-8'
            )

            # Extract C# code from response
            csharp_code = self._extract_csharp_code(result.stdout)
            
            # Save to file
            with open(output_file, 'w', encoding='utf-8') as f:
                f.write(csharp_code)

            print(f"✅ Generated: {output_file}")
            
            # Save raw AI response to logs
            log_file = self.logs_dir / f"{output_file.stem}_response.txt"
            with open(log_file, 'w', encoding='utf-8') as f:
                f.write(result.stdout)

            return output_file

        except subprocess.TimeoutExpired:
            print(f"❌ Error: gemini CLI call timed out after 5 minutes")
            return None
        except subprocess.CalledProcessError as e:
            print(f"❌ Error calling gemini CLI tool:")
            print(f"   STDERR: {e.stderr}")
            return None
        except Exception as e:
            print(f"❌ Error generating C# code: {e}")
            return None
        finally:
            # Clean up temp file
            try:
                os.unlink(prompt_file)
            except:
                pass

    def _extract_csharp_code(self, ai_response: str) -> str:
        """Extract C# code from AI response (remove markdown formatting, etc.)"""
        # Look for code blocks
        import re
        
        # Try to find ```csharp ... ``` blocks
        csharp_blocks = re.findall(r'```(?:csharp|cs|c#)?\s*\n(.*?)\n```', ai_response, re.DOTALL | re.IGNORECASE)
        
        if csharp_blocks:
            return '\n\n'.join(csharp_blocks)
        
        # If no code blocks, return the whole response
        return ai_response

    def process_task(self, task: BatchTask) -> bool:
        """Process a single batch task end-to-end"""
        print(f"\n{'='*60}")
        print(f"Processing: {task.book} Ch.{task.chapter} v.{task.verse_range} ({task.batch_number})")
        print(f"{'='*60}")

        # Step 1: Parse OpenGNT
        json_file = self.parse_opengnt(task)
        if not json_file:
            return False

        # Step 2: Generate C# with AI
        csharp_file = self.generate_csharp_with_ai(task, json_file)
        if not csharp_file:
            return False

        # Step 3: Mark complete
        task.mark_complete(notes=f"Generated {csharp_file.name}")
        
        return True

    def process_all_pending(self) -> Dict[str, int]:
        """Process all pending tasks in the tracker"""
        pending_tasks = [t for t in self.tasks if t.is_pending]
        
        print(f"\n{'='*60}")
        print(f"Found {len(pending_tasks)} pending tasks")
        print(f"{'='*60}\n")

        if not pending_tasks:
            print("✨ No pending tasks found!")
            return {"total": 0, "success": 0, "failed": 0}

        stats = {"total": len(pending_tasks), "success": 0, "failed": 0}

        for task in pending_tasks:
            success = self.process_task(task)
            
            if success:
                stats["success"] += 1
            else:
                stats["failed"] += 1
                task.notes = "Failed - see logs"

            # Save progress after each task
            self.save_tracker()

        return stats

    def generate_class_wrapper(self, book: str) -> Optional[Path]:
        """
        Generate the full class wrapper that combines all chapter methods
        """
        # Find all C# files for this book
        book_pattern = book.replace(' ', '')
        csharp_files = sorted(self.csharp_dir.glob(f"{book_pattern}Chapter*.cs"))

        if not csharp_files:
            print(f"⚠️  No C# files found for {book}")
            return None

        print(f"\n📦 Generating class wrapper for {book}")
        print(f"   Found {len(csharp_files)} chapter files")

        # Read all chapter methods
        chapter_methods = []
        for f in csharp_files:
            with open(f, 'r', encoding='utf-8') as file:
                chapter_methods.append(file.read())

        # Create wrapper prompt
        wrapper_prompt = f"""Given these chapter methods for {book}, create a complete C# class wrapper with:

1. Class name: {book.replace(' ', '')}TextData
2. A GetChapters() method that returns List<Chapter>
3. Individual GetChapter1(), GetChapter2(), etc. methods
4. Match the FirstJohnTextData.cs reference style

Here are the chapter methods:

{'='*60}
""" + "\n\n".join(chapter_methods)

        output_file = self.csharp_dir / f"{book_pattern}TextData.cs"

        if self.dry_run:
            print(f"🔍 [DRY RUN] Would generate wrapper: {output_file}")
            return output_file

        # Write prompt to temp file
        with tempfile.NamedTemporaryFile(mode='w', suffix='.txt', delete=False, encoding='utf-8') as tmp:
            tmp.write(wrapper_prompt)
            prompt_file = tmp.name

        try:
            # Call Gemini CLI tool
            cmd = ["gemini", "chat"]
            
            # Read the prompt content
            with open(prompt_file, 'r', encoding='utf-8') as f:
                prompt_content = f.read()

            result = subprocess.run(
                cmd,
                input=prompt_content,
                capture_output=True,
                text=True,
                check=True,
                encoding='utf-8'
            )
            
            csharp_code = self._extract_csharp_code(result.stdout)
            
            with open(output_file, 'w', encoding='utf-8') as f:
                f.write(csharp_code)

            print(f"✅ Generated wrapper: {output_file}")
            return output_file

        except Exception as e:
            print(f"❌ Error generating wrapper: {e}")
            return None
        finally:
            try:
                os.unlink(prompt_file)
            except:
                pass

    def generate_all_wrappers(self):
        """Generate class wrappers for all books that have completed chapters"""
        # Group tasks by book
        books = {}
        for task in self.tasks:
            if task.is_complete:
                books.setdefault(task.book, []).append(task)

        print(f"\n📚 Generating wrappers for {len(books)} books")

        for book, tasks in books.items():
            self.generate_class_wrapper(book)


def main():
    parser = argparse.ArgumentParser(
        description="Orchestrate GNT seed data generation from OpenGNT to C#"
    )
    parser.add_argument(
        "--tracker",
        required=True,
        help="Path to the CSV tracker file"
    )
    parser.add_argument(
        "--output-dir",
        default="./output",
        help="Output directory for generated files (default: ./output)"
    )
    parser.add_argument(
        "--parse-script",
        default="parse_opengnt.py",
        help="Path to parse_opengnt.py script (default: parse_opengnt.py)"
    )
    parser.add_argument(
        "--prompt-script",
        default="ai_seeding_prompt.py",
        help="Path to ai_seeding_prompt.py script (default: ai_seeding_prompt.py)"
    )
    parser.add_argument(
        "--book",
        type=int,
        help="Process only this book number (e.g., 62 for 1 John)"
    )
    parser.add_argument(
        "--chapter",
        type=int,
        help="Process only this chapter (requires --book)"
    )
    parser.add_argument(
        "--generate-wrappers",
        action="store_true",
        help="Generate class wrappers for completed books"
    )
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Show what would be done without making changes"
    )

    args = parser.parse_args()

    # Initialize orchestrator
    orchestrator = GNTOrchestrator(
        tracker_path=args.tracker,
        output_dir=args.output_dir,
        parse_script=args.parse_script,
        prompt_script=args.prompt_script,
        dry_run=args.dry_run
    )

    # Load tracker
    print(f"📋 Loading tracker from: {args.tracker}")
    orchestrator.load_tracker()
    print(f"   Loaded {len(orchestrator.tasks)} tasks")

    # Filter tasks if book/chapter specified
    if args.book:
        orchestrator.tasks = [t for t in orchestrator.tasks if t.book_number == args.book]
        print(f"   Filtered to book #{args.book}: {len(orchestrator.tasks)} tasks")
    
    if args.chapter:
        if not args.book:
            print("❌ Error: --chapter requires --book")
            sys.exit(1)
        orchestrator.tasks = [t for t in orchestrator.tasks if t.chapter == args.chapter]
        print(f"   Filtered to chapter {args.chapter}: {len(orchestrator.tasks)} tasks")

    # Process tasks
    if args.generate_wrappers:
        orchestrator.generate_all_wrappers()
    else:
        stats = orchestrator.process_all_pending()
        
        print(f"\n{'='*60}")
        print(f"📊 SUMMARY")
        print(f"{'='*60}")
        print(f"Total tasks:    {stats['total']}")
        print(f"✅ Success:     {stats['success']}")
        print(f"❌ Failed:      {stats['failed']}")
        print(f"{'='*60}\n")

        if stats['success'] > 0:
            print(f"✨ Output directory: {orchestrator.output_dir}")
            print(f"   📁 JSON files:   {orchestrator.json_dir}")
            print(f"   📁 C# files:     {orchestrator.csharp_dir}")
            print(f"   📁 Logs:         {orchestrator.logs_dir}")


if __name__ == "__main__":
    main()