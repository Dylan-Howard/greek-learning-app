'use client';
// src/components/srs/SRSStudyPanel.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import Divider from '@mui/material/Divider';
import CloseIcon from '@mui/icons-material/Close';
import { tokens } from '@/design-system-v2/theme/theme';
import FlashCard from './FlashCard';
import SRSRatingButtons, { type SRSRating } from './SRSRatingButtons';
import SRSSessionProgress from './SRSSessionProgress';

export interface SRSCard {
  id:          string;
  front:       string;
  back:        { definition: string; parsing: string };
  intervals:   Record<SRSRating, string>;
}

interface Props {
  cards:    SRSCard[];
  onRate:   (cardId: string, rating: SRSRating) => void;
  onClose:  () => void;
  size?:    'compact' | 'full';
}

export default function SRSStudyPanel({ cards, onRate, onClose, size = 'compact' }: Props) {
  const [index,   setIndex]   = useState(0);
  const [flipped, setFlipped] = useState(false);

  const card = cards[index];

  function handleRate(rating: SRSRating) {
    if (!card) return;
    onRate(card.id, rating);
    setFlipped(false);
    setIndex((i) => i + 1);
  }

  // Session complete
  if (!card || index >= cards.length) {
    return (
      <Box
        sx={{
          flex:           1,
          display:        'flex',
          flexDirection:  'column',
          alignItems:     'center',
          justifyContent: 'center',
          p:              3,
          gap:            1.5,
          textAlign:      'center',
        }}
      >
        <Typography sx={{ fontSize: '2rem' }}>🎉</Typography>
        <Typography variant="h3" sx={{ color: tokens.color.textPrimary }}>
          Session complete!
        </Typography>
        <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
          You reviewed {cards.length} card{cards.length !== 1 ? 's' : ''}.
        </Typography>
        <Box
          component="button"
          onClick={onClose}
          sx={{
            mt:           1,
            px:           2,
            py:           0.75,
            border:       `1px solid ${tokens.color.border}`,
            borderRadius: tokens.radius.sm,
            bgcolor:      'transparent',
            cursor:       'pointer',
            fontSize:     '0.875rem',
            color:        tokens.color.textSecondary,
            '&:hover':    { bgcolor: tokens.color.surfaceAlt },
          }}
        >
          Return to reader
        </Box>
      </Box>
    );
  }

  return (
    <Box
      sx={{
        display:       'flex',
        flexDirection: 'column',
        height:        '100%',
        p:             2,
        gap:           2,
      }}
    >
      {/* Header */}
      <Box sx={{ display: 'flex', alignItems: 'center', justifyContent: 'space-between' }}>
        <Typography
          sx={{
            fontSize:      '0.625rem',
            fontWeight:    600,
            color:         tokens.color.textMuted,
            textTransform: 'uppercase',
            letterSpacing: '0.08em',
          }}
        >
          Study Session
        </Typography>
        <IconButton
          size="small"
          onClick={onClose}
          aria-label="Exit study session"
          sx={{ color: tokens.color.textMuted, '&:hover': { color: tokens.color.textPrimary } }}
        >
          <CloseIcon fontSize="small" />
        </IconButton>
      </Box>

      {/* Progress */}
      <SRSSessionProgress current={index} total={cards.length} />

      <Divider />

      {/* Flashcard */}
      <Box sx={{ flex: 1, display: 'flex', flexDirection: 'column', gap: 2, justifyContent: 'center' }}>
        <FlashCard
          front={card.front}
          back={card.back}
          flipped={flipped}
          onFlip={() => setFlipped((f) => !f)}
          size={size}
        />

        {/* Rating buttons — only shown after flip */}
        <Box
          sx={{
            opacity:    flipped ? 1 : 0,
            pointerEvents: flipped ? 'auto' : 'none',
            transition: `opacity ${tokens.motion.normal} ${tokens.motion.ease}`,
          }}
        >
          <SRSRatingButtons
            onRate={handleRate}
            intervals={card.intervals}
            disabled={!flipped}
          />
        </Box>

        {/* Hint when not flipped */}
        {!flipped && (
          <Typography
            variant="body2"
            sx={{ color: tokens.color.textMuted, textAlign: 'center', fontStyle: 'italic' }}
          >
            Tap the card to reveal
          </Typography>
        )}
      </Box>
    </Box>
  );
}
