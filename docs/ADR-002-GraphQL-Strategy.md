# ADR-002: GraphQL Strategy

## Status
Proposed

## Context
The application needs a flexible way to query complex, nested Greek language data (e.g., words with morphology, translations, and syntactic features). While REST APIs are currently used, they often lead to over-fetching or multiple round-trips for complex UI views like the Reader or Vocabulary lists.

## Decision
We will implement **GraphQL** alongside our existing REST API to handle complex data fetching requirements.
- **Backend Framework**: [HotChocolate](https://chillicream.com/docs/hotchocolate) for .NET.
- **Frontend Client**: Apollo Client or URQL (to be decided).
- **Structure**:
    - **Queries**: Read-only operations for fetching text, morphology, and user progress.
    - **Mutations**: Write operations for user settings, lesson completions, and study sessions.
    - **DataLoaders**: Used to solve the N+1 query problem when fetching related entities like GrammaticalFeatures for multiple Words.

## Consequences
- **Pros**:
    - Improved performance for complex UI views.
    - Type safety across the stack when combined with code generation.
    - Frontend developers can request exactly the data they need.
- **Cons**:
    - Increased backend complexity (schema maintenance, DataLoaders).
    - Requires additional security considerations (query depth limiting, cost analysis).

## Compliance
- All new complex data-fetching features should prioritize GraphQL over REST.
- Existing REST endpoints will be maintained for simple resource-based access.
