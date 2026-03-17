'use client';
// src/app/study/page.tsx
// Standalone full-screen study session (all due cards, not chapter-scoped).

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import AppShell from '@/components/layouts/AppShell';
import SRSStudyPanel, { type SRSCard } from '@/components/srs/SRSStudyPanel';
import EmptyState from '@/components/shared/EmptyState';
import StyleOutlinedIcon from '@mui/icons-material/StyleOutlined';
import { useRouter } from 'next/navigation';
import { tokens } from '@/theme/theme';

const ALL_DUE_CARDS: SRSCard[] = [
  { id: 'c1', front: 'ἀρχή',     back: { definition: 'beginning, origin, ruler', parsing: 'Noun · Feminine' },       intervals: { again: '<10m', hard: '1d', good: '3d', easy: '1w' } },
  { id: 'c2', front: 'πρός',     back: { definition: 'toward, with (+ acc)',      parsing: 'Preposition' },           intervals: { again: '<10m', hard: '2d', good: '5d', easy: '2w' } },
  { id: 'c3', front: 'ἄνθρωπος', back: { definition: 'human being, person',       parsing: 'Noun · Masculine' },      intervals: { again: '<10m', hard: '1d', good: '4d', easy: '1w' } },
  { id: 'c4', front: 'λαμβάνω',  back: { definition: 'I take, receive',           parsing: 'Verb · Present Active' }, intervals: { again: '<10m', hard: '3d', good: '1w', easy: '3w' } },
];

export default function StudyPage() {
  const router = useRouter();

  return (
    <AppShell>
      <Box sx={{ maxWidth: 520, mx: 'auto', px: 3, py: 6 }}>
        <Typography variant="h1" sx={{ mb: 0.75 }}>Review Session</Typography>
        <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 4 }}>
          {ALL_DUE_CARDS.length} card{ALL_DUE_CARDS.length !== 1 ? 's' : ''} due across all sets
        </Typography>

        {ALL_DUE_CARDS.length === 0 ? (
          <EmptyState
            icon={<StyleOutlinedIcon />}
            title="All caught up!"
            description="No cards are due right now. Come back later or start reading to add new words."
            action={{ label: 'Go to Reader', onClick: () => router.push('/read') }}
          />
        ) : (
          <Box sx={{ border: '1px solid ' + tokens.color.border, borderRadius: tokens.radius.lg, overflow: 'hidden', minHeight: 460 }}>
            <SRSStudyPanel
              cards={ALL_DUE_CARDS}
              onRate={(_id, _rating) => { /* persist */ }}
              onClose={() => router.push('/read')}
              size="full"
            />
          </Box>
        )}
      </Box>
    </AppShell>
  );
}
