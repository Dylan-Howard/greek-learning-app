// Feature: graphql-integration, Property 10: GraphQL error codes are propagated to the calling component

import { describe, it, expect, vi, beforeEach, afterEach } from 'vitest';
import fc from 'fast-check';
import { ApolloLink, Observable, gql, execute } from '@apollo/client';
import type { GraphQLError } from 'graphql';
import { buildErrorLink, type ErrorLinkHandlers } from './client';

// **Validates: Requirements 14.1–14.6**

const TEST_QUERY = gql`
  query TestQuery {
    __typename
  }
`;

/** Known extension codes the errorLink must handle */
const KNOWN_CODES = ['UNAUTHENTICATED', 'NOT_FOUND', 'FORBIDDEN'] as const;
type KnownCode = (typeof KNOWN_CODES)[number];

/** Build a minimal GraphQLError-shaped object with a given extension code */
function makeGraphQLError(code: string): GraphQLError {
  return {
    message: `Error with code ${code}`,
    extensions: { code },
    locations: undefined,
    path: undefined,
    nodes: undefined,
    source: undefined,
    positions: undefined,
    originalError: null,
    name: 'GraphQLError',
    toJSON: () => ({ message: `Error with code ${code}` }),
    [Symbol.toStringTag]: 'GraphQLError',
  } as unknown as GraphQLError;
}

/**
 * Executes the errorLink against a terminal link that emits a response
 * containing the given graphQLErrors, then returns a promise that resolves
 * when the observable completes.
 */
function runWithErrors(
  errorLink: ApolloLink,
  graphQLErrors: GraphQLError[],
): Promise<void> {
  const terminalLink = new ApolloLink(() =>
    Observable.of({ data: { __typename: 'Query' }, errors: graphQLErrors }),
  );

  const link = errorLink.concat(terminalLink);

  return new Promise<void>((resolve, reject) => {
    execute(link, { query: TEST_QUERY }).subscribe({
      next: () => {},
      error: reject,
      complete: resolve,
    });
  });
}

/**
 * Executes the errorLink against a terminal link that emits a network error.
 */
function runWithNetworkError(
  errorLink: ApolloLink,
  networkError: Error,
): Promise<void> {
  const terminalLink = new ApolloLink(() =>
    new Observable((observer) => {
      observer.error(networkError);
    }),
  );

  const link = errorLink.concat(terminalLink);

  return new Promise<void>((resolve) => {
    execute(link, { query: TEST_QUERY }).subscribe({
      next: () => {},
      error: () => resolve(), // network errors surface as observable errors
      complete: resolve,
    });
  });
}

describe('Property 10: GraphQL error codes are propagated to the calling component', () => {
  let consoleErrorSpy: ReturnType<typeof vi.spyOn>;

  beforeEach(() => {
    consoleErrorSpy = vi.spyOn(console, 'error').mockImplementation(() => {});
  });

  afterEach(() => {
    consoleErrorSpy.mockRestore();
  });

  it('calls console.error for every GraphQL error regardless of code', async () => {
    await fc.assert(
      fc.asyncProperty(
        // Generate arrays of 1–5 errors with arbitrary string codes
        fc.array(
          fc.string({ minLength: 1, maxLength: 30 }).map((code) => makeGraphQLError(code)),
          { minLength: 1, maxLength: 5 },
        ),
        async (errors) => {
          consoleErrorSpy.mockClear();
          const errorLink = buildErrorLink();
          await runWithErrors(errorLink, errors);
          expect(consoleErrorSpy).toHaveBeenCalledTimes(errors.length);
        },
      ),
      { numRuns: 100 },
    );
  });

  it('calls onUnauthenticated exactly once per UNAUTHENTICATED error', async () => {
    await fc.assert(
      fc.asyncProperty(
        // Generate arrays of 1–5 errors, each with a known code
        fc.array(fc.constantFrom(...KNOWN_CODES), { minLength: 1, maxLength: 5 }),
        async (codes) => {
          consoleErrorSpy.mockClear();
          const handlers: Required<ErrorLinkHandlers> = {
            onUnauthenticated: vi.fn(),
            onNotFound: vi.fn(),
            onForbidden: vi.fn(),
          };
          const errorLink = buildErrorLink(handlers);
          const errors = codes.map(makeGraphQLError);
          await runWithErrors(errorLink, errors);

          const expectedCount = codes.filter((c) => c === 'UNAUTHENTICATED').length;
          expect(handlers.onUnauthenticated).toHaveBeenCalledTimes(expectedCount);
        },
      ),
      { numRuns: 100 },
    );
  });

  it('calls onNotFound exactly once per NOT_FOUND error', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.array(fc.constantFrom(...KNOWN_CODES), { minLength: 1, maxLength: 5 }),
        async (codes) => {
          consoleErrorSpy.mockClear();
          const handlers: Required<ErrorLinkHandlers> = {
            onUnauthenticated: vi.fn(),
            onNotFound: vi.fn(),
            onForbidden: vi.fn(),
          };
          const errorLink = buildErrorLink(handlers);
          const errors = codes.map(makeGraphQLError);
          await runWithErrors(errorLink, errors);

          const expectedCount = codes.filter((c) => c === 'NOT_FOUND').length;
          expect(handlers.onNotFound).toHaveBeenCalledTimes(expectedCount);
        },
      ),
      { numRuns: 100 },
    );
  });

  it('calls onForbidden exactly once per FORBIDDEN error', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.array(fc.constantFrom(...KNOWN_CODES), { minLength: 1, maxLength: 5 }),
        async (codes) => {
          consoleErrorSpy.mockClear();
          const handlers: Required<ErrorLinkHandlers> = {
            onUnauthenticated: vi.fn(),
            onNotFound: vi.fn(),
            onForbidden: vi.fn(),
          };
          const errorLink = buildErrorLink(handlers);
          const errors = codes.map(makeGraphQLError);
          await runWithErrors(errorLink, errors);

          const expectedCount = codes.filter((c) => c === 'FORBIDDEN').length;
          expect(handlers.onForbidden).toHaveBeenCalledTimes(expectedCount);
        },
      ),
      { numRuns: 100 },
    );
  });

  it('unknown error codes do not trigger any handler but still log via console.error', async () => {
    await fc.assert(
      fc.asyncProperty(
        // Generate codes that are NOT in the known set
        fc.array(
          fc.string({ minLength: 1, maxLength: 20 }).filter(
            (s) => !(KNOWN_CODES as readonly string[]).includes(s),
          ),
          { minLength: 1, maxLength: 5 },
        ),
        async (codes) => {
          consoleErrorSpy.mockClear();
          const handlers: Required<ErrorLinkHandlers> = {
            onUnauthenticated: vi.fn(),
            onNotFound: vi.fn(),
            onForbidden: vi.fn(),
          };
          const errorLink = buildErrorLink(handlers);
          const errors = codes.map(makeGraphQLError);
          await runWithErrors(errorLink, errors);

          expect(handlers.onUnauthenticated).not.toHaveBeenCalled();
          expect(handlers.onNotFound).not.toHaveBeenCalled();
          expect(handlers.onForbidden).not.toHaveBeenCalled();
          // But console.error must still have been called for each error
          expect(consoleErrorSpy).toHaveBeenCalledTimes(codes.length);
        },
      ),
      { numRuns: 100 },
    );
  });

  it('logs network errors via console.error and does not call GraphQL handlers', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.string({ minLength: 1, maxLength: 50 }).map((msg) => new Error(msg)),
        async (networkError) => {
          consoleErrorSpy.mockClear();
          const handlers: Required<ErrorLinkHandlers> = {
            onUnauthenticated: vi.fn(),
            onNotFound: vi.fn(),
            onForbidden: vi.fn(),
          };
          const errorLink = buildErrorLink(handlers);
          await runWithNetworkError(errorLink, networkError);

          expect(consoleErrorSpy).toHaveBeenCalledTimes(1);
          expect(handlers.onUnauthenticated).not.toHaveBeenCalled();
          expect(handlers.onNotFound).not.toHaveBeenCalled();
          expect(handlers.onForbidden).not.toHaveBeenCalled();
        },
      ),
      { numRuns: 100 },
    );
  });

  it('works with no handlers provided (default no-ops) without throwing', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.array(fc.constantFrom(...KNOWN_CODES), { minLength: 1, maxLength: 3 }),
        async (codes) => {
          consoleErrorSpy.mockClear();
          // No handlers — should not throw
          const errorLink = buildErrorLink();
          const errors = codes.map(makeGraphQLError);
          await expect(runWithErrors(errorLink, errors)).resolves.toBeUndefined();
          expect(consoleErrorSpy).toHaveBeenCalledTimes(codes.length);
        },
      ),
      { numRuns: 50 },
    );
  });
});
