'use client';

import React, { useMemo, useState } from 'react';
import {
  Box,
  Button,
  Grid,
  IconButton,
  Paper,
  Stack,
  Typography,
} from '@mui/material';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import { CardDto } from '@/lib/types/api';

interface MultipleChoiceCardProps {
  card: CardDto;
  onAnswer: (correct: boolean) => void;
  disabled?: boolean;
}

export default function MultipleChoiceCard({ card, onAnswer, disabled = false }: MultipleChoiceCardProps) {
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
    <Paper elevation={4} sx={{ p: 4, minHeight: 280 }}>
      <Stack spacing={2} alignItems="center">
        <Typography variant="h3" sx={{ fontFamily: '"Noto Serif", serif' }}>
          {card.front.root}
        </Typography>
        {card.front.transliteration && (
          <Typography variant="body1">{card.front.transliteration}</Typography>
        )}
        <Typography variant="body2" color="text.secondary">
          {card.front.partOfSpeech ?? '—'} • {card.front.occurrences ?? 0} occurrences
        </Typography>
        <IconButton onClick={handleSpeak} aria-label="Speak Greek word">
          <VolumeUpIcon />
        </IconButton>
      </Stack>

      <Box sx={{ mt: 4 }}>
        <Grid container spacing={2}>
          {(card.choices ?? []).map((choice) => {
            const isSelected = selected === choice;
            const isCorrect = choice === correct;
            const color: 'primary' | 'success' | 'error' = !selected
              ? 'primary'
              : isSelected
                ? isCorrect
                  ? 'success'
                  : 'error'
                : 'primary';
            const variant = selected && isSelected ? 'contained' : 'outlined';
            return (
              <Grid key={choice} size={{ xs: 12, sm: 6 }}>
                <Button
                  fullWidth
                  color={color}
                  variant={variant as 'contained' | 'outlined'}
                  disabled={!!selected || disabled}
                  onClick={() => handleChoice(choice)}
                >
                  {choice}
                </Button>
              </Grid>
            );
          })}
        </Grid>
      </Box>
    </Paper>
  );
}
