'use client';

import React from 'react';
import {
  Box,
  TextField as MuiTextField,
  TextFieldProps as MuiTextFieldProps,
} from '@mui/material';

export interface TextFieldProps extends Omit<MuiTextFieldProps, 'variant'> {
  /**
   * Show character count
   */
  showCount?: boolean;
  /**
   * Maximum character length
   */
  maxLength?: number;
}

/**
 * Enhanced text field with character count
 */
export const TextField: React.FC<TextFieldProps> = ({
  showCount,
  maxLength,
  helperText,
  value,
  ...props
}) => {
  const count = value ? String(value).length : 0;

  return (
    <MuiTextField
      value={value}
      inputProps={{ maxLength }}
      helperText={
        showCount ? (
          <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
            <span>{helperText}</span>
            <span>
              {count}
              {maxLength && `/${maxLength}`}
            </span>
          </Box>
        ) : (
          helperText
        )
      }
      {...props}
    />
  );
};

export default TextField;
