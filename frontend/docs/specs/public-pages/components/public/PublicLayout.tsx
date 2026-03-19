// src/components/public/PublicLayout.tsx
// Wraps all public/marketing pages with sticky header + footer.
// NOT the AppShell — no NavRail, no BottomNav.

import React from 'react';
import Box from '@mui/material/Box';
import LandingHeader from './LandingHeader';
import LandingFooter from './LandingFooter';

interface Props { children: React.ReactNode; }

export default function PublicLayout({ children }: Props) {
  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', minHeight: '100vh' }}>
      <LandingHeader />
      <Box component="main" sx={{ flex: 1, pt: '64px' /* header height */ }}>
        {children}
      </Box>
      <LandingFooter />
    </Box>
  );
}
