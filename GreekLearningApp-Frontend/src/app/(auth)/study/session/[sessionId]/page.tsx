'use client';

import React, { useEffect, useState } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { Box, Grid, LinearProgress, Stack, Typography } from '@mui/material';
import FlashCard from '@/components/features/study/FlashCard';
import MultipleChoiceCard from '@/components/features/study/MultipleChoiceCard';
import { getNextCard, rateCard } from '@/lib/api/rest/study';
import { CardDto, Rating } from '@/lib/types/api';

export default function ActiveSessionPage() {
  const router = useRouter();
  const params = useParams();
  const sessionIdParam = params?.sessionId;
  const sessionId = Array.isArray(sessionIdParam) ? sessionIdParam[0] : sessionIdParam;
  const [card, setCard] = useState<CardDto | null>(null);
  const [revealed, setRevealed] = useState(false);
  const [loading, setLoading] = useState(true);

  const loadNext = async () => {
    if (!sessionId) return;
    setLoading(true);
    const result = await getNextCard(sessionId);
    if (result.ok) {
      setCard(result.data);
      setRevealed(false);
    } else {
      setCard(null);
    }
    setLoading(false);
  };

  useEffect(() => {
    if (sessionId) {
      loadNext();
    }
  }, [sessionId]);

  const handleRate = async (rating: Rating) => {
    if (!card) return;
    if (!sessionId) return;
    const result = await rateCard(sessionId, card.vocabularyId, { rating });
    if (result.ok && result.data.sessionComplete) {
      router.push(`/study/session/${sessionId}/summary`);
      return;
    }
    await loadNext();
  };

  const handleAnswer = (correct: boolean) => {
    handleRate(correct ? 'Good' : 'Again');
  };

  const progressValue = card ? (card.position / card.totalCards) * 100 : 0;

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ xs: 11, sm: 7 }}>
        <Stack spacing={3}>
          <Box>
            <LinearProgress variant="determinate" value={progressValue} />
            {card && (
              <Typography variant="body2" sx={{ mt: 1 }}>
                Card {card.position} of {card.totalCards}
              </Typography>
            )}
          </Box>

          {loading && <Typography>Loading...</Typography>}

          {!loading && card && card.interactionMode === 'Flip' && (
            <FlashCard
              card={card}
              revealed={revealed}
              onReveal={() => setRevealed(true)}
              onRate={handleRate}
            />
          )}

          {!loading && card && card.interactionMode === 'MultipleChoice' && (
            <MultipleChoiceCard card={card} onAnswer={handleAnswer} />
          )}

          {!loading && !card && (
            <Typography>No cards available for this session.</Typography>
          )}
        </Stack>
      </Grid>
    </Grid>
  );
}
