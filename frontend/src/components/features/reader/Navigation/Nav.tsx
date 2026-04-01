'use client';

import React from 'react';
import {
  Box,
  Stack,
} from '@mui/material';

import BottomNavigation from '@mui/material/BottomNavigation';
import BottomNavigationAction from '@mui/material/BottomNavigationAction';

import AbcIcon from '@mui/icons-material/Abc';
import LibraryBooksIcon from '@mui/icons-material/LibraryBooks';
import PersonIcon from '@mui/icons-material/Person';
import SchoolIcon from '@mui/icons-material/School';

import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';
import { useUserContext } from '@/lib/types/domain/user';
import { ExpAvatarBadge } from '@/components/shared/ExpGainAnimation';
import {
  avatarInitial,
  XP_PER_LEVEL,
} from '@/lib/services/user/gamification';

export default function Nav() {
  const { user, expQueue, consumeExp } = useUserContext();
  const { page, setPage } = useReaderContext();

  const handleChange = (_e: unknown, newTab: number) => {
    if (newTab === 5) {
      return;
    }
    setPage({ ...page, tabId: newTab });
  };

  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: { xs: 'column', sm: 'column' },
        bgcolor: 'background.secondary',
      }}
    >

      <BottomNavigation
        showLabels
        value={page?.tabId}
        onChange={(e, newValue) => handleChange(e, newValue)}
        sx={{
          flexDirection: { xs: 'row', sm: 'column' },
          height: { xs: 'auto', sm: '100vh' },
          maxHeight: { xs: 600, sm: 'none' },
          mt: { xs: 0, sm: 0 },
          bgcolor: 'background.secondary',
          alignItems: { xs: 'center', sm: 'stretch' },
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
          sx={{ textDecoration: 'none'}}
        />
        <Box sx={{ display: { xs: 'none', sm: 'block' }, mt: 'auto', px: 1.5, pb: 2 }}>
          <Stack
            spacing={0.75}
            alignItems="center"
            sx={{
              p: 1.25,
              borderRadius: 2,
              border: '1px solid',
              borderColor: 'divider',
              bgcolor: 'background.paper',
            }}
          >
            <ExpAvatarBadge
              totalExp={Math.max(0, (user?.totalExp ?? 0) - (expQueue[0] ?? 0))}
              gainedExp={expQueue[0] ?? 0}
              xpPerLevel={XP_PER_LEVEL}
              avatarSrc={undefined}
              avatarInitial={avatarInitial(user?.name)}
              showMeta
              onAnimationComplete={() => consumeExp()}
            />
          </Stack>
        </Box>
      </BottomNavigation>
    </Box>
  );
}
