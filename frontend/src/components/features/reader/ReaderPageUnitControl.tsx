'use client';

import { KeyboardEvent, ReactNode } from 'react';
import Box from '@mui/material/Box';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';
import { Unitv2 } from '@/lib/types/domain/text';

export default function ReaderTextUnit(
  { children, unit } : { children: ReactNode, unit: Unitv2 },
) {
  const { page, setPage } = useReaderContext();
  const selectedUnit = {
    unitId: unit.unitId,
    content: unit.content,
    helpText: unit.helpText,
    morphologyId: unit.morphologyId,
    type: unit.type,
    path: unit.path,
    original: unit.original,
    translation: unit.translation,
    grammarFeatureIds: unit.grammarFeatureIds || [],
    syntacticalFeatureIds: unit.syntacticalFeatureIds || [],
    parentPhrases: unit.parentPhrases || [],
  };

  const handleClick = () => setPage({
    ...page,
    tabId: unit.type === 'original_practice' ? 4 : 3,
    morphologyId: unit.morphologyId,
    studyFocusWordId: unit.type === 'original_practice' ? unit.morphologyId : page.studyFocusWordId,
    selectedUnit,
  });

  const handleKeyDown = (event: KeyboardEvent<HTMLDivElement>) => {
    if (event.key === 'Enter' || event.key === ' ') {
      event.preventDefault();
      handleClick();
    }
  };

  return (
    <Box
      role="button"
      tabIndex={0}
      onClick={() => handleClick()}
      onKeyDown={handleKeyDown}
      sx={{
        display: 'inline-block',
        borderRadius: 0.5,
        transition: 'background-color 120ms ease',
        '&:hover': { backgroundColor: 'action.hover' },
      }}
    >
      {children}
    </Box>
  );
}
