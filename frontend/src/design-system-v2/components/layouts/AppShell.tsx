'use client';
// src/components/layouts/AppShell.tsx
// Main layout shell for all app pages.
// Desktop: fixed NavRail (72px) + scrollable content + optional fixed sidebar (280px).
// Mobile: scrollable content + fixed BottomNav (56px).
// MUI v7: no Hidden component — use sx display prop with breakpoints.

import React from 'react';
import Box from '@mui/material/Box';
import { tokens } from '@/design-system-v2/theme/theme';
import NavRail from '@/design-system-v2/components/nav/NavRail';
import BottomNav from '@/design-system-v2/components/nav/BottomNav';
import { type Tier } from '@/design-system-v2/components/nav/UserAvatarBadge';

interface Props {
  children:      React.ReactNode;
  sidebar?:      React.ReactNode;  // Only rendered on reader page
  userInitials?: string;
  xpPercent?:    number;
  tier?:         Tier;
}

export default function AppShell({
  children,
  sidebar,
  userInitials = 'GR',
  xpPercent    = 0,
  tier         = 'novice',
}: Props) {
  return (
    <Box sx={{ display: 'flex', minHeight: '100vh', bgcolor: tokens.color.bg }}>

      {/* Desktop NavRail — hidden on mobile (MUI v7: sx display, no Hidden) */}
      <Box sx={{ display: { xs: 'none', md: 'block' } }}>
        <NavRail
          userInitials={userInitials}
          xpPercent={xpPercent}
          tier={tier}
        />
      </Box>

      {/* Main content area — offset by navrail on desktop */}
      <Box
        component="main"
        sx={{
          flex:     1,
          ml:       { xs: 0, md: '72px' },       // navrail width
          mr:       sidebar ? { xs: 0, md: '280px' } : 0, // sidebar width
          mb:       { xs: '56px', md: 0 },        // bottom nav height on mobile
          minHeight: '100vh',
          overflowX: 'hidden',
        }}
      >
        {children}
      </Box>

      {/* Desktop sidebar */}
      {sidebar && (
        <Box
          sx={{
            display: { xs: 'none', md: 'flex' },
            width:   280,
            position: 'fixed',
            top:      0,
            right:    0,
            height:   '100vh',
            flexDirection: 'column',
            bgcolor:  tokens.color.surface,
            borderLeft: `1px solid ${tokens.color.border}`,
            zIndex:   1100,
          }}
        >
          {sidebar}
        </Box>
      )}

      {/* Mobile BottomNav — hidden on desktop */}
      <Box sx={{ display: { xs: 'block', md: 'none' } }}>
        <BottomNav />
      </Box>
    </Box>
  );
}
