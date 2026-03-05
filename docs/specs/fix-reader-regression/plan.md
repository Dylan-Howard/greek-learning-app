I have synthesized the analysis and the refined implementation plan into the following technical specification. This document outlines the architectural shift from the legacy Go service to the current .NET monolith, identifies critical regressions, and details the "In-Situ SRS" enhancement for the reader.

# Specification: Enhanced Reader Service & In-Situ SRS

## 1. Analysis: Current vs. Legacy Logic

### 1.1 Legacy Service (Go)
The legacy service (`legacy-reader-service/handler.go`) used a flat, binary recognition model:
*   **Logic:** `DoesRecognize(unit)` checked for the completion of all related lessons.
*   **Rendering:**
    *   **Recognized:** Original Greek.
    *   **Needs Help:** Greek + `[Abbrev; Root]` (Detailed morphological tags like `V-PAI-3S`).
    *   **Unrecognized:** Full English translation.
*   **Regression:** The legacy service possessed a robust `GetAbbreviation` engine that the current system lacks, resulting in a loss of pedagogical value for the student.

### 1.2 Current System (.NET Monolith)
The current service (`backend/src/Koine.Application/Services/ReaderService.cs`) uses a hierarchical `UnitNode` tree and a mastery-based approach:
*   **Logic:** Mastery is calculated as a level (0–100). The current threshold is hardcoded at 70%.
*   **Divergence:** It supports "Expanded" nodes, allowing phrases to be broken down into individual words or rendered as unified translated blocks.
*   **Regression:** `BuildParsingHints` is currently a placeholder returning strings like `"Feature{id}"` instead of linguistic data.

---

## 2. The "Amber" UX Strategy

To transform the reader into an active learning tool, the service will implement an **In-Situ Spaced Repetition (SRS)** loop.

### 2.1 Mastery Thresholds
The rendering engine will be updated to support three distinct states:
1.  **Red (Translated):** Mastery < 1%. The user cannot yet decode the unit.
2.  **Amber (Needs Practice):** Mastery ≥ 1% but < 70%. The unit renders in Greek with an Amber visual flag.
3.  **Green (Mastered):** Mastery ≥ 70%. Renders as standard Greek text.

### 2.2 The Review Loop
*   **Trigger:** Clicking an **Amber** unit opens the details sidebar (`Sidebar.tsx`).
*   **Interface:** A "Quick Review" panel is injected into the sidebar, featuring the four standard SRS buttons: **Again, Hard, Good, Easy**.
*   **Persistence:** Selecting a rating sends a payload to a new `UserProgress` endpoint, updating the `MasteryLevel` and `NextReviewDate` for the specific `VocabId` or `GramFeatureId`, identical to the `Study` service.

---

## 3. Unit Test Specification

We aim for **100% code coverage** of the `ReaderService` core logic to ensure stability across threshold boundaries and hierarchical rendering.

### 3.1 Scenario A: Knowledge Spectrum
*   **Boundary 0.9%:** Verify `type: "translated"` (Red).
*   **Boundary 1.0%:** Verify `type: "original_needs_practice"` (Amber).
*   **Boundary 70.0%:** Verify `type: "original"` (Green).

### 3.2 Scenario B: Hierarchy Integrity
*   **Mixed Mastery:** Test a `Phrase` node where the phrase-level translation is known but a child `Word` is "Amber." Verify the parent node defaults to `type: "expanded"` to ensure the Amber word is not obscured.

### 3.3 Scenario C: Resilience
*   **Guest Access:** Verify the system defaults to a "beginner" (mostly Red) state when `userId` is missing.
*   **Missing Data:** Ensure graceful failure when a `Translation` for a specific language is missing.

---

## 4. Implementation Plan

### Phase 1: Backend Refinement
1.  **Linguistic Engine:** Port `GetAbbreviation` logic from Go to a new `MorphologyFormatter` in `Koine.Application`.
2.  **Threshold Logic:** Update `ReaderService.RenderUnit` to implement the 1% and 70% mastery tiers.
3.  **SRS Integration:** Implement `POST /api/userprogress/review` in `UserProgressController` to handle in-situ ratings.

### Phase 2: Frontend Implementation
1.  **Amber Component:** Update `ReaderPageUnit.tsx` with conditional styling (`warning.main` for Amber units).
2.  **Quick Review UI:** Add the rating button group (referencing `RatingButtons.tsx`) to the `Sidebar.tsx`.
3.  **Context Synchronization:** Ensure that when a user rates a unit, the `ReaderContext` triggers a re-fetch or local state update to reflect the change in mastery color immediately.

### Phase 3: Validation
1.  **Test Suite:** Implement `ReaderServiceTests.cs` using `Moq` to simulate all mastery and hierarchy scenarios.
2.  **E2E Walkthrough:** Verify that clicking an Amber word, rating it "Easy," and reloading the page eventually turns the word Green (standard color).
