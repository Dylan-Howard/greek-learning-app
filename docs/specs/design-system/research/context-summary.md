# Design System Context Summary for Web Agent

## Executive Summary
The Koine Greek Learning App is a modern Next.js 16/React 19 application using MUI v7. The goal is to design a unified design system that bridges the gap between Material Design 3 and GitHub Primer, ensuring a functional, accessible, and aesthetically pleasing interface for Greek text learners.

## Key Application Features Requiring Specialized Components
1. **Interactive Reader**:
   - Needs a sophisticated "Text Unit" component that handles Greek text (`Noto Serif`), interlinear help text, and hover/click interactions.
   - Requires a fluid, distraction-free reading mode.
2. **Navigation Rail/Sidebar**:
   - Consolidation of the existing `Nav` and `Sidebar` into a unified system that adapts across mobile and desktop.
3. **Vocabulary & Flashcards**:
   - Standardized card patterns for displaying Greek words, definitions, and progress.
   - Interactive study interface with emphasized motion (MD3).
4. **Onboarding & Progress**:
   - Step-based navigation with large, accessible choice boxes.
   - Clear, visual tracking of learning progress.

## Priority Component List
- **GreekTextUnit**: Optimized for readability and interaction.
- **AppShell**: Unified layout wrapper with integrated navigation.
- **KoineCard**: Versatile card for lessons, sets, and words.
- **ActionFAB**: Standardized floating action button for navigation and primary actions.
- **ProgressIndicator**: Custom circular/linear progress components.

## Design System Scope
- **Theming**: Full light/dark mode support using MUI v7 `colorSchemes` and CSS variables.
- **Colors**: Functional color tokens inspired by GitHub Primer (e.g., `fg`, `canvas`, `border`).
- **Typography**: Dual-font system (`Noto Sans` for UI, `Noto Serif` for Greek) with standardized scales.
- **Motion**: MD3 emphasized easing for primary transitions; standard easing for utility interactions.
- **Accessibility**: WCAG 2.2 AA compliance for contrast and keyboard operability.

## Technical Constraints
- **Platform**: Next.js App Router (v16).
- **Styling**: MUI v7 (`sx`, `styled`, `theme.vars`).
- **Authentication**: Integrated with Clerk (requires themed sign-in/profile components).
- **Responsive**: Mobile-first design is critical for safe-area-inset handling.
