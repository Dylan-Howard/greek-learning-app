'use client';

import React from 'react';
import Box from '@mui/material/Box';
import LinearProgress from '@mui/material/LinearProgress';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

export interface LessonTrackCardProps {
  title: string;
  description?: string | null;
  completedLessons: number;
  totalLessons: number;
  percentComplete: number;
  nextLessonTitle?: string | null;
  actions?: React.ReactNode;
}

export function LessonTrackCard({
  title,
  description,
  completedLessons,
  totalLessons,
  percentComplete,
  nextLessonTitle,
  actions,
}: LessonTrackCardProps) {
  return (
    <Box
      sx={{
        border: `1px solid ${tokens.color.border}`,
        borderRadius: tokens.radius.lg,
        bgcolor: tokens.color.bg,
        p: 2.5,
        display: 'flex',
        flexDirection: 'column',
        gap: 1.5,
        height: '100%',
        boxShadow: '0 1px 3px rgba(0,0,0,0.08)',
        transition: `box-shadow ${tokens.motion.fast} ${tokens.motion.ease}`,
        '&:hover': {
          boxShadow: '0 3px 8px rgba(0,0,0,0.10)',
        },
      }}
    >
      <Box>
        <Typography variant="h3" sx={{ mb: 0.5 }}>
          {title}
        </Typography>
        {description && (
          <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
            {description}
          </Typography>
        )}
      </Box>

      <Stack spacing={0.5}>
        <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
          Progress: {completedLessons}/{totalLessons}
        </Typography>
        <LinearProgress value={Math.min(100, Math.max(0, percentComplete))} variant="determinate" />
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          Next: {nextLessonTitle ?? 'Track completed'}
        </Typography>
      </Stack>

      {actions && (
        <Box sx={{ mt: 'auto' }}>
          {actions}
        </Box>
      )}
    </Box>
  );
}
