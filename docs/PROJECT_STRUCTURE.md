# Project Structure (Current vs. Goal)

## Current Structure (Monolith Migration)
The project is currently in the middle of a transition from multiple Azure Function-based services to a consolidated .NET monolith.

- `/backend`: The new monolith core.
    - `Koine.API`: Entry point (ASP.NET Core).
    - `Koine.Application`: Use cases and ports.
    - `Koine.Domain`: Business entities.
    - `Koine.Infrastructure`: EF Core and repository adapters.
- `/GreekLearningApp-Frontend`: The Next.js 16 frontend.
- `/GreekLearningApp-*Service`: Legacy Azure Function projects (to be decommissioned).
- `/data`: Python and shell scripts for processing Greek NT/OT data.
- `/docs`: Documentation and specifications.

## Goal Structure
Once the migration is complete, the legacy service folders will be removed, and all backend logic will reside within the `backend/` directory.

```text
/
├── backend/                # Unified .NET Monolith
│   ├── Koine.API/          # REST/GraphQL API
│   ├── Koine.Application/  # Business Logic
│   ├── Koine.Domain/       # Entities
│   └── Koine.Infrastructure/ # Database/External Clients
├── frontend/               # Next.js Application (renamed)
├── data/                   # Data processing & seed files
├── docs/                   # Documentation (ADRs, Specs)
└── scripts/                # CI/CD and utility scripts
```

## Migration Status
- [x] Create monolith project structure.
- [x] Migrate Domain entities to `Koine.Domain`.
- [x] Set up EF Core in `Koine.Infrastructure`.
- [ ] Migrate `GreekLearningApp-TextService` logic to `Koine.Application`.
- [ ] Migrate `GreekLearningApp-UserService` logic to `Koine.Application`.
- [ ] Migrate `GreekLearningApp-StudyService` logic to `Koine.Application`.
- [ ] Decommission legacy Function projects.
