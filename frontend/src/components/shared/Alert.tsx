'use client';

import React from 'react';
import MuiAlert, { AlertProps as MuiAlertProps } from '@mui/material/Alert';
import { tokens } from '@/design-system-v2/theme/theme';

export interface AlertProps extends MuiAlertProps {
  message: string;
  closable?: boolean;
  onClose?: () => void;
}

export function Alert({ message, closable, onClose, sx, ...props }: AlertProps) {
  return (
    <MuiAlert
      onClose={closable ? () => onClose?.() : undefined}
      sx={{ borderRadius: tokens.radius.sm, ...sx }}
      {...props}
    >
      {message}
    </MuiAlert>
  );
}
