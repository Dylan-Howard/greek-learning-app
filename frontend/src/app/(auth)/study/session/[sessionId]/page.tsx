'use client';

import React, { useEffect, useMemo, useState } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { Box, Grid, Stack, Typography } from '@mui/material';
import { AppShell } from '@/components/layout/AppShell';
import FlashCard from '@/design-system-v2/components/srs/FlashCard';
import SRSRatingButtons, { type SRSRating } from '@/design-system-v2/components/srs/SRSRatingButtons';
import SRSSessionProgress from '@/design-system-v2/components/srs/SRSSessionProgress';
import MultipleChoiceCard from '@/design-system-v2/components/srs/MultipleChoiceCard';
import { getNextCard, rateCard } from '@/lib/api/rest/study';
import { CardDto, Rating } from '@/lib/types/api';
import { getActiveDevUserId } from '@/lib/services/auth/devSession';
import { tokens } from '@/design-system-v2/theme/theme';

export default function ActiveSessionPage() {
  const router = useRouter();
  const params = useParams();
  const sessionIdParam = params?.sessionId;
  const sessionId = Array.isArray(sessionIdParam) ? sessionIdParam[0] : sessionIdParam;
  const [card, setCard] = useState<CardDto | null>(null);
  const [revealed, setRevealed] = useState(false);
  const [loading, setLoading] = useState(true);

  const intervals = useMemo(() => ({
    again: '—',
    hard: '—',
    good: '—',
    easy: '—',
  }), []);

  const loadNext = async () => {
    if (!sessionId) return;
    setLoading(true);
    const result = await getNextCard(sessionId, getActiveDevUserId());
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
    const result = await rateCard(sessionId, card.vocabularyId, { rating }, getActiveDevUserId());
    if (result.ok && result.data.sessionComplete) {
      router.push(`/study/session/${sessionId}/summary`);
      return;
    }
    await loadNext();
  };

  const handleAnswer = (correct: boolean) => {
    handleRate(correct ? 'Good' : 'Again');
  };

  const progressValue = card ? card.position : 0;

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Grid container justifyContent="center">
          <Grid size={{ xs: 12, sm: 8, md: 6 }}>
            <Stack spacing={3}>
              <Box>
                <SRSSessionProgress current={progressValue} total={card?.totalCards ?? 0} />
              </Box>

              {loading && <Typography>Loading...</Typography>}

              {!loading && card && card.interactionMode === 'Flip' && (
                <Stack spacing={2} alignItems="center">
                  <FlashCard
                    front={card.front.root}
                    back={{
                      definition: card.back.gloss,
                      parsing: card.front.partOfSpeech || '—',
                    }}
                    flipped={revealed}
                    onFlip={() => setRevealed((prev) => !prev)}
                    size="full"
                  />

                  <Box sx={{ width: '100%' }}>
                    <SRSRatingButtons
                      onRate={(rating: SRSRating) => handleRate(rating === 'again' ? 'Again' : rating === 'hard' ? 'Hard' : rating === 'good' ? 'Good' : 'Easy')}
                      intervals={intervals}
                      disabled={!revealed}
                    />
                  </Box>

                  {!revealed && (
                    <Typography variant="body2" sx={{ color: tokens.color.textMuted, textAlign: 'center', fontStyle: 'italic' }}>
                      Tap the card to reveal
                    </Typography>
                  )}
                </Stack>
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
      </Box>
    </AppShell>
  );
}
