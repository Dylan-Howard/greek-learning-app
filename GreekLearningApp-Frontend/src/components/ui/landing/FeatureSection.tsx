'use client';

import React from 'react';
import {
  Box,
  Container as MuiContainer,
  Grid,
  Stack,
  Typography,
  alpha,
} from '@mui/material';

export interface Feature {
  icon: React.ReactNode;
  title: string;
  description: string;
}

export interface FeatureSectionProps {
  /**
   * Section title
   */
  title?: string;
  /**
   * Section description
   */
  description?: string;
  /**
   * Features to display
   */
  features: Feature[];
  /**
   * Layout columns (2 or 3)
   */
  columns?: 2 | 3;
}

/**
 * Feature section for landing pages
 */
export const FeatureSection: React.FC<FeatureSectionProps> = ({
  title,
  description,
  features,
  columns = 3,
}) => {
  return (
    <Box sx={{ py: 8 }}>
      <MuiContainer maxWidth="lg">
        {(title || description) && (
          <Box sx={{ textAlign: 'center', mb: 6 }}>
            {title && <Typography variant="h2" gutterBottom>{title}</Typography>}
            {description && (
              <Typography variant="h3" color="text.secondary" fontWeight={400}>
                {description}
              </Typography>
            )}
          </Box>
        )}
        <Grid container spacing={4}>
          {features.map((feature, index) => (
            <Grid key={index} size={{ xs: 12, md: 12 / columns }}>
              <Stack spacing={2} alignItems="center" textAlign="center">
                <Box
                  sx={{
                    width: 64,
                    height: 64,
                    borderRadius: '50%',
                    display: 'flex',
                    alignItems: 'center',
                    justifyContent: 'center',
                    bgcolor: (theme) =>
                      alpha(theme.vars.palette.primary.main, 0.1),
                    color: 'primary.main',
                  }}
                >
                  {feature.icon}
                </Box>
                <Typography variant="h4">{feature.title}</Typography>
                <Typography variant="body1" color="text.secondary">
                  {feature.description}
                </Typography>
              </Stack>
            </Grid>
          ))}
        </Grid>
      </MuiContainer>
    </Box>
  );
};

export default FeatureSection;
