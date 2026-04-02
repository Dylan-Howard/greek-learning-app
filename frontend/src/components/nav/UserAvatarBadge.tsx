'use client';
// src/components/nav/UserAvatarBadge.tsx

import React from 'react';
import Box from '@mui/material/Box';
import { tokens } from '@/design-system-v2/theme/theme';

export type Tier = 'novice' | 'apprentice' | 'scholar' | 'master';

const TIER_COLORS: Record<Tier, string> = {
  novice:     tokens.color.tierNovice,
  apprentice: tokens.color.tierApprentice,
  scholar:    tokens.color.tierScholar,
  master:     tokens.color.tierMaster,
};

const TIER_ABBR: Record<Tier, string> = {
  novice:     'N',
  apprentice: 'A',
  scholar:    'S',
  master:     'M',
};

interface Props {
  initials:   string;    // Max 2 chars
  xpPercent:  number;    // 0–100
  tier:       Tier;
  size?:      number;    // avatar diameter in px, default 40
  onClick?:   () => void;
}

export default function UserAvatarBadge({
  initials,
  xpPercent,
  tier,
  size = 40,
  onClick,
}: Props) {
  const ringSize = size + 12; // SVG canvas is slightly larger than avatar
  const r        = (ringSize - 6) / 2; // radius leaving 3px stroke gap on each side
  const circ     = 2 * Math.PI * r;
  const dash     = (xpPercent / 100) * circ;

  const badgeSize = Math.round(size * 0.4);

  return (
    <Box
      onClick={onClick}
      sx={{
        position: 'relative',
        width:    ringSize,
        height:   ringSize,
        cursor:   onClick ? 'pointer' : 'default',
        flexShrink: 0,
      }}
    >
      {/* XP ring SVG */}
      <svg
        width={ringSize}
        height={ringSize}
        viewBox={`0 0 ${ringSize} ${ringSize}`}
        style={{ position: 'absolute', top: 0, left: 0, transform: 'rotate(-90deg)' }}
      >
        {/* Track */}
        <circle
          cx={ringSize / 2}
          cy={ringSize / 2}
          r={r}
          fill="none"
          stroke={tokens.color.xpRingBg}
          strokeWidth={3}
        />
        {/* Progress arc */}
        <circle
          cx={ringSize / 2}
          cy={ringSize / 2}
          r={r}
          fill="none"
          stroke={tokens.color.xpGold}
          strokeWidth={3}
          strokeLinecap="round"
          strokeDasharray={`${dash} ${circ}`}
          style={{ transition: `stroke-dasharray ${tokens.motion.slow} ${tokens.motion.ease}` }}
        />
      </svg>

      {/* Avatar circle */}
      <Box
        sx={{
          position:       'absolute',
          top:            (ringSize - size) / 2,
          left:           (ringSize - size) / 2,
          width:          size,
          height:         size,
          borderRadius:   '50%',
          bgcolor:        tokens.color.primaryLight,
          color:          tokens.color.primaryDark,
          display:        'flex',
          alignItems:     'center',
          justifyContent: 'center',
          fontFamily:     '"Noto Sans", sans-serif',
          fontWeight:     600,
          fontSize:       size * 0.35,
          userSelect:     'none',
        }}
      >
        {initials.slice(0, 2).toUpperCase()}
      </Box>

      {/* Tier badge */}
      <Box
        sx={{
          position:       'absolute',
          bottom:         (ringSize - size) / 2 - 2,
          right:          (ringSize - size) / 2 - 2,
          width:          badgeSize,
          height:         badgeSize,
          borderRadius:   '50%',
          bgcolor:        TIER_COLORS[tier],
          color:          '#FFFFFF',
          display:        'flex',
          alignItems:     'center',
          justifyContent: 'center',
          fontFamily:     '"Noto Sans", sans-serif',
          fontWeight:     700,
          fontSize:       badgeSize * 0.5,
          border:         `2px solid #FFFFFF`,
          lineHeight:     1,
        }}
      >
        {TIER_ABBR[tier]}
      </Box>
    </Box>
  );
}
