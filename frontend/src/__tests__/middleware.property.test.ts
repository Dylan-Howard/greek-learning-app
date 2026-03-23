/**
 * Property-based and unit tests for middleware.ts routing logic.
 *
 * Tests use the exported `resolveMiddlewareAction` pure helper to avoid
 * fighting the Next.js request/response cycle.
 */
import { describe, it, expect } from 'vitest';
import * as fc from 'fast-check';
import { resolveMiddlewareAction } from '../../middleware';

// ---------------------------------------------------------------------------
// Property 1: Protected routes always redirect unauthenticated requests
// Validates: Requirements 2.1
// ---------------------------------------------------------------------------
describe('Property 1: Protected routes always redirect unauthenticated requests', () => {
  it('redirects to sign-in for any protected path when userId is null (min 100 iterations)', () => {
    /**
     * **Validates: Requirements 2.1**
     */
    fc.assert(
      fc.property(
        fc.constantFrom('reader', 'lessons', 'study', 'vocabulary', 'profile'),
        (segment) => {
          const pathname = `/${segment}`;
          const action = resolveMiddlewareAction(
            false, // not a public route
            true,  // is a protected route
            null,  // unauthenticated
            pathname,
            undefined
          );
          return action === 'redirect-signin';
        }
      ),
      { numRuns: 100 }
    );
  });
});

// ---------------------------------------------------------------------------
// Property 2: Public routes always pass through unauthenticated requests
// Validates: Requirements 2.2, 2.3
// ---------------------------------------------------------------------------
describe('Property 2: Public routes always pass through unauthenticated requests', () => {
  it('returns next() for any public path when userId is null (min 100 iterations)', () => {
    /**
     * **Validates: Requirements 2.2, 2.3**
     */
    fc.assert(
      fc.property(
        fc.constantFrom('/welcome', '/auth/login', '/auth/signup', '/onboarding'),
        (pathname) => {
          const action = resolveMiddlewareAction(
            true,  // is a public route
            false, // not a protected route
            null,  // unauthenticated
            pathname,
            undefined
          );
          return action === 'next';
        }
      ),
      { numRuns: 100 }
    );
  });
});

// ---------------------------------------------------------------------------
// Property 3: Authenticated users without onboarding are redirected to /onboarding
// Validates: Requirements 4.2
// ---------------------------------------------------------------------------
describe('Property 3: Authenticated users without onboarding redirected to /onboarding', () => {
  it('redirects to /onboarding for any protected path when onboardingComplete is absent/false', () => {
    /**
     * **Validates: Requirements 4.2**
     */
    fc.assert(
      fc.property(
        fc.constantFrom('reader', 'lessons', 'study', 'vocabulary', 'profile'),
        fc.oneof(fc.constant(undefined), fc.constant(false as boolean | undefined)),
        (segment, onboardingComplete) => {
          const pathname = `/${segment}`;
          const action = resolveMiddlewareAction(
            false,           // not a public route
            true,            // is a protected route
            'user_abc123',   // authenticated
            pathname,
            onboardingComplete
          );
          return action === 'redirect-onboarding';
        }
      ),
      { numRuns: 100 }
    );
  });

  it('does NOT redirect to /onboarding when onboardingComplete is true', () => {
    fc.assert(
      fc.property(
        fc.constantFrom('reader', 'lessons', 'study', 'vocabulary', 'profile'),
        (segment) => {
          const pathname = `/${segment}`;
          const action = resolveMiddlewareAction(
            false,
            true,
            'user_abc123',
            pathname,
            true // onboarding complete
          );
          return action === 'next';
        }
      ),
      { numRuns: 100 }
    );
  });
});

// ---------------------------------------------------------------------------
// Task 10.4: Unit tests for middleware routing logic
// Validates: Requirements 2.1, 2.2, 2.3, 2.4
// ---------------------------------------------------------------------------
describe('Unit tests: resolveMiddlewareAction', () => {
  it('redirects authenticated user on /auth/login to /reader', () => {
    const action = resolveMiddlewareAction(
      true,          // /auth/login is under (public)
      false,
      'user_abc123', // authenticated
      '/auth/login',
      true
    );
    expect(action).toBe('redirect-reader');
  });

  it('redirects authenticated user on /auth/signup to /reader', () => {
    const action = resolveMiddlewareAction(
      true,
      false,
      'user_abc123',
      '/auth/signup',
      true
    );
    expect(action).toBe('redirect-reader');
  });

  it('redirects unauthenticated user on /reader to sign-in', () => {
    const action = resolveMiddlewareAction(
      false,
      true,
      null,
      '/reader',
      undefined
    );
    expect(action).toBe('redirect-signin');
  });

  it('passes through unauthenticated user on /onboarding', () => {
    const action = resolveMiddlewareAction(
      true,  // /onboarding is public
      false,
      null,
      '/onboarding',
      undefined
    );
    expect(action).toBe('next');
  });

  it('passes through authenticated user with onboarding complete on protected route', () => {
    const action = resolveMiddlewareAction(
      false,
      true,
      'user_abc123',
      '/reader',
      true
    );
    expect(action).toBe('next');
  });

  it('redirects authenticated user without onboarding on /lessons to /onboarding', () => {
    const action = resolveMiddlewareAction(
      false,
      true,
      'user_abc123',
      '/lessons',
      undefined
    );
    expect(action).toBe('redirect-onboarding');
  });

  it('passes through unauthenticated user on /welcome', () => {
    const action = resolveMiddlewareAction(
      true,
      false,
      null,
      '/welcome',
      undefined
    );
    expect(action).toBe('next');
  });
});
