# ADR-001: Hexagonal Architecture

## Status
Accepted

## Context
The project is transitioning from a distributed microservices architecture (Azure Functions) to a consolidated monolith. We need an architectural pattern that promotes testability, maintainability, and clear separation of concerns to prevent the "Big Ball of Mud" anti-pattern.

## Decision
We will adopt **Hexagonal Architecture** (also known as Ports and Adapters) for the backend monolith. This architecture organizes the codebase into three main layers:

1.  **Domain Layer (`Koine.Domain`)**: Contains the core business logic, entities, and value objects. This layer has no dependencies on external frameworks or databases.
2.  **Application Layer (`Koine.Application`)**: Defines the use cases (services) and interfaces (ports) for data access and external services. It coordinates the domain objects to fulfill user requests.
3.  **Infrastructure Layer (`Koine.Infrastructure`)**: Implements the interfaces (adapters) defined in the application layer. This includes EF Core database contexts, repository implementations, and external API clients.
4.  **API Layer (`Koine.API`)**: The entry point for the application. It acts as an adapter for HTTP requests (REST/GraphQL) and handles routing, authentication, and request/response mapping.

## Consequences
- **Pros**:
    - High testability: Domain logic can be tested in isolation without mocking external dependencies.
    - Decoupling: Switching databases or external services only requires changes in the Infrastructure layer.
    - Maintainability: Business rules are centralized in the Domain layer.
- **Cons**:
    - Initial complexity: Requires more boilerplate (interfaces, DTOs, mappers) compared to a simple layered architecture.
    - Learning curve: Developers must understand the principles of Hexagonal Architecture to maintain consistency.

## Compliance
- All new features MUST be implemented following these layer boundaries.
- No direct references to `Koine.Infrastructure` from `Koine.Domain` or `Koine.Application`.
- Use Dependency Injection in `Koine.API` to bind implementations to their respective interfaces.
