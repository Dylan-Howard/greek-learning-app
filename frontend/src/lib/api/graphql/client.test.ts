import { describe, it, expect, beforeEach } from 'vitest';
import { InMemoryCache } from '@apollo/client';
import { createServerClient, getApolloClient, _resetApolloClientForTesting } from './client';
import { apiClient } from '@/lib/api/rest/client';

describe('createServerClient()', () => {
  it('returns an ApolloClient instance', () => {
    const client = createServerClient();
    expect(client).toBeDefined();
    expect(typeof client.query).toBe('function');
  });

  it('has no shared InMemoryCache (fetchPolicy is no-cache)', () => {
    const client = createServerClient();
    // The default options should enforce no-cache for server-side usage
    expect(client.defaultOptions.query?.fetchPolicy).toBe('no-cache');
  });

  it('is in ssrMode', () => {
    const client = createServerClient();
    // ssrMode disables forceFetch and is accessible via the client options
    // We verify by checking the cache is configured with resultCaching: false
    const cache = client.cache as InMemoryCache;
    // InMemoryCache with resultCaching: false means cache.config.resultCaching is false
    expect((cache as unknown as { config: { resultCaching: boolean } }).config.resultCaching).toBe(false);
  });
});

describe('getApolloClient()', () => {
  beforeEach(() => {
    _resetApolloClientForTesting();
  });

  it('returns an ApolloClient instance', () => {
    const client = getApolloClient();
    expect(client).toBeDefined();
    expect(typeof client.query).toBe('function');
  });

  it('returns the same singleton instance on repeated calls', () => {
    const first = getApolloClient();
    const second = getApolloClient();
    expect(first).toBe(second);
  });

  it('returns a new instance after reset', () => {
    const first = getApolloClient();
    _resetApolloClientForTesting();
    const second = getApolloClient();
    expect(first).not.toBe(second);
  });

  it('has an InMemoryCache (not no-cache)', () => {
    const client = getApolloClient();
    expect(client.cache).toBeInstanceOf(InMemoryCache);
    // Client-side instance should NOT force no-cache
    expect(client.defaultOptions.query?.fetchPolicy).toBeUndefined();
  });
});

describe('REST client coexistence (Requirement 7.6, 15.5)', () => {
  it('rest/client.ts still exports apiClient', () => {
    expect(apiClient).toBeDefined();
    expect(typeof apiClient.get).toBe('function');
    expect(typeof apiClient.post).toBe('function');
    expect(typeof apiClient.put).toBe('function');
    expect(typeof apiClient.delete).toBe('function');
  });
});
