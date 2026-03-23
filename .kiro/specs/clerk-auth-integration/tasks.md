# Implementation Plan: Clerk Auth Integration

## Overview

Wire Clerk end-to-end across the Next.js frontend and ASP.NET Core backend. Work proceeds in four phases: (1) backend data + JWT plumbing, (2) frontend provider + middleware, (3) auth pages + client hardening, (4) sign-out + cleanup.

## Tasks

- [x] 1. Add `ClerkId` to the `User` entity and generate the EF migration
  - Add `public string? ClerkId { get; set; }` to `Koine.Domain/Entities/User.cs`
  - Add a unique filtered index on `ClerkId` (non-null values only) in `KoineDbContext` via `OnModelCreating`
  - Run `dotnet ef migrations add AddClerkIdToUser` — do not hand-edit the generated file
  - _Requirements: 9.1, 10.1_

- [x] 2. Extend `IUserRepository` and implement `GetByClerkIdAsync` / `ProvisionClerkUserAsync`
  - Add `Task<User?> GetByClerkIdAsync(string clerkId)` and `Task<User> ProvisionClerkUserAsync(string clerkId, string email, string username)` to `IUserRepository` in `Koine.Application/Interfaces/Repositories/`
  - Implement both methods in the existing `UserRepository` in `Koine.Infrastructure`
  - `ProvisionClerkUserAsync` generates a username from the Clerk first name + last 6 chars of the Clerk ID
  - _Requirements: 9.2, 10.1_

  - [ ] 2.1 Write property test for `ProvisionClerkUserAsync` idempotency (Property 11)
    - **Property 11: User provisioning is idempotent**
    - **Validates: Requirements 10.1, 10.3**
    - Use CsCheck or FsCheck; generate random Clerk IDs; call provisioning twice; assert exactly one `Users` record exists

- [x] 3. Add `ClerkSettings` record and startup validation in `Program.cs`
  - Create `backend/src/Koine.API/Settings/ClerkSettings.cs` as a `record` with `JwksUrl`, `Issuer`, `string[] AuthorizedParties`
  - Bind from `ClerkSettings` config section in `Program.cs`; throw `InvalidOperationException` with a descriptive message if any field is missing in non-Development environments
  - In Development, log a warning (not a hard failure) when `JwksUrl` is not configured
  - Add placeholder values to `backend/src/Koine.API/appsettings.Development.json`
  - _Requirements: 8.1, 8.2, 8.3, 12.2, 12.3, 11.5_

- [ ] 4. Register dual JWT schemes (`ClerkJwt` default + `LocalJwt` dev-only) in `Program.cs`
  - Replace the existing single `AddJwtBearer` call with `AddAuthentication(defaultScheme: "ClerkJwt")`
  - Add `"ClerkJwt"` scheme using `options.Authority` (issuer) and `options.MetadataAddress` (JWKS URL) from `ClerkSettings`; validate `azp` against `ClerkSettings.AuthorizedParties` via `TokenValidationParameters.ValidAudiences` or a custom validator
  - Wrap the existing symmetric-key `"LocalJwt"` scheme registration in `#if DEBUG`
  - _Requirements: 8.1, 8.2, 8.3, 8.6_

  - [ ] 4.1 Write property test for JWT validation (Property 8)
    - **Property 8: Invalid JWT always returns HTTP 401**
    - **Validates: Requirements 8.1, 8.2, 8.3, 8.5**
    - Use CsCheck/FsCheck; generate expired JWTs, wrong-issuer JWTs, malformed strings; assert every case returns 401

  - [ ] 4.2 Write property test for valid JWT claim extraction (Property 9)
    - **Property 9: Valid Clerk JWT exposes `sub` claim in `HttpContext.User`**
    - **Validates: Requirements 8.4**
    - Generate valid JWT payloads with random `sub` values; assert `HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value` equals the `sub`

- [ ] 5. Implement `UserProvisioningMiddleware`
  - Create `backend/src/Koine.API/Middleware/UserProvisioningMiddleware.cs`
  - For authenticated requests: read `sub` claim → call `IUserRepository.GetByClerkIdAsync`; if null call `ProvisionClerkUserAsync`; store numeric `userId` in `HttpContext.Items["NumericUserId"]`
  - On `DbUpdateException`: log via `ILogger<UserProvisioningMiddleware>`, short-circuit with HTTP 503 and JSON body `{ "message": "User provisioning failed. Please try again." }`
  - Register after `UseAuthorization()` in `Program.cs`
  - _Requirements: 10.1, 10.2, 10.3, 10.4_

  - [ ] 5.1 Write unit tests for `UserProvisioningMiddleware`
    - New user: assert `ProvisionClerkUserAsync` called and `HttpContext.Items["NumericUserId"]` set
    - Existing user: assert `GetByClerkIdAsync` returns existing record, no provisioning call
    - DB failure: assert HTTP 503 response and exception logged
    - _Requirements: 10.1, 10.3, 10.4_

- [ ] 6. Update `HttpContextCurrentUserProvider` to read from `HttpContext.Items`
  - Replace the current `ClaimTypes.NameIdentifier` integer-parse logic with a read of `HttpContext.Items["NumericUserId"]`
  - Throw `UnauthorizedAccessException("No user record found for Clerk ID: {clerkId}")` when the item is absent
  - Restrict the `X-Dev-User-Id` header fallback to `#if DEBUG` only; remove the hardcoded `return 1` default
  - Add request-scoped caching: store the resolved ID in a private nullable field so the repository is queried at most once per request
  - _Requirements: 9.1, 9.2, 9.3, 9.4, 9.5_

  - [ ] 6.1 Write property test for per-request caching (Property 10)
    - **Property 10: Clerk user ID lookup returns consistent numeric ID per request**
    - **Validates: Requirements 9.2, 9.4**
    - Generate random Clerk IDs; call `GetUserId()` N times on the same provider instance; assert repository called exactly once

  - [ ] 6.2 Write unit tests for `HttpContextCurrentUserProvider`
    - Returns numeric ID from `HttpContext.Items["NumericUserId"]`
    - Throws `UnauthorizedAccessException` when item absent
    - `X-Dev-User-Id` fallback present only in DEBUG build
    - _Requirements: 9.1, 9.3, 9.5_

- [ ] 7. Deprecate `POST /api/auth/register` in `AuthController`
  - Return HTTP 410 Gone with body `{ "message": "Registration via this endpoint is deprecated. Users are provisioned automatically on first Clerk sign-in." }`
  - _Requirements: 10.5_

- [ ] 8. Checkpoint — backend plumbing complete
  - Ensure all backend tests pass: `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1`
  - Ask the user if questions arise before proceeding to frontend work.

- [ ] 9. Add `ClerkProvider` to `app/layout.tsx` and validate env vars at build time
  - Import `ClerkProvider` from `@clerk/nextjs` and wrap the existing `<ThemeProvider><ClientProviders>` tree
  - Add a build-time guard: `if (!process.env.NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY) throw new Error('NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY is required')`
  - Pass `signInUrl`, `signUpUrl`, `afterSignInUrl`, `afterSignUpUrl` from env vars to `ClerkProvider`
  - _Requirements: 1.1, 1.2, 1.3_

  - [ ] 9.1 Write unit tests for `app/layout.tsx`
    - Renders `ClerkProvider` wrapping children
    - Throws when `NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY` is absent
    - _Requirements: 1.1, 1.2_

- [ ] 10. Create `middleware.ts` with `clerkMiddleware` and explicit public-route matcher
  - Create `frontend/middleware.ts` (Next.js App Router root)
  - Use `clerkMiddleware` from `@clerk/nextjs/server` with an explicit `isPublicRoute` matcher covering `/(public)/(.*)` and `/onboarding`
  - Redirect unauthenticated requests to protected routes (`/(auth)/(.*)`) to the sign-in URL
  - Redirect authenticated users visiting `/auth/login` or `/auth/signup` to `/reader`
  - Redirect authenticated users without `publicMetadata.onboardingComplete` who request `/(auth)/(.*)` to `/onboarding`
  - _Requirements: 2.1, 2.2, 2.3, 2.4, 2.5, 4.2_

  - [ ] 10.1 Write property test for protected-route redirect (Property 1)
    - **Property 1: Protected routes always redirect unauthenticated requests**
    - **Validates: Requirements 2.1**
    - Use fast-check; generate paths from `['reader', 'lessons', 'study', 'vocabulary', 'profile']`; assert redirect response for unauthenticated requests

  - [ ] 10.2 Write property test for public-route pass-through (Property 2)
    - **Property 2: Public routes always pass through unauthenticated requests**
    - **Validates: Requirements 2.2, 2.3**
    - Use fast-check; generate paths from `['/welcome', '/auth/login', '/auth/signup', '/onboarding']`; assert no redirect

  - [ ] 10.3 Write property test for onboarding redirect (Property 3)
    - **Property 3: Authenticated users without onboarding are redirected to `/onboarding`**
    - **Validates: Requirements 4.2**
    - Simulate authenticated session with `onboardingComplete` absent/false; assert redirect to `/onboarding` for any `/(auth)/` path

  - [ ] 10.4 Write unit tests for `middleware.ts`
    - Authenticated user on `/auth/login` → redirect to `/reader`
    - Unauthenticated user on `/reader` → redirect to sign-in
    - `/onboarding` passes through unauthenticated
    - _Requirements: 2.1, 2.2, 2.3, 2.4_

- [ ] 11. Wire `login/page.tsx` to Clerk `useSignIn()` custom flow
  - Replace the stub `handleLogin` in `frontend/src/app/(public)/auth/login/page.tsx` with a real implementation using `useSignIn()` from `@clerk/nextjs`
  - On `result.status === 'complete'`: call `setActive({ session: result.createdSessionId })` then `router.push('/reader')`
  - On Clerk error: re-throw with `err.errors[0].longMessage ?? err.errors[0].message` so the existing `<Alert>` in `LoginForm` displays it
  - Do not modify `AuthForms.tsx` or `AuthShell.tsx`
  - _Requirements: 3.1, 3.5, 3.6, 3.7_

  - [ ] 11.1 Write unit tests for `login/page.tsx`
    - Successful sign-in calls `setActive` and navigates to `/reader`
    - Clerk error surfaces via the `LoginForm` `onSubmit` rejection
    - _Requirements: 3.1, 3.5, 3.6_

- [ ] 12. Wire `signup/page.tsx` to Clerk `useSignUp()` custom flow
  - Replace the stub `handleSignup` in `frontend/src/app/(public)/auth/signup/page.tsx` with a real implementation using `useSignUp()` from `@clerk/nextjs`
  - On `result.status === 'complete'`: call `setActive({ session: result.createdSessionId })` then `router.push('/onboarding')`
  - On Clerk error: re-throw with `err.errors[0].longMessage ?? err.errors[0].message`
  - Do not modify `AuthForms.tsx` or `AuthShell.tsx`
  - _Requirements: 3.2, 3.4, 3.6, 3.7_

  - [ ] 12.1 Write unit tests for `signup/page.tsx`
    - Successful sign-up calls `setActive` and navigates to `/onboarding`
    - Clerk error surfaces via the `SignUpForm` `onSubmit` rejection
    - _Requirements: 3.2, 3.4, 3.6_

- [ ] 13. Wire `OAuthButtons` to `authenticateWithRedirect` and create `/sso-callback` route
  - In `login/page.tsx` and `signup/page.tsx`, pass an `onOAuth` prop (or equivalent pattern) down to the `OAuthButtons` component via the page's render context — without modifying `AuthForms.tsx`
  - Since `OAuthButtons` is inside `AuthForms.tsx` (which must not be modified), create a thin wrapper page component that intercepts the OAuth button clicks via a React context or by rendering a custom `OAuthButtons` overlay — confirm the approach that avoids touching `AuthForms.tsx`
  - Call `signIn.authenticateWithRedirect({ strategy: 'oauth_google' | 'oauth_apple', redirectUrl: '/sso-callback', redirectUrlComplete: '/reader' })` for login; use `signUp.authenticateWithRedirect` for signup
  - Create `frontend/src/app/(public)/sso-callback/page.tsx` that renders `<AuthenticateWithRedirectCallback />` from `@clerk/nextjs`
  - _Requirements: 3.3_

- [ ] 14. Create `useAuthenticatedClient` hook
  - Create `frontend/src/lib/hooks/useAuthenticatedClient.ts`
  - Use `useAuth().getToken` from `@clerk/nextjs` to obtain a fresh token before each call
  - Return a wrapped version of `apiClient` where every method automatically calls `getToken()` and passes the result as the `token` argument
  - Token must never be stored in `localStorage`, `sessionStorage`, or cookies
  - _Requirements: 5.1, 5.2, 5.3, 5.4, 5.5_

  - [ ] 14.1 Write property test for Bearer token injection (Property 4)
    - **Property 4: REST client injects Bearer token for any non-null token**
    - **Validates: Requirements 5.1, 5.2**
    - Use fast-check; generate arbitrary non-empty token strings; assert outgoing request has `Authorization: Bearer <token>` matching exactly

  - [ ] 14.2 Write property test for no persistent storage (Property 5)
    - **Property 5: Token is never written to persistent browser storage**
    - **Validates: Requirements 5.5**
    - Spy on `localStorage.setItem`, `sessionStorage.setItem`, `document.cookie`; assert no JWT-shaped value (`/^eyJ/`) is written during any request

- [ ] 15. Migrate `ClientProviders.tsx` from `devSession` / `localStorage` to `useUser()`
  - Replace `getActiveDevUserId()` / `DEV_USER_CHANGED_EVENT` logic with `useUser()` from `@clerk/nextjs`
  - When `isLoaded === false`: render a loading state (e.g. `null` or a spinner), do not call `fetchUser`
  - When `isSignedIn === false`: call `setActiveUser(UserService.getDefaultUserState())`
  - When `isSignedIn === true`: call `fetchUser(user.id)` using `useAuthenticatedClient` for the token
  - Remove all imports of `devSession` from `ClientProviders.tsx`
  - _Requirements: 7.1, 7.2, 7.3, 7.4_

  - [ ] 15.1 Write property test for `fetchUser` always called with Clerk ID (Property 7)
    - **Property 7: Authenticated Clerk user always triggers `fetchUser`**
    - **Validates: Requirements 7.2**
    - Use fast-check; generate arbitrary Clerk user ID strings; render `ClientProviders` with mocked `useUser` returning `{ isLoaded: true, isSignedIn: true, user: { id } }`; assert `fetchUser` called with that ID

  - [ ] 15.2 Write unit tests for `ClientProviders`
    - `isLoaded=false` → renders loading state, `fetchUser` not called
    - `isSignedIn=false` → `setActiveUser` called with `getDefaultUserState()`
    - `isSignedIn=true` → `fetchUser` called with `user.id`
    - _Requirements: 7.1, 7.2, 7.3, 7.4_

- [ ] 16. Harden `ApolloClientProvider` — null token warning + unauthenticated redirect
  - In `ApolloClientProvider.tsx`, pass an `onUnauthenticated` handler to `getApolloClient` that calls `router.push('/auth/login')` and `_resetApolloClientForTesting()` (or a production-safe reset)
  - In `buildErrorLink` (or the `authLink` `setContext` in `client.ts`), add `if (!token && process.env.NODE_ENV === 'development') console.warn('[Apollo] getToken() returned null — request sent without Authorization header')`
  - _Requirements: 6.2, 6.4_

  - [ ] 16.1 Write property test for Apollo `getToken` called per request (Property 6)
    - **Property 6: Apollo client calls `getToken` before every GraphQL request**
    - **Validates: Requirements 6.1**
    - Use fast-check; generate arbitrary operation names; assert `getToken` spy called exactly once per operation

  - [ ] 16.2 Write unit tests for `ApolloClientProvider`
    - `UNAUTHENTICATED` error code triggers redirect to `/auth/login` and cache reset
    - `getToken()` returning null logs a console warning in development
    - _Requirements: 6.2, 6.4_

- [ ] 17. Implement sign-out flow
  - Add a sign-out action to the `NavRail` or profile menu that calls `signOut()` from `@clerk/nextjs`
  - After `signOut()` resolves: call `router.push('/welcome')`, call `setActiveUser(getDefaultUserState())` via `UserContext`, and call `_resetApolloClientForTesting()` (or production-safe equivalent) to clear the Apollo cache
  - _Requirements: 13.1, 13.2, 13.3, 13.4_

  - [ ] 17.1 Write property test for sign-out guest state reset (Property 12)
    - **Property 12: Sign-out resets `UserContext` to guest state**
    - **Validates: Requirements 13.3**
    - Use fast-check; generate arbitrary authenticated user shapes; after `signOut()` assert `UserContext` value is structurally equal to `getDefaultUserState()`

  - [ ] 17.2 Write unit tests for sign-out flow
    - `signOut()` → redirect to `/welcome`
    - `UserContext` reset to guest state
    - Apollo cache reset called
    - _Requirements: 13.1, 13.2, 13.3, 13.4_

- [ ] 18. Update `frontend/.env.local.example` and `appsettings.Development.json`
  - Add all required Clerk frontend env vars to `frontend/.env.local.example` with placeholder values and comments
  - Confirm `appsettings.Development.json` has `ClerkSettings` section with placeholder values (added in task 3)
  - Verify `.gitignore` excludes `.env.local` and `appsettings.*.json` secret files
  - _Requirements: 12.1, 12.2, 12.4_

- [ ] 19. Remove `devSession.ts` from production code paths
  - Delete `frontend/src/lib/services/auth/devSession.ts` once `ClientProviders` no longer imports it (after task 15)
  - Remove any remaining imports of `getActiveDevUserId`, `setActiveDevUserId`, `DEV_USER_CHANGED_EVENT` from non-debug files
  - _Requirements: 7.5_

- [ ] 20. Final checkpoint — full integration
  - Run frontend tests: `cd frontend && npm run test -- --silent`
  - Run backend tests: `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1`
  - Ensure all tests pass; ask the user if questions arise.

## Notes

- Tasks marked with `*` are optional and can be skipped for a faster MVP
- Tasks 1–8 are backend-only and can be worked independently of tasks 9–19
- `AuthForms.tsx` and `AuthShell.tsx` must not be modified — all Clerk logic lives in page files
- Property tests use `fast-check` (frontend) and `CsCheck`/`FsCheck` (backend)
- `DevAuthController` is intentionally left unchanged — it remains `#if DEBUG` only
- EF migrations are auto-generated — never hand-edit files in `Koine.Infrastructure/Migrations/`
