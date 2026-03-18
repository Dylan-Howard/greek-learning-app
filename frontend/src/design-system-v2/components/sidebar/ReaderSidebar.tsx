'use client';
// src/components/sidebar/ReaderSidebar.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Divider from '@mui/material/Divider';
import { tokens } from '@/design-system-v2/theme/theme';
import WordDetailPanel, { type ParsedWord } from './WordDetailPanel';
import StudyLaunchPanel from './StudyLaunchPanel';
import SRSStudyPanel, { type SRSCard } from '@/design-system-v2/components/srs/SRSStudyPanel';
import XPToast from '@/design-system-v2/components/gamification/XPToast';
import { type SRSRating } from '@/design-system-v2/components/srs/SRSRatingButtons';

interface Props {
  selectedWord:  ParsedWord | null;
  dueCards:      SRSCard[];
  onRate:        (cardId: string, rating: SRSRating) => void;
  onXPEarned?:   (xp: number) => void;
}

export default function ReaderSidebar({
  selectedWord,
  dueCards,
  onRate,
  onXPEarned,
}: Props) {
  const [studyMode, setStudyMode] = useState(false);
  const [toastXP, setToastXP]     = useState<number | null>(null);

  function handleRate(cardId: string, rating: SRSRating) {
    const xp = rating === 'easy' ? 10 : rating === 'good' ? 7 : rating === 'hard' ? 4 : 2;
    onRate(cardId, rating);
    setToastXP(xp);
    onXPEarned?.(xp);
  }

  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', height: '100%', overflow: 'hidden', position: 'relative' }}>
      {studyMode ? (
        <SRSStudyPanel
          cards={dueCards}
          onRate={handleRate}
          onClose={() => setStudyMode(false)}
          size="compact"
        />
      ) : (
        <>
          {/* Word details — scrollable */}
          <Box sx={{ flex: 1, overflowY: 'auto' }}>
            <WordDetailPanel word={selectedWord} />
          </Box>

          <Divider />

          {/* Study launch — sticky at bottom */}
          <StudyLaunchPanel
            dueCount={dueCards.length}
            onStartStudy={() => setStudyMode(true)}
          />
        </>
      )}

      {/* XP toast */}
      {toastXP !== null && (
        <XPToast xp={toastXP} onDone={() => setToastXP(null)} />
      )}
    </Box>
  );
}
