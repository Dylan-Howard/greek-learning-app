'use client';

import React, { useEffect, useState } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { Box, Button, Grid, Stack, Typography } from '@mui/material';
import { useCompleteStudySessionMutation } from '@/lib/api/graphql/generated';
import { useUserContext } from '@/lib/types/domain/user';
import { AppShell } from '@/components/layout/AppShell';

export default function SummaryPage() {
  const { awardExp, syncUser } = useUserContext();
  const router = useRouter();
  const params = useParams();
  const sessionIdParam = params?.sessionId;
  const sessionId = Array.isArray(sessionIdParam) ? sessionIdParam[0] : sessionIdParam;

  const [completeStudySession] = useCompleteStudySessionMutation();
  const [summaryLoaded, setSummaryLoaded] = useState(false);
  const [summaryData, setSummaryData] = useState<{
    totalReviewed: number;
    correctCount: number;
    correctPercentage: number;
    xpGained: number;
    totalExperience: number;
  } | null>(null);

  useEffect(() => {
    if (!sessionId) return;
    completeStudySession({ variables: { sessionId } }).then(async (result) => {
      const summary = result.data?.completeStudySession;
      if (summary) {
        setSummaryData(summary);
        awardExp(summary.xpGained, summary.totalExperience);
        await syncUser();
      }
      setSummaryLoaded(true);
    });
  }, [awardExp, sessionId, syncUser]);

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Grid container justifyContent="center">
          <Grid size={{ xs: 12, sm: 8, md: 6 }}>
            <Stack spacing={3}>
              <Typography variant="h2">Session Summary</Typography>

              {!summaryLoaded && <Typography>Loading summary...</Typography>}

              {summaryLoaded && summaryData && (
                <>
                  <Typography variant="h4">
                    Correct: {summaryData.correctCount} / {summaryData.totalReviewed}
                  </Typography>
                  <Typography variant="body1">
                    Accuracy: {summaryData.correctPercentage.toFixed(1)}%
                  </Typography>
                </>
              )}

              <Stack direction="row" spacing={2}>
                <Button variant="contained" onClick={() => router.push('/study/session')}>
                  Study Again
                </Button>
                <Button onClick={() => router.push('/study')}>
                  Back to Dashboard
                </Button>
              </Stack>
            </Stack>
          </Grid>
        </Grid>
      </Box>
    </AppShell>
  );
}
