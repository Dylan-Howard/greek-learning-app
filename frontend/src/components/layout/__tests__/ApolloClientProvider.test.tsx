/**
 * Unit tests for ApolloClientProvider
 * Validates: Requirements 6.2, 6.4
 */
import { render, waitFor } from '@testing-library/react';
import { vi, describe, it, expect, beforeEach, afterEach } from 'vitest';
import React from 'react';
import { gql } from '@apollo/client';

// --- Mocks ---

const mockRouterPush = vi.fn();
vi.mock('next/navigation', () => ({
  useRouter: () => ({ push: mockRouterPush }),
}));

const mockGetToken = vi.fn();
vi.mock('@clerk/nextjs', () => ({
  useAuth: () => ({ getToken: mockGetToken }),
}));

const mockResetApolloClient = vi.fn();
vi.mock('@/lib/api/graphql/client', async (importOriginal) => {
  const actual = await importOriginal<typeof import('@/lib/api/graphql/client')>();
  return {
    ...actual,
    _resetApolloClientForTesting: () => {
      mockResetApolloClient();
      actual._resetApolloClientForTesting();
    },
  };
});

const mockFetch = vi.fn();

// Import after mocks
import { ApolloClientProvider } from '../ApolloClientProvider';
import { getApolloClient, _resetApolloClientForTesting } from '@/lib/api/graphql/client';

// Helper: build a minimal GraphQL fetch response
function makeGqlResponse(data: Record<string, unknown> = {}) {
  return new Response(JSON.stringify({ data }), {
    status: 200,
    headers: { 'Content-Type': 'application/json' },
  });
}

// Helper: build an UNAUTHENTICATED GraphQL error response
function makeUnauthenticatedResponse() {
  return new Response(
    JSON.stringify({
      errors: [{ message: 'Not authenticated', extensions: { code: 'UNAUTHENTICATED' } }],
    }),
    { status: 200, headers: { 'Content-Type': 'application/json' } }
  );
}

beforeEach(() => {
  vi.stubGlobal('fetch', mockFetch);
  _resetApolloClientForTesting();
  mockResetApolloClient.mockClear();
  mockRouterPush.mockClear();
  mockGetToken.mockClear();
});

afterEach(() => {
  vi.unstubAllGlobals();
  _resetApolloClientForTesting();
});

// ---------------------------------------------------------------------------
// Helper: render the provider and get the Apollo client instance
// ---------------------------------------------------------------------------
function renderProvider() {
  let capturedClient: ReturnType<typeof getApolloClient> | null = null;

  const Capture = () => {
    capturedClient = getApolloClient();
    return null;
  };

  render(
    <ApolloClientProvider>
      <Capture />
    </ApolloClientProvider>
  );

  return capturedClient!;
}

// ---------------------------------------------------------------------------
// Test 1: UNAUTHENTICATED error triggers redirect + cache reset
// ---------------------------------------------------------------------------
describe('ApolloClientProvider — UNAUTHENTICATED error handling', () => {
  it('redirects to /auth/login and resets Apollo cache when UNAUTHENTICATED error is received', async () => {
    mockGetToken.mockResolvedValue('valid-token');
    mockFetch.mockResolvedValueOnce(makeUnauthenticatedResponse());

    // Mock console.error to suppress the expected GraphQL error log
    const errorSpy = vi.spyOn(console, 'error').mockImplementation(() => {});

    const client = renderProvider();

    const query = gql`
      query TestQuery {
        test
      }
    `;

    try {
      await client.query({ query, fetchPolicy: 'no-cache' });
    } catch {
      // Apollo throws on GraphQL errors — expected
    }

    await waitFor(() => {
      expect(mockRouterPush).toHaveBeenCalledWith('/auth/login');
    });

    // _resetApolloClientForTesting called: once on mount + once in onUnauthenticated
    expect(mockResetApolloClient).toHaveBeenCalledTimes(2);

    errorSpy.mockRestore();
  });
});

// ---------------------------------------------------------------------------
// Test 2: getToken() returning null logs console.warn in development
// ---------------------------------------------------------------------------
describe('ApolloClientProvider — null token warning', () => {
  it('logs a console.warn when getToken returns null in development mode', async () => {
    const originalNodeEnv = process.env.NODE_ENV;
    // @ts-expect-error — overriding read-only NODE_ENV for test
    process.env.NODE_ENV = 'development';

    mockGetToken.mockResolvedValue(null);
    mockFetch.mockResolvedValueOnce(makeGqlResponse({ test: null }));

    const warnSpy = vi.spyOn(console, 'warn').mockImplementation(() => {});

    const client = renderProvider();

    const query = gql`
      query NullTokenQuery {
        test
      }
    `;

    try {
      await client.query({ query, fetchPolicy: 'no-cache' });
    } catch {
      // ignore
    }

    await waitFor(() => {
      expect(warnSpy).toHaveBeenCalledWith(
        '[Apollo] getToken() returned null — request sent without Authorization header'
      );
    });

    // @ts-expect-error — restore
    process.env.NODE_ENV = originalNodeEnv;
  });

  it('does not log a console.warn when getToken returns null in production mode', async () => {
    const originalNodeEnv = process.env.NODE_ENV;
    // @ts-expect-error — overriding read-only NODE_ENV for test
    process.env.NODE_ENV = 'production';

    mockGetToken.mockResolvedValue(null);
    mockFetch.mockResolvedValueOnce(makeGqlResponse({ test: null }));

    const warnSpy = vi.spyOn(console, 'warn').mockImplementation(() => {});

    const client = renderProvider();

    const query = gql`
      query NullTokenProdQuery {
        test
      }
    `;

    try {
      await client.query({ query, fetchPolicy: 'no-cache' });
    } catch {
      // ignore
    }

    // Give any async effects time to settle
    await new Promise((r) => setTimeout(r, 50));

    expect(warnSpy).not.toHaveBeenCalledWith(
      expect.stringContaining('[Apollo] getToken() returned null')
    );

    // @ts-expect-error — restore
    process.env.NODE_ENV = originalNodeEnv;
  });
});
