---
title: Product Vision
description: "Defines the project's core purpose, target users, and main features."
inclusion: always
---

# Koine: Ancient Greek Learning Platform

## Core Purpose
Koine is a comprehensive web application designed to help users master Koine Greek. Its primary goal is to enable users to read the New Testament in its original language by providing adaptive tools that bridge the gap between reliance on translations and independent reading.

## Target Audience
- **Beginners:** Individuals with no prior knowledge of Greek.
- **Theologians & Students:** Academic users deepening their understanding of the text.
- **Laypeople:** Bible readers wanting to access the original text.

## Key Features
- **Adaptive Interlinear Text:** The core feature. Text display adjusts to the user's proficiency, gradually removing English aids as the user learns.
- **Interactive Learning:** Flashcards, exercises, and potential video content to reinforce grammar and vocabulary.
- **Personalized Learning Path:** Progress tracking and content unlocking based on achievement.
- **Comprehensive Curriculum:** Grammar explanations and practice sets.

## Logic Preservation & Migration
**Adaptive Text Logic (`RenderChapter`):**
The "Adaptive Interlinear Text" feature relies on logic originally implemented in `legacy-reader-service/reader/handler.go` and now represented in the monolith reader pipeline. This logic MUST be preserved as reader behavior evolves.
- **Input:** User progress (completed lessons, known vocabulary) and text morphology.
- **Logic:** Checks if the user "recognizes" the word's root and grammatical form.
- **Output:**
    - **Recognized:** Displays original Greek text.
    - **Needs Help:** Displays Greek text with parsing/root helpers.
    - **Unrecognized:** Displays English translation.
