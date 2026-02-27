'use client';

import React from 'react';
import {
  Alert as MuiAlert,
  AlertProps as MuiAlertProps,
} from '@mui/material';

export interface AlertProps extends MuiAlertProps {
  /**
   * Alert message
   */
  message: string;
  /**
   * Show close button
   */
  closable?: boolean;
  /**
   * Close handler
   */
  onClose?: () => void;
}

/**
 * Alert component for feedback messages
 */
export const Alert: React.FC<AlertProps> = ({
  message,
  closable,
  onClose,
  ...props
}) => {
  return (
    <MuiAlert onClose={closable ? onClose : undefined} {...props}>
      {message}
    </MuiAlert>
  );
};

export default Alert;
