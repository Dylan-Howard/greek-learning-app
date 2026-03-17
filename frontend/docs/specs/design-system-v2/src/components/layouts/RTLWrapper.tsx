'use client';
// src/components/layouts/RTLWrapper.tsx
// Provides RTL context for Arabic support.
// Wraps MUI theme with rtl direction and sets dir attribute on the DOM.
// All layout components consume useDirection() to conditionally swap
// flex-direction, margins, icon mirroring, etc.

import React, { createContext, useContext } from 'react';
import { createTheme, ThemeProvider } from '@mui/material/styles';
// MUI v7: StyledEngineProvider from '@mui/material/styles' (not '@mui/material')
import { StyledEngineProvider } from '@mui/material/styles';
import createCache from '@emotion/cache';
import { CacheProvider } from '@emotion/react';
import theme from '@/theme/theme';

type Direction = 'ltr' | 'rtl';

const DirectionContext = createContext<Direction>('ltr');

export function useDirection(): Direction {
  return useContext(DirectionContext);
}

interface Props {
  direction?: Direction;
  children: React.ReactNode;
}

export default function RTLWrapper({ direction = 'ltr', children }: Props) {
  const rtlTheme = React.useMemo(
    () => createTheme({ ...theme, direction }),
    [direction],
  );

  // Emotion cache with direction-aware insertion point
  const cache = React.useMemo(
    () =>
      createCache({
        key: direction === 'rtl' ? 'muirtl' : 'muiltr',
        stylisPlugins:
          direction === 'rtl'
            ? [require('stylis-plugin-rtl').default]
            : [],
      }),
    [direction],
  );

  return (
    <DirectionContext.Provider value={direction}>
      <CacheProvider value={cache}>
        <StyledEngineProvider injectFirst>
          <ThemeProvider theme={rtlTheme}>
            <div dir={direction}>{children}</div>
          </ThemeProvider>
        </StyledEngineProvider>
      </CacheProvider>
    </DirectionContext.Provider>
  );
}
