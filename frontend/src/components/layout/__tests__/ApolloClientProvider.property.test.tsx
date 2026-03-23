/**
 * Property 6: Apollo client calls `getToken` before every GraphQL request
 * Validates: Requirements 6.1
 */
import { describe, it, expect, vi, beforeEach, afterEach } from 'vitest';
import * as fc from 'fast-check';
import { gql } from '@apollo/client';
import { getApolloClient, _resetApolloClientForTesting } from '@/lib/api/graphql/client';

// Mock fetch globally so no real network calls are made
const mockFetch = vi.fn();

beforeEach(() => {
  vi.stubGlobal('fetch', mockFetch);
  _resetApolloClientForTesting();
});

afterEach(() => {
  vi.unstubAllGlobals();
  _resetApolloClientForTesting();
});

/**
 * Returns a minimal valid GraphQL JSON response for fetch to return.
 */
function makeGraphQLResponse(operationName: string) {
  return new Response(
    JSON.stringify({ data: { [operationName]: null } }),
    {
      status: 200,
      headers: { 'Content-Type': 'application/json' },
    }
  );
}

describe('Property 6: Apollo client calls getToken before every GraphQL request', () => {
  it('calls getToken exactly once per GraphQL operation for any operation name', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.string({ minLength: 1, maxLength: 30 }).filter(s => /^[a-zA-Z][a-zA-Z0-9]*$/.test(s)),
        async (operationName) => {
          // Reset singleton so each iteration gets a fresh client
          _resetApolloClientForTesting();

          const getToken = vi.fn().mockResolvedValue('test-token-abc');

          mockFetch.mockResolvedValueOnce(makeGraphQLResponse(operationName));

          const client = getApolloClient(getToken);

          const query = gql`
            query ${operationName} {
              ${operationName}
            }
          `;

          try {
            await client.query({ query, fetchPolicy: 'no-cache' });
          } catch {
            // Network/parse errors are acceptable — we only care that getToken was called
          }

          expect(getToken).toHaveBeenCalledTimes(1);
        }
      ),
      { numRuns: 100 }
    );
  });
});
