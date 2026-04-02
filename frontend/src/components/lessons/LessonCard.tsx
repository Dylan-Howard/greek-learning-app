'use client';
// src/components/lessons/LessonCard.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Chip from '@mui/material/Chip';
import CheckCircleIcon    from '@mui/icons-material/CheckCircle';
import RadioButtonUncheckedIcon from '@mui/icons-material/RadioButtonUnchecked';
import { tokens } from '@/theme/theme';

export interface LessonMeta {
  id:         string;
  number:     number;
  title:      string;
  type:       'Grammar' | 'Vocabulary' | 'Culture';
  readTime:   number; // minutes
  completed:  boolean;
}

const TYPE_COLORS: Record<LessonMeta['type'], string> = {
  Grammar:    tokens.color.tierScholar,
  Vocabulary: tokens.color.tierApprentice,
  Culture:    tokens.color.tierMaster,
};

interface Props {
  lesson:  LessonMeta;
  onClick: (id: string) => void;
}

export function LessonCard({ lesson, onClick }: Props) {
  return (
    <Box
      onClick={() => onClick(lesson.id)}
      sx={{
        display:      'flex',
        alignItems:   'center',
        gap:          2,
        p:            2,
        border:       `1px solid ${tokens.color.border}`,
        borderRadius: tokens.radius.md,
        cursor:       'pointer',
        bgcolor:      tokens.color.bg,
        transition:   `all ${tokens.motion.fast} ${tokens.motion.ease}`,
        '&:hover': {
          borderColor: tokens.color.borderStrong,
          boxShadow:   '0 2px 6px rgba(0,0,0,0.06)',
        },
      }}
    >
      {/* Lesson number + completion */}
      <Box sx={{ position: 'relative', flexShrink: 0 }}>
        <Box
          sx={{
            width:          36,
            height:         36,
            borderRadius:   '50%',
            bgcolor:        lesson.completed ? tokens.color.srsGood : tokens.color.surfaceAlt,
            color:          lesson.completed ? '#FFFFFF' : tokens.color.textMuted,
            display:        'flex',
            alignItems:     'center',
            justifyContent: 'center',
            fontWeight:     700,
            fontSize:       '0.875rem',
            fontFamily:     '"Noto Sans"',
            transition:     `all ${tokens.motion.normal} ${tokens.motion.ease}`,
          }}
        >
          {lesson.completed
            ? <CheckCircleIcon sx={{ fontSize: 20, color: '#FFFFFF' }} />
            : lesson.number
          }
        </Box>
      </Box>

      {/* Title + meta */}
      <Box sx={{ flex: 1, minWidth: 0 }}>
        <Typography
          variant="h3"
          sx={{
            color:        lesson.completed ? tokens.color.textSecondary : tokens.color.textPrimary,
            fontSize:     '0.9375rem',
            overflow:     'hidden',
            textOverflow: 'ellipsis',
            whiteSpace:   'nowrap',
          }}
        >
          {lesson.title}
        </Typography>
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          {lesson.readTime} min read
        </Typography>
      </Box>

      {/* Type chip */}
      <Chip
        label={lesson.type}
        size="small"
        sx={{
          bgcolor:   `${TYPE_COLORS[lesson.type]}18`,
          color:     TYPE_COLORS[lesson.type],
          fontWeight: 600,
          fontSize:  '0.6875rem',
          flexShrink: 0,
        }}
      />
    </Box>
  );
}
