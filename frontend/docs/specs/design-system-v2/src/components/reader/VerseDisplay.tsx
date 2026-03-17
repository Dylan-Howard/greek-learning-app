'use client';
// src/components/reader/VerseDisplay.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import GreekWord, { type WordStatus } from './GreekWord';
import { tokens } from '@/theme/theme';

export interface WordToken {
  id:     string;   // unique token id, e.g. "JHN.1.1.1"
  text:   string;   // Greek word with diacritics
  status: WordStatus;
}

export interface Verse {
  verse:  number;
  tokens: WordToken[];
}

interface Props {
  verses:           Verse[];
  selectedWordId:   string | null;
  onWordSelect:     (wordId: string) => void;
}

export default function VerseDisplay({ verses, selectedWordId, onWordSelect }: Props) {
  return (
    <Box
      sx={{
        maxWidth:  560,
        mx:        'auto',
        px:        { xs: 3, md: 6 },
        py:        5,
        // Ensure diacritics in Greek text are not clipped at container edges
        overflow:  'visible',
      }}
    >
      {verses.map(({ verse, tokens: words }) => (
        <Box
          key={verse}
          component="p"
          sx={{
            m:          0,
            mb:         0,
            lineHeight: 2.1,
            // Verse number as superscript inline before text
            '&::before': {
              content:    `"${verse}"`,
              display:    'inline',
              fontSize:   '0.75rem',
              lineHeight: 1,
              verticalAlign: 'super',
              color:      tokens.color.textMuted,
              mr:         0.5,
              fontFamily: '"Noto Sans", sans-serif',
            },
          }}
        >
          {words.map((token, i) => (
            <React.Fragment key={token.id}>
              <GreekWord
                word={token.text}
                status={token.status}
                selected={selectedWordId === token.id}
                onClick={() => onWordSelect(token.id)}
              />
              {/* Space between words (not after last) */}
              {i < words.length - 1 && (
                <Typography
                  component="span"
                  sx={{
                    fontFamily: '"Noto Serif", serif',
                    fontSize:   '1.75rem',
                    lineHeight: 2.1,
                  }}
                >
                  {' '}
                </Typography>
              )}
            </React.Fragment>
          ))}
        </Box>
      ))}
    </Box>
  );
}
