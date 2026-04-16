# Requirements Document

## Introduction

This feature introduces a Command pattern architecture to the Koine backend. The goal is to replace the current broad-service pattern (e.g. `UserService`, `LessonService`) with focused, single-responsibility action classes. Each action handles exactly one operation, accepts a strongly-typed DTO, and returns a typed result (event or result DTO) — never a raw domain entity.

The pattern is built on a three-level inheritance hierarchy. `BaseAction` is the plain abstract root — no generics, no dependencies — providing a common type for registration and discovery. `BaseDomainAction` (e.g. `BaseUserAction`, `BaseLessonAction`) extends `BaseAction` and injects shared dependencies (`KoineDbContext`, `ICurrentUserContext`) via constructor, exposing them as `protected` fields. Concrete action classes inherit from the domain base and define their own `Execute` method with specific input/output types. There is no generic base class, no central processor, and no result wrapper type.

Cross-cutting concerns (logging, auth checks, permission enforcement) are handled inside each action's `Execute` method or via shared helpers. Controllers and GraphQL resolvers inject action classes directly and call `Execute` directly.

The migration is incremental: existing services and controllers remain functional while new domain areas adopt the pattern.

---

## Glossary

- **Action**: A single-operation command class that inherits from a `BaseDomainAction` and defines its own `Execute` method with specific input/output types.
- **BaseAction**: The plain abstract root class of the hierarchy. No generic type parameters, no injected dependencies. Provides a common type for registration, discovery, and any future shared behaviour.
- **BaseDomainAction**: A plain abstract class (e.g. `BaseUserAction`, `BaseLessonAction`) that extends `BaseAction` and injects `KoineDbContext` and `ICurrentUserContext` via constructor, exposing them as `protected` fields. No generics, no enforced `Execute` signature.
- **BaseDto**: An abstract base record that input DTOs may inherit from to share common validation helpers. Not enforced via generics.
- **CurrentUserContext**: The `ICurrentUserContext` interface (backed by `HttpContextCurrentUserProvider`) that provides the authenticated user's identity to actions.
- **DomainEvent**: A `record` type returned by mutating actions (e.g. `UserCreated`, `LessonCompleted`) that describes what happened.
- **KoineDbContext**: The EF Core database context injected into domain base actions.
- **IEventWriter**: An interface for persisting or publishing domain events, injected into actions that need it.
- **Resolver**: A GraphQL resolver in `RootQuery` or `RootMutation` that injects and calls action classes directly.

---

## Requirements

### Requirement 1: Base Action Classes

**User Story:** As a backend developer, I want a clear base class hierarchy, so that all actions share a common root type and domain-specific bases handle shared dependency injection.

#### Acceptance Criteria

1. THE `BaseAction` SHALL be a plain abstract class with no generic type parameters and no injected dependencies.
2. THE `BaseAction` SHALL serve as the common root type for all action classes, enabling registration, discovery, and any future shared behaviour.
3. THE `BaseDomainAction` SHALL extend `BaseAction`.
4. THE `BaseDomainAction` SHALL be a plain abstract class with no generic type parameters.
5. THE `BaseDomainAction` SHALL inject `KoineDbContext` and `ICurrentUserContext` via constructor and expose them as `protected readonly` fields.
6. THE `BaseDomainAction` SHALL NOT define or enforce any `Execute` method signature.
7. THE `BaseDomainAction` SHALL NOT contain business logic — only dependency injection and protected field exposure.
8. WHEN a new domain area is introduced, THE developer SHALL create a `Base{DomainName}Action` class in `Koine.Application/{DomainName}Actions/` that extends `BaseDomainAction` and injects the domain's shared dependencies.
9. WHERE a domain action requires additional shared infrastructure (e.g. `IEventWriter`), THE `BaseDomainAction` MAY inject it and expose it as a `protected readonly` field.

---

### Requirement 2: Concrete Action Classes

**User Story:** As a backend developer, I want a clear, consistent structure for action classes, so that every developer on the team can locate, read, and write actions predictably.

#### Acceptance Criteria

1. THE `Action` SHALL be a concrete class that inherits from the `BaseDomainAction` for its domain area.
2. THE `Action` SHALL define exactly one `Execute` method with input and output types specific to that operation (e.g. `Task<SomeEntityCreated> Execute(CreateSomeEntityDto dto)`).
3. THE `Action` SHALL NOT return raw domain entities — the return type SHALL be a result DTO or a `DomainEvent` record.
4. WHEN an action requires dependencies beyond those provided by `BaseDomainAction`, THE `Action` SHALL inject them via constructor parameters and call `base(db, userContext)`.
5. THE `Action` SHALL be placed in `Koine.Application/{DomainArea}Actions/` following the naming convention `{OperationName}{EntityName}.cs` (e.g. `CreateUser.cs`, `UpdateLesson.cs`).
6. THE input DTO for an action SHALL be placed in `Koine.Application/{DomainArea}Actions/Dtos/`.
7. THE `DomainEvent` returned by a mutating action SHALL be placed in `Koine.Application/{DomainArea}Actions/Events/` and SHALL be a `record` type.

---

### Requirement 3: DTO Conventions

**User Story:** As a backend developer, I want a consistent DTO structure, so that input shapes are predictable and validation helpers can be shared where useful.

#### Acceptance Criteria

1. THE input DTO for an action SHALL be a `record` type.
2. WHERE multiple DTOs in a domain area share common validation helpers, THE `BaseDto` MAY be an abstract base record that those DTOs inherit from.
3. THE `BaseDto` SHALL NOT be enforced via generics on the base action class — inheritance is optional and by convention only.
4. WHEN an action's `Execute` method receives a DTO, THE `Action` SHALL validate the DTO's fields before executing business logic and throw a `ValidationException` if validation fails.

---

### Requirement 4: Event Writing

**User Story:** As a backend developer, I want mutating actions to write domain events, so that downstream consumers can react to state changes without coupling to the action's internals.

#### Acceptance Criteria

1. THE `IEventWriter` interface SHALL expose a `Task WriteAsync<TEvent>(TEvent domainEvent)` method for persisting or publishing domain events.
2. WHEN a mutating action completes its core operation, THE `Action` SHALL call `IEventWriter.WriteAsync` with the appropriate `DomainEvent` before returning.
3. THE `Action` SHALL return the `DomainEvent` instance as its result, not the raw domain entity.
4. IF `IEventWriter.WriteAsync` throws an exception, THEN THE `Action` SHALL allow the exception to propagate to the caller.

---

### Requirement 5: Cross-Cutting Concerns

**User Story:** As a backend developer, I want a consistent approach to logging, authentication, and permission checks inside actions, so that these concerns are handled predictably without a central processor.

#### Acceptance Criteria

1. WHEN an action requires authentication, THE `Action.Execute` method SHALL verify that `ICurrentUserContext` returns a non-null, non-empty user identity and throw an `UnauthorizedException` if the check fails.
2. WHEN an action requires a permission check, THE `Action.Execute` method SHALL verify the current user holds the required permission and throw a `ForbiddenException` if the check fails.
3. THE `Action.Execute` method SHALL use `ILogger<T>` for any logging — never `Console.Write` or `Console.WriteLine`.
4. WHERE multiple actions in a domain share the same auth or permission check, THE `BaseDomainAction` MAY expose a `protected` helper method to perform the check.

---

### Requirement 6: Dependency Injection Registration

**User Story:** As a backend developer, I want action classes to be registered with the DI container, so that controllers and resolvers can inject them directly.

#### Acceptance Criteria

1. THE `ActionRegistrationExtensions` SHALL provide an `AddKoineActions(this IServiceCollection services)` extension method that registers all concrete action classes in `Koine.Application` as `Scoped`.
2. WHEN `AddKoineActions` is called in `Program.cs`, THE DI container SHALL resolve any registered action class by its concrete type.
3. THE `IEventWriter` implementation SHALL be registered as `Scoped` via `AddKoineActions` or a dedicated infrastructure registration method.
4. WHEN a new action class is added to `Koine.Application`, THE action SHALL be automatically discovered and registered without requiring a manual `Program.cs` change.

---

### Requirement 7: Controller Integration

**User Story:** As an API developer, I want controllers to inject and call action classes directly, so that controllers remain thin and free of business logic.

#### Acceptance Criteria

1. THE `Controller` SHALL inject action classes directly by concrete type via constructor.
2. THE `Controller` SHALL call `action.Execute(dto)` directly — there is no intermediate processor.
3. WHEN `Execute` throws an `UnauthorizedException`, THE `Controller` SHALL return HTTP 401.
4. WHEN `Execute` throws a `ForbiddenException`, THE `Controller` SHALL return HTTP 403.
5. WHEN `Execute` throws a `NotFoundException`, THE `Controller` SHALL return HTTP 404.
6. WHEN `Execute` throws a `ValidationException`, THE `Controller` SHALL return HTTP 400 with the validation errors in the response body.
7. WHEN `Execute` throws any other unhandled exception, THE `Controller` SHALL log the exception and return HTTP 500 with a generic error message.
8. WHEN `Execute` returns successfully, THE `Controller` SHALL return the appropriate 2xx HTTP response with the result as the body.

---

### Requirement 8: GraphQL Resolver Integration

**User Story:** As a GraphQL developer, I want resolvers to inject and call action classes directly, so that GraphQL mutations and queries share the same business logic path as REST controllers.

#### Acceptance Criteria

1. THE GraphQL `Resolver` SHALL inject action classes directly by concrete type and call `action.Execute(dto)` directly.
2. WHEN `Execute` throws an `UnauthorizedException`, THE `Resolver` SHALL throw an `ExecutionError` with code `"UNAUTHENTICATED"`.
3. WHEN `Execute` throws a `ForbiddenException`, THE `Resolver` SHALL throw an `ExecutionError` with code `"FORBIDDEN"`.
4. WHEN `Execute` throws a `NotFoundException`, THE `Resolver` SHALL throw an `ExecutionError` with code `"NOT_FOUND"`.
5. WHEN `Execute` throws a `ValidationException`, THE `Resolver` SHALL throw an `ExecutionError` with code `"VALIDATION_ERROR"` and include the validation messages.
6. WHEN `Execute` returns successfully, THE `Resolver` SHALL return the result value to the GraphQL response.

---

### Requirement 9: Migration Path for Existing Services

**User Story:** As a backend developer, I want a clear incremental migration path from the existing service pattern to the command pattern, so that the codebase can be migrated without a big-bang rewrite.

#### Acceptance Criteria

1. THE existing `IXxxService` interfaces and their implementations SHALL remain functional and unmodified during the migration period.
2. WHEN a domain area is migrated, THE developer SHALL create the `Base{Domain}Action` and individual action classes in `Koine.Application/{Domain}Actions/`, leaving the existing service in place until all callers are updated.
3. WHEN all callers of an existing service method have been migrated to the corresponding action, THE developer SHALL remove the service method and, when the service is empty, remove the service class and interface.
4. THE `AddKoineActions` registration SHALL coexist with the existing manual service registrations in `Program.cs` without conflict.
5. WHEN a controller action method is migrated, THE controller method SHALL be updated to inject and invoke the new action class while the remaining methods in the same controller continue to use the existing service.

---

### Requirement 10: Testability

**User Story:** As a backend developer, I want action classes to be easily unit-testable in isolation, so that I can verify business logic without spinning up the full application stack.

#### Acceptance Criteria

1. THE `Action` SHALL be instantiable in a unit test by constructing it directly with mocked dependencies (using Moq).
2. WHEN testing an action in isolation, THE test SHALL call `action.Execute(dto)` directly and assert on the returned value or thrown exception.
3. THE `Action` SHALL have no dependency on a central processor or pipeline — the full behaviour is exercised by calling `Execute` directly.
4. WHEN testing error paths, THE test SHALL assert that `Execute` throws the expected exception type (e.g. `ValidationException`, `UnauthorizedException`).
