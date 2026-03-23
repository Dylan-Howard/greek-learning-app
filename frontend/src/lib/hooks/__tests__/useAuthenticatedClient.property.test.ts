/**
 * Property-based tests for useAuthenticatedClient hook.
 *
 * Property 4: REST client injects Bearer token for any non-null token
 * Validates: Requirements 5.1, 5.2
 *
 * Property 5: Token is never written to persistent browser storage
 * Validates: Requirements 5.5
 */

import { describe, it, expect, vi, beforeEach, afterEach } from 'vitest';
import * as fc from 'fast-check';
import { renderHook } from '@testing-library/react';
import { useAuthenticatedClient } from '../useAuthenticatedClient';

// Mutable reference so the factory closure can pick up the latest value
let mockGetToken: () => Promise<string | null> = () => Promise.resolve(null);

vi.mock('@clerk/nextjs', () => ({
  useAuth: () => ({ getToken: () => mockGetToken() }),
}));

function makeFetchMock(capturedHeaders: Record<string, string>[]) {
  return vi.fn().mockImplementation((_url: string, init?: RequestInit) => {
    const headers = (init?.headers ?? {}) as Record<string, string>;
    capturedHeaders.push({ ...headers });
    return Promise.resolve(
      new Response(JSON.stringify({}), {
        status: 200,
        headers: { 'Content-Type': 'application/json' },
      }),
    );
  });
}

describe('useAuthenticatedClient — Property 4: Bearer token injection', () => {
  /**
   * **Validates: Requirements 5.1, 5.2**
   *
   * For any non-empty token string returned by getToken(), the outgoing
   * HTTP request must carry an Authorization header with value
   * `Bearer <token>` — exactly matching the token.
   */
  it('injects Authorization: Bearer <token> for any non-null token string', async () => {
    await fc.assert(
      fc.asyncProperty(fc.string({ minLength: 10 }), async (token) => {
        const capturedHeaders: Record<string, string>[] = [];
        const fetchMock = makeFetchMock(capturedHeaders);
        vi.stubGlobal('fetch', fetchMock);

        mockGetToken = () => Promise.resolve(token);

        const { result } = renderHook(() => useAuthenticatedClient());
        const client = result.current;

        await client.get('test-endpoint');

        expect(capturedHeaders.length).toBeGreaterThan(0);
        const authHeader = capturedHeaders[capturedHeaders.length - 1]['Authorization'];
        expect(authHeader).toBe(`Bearer ${token}`);
      }),
      { numRuns: 100 },
    );
  });

  it('injects Bearer token on post requests', async () => {
    await fc.assert(
      fc.asyncProperty(fc.string({ minLength: 10 }), async (token) => {
        const capturedHeaders: Record<string, string>[] = [];
        const fetchMock = makeFetchMock(capturedHeaders);
        vi.stubGlobal('fetch', fetchMock);

        mockGetToken = () => Promise.resolve(token);

        const { result } = renderHook(() => useAuthenticatedClient());
        const client = result.current;

        await client.post('test-endpoint', { data: 'value' });

        expect(capturedHeaders.length).toBeGreaterThan(0);
        const authHeader = capturedHeaders[capturedHeaders.length - 1]['Authorization'];
        expect(authHeader).toBe(`Bearer ${token}`);
      }),
      { numRuns: 100 },
    );
  });
});

describe('useAuthenticatedClient — Property 5: Token never written to persistent storage', () => {
  /**
   * **Validates: Requirements 5.5**
   *
   * For any token string, making a request via the authenticated client
   * must never write a JWT-shaped value (matching /^eyJ/) to
   * localStorage, sessionStorage, or document.cookie.
   */
  it('never writes JWT-shaped values to localStorage or sessionStorage', async () => {
    const localStorageSpy = vi.spyOn(Storage.prototype, 'setItem');
    const sessionStorageSpy = vi.spyOn(
      Object.getPrototypeOf(window.sessionStorage) as Storage,
      'setItem',
    );

    await fc.assert(
      fc.asyncProperty(fc.string({ minLength: 10 }), async (token) => {
        localStorageSpy.mockClear();
        sessionStorageSpy.mockClear();

        const fetchMock = makeFetchMock([]);
        vi.stubGlobal('fetch', fetchMock);

        mockGetToken = () => Promise.resolve(token);

        const { result } = renderHook(() => useAuthenticatedClient());
        const client = result.current;

        await client.get('test-endpoint');

        // Assert no JWT-shaped value was written to localStorage
        const localStorageCalls = localStorageSpy.mock.calls;
        for (const [, value] of localStorageCalls) {
          expect(String(value)).not.toMatch(/^eyJ/);
        }

        // Assert no JWT-shaped value was written to sessionStorage
        const sessionStorageCalls = sessionStorageSpy.mock.calls;
        for (const [, value] of sessionStorageCalls) {
          expect(String(value)).not.toMatch(/^eyJ/);
        }
      }),
      { numRuns: 100 },
    );

    localStorageSpy.mockRestore();
    sessionStorageSpy.mockRestore();
  });

  it('never writes JWT-shaped values to document.cookie', async () => {
    // Spy on the cookie setter via Object.defineProperty
    const cookieValues: string[] = [];
    const originalDescriptor = Object.getOwnPropertyDescriptor(Document.prototype, 'cookie');

    Object.defineProperty(document, 'cookie', {
      set(value: string) {
        cookieValues.push(value);
        // Apply the original setter if available
        if (originalDescriptor?.set) {
          originalDescriptor.set.call(document, value);
        }
      },
      get() {
        return originalDescriptor?.get ? originalDescriptor.get.call(document) : '';
      },
      configurable: true,
    });

    await fc.assert(
      fc.asyncProperty(fc.string({ minLength: 10 }), async (token) => {
        cookieValues.length = 0;

        const fetchMock = makeFetchMock([]);
        vi.stubGlobal('fetch', fetchMock);

        mockGetToken = () => Promise.resolve(token);

        const { result } = renderHook(() => useAuthenticatedClient());
        const client = result.current;

        await client.get('test-endpoint');

        for (const cookieValue of cookieValues) {
          expect(cookieValue).not.toMatch(/^eyJ/);
        }
      }),
      { numRuns: 100 },
    );

    // Restore original cookie descriptor
    if (originalDescriptor) {
      Object.defineProperty(document, 'cookie', originalDescriptor);
    }
  });
});
