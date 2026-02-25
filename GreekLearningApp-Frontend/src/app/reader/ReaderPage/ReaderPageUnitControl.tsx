'use client';

import { ReactNode } from 'react';
import Box from '@mui/material/Box';
import { useReaderContext } from './ReaderPageContext';
import { Unitv2 } from '../../modules/Text';

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

  const handleHover = () => setPage({
    ...page,
    morphologyId: unit.morphologyId,
    selectedUnit,
  });

  const handleClick = () => setPage({
    ...page,
    tabId: 3,
    morphologyId: unit.morphologyId,
    selectedUnit,
  });

  return (
    <Box
      role="button"
      tabIndex={0}
      onMouseEnter={handleHover}
      onClick={() => handleClick()}
      sx={{ display: 'inline-block' }}
    >
      {children}
    </Box>
  );
}
