'use client';
// src/components/sidebar/StudyLaunchPanel.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Divider from '@mui/material/Divider';
import StyleOutlinedIcon from '@mui/icons-material/StyleOutlined';
import { tokens } from '@/design-system-v2/theme/theme';

interface Props {
  dueCount:     number;
  onStartStudy: () => void;
}

export default function StudyLaunchPanel({ dueCount, onStartStudy }: Props) {
  return (
    <Box sx={{ p: 2.5, borderTop: `1px solid ${tokens.color.border}` }}>
      {dueCount > 0 ? (
        <>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1, mb: 1.5 }}>
            <StyleOutlinedIcon sx={{ fontSize: 18, color: tokens.color.srsAgain }} />
            <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
              <Box component="span" sx={{ fontWeight: 700, color: tokens.color.srsAgain }}>
                {dueCount}
              </Box>{' '}
              word{dueCount !== 1 ? 's' : ''} due from this chapter
            </Typography>
          </Box>
          <Button
            variant="contained"
            fullWidth
            onClick={onStartStudy}
            sx={{
              bgcolor:  tokens.color.primary,
              '&:hover': { bgcolor: tokens.color.primaryDark },
              borderRadius: tokens.radius.sm,
              fontWeight: 700,
            }}
          >
            Begin Review
          </Button>
        </>
      ) : (
        <>
          <Typography variant="body2" sx={{ color: tokens.color.textMuted, mb: 1.5, fontStyle: 'italic' }}>
            No words due from this chapter.
          </Typography>
          <Button
            variant="outlined"
            fullWidth
            href="/study"
            sx={{
              borderColor: tokens.color.border,
              color:       tokens.color.textSecondary,
              borderRadius: tokens.radius.sm,
              '&:hover': { borderColor: tokens.color.primary, color: tokens.color.primary },
            }}
          >
            Review all vocabulary
          </Button>
        </>
      )}
    </Box>
  );
}
