'use client';
// src/components/mobile/BottomSheet.tsx
// Three snap points: hidden (0) | peek (40%) | full (100%)
// Built with a custom draggable implementation over a fixed overlay.

import React, { useCallback, useEffect, useRef, useState } from 'react';
import Box from '@mui/material/Box';
import { tokens } from '@/design-system-v2/theme/theme';

export type SnapPoint = 'hidden' | 'peek' | 'full';

interface Props {
  snap:         SnapPoint;
  onSnapChange: (snap: SnapPoint) => void;
  children:     React.ReactNode;
}

const SNAP_HEIGHTS: Record<SnapPoint, string> = {
  hidden: '0vh',
  peek:   '45vh',
  full:   '100vh',
};

const SNAP_ORDER: SnapPoint[] = ['hidden', 'peek', 'full'];

export default function BottomSheet({ snap, onSnapChange, children }: Props) {
  const sheetRef     = useRef<HTMLDivElement>(null);
  const dragStartY   = useRef<number>(0);
  const dragStartH   = useRef<number>(0);
  const isDragging   = useRef(false);
  const [height, setHeight] = useState(SNAP_HEIGHTS[snap]);

  // Sync snap → height when prop changes
  useEffect(() => {
    setHeight(SNAP_HEIGHTS[snap]);
  }, [snap]);

  const snapToNearest = useCallback(
    (currentPx: number, viewportH: number) => {
      const pct = (currentPx / viewportH) * 100;
      if (pct < 15)  { onSnapChange('hidden'); return; }
      if (pct < 70)  { onSnapChange('peek');   return; }
      onSnapChange('full');
    },
    [onSnapChange],
  );

  // Touch handlers
  const onTouchStart = (e: React.TouchEvent) => {
    isDragging.current  = true;
    dragStartY.current  = e.touches[0].clientY;
    dragStartH.current  = sheetRef.current?.getBoundingClientRect().height ?? 0;
  };

  const onTouchMove = (e: React.TouchEvent) => {
    if (!isDragging.current) return;
    const dy      = dragStartY.current - e.touches[0].clientY;
    const newH    = Math.max(0, dragStartH.current + dy);
    setHeight(`${newH}px`);
  };

  const onTouchEnd = () => {
    isDragging.current = false;
    const currentH = sheetRef.current?.getBoundingClientRect().height ?? 0;
    snapToNearest(currentH, window.innerHeight);
  };

  if (snap === 'hidden') return null;

  return (
    <>
      {/* Backdrop — tap to close */}
      {snap === 'full' && (
        <Box
          onClick={() => onSnapChange('peek')}
          sx={{
            position: 'fixed',
            inset:    0,
            bgcolor:  'rgba(0,0,0,0.2)',
            zIndex:   1299,
          }}
        />
      )}

      {/* Sheet */}
      <Box
        ref={sheetRef}
        sx={{
          position:     'fixed',
          bottom:       0,
          left:         0,
          right:        0,
          height:       height,
          zIndex:       1300,
          bgcolor:      tokens.color.bg,
          borderRadius: `${tokens.radius.xl} ${tokens.radius.xl} 0 0`,
          boxShadow:    '0 -4px 24px rgba(0,0,0,0.12)',
          display:      'flex',
          flexDirection:'column',
          overflow:     'hidden',
          // Only animate when not dragging
          transition:   isDragging.current ? 'none' : `height 300ms ${tokens.motion.decel}`,
          // iOS safe area
          pb:           'env(safe-area-inset-bottom, 0px)',
        }}
      >
        {/* Drag handle */}
        <Box
          onTouchStart={onTouchStart}
          onTouchMove={onTouchMove}
          onTouchEnd={onTouchEnd}
          sx={{
            width:          '100%',
            pt:             1.5,
            pb:             1,
            display:        'flex',
            justifyContent: 'center',
            alignItems:     'center',
            cursor:         'grab',
            flexShrink:     0,
            touchAction:    'none',
          }}
          aria-label="Drag to resize panel"
        >
          <Box
            sx={{
              width:        32,
              height:       4,
              borderRadius: tokens.radius.full,
              bgcolor:      tokens.color.borderStrong,
            }}
          />
        </Box>

        {/* Content */}
        <Box sx={{ flex: 1, overflowY: 'auto', overflowX: 'hidden' }}>
          {children}
        </Box>
      </Box>
    </>
  );
}
