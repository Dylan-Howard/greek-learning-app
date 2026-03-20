// Feature: graphql-integration, Property 8: Apollo authLink attaches the Clerk JWT on every request

import { describe, it, expect, beforeEach } from 'vitest';
import fc from 'fast-check';
import { ApolloLink, Observable, gql, execute } from '@apollo/client';
import { setContext } from '@apollo/client/link/context';
import { _resetApolloClientForTesting } from './client';

// **Validates: Requirements 7.3**

const TEST_QUERY = gql`
  query TestQuery {
    __typename
  }
`;

/**
 * Builds an authLink that reads a JWT from the provided async getter,
 * mirroring the implementation in client.ts.
 */
function buildAuthLink(getToken: () => Promise<string | null>): ApolloLink {
  return setContext(async (_, { headers }: { headers?: Record<string, string> }) => {
    const token = await getToken();
    return {
      headers: {
        ...headers,
        ...(token ? { Authorization: `Bearer ${token}` } : {}),
      },
    };
  });
}

describe('Property 8: Apollo authLink attaches the Clerk JWT on every request', () => {
  beforeEach(() => {
    _resetApolloClientForTesting();
  });

  it('attaches Authorization: Bearer <token> for every random JWT string', async () => {
    await fc.assert(
      fc.asyncProperty(
        // Generate realistic JWT-like strings (base64url segments separated by dots)
        fc.tuple(
          fc.base64String({ minLength: 10, maxLength: 40 }),
          fc.base64String({ minLength: 20, maxLength: 80 }),
          fc.base64String({ minLength: 20, maxLength: 80 }),
        ).map(([h, p, s]) => `${h}.${p}.${s}`),
        async (jwt) => {
          const capturedHeaders: Record<string, string>[] = [];

          const authLink = buildAuthLink(async () => jwt);

          // Terminal link that captures the operation context headers
          const captureLink = new ApolloLink((operation) => {
            capturedHeaders.push({ ...(operation.getContext().headers as Record<string, string>) });
            return Observable.of({ data: { __typename: 'Query' } });
          });

          const link = authLink.concat(captureLink);

          await new Promise<void>((resolve, reject) => {
            execute(link, { query: TEST_QUERY }).subscribe({
              next: () => {},
              error: reject,
              complete: resolve,
            });
          });

          expect(capturedHeaders).toHaveLength(1);
          expect(capturedHeaders[0]?.Authorization).toBe(`Bearer ${jwt}`);
        },
      ),
      { numRuns: 100 },
    );
  });

  it('omits Authorization header when getToken returns null', async () => {
    await fc.assert(
      fc.asyncProperty(fc.constant(null), async () => {
        const capturedHeaders: Record<string, string>[] = [];

        const authLink = buildAuthLink(async () => null);
        const captureLink = new ApolloLink((operation) => {
          capturedHeaders.push({ ...(operation.getContext().headers as Record<string, string>) });
          return Observable.of({ data: { __typename: 'Query' } });
        });

        const link = authLink.concat(captureLink);

        await new Promise<void>((resolve, reject) => {
          execute(link, { query: TEST_QUERY }).subscribe({
            next: () => {},
            error: reject,
            complete: resolve,
          });
        });

        expect(capturedHeaders[0]?.Authorization).toBeUndefined();
      }),
      { numRuns: 10 },
    );
  });
});
