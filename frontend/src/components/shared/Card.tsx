'use client';

import React from 'react';
import {
  Card as MuiCard,
  CardProps as MuiCardProps,
  CardContent,
  CardHeader,
  CardActions,
  styled,
} from '@mui/material';
import { tokens } from '@/theme/theme';

export interface CardProps extends MuiCardProps {
  title?: string;
  subtitle?: string;
  headerAction?: React.ReactNode;
  actions?: React.ReactNode;
  hoverable?: boolean;
}

const HoverableCard = styled(MuiCard, {
  shouldForwardProp: (prop) => prop !== 'hoverable',
})<{ hoverable?: boolean }>(({ hoverable }) => ({
  borderRadius: tokens.radius.lg,
  border: `1px solid ${tokens.color.border}`,
  boxShadow: '0 1px 3px rgba(0,0,0,0.08)',
  transition: `all ${tokens.motion.fast} ${tokens.motion.ease}`,
  ...(hoverable && {
    cursor: 'pointer',
    '&:hover': {
      borderColor: tokens.color.borderStrong,
      boxShadow: '0 3px 8px rgba(0,0,0,0.10)',
      transform: 'translateY(-1px)',
    },
  }),
}));

export function Card({
  title,
  subtitle,
  headerAction,
  actions,
  children,
  hoverable,
  ...props
}: CardProps) {
  return (
    <HoverableCard hoverable={hoverable} {...props}>
      {(title || subtitle || headerAction) && (
        <CardHeader
          title={title}
          subheader={subtitle}
          action={headerAction}
          titleTypographyProps={{ variant: 'h4' }}
          subheaderTypographyProps={{ variant: 'body2' }}
        />
      )}
      {children && <CardContent>{children}</CardContent>}
      {actions && <CardActions>{actions}</CardActions>}
    </HoverableCard>
  );
}
