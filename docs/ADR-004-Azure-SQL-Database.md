# ADR-004: Azure SQL Database

## Status
Accepted

## Context
The application requires a robust, relational database to store Greek NT/OT text data, user progress, and complex linguistic mappings. We need a cloud-native solution that offers high availability and easy scaling.

## Decision
We will use **Azure SQL Database** as our primary relational data store.
- **ORM**: Entity Framework Core (EF Core).
- **Hosting**: Azure SQL Database (Serverless or DTU-based depending on load).
- **Schema Management**: EF Core Migrations, tracked in `Koine.Infrastructure`.
- **Naming Convention**: PascalCase for table and column names to align with C# entity properties.

## Consequences
- **Pros**:
    - Familiar SQL environment with excellent tooling (SSMS, Azure Data Studio).
    - Native integration with Azure hosting environments (App Service, Functions).
    - Built-in backup, high availability, and security features.
- **Cons**:
    - Higher cost compared to some open-source alternatives like PostgreSQL on small instances.
    - Vendor lock-in to the Azure ecosystem.

## Compliance
- All database interactions MUST go through the `KoineDbContext`.
- No raw SQL unless absolutely necessary for performance-critical queries that EF Core cannot optimize.
- All schema changes MUST be applied via Migrations.
