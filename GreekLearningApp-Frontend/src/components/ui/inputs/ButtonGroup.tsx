'use client';

import React from 'react';
import {
  ButtonGroup as MuiButtonGroup,
  ButtonGroupProps as MuiButtonGroupProps,
} from '@mui/material';
import Button from './Button';

export interface ButtonGroupProps extends MuiButtonGroupProps {
  /**
   * Buttons to render in the group
   */
  buttons: Array<{
    label: string;
    onClick: () => void;
    disabled?: boolean;
    startIcon?: React.ReactNode;
    endIcon?: React.ReactNode;
  }>;
}

/**
 * Group of related buttons
 */
export const ButtonGroup: React.FC<ButtonGroupProps> = ({
  buttons,
  ...props
}) => {
  return (
    <MuiButtonGroup {...props}>
      {buttons.map((button, index) => (
        <Button
          key={index}
          onClick={button.onClick}
          disabled={button.disabled}
          startIcon={button.startIcon}
          endIcon={button.endIcon}
        >
          {button.label}
        </Button>
      ))}
    </MuiButtonGroup>
  );
};

export default ButtonGroup;
