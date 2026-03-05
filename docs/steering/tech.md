---
title: Technology Stack
description: "Current technology stack used in this repository."
inclusion: always
---

# Technology Stack

## Frontend
- **Framework:** Next.js (App Router)
- **Library:** React
- **Language:** TypeScript
- **UI:** Material UI
- **Testing:** Vitest

## Backend
- **Platform:** ASP.NET Core (.NET 10)
- **Architecture:** Hexagonal/Clean layering across Domain/Application/Infrastructure/API
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **Auth:** Clerk-issued token validation (hardening in progress)

## Infrastructure & Tooling
- **Containerization:** Docker / Docker Compose
- **Package Managers:** npm, NuGet
- **Version Control:** Git
- **Coverage:** coverlet + Vitest coverage

## Legacy/Reference Components
- `legacy-reader-service/` remains as historical reference only.
- Legacy Azure Function microservices are decommission targets and not the active runtime.
