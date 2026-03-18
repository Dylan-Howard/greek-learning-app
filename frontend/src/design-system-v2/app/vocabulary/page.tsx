'use client';
// src/app/vocabulary/page.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid';
import AppShell from '@/design-system-v2/components/layouts/AppShell';
import { PageHeader } from '@/design-system-v2/components/shared/PageHeader';
import VocabSetCard, { type VocabSet } from '@/design-system-v2/components/vocab/VocabSetCard';
import { VocabCardSkeleton } from '@/design-system-v2/components/shared/LoadingSkeleton';
import EmptyState from '@/design-system-v2/components/shared/EmptyState';
import ListAltOutlinedIcon from '@mui/icons-material/ListAltOutlined';
import { tokens } from '@/design-system-v2/theme/theme';

const DEMO_SETS: VocabSet[] = [
  { id: 'mounce-top-100', title: 'Mounce Top 100',      description: 'The 100 most frequent words in the Greek NT, covering over 60% of all occurrences.', wordCount: 100, mastered: 34, dueCount: 8, lastStudied: new Date(Date.now() - 2*86400000).toISOString() },
  { id: 'john-1',         title: 'John Chapter 1',      description: 'All vocabulary from the prologue of John — an ideal starting point for reading.',       wordCount: 48,  mastered: 20, dueCount: 5, lastStudied: new Date(Date.now() - 86400000).toISOString() },
  { id: 'verbs-present',  title: 'Present Tense Verbs', description: 'Core present active and middle/passive indicative verb forms for daily practice.',       wordCount: 60,  mastered: 12, dueCount: 0, lastStudied: null },
  { id: 'prepositions',   title: 'Prepositions',         description: 'All NT Greek prepositions with governing cases and primary semantic ranges.',             wordCount: 18,  mastered: 18, dueCount: 0, lastStudied: new Date(Date.now() - 7*86400000).toISOString() },
];

export default function VocabularyPage() {
  const [loading] = useState(false);

  return (
    <AppShell>
      <Box sx={{ p: { xs: 3, md: 4 }, maxWidth: 1100, mx: 'auto' }}>
        <PageHeader
          title="Vocabulary Sets"
          subtitle="Study curated word lists with spaced repetition"
          actions={
            <Button href="/vocabulary/master" variant="text" sx={{ color: tokens.color.primary, fontWeight: 600 }}>
              Browse All Words &#8594;
            </Button>
          }
        />
        {loading ? (
          <Grid container spacing={3}>
            {[1,2,3,4].map((i) => (
              <Grid key={i} size={{ xs: 12, sm: 6 }}>
                <VocabCardSkeleton />
              </Grid>
            ))}
          </Grid>
        ) : DEMO_SETS.length === 0 ? (
          <EmptyState
            icon={<ListAltOutlinedIcon />}
            title="No vocabulary sets yet"
            description="Vocabulary sets will appear here as you progress through lessons."
          />
        ) : (
          <Grid container spacing={3}>
            {DEMO_SETS.map((set) => (
              <Grid key={set.id} size={{ xs: 12, sm: 6 }}>
                <VocabSetCard
                  set={set}
                  onStudy={(_id) => { /* navigate to study session */ }}
                  onClick={(_id) => { /* navigate to set detail */ }}
                />
              </Grid>
            ))}
          </Grid>
        )}
      </Box>
    </AppShell>
  );
}
