'use client';

import React, { useEffect, useState } from 'react';
import { useRouter } from 'next/navigation';
import { Box, Grid, Typography } from '@mui/material';
import SessionConfigPanel from '@/design-system-v2/components/srs/SessionConfigPanel';
import { startSession } from '@/lib/api/rest/study';
import { fetchVocabularySets } from '@/lib/api/rest/vocabulary';
import { StartSessionRequest, VocabularySetDto } from '@/lib/types/api';
import { getActiveDevUserId } from '@/lib/services/auth/devSession';
import { AppShell } from '@/components/layout/AppShell';

export default function SessionConfigPage() {
  const router = useRouter();
  const [sets, setSets] = useState<VocabularySetDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [config, setConfig] = useState<StartSessionRequest>({
    cardCount: 10,
    pool: 'Mixed',
    direction: 'GreekToEnglish',
    mode: 'Mix',
    source: 'StandardStudy',
    vocabularySetId: null,
  });

  useEffect(() => {
    fetchVocabularySets(getActiveDevUserId()).then((result) => {
      if (result.ok) {
        setSets(result.data);
      }
    });
  }, []);

  useEffect(() => {
    const setIdParam = new URLSearchParams(window.location.search).get('setId');
    if (!setIdParam) {
      return;
    }
    const parsed = Number.parseInt(setIdParam, 10);
    if (Number.isNaN(parsed)) {
      return;
    }
    setConfig((prev) => ({ ...prev, vocabularySetId: parsed }));
  }, []);

  const handleStart = async () => {
    setLoading(true);
    const result = await startSession(config, getActiveDevUserId());
    setLoading(false);
    if (result.ok) {
      router.push(`/study/session/${result.data.id}`);
    }
  };

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Grid container justifyContent="center">
          <Grid size={{ xs: 12, sm: 8, md: 6 }}>
            <Typography variant="h2" sx={{ mb: 4 }}>Study Session</Typography>
            <SessionConfigPanel
              sets={sets}
              config={config}
              onChange={setConfig}
              onStart={handleStart}
              disabled={loading}
            />
          </Grid>
        </Grid>
      </Box>
    </AppShell>
  );
}
