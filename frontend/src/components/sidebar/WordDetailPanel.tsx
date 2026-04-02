'use client';
// src/components/sidebar/WordDetailPanel.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Divider from '@mui/material/Divider';
import { tokens } from '@/theme/theme';
import ProgressChip, { type SRSStatus } from '@/components/shared/ProgressChip';

export interface ParsedWord {
  id:          string;
  greek:       string;        // displayed word form
  lexicalForm: string;        // dictionary headword
  definition:  string;
  parsing: {
    partOfSpeech: string;
    // Noun fields
    case?:   string;
    number?: string;
    gender?: string;
    // Verb fields
    person?: string;
    tense?:  string;
    voice?:  string;
    mood?:   string;
  };
  srsStatus:  SRSStatus;
  frequency:  number;
  sets?:      string[];
}

interface ParseRow { label: string; value: string; }

interface Props {
  word:    ParsedWord | null;
}

function ParsingGrid({ rows }: { rows: ParseRow[] }) {
  return (
    <Box
      sx={{
        display:             'grid',
        gridTemplateColumns: '1fr 1fr',
        gap:                 0.5,
        mt:                  1,
      }}
    >
      {rows.map(({ label, value }) => (
        <Box key={label} sx={{ display: 'flex', flexDirection: 'column', gap: 0.25 }}>
          <Typography sx={{ fontSize: '0.625rem', fontWeight: 600, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.06em' }}>
            {label}
          </Typography>
          <Typography sx={{ fontSize: '0.8125rem', color: tokens.color.textPrimary }}>
            {value}
          </Typography>
        </Box>
      ))}
    </Box>
  );
}

export default function WordDetailPanel({ word }: Props) {
  if (!word) {
    return (
      <Box
        sx={{
          flex:           1,
          display:        'flex',
          alignItems:     'center',
          justifyContent: 'center',
          p:              3,
          textAlign:      'center',
        }}
      >
        <Typography variant="body2" sx={{ color: tokens.color.textMuted, fontStyle: 'italic' }}>
          Tap any word to see its details.
        </Typography>
      </Box>
    );
  }

  const { parsing } = word;

  const parsingRows: ParseRow[] = parsing.partOfSpeech.toLowerCase().includes('verb')
    ? [
        { label: 'Part of Speech', value: parsing.partOfSpeech },
        { label: 'Person',         value: parsing.person  ?? '—' },
        { label: 'Number',         value: parsing.number  ?? '—' },
        { label: 'Tense',          value: parsing.tense   ?? '—' },
        { label: 'Voice',          value: parsing.voice   ?? '—' },
        { label: 'Mood',           value: parsing.mood    ?? '—' },
      ]
    : [
        { label: 'Part of Speech', value: parsing.partOfSpeech },
        { label: 'Case',           value: parsing.case    ?? '—' },
        { label: 'Number',         value: parsing.number  ?? '—' },
        { label: 'Gender',         value: parsing.gender  ?? '—' },
      ];

  return (
    <Box sx={{ p: 2.5 }}>
      {/* Section label */}
      <Typography
        sx={{
          fontSize:      '0.625rem',
          fontWeight:    600,
          color:         tokens.color.textMuted,
          textTransform: 'uppercase',
          letterSpacing: '0.08em',
          mb:            1.5,
        }}
      >
        Word Details
      </Typography>

      {/* Lexical form */}
      <Typography
        sx={{
          fontFamily: '"Noto Serif", serif',
          fontSize:   '1.375rem',
          color:      tokens.color.textPrimary,
          lineHeight: 1.4,
          mb:         0.5,
        }}
      >
        {word.lexicalForm}
      </Typography>

      {/* Definition */}
      <Typography
        sx={{
          fontSize:   '0.9375rem',
          fontWeight: 600,
          color:      tokens.color.primary,
          mb:         1.5,
          lineHeight: 1.4,
        }}
      >
        {word.definition}
      </Typography>

      {/* SRS status + frequency */}
      <Box sx={{ display: 'flex', alignItems: 'center', gap: 1, mb: 1.5 }}>
        <ProgressChip status={word.srsStatus} />
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          {word.frequency.toLocaleString()}× in NT
        </Typography>
      </Box>

      <Divider sx={{ my: 1.5 }} />

      {/* Parsing grid */}
      <ParsingGrid rows={parsingRows} />

      {/* Vocabulary sets */}
      {word.sets && word.sets.length > 0 && (
        <>
          <Divider sx={{ my: 1.5 }} />
          <Typography
            sx={{ fontSize: '0.625rem', fontWeight: 600, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em', mb: 0.75 }}
          >
            In Sets
          </Typography>
          <Box sx={{ display: 'flex', flexWrap: 'wrap', gap: 0.5 }}>
            {word.sets.map((set) => (
              <Box
                key={set}
                sx={{
                  px: 1, py: 0.25,
                  borderRadius: tokens.radius.xs,
                  bgcolor: tokens.color.primaryLight,
                  color: tokens.color.primaryDark,
                  fontSize: '0.75rem',
                  fontWeight: 500,
                }}
              >
                {set}
              </Box>
            ))}
          </Box>
        </>
      )}
    </Box>
  );
}
