# Application Discovery Report: Koine Greek Learning App

## Project Structure Overview
The application is a Next.js (v16+) project using React 19 and Material UI v7. It follows the App Router pattern with route groups for authentication and public access.

### Key Directories
- `src/app`: Contains the routing logic and page components.
  - `(auth)`: Authenticated routes like `/reader`, `/vocabulary`, `/study`, `/lessons`.
  - `(public)`: Publicly accessible routes like `/welcome`, `/onboarding`, `/about`.
  - `reader`: A catch-all route `[[...page]]` under `(auth)/reader` for the main reader interface.
- `src/components`: Reusable components.
  - `features`: Feature-specific components (e.g., `flashcards`, `reader`, `vocabulary`).
  - `layout`: Shell and theme configuration (`Theme.tsx`).
  - `shared`: Common components like `Skeletons` and `OnboardingIllustrations`.
- `src/lib`: API clients and utility functions.
- `src/styles`: Global styles and CSS modules.

## Page-by-Page Functionality Breakdown

### 1. Welcome Page (`/welcome`)
- **Purpose**: Landing page for users.
- **Functionality**: Introduction to the app, link to start reading or run onboarding.
- **UI Patterns**: 
  - Split screen layout (Grid).
  - Large illustrations (`WelcomeIllustration`).
  - Stacked buttons for actions.
  - Branding (Logo).

### 2. Reader Page (`/reader/[[...page]]`)
- **Purpose**: The core feature where users read Greek texts.
- **Functionality**: 
  - Displays Greek text with interlinear help.
  - Interactive text units with click/hover actions.
  - Navigation between books and chapters via dropdowns and FABs.
  - Audio playback for the text.
  - Sidebar for additional tools/settings.
- **UI Patterns**:
  - Fixed sidebar/navigation.
  - Scrollable text container.
  - Custom typography for Greek (`Noto Serif`).
  - `FormControl` with `Select` for navigation.
  - `Fab` for forward/backward navigation.

### 3. Onboarding (`/onboarding`)
- **Purpose**: Guide new users through initial setup and selection of current knowledge of Greek NT.
- **UI Patterns**:
  - Step-based navigation (inferred from `Onboarding.css`).
  - Large choice boxes with illustrations(`OnboardingOptionBox`).

### 4. Vocabulary/Study/Lessons (Inferred)
- **Purpose**: Manage vocabulary sets, perform study sessions, and track progress.
- **UI Patterns**: 
  - Likely cards for vocabulary sets.
  - Progress indicators for lessons.

## Current Component Inventory

### Layout Components
- `Theme.tsx`: Centralized MUI theme provider with light/dark mode support.
- `Nav.tsx`: Fixed navigation bar (bottom on mobile, side on desktop).
- `Sidebar.tsx`: Supplemental navigation and tools.

### Feature Components (Reader)
- `ReaderInterface.tsx`: Context provider for reader state.
- `ReaderPageUnit.tsx`: Renders individual Greek words/units with custom styling.
- `ReaderPageSelect.tsx`: Wrapper for MUI `Select` used in book/chapter selection.
- `ReaderPageAudioButton.tsx`: Controls for text-to-speech.

### Shared Components
- `Skeletons.tsx`: Loading states for various UI elements.
- `OnboardingIllustrations.tsx`: SVG illustrations for onboarding steps.

## Identified UI Patterns & Inconsistencies
- **Color Usage**: Hardcoded hex values in several components (e.g., `welcome/page.tsx`) instead of using theme tokens exclusively.
- **Responsive Design**: Extensive use of MUI's `sx` prop for responsive layouts (`xs`, `sm`).
- **Typography**: Specialized typography variants (`readerBody`, `readerHelp`) defined in the theme but sometimes overridden locally.
- **Icons**: Mix of MUI Icons and custom SVG illustrations.

## Required Components List (for Standardization)
- **Standardized Card**: For vocabulary sets and lessons.
- **Unified Navigation**: Consolidation of `Nav` and `Sidebar` into a consistent rail/drawer system.
- **Interactive Text Wrapper**: A more robust component for Greek text units that handles all interaction states.
- **Themed Feedback**: Standardized components for success/error/loading states.
- **Progress Tracking**: Visual indicators for learning progress (circular/linear progress).
