'use client';
// src/components/srs/FlashCard.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

interface Props {
  front:    string;            // Greek word
  back:     { definition: string; parsing: string };
  flipped:  boolean;
  onFlip:   () => void;
  size?:    'compact' | 'full'; // compact = sidebar, full = standalone session
}

export default function FlashCard({ front, back, flipped, onFlip, size = 'compact' }: Props) {
  const h = size === 'full' ? 220 : 160;
  const w = size === 'full' ? 340 : '100%';

  return (
    <Box
      onClick={onFlip}
      role="button"
      tabIndex={0}
      aria-label={flipped ? 'Card back — click to flip' : 'Card front — click to reveal'}
      onKeyDown={(e) => { if (e.key === 'Enter' || e.key === ' ') onFlip(); }}
      sx={{
        width:       w,
        height:      h,
        perspective: '800px',
        cursor:      'pointer',
        flexShrink:  0,
        '&:focus-visible': {
          outline:       `2px solid ${tokens.color.primary}`,
          outlineOffset: 3,
          borderRadius:  tokens.radius.lg,
        },
      }}
    >
      {/* Inner — rotates on flip */}
      <Box
        sx={{
          width:           '100%',
          height:          '100%',
          position:        'relative',
          transformStyle:  'preserve-3d',
          transform:       flipped ? 'rotateY(180deg)' : 'rotateY(0deg)',
          transition:      `transform ${tokens.motion.slow} ${tokens.motion.ease}`,
        }}
      >
        {/* Front face */}
        <Box
          sx={{
            position:          'absolute',
            inset:             0,
            backfaceVisibility: 'hidden',
            WebkitBackfaceVisibility: 'hidden',
            bgcolor:           tokens.color.bg,
            border:            `1px solid ${tokens.color.border}`,
            borderRadius:      tokens.radius.lg,
            boxShadow:         '0 3px 8px rgba(0,0,0,0.08)',
            display:           'flex',
            flexDirection:     'column',
            alignItems:        'center',
            justifyContent:    'center',
            gap:               1,
            p:                 2,
          }}
        >
          <Typography
            sx={{
              fontFamily: '"Noto Serif", serif',
              fontSize:   size === 'full' ? '2.25rem' : '1.875rem',
              lineHeight: 1.3,
              color:      tokens.color.textPrimary,
              textAlign:  'center',
            }}
          >
            {front}
          </Typography>
          <Typography
            sx={{
              fontSize:      '0.625rem',
              fontWeight:    600,
              color:         tokens.color.textMuted,
              textTransform: 'uppercase',
              letterSpacing: '0.08em',
            }}
          >
            tap to reveal
          </Typography>
        </Box>

        {/* Back face */}
        <Box
          sx={{
            position:          'absolute',
            inset:             0,
            backfaceVisibility: 'hidden',
            WebkitBackfaceVisibility: 'hidden',
            transform:         'rotateY(180deg)',
            bgcolor:           tokens.color.bg,
            border:            `1px solid ${tokens.color.border}`,
            borderRadius:      tokens.radius.lg,
            boxShadow:         '0 3px 8px rgba(0,0,0,0.08)',
            display:           'flex',
            flexDirection:     'column',
            alignItems:        'center',
            justifyContent:    'center',
            gap:               0.75,
            p:                 2.5,
          }}
        >
          <Typography
            sx={{
              fontSize:   size === 'full' ? '1.125rem' : '1rem',
              fontWeight: 600,
              color:      tokens.color.textPrimary,
              textAlign:  'center',
              lineHeight: 1.4,
            }}
          >
            {back.definition}
          </Typography>
          <Typography
            variant="body2"
            sx={{ color: tokens.color.textSecondary, textAlign: 'center' }}
          >
            {back.parsing}
          </Typography>
        </Box>
      </Box>
    </Box>
  );
}
