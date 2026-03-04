'use client';

import React from 'react';
import { useEffect, useState } from 'react';
import {
  Box,
  FormControl,
  MenuItem,
  Select,
} from '@mui/material';
import {
  DEV_USER_OPTIONS,
  getActiveDevUserId,
  setActiveDevUserId,
} from '@/lib/services/auth/devSession';

import BottomNavigation from '@mui/material/BottomNavigation';
import BottomNavigationAction from '@mui/material/BottomNavigationAction';

import AbcIcon from '@mui/icons-material/Abc';
import LibraryBooksIcon from '@mui/icons-material/LibraryBooks';
import PersonIcon from '@mui/icons-material/Person';
import SchoolIcon from '@mui/icons-material/School';

import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';

export default function Nav() {
  const devUserLabel: Record<string, string> = {
    '1': 'Dev Novice',
    '2': 'Dev 100+',
    '3': 'Dev 50+',
    '4': 'Dev 15+',
    '5': 'Dev Mastered',
  };
  const { page, setPage } = useReaderContext();
  const [devUserId, setDevUserId] = useState('1');

  useEffect(() => {
    setDevUserId(getActiveDevUserId());
  }, []);

  const handleChange = (_e: any, newTab: number) => {
    if (newTab === 5) {
      return;
    }
    setPage({ ...page, tabId: newTab });
  };

  const handleUserChange = (nextUserId: string) => {
    const id = setActiveDevUserId(nextUserId);
    setDevUserId(id);
  };

  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: { xs: 'column', sm: 'column' },
        bgcolor: 'background.secondary',
      }}
    >
      <FormControl size="small" sx={{ p: 1 }}>
        <Select value={devUserId} onChange={(evt) => handleUserChange(`${evt.target.value}`)}>
          {DEV_USER_OPTIONS.map((id: string) => (
            <MenuItem value={id} key={`dev-user-${id}`}>{devUserLabel[id] || `Dev User ${id}`}</MenuItem>
          ))}
        </Select>
      </FormControl>

      <BottomNavigation
        showLabels
        value={page?.tabId}
        onChange={(e, newValue) => handleChange(e, newValue)}
        sx={{
          flexDirection: { xs: 'row', sm: 'column' },
          height: { xs: 'auto', sm: '100vh' },
          maxHeight: { xs: 600, sm: 300 },
          mt: { xs: 0, sm: 0 },
          bgcolor: 'background.secondary',
        }}
      >
        <BottomNavigationAction
          value={1}
          label="Lessons"
          icon={<LibraryBooksIcon />}
        />
        <BottomNavigationAction
          value={2}
          label="Vocab"
          icon={<AbcIcon />}
        />
        {
          page && page.morphologyId
            ? (
              <BottomNavigationAction
                value={3}
                label="Details"
                icon={<LibraryBooksIcon />}
              />
            )
            : ''
        }
        <BottomNavigationAction
          value={4}
          label="Study"
          icon={<SchoolIcon />}
        />
        <BottomNavigationAction
          value={5}
          label="Profile"
          icon={<PersonIcon />}
          href="/profile"
        />
      </BottomNavigation>
    </Box>
  );
}
