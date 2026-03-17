'use client';
// src/app/vocabulary/master/page.tsx

import React, { useMemo, useState } from 'react';
import Box from '@mui/material/Box';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import TableSortLabel from '@mui/material/TableSortLabel';
import Paper from '@mui/material/Paper';
import Chip from '@mui/material/Chip';
import Box2 from '@mui/material/Box';
import AppShell from '@/components/layouts/AppShell';
import { PageHeader } from '@/components/shared/PageHeader';
import TransliterationSearchInput, { translitToGreekPattern } from '@/components/vocab/TransliterationSearchInput';
import VocabWordRow, { type VocabWord } from '@/components/vocab/VocabWordRow';
import { tokens } from '@/theme/theme';

const ALL_WORDS: VocabWord[] = [
  { id: 'logos',    greek: 'λόγος',  transliteration: 'logos',   definition: 'word, reason, account',       partOfSpeech: 'Noun',         frequency: 330, srsStatus: 'new'      },
  { id: 'arche',    greek: 'ἀρχή',   transliteration: 'arche',   definition: 'beginning, origin, ruler',    partOfSpeech: 'Noun',         frequency: 55,  srsStatus: 'due'      },
  { id: 'theos',    greek: 'θεός',   transliteration: 'theos',   definition: 'God, god',                    partOfSpeech: 'Noun',         frequency: 1317,srsStatus: 'mastered' },
  { id: 'kai',      greek: 'καί',    transliteration: 'kai',     definition: 'and, also, even',             partOfSpeech: 'Conjunction',  frequency: 9161,srsStatus: 'mastered' },
  { id: 'en',       greek: 'ἐν',     transliteration: 'en',      definition: 'in, on, among (+ dat)',       partOfSpeech: 'Preposition',  frequency: 2752,srsStatus: 'mastered' },
  { id: 'pros',     greek: 'πρός',   transliteration: 'pros',    definition: 'toward, with, against (+ acc)',partOfSpeech: 'Preposition', frequency: 700, srsStatus: 'due'      },
  { id: 'anthropos',greek: 'ἄνθρωπος',transliteration:'anthropos',definition: 'human being, person, man',  partOfSpeech: 'Noun',         frequency: 550, srsStatus: 'new'      },
  { id: 'zoe',      greek: 'ζωή',    transliteration: 'zoe',     definition: 'life',                        partOfSpeech: 'Noun',         frequency: 135, srsStatus: 'unseen'   },
];

type SortField = 'greek' | 'frequency' | 'srsStatus';
type SortDir   = 'asc' | 'desc';

const STATUS_FILTERS = ['All', 'New', 'Due', 'Mastered', 'Unseen'] as const;

export default function MasterVocabPage() {
  const [query,      setQuery]      = useState('');
  const [statusFilter, setStatus]   = useState<typeof STATUS_FILTERS[number]>('All');
  const [sortField,  setSortField]  = useState<SortField>('frequency');
  const [sortDir,    setSortDir]    = useState<SortDir>('desc');

  const pattern = useMemo(() => translitToGreekPattern(query), [query]);

  const filtered = useMemo(() => {
    return ALL_WORDS
      .filter((w) => {
        if (statusFilter !== 'All' && w.srsStatus !== statusFilter.toLowerCase()) return false;
        if (!query) return true;
        return pattern.test(w.greek) || w.definition.toLowerCase().includes(query.toLowerCase()) || w.transliteration.toLowerCase().includes(query.toLowerCase());
      })
      .sort((a, b) => {
        let cmp = 0;
        if (sortField === 'greek')     cmp = a.greek.localeCompare(b.greek);
        if (sortField === 'frequency') cmp = a.frequency - b.frequency;
        if (sortField === 'srsStatus') cmp = a.srsStatus.localeCompare(b.srsStatus);
        return sortDir === 'asc' ? cmp : -cmp;
      });
  }, [query, pattern, statusFilter, sortField, sortDir]);

  function handleSort(field: SortField) {
    if (sortField === field) setSortDir((d) => (d === 'asc' ? 'desc' : 'asc'));
    else { setSortField(field); setSortDir('desc'); }
  }

  return (
    <AppShell>
      <Box sx={{ p: { xs: 3, md: 4 }, maxWidth: 1100, mx: 'auto' }}>
        <PageHeader title="All Words" subtitle={`${ALL_WORDS.length} words in the database`} />

        {/* Filters row */}
        <Box sx={{ display: 'flex', flexWrap: 'wrap', gap: 2, mb: 3, alignItems: 'flex-start' }}>
          <Box sx={{ flex: 1, minWidth: 220, maxWidth: 360 }}>
            <TransliterationSearchInput value={query} onChange={setQuery} />
          </Box>
          <Box sx={{ display: 'flex', gap: 0.75, flexWrap: 'wrap' }}>
            {STATUS_FILTERS.map((f) => (
              <Chip
                key={f}
                label={f}
                onClick={() => setStatus(f)}
                variant={statusFilter === f ? 'filled' : 'outlined'}
                sx={{
                  bgcolor:     statusFilter === f ? tokens.color.primary : 'transparent',
                  color:       statusFilter === f ? '#FFFFFF' : tokens.color.textSecondary,
                  borderColor: tokens.color.border,
                  fontWeight:  600,
                  fontSize:    '0.75rem',
                  '&:hover':   { bgcolor: statusFilter === f ? tokens.color.primaryDark : tokens.color.primaryLight },
                }}
              />
            ))}
          </Box>
        </Box>

        <TableContainer component={Paper} elevation={0} sx={{ border: '1px solid ' + tokens.color.border, borderRadius: tokens.radius.md }}>
          <Table size="small">
            <TableHead>
              <TableRow sx={{ bgcolor: tokens.color.surface }}>
                <TableCell sx={{ fontWeight: 700, color: tokens.color.textSecondary, fontSize: '0.75rem' }}>
                  <TableSortLabel active={sortField === 'greek'} direction={sortField === 'greek' ? sortDir : 'asc'} onClick={() => handleSort('greek')}>
                    Greek
                  </TableSortLabel>
                </TableCell>
                <TableCell sx={{ fontWeight: 700, color: tokens.color.textSecondary, fontSize: '0.75rem' }}>Transliteration</TableCell>
                <TableCell sx={{ fontWeight: 700, color: tokens.color.textSecondary, fontSize: '0.75rem' }}>Definition</TableCell>
                <TableCell sx={{ display: { xs: 'none', md: 'table-cell' }, fontWeight: 700, color: tokens.color.textSecondary, fontSize: '0.75rem' }}>Part of Speech</TableCell>
                <TableCell align="right" sx={{ display: { xs: 'none', sm: 'table-cell' }, fontWeight: 700, color: tokens.color.textSecondary, fontSize: '0.75rem' }}>
                  <TableSortLabel active={sortField === 'frequency'} direction={sortField === 'frequency' ? sortDir : 'desc'} onClick={() => handleSort('frequency')}>
                    Freq
                  </TableSortLabel>
                </TableCell>
                <TableCell sx={{ fontWeight: 700, color: tokens.color.textSecondary, fontSize: '0.75rem' }}>Status</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {filtered.map((word) => (
                <VocabWordRow key={word.id} word={word} onClick={(_id) => { /* open word detail dialog */ }} />
              ))}
              {filtered.length === 0 && (
                <TableRow>
                  <TableCell colSpan={6} align="center" sx={{ py: 6, color: tokens.color.textMuted, fontStyle: 'italic' }}>
                    No words match your search.
                  </TableCell>
                </TableRow>
              )}
            </TableBody>
          </Table>
        </TableContainer>
      </Box>
    </AppShell>
  );
}
