'use client';

import React from 'react';
import {
  Box,
  CardActions,
  CardContent,
  CardHeader,
  LinearProgress,
  Typography,
  styled,
} from '@mui/material';
import Card from './Card';

export interface KoineCardProps {
  /**
   * Title (e.g., lesson name, vocabulary set)
   */
  title: string;
  /**
   * Description
   */
  description?: string;
  /**
   * Progress percentage (0-100)
   */
  progress?: number;
  /**
   * Greek text preview
   */
  greekPreview?: string;
  /**
   * Click handler
   */
  onClick?: () => void;
  /**
   * Action buttons
   */
  actions?: React.ReactNode;
  /**
   * Icon or image
   */
  icon?: React.ReactNode;
}

const KoineCardRoot = styled(Card)(({ theme }) => ({
  height: '100%',
  display: 'flex',
  flexDirection: 'column',
}));

/**
 * Specialized card for Greek learning content
 */
export const KoineCard: React.FC<KoineCardProps> = ({
  title,
  description,
  progress,
  greekPreview,
  onClick,
  actions,
  icon,
}) => {
  return (
    <KoineCardRoot hoverable={!!onClick} onClick={onClick}>
      <CardHeader
        avatar={icon}
        title={title}
        titleTypographyProps={{ variant: 'h4' }}
      />
      <CardContent sx={{ flexGrow: 1 }}>
        {description && (
          <Typography variant="body2" color="text.secondary" paragraph>
            {description}
          </Typography>
        )}
        {greekPreview && (
          <Typography variant="greekBody" sx={{ mt: 2 }}>
            {greekPreview}
          </Typography>
        )}
      </CardContent>
      {progress !== undefined && (
        <Box sx={{ px: 2, pb: 1 }}>
          <LinearProgress
            variant="determinate"
            value={progress}
            sx={{ height: 4, borderRadius: 2 }}
          />
        </Box>
      )}
      {actions && <CardActions>{actions}</CardActions>}
    </KoineCardRoot>
  );
};

export default KoineCard;
