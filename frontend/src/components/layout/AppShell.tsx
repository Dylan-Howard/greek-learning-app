'use client';

import React from 'react';
import { useRouter } from 'next/navigation';
import { useClerk } from '@clerk/nextjs';
import Box from '@mui/material/Box';
import Tooltip from '@mui/material/Tooltip';
import IconButton from '@mui/material/IconButton';
import LogoutIcon from '@mui/icons-material/Logout';
import AppShellLayout from '@/design-system-v2/components/layouts/AppShell';
import { type Tier } from '@/design-system-v2/components/nav/UserAvatarBadge';
import { useUserContext } from '@/lib/types/domain/user';
import { getDefaultUserState } from '@/lib/api/rest/user';
import { _resetApolloClientForTesting } from '@/lib/api/graphql/client';
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
  const { user, setUser } = useUserContext();
  const { signOut } = useClerk();
  const router = useRouter();
  const totalExp = user?.totalExp ?? 0;
  const level = levelFromExperience(totalExp);

  async function handleSignOut(): Promise<void> {
    await signOut();
    _resetApolloClientForTesting();
    setUser(getDefaultUserState());
    router.push('/welcome');
  }

  return (
    <Box sx={{ position: 'relative' }}>
      <AppShellLayout
        sidebar={sidebar}
        userInitials={avatarInitial(user?.name)}
        xpPercent={experienceProgressPercent(totalExp)}
        tier={tierFromLevel(level)}
      >
        {children}
      </AppShellLayout>
      {/* Sign-out button — fixed at bottom of nav rail area */}
      <Tooltip title="Sign out" placement="right">
        <IconButton
          onClick={handleSignOut}
          aria-label="Sign out"
          size="small"
          sx={{
            position: 'fixed',
            bottom: { xs: 64, md: 16 },
            left: { xs: 'auto', md: 16 },
            right: { xs: 16, md: 'auto' },
            zIndex: 1300,
            bgcolor: 'background.paper',
            border: '1px solid',
            borderColor: 'divider',
            '&:hover': { bgcolor: 'action.hover' },
          }}
        >
          <LogoutIcon fontSize="small" />
        </IconButton>
      </Tooltip>
    </Box>
  );
}
