'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Grid,
  Typography,
} from '@mui/material';
import { useEffect, useMemo, useState } from 'react';
import { useRouter } from 'next/navigation';
import { AppShell } from '@/components/layout/AppShell';
import VocabSetCard, { type VocabSet } from '@/design-system-v2/components/vocab/VocabSetCard';
import { fetchVocabularySets } from '@/lib/api/rest/vocabulary';
import { VocabularySetDto } from '@/lib/types/api';
import { getActiveDevUserId } from '@/lib/services/auth/devSession';

export const dynamic = 'force-dynamic';

function VocabularySet() {
  const router = useRouter();
  const [sets, setSets] = useState<VocabularySetDto[]>([]);
  const [setsError, setSetsError] = useState<string | undefined>();

  useEffect(() => {
    const userId = getActiveDevUserId();
    fetchVocabularySets(userId).then((result) => {
      if (result.ok) {
        setSets(result.data);
        setSetsError(undefined);
      } else {
        setSets([]);
        setSetsError(result.error.message);
      }
    });
  }, []);

  const systemSets = useMemo(() => sets.filter((set: VocabularySetDto) => set.isSystem), [sets]);
  const customSets = useMemo(() => sets.filter((set: VocabularySetDto) => !set.isSystem), [sets]);

  const mapSet = (set: VocabularySetDto): VocabSet => ({
    id: String(set.id),
    title: set.title,
    description: set.description,
    wordCount: set.totalCount,
    mastered: set.knownCount,
    dueCount: set.learningCount,
    lastStudied: set.lastPracticed ?? null,
  });

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Vocabulary Sets</Typography>
        </Breadcrumbs>

        <Typography variant="h2" sx={{ mb: 3 }}>System Vocabulary Sets</Typography>
        {setsError && (
          <Typography color="error.main" sx={{ mb: 3 }}>Unable to load vocabulary sets: {setsError}</Typography>
        )}
        {systemSets.length === 0 && (
          <Typography variant="body1" sx={{ mb: 3 }}>No system sets are currently available.</Typography>
        )}
        <Grid container spacing={2} sx={{ mb: 4 }}>
          {systemSets.map((set) => (
            <Grid key={set.id} size={{ xs: 12, sm: 6, md: 4 }}>
              <VocabSetCard
                set={mapSet(set)}
                onClick={(setId) => router.push(`/vocabulary/sets/${setId}`)}
                onStudy={(setId) => router.push(`/study/session?setId=${setId}`)}
              />
            </Grid>
          ))}
        </Grid>

        <Typography variant="h2" sx={{ mb: 3 }}>Custom Vocabulary Sets</Typography>
        {customSets.length === 0 && (
          <Typography variant="body1" sx={{ mb: 3 }}>
            Create a custom set from the vocabulary page to start tracking your own list.
          </Typography>
        )}
        <Grid container spacing={2} sx={{ mb: 4 }}>
          {customSets.map((set) => (
            <Grid key={set.id} size={{ xs: 12, sm: 6, md: 4 }}>
              <VocabSetCard
                set={mapSet(set)}
                onClick={(setId) => router.push(`/vocabulary/sets/${setId}`)}
                onStudy={(setId) => router.push(`/study/session?setId=${setId}`)}
              />
            </Grid>
          ))}
        </Grid>

        <NextLink href="/vocabulary">Return to vocabulary</NextLink>
      </Box>
    </AppShell>
  );
}

export default VocabularySet;
