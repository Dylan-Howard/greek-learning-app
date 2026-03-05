'use client';

import React from 'react';
import {
  IconButton as MuiIconButton,
  IconButtonProps as MuiIconButtonProps,
  Tooltip as MuiTooltip,
  styled,
} from '@mui/material';

export interface IconButtonProps extends MuiIconButtonProps {
  /**
   * Tooltip text to show on hover
   */
  tooltip?: string;
  /**
   * Optional href to render as an anchor-style button
   */
  href?: string;
}

const StyledIconButton = styled(MuiIconButton)(({ theme }) => ({
  transition: theme.transitions.create(['background-color', 'transform'], {
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
 * Icon button with optional tooltip
 */
export const IconButton: React.FC<IconButtonProps> = ({
  tooltip,
  href,
  children,
  onClick,
  ...props
}) => {
  const handleClick: React.MouseEventHandler<HTMLButtonElement> = (event) => {
    onClick?.(event);
    if (!event.defaultPrevented && href) {
      window.location.assign(href);
    }
  };

  const button = (
    <StyledIconButton
      {...props}
      onClick={href || onClick ? handleClick : undefined}
    >
      {children}
    </StyledIconButton>
  );

  if (tooltip) {
    return <MuiTooltip title={tooltip}>{button}</MuiTooltip>;
  }

  return button;
};

export default IconButton;
