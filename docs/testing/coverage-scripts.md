# Coverage Scripts

Use these from the repository root.

## Backend (full project coverage snapshot)

```bash
./scripts/coverage-backend.sh
```

Output:
- `backend/Koine.Tests/backend/Koine.Tests/TestResults/coverage-current.cobertura.xml`

## Backend (focused MVP parity services, 70% enforced)

```bash
./scripts/coverage-backend-focused.sh
```

Scope:
- `BookService`
- `ChapterService`
- `TranslationService`
- `UserService`
- `LessonService`

Output:
- `backend/Koine.Tests/backend/Koine.Tests/TestResults/coverage-services.cobertura.xml`

This command fails if line coverage is below 70% for the focused scope.

## Frontend (Vitest coverage)

```bash
./scripts/coverage-frontend.sh
```

This runs:
- `npm run test:coverage` in `GreekLearningApp-Frontend/`

## All coverage scripts

```bash
./scripts/coverage-all.sh
```

This runs focused backend coverage, full backend snapshot coverage, then frontend coverage.
