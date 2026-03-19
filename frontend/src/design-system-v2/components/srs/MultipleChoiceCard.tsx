'use client';

import React, { useMemo, useState } from 'react';
import {
  Box,
  Button,
  Grid,
  IconButton,
  Stack,
  Typography,
} from '@mui/material';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import { tokens } from '@/design-system-v2/theme/theme';
import { CardDto } from '@/lib/types/api';

interface Props {
  card: CardDto;
  onAnswer: (correct: boolean) => void;
  disabled?: boolean;
}

export default function MultipleChoiceCard({ card, onAnswer, disabled = false }: Props) {
  const [selected, setSelected] = useState<string | null>(null);
  const correct = useMemo(() => card.back.gloss, [card.back.gloss]);

  const handleSpeak = () => {
    if (typeof window === 'undefined') return;
    const speakText = card.direction === 'EnglishToGreek' ? card.back.gloss : card.front.root;
    const utterance = new SpeechSynthesisUtterance(speakText);
    utterance.lang = 'el-GR';
    window.speechSynthesis.speak(utterance);
  };

  const handleChoice = (choice: string) => {
    if (selected || disabled) return;
    setSelected(choice);
    const isCorrect = choice === correct;
    setTimeout(() => onAnswer(isCorrect), 800);
  };

  return (
    <Box
      sx={{
        p: 3,
        border: `1px solid ${tokens.color.border}`,
        borderRadius: tokens.radius.lg,
        bgcolor: tokens.color.bg,
        boxShadow: '0 3px 8px rgba(0,0,0,0.08)',
      }}
    >
      <Stack spacing={1.5} alignItems="center">
        <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: '2rem' }}>
          {card.front.root}
        </Typography>
        {card.front.transliteration && (
          <Typography variant="body1" sx={{ color: tokens.color.textSecondary }}>
            {card.front.transliteration}
          </Typography>
        )}
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          {card.front.partOfSpeech ?? '—'} • {card.front.occurrences ?? 0} occurrences
        </Typography>
        <IconButton onClick={handleSpeak} aria-label="Speak Greek word">
          <VolumeUpIcon />
        </IconButton>
      </Stack>

      <Box sx={{ mt: 3 }}>
        <Grid container spacing={2}>
          {(card.choices ?? []).map((choice) => {
            const isSelected = selected === choice;
            const isCorrect = choice === correct;
            const color = !selected
              ? tokens.color.primary
              : isSelected
                ? isCorrect
                  ? tokens.color.srsGood
                  : tokens.color.srsAgain
                : tokens.color.primary;
            const variant = selected && isSelected ? 'contained' : 'outlined';
            return (
              <Grid key={choice} size={{ xs: 12, sm: 6 }}>
                <Button
                  fullWidth
                  variant={variant as 'contained' | 'outlined'}
                  disabled={!!selected || disabled}
                  onClick={() => handleChoice(choice)}
                  sx={{
                    borderColor: color,
                    color: variant === 'outlined' ? color : '#FFFFFF',
                    bgcolor: variant === 'contained' ? color : 'transparent',
                    '&:hover': {
                      borderColor: color,
                      bgcolor: variant === 'contained' ? color : tokens.color.primaryLight,
                    },
                  }}
                >
                  {choice}
                </Button>
              </Grid>
            );
          })}
        </Grid>
      </Box>
    </Box>
  );
}
