'use client';

import React from 'react';
import Box from '@mui/material/Box';
import LinearProgress from '@mui/material/LinearProgress';
import Typography from '@mui/material/Typography';
import { Card, type CardProps } from '@/components/shared/Card';
import { tokens } from '@/theme/theme';

export interface ProgressCardProps extends CardProps {
  progress: number;
  progressLabel?: string;
  progressColor?: 'primary' | 'secondary' | 'success' | 'error' | 'warning' | 'info';
}

export function ProgressCard({
  progress,
  progressLabel,
  progressColor = 'primary',
  children,
  ...cardProps
}: ProgressCardProps) {
  return (
    <Card {...cardProps}>
      {children}
      <Box sx={{ px: 2, pb: 2 }}>
        <Box sx={{ display: 'flex', justifyContent: 'space-between', mb: 1 }}>
          <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
            {progressLabel || 'Progress'}
          </Typography>
          <Typography variant="body2" sx={{ fontWeight: 600 }}>
            {Math.round(progress)}%
          </Typography>
        </Box>
        <LinearProgress
          variant="determinate"
          value={progress}
          color={progressColor}
        />
      </Box>
    </Card>
  );
}
