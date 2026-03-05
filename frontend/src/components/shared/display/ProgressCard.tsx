'use client';

import React from 'react';
import {
  Box,
  LinearProgress,
  Typography,
} from '@mui/material';
import Card, { CardProps } from './Card';

export interface ProgressCardProps extends CardProps {
  /**
   * Progress value (0-100)
   */
  progress: number;
  /**
   * Progress label
   */
  progressLabel?: string;
  /**
   * Progress color
   */
  progressColor?: 'primary' | 'secondary' | 'success' | 'error' | 'warning' | 'info';
}

/**
 * Card with integrated progress indicator
 */
export const ProgressCard: React.FC<ProgressCardProps> = ({
  progress,
  progressLabel,
  progressColor = 'primary',
  children,
  ...cardProps
}) => {
  return (
    <Card {...cardProps}>
      {children}
      <Box sx={{ px: 2, pb: 2 }}>
        <Box sx={{ display: 'flex', justifyContent: 'space-between', mb: 1 }}>
          <Typography variant="body2" color="text.secondary">
            {progressLabel || 'Progress'}
          </Typography>
          <Typography variant="body2" fontWeight={600}>
            {Math.round(progress)}%
          </Typography>
        </Box>
        <LinearProgress
          variant="determinate"
          value={progress}
          color={progressColor}
          sx={{ height: 6, borderRadius: 3 }}
        />
      </Box>
    </Card>
  );
};

export default ProgressCard;
