'use client';
// src/app/auth/signup/page.tsx

import React from 'react';
import { useRouter } from 'next/navigation';
import AuthShell from '@/design-system-v2/components/layouts/AuthShell';
import { SignUpForm } from '@/design-system-v2/components/auth/AuthForms';

export default function SignUpPage() {
  const router = useRouter();

  async function handleSignUp(email: string, password: string) {
    // TODO: integrate with your auth provider
    await new Promise((r) => setTimeout(r, 800));
    router.push('/read');
  }

  return (
    <AuthShell>
      <SignUpForm
        onSubmit={handleSignUp}
        onLogin={() => router.push('/auth/login')}
        onGuest={() => router.push('/read')}
      />
    </AuthShell>
  );
}
