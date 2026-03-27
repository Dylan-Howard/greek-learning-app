import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';

export default function SettingsMenu({ title }: { title: string }) {
  return (
    <Box sx={{ p: 2 }}>
      <Typography variant="h3" sx={{ mb: 1 }}>
        {title} (Mock)
      </Typography>
      <Typography variant="body2" color="text.secondary">
        Storybook mock for reader settings content.
      </Typography>
    </Box>
  );
}
