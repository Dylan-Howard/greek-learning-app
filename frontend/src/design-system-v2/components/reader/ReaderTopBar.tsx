'use client';

import React, { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import IconButton from '@mui/material/IconButton';
import Tooltip from '@mui/material/Tooltip';
import FormControl from '@mui/material/FormControl';
import Select from '@mui/material/Select';
import MenuItem from '@mui/material/MenuItem';
import Typography from '@mui/material/Typography';
import SettingsOutlinedIcon from '@mui/icons-material/SettingsOutlined';
import LibraryBooksOutlinedIcon from '@mui/icons-material/LibraryBooksOutlined';
import SchoolOutlinedIcon from '@mui/icons-material/SchoolOutlined';
import MenuBookOutlinedIcon from '@mui/icons-material/MenuBookOutlined';
import { tokens } from '@/design-system-v2/theme/theme';
import ReaderPageAudioButton from '@/components/features/reader/ReaderPageAudioButton';
import {
  DEV_USER_OPTIONS,
  getActiveDevUserId,
  setActiveDevUserId,
} from '@/lib/services/auth/devSession';

interface Props {
  activeTab: number;
  onTabChange: (tabId: number) => void;
  ttsContent: string;
}

export default function ReaderTopBar({ activeTab, onTabChange, ttsContent }: Props) {
  const [devUserId, setDevUserId] = useState('1');

  useEffect(() => {
    setDevUserId(getActiveDevUserId());
  }, []);

  const handleUserChange = (nextUserId: string) => {
    const id = setActiveDevUserId(nextUserId);
    setDevUserId(id);
  };

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
        <FormControl size="small" sx={{ minWidth: 140 }}>
          <Select value={devUserId} onChange={(evt) => handleUserChange(`${evt.target.value}`)}>
            {DEV_USER_OPTIONS.map((id: string) => (
              <MenuItem value={id} key={`dev-user-${id}`}>{`Dev User ${id}`}</MenuItem>
            ))}
          </Select>
        </FormControl>
      </Box>
    </Box>
  );
}
