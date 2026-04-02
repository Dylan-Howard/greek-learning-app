'use client';
// src/components/gamification/TierUpModal.tsx

import React, { useEffect, useState } from 'react';
import Dialog from '@mui/material/Dialog';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/design-system-v2/theme/theme';
import { type Tier } from '@/design-system-v2/components/nav/UserAvatarBadge';

const TIER_CONFIG: Record<Tier, { color: string; icon: string; flavour: string }> = {
  novice:     { color: tokens.color.tierNovice,     icon: '📖', flavour: 'Your journey in the Greek text begins.' },
  apprentice: { color: tokens.color.tierApprentice, icon: '🏛️', flavour: 'The grammar is yielding its secrets.' },
  scholar:    { color: tokens.color.tierScholar,    icon: '🔬', flavour: 'You read with the eyes of a scholar.' },
  master:     { color: tokens.color.tierMaster,     icon: '✨', flavour: 'The text is no longer foreign to you.' },
};

const TIER_NAMES: Record<Tier, string> = {
  novice:     'Novice',
  apprentice: 'Apprentice',
  scholar:    'Scholar',
  master:     'Master',
};

interface Props {
  open:     boolean;
  tier:     Tier;
  totalXP:  number;
  onClose:  () => void;
}

export default function TierUpModal({ open, tier, totalXP, onClose }: Props) {
  const [popped, setPopped] = useState(false);
  const { color, icon, flavour } = TIER_CONFIG[tier];

  useEffect(() => {
    if (open) {
      setTimeout(() => setPopped(true), 50);
      const t = setTimeout(onClose, 4500);
      return () => clearTimeout(t);
    } else {
      setPopped(false);
    }
  }, [open, onClose]);

  return (
    <Dialog
      open={open}
      // MUI v7: onBackdropClick removed — use onClose with reason
      onClose={(_, reason) => { if (reason !== 'backdropClick') onClose(); }}
      PaperProps={{
        sx: {
          textAlign:    'center',
          p:            4,
          borderRadius: tokens.radius.lg,
          minWidth:     300,
          maxWidth:     360,
          border:       `2px solid ${color}`,
        },
      }}
    >
      {/* Tier badge icon — pop animation */}
      <Box
        sx={{
          fontSize:   '3.5rem',
          lineHeight: 1,
          mb:         2,
          transform:  popped ? 'scale(1)' : 'scale(0.5)',
          transition: `transform ${tokens.motion.slow} cubic-bezier(0.34, 1.56, 0.64, 1)`,
        }}
      >
        {icon}
      </Box>

      <Typography
        sx={{
          fontFamily: '"Noto Serif", serif',
          fontSize:   '1.5rem',
          color:      tokens.color.textPrimary,
          mb:         0.75,
        }}
      >
        You've reached
      </Typography>

      <Typography
        sx={{
          fontFamily: '"Noto Serif", serif',
          fontSize:   '2rem',
          fontWeight: 700,
          color,
          mb:         1.5,
        }}
      >
        {TIER_NAMES[tier]}
      </Typography>

      <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 2 }}>
        {flavour}
      </Typography>

      <Typography
        sx={{ fontWeight: 700, fontSize: '1.25rem', color: tokens.color.xpGold }}
      >
        {totalXP.toLocaleString()} XP
      </Typography>
    </Dialog>
  );
}
