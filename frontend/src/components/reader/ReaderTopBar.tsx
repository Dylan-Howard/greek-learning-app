'use client';

import React from 'react';
import Box from '@mui/material/Box';
import IconButton from '@mui/material/IconButton';
import Tooltip from '@mui/material/Tooltip';
import Typography from '@mui/material/Typography';
import SettingsOutlinedIcon from '@mui/icons-material/SettingsOutlined';
import LibraryBooksOutlinedIcon from '@mui/icons-material/LibraryBooksOutlined';
import SchoolOutlinedIcon from '@mui/icons-material/SchoolOutlined';
import MenuBookOutlinedIcon from '@mui/icons-material/MenuBookOutlined';
import { tokens } from '@/design-system-v2/theme/theme';
import ReaderPageAudioButton from '@/components/features/reader/ReaderPageAudioButton';

interface Props {
  activeTab: number;
  onTabChange: (tabId: number) => void;
  ttsContent: string;
}

export default function ReaderTopBar({ activeTab, onTabChange, ttsContent }: Props) {
  return (
    <Box
      sx={{
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'space-between',
        gap: 2,
        px: { xs: 2, md: 4 },
        py: 1.5,
        borderBottom: `1px solid ${tokens.color.border}`,
        bgcolor: tokens.color.surface,
      }}
    >
      <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
        <Typography variant="overline" sx={{ color: tokens.color.textMuted }}>
          Reader Tools
        </Typography>
        <Box sx={{ display: 'flex', gap: 0.5 }}>
          <Tooltip title="Lessons">
            <IconButton
              onClick={() => onTabChange(activeTab === 1 ? 0 : 1)}
              sx={{ color: activeTab === 1 ? tokens.color.primary : tokens.color.textMuted }}
            >
              <LibraryBooksOutlinedIcon />
            </IconButton>
          </Tooltip>
          <Tooltip title="Dictionary">
            <IconButton
              onClick={() => onTabChange(activeTab === 2 ? 0 : 2)}
              sx={{ color: activeTab === 2 ? tokens.color.primary : tokens.color.textMuted }}
            >
              <MenuBookOutlinedIcon />
            </IconButton>
          </Tooltip>
          <Tooltip title="Details">
            <IconButton
              onClick={() => onTabChange(activeTab === 3 ? 0 : 3)}
              sx={{ color: activeTab === 3 ? tokens.color.primary : tokens.color.textMuted }}
            >
              <SettingsOutlinedIcon />
            </IconButton>
          </Tooltip>
          <Tooltip title="Study">
            <IconButton
              onClick={() => onTabChange(activeTab === 4 ? 0 : 4)}
              sx={{ color: activeTab === 4 ? tokens.color.primary : tokens.color.textMuted }}
            >
              <SchoolOutlinedIcon />
            </IconButton>
          </Tooltip>
        </Box>
      </Box>

      <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
        <ReaderPageAudioButton content={ttsContent} />
      </Box>
    </Box>
  );
}
