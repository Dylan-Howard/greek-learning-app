'use client';
// src/components/profile/StatCard.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/design-system-v2/theme/theme';

interface Props {
  value:    string | number;
  label:    string;
  icon:     React.ReactNode;
  color?:   string;
}

export default function StatCard({ value, label, icon, color }: Props) {
  return (
    <Box
      sx={{
        p:            2,
        border:       `1px solid ${tokens.color.border}`,
        borderRadius: tokens.radius.md,
        display:      'flex',
        flexDirection: 'column',
        gap:          0.5,
        position:     'relative',
        overflow:     'hidden',
      }}
    >
      {/* Icon top-right */}
      <Box
        sx={{
          position: 'absolute',
          top:      12,
          right:    12,
          color:    tokens.color.textMuted,
          '& svg':  { fontSize: 20 },
        }}
      >
        {icon}
      </Box>

      {/* Value */}
      <Typography
        sx={{
          fontFamily: '"Noto Sans", sans-serif',
          fontSize:   '1.75rem',
          fontWeight: 700,
          color:      color ?? tokens.color.primary,
          lineHeight: 1.2,
        }}
      >
        {typeof value === 'number' ? value.toLocaleString() : value}
      </Typography>

      {/* Label */}
      <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
        {label}
      </Typography>
    </Box>
  );
}
