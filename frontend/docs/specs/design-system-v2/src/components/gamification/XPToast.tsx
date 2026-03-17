'use client';
// src/components/gamification/XPToast.tsx

import React, { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import { tokens } from '@/theme/theme';

interface Props {
  xp:     number;
  onDone: () => void;
}

export default function XPToast({ xp, onDone }: Props) {
  const [visible, setVisible] = useState(false);

  useEffect(() => {
    // Slight delay so CSS transition fires
    const showTimer = setTimeout(() => setVisible(true), 30);
    const hideTimer = setTimeout(() => {
      setVisible(false);
      setTimeout(onDone, 300);
    }, 2000);
    return () => { clearTimeout(showTimer); clearTimeout(hideTimer); };
  }, [onDone]);

  return (
    <Box
      aria-live="polite"
      aria-atomic="true"
      sx={{
        position:       'absolute',
        top:            12,
        left:           '50%',
        transform:      visible
          ? 'translateX(-50%) translateY(0)'
          : 'translateX(-50%) translateY(-8px)',
        opacity:        visible ? 1 : 0,
        transition:     `opacity 200ms ${tokens.motion.ease}, transform 200ms ${tokens.motion.ease}`,
        bgcolor:        tokens.color.textPrimary,
        color:          tokens.color.xpGold,
        fontFamily:     '"Noto Sans", sans-serif',
        fontWeight:     700,
        fontSize:       '1rem',
        px:             2,
        py:             0.75,
        borderRadius:   tokens.radius.full,
        pointerEvents:  'none',
        zIndex:         10,
        whiteSpace:     'nowrap',
        boxShadow:      '0 4px 12px rgba(0,0,0,0.2)',
      }}
    >
      +{xp} XP
    </Box>
  );
}
