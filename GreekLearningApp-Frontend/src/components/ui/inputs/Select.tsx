'use client';

import React from 'react';
import {
  FormControl,
  InputLabel,
  MenuItem,
  Select as MuiSelect,
  SelectProps as MuiSelectProps,
} from '@mui/material';

export interface SelectOption {
  value: string | number;
  label: string;
  disabled?: boolean;
}

export interface SelectProps extends Omit<MuiSelectProps, 'children'> {
  /**
   * Options to display
   */
  options: SelectOption[];
  /**
   * Optional label
   */
  label?: string;
}

/**
 * Select dropdown component
 */
export const Select: React.FC<SelectProps> = ({ options, label, ...props }) => {
  return (
    <FormControl fullWidth={props.fullWidth}>
      {label && <InputLabel>{label}</InputLabel>}
      <MuiSelect label={label} {...props}>
        {options.map((option) => (
          <MenuItem
            key={option.value}
            value={option.value}
            disabled={option.disabled}
          >
            {option.label}
          </MenuItem>
        ))}
      </MuiSelect>
    </FormControl>
  );
};

export default Select;
