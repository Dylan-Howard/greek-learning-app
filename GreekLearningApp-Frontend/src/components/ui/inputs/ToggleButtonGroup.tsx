'use client';

import React from 'react';
import {
  Box,
  ToggleButton as MuiToggleButton,
  ToggleButtonGroup as MuiToggleButtonGroup,
  ToggleButtonGroupProps,
} from '@mui/material';

export interface ToggleButtonGroupComponentProps extends ToggleButtonGroupProps {
  /**
   * Options to display
   */
  options: Array<{
    value: string;
    label: string;
    icon?: React.ReactNode;
    disabled?: boolean;
  }>;
}

/**
 * Toggle button group for mutually exclusive options
 */
export const ToggleButtonGroupComponent: React.FC<
  ToggleButtonGroupComponentProps
> = ({ options, ...props }) => {
  return (
    <MuiToggleButtonGroup {...props}>
      {options.map((option) => (
        <MuiToggleButton
          key={option.value}
          value={option.value}
          disabled={option.disabled}
        >
          {option.icon && <Box sx={{ mr: 1, display: 'flex' }}>{option.icon}</Box>}
          {option.label}
        </MuiToggleButton>
      ))}
    </MuiToggleButtonGroup>
  );
};

export default ToggleButtonGroupComponent;
