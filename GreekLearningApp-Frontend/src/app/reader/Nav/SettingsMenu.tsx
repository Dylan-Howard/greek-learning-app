'use client';

import { useState } from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Divider from '@mui/material/Divider';
import Stack from '@mui/material/Stack';
import TextField from '@mui/material/TextField';
import Typography from '@mui/material/Typography';
import { useTheme } from '@mui/material/styles';
import { SettingsMenuTabSkeleton } from '../../modules/Skeletons';

function SettingsMenu({ title }: { title: string }) {
  const theme = useTheme();

  return (
    <Box>
      <Typography variant="h4" sx={{ mb: 2 }}>{title}</Typography>
      <Divider sx={{ mb: 2 }} />
      <Stack spacing={2}>
        <Typography variant="body1">Settings for {title} would go here.</Typography>
        {/* Placeholder settings */}
        <TextField label="Sample Setting" variant="outlined" fullWidth />
        <Button variant="contained">Save Settings</Button>
      </Stack>
    </Box>
  );
}

export default SettingsMenu;
