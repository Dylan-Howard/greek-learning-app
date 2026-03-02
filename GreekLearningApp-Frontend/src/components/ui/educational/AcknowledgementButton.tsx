'use client';

import React from 'react';
import {
  styled,
  alpha,
} from '@mui/material';
import {
  Check as CheckIcon,
} from '@mui/icons-material';
import Button from '../inputs/Button';

export interface AcknowledgementButtonProps {
  /**
   * Button text
   */
  text: string;
  /**
   * Acknowledgement state
   */
  acknowledged: boolean;
  /**
   * Click handler
   */
  onClick: () => void;
  /**
   * Icon to show when acknowledged
   */
  acknowledgedIcon?: React.ReactNode;
}

const AckButton = styled(Button, {
  shouldForwardProp: (prop) => prop !== 'acknowledged',
})<{ acknowledged?: boolean }>(({ theme, acknowledged }) => {
  const palette = theme.vars?.palette ?? theme.palette;
  return {
  transition: theme.transitions.create(['background-color', 'border-color'], {
    duration: theme.transitions.duration.standard,
  }),
  ...(acknowledged && {
    backgroundColor: alpha(palette.success.main, 0.1),
    borderColor: palette.success.main,
    color: palette.success.dark,
    '&:hover': {
      backgroundColor: alpha(palette.success.main, 0.2),
    },
  }),
  };
});

/**
 * Button for confirming user acknowledgement of information
 */
export const AcknowledgementButton: React.FC<AcknowledgementButtonProps> = ({
  text,
  acknowledged,
  onClick,
  acknowledgedIcon = <CheckIcon />,
}) => {
  return (
    <AckButton
      variant="outlined"
      acknowledged={acknowledged}
      onClick={onClick}
      endIcon={acknowledged ? acknowledgedIcon : undefined}
      fullWidth
    >
      {acknowledged ? 'Acknowledged' : text}
    </AckButton>
  );
};

export default AcknowledgementButton;
