'use client';

import {
  MouseEventHandler,
  // Suspense,
  TouchEventHandler,
  useState,
} from 'react';

import useMediaQuery from '@mui/material/useMediaQuery';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Slide from '@mui/material/Slide';
import Stack from '@mui/material/Stack';
import Avatar from '@mui/material/Avatar';
import Typography from '@mui/material/Typography';
import CloseIcon from '@mui/icons-material/Close';
import Container from '@mui/material/Container';
import IconButton from '@mui/material/IconButton';

// import { SettingsMenuTabSkeleton } from 'app/modules/Skeletons';
import DetailsMenu from '@/components/features/reader/Navigation/DetailsMenu';
import ReaderStudyMenu from '@/components/features/reader/Navigation/ReaderStudyMenu';
import SettingsMenu from '@/components/features/reader/Navigation/SettingsMenu';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';
import { useUserContext } from '@/lib/types/domain/user';
import {
  avatarColorFromUserId,
  avatarInitial,
  inLevelExperience,
  levelFromExperience,
  XP_PER_LEVEL,
} from '@/lib/services/user/gamification';

function MenuHandle({ onTouchClose }: { onTouchClose: TouchEventHandler }) {
  const [swipe, setSwipe] = useState({ start: 0 });
  const swipeCloseDistance = 50;

  const handleTouchStart = (e: any) => {
    setSwipe({ start: e.touches[0].clientY });
  };

  const handleTouchEnd = (e: any) => {
    const swipeDistance = e.changedTouches[0].clientY - swipe.start;
    if (swipeCloseDistance < swipeDistance) {
      onTouchClose(e);
    }
  };

  return (
    <Stack
      flexDirection="row"
      justifyContent="center"
      onTouchStart={(e: any) => handleTouchStart(e)}
      onTouchEnd={(e: any) => handleTouchEnd(e)}
      sx={{ pt: 2, pb: 2 }}
    >
      <Box
        sx={{
          border: '1px solid',
          borderColor: 'divider',
          width: 48,
        }}
      />
    </Stack>
  );
}

function MenuCloseButton({ onClose }: { onClose: MouseEventHandler<HTMLButtonElement> }) {
  return (
    <Stack flexDirection="row" justifyContent="end" sx={{ pt: 2, pb: 2 }}>
      <IconButton aria-label="close" onClick={onClose}>
        <CloseIcon />
      </IconButton>
    </Stack>
  );
}

export default function Sidebar() {
  const { user } = useUserContext();
  const { page, setPage } = useReaderContext();
  const gt600px = useMediaQuery('(min-width:600px)');

  const titleByTab: Record<number, string> = {
    1: 'Lessons',
    2: 'Dictionary',
    3: 'Details',
    4: 'Study',
  };
  const title = titleByTab[page?.tabId || 0] || '';

  const handleClose = () => setPage({
    ...page,
    tabId: 0,
    morphologyId: 0,
    selectedUnit: undefined,
  });

  return (
    <Box
      sx={{
        position: 'fixed',
        bottom: { xs: 'calc(72.5px + env(safe-area-inset-bottom))', sm: 'auto' },
        left: { xs: 'auto', sm: 142 },
        zIndex: 1100,
        maxWidth: { xs: 'none', sm: 350 },
      }}
    >
      <Slide
        direction={gt600px ? 'right' : 'up'}
        in={page?.tabId !== 0}
        timeout={200}
        mountOnEnter
        unmountOnExit
      >
        <Paper
          sx={{
            bgcolor: 'background.default',
            borderTopLeftRadius: { xs: 24, sm: 0 },
            borderTopRightRadius: { xs: 24, sm: 0 },
            boxShadow: 'rgba(99, 99, 99, 0.2) 0px -2px 8px 0px',
          }}
        >
          <Container sx={{
            bgcolor: 'background.tertiary',
            height: gt600px ? '100vh' : 100,
            pr: { xs: 4, sm: 2 },
            pl: { xs: 4, sm: 2 },
            borderTopLeftRadius: { xs: 24, sm: 0 },
            borderTopRightRadius: { xs: 24, sm: 0 },
            width: { xs: '100vw', sm: 'auto' },
          }}
          >
            {
              gt600px
                ? <MenuCloseButton onClose={() => handleClose()} />
                : <MenuHandle onTouchClose={() => handleClose()} />
            }
            <Stack direction="row" spacing={1.5} alignItems="center" sx={{ pb: 2 }}>
              <Avatar
                sx={{
                  width: 36,
                  height: 36,
                  bgcolor: avatarColorFromUserId(user?.id),
                  fontSize: 14,
                  fontWeight: 700,
                }}
              >
                {avatarInitial(user?.name)}
              </Avatar>
              <Box>
                <Typography variant="body2" sx={{ fontWeight: 700 }}>
                  {user?.name || 'Scholar'}
                </Typography>
                <Typography variant="caption" color="text.secondary">
                  {`Lv ${levelFromExperience(user?.totalExp ?? 0)} · ${inLevelExperience(user?.totalExp ?? 0)}/${XP_PER_LEVEL} XP`}
                </Typography>
              </Box>
            </Stack>
            {
                page?.tabId === 3
                  ? <DetailsMenu />
                  : page?.tabId === 4
                    ? <ReaderStudyMenu />
                    : <SettingsMenu title={title} />
              }
          </Container>
        </Paper>
      </Slide>
    </Box>
  );
}
