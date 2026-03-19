# Koine — Product Overview

Koine is a full-stack Greek language learning platform. It focuses on three core learning modes:

- **Adaptive Reader** — read annotated Greek texts (NT books) with word-level grammatical and syntactical feature overlays
- **Vocabulary Study** — spaced-repetition flashcard sessions driven by vocabulary sets and user card progress
- **Lesson Progression** — structured lesson tracks with completion tracking and progress reporting

The target user is someone learning Koine (Biblical) Greek, from beginner to intermediate. The platform is designed to be used alongside a Greek NT text corpus seeded into the database.

Auth is handled via Clerk (with a dev fallback via `DevAuthController`). Users have profiles, settings, and per-word/per-card progress records.
