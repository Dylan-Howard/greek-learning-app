'use client';

import React from 'react';
import {
  Fab as MuiFab,
  FabProps as MuiFabProps,
  Tooltip as MuiTooltip,
  styled,
} from '@mui/material';

export interface FabProps extends MuiFabProps {
  /**
   * Tooltip text
   */
  tooltip?: string;
}

const StyledFab = styled(MuiFab)(({ theme }) => ({
  transition: theme.transitions.create(['transform', 'box-shadow'], {
    duration: theme.transitions.duration.shorter,
  }),
  '&:hover': {
    transform: 'scale(1.05)',
  },
  '&:active': {
    transform: 'scale(0.95)',
  },
}));

/**
 * Floating action button for primary actions
 */
export const Fab: React.FC<FabProps> = ({ tooltip, children, ...props }) => {
  const fab = <StyledFab {...props}>{children}</StyledFab>;

  if (tooltip) {
    return <MuiTooltip title={tooltip}>{fab}</MuiTooltip>;
  }

  return fab;
};

export default Fab;
