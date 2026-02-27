'use client';

import React from 'react';
import {
  Checkbox as MuiCheckbox,
  CheckboxProps as MuiCheckboxProps,
  FormControlLabel,
} from '@mui/material';

export interface CheckboxProps extends MuiCheckboxProps {
  /**
   * Label text
   */
  label?: string;
}

/**
 * Checkbox with optional label
 */
export const Checkbox: React.FC<CheckboxProps> = ({ label, ...props }) => {
  if (label) {
    return <FormControlLabel control={<MuiCheckbox {...props} />} label={label} />;
  }
  return <MuiCheckbox {...props} />;
};

export default Checkbox;
