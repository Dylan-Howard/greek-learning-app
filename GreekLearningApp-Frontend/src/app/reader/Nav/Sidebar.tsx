'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Slide from '@mui/material/Slide';
import Container from '@mui/material/Container';
import useMediaQuery from '@mui/material/useMediaQuery';
import IconButton from '@mui/material/IconButton';
import CloseIcon from '@mui/icons-material/Close';
import DragHandleIcon from '@mui/icons-material/DragHandle';

import { useReaderContext } from '../ReaderPage/ReaderPageContext';
import DetailsMenu from './DetailsMenu';
import SettingsMenu from './SettingsMenu';

function MenuCloseButton({ onClose }: { onClose: () => void }) {
  return (
    <Box sx={{ display: 'flex', justifyContent: 'flex-end', pt: 2 }}>
      <IconButton onClick={onClose}>
        <CloseIcon />
      </IconButton>
    </Box>
  );
}

function MenuHandle({ onTouchClose }: { onTouchClose: () => void }) {
  return (
    <Box 
      sx={{ display: 'flex', justifyContent: 'center', py: 1, cursor: 'ns-resize' }}
      onClick={onTouchClose}
    >
      <DragHandleIcon />
    </Box>
  );
}

export default function Sidebar() {
  const { page, setPage } = useReaderContext();
  const gt600px = useMediaQuery('(min-width:600px)');

  const tabs = [
    { title: 'Lessons', iconName: 'lessons' },
    { title: 'Vocab', iconName: 'dictionary' },
    { title: 'Details', iconName: 'details' },
  ];

  const currentTab = page?.tabId !== undefined && page.tabId > 0 ? tabs[page.tabId - 1] : null;
  const title = currentTab ? currentTab.title : '';

  const handleClose = () => setPage({ ...page, tabId: 0 });

  return (
    <Box
      sx={{
        position: 'fixed',
        bottom: { xs: 'calc(72.5px + env(safe-area-inset-bottom))', sm: 0 },
        left: { xs: 0, sm: 80 },
        right: { xs: 0, sm: 'auto' },
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
            height: { xs: 'auto', sm: '100vh' },
            overflowY: 'auto',
          }}
        >
          <Container sx={{
            bgcolor: 'background.paper',
            minHeight: { xs: 300, sm: '100vh' },
            pb: 4,
          }}
          >
            {
              gt600px
                ? <MenuCloseButton onClose={() => handleClose()} />
                : <MenuHandle onTouchClose={() => handleClose()} />
            }
            {
                page?.tabId === 3
                  ? <DetailsMenu />
                  : <SettingsMenu title={title} />
              }
          </Container>
        </Paper>
      </Slide>
    </Box>
  );
}
