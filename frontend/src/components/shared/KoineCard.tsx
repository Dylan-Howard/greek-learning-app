'use client';

import React from 'react';
import {
  CardActions,
  CardContent,
  CardHeader,
  Typography,
} from '@mui/material';
import { Card } from '@/design-system-v2/components/shared/Card';

export interface KoineCardProps {
  title: string;
  subtitle?: string;
  actions?: React.ReactNode;
  headerAction?: React.ReactNode;
  onClick?: () => void;
  children?: React.ReactNode;
}

export function KoineCard({
  title,
  subtitle,
  actions,
  headerAction,
  onClick,
  children,
}: KoineCardProps) {
  return (
    <Card hoverable={!!onClick} onClick={onClick}>
      <CardHeader
        title={title}
        subheader={subtitle}
        action={headerAction}
        titleTypographyProps={{ variant: 'h4' }}
        subheaderTypographyProps={{ variant: 'body2' }}
      />
      <CardContent sx={{ flexGrow: 1 }}>
        {children ?? <Typography variant="body2" color="text.secondary">No content.</Typography>}
      </CardContent>
      {actions && <CardActions>{actions}</CardActions>}
    </Card>
  );
}
