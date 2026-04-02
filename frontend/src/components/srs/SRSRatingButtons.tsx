'use client';
// src/components/srs/SRSRatingButtons.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

export type SRSRating = 'again' | 'hard' | 'good' | 'easy';

const RATINGS: {
  id:      SRSRating;
  label:   string;
  color:   string;
  hover:   string;
}[] = [
  { id: 'again', label: 'Again', color: tokens.color.srsAgain, hover: '#991F1F' },
  { id: 'hard',  label: 'Hard',  color: tokens.color.srsHard,  hover: '#B34500' },
  { id: 'good',  label: 'Good',  color: tokens.color.srsGood,  hover: '#1B5E20' },
  { id: 'easy',  label: 'Easy',  color: tokens.color.srsEasy,  hover: '#004D40' },
];

interface Props {
  onRate:    (rating: SRSRating) => void;
  intervals: Record<SRSRating, string>;
  disabled?: boolean;
}

export default function SRSRatingButtons({ onRate, intervals, disabled = false }: Props) {
  return (
    <Box sx={{ display: 'flex', gap: 0.75, width: '100%' }}>
      {RATINGS.map(({ id, label, color, hover }) => (
        <Box
          key={id}
          sx={{ flex: 1, display: 'flex', flexDirection: 'column', alignItems: 'center', gap: 0.5 }}
        >
          <Button
            onClick={() => onRate(id)}
            disabled={disabled}
            fullWidth
            sx={{
              bgcolor:      color,
              color:        '#FFFFFF',
              borderRadius: tokens.radius.xs,
              fontWeight:   700,
              fontSize:     '0.8125rem',
              py:           0.75,
              minWidth:     0,
              '&:hover': { bgcolor: hover },
              '&:disabled': { bgcolor: `${color}66`, color: '#FFFFFF99' },
            }}
          >
            {label}
          </Button>
          <Typography
            sx={{ fontSize: '0.625rem', color: tokens.color.textMuted, lineHeight: 1 }}
          >
            {intervals[id]}
          </Typography>
        </Box>
      ))}
    </Box>
  );
}
