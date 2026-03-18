'use client';
// src/app/vocabulary/[setId]/page.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import LinearProgress from '@mui/material/LinearProgress';
import Chip from '@mui/material/Chip';
import Button from '@mui/material/Button';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableContainer from '@mui/material/TableContainer';
import Paper from '@mui/material/Paper';
import Typography from '@mui/material/Typography';
import { useParams } from 'next/navigation';
import AppShell from '@/design-system-v2/components/layouts/AppShell';
import { PageHeader } from '@/design-system-v2/components/shared/PageHeader';
import TransliterationSearchInput from '@/design-system-v2/components/vocab/TransliterationSearchInput';
import VocabWordRow, { type VocabWord } from '@/design-system-v2/components/vocab/VocabWordRow';
import { tokens } from '@/design-system-v2/theme/theme';

const DEMO_WORDS: VocabWord[] = [
  { id: 'logos',    greek: 'λόγος',  transliteration: 'logos',   definition: 'word, reason, account',   partOfSpeech: 'Noun', frequency: 330, srsStatus: 'new' },
  { id: 'theos',    greek: 'θεός',   transliteration: 'theos',   definition: 'God, god',                partOfSpeech: 'Noun', frequency: 1317,srsStatus: 'mastered' },
  { id: 'arche',    greek: 'ἀρχή',   transliteration: 'arche',   definition: 'beginning, origin',       partOfSpeech: 'Noun', frequency: 55,  srsStatus: 'due' },
];

const STATUS_FILTERS = ['All', 'New', 'Due', 'Mastered'] as const;

export default function VocabSetDetailPage() {
  const params = useParams();
  const setId = params?.setId as string;
  const [query, setQuery]             = useState('');
  const [statusFilter, setStatus]     = useState<typeof STATUS_FILTERS[number]>('All');

  const mastered  = DEMO_WORDS.filter((w) => w.srsStatus === 'mastered').length;
  const pct       = Math.round((mastered / DEMO_WORDS.length) * 100);

  const filtered = DEMO_WORDS.filter((w) => {
    if (statusFilter !== 'All' && w.srsStatus !== statusFilter.toLowerCase()) return false;
    if (!query) return true;
    return w.greek.includes(query) || w.definition.toLowerCase().includes(query.toLowerCase()) || w.transliteration.toLowerCase().includes(query.toLowerCase());
  });

  return (
    <AppShell>
      <Box sx={{ p: { xs: 3, md: 4 }, maxWidth: 900, mx: 'auto' }}>
        <PageHeader
          title="Mounce Top 100"
          subtitle="The 100 most frequent words in the Greek NT"
          actions={
            <Button variant="contained" sx={{ bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark } }}>
              Study Set
            </Button>
          }
        />

        {/* Progress bar */}
        <Box sx={{ mb: 3 }}>
          <LinearProgress
            variant="determinate"
            value={pct}
            sx={{ height: 8, mb: 0.75, bgcolor: tokens.color.surfaceAlt, '& .MuiLinearProgress-bar': { bgcolor: tokens.color.srsEasy } }}
          />
          <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
            {mastered} / {DEMO_WORDS.length} mastered ({pct}%)
          </Typography>
        </Box>

        {/* Filters */}
        <Box sx={{ display: 'flex', flexWrap: 'wrap', gap: 2, mb: 2, alignItems: 'flex-start' }}>
          <Box sx={{ flex: 1, minWidth: 220, maxWidth: 320 }}>
            <TransliterationSearchInput value={query} onChange={setQuery} />
          </Box>
          <Box sx={{ display: 'flex', gap: 0.75 }}>
            {STATUS_FILTERS.map((f) => (
              <Chip key={f} label={f} onClick={() => setStatus(f)}
                variant={statusFilter === f ? 'filled' : 'outlined'}
                sx={{ bgcolor: statusFilter === f ? tokens.color.primary : 'transparent', color: statusFilter === f ? '#FFFFFF' : tokens.color.textSecondary, borderColor: tokens.color.border, fontWeight: 600, fontSize: '0.75rem' }}
              />
            ))}
          </Box>
        </Box>

        <TableContainer component={Paper} elevation={0} sx={{ border: '1px solid ' + tokens.color.border, borderRadius: tokens.radius.md }}>
          <Table size="small">
            <TableBody>
              {filtered.map((word) => (
                <VocabWordRow key={word.id} word={word} onClick={() => {}} />
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </Box>
    </AppShell>
  );
}
