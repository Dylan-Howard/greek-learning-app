# Implementation Plan: Command Pattern Architecture

## Overview

Implement the command pattern base classes, exception types, and DI registration in `Koine.Application/Common/`, then build the `UserActions` reference domain, wire it into the existing `UsersController` and `RootMutation`, and cover everything with unit and property-based tests. Existing services remain untouched throughout.

## Tasks

- [x] 1. Create shared base classes in `Koine.Application/Common/`
  - [x] 1.1 Create `BaseAction` abstract class
    - Create `backend/src/Koine.Application/Common/BaseAction.cs`
    - Plain abstract class, no generic type parameters, no constructor parameters, no methods
    - XML doc comment on the class
    - _Requirements: 1.1, 1.2_

  - [x] 1.2 Create `BaseDomainAction` abstract class
    - Create `backend/src/Koine.Application/Common/BaseDomainAction.cs`
    - Extends `BaseAction`; injects `KoineDbContext` and `ICurrentUserContext` via constructor
    - Exposes both as `protected readonly` fields
    - Implements `protected void RequireAuthentication()` helper that throws `UnauthorizedException` when `ICurrentUserContext.GetUserId()` throws
    - No `Execute` signature, no business logic
    - XML doc comments on all public/protected members
    - Note: `ICurrentUserContext` is a new interface to define in `Koine.Application/Common/` that mirrors `ICurrentUserProvider` in `Koine.Application.Study.Ports` — expose `int GetUserId()`
    - _Requirements: 1.3, 1.4, 1.5, 1.6, 1.7, 5.4_

  - [x] 1.3 Create `ICurrentUserContext` interface
    - Create `backend/src/Koine.Application/Common/ICurrentUserContext.cs`
    - Single method: `int GetUserId()`
    - XML doc comment
    - _Requirements: 1.5_

  - [x] 1.4 Create `IEventWriter` interface
    - Create `backend/src/Koine.Application/Common/IEventWriter.cs`
    - Single method: `Task WriteAsync<TEvent>(TEvent domainEvent)`
    - XML doc comment
    - _Requirements: 4.1_

- [x] 2. Create exception types in `Koine.Application/Common/Exceptions/`
  - [x] 2.1 Create `ValidationException`
    - Create `backend/src/Koine.Application/Common/Exceptions/ValidationException.cs`
    - Two constructors: `(string field, string message)` and `(IReadOnlyDictionary<string, string[]> errors)`
    - Exposes `IReadOnlyDictionary<string, string[]> Errors` property
    - XML doc comments
    - _Requirements: 3.4_

  - [x] 2.2 Create `UnauthorizedException`, `ForbiddenException`, `NotFoundException`
    - Create `backend/src/Koine.Application/Common/Exceptions/UnauthorizedException.cs`
    - Create `backend/src/Koine.Application/Common/Exceptions/ForbiddenException.cs`
    - Create `backend/src/Koine.Application/Common/Exceptions/NotFoundException.cs`
    - `UnauthorizedException(string message)` and `ForbiddenException(string message)` use primary constructors
    - `NotFoundException(string resourceType, object id)` formats message as `"{resourceType} with id '{id}' was not found."`
    - XML doc comments on all
    - _Requirements: 5.1, 5.2, 7.3, 7.4, 7.5_

- [ ] 3. Create `ActionRegistrationExtensions` and register in `Program.cs`
  - [ ] 3.1 Create `ActionRegistrationExtensions`
    - Create `backend/src/Koine.Application/Common/ActionRegistrationExtensions.cs`
    - `public static IServiceCollection AddKoineActions(this IServiceCollection services)` extension method
    - Scans `typeof(BaseAction).Assembly` for concrete non-abstract `BaseAction` subclasses and registers each as `Scoped`
    - XML doc comment
    - _Requirements: 6.1, 6.4_

  - [ ] 3.2 Call `AddKoineActions()` in `Program.cs`
    - Add `builder.Services.AddKoineActions();` after the existing manual service registrations in `backend/src/Koine.API/Program.cs`
    - Add the required `using Koine.Application.Common;` directive
    - _Requirements: 6.2, 9.4_

  - [ ]* 3.3 Write property test for DI registration (Property 12)
    - Create `backend/tests/Koine.Tests/Unit/CommandPattern/ActionRegistrationTests.cs`
    - `// Feature: command-pattern-architecture, Property 12: DI registration discovers all concrete BaseAction subclasses`
    - `[Property(MaxTest = 100)]` — for each concrete `BaseAction` subclass in the assembly, calling `AddKoineActions` and building a `ServiceCollection` must allow that type to be resolved as a scoped service
    - **Property 12: DI registration discovers all concrete BaseAction subclasses**
    - **Validates: Requirements 6.1, 6.4**
    - _Requirements: 6.1, 6.4_

- [ ] 4. Implement `UserActions` reference domain
  - [ ] 4.1 Create `BaseUserAction`
    - Create `backend/src/Koine.Application/UserActions/BaseUserAction.cs`
    - Extends `BaseDomainAction`; passes `db` and `userContext` to base constructor
    - XML doc comment
    - _Requirements: 1.8_

  - [ ] 4.2 Create DTOs and domain events for `UserActions`
    - Create `backend/src/Koine.Application/UserActions/Dtos/CreateUserDto.cs` — `record CreateUserDto(string Email, string Username, string? DisplayName)`
    - Create `backend/src/Koine.Application/UserActions/Dtos/UpdateUserDto.cs` — `record UpdateUserDto(int UserId, string? Email, string? Username, string? DisplayName)`
    - Create `backend/src/Koine.Application/UserActions/Events/UserCreated.cs` — `record UserCreated(int UserId, string Email, string Username)`
    - Create `backend/src/Koine.Application/UserActions/Events/UserUpdated.cs` — `record UserUpdated(int UserId, string? Email, string? Username, string? DisplayName)`
    - XML doc comments on all
    - _Requirements: 2.6, 2.7, 3.1_

  - [ ] 4.3 Implement `CreateUser` action
    - Create `backend/src/Koine.Application/UserActions/CreateUser.cs`
    - Extends `BaseUserAction`; injects `IEventWriter` via constructor
    - `public async Task<UserCreated> Execute(CreateUserDto dto)`:
      1. Validate `dto.Email` and `dto.Username` are non-empty — throw `ValidationException` if not
      2. Create and add `User` entity to `Db.Users`
      3. `await Db.SaveChangesAsync()`
      4. Build and write `UserCreated` event via `_eventWriter.WriteAsync`
      5. Return the event
    - XML doc comments
    - _Requirements: 2.1, 2.2, 2.3, 2.4, 3.4, 4.2, 4.3_

  - [ ]* 4.4 Write unit tests for `CreateUser`
    - Create `backend/tests/Koine.Tests/Unit/CommandPattern/CreateUserTests.cs`
    - Test: valid DTO → correct `UserCreated` event returned, `WriteAsync` called once
    - Test: empty `Email` → `ValidationException` thrown, `WriteAsync` not called
    - Test: empty `Username` → `ValidationException` thrown, `WriteAsync` not called
    - Test: `IEventWriter.WriteAsync` throws → exception propagates from `Execute`
    - Use `Moq` for `ICurrentUserContext` and `IEventWriter`; use EF Core in-memory provider for `KoineDbContext`
    - _Requirements: 2.2, 3.4, 4.2, 4.4, 10.1, 10.2, 10.4_

  - [ ] 4.5 Implement `UpdateUser` action
    - Create `backend/src/Koine.Application/UserActions/UpdateUser.cs`
    - Extends `BaseUserAction`; injects `IEventWriter`
    - `public async Task<UserUpdated> Execute(UpdateUserDto dto)`:
      1. Call `RequireAuthentication()`
      2. Load user by `dto.UserId` — throw `NotFoundException("User", dto.UserId)` if not found
      3. Apply non-null field updates
      4. `await Db.SaveChangesAsync()`
      5. Write and return `UserUpdated` event
    - XML doc comments
    - _Requirements: 2.1, 2.2, 2.3, 5.1, 4.2, 4.3_

  - [ ]* 4.6 Write unit tests for `UpdateUser`
    - Create `backend/tests/Koine.Tests/Unit/CommandPattern/UpdateUserTests.cs`
    - Test: valid DTO with existing user → `UserUpdated` returned, `WriteAsync` called once
    - Test: user not found → `NotFoundException` thrown
    - Test: unauthenticated (`GetUserId()` throws) → `UnauthorizedException` thrown
    - _Requirements: 5.1, 4.2, 4.4, 10.1, 10.4_

- [ ] 5. Checkpoint — ensure all tests pass
  - Run `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1`
  - Ensure all tests pass; ask the user if questions arise.

- [ ] 6. Write property-based tests for structural invariants
  - [ ] 6.1 Write property test for all concrete actions subclass BaseAction (Property 1)
    - Create `backend/tests/Koine.Tests/Unit/CommandPattern/ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 1: All concrete actions subclass BaseAction`
    - Reflect over `typeof(BaseAction).Assembly`; assert every concrete class in a `*Actions` namespace is a `BaseAction` subclass
    - **Property 1: All concrete actions subclass BaseAction**
    - **Validates: Requirements 1.2, 2.1**
    - _Requirements: 1.2, 2.1_

  - [ ] 6.2 Write property test for BaseAction has no constructor parameters and no generics (Property 2)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 2: BaseAction has no constructor parameters and no generic type parameters`
    - Assert `typeof(BaseAction)` has no generic type parameters and its only constructor is parameterless
    - **Property 2: BaseAction has no constructor parameters and no generic type parameters**
    - **Validates: Requirements 1.1, 1.4**
    - _Requirements: 1.1, 1.4_

  - [ ] 6.3 Write property test for every concrete action has exactly one Execute method (Property 3)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 3: Every concrete action has exactly one public Execute method`
    - For each concrete `BaseAction` subclass, count public instance methods named `Execute` — must equal 1
    - **Property 3: Every concrete action has exactly one public Execute method**
    - **Validates: Requirements 2.2**
    - _Requirements: 2.2_

  - [ ] 6.4 Write property test for Execute return types are never raw domain entities (Property 4)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 4: Execute return types are never raw domain entities`
    - Unwrap `Task<T>` from each `Execute` return type; assert the unwrapped type is not in `Koine.Domain.Entities`
    - **Property 4: Execute return types are never raw domain entities**
    - **Validates: Requirements 2.3, 4.3**
    - _Requirements: 2.3, 4.3_

  - [ ] 6.5 Write property test for mutating action return types are record types (Property 5)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 5: Execute return types for mutating actions are record types`
    - For concrete actions whose name starts with `Create`, `Update`, or `Delete`, assert the unwrapped `Execute` return type is a `record`
    - **Property 5: Execute return types for mutating actions are record types**
    - **Validates: Requirements 2.7, 4.3**
    - _Requirements: 2.7, 4.3_

  - [ ] 6.6 Write property test for input DTO types are record types (Property 6)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 6: Input DTO types are record types`
    - For each concrete `BaseAction` subclass, assert the first parameter type of `Execute` is a `record`
    - **Property 6: Input DTO types are record types**
    - **Validates: Requirements 3.1**
    - _Requirements: 3.1_

  - [ ] 6.7 Write property test for actions are directly constructable with mocked dependencies (Property 15)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 15: Actions are directly constructable with mocked dependencies`
    - For each concrete `BaseAction` subclass, use `Moq` to create mocks for each constructor parameter type and assert instantiation succeeds without a DI container
    - **Property 15: Actions are directly constructable with mocked dependencies**
    - **Validates: Requirements 10.1**
    - _Requirements: 10.1_

  - [ ]* 6.8 Write property test for invalid DTOs cause ValidationException (Property 7)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 7: Invalid DTOs cause ValidationException`
    - For `CreateUser`: generate DTOs with null/whitespace `Email` or `Username` via FsCheck generators; assert `Execute` throws `ValidationException` and `IEventWriter.WriteAsync` is never called
    - **Property 7: Invalid DTOs cause ValidationException**
    - **Validates: Requirements 3.4**
    - _Requirements: 3.4_

  - [ ]* 6.9 Write property test for mutating actions call IEventWriter exactly once (Property 8)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 8: Mutating actions call IEventWriter exactly once`
    - For `CreateUser` with valid generated DTOs, assert `WriteAsync` is called exactly once per `Execute` invocation
    - **Property 8: Mutating actions call IEventWriter exactly once**
    - **Validates: Requirements 4.2**
    - _Requirements: 4.2_

  - [ ]* 6.10 Write property test for IEventWriter exceptions propagate (Property 9)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 9: IEventWriter exceptions propagate from Execute`
    - Configure mock `IEventWriter.WriteAsync` to throw; assert the same exception propagates out of `Execute`
    - **Property 9: IEventWriter exceptions propagate from Execute**
    - **Validates: Requirements 4.4**
    - _Requirements: 4.4_

  - [ ]* 6.11 Write property test for unauthenticated Execute throws UnauthorizedException (Property 10)
    - Add to `ActionHierarchyPropertyTests.cs`
    - `// Feature: command-pattern-architecture, Property 10: Unauthenticated Execute throws UnauthorizedException`
    - Configure mock `ICurrentUserContext.GetUserId()` to throw; assert `Execute` on `UpdateUser` throws `UnauthorizedException`
    - **Property 10: Unauthenticated Execute throws UnauthorizedException**
    - **Validates: Requirements 5.1**
    - _Requirements: 5.1_

- [ ] 7. Wire `ICurrentUserContext` to the existing `HttpContextCurrentUserProvider`
  - [ ] 7.1 Implement `ICurrentUserContext` on `HttpContextCurrentUserProvider`
    - Open `backend/src/Koine.API/Providers/HttpContextCurrentUserProvider.cs`
    - Add `ICurrentUserContext` to the class's implemented interfaces
    - The existing `GetUserId()` implementation already satisfies the contract — no logic change needed
    - Add `using Koine.Application.Common;` directive
    - _Requirements: 1.5_

  - [ ] 7.2 Register `ICurrentUserContext` in `Program.cs`
    - In `backend/src/Koine.API/Program.cs`, add:
      `builder.Services.AddScoped<ICurrentUserContext, HttpContextCurrentUserProvider>();`
    - Place it alongside the existing `ICurrentUserProvider` registration
    - _Requirements: 6.2_

- [ ] 8. Integrate `CreateUser` and `UpdateUser` into `UsersController`
  - [ ] 8.1 Update `UsersController` to inject and call `CreateUser`
    - Open the existing `UsersController` in `backend/src/Koine.API/Controllers/`
    - Add `CreateUser _createUser` constructor parameter alongside existing service parameters
    - Migrate the `POST /api/users` endpoint to call `_createUser.Execute(dto)` instead of the existing service method
    - Wrap in try/catch mapping: `ValidationException` → 400, `UnauthorizedException` → 401, `ForbiddenException` → 403, `NotFoundException` → 404, other → 500 with `ILogger<T>` log
    - Return `CreatedAtAction` with the `UserCreated` event as body on success
    - Leave all other controller methods unchanged
    - _Requirements: 7.1, 7.2, 7.3, 7.4, 7.5, 7.6, 7.7, 7.8, 9.5_

  - [ ] 8.2 Update `UsersController` to inject and call `UpdateUser`
    - Add `UpdateUser _updateUser` constructor parameter
    - Migrate the `PUT /api/users/{id}` endpoint to call `_updateUser.Execute(dto)`
    - Apply the same try/catch exception mapping as 8.1
    - Leave all other controller methods unchanged
    - _Requirements: 7.1, 7.2, 7.3, 7.4, 7.5, 7.6, 7.7, 7.8, 9.5_

  - [ ]* 8.3 Write unit tests for controller exception mapping (Property 13)
    - Create `backend/tests/Koine.Tests/Unit/CommandPattern/UsersControllerActionTests.cs`
    - `// Feature: command-pattern-architecture, Property 13: Controller maps every known exception type to the correct HTTP status`
    - Test each exception type → expected HTTP status code using a mocked `CreateUser` action
    - **Property 13: Controller maps every known exception type to the correct HTTP status**
    - **Validates: Requirements 7.3, 7.4, 7.5, 7.6, 7.7**
    - _Requirements: 7.3, 7.4, 7.5, 7.6, 7.7_

- [ ] 9. Integrate `CreateUser` into `RootMutation`
  - [ ] 9.1 Add `createUser` mutation field to `RootMutation`
    - Open `backend/src/Koine.API/GraphQL/Mutations/RootMutation.cs`
    - Add `CreateUser createUser` constructor parameter
    - Add a `createUser` mutation field that calls `createUser.Execute(input)` and maps exceptions to `ExecutionError` with codes: `ValidationException` → `"VALIDATION_ERROR"`, `UnauthorizedException` → `"UNAUTHENTICATED"`, `ForbiddenException` → `"FORBIDDEN"`, `NotFoundException` → `"NOT_FOUND"`
    - Add the corresponding `UserCreatedType` GraphQL output type in `Koine.API/GraphQL/Types/`
    - Add `CreateUserInputType` in `Koine.API/GraphQL/Types/InputTypes/`
    - _Requirements: 8.1, 8.2, 8.3, 8.4, 8.5, 8.6_

  - [ ]* 9.2 Write unit tests for GraphQL resolver exception mapping (Property 14)
    - Create `backend/tests/Koine.Tests/Unit/CommandPattern/RootMutationUserActionTests.cs`
    - `// Feature: command-pattern-architecture, Property 14: GraphQL resolver maps every known exception type to the correct error code`
    - Test each exception type → expected `ExecutionError.Code` using a mocked `CreateUser` action
    - **Property 14: GraphQL resolver maps every known exception type to the correct error code**
    - **Validates: Requirements 8.2, 8.3, 8.4, 8.5**
    - _Requirements: 8.2, 8.3, 8.4, 8.5_

- [ ] 10. Final checkpoint — ensure all tests pass
  - Run `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1`
  - Ensure all tests pass; ask the user if questions arise.

## Notes

- Tasks marked with `*` are optional and can be skipped for a faster MVP
- Run tests with: `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1` (single-threaded, required by project convention)
- Property tests use FsCheck 3 + FsCheck.NUnit (`[Property(MaxTest = 100)]`); tag format: `// Feature: command-pattern-architecture, Property {N}: {text}`
- Existing services (`IUserService`, etc.) and their registrations in `Program.cs` are not modified
- `ICurrentUserContext` is a new interface in `Koine.Application/Common/` — `HttpContextCurrentUserProvider` implements it alongside the existing `ICurrentUserProvider`
- EF Core in-memory provider is suitable for unit tests; integration tests are out of scope for this spec
