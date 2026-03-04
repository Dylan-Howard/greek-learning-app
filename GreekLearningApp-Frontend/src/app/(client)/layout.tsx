'use client';

import { ReactNode } from 'react';
import ClientProviders from '@/components/layout/ClientProviders';

export default function ClientLayout({ children }: { children: ReactNode }) {
  return (
    <ClientProviders>{ children }</ClientProviders>
  );
}
