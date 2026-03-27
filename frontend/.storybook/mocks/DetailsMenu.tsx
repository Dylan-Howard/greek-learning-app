import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';

export default function DetailsMenu() {
  return (
    <Box sx={{ p: 2 }}>
      <Typography variant="h3" sx={{ mb: 1 }}>
        Details (Mock)
      </Typography>
      <Typography variant="body2" color="text.secondary">
        Storybook mock for reader details content.
      </Typography>
    </Box>
  );
}
