'use client';

import { ApolloProvider } from '@apollo/client';
import { useAuth } from '@clerk/nextjs';
import { useMemo, type ReactNode } from 'react';
import { getApolloClient, _resetApolloClientForTesting } from '@/lib/api/graphql/client';

interface ApolloClientProviderProps {
  children: ReactNode;
}

export function ApolloClientProvider({ children }: ApolloClientProviderProps) {
  const { getToken } = useAuth();

  // Reset singleton so the authLink captures the current getToken reference.
  // This runs once per mount (i.e. once per page load in the browser).
  const client = useMemo(() => {
    _resetApolloClientForTesting();
    return getApolloClient(() => getToken());
  }, [getToken]);

  return <ApolloProvider client={client}>{children}</ApolloProvider>;
}
