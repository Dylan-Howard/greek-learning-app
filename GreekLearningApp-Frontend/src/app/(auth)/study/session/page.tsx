'use client';

import React, { useEffect, useState } from 'react';
import { useRouter } from 'next/navigation';
import { Grid, Typography } from '@mui/material';
import SessionConfig from '@/components/features/study/SessionConfig';
import { startSession } from '@/lib/api/rest/study';
import { fetchVocabularySets } from '@/lib/api/rest/vocabulary';
import { StartSessionRequest, VocabularySetDto } from '@/lib/types/api';

export default function SessionConfigPage() {
  const router = useRouter();
  const [sets, setSets] = useState<VocabularySetDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [config, setConfig] = useState<StartSessionRequest>({
    cardCount: 10,
    pool: 'Mixed',
    direction: 'GreekToEnglish',
    mode: 'Mix',
    vocabularySetId: null,
  });

  useEffect(() => {
    fetchVocabularySets().then((result) => {
      if (result.ok) {
        setSets(result.data);
      }
    });
  }, []);

  const handleStart = async () => {
    setLoading(true);
    const result = await startSession(config);
    setLoading(false);
    if (result.ok) {
      router.push(`/study/session/${result.data.id}`);
    }
  };

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ xs: 11, sm: 7 }}>
        <Typography variant="h2" sx={{ mb: 4 }}>Study Session</Typography>
        <SessionConfig
          sets={sets}
          config={config}
          onChange={setConfig}
          onStart={handleStart}
          disabled={loading}
        />
      </Grid>
    </Grid>
  );
}
