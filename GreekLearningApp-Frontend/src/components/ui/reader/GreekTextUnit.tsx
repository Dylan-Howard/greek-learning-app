'use client';

import React from 'react';
import {
  Box,
  Typography,
  styled,
  alpha,
} from '@mui/material';

export interface GreekTextUnitProps {
  /**
   * Greek word/text
   */
  greekText: string;
  /**
   * Interlinear help text (English translation)
   */
  helpText?: string;
  /**
   * Click handler
   */
  onClick?: () => void;
  /**
   * Highlight state
   */
  highlighted?: boolean;
  /**
   * Disabled/non-interactive state
   */
  disabled?: boolean;
}

const GreekTextRoot = styled(Box, {
  shouldForwardProp: (prop) => prop !== 'highlighted' && prop !== 'clickable',
})<{ highlighted?: boolean; clickable?: boolean }>(({ theme, highlighted, clickable }) => ({
  display: 'inline-flex',
  flexDirection: 'column',
  alignItems: 'center',
  gap: theme.spacing(0.5),
  padding: theme.spacing(0.5, 1),
  borderRadius: 4,
  cursor: clickable ? 'pointer' : 'default',
  transition: theme.transitions.create(['background-color'], {
    duration: theme.transitions.duration.shorter,
  }),
  ...(clickable && {
    '&:hover': {
      backgroundColor: theme.vars.palette.neutral.subtle,
    },
  }),
  ...(highlighted && {
    backgroundColor: alpha(theme.vars.palette.primary.main, 0.1),
  }),
}));

/**
 * Interactive Greek text unit with optional interlinear help
 */
export const GreekTextUnit: React.FC<GreekTextUnitProps> = ({
  greekText,
  helpText,
  onClick,
  highlighted,
  disabled,
}) => {
  return (
    <GreekTextRoot
      highlighted={highlighted}
      clickable={!disabled && !!onClick}
      onClick={!disabled ? onClick : undefined}
    >
      <Typography variant="greekBody" component="span">
        {greekText}
      </Typography>
      {helpText && (
        <Typography variant="greekHelp" component="span" color="text.secondary">
          {helpText}
        </Typography>
      )}
    </GreekTextRoot>
  );
};

export default GreekTextUnit;
