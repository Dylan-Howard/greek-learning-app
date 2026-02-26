'use client';

import React from 'react';
import {
  Box,
  Button,
  IconButton,
  Paper,
  Stack,
  Typography,
} from '@mui/material';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import { CardDto } from '@/lib/types/api';
import RatingButtons from '@/components/features/study/RatingButtons';

interface FlashCardProps {
  card: CardDto;
  revealed: boolean;
  onReveal: () => void;
  onRate: (rating: 'Again' | 'Hard' | 'Good' | 'Easy') => void;
  disabled?: boolean;
}

export default function FlashCard({
  card,
  revealed,
  onReveal,
  onRate,
  disabled = false,
}: FlashCardProps) {
  const handleSpeak = () => {
    if (typeof window === 'undefined') return;
    const speakText = card.direction === 'EnglishToGreek' ? card.back.gloss : card.front.root;
    const utterance = new SpeechSynthesisUtterance(speakText);
    utterance.lang = 'el-GR';
    window.speechSynthesis.speak(utterance);
  };

  return (
    <Paper elevation={4} sx={{ p: 4, minHeight: 280, perspective: 1000 }}>
      <Box
        sx={{
          position: 'relative',
          transformStyle: 'preserve-3d',
          transition: 'transform 0.6s',
          transform: revealed ? 'rotateY(180deg)' : 'rotateY(0deg)',
          minHeight: 200,
        }}
      >
        <Box
          sx={{
            position: 'absolute',
            width: '100%',
            backfaceVisibility: 'hidden',
          }}
        >
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
        </Box>
        <Box
          sx={{
            position: 'absolute',
            width: '100%',
            backfaceVisibility: 'hidden',
            transform: 'rotateY(180deg)',
          }}
        >
          <Stack spacing={2} alignItems="center">
            <Typography variant="h4">{card.back.gloss}</Typography>
          </Stack>
        </Box>
      </Box>

      <Stack spacing={2} sx={{ mt: 4 }} alignItems="center">
        {!revealed && (
          <Button variant="contained" onClick={onReveal} disabled={disabled}>
            Show Answer
          </Button>
        )}
        <RatingButtons onRate={onRate} disabled={!revealed || disabled} />
      </Stack>
    </Paper>
  );
}
