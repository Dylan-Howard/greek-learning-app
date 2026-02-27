'use client';

import React from 'react';
import {
  Box,
  Dialog as MuiDialog,
  DialogTitle,
  DialogContent,
  DialogActions,
  DialogProps,
  IconButton,
} from '@mui/material';
import { Close as CloseIcon } from '@mui/icons-material';

export interface DialogComponentProps extends DialogProps {
  /**
   * Dialog title
   */
  title: string;
  /**
   * Content
   */
  content: React.ReactNode;
  /**
   * Actions (buttons)
   */
  actions?: React.ReactNode;
  /**
   * Show close button
   */
  showClose?: boolean;
  /**
   * Close handler
   */
  onClose?: () => void;
}

/**
 * Modal dialog component
 */
export const DialogComponent: React.FC<DialogComponentProps> = ({
  title,
  content,
  actions,
  showClose,
  onClose,
  ...props
}) => {
  return (
    <MuiDialog onClose={onClose} {...props}>
      <DialogTitle>
        <Box sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
          {title}
          {showClose && onClose && (
            <IconButton onClick={onClose} size="small">
              <CloseIcon />
            </IconButton>
          )}
        </Box>
      </DialogTitle>
      <DialogContent>{content}</DialogContent>
      {actions && <DialogActions>{actions}</DialogActions>}
    </MuiDialog>
  );
};

export default DialogComponent;
