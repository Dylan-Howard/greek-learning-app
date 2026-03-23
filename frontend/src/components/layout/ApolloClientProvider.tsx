'use client';

import { ApolloProvider } from '@apollo/client';
import { useAuth } from '@clerk/nextjs';
import { useRouter } from 'next/navigation';
import { useMemo, type ReactNode } from 'react';
import { getApolloClient, _resetApolloClientForTesting } from '@/lib/api/graphql/client';

interface ApolloClientProviderProps {
  children: ReactNode;
}

export function ApolloClientProvider({ children }: ApolloClientProviderProps) {
  const { getToken } = useAuth();
  const router = useRouter();

  const client = useMemo(() => {
    _resetApolloClientForTesting();

    const getTokenWithWarning = async (): Promise<string | null> => {
      const token = await getToken();
      if (!token && process.env.NODE_ENV === 'development') {
        console.warn('[Apollo] getToken() returned null — request sent without Authorization header');
      }
      return token;
    };

    return getApolloClient(getTokenWithWarning, {
      onUnauthenticated: () => {
        _resetApolloClientForTesting();
        router.push('/auth/login');
      },
    });
  }, [getToken, router]);

  return <ApolloProvider client={client}>{children}</ApolloProvider>;
}
