'use client';
// src/theme/ThemeProvider.tsx
// MUI v7 + Next.js App Router setup.
// Uses AppRouterCacheProvider from @mui/material-nextjs for proper SSR cache.
// enableCssLayer integrates with modern tools (Tailwind v4, CSS cascade layers).

import React from 'react';
import { AppRouterCacheProvider } from '@mui/material-nextjs/v15-appRouter';
import { ThemeProvider as MuiThemeProvider } from '@mui/material/styles';
import CssBaseline from '@mui/material/CssBaseline';
import theme from './theme';

interface Props {
  children: React.ReactNode;
}

export default function ThemeProvider({ children }: Props) {
  return (
    // enableCssLayer: MUI v7 opt-in — wraps MUI styles in a CSS layer
    // so they play nicely with Tailwind v4 and other layer-based tools
    <AppRouterCacheProvider options={{ enableCssLayer: true }}>
      <MuiThemeProvider theme={theme}>
        <CssBaseline />
        {children}
      </MuiThemeProvider>
    </AppRouterCacheProvider>
  );
}
