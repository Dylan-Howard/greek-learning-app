# Requirements Document

## Introduction
This document outlines the requirements for completing the Unified Backend for the Koine learning platform. The previous attempt at a C# unified backend was found to be incomplete and not aligned with the project's target architecture. This specification details the features required to create a functional backend using the approved technology stack (Supabase and TypeScript), providing feature parity with the legacy microservices and enabling the core product vision.

## Requirements

### Requirement 1: User Management
**Objective:** As a platform administrator, I want a complete user management system, so that users can register, manage their profiles, and track their settings.

#### Acceptance Criteria
1.  WHEN a new user signs up THEN the Unified Backend SHALL create a new user record in the database.
2.  WHEN a user requests their profile data THEN the Unified Backend SHALL return the user's profile information.
3.  WHEN a user updates their profile THEN the Unified Backend SHALL update the corresponding user record.
4.  IF a user requests their settings THEN the Unified Backend SHALL return their stored settings.
5.  IF a user updates their settings THEN the UnifiedBackend SHALL persist the new settings.

### Requirement 2: Learning Content Service
**Objective:** As a content administrator, I want a robust system for managing learning content, so that lessons, vocabulary, and texts can be stored and served to the frontend.

#### Acceptance Criteria
1.  WHEN the frontend requests a list of all lessons THEN the Unified Backend SHALL return a list of all available lessons.
2.  WHEN the frontend requests a specific lesson THEN the Unified Backend SHALL return the detailed content for that lesson.
3.  IF the backend receives a request to create or update a lesson THEN the Unified Backend SHALL persist the lesson data to the database.
4.  WHEN the frontend requests vocabulary data THEN the Unified Backend SHALL return the requested vocabulary information.
5.  IF the backend receives a request to create or update a vocabulary word THEN the Unified Backend SHALL persist the word data to the database.
6.  WHEN the frontend requests a specific text (e.g., a book or chapter) THEN the Unified Backend SHALL return the content of that text.

### Requirement 3: Personalized Text Rendering
**Objective:** As a user, I want the reading text to adapt to my skill level, so that I can learn effectively and transition from guided reading to independent reading.

#### Acceptance Criteria
1.  WHEN a user requests a chapter of a text THEN the Unified Backend SHALL retrieve the user's progress, including completed lessons and known vocabulary.
2.  WHEN processing a word in the text that the user has fully mastered (both vocabulary and all grammatical forms are known) THEN the Unified Backend SHALL render the word in the original Greek.
3.  WHEN processing a word in the text where the user knows the vocabulary but has not mastered all grammatical forms THEN the Unified Backend SHALL render the word in Greek and provide grammatical help text.
4.  WHEN processing a word in the text whose vocabulary the user has not yet learned THEN the Unified Backend SHALL render the word's English translation.
5.  WHERE the user is not logged in (is a guest) THE Unified Backend SHALL render all words in the original Greek without any help text or translations.

### Requirement 4: Vocabulary Study Service
**Objective:** As a user, I want to be able to create and study vocabulary sets, so that I can focus my learning on specific words.

#### Acceptance Criteria
1.  WHEN a user requests their vocabulary sets THEN the Unified Backend SHALL return a list of all sets created by that user.
2.  WHEN a user requests the contents of a specific vocabulary set THEN the Unified Backend SHALL return all the words included in that set.
3.  IF a user creates a new vocabulary set THEN the Unified Backend SHALL create and store a new set linked to that user.

### Requirement 5: User Progress Tracking
**Objective:** As a user, I want my learning progress to be saved automatically, so that the platform always knows what I have learned.

#### Acceptance Criteria
1.  WHEN a user completes a lesson THEN the Unified Backend SHALL record the lesson as complete for that user.
2.  WHEN a user marks a vocabulary word as learned THEN the Unified Backend SHALL update the user's vocabulary progress.
3.  WHILE a user is interacting with learning materials THE Unified Backend SHALL provide endpoints to save their ongoing progress across all learnable items (lessons, vocabulary, grammatical features, etc.).