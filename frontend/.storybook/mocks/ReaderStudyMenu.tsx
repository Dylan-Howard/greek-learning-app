import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';

export function ReaderStudyMenu() {
  return (
    <Box sx={{ p: 2 }}>
      <Typography variant="h3" sx={{ mb: 1 }}>
        Study (Mock)
      </Typography>
      <Typography variant="body2" color="text.secondary" sx={{ mb: 2 }}>
        Storybook mock for the reader study experience.
      </Typography>
      <Button variant="outlined">Start Review</Button>
    </Box>
  );
}
