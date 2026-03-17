'use client';
// src/app/auth/login/page.tsx

import React from 'react';
import { useRouter } from 'next/navigation';
import AuthShell from '@/components/layouts/AuthShell';
import { LoginForm } from '@/components/auth/AuthForms';

export default function LoginPage() {
  const router = useRouter();

  async function handleLogin(email: string, password: string) {
    // TODO: integrate with your auth provider
    await new Promise((r) => setTimeout(r, 800));
    router.push('/read');
  }

  return (
    <AuthShell>
      <LoginForm
        onSubmit={handleLogin}
        onSignUp={() => router.push('/auth/signup')}
        onGuest={() => router.push('/read')}
      />
    </AuthShell>
  );
}
