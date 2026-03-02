# ADR-003: Clerk Authentication

## Status
Accepted

## Context
We need a secure, scalable, and easy-to-manage authentication solution that supports social logins, session management, and user profiles without the overhead of building a custom identity system.

## Decision
We will use **Clerk** as our primary Identity Provider (IdP).
- **Frontend**: Integrate `@clerk/nextjs` for session management, login/signup UI, and protected routes.
- **Backend**: Validate Clerk-issued JWTs in `Koine.API` using the `Microsoft.AspNetCore.Authentication.JwtBearer` package.
- **User Syncing**: Use Clerk webhooks or on-demand synchronization to keep our local `User` entity in `Koine.Domain` updated with the Clerk `UserId`.

## Consequences
- **Pros**:
    - Out-of-the-box support for MFA, social logins, and account management.
    - Reduced security risk by offloading credential storage to a specialized provider.
    - Seamless integration with Next.js.
- **Cons**:
    - Dependency on a third-party service.
    - Monthly cost as user base scales.

## Compliance
- All protected backend endpoints MUST require a valid Clerk JWT.
- Frontend components should use Clerk's `useUser()` and `useAuth()` hooks for client-side authorization checks.
