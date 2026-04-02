'use client';

import React, { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import IconButton from '@mui/material/IconButton';
import CloseIcon from '@mui/icons-material/Close';
import { tokens } from '@/theme/theme';
import BottomSheet, { type SnapPoint } from '@/components/mobile/BottomSheet';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';
import ReaderSettingsPanel from './ReaderSettingsPanel';
import ReaderDetailsPanel from './ReaderDetailsPanel';
import ReaderStudyPanel from './ReaderStudyPanel';

function PanelContent({ tabId }: { tabId: number }) {
  if (tabId === 3) {
    return <ReaderDetailsPanel />;
  }
  if (tabId === 4) {
    return <ReaderStudyPanel />;
  }
  if (tabId === 1) {
    return <ReaderSettingsPanel title="Lessons" />;
  }
  if (tabId === 2) {
    return <ReaderSettingsPanel title="Dictionary" />;
  }
  return null;
}

export default function ReaderPanels() {
  const { page, setPage } = useReaderContext();
  const tabId = page?.tabId ?? 0;
  const [snap, setSnap] = useState<SnapPoint>('hidden');

  useEffect(() => {
    setSnap(tabId === 0 ? 'hidden' : 'peek');
  }, [tabId]);

  const handleClose = () => {
    setPage({ ...page, tabId: 0 });
  };

  if (tabId === 0) {
    return null;
  }

  const panel = (
    <Box sx={{ display: 'flex', flexDirection: 'column', height: '100%' }}>
      <Box sx={{ display: 'flex', justifyContent: 'flex-end', px: 2, pt: 1 }}>
        <IconButton aria-label="Close panel" onClick={handleClose}>
          <CloseIcon />
        </IconButton>
      </Box>
      <Box sx={{ flex: 1, overflowY: 'auto' }}>
        <PanelContent tabId={tabId} />
      </Box>
    </Box>
  );

  return (
    <>
      <Box
        sx={{
          display: { xs: 'none', md: 'flex' },
          width: 320,
          position: 'fixed',
          top: 64,
          right: 0,
          height: 'calc(100vh - 64px)',
          flexDirection: 'column',
          bgcolor: tokens.color.surface,
          borderLeft: `1px solid ${tokens.color.border}`,
          zIndex: 1100,
        }}
      >
        {panel}
      </Box>

      <Box sx={{ display: { xs: 'block', md: 'none' } }}>
        <BottomSheet snap={snap} onSnapChange={setSnap}>
          {panel}
        </BottomSheet>
      </Box>
    </>
  );
}
