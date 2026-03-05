---
title: Project Structure
description: "Current file structure and organization conventions."
inclusion: always
---

# Project Structure

The repository is a monorepo with a Next.js frontend and a .NET monolith backend.

## High-Level Directories

- **`frontend/`**: Next.js application.
  - `src/app`: routes and layouts
  - `src/components`: UI and feature components
  - `src/lib`: API clients, services, stores, hooks
- **`backend/`**: .NET monolith.
  - `src/Koine.API`
  - `src/Koine.Application`
  - `src/Koine.Domain`
  - `src/Koine.Infrastructure`
  - `tests/Koine.Tests`
- **`data/`**: data processing and seed utilities
- **`docs/`**: roadmap, ADRs, specs, steering docs
- **`scripts/`**: project automation scripts
- **`legacy-reader-service/`**: legacy reference implementation

## Documentation Conventions
- Architecture and ADRs: `docs/`
- Feature specs: `docs/specs/`
- Sprint-level planning/closure artifacts: `docs/sprint-0/`
