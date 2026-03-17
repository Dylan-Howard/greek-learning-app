'use client';
// src/components/layouts/AuthShell.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

interface Props {
  children: React.ReactNode;
}

export default function AuthShell({ children }: Props) {
  return (
    <Box
      sx={{
        minHeight:      '100vh',
        bgcolor:        tokens.color.bg,
        display:        'flex',
        flexDirection:  'column',
        alignItems:     'center',
        justifyContent: 'center',
        px:             3,
        // Subtle dot grid background
        backgroundImage: `radial-gradient(${tokens.color.border} 1px, transparent 1px)`,
        backgroundSize:  '24px 24px',
      }}
    >
      {/* Logo + wordmark */}
      <Box sx={{ display: 'flex', alignItems: 'center', gap: 1.5, mb: 4 }}>
        <Box
          sx={{
            width:          40,
            height:         40,
            borderRadius:   tokens.radius.md,
            bgcolor:        tokens.color.primary,
            color:          '#FFFFFF',
            display:        'flex',
            alignItems:     'center',
            justifyContent: 'center',
            fontFamily:     '"Noto Serif", serif',
            fontSize:       22,
          }}
        >
          α
        </Box>
        <Typography
          variant="h2"
          sx={{
            fontFamily: '"Noto Serif", serif',
            fontWeight: 400,
            color:      tokens.color.primaryDark,
            fontSize:   '1.25rem',
          }}
        >
          Greek NT Reader
        </Typography>
      </Box>

      {/* Auth card */}
      <Paper
        elevation={0}
        sx={{
          width:        '100%',
          maxWidth:     420,
          p:            { xs: 3, sm: 4 },
          borderRadius: tokens.radius.lg,
          border:       `1px solid ${tokens.color.border}`,
          boxShadow:    '0 3px 8px rgba(0,0,0,0.08)',
        }}
      >
        {children}
      </Paper>
    </Box>
  );
}
