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
import CloseIcon from '@mui/icons-material/Close';

export interface DialogPropsV2 extends DialogProps {
  title: string;
  dialogContent: React.ReactNode;
  actions?: React.ReactNode;
  showClose?: boolean;
  onClose?: () => void;
  disableBackdropClose?: boolean;
}

export function Dialog({
  title,
  dialogContent,
  actions,
  showClose,
  onClose,
  disableBackdropClose = false,
  ...props
}: DialogPropsV2) {
  return (
    <MuiDialog
      onClose={(_, reason) => {
        if (disableBackdropClose && reason === 'backdropClick') return;
        onClose?.();
      }}
      {...props}
    >
      <DialogTitle sx={{ pr: 6 }}>
        <Box sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
          {title}
          {showClose && (
            <IconButton onClick={() => onClose?.()} size="small" aria-label="Close dialog">
              <CloseIcon />
            </IconButton>
          )}
        </Box>
      </DialogTitle>
      <DialogContent sx={{ pt: 1 }}>{dialogContent}</DialogContent>
      {actions && <DialogActions sx={{ px: 3, pb: 2, pt: 1 }}>{actions}</DialogActions>}
    </MuiDialog>
  );
}
