'use client';
// src/components/reader/GreekWord.tsx

import React from 'react';
import Box from '@mui/material/Box';
import { tokens } from '@/theme/theme';

export type WordStatus = 'default' | 'new' | 'due' | 'mastered';

const STATUS_UNDERLINE: Record<WordStatus, string | undefined> = {
  default:  undefined,
  new:      tokens.color.srsNew,
  due:      tokens.color.srsAgain,
  mastered: tokens.color.srsEasy,
};

interface Props {
  word:     string;
  status:   WordStatus;
  selected: boolean;
  onClick:  () => void;
}

export default function GreekWord({ word, status, selected, onClick }: Props) {
  const underlineColor = STATUS_UNDERLINE[status];

  return (
    <Box
      component="span"
      onClick={onClick}
      role="button"
      tabIndex={0}
      aria-pressed={selected}
      onKeyDown={(e) => { if (e.key === 'Enter' || e.key === ' ') onClick(); }}
      sx={{
        fontFamily:     '"Noto Serif", serif',
        fontSize:       '1.75rem',
        lineHeight:     2.1,
        cursor:         'pointer',
        display:        'inline',
        // Overflow visible so diacritics are never clipped
        overflow:       'visible',
        borderBottom:   underlineColor ? `2px solid ${underlineColor}` : 'none',
        paddingBottom:  underlineColor ? '1px' : undefined,
        borderRadius:   0,
        bgcolor:        selected ? `${tokens.color.primaryLight}99` : 'transparent',
        px:             selected ? 0.25 : 0,
        transition:     `background-color ${tokens.motion.fast} ${tokens.motion.ease}`,
        '&:hover': {
          bgcolor: `${tokens.color.primaryLight}88`,
        },
        '&:focus-visible': {
          outline:       `2px solid ${tokens.color.primary}`,
          outlineOffset: 2,
          borderRadius:  tokens.radius.xs,
        },
      }}
    >
      {word}
    </Box>
  );
}
