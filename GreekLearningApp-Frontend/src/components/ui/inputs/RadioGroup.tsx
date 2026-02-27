'use client';

import React from 'react';
import {
  Box,
  FormControlLabel,
  Radio as MuiRadio,
  RadioGroup,
  Typography,
} from '@mui/material';

export interface RadioGroupOption {
  value: string;
  label: string;
  disabled?: boolean;
  helperText?: string;
}

export interface RadioGroupComponentProps {
  /**
   * Current value
   */
  value: string;
  /**
   * Change handler
   */
  onChange: (value: string) => void;
  /**
   * Options to display
   */
  options: RadioGroupOption[];
  /**
   * Group name
   */
  name?: string;
  /**
   * Display direction
   */
  row?: boolean;
}

/**
 * Radio group with options
 */
export const RadioGroupComponent: React.FC<RadioGroupComponentProps> = ({
  value,
  onChange,
  options,
  name,
  row,
}) => {
  return (
    <RadioGroup
      value={value}
      onChange={(e) => onChange(e.target.value)}
      name={name}
      row={row}
    >
      {options.map((option) => (
        <Box key={option.value}>
          <FormControlLabel
            value={option.value}
            control={<MuiRadio />}
            label={option.label}
            disabled={option.disabled}
          />
          {option.helperText && (
            <Typography variant="caption" sx={{ ml: 4, display: 'block' }}>
              {option.helperText}
            </Typography>
          )}
        </Box>
      ))}
    </RadioGroup>
  );
};

export default RadioGroupComponent;
