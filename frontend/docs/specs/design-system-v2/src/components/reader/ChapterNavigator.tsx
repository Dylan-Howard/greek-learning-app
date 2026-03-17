'use client';
// src/components/reader/ChapterNavigator.tsx
// Full-height ghost navigation buttons in the margins outside the text column.
// Appear on hover of the content area. Hidden on mobile.

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Tooltip from '@mui/material/Tooltip';
import ChevronLeftIcon  from '@mui/icons-material/ChevronLeft';
import ChevronRightIcon from '@mui/icons-material/ChevronRight';
import { tokens } from '@/theme/theme';
import { useDirection } from '@/components/layouts/RTLWrapper';

interface Props {
  hasPrev:  boolean;
  hasNext:  boolean;
  onPrev:   () => void;
  onNext:   () => void;
}

function NavButton({
  side,
  disabled,
  onClick,
  label,
}: {
  side:     'left' | 'right';
  disabled: boolean;
  onClick:  () => void;
  label:    string;
}) {
  if (disabled) return null;

  return (
    <Tooltip title={label} placement={side === 'left' ? 'right' : 'left'} arrow>
      <Box
        component="button"
        onClick={onClick}
        aria-label={label}
        sx={{
          position:       'absolute',
          top:            0,
          bottom:         0,
          [side]:         0,
          width:          48,
          border:         'none',
          bgcolor:        'transparent',
          cursor:         'pointer',
          display:        { xs: 'none', md: 'flex' },
          alignItems:     'center',
          justifyContent: 'center',
          color:          tokens.color.textMuted,
          '&:hover': {
            color:  tokens.color.primary,
            bgcolor: tokens.color.primaryLight,
          },
          '&:focus-visible': {
            outline: `2px solid ${tokens.color.primary}`,
            outlineOffset: 2,
          },
          transition: `opacity ${tokens.motion.normal} ${tokens.motion.ease}, color ${tokens.motion.fast} ${tokens.motion.ease}, background-color ${tokens.motion.fast} ${tokens.motion.ease}`,
          '& svg': { fontSize: 28 },
        }}
      >
        {side === 'left' ? <ChevronLeftIcon /> : <ChevronRightIcon />}
      </Box>
    </Tooltip>
  );
}

interface WrapperProps extends Props {
  children: React.ReactNode;
}

// Wrap the reader content area to provide relative positioning context
export function ChapterNavigatorWrapper({ children, hasPrev, hasNext, onPrev, onNext }: WrapperProps) {
  const [hovered, setHovered] = useState(false);
  const direction = useDirection();

  return (
    <Box
      onMouseEnter={() => setHovered(true)}
      onMouseLeave={() => setHovered(false)}
      sx={{
        position: 'relative',
        flex: 1,
        '& .chapter-nav-btn': {
          opacity: hovered ? 1 : 0,
          transition: `opacity ${tokens.motion.normal} ${tokens.motion.ease}`,
        },
      }}
    >
      <NavButton
        side={direction === 'rtl' ? 'right' : 'left'}
        disabled={!hasPrev}
        onClick={onPrev}
        label="Previous chapter"
      />
      {children}
      <NavButton
        side={direction === 'rtl' ? 'left' : 'right'}
        disabled={!hasNext}
        onClick={onNext}
        label="Next chapter"
      />
    </Box>
  );
}
