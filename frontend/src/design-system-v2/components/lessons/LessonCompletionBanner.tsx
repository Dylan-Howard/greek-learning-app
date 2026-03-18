'use client';
// src/components/lessons/LessonCompletionBanner.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import CheckCircleOutlineIcon from '@mui/icons-material/CheckCircleOutline';
import ArrowForwardIcon from '@mui/icons-material/ArrowForward';
import { tokens } from '@/design-system-v2/theme/theme';

interface Props {
  xpEarned:        number;
  nextLessonId?:   string;
  nextLessonTitle?: string;
  onNextLesson?:   (id: string) => void;
}

export default function LessonCompletionBanner({
  xpEarned,
  nextLessonId,
  nextLessonTitle,
  onNextLesson,
}: Props) {
  return (
    <Box
      role="region"
      aria-label="Lesson complete"
      sx={{
        mt:           4,
        p:            3,
        bgcolor:      tokens.color.primaryLight,
        border:       `1px solid ${tokens.color.primary}44`,
        borderRadius: tokens.radius.lg,
        display:      'flex',
        flexDirection: { xs: 'column', sm: 'row' },
        alignItems:   { xs: 'flex-start', sm: 'center' },
        gap:          2,
      }}
    >
      <CheckCircleOutlineIcon sx={{ fontSize: 36, color: tokens.color.primary, flexShrink: 0 }} />

      <Box sx={{ flex: 1 }}>
        <Typography variant="h3" sx={{ color: tokens.color.primaryDark, mb: 0.25 }}>
          Lesson complete!
        </Typography>
        <Typography variant="body2" sx={{ color: tokens.color.primary }}>
          You earned{' '}
          <Box
            component="span"
            sx={{ fontWeight: 700, color: tokens.color.xpGold, fontSize: '1rem' }}
          >
            +{xpEarned} XP
          </Box>
        </Typography>
      </Box>

      {nextLessonId && (
        <Button
          variant="contained"
          endIcon={<ArrowForwardIcon />}
          onClick={() => onNextLesson?.(nextLessonId)}
          sx={{
            bgcolor:  tokens.color.primary,
            '&:hover': { bgcolor: tokens.color.primaryDark },
            flexShrink: 0,
            whiteSpace: 'nowrap',
          }}
        >
          {nextLessonTitle ? `Next: ${nextLessonTitle}` : 'Next Lesson'}
        </Button>
      )}
    </Box>
  );
}
