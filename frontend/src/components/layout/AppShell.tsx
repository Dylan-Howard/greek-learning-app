'use client';

import React from 'react';
import AppShellLayout from '@/design-system-v2/components/layouts/AppShell';
import { type Tier } from '@/design-system-v2/components/nav/UserAvatarBadge';
import { useUserContext } from '@/lib/types/domain/user';
import {
  avatarInitial,
  experienceProgressPercent,
  levelFromExperience,
} from '@/lib/services/user/gamification';

export interface AppShellProps {
  children: React.ReactNode;
  sidebar?: React.ReactNode;
}

function tierFromLevel(level: number): Tier {
  if (level < 5) return 'novice';
  if (level < 10) return 'apprentice';
  if (level < 20) return 'scholar';
  return 'master';
}

export function AppShell({ children, sidebar }: AppShellProps) {
  const { user } = useUserContext();
  const totalExp = user?.totalExp ?? 0;
  const level = levelFromExperience(totalExp);

  return (
    <AppShellLayout
      sidebar={sidebar}
      userInitials={avatarInitial(user?.name)}
      xpPercent={experienceProgressPercent(totalExp)}
      tier={tierFromLevel(level)}
    >
      {children}
    </AppShellLayout>
  );
}
