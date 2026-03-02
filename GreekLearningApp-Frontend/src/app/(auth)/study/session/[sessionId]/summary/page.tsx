'use client';

import React, { useEffect, useState } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { Grid, Stack, Typography } from '@mui/material';
import { completeSession } from '@/lib/api/rest/study';
import { SessionSummaryDto } from '@/lib/types/api';
import { Button } from '@/components/ui';

export default function SummaryPage() {
  const router = useRouter();
  const params = useParams();
  const sessionIdParam = params?.sessionId;
  const sessionId = Array.isArray(sessionIdParam) ? sessionIdParam[0] : sessionIdParam;
  const [summary, setSummary] = useState<SessionSummaryDto | null>(null);

  useEffect(() => {
    if (!sessionId) return;
    completeSession(sessionId).then((result) => {
      if (result.ok) {
        setSummary(result.data);
      }
    });
  }, [sessionId]);

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ xs: 11, sm: 7 }}>
        <Stack spacing={3}>
          <Typography variant="h2">Session Summary</Typography>

          {!summary && <Typography>Loading summary...</Typography>}

          {summary && (
            <>
              <Typography variant="h4">
                Correct: {summary.correctCount} / {summary.totalReviewed}
              </Typography>
              <Typography variant="body1">
                Accuracy: {summary.correctPercentage.toFixed(1)}%
              </Typography>
              <Typography variant="body2">
                Again: {summary.ratings.Again ?? 0} • Hard: {summary.ratings.Hard ?? 0} • Good: {summary.ratings.Good ?? 0} • Easy: {summary.ratings.Easy ?? 0}
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
  );
}
