'use client';
// src/components/shared/EmptyState.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import { tokens } from '@/theme/theme';

interface Props {
  icon?:        React.ReactNode;
  title:        string;
  description?: string;
  action?:      { label: string; onClick: () => void };
}

export default function EmptyState({ icon, title, description, action }: Props) {
  return (
    <Box
      sx={{
        display:        'flex',
        flexDirection:  'column',
        alignItems:     'center',
        justifyContent: 'center',
        textAlign:      'center',
        py:             10,
        px:             4,
        gap:            1.5,
      }}
    >
      {icon && (
        <Box sx={{ color: tokens.color.textMuted, '& svg': { fontSize: 48 } }}>
          {icon}
        </Box>
      )}
      <Typography variant="h3" sx={{ color: tokens.color.textPrimary }}>
        {title}
      </Typography>
      {description && (
        <Typography variant="body1" sx={{ color: tokens.color.textSecondary, maxWidth: 360 }}>
          {description}
        </Typography>
      )}
      {action && (
        <Button
          variant="contained"
          onClick={action.onClick}
          sx={{ mt: 1, bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark } }}
        >
          {action.label}
        </Button>
      )}
    </Box>
  );
}
