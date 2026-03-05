'use client';

import React from 'react';
import {
  Button as MuiButton,
  ButtonProps as MuiButtonProps,
  CircularProgress,
  styled,
} from '@mui/material';

export interface ButtonProps extends MuiButtonProps {
  /**
   * Visual style variant
   * - contained: Solid background (primary CTA)
   * - outlined: Outlined with border (secondary actions)
   * - text: No background or border (tertiary actions)
   */
  variant?: 'contained' | 'outlined' | 'text';
  /**
   * Color theme
   */
  color?: 'primary' | 'secondary' | 'error' | 'warning' | 'info' | 'success';
  /**
   * Size variant
   */
  size?: 'small' | 'medium' | 'large';
  /**
   * Show loading state with spinner
   */
  loading?: boolean;
}

const StyledButton = styled(MuiButton, {
  shouldForwardProp: (prop) => prop !== 'loading',
})<{ loading?: boolean }>(({ theme, loading }) => ({
  position: 'relative',
  '&:hover': {
    transform: 'translateY(-1px)',
  },
  '&:active': {
    transform: 'translateY(0)',
  },
  ...(loading && {
    color: 'transparent',
    pointerEvents: 'none',
  }),
}));

const ButtonSpinner = styled(CircularProgress)({
  position: 'absolute',
  top: '50%',
  left: '50%',
  marginTop: -12,
  marginLeft: -12,
});

/**
 * Primary button component with loading state and hover animations
 */
export const Button: React.FC<ButtonProps> = ({
  loading,
  children,
  disabled,
  ...props
}) => {
  return (
    <StyledButton loading={loading} disabled={disabled || loading} {...props}>
      {children}
      {loading && <ButtonSpinner size={24} color="inherit" />}
    </StyledButton>
  );
};

export default Button;
