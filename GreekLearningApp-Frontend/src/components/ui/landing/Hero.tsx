'use client';

import React from 'react';
import {
  Box,
  Container as MuiContainer,
  Stack,
  Typography,
  styled,
} from '@mui/material';
import Button from '../inputs/Button';

export interface HeroProps {
  /**
   * Main headline
   */
  title: string;
  /**
   * Subtitle/description
   */
  subtitle?: string;
  /**
   * Primary CTA
   */
  primaryAction?: {
    label: string;
    onClick: () => void;
  };
  /**
   * Secondary CTA
   */
  secondaryAction?: {
    label: string;
    onClick: () => void;
  };
  /**
   * Background image URL
   */
  backgroundImage?: string;
  /**
   * Hero illustration/image
   */
  illustration?: React.ReactNode;
}

const HeroRoot = styled(Box)(({ theme }) => ({
  minHeight: '70vh',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
  textAlign: 'center',
  padding: theme.spacing(8, 2),
  position: 'relative',
  overflow: 'hidden',
}));

/**
 * Hero section for landing pages
 */
export const Hero: React.FC<HeroProps> = ({
  title,
  subtitle,
  primaryAction,
  secondaryAction,
  backgroundImage,
  illustration,
}) => {
  return (
    <HeroRoot
      sx={{
        backgroundImage: backgroundImage ? `url(${backgroundImage})` : undefined,
        backgroundSize: 'cover',
        backgroundPosition: 'center',
      }}
    >
      <MuiContainer maxWidth="md">
        <Stack spacing={4} alignItems="center">
          {illustration && <Box sx={{ mb: 2 }}>{illustration}</Box>}
          <Typography variant="h1" component="h1">
            {title}
          </Typography>
          {subtitle && (
            <Typography variant="h3" color="text.secondary" fontWeight={400}>
              {subtitle}
            </Typography>
          )}
          <Stack direction="row" spacing={2} flexWrap="wrap" justifyContent="center">
            {primaryAction && (
              <Button
                variant="contained"
                size="large"
                onClick={primaryAction.onClick}
              >
                {primaryAction.label}
              </Button>
            )}
            {secondaryAction && (
              <Button
                variant="outlined"
                size="large"
                onClick={secondaryAction.onClick}
              >
                {secondaryAction.label}
              </Button>
            )}
          </Stack>
        </Stack>
      </MuiContainer>
    </HeroRoot>
  );
};

export default Hero;
