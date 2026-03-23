# Requirements Document

## Introduction

This feature completes the end-to-end Clerk.js authentication integration for the Koine Greek learning platform. Auth is currently partially wired: `@clerk/nextjs` is installed on the frontend and the Apollo GraphQL client already injects Clerk JWTs, but the login/signup pages are stubs, the REST `apiClient` never attaches tokens, `ClientProviders` still drives user identity from a dev-only numeric ID stored in `localStorage`, and the backend validates only its own locally-issued JWTs rather than Clerk-issued tokens.

The goal is to replace all of that with a coherent, production-ready auth flow while retaining the existing onboarding level-setting screen and providing a professional local-development testing story using Clerk's own test accounts feature (no hacky mocks).

## Glossary

- **Clerk**: Third-party authentication provider (`@clerk/nextjs`). Issues signed JWTs (session tokens) that the frontend obtains via `useAuth().getToken()`.
- **ClerkProvider**: The `@clerk/nextjs` root provider that must wrap the entire Next.js app.
- **Frontend**: The Next.js 16 App Router application in `frontend/`.
- **Backend**: The ASP.NET Core 10 Web API in `backend/src/Koine.API/`.
- **JWT_Validator**: The ASP.NET Core JWT Bearer middleware configured in `Program.cs`.
- **ClerkJwtValidator**: A new configuration of the JWT Bearer middleware that validates Clerk-issued tokens using Clerk's JWKS endpoint.
- **AuthMiddleware**: Next.js middleware (`middleware.ts`) that enforces route-level authentication using `clerkMiddleware`.
- **REST_Client**: The `apiClient` in `frontend/src/lib/api/rest/client.ts`.
- **Apollo_Client**: The Apollo GraphQL client in `frontend/src/lib/api/graphql/client.ts`.
- **ClientProviders**: The `ClientProviders` React component in `frontend/src/components/layout/ClientProviders.tsx`.
- **UserContext**: The React context that holds the active user's profile and exp state.
- **Onboarding_Flow**: The level-setting screen at `/onboarding` where new users select their prior Greek knowledge rank.
- **DevAuthController**: The `#if DEBUG`-guarded controller at `api/dev/token` used for local development token generation.
- **ClerkTestAccount**: A Clerk-managed test user created in the Clerk dashboard with a fixed, deterministic password, used for local development without mocking.
- **HttpContextCurrentUserProvider**: The `ICurrentUserProvider` implementation that resolves the current user's numeric DB ID from JWT claims.

---

## Requirements

### Requirement 1: ClerkProvider Wired into the Next.js App

**User Story:** As a developer, I want ClerkProvider to wrap the entire Next.js application, so that all Clerk hooks (`useAuth`, `useUser`, `currentUser`) are available in every route and component.

#### Acceptance Criteria

1. THE Frontend SHALL render `ClerkProvider` as an ancestor of all page content in the root layout (`app/layout.tsx`).
2. WHEN `NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY` is absent at build time, THE Frontend SHALL throw a build-time error rather than silently producing a broken app.
3. THE ClerkProvider SHALL be configured with `signInUrl`, `signUpUrl`, `afterSignInUrl`, and `afterSignUpUrl` values sourced exclusively from environment variables.
4. WHERE the app is rendered server-side, THE Frontend SHALL use `@clerk/nextjs/server` helpers (`auth()`, `currentUser()`) rather than client-side hooks.

---

### Requirement 2: Route Protection via Next.js Middleware

**User Story:** As a product owner, I want authenticated routes to be inaccessible to unauthenticated users, so that user data and learning progress are protected.

#### Acceptance Criteria

1. THE AuthMiddleware SHALL protect all routes under `/(auth)/` (lessons, reader, study, vocabulary, profile) by redirecting unauthenticated requests to the sign-in page.
2. THE AuthMiddleware SHALL allow unauthenticated access to all routes under `/(public)/` (welcome, about, auth pages, legal).
3. THE AuthMiddleware SHALL allow unauthenticated access to the `/onboarding` route so that newly signed-up users can complete level-setting before their session is fully established.
4. WHEN an authenticated user navigates to `/auth/login` or `/auth/signup`, THE AuthMiddleware SHALL redirect them to `/reader`.
5. THE AuthMiddleware SHALL be implemented using `clerkMiddleware` from `@clerk/nextjs/server` with an explicit `isPublicRoute` matcher — not a blanket allow-all fallback.

---

### Requirement 3: Sign-In and Sign-Up Pages Replaced with Clerk Components

**User Story:** As a learner, I want to sign in and sign up using Clerk's hosted UI components, so that I get a secure, maintained auth experience without the app managing credentials.

#### Acceptance Criteria

1. THE Frontend SHALL render `<SignIn />` from `@clerk/nextjs` at the `/auth/login` route, replacing the current stub `LoginForm`.
2. THE Frontend SHALL render `<SignUp />` from `@clerk/nextjs` at the `/auth/signup` route, replacing the current stub `SignUpForm`.
3. WHEN a user completes sign-up, THE Frontend SHALL redirect them to `/onboarding` (matching the existing `NEXT_PUBLIC_CLERK_SIGN_UP_FORCE_REDIRECT_URL` env var).
4. WHEN a user completes sign-in, THE Frontend SHALL redirect them to `/reader` (matching the existing `NEXT_PUBLIC_CLERK_SIGN_IN_FALLBACK_REDIRECT_URL` env var).
5. THE `<SignIn />` and `<SignUp />` components SHALL be wrapped in the existing `AuthShell` layout so visual consistency with the rest of the auth pages is preserved.

---

### Requirement 4: Onboarding Flow Preserved and Gated Correctly

**User Story:** As a new learner, I want to complete the level-setting onboarding screen after signing up, so that my vocabulary deck is pre-seeded with words I already know.

#### Acceptance Criteria

1. WHEN a user completes Clerk sign-up, THE Frontend SHALL redirect them to `/onboarding` before any authenticated route.
2. WHILE a user has not yet completed onboarding (no `onboardingComplete` metadata on their Clerk session), THE AuthMiddleware SHALL redirect authenticated requests to protected routes back to `/onboarding`.
3. WHEN a user submits their knowledge rank on the Onboarding_Flow, THE Frontend SHALL call `POST /api/users/{id}/onboarding` with the selected rank and the user's Clerk JWT as a Bearer token.
4. WHEN the onboarding API call succeeds, THE Frontend SHALL set `onboardingComplete: true` in the user's Clerk public metadata via a Server Action, then redirect to `/reader`.
5. IF the onboarding API call fails, THEN THE Frontend SHALL display an inline error message and allow the user to retry without losing their rank selection.
6. THE Onboarding_Flow SHALL remain accessible to users who skip it, via a link in their profile settings, so they can change their level later.

---

### Requirement 5: REST Client Attaches Clerk JWT on Every Authenticated Request

**User Story:** As a developer, I want every REST API call made from authenticated pages to include the Clerk JWT, so that the backend can identify and authorize the caller.

#### Acceptance Criteria

1. THE REST_Client SHALL accept an optional `getToken` callback parameter that, when provided, is called before each request to obtain the current Clerk session token.
2. WHEN `getToken` returns a non-null token, THE REST_Client SHALL include an `Authorization: Bearer <token>` header on the request.
3. WHEN `getToken` returns null (unauthenticated or token fetch failed), THE REST_Client SHALL send the request without an `Authorization` header rather than throwing.
4. THE Frontend SHALL provide the Clerk `getToken` function to the REST_Client via a React hook (`useAuthenticatedClient` or equivalent) so that token injection is automatic for all calls made from authenticated components.
5. THE REST_Client SHALL NOT store the token in `localStorage`, `sessionStorage`, or any persistent browser storage — it SHALL be fetched fresh from Clerk on each request.

---

### Requirement 6: Apollo GraphQL Client Already Uses Clerk JWT — Verify and Harden

**User Story:** As a developer, I want to confirm the Apollo client's Clerk JWT injection is correct and resilient, so that GraphQL queries from authenticated pages never silently fall back to unauthenticated requests.

#### Acceptance Criteria

1. THE Apollo_Client SHALL call `getToken()` inside the `authLink` `setContext` callback before every request, consistent with the existing implementation.
2. WHEN `getToken()` returns null, THE Apollo_Client SHALL send the request without an `Authorization` header and SHALL log a warning to the console in development mode.
3. THE Apollo_Client SHALL NOT be instantiated outside of `ApolloClientProvider` in production code paths, ensuring the Clerk `getToken` reference is always current.
4. WHEN the Clerk session expires mid-session, THE Apollo_Client error link SHALL detect an `UNAUTHENTICATED` GraphQL error code and redirect the user to `/auth/login`.

---

### Requirement 7: ClientProviders Migrated from Dev Numeric ID to Clerk Identity

**User Story:** As a developer, I want the `ClientProviders` component to derive user identity from Clerk rather than a dev-only numeric ID in localStorage, so that the app works correctly for real authenticated users.

#### Acceptance Criteria

1. THE ClientProviders SHALL use `useUser()` from `@clerk/nextjs` to obtain the authenticated user's Clerk user ID (`user.id`) instead of reading from `localStorage` via `getActiveDevUserId()`.
2. WHEN the Clerk user is loaded and authenticated, THE ClientProviders SHALL call `fetchUser(clerkUserId)` to load the user's backend profile into `UserContext`.
3. WHEN the Clerk user is not yet loaded (`isLoaded === false`), THE ClientProviders SHALL render a loading state rather than fetching with a default guest ID.
4. WHEN the Clerk user is signed out (`isSignedIn === false`), THE ClientProviders SHALL set the `UserContext` to the default guest state returned by `getDefaultUserState()`.
5. THE `devSession.ts` module and all references to `getActiveDevUserId`, `setActiveDevUserId`, and `DEV_USER_CHANGED_EVENT` SHALL be removed from production code paths once Clerk identity is the source of truth.

---

### Requirement 8: Backend Validates Clerk-Issued JWTs

**User Story:** As a backend developer, I want the ASP.NET Core API to validate Clerk-issued JWTs, so that only authenticated Clerk users can access protected endpoints.

#### Acceptance Criteria

1. THE ClerkJwtValidator SHALL be configured in `Program.cs` using `AddJwtBearer` with Clerk's JWKS endpoint (`https://api.clerk.dev/v1/jwks` or the instance-specific URL from `CLERK_JWKS_URL` env var) as the signing key source.
2. THE ClerkJwtValidator SHALL validate the `iss` (issuer) claim against the Clerk Frontend API URL configured in `CLERK_ISSUER` env var.
3. THE ClerkJwtValidator SHALL validate the `azp` (authorized party) claim against the allowed origins configured in `CLERK_AUTHORIZED_PARTIES` env var (comma-separated list).
4. WHEN a request arrives with a valid Clerk JWT, THE Backend SHALL extract the Clerk user ID from the `sub` claim and make it available via `HttpContext.User`.
5. WHEN a request arrives with an expired, malformed, or missing JWT, THE Backend SHALL return HTTP 401 Unauthorized.
6. THE existing locally-issued JWT auth path (used by `DevAuthController` and legacy login/register endpoints) SHALL remain functional in `Development` environment only, as a named scheme (`LocalJwt`), so that existing integration tests are not broken.

---

### Requirement 9: HttpContextCurrentUserProvider Resolves Clerk User ID to DB User ID

**User Story:** As a backend developer, I want the `ICurrentUserProvider` to map the Clerk user ID (a string like `user_abc123`) to the application's numeric database user ID, so that all domain services continue to work with integer user IDs.

#### Acceptance Criteria

1. THE HttpContextCurrentUserProvider SHALL read the `sub` claim from `HttpContext.User` to obtain the Clerk user ID string.
2. WHEN the `sub` claim contains a Clerk user ID, THE HttpContextCurrentUserProvider SHALL look up the corresponding numeric DB user ID from the `Users` table via a repository call.
3. IF no matching user is found for the Clerk user ID, THEN THE HttpContextCurrentUserProvider SHALL throw an `UnauthorizedAccessException` with a descriptive message.
4. THE HttpContextCurrentUserProvider SHALL cache the resolved numeric ID per HTTP request (scoped lifetime) to avoid redundant DB lookups within a single request.
5. THE fallback to `X-Dev-User-Id` header and the hardcoded `return 1` default SHALL be removed from the production code path and restricted to `#if DEBUG` guards.

---

### Requirement 10: User Provisioning on First Clerk Sign-In

**User Story:** As a new learner, I want my backend user record to be created automatically the first time I sign in with Clerk, so that I don't have to go through a separate registration step.

#### Acceptance Criteria

1. WHEN a Clerk-authenticated request arrives and no `Users` record exists for the Clerk user ID, THE Backend SHALL create a new `Users` record using the Clerk user's email and a generated username derived from the Clerk user's first name and ID.
2. THE Backend SHALL perform this provisioning transparently within the existing request pipeline (e.g., via a middleware or a base controller method) rather than requiring a separate explicit registration call.
3. WHEN a `Users` record already exists for the Clerk user ID, THE Backend SHALL proceed without modification to the existing record.
4. IF user provisioning fails due to a database error, THEN THE Backend SHALL return HTTP 503 Service Unavailable with a descriptive error message and log the exception.
5. THE existing `POST /api/auth/register` endpoint SHALL be deprecated (returning HTTP 410 Gone) once Clerk-based provisioning is in place, to prevent duplicate registration paths.

---

### Requirement 11: DevAuthController Replaced with Clerk Test Accounts

**User Story:** As a developer, I want to use Clerk's test accounts feature for local development authentication, so that I can test the full auth flow without mocks or bypasses.

#### Acceptance Criteria

1. THE project README SHALL document how to create Clerk test accounts in the Clerk dashboard for each of the four test personas (beginner, intermediate, scholar, advanced).
2. THE project README SHALL document that Clerk test accounts use the bypass code `424242` as the OTP/verification code, enabling automated or scripted sign-in without real email delivery.
3. THE `DevAuthController` SHALL remain available in `Development` environment only (guarded by `#if DEBUG`) as a convenience for generating local JWT tokens for direct API testing via Swagger/NSwag UI.
4. THE `devSession.ts` localStorage-based user switcher SHALL be replaced by a development-only UI component that triggers Clerk sign-in for each test persona, rather than bypassing auth entirely.
5. WHERE the `ASPNETCORE_ENVIRONMENT` is `Development`, THE Backend SHALL log a warning on startup if `CLERK_JWKS_URL` is not configured, indicating that Clerk JWT validation is not active.

---

### Requirement 12: Environment Variable Configuration

**User Story:** As a developer, I want all Clerk configuration to be driven by environment variables with clear documentation, so that the app can be configured for different environments without code changes.

#### Acceptance Criteria

1. THE Frontend `frontend/.env.local.example` SHALL document all required Clerk environment variables: `NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY`, `CLERK_SECRET_KEY`, `NEXT_PUBLIC_CLERK_SIGN_IN_URL`, `NEXT_PUBLIC_CLERK_SIGN_UP_URL`, `NEXT_PUBLIC_CLERK_SIGN_IN_FALLBACK_REDIRECT_URL`, `NEXT_PUBLIC_CLERK_SIGN_UP_FORCE_REDIRECT_URL`.
2. THE Backend `appsettings.Development.json` SHALL document the required Clerk backend variables: `ClerkSettings__JwksUrl`, `ClerkSettings__Issuer`, `ClerkSettings__AuthorizedParties`.
3. WHEN any required Clerk environment variable is missing at startup, THE Backend SHALL log a clear error message identifying the missing variable and exit with a non-zero status code.
4. THE `.gitignore` SHALL ensure that `.env.local` and any file matching `appsettings.*.json` containing real secrets are never committed to version control.

---

### Requirement 13: Sign-Out Flow

**User Story:** As a learner, I want to sign out of the app and have my session fully cleared, so that my account is secure when I leave a shared device.

#### Acceptance Criteria

1. THE Frontend SHALL provide a sign-out action (e.g., in the `NavRail` or profile menu) that calls `signOut()` from `@clerk/nextjs`.
2. WHEN `signOut()` completes, THE Frontend SHALL redirect the user to `/welcome`.
3. WHEN `signOut()` completes, THE ClientProviders SHALL reset `UserContext` to the guest state returned by `getDefaultUserState()`.
4. WHEN `signOut()` completes, THE Apollo_Client singleton SHALL be reset (via `_resetApolloClientForTesting` or an equivalent production-safe reset) so that cached user data is not accessible to the next session.
