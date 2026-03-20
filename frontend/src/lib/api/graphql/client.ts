// frontend/src/lib/api/graphql/client.ts

import {
  ApolloClient,
  HttpLink,
  InMemoryCache,
  from,
  type NormalizedCacheObject,
} from '@apollo/client';
import { setContext } from '@apollo/client/link/context';

const GRAPHQL_URL =
  process.env.NEXT_PUBLIC_GRAPHQL_URL ?? 'http://localhost:5001/graphql';

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
 */
export function getApolloClient(
  getToken?: () => Promise<string | null>,
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

  _clientInstance = new ApolloClient({
    link: from([authLink, httpLink]),
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
