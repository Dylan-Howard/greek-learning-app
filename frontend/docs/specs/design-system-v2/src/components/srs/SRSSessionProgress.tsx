'use client';
// src/components/srs/SRSSessionProgress.tsx

import React from 'react';
import Box from '@mui/material/Box';
import LinearProgress from '@mui/material/LinearProgress';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

interface Props {
  current: number;
  total:   number;
}

export default function SRSSessionProgress({ current, total }: Props) {
  const pct = total > 0 ? Math.round((current / total) * 100) : 0;

  return (
    <Box sx={{ width: '100%' }}>
      <Box sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', mb: 0.75 }}>
        <Typography sx={{ fontSize: '0.625rem', fontWeight: 600, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em' }}>
          Progress
        </Typography>
        <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
          {current} / {total}
        </Typography>
      </Box>
      <LinearProgress
        variant="determinate"
        value={pct}
        sx={{
          height:  4,
          bgcolor: tokens.color.surfaceAlt,
          '& .MuiLinearProgress-bar': { bgcolor: tokens.color.primary },
        }}
      />
    </Box>
  );
}
