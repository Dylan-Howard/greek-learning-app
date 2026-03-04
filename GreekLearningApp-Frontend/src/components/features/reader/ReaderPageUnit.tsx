'use client';

import { ReactNode } from 'react';

import Typography from '@mui/material/Typography';
import { useTheme } from '@mui/material/styles';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';

export function ReaderPageUnitHelp({ children } : { children: ReactNode }) {
  const theme = useTheme();

  return (
    <Typography
      variant="greekHelp"
      sx={{
        display: 'inline-block',
        color: theme.palette.text.primary,
        mr: 1,
      }}
    >
      {children}
    </Typography>
  );
}

export function ReaderPageUnit({ children } : { children: ReactNode }) {
  const theme = useTheme();

  return (
    <Typography
      variant="greekBody"
      sx={{
        color: theme.palette.text.primary,
        cursor: 'pointer',
        mr: 1,
        '&:hover': { color: theme.palette.primary.main },
      }}
    >
      {children}
    </Typography>
  // <Box
  //   role="button"
  //   tabIndex={0}
  //   onClick={() => handleClick()}
  //   sx={{ display: 'inline-block' }}
  // >

  //   {
  //     helpText
  //       ? (
  //         <Typography
  //           sx={{
  //             display: 'inline-block',
  //             color: theme.palette.text.primary,
  //             fontFamily: 'Noto Serif, serif',
  //             fontSize: theme.typography.readerHelp.fontSize,
  //             lineHeight: theme.typography.readerHelp.lineHeight,
  //             mr: 1,
  //           }}
  //         >
  //           {helpText}
  //         </Typography>
  //       )
  //       : ''
  //     }
  // </Box>
  );
}

export function ReaderPageUnitText(
  { children, type, morphologyId } : { children: ReactNode, type?: string, morphologyId?: number },
) {
  const theme = useTheme();
  const { page } = useReaderContext();

  const ratedState = morphologyId ? page?.study?.ratedStates?.[morphologyId] : undefined;

  let color = theme.palette.text.primary;
  if (ratedState === 'accepted') {
    color = theme.palette.success.main;
  } else if (ratedState === 'rejected') {
    color = theme.palette.error.main;
  } else if (type === 'translated') {
    color = theme.palette.text.secondary;
  } else if (type === 'original_practice') {
    color = theme.palette.warning.main;
  } else if (type === 'original_mastered') {
    color = theme.palette.grey[500];
  }

  return (
    <Typography
      variant="greekBody"
      sx={{
        color,
        cursor: 'pointer',
        mr: 1,
        '&:hover': { color: theme.palette.primary.main },
      }}
    >
      {children}
    </Typography>
  );
}
