'use client';
// src/components/shared/ProgressChip.tsx

import React from 'react';
import Chip from '@mui/material/Chip';
import Box from '@mui/material/Box';
import { tokens } from '@/design-system-v2/theme/theme';

export type SRSStatus = 'unseen' | 'new' | 'due' | 'mastered';

const STATUS_CONFIG: Record<SRSStatus, { label: string; color: string; bg: string }> = {
  unseen:   { label: 'Unseen',   color: tokens.color.textMuted,     bg: tokens.color.surfaceAlt },
  new:      { label: 'New',      color: tokens.color.srsNew,        bg: `${tokens.color.srsNew}18` },
  due:      { label: 'Due',      color: tokens.color.srsAgain,      bg: `${tokens.color.srsAgain}18` },
  mastered: { label: 'Mastered', color: tokens.color.srsEasy,       bg: `${tokens.color.srsEasy}18` },
};

interface Props {
  status: SRSStatus;
  size?:  'small' | 'medium';
}

export default function ProgressChip({ status, size = 'small' }: Props) {
  const { label, color, bg } = STATUS_CONFIG[status];

  return (
    <Chip
      size={size}
      label={
        <Box sx={{ display: 'flex', alignItems: 'center', gap: 0.5 }}>
          <Box
            sx={{
              width:        6,
              height:       6,
              borderRadius: '50%',
              bgcolor:      color,
              flexShrink:   0,
            }}
          />
          {label}
        </Box>
      }
      variant="outlined"
      sx={{
        borderColor: color,
        color:       color,
        bgcolor:     bg,
        fontWeight:  600,
        fontSize:    '0.6875rem',
        height:      size === 'small' ? 20 : 24,
        '& .MuiChip-label': { px: 1 },
      }}
    />
  );
}
