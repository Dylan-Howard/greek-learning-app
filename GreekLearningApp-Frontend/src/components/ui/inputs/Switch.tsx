'use client';

import React from 'react';
import {
  FormControlLabel,
  Switch as MuiSwitch,
  SwitchProps as MuiSwitchProps,
} from '@mui/material';

export interface SwitchProps extends MuiSwitchProps {
  /**
   * Label text
   */
  label?: string;
}

/**
 * Switch with optional label
 */
export const Switch: React.FC<SwitchProps> = ({ label, ...props }) => {
  if (label) {
    return <FormControlLabel control={<MuiSwitch {...props} />} label={label} />;
  }
  return <MuiSwitch {...props} />;
};

export default Switch;
