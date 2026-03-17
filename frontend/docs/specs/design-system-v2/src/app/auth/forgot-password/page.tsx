'use client';
// src/app/auth/forgot-password/page.tsx

import React from 'react';
import { useRouter } from 'next/navigation';
import AuthShell from '@/components/layouts/AuthShell';
import { ForgotPasswordForm } from '@/components/auth/AuthForms';

export default function ForgotPasswordPage() {
  const router = useRouter();

  async function handleSubmit(email: string) {
    // TODO: trigger password reset email via auth provider
    await new Promise((r) => setTimeout(r, 800));
  }

  return (
    <AuthShell>
      <ForgotPasswordForm
        onSubmit={handleSubmit}
        onBack={() => router.push('/auth/login')}
      />
    </AuthShell>
  );
}
