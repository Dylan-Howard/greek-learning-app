# Gemini Agent Guidelines

## Project Context
- See `README.md` for project overview
- See `docs/steering/` or `.kiro/steering/` for project-specific guidelines
- User preferences: `~/.gemini/my-preferences.md`
- Default to *plan mode*

---

## Git Workflow
- Always work on a feature branch; never commit directly to `main` or `master`
- Commit frequently with descriptive messages (imperative mood: "Add", "Fix", "Refactor")
- Never commit `.env`, secrets, or credential files — no exceptions
- Stage and commit automatically when a task is complete

---

## Code Quality (Non-Negotiable)
- Run linter and type-checker after every file edit — fix all errors before marking a task done
- No dead code, commented-out blocks, or debug statements in commits
- Prefer explicit over clever; optimize for readability first
- Use `TODO` and `FIXME` comments to indicate future work

---

## Testing
Defaults unless the project specifies otherwise:

| Scope | Type | Target |
|---|---|---|
| Business logic / units | Unit tests | ≥ 70% coverage |
| API endpoints | Smoke / integration tests | 100% route coverage |
| Complex features | TDD encouraged | — |

- Run the full existing test suite before completing any task
- New features require new tests; do not ship untested code

---

## Documentation
- Update `README.md` when adding features or changing setup steps
- Add inline comments for non-obvious logic; avoid restating what the code already says
- Generate or update API docs (OpenAPI / godoc / XML doc comments) for new endpoints

---

## Language Conventions

### TypeScript
- `strict` mode enabled; `any` is banned — use `unknown` + type guards if needed
- Named exports only; no default exports
- Prefer `interface` for object shapes, `type` for unions/aliases
- Use `async/await`; avoid raw `.then()` chains

### Go
- Follow `gofmt` / `goimports` formatting — run before every commit
- Handle all errors explicitly; never use `_` to discard errors silently
- Prefer table-driven tests (`testing` package); use `testify` only if the project already imports it
- Keep packages small and focused; avoid circular imports

### C# / .NET
- Target the latest active LTS SDK unless the project pins a version
- Use file-scoped namespaces and primary constructors where available
- Prefer `record` types for immutable data; avoid mutable `struct`
- Use `ILogger<T>` for all logging — no `Console.Write` in production paths
- XML doc comments on all `public` members