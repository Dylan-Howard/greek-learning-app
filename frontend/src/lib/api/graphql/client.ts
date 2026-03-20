// frontend/src/lib/api/graphql/client.ts

import {
  ApolloClient,
  HttpLink,
  InMemoryCache,
  from,
  type NormalizedCacheObject,
} from '@apollo/client';
import { onError } from '@apollo/client/link/error';
import { setContext } from '@apollo/client/link/context';

const GRAPHQL_URL =
  process.env.NEXT_PUBLIC_GRAPHQL_URL ?? 'http://localhost:5001/graphql';

// ---------------------------------------------------------------------------
// Known GraphQL error extension codes
// ---------------------------------------------------------------------------

export type GraphQLErrorCode = 'UNAUTHENTICATED' | 'NOT_FOUND' | 'FORBIDDEN';

/**
 * Callbacks that the errorLink uses to trigger UI-level side effects.
 * Defaults are no-ops; the ApolloProvider should override them with real
 * navigation / state-setter functions.
 */
export interface ErrorLinkHandlers {
  onUnauthenticated?: () => void;
  onNotFound?: () => void;
  onForbidden?: () => void;
}

/**
 * Builds an Apollo `errorLink` that:
 *  - Logs every error via `console.error` (matching the pattern in rest/client.ts)
 *  - Calls the appropriate handler for UNAUTHENTICATED / NOT_FOUND / FORBIDDEN
 *  - Surfaces network errors through Apollo's standard `error` return value
 */
export function buildErrorLink(handlers: ErrorLinkHandlers = {}) {
  return onError(({ graphQLErrors, networkError, operation }) => {
    if (graphQLErrors) {
      for (const err of graphQLErrors) {
        const code = (err.extensions?.code as string | undefined) ?? '';
        console.error(`GraphQL Error [${operation.operationName ?? 'unknown'}]:`, err);

        if (code === 'UNAUTHENTICATED') {
          handlers.onUnauthenticated?.();
        } else if (code === 'NOT_FOUND') {
          handlers.onNotFound?.();
        } else if (code === 'FORBIDDEN') {
          handlers.onForbidden?.();
        }
      }
    }

    if (networkError) {
      console.error(`Network Error [${operation.operationName ?? 'unknown'}]:`, networkError);
    }
  });
}

// ---------------------------------------------------------------------------
// Server-side client — plain HttpLink, no InMemoryCache (mirrors rest/client.ts)
// ---------------------------------------------------------------------------

export function createServerClient(): ApolloClient<NormalizedCacheObject> {
  return new ApolloClient({
    link: new HttpLink({ uri: GRAPHQL_URL, fetch }),
    // Intentionally no InMemoryCache for server-side usage
    cache: new InMemoryCache({ resultCaching: false }),
    ssrMode: true,
    defaultOptions: {
      query: { fetchPolicy: 'no-cache' },
    },
  });
}

// ---------------------------------------------------------------------------
// Client-side singleton — InMemoryCache + authLink that injects Clerk JWT
// ---------------------------------------------------------------------------

let _clientInstance: ApolloClient<NormalizedCacheObject> | null = null;

/**
 * Returns (or creates) the singleton Apollo Client for use in Client Components.
 *
 * @param getToken - async function that resolves the Clerk JWT; typically
 *   `useAuth().getToken` called from a wrapper component.  When omitted the
 *   client is created without auth (useful for testing / unauthenticated paths).
 * @param errorHandlers - optional callbacks for UNAUTHENTICATED / NOT_FOUND /
 *   FORBIDDEN error codes; defaults to no-ops.
 */
export function getApolloClient(
  getToken?: () => Promise<string | null>,
  errorHandlers?: ErrorLinkHandlers,
): ApolloClient<NormalizedCacheObject> {
  if (_clientInstance) {
    return _clientInstance;
  }

  const httpLink = new HttpLink({ uri: GRAPHQL_URL });

  const authLink = setContext(async (_, { headers }: { headers?: Record<string, string> }) => {
    const token = getToken ? await getToken() : null;
    return {
      headers: {
        ...headers,
        ...(token ? { Authorization: `Bearer ${token}` } : {}),
      },
    };
  });

  const errorLink = buildErrorLink(errorHandlers);

  _clientInstance = new ApolloClient({
    link: from([errorLink, authLink, httpLink]),
    cache: new InMemoryCache(),
  });

  return _clientInstance;
}

/**
 * Resets the singleton — intended for use in tests only.
 * @internal
 */
export function _resetApolloClientForTesting(): void {
  _clientInstance = null;
}
