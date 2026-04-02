'use client';
// src/components/vocab/VocabSetCard.tsx

import React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardActions from '@mui/material/CardActions';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import LinearProgress from '@mui/material/LinearProgress';
import Chip from '@mui/material/Chip';
import Button from '@mui/material/Button';
import { tokens } from '@/theme/theme';

export interface VocabSet {
  id:          string;
  title:       string;
  description: string;
  wordCount:   number;
  mastered:    number;
  dueCount:    number;
  lastStudied: string | null; // ISO date string or null
}

interface Props {
  set:     VocabSet;
  onStudy: (setId: string) => void;
  onClick: (setId: string) => void;
}

export default function VocabSetCard({ set, onStudy, onClick }: Props) {
  const pct = set.wordCount > 0 ? Math.round((set.mastered / set.wordCount) * 100) : 0;

  const lastStudiedLabel = set.lastStudied
    ? `Last studied ${formatRelativeDate(set.lastStudied)}`
    : 'Not studied yet';

  return (
    <Card
      onClick={() => onClick(set.id)}
      sx={{
        cursor:        'pointer',
        display:       'flex',
        flexDirection: 'column',
        height:        '100%',
      }}
    >
      <CardContent sx={{ flex: 1, pb: 1 }}>
        {/* Title row */}
        <Box sx={{ display: 'flex', alignItems: 'flex-start', justifyContent: 'space-between', gap: 1, mb: 0.5 }}>
          <Typography variant="h2" sx={{ lineHeight: 1.3 }}>
            {set.title}
          </Typography>
          {set.dueCount > 0 && (
            <Chip
              label={`${set.dueCount} due`}
              size="small"
              sx={{
                bgcolor:   tokens.color.srsAgain,
                color:     '#FFFFFF',
                fontWeight: 700,
                fontSize:  '0.6875rem',
                flexShrink: 0,
              }}
            />
          )}
        </Box>

        {/* Description */}
        <Typography
          variant="body2"
          sx={{
            color:              tokens.color.textSecondary,
            mb:                 1.5,
            // 2-line clamp
            display:            '-webkit-box',
            WebkitLineClamp:    2,
            WebkitBoxOrient:    'vertical',
            overflow:           'hidden',
          }}
        >
          {set.description}
        </Typography>

        {/* Word count */}
        <Typography variant="body2" sx={{ color: tokens.color.textMuted, mb: 1.5 }}>
          {set.wordCount} words
        </Typography>

        {/* Progress */}
        <Box>
          <LinearProgress
            variant="determinate"
            value={pct}
            sx={{
              mb: 0.75,
              height: 6,
              bgcolor: tokens.color.surfaceAlt,
              '& .MuiLinearProgress-bar': { bgcolor: tokens.color.srsEasy },
            }}
          />
          <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
            {set.mastered} / {set.wordCount} mastered
          </Typography>
        </Box>
      </CardContent>

      <CardActions
        sx={{
          px:             2,
          pb:             2,
          pt:             1,
          justifyContent: 'space-between',
          alignItems:     'center',
        }}
        onClick={(e) => e.stopPropagation()} // prevent card click
      >
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          {lastStudiedLabel}
        </Typography>
        <Button
          variant="outlined"
          size="small"
          onClick={() => onStudy(set.id)}
          sx={{
            borderColor: tokens.color.border,
            color:       tokens.color.primary,
            borderRadius: tokens.radius.xs,
            '&:hover':   { borderColor: tokens.color.primary, bgcolor: tokens.color.primaryLight },
          }}
        >
          Study Set
        </Button>
      </CardActions>
    </Card>
  );
}

function formatRelativeDate(iso: string): string {
  const diff = Date.now() - new Date(iso).getTime();
  const days = Math.floor(diff / 86_400_000);
  if (days === 0) return 'today';
  if (days === 1) return 'yesterday';
  if (days < 7)  return `${days} days ago`;
  if (days < 30) return `${Math.floor(days / 7)} week${Math.floor(days / 7) > 1 ? 's' : ''} ago`;
  return `${Math.floor(days / 30)} month${Math.floor(days / 30) > 1 ? 's' : ''} ago`;
}
