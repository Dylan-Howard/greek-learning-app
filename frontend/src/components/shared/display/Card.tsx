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

export interface CardProps extends MuiCardProps {
  /**
   * Card title
   */
  title?: string;
  /**
   * Card subtitle/description
   */
  subtitle?: string;
  /**
   * Header action (e.g., icon button)
   */
  headerAction?: React.ReactNode;
  /**
   * Card actions (buttons)
   */
  actions?: React.ReactNode;
  /**
   * Show hover effect
   */
  hoverable?: boolean;
}

const HoverableCard = styled(MuiCard, {
  shouldForwardProp: (prop) => prop !== 'hoverable',
})<{ hoverable?: boolean }>(({ theme, hoverable }) => {
  const palette = theme.vars?.palette ?? theme.palette;
  return {
  transition: theme.transitions.create(['transform', 'border-color'], {
    duration: theme.transitions.duration.shorter,
  }),
  ...(hoverable && {
    cursor: 'pointer',
    '&:hover': {
      transform: 'translateY(-2px)',
      borderColor: palette.primary.main,
    },
  }),
  };
});

/**
 * Versatile card component
 */
export const Card: React.FC<CardProps> = ({
  title,
  subtitle,
  headerAction,
  actions,
  children,
  hoverable,
  ...props
}) => {
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
};

export default Card;
