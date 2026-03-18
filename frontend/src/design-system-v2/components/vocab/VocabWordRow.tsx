'use client';
// src/components/vocab/VocabWordRow.tsx

import React from 'react';
import TableRow from '@mui/material/TableRow';
import TableCell from '@mui/material/TableCell';
import Typography from '@mui/material/Typography';
import { tokens } from '@/design-system-v2/theme/theme';
import ProgressChip, { type SRSStatus } from '@/design-system-v2/components/shared/ProgressChip';

export interface VocabWord {
  id:            string;
  greek:         string;
  transliteration: string;
  definition:    string;
  partOfSpeech:  string;
  frequency:     number;
  srsStatus:     SRSStatus;
}

interface Props {
  word:    VocabWord;
  onClick: (wordId: string) => void;
}

export default function VocabWordRow({ word, onClick }: Props) {
  return (
    <TableRow
      hover
      onClick={() => onClick(word.id)}
      sx={{
        cursor: 'pointer',
        '&:hover': { bgcolor: tokens.color.primaryLight },
        '& td': { borderBottom: `1px solid ${tokens.color.border}`, py: 1.25, px: 2 },
      }}
    >
      {/* Greek word */}
      <TableCell>
        <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: '1rem', color: tokens.color.textPrimary }}>
          {word.greek}
        </Typography>
      </TableCell>

      {/* Transliteration */}
      <TableCell>
        <Typography variant="body2" sx={{ color: tokens.color.textSecondary, fontStyle: 'italic' }}>
          {word.transliteration}
        </Typography>
      </TableCell>

      {/* Definition */}
      <TableCell>
        <Typography variant="body2" sx={{ color: tokens.color.textPrimary }}>
          {word.definition}
        </Typography>
      </TableCell>

      {/* Part of speech */}
      <TableCell sx={{ display: { xs: 'none', md: 'table-cell' } }}>
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          {word.partOfSpeech}
        </Typography>
      </TableCell>

      {/* Frequency */}
      <TableCell align="right" sx={{ display: { xs: 'none', sm: 'table-cell' } }}>
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          {word.frequency.toLocaleString()}×
        </Typography>
      </TableCell>

      {/* SRS status */}
      <TableCell>
        <ProgressChip status={word.srsStatus} />
      </TableCell>
    </TableRow>
  );
}
