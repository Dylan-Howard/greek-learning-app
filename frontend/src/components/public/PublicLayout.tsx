'use client';

import React from 'react';
import Box from '@mui/material/Box';
import LandingHeader from './LandingHeader';
import LandingFooter from './LandingFooter';

interface Props { children: React.ReactNode; }

export default function PublicLayout({ children }: Props) {
  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', minHeight: '100vh' }}>
      <LandingHeader />
      <Box component="main" sx={{ flex: 1, pt: '64px' }}>
        {children}
      </Box>
      <LandingFooter />
    </Box>
  );
}
