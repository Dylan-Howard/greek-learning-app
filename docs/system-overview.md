# System Overview: Greek Learning App (Koine)

## Architecture Overview
Koine is a full-stack monolith deployment model: Next.js frontend plus a layered .NET backend.

```mermaid
graph TD
    subgraph Frontend [frontend]
        UI[Next.js / React]
        Client[REST Client]
    end

    subgraph Auth [Identity Provider]
        Clerk[Clerk]
    end

    subgraph Backend [Koine Monolith]
        API[Koine.API Controllers]
        App[Koine.Application Services]
        Domain[Koine.Domain]
        Infra[Koine.Infrastructure]
    end

    subgraph Storage [Persistence]
        DB[(SQL Server)]
    end

    UI --> Client
    Client --> API
    API --> App
    App --> Domain
    App --> Infra
    Infra --> DB
    UI -- Auth Token --> Clerk
    API -- Token Validation --> Clerk
```

## Core Components

### 1. Frontend
- Next.js app in `frontend/`
- Reader, study, vocabulary, lessons routes
- Shared API utilities under `src/lib`

### 2. Backend
- .NET 10 solution in `backend/`
- `Koine.API`: HTTP API and middleware
- `Koine.Application`: use-case/services orchestration
- `Koine.Domain`: entities/value objects
- `Koine.Infrastructure`: EF Core data access and external adapters

### 3. Data Layer
- SQL Server for text, progress, study sessions, and lessons
- Seed pipeline driven by backend seeding + `data/` scripts

## Key Data Flows

### Reading a Text
1. Frontend requests chapter/reader data.
2. API delegates to application reader services.
3. Infrastructure queries SQL and returns DTOs.
4. Frontend renders adaptive content.

### Study Session
1. Frontend requests due items/session state.
2. API updates progress through study services.
3. Scheduler state persists in SQL via infrastructure repositories.
