'use client';

import React from 'react';
import {
  Box,
  Button,
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  Stack,
  ToggleButton,
  ToggleButtonGroup,
  Typography,
} from '@mui/material';
import { StartSessionRequest, VocabularySetDto } from '@/lib/types/api';

interface SessionConfigProps {
  sets: VocabularySetDto[];
  config: StartSessionRequest;
  onChange: (config: StartSessionRequest) => void;
  onStart: () => void;
  disabled?: boolean;
}

export default function SessionConfig({
  sets,
  config,
  onChange,
  onStart,
  disabled = false,
}: SessionConfigProps) {
  return (
    <Box sx={{ maxWidth: 520 }}>
      <Stack spacing={3}>
        <Typography variant="h4">Start a Study Session</Typography>

        <FormControl fullWidth>
          <InputLabel id="card-count-label">Card Count</InputLabel>
          <Select
            labelId="card-count-label"
            value={config.cardCount}
            label="Card Count"
            onChange={(event) => onChange({ ...config, cardCount: Number(event.target.value) })}
          >
            <MenuItem value={5}>5</MenuItem>
            <MenuItem value={10}>10</MenuItem>
            <MenuItem value={20}>20</MenuItem>
            <MenuItem value={-1}>All Due</MenuItem>
          </Select>
        </FormControl>

        <FormControl fullWidth>
          <InputLabel id="set-scope-label">Vocabulary Set</InputLabel>
          <Select
            labelId="set-scope-label"
            value={config.vocabularySetId ?? ''}
            label="Vocabulary Set"
            onChange={(event) => onChange({
              ...config,
              vocabularySetId: event.target.value ? Number(event.target.value) : null,
            })}
          >
            <MenuItem value="">All Vocabulary</MenuItem>
            {sets.map((set) => (
              <MenuItem key={set.id} value={set.id}>{set.title}</MenuItem>
            ))}
          </Select>
        </FormControl>

        <Box>
          <Typography variant="subtitle2" sx={{ mb: 1 }}>Card Pool</Typography>
          <ToggleButtonGroup
            exclusive
            value={config.pool}
            onChange={(_, value) => value && onChange({ ...config, pool: value })}
          >
            <ToggleButton value="DueOnly">Due Only</ToggleButton>
            <ToggleButton value="NewOnly">New Only</ToggleButton>
            <ToggleButton value="Mixed">Mixed</ToggleButton>
          </ToggleButtonGroup>
        </Box>

        <Box>
          <Typography variant="subtitle2" sx={{ mb: 1 }}>Direction</Typography>
          <ToggleButtonGroup
            exclusive
            value={config.direction}
            onChange={(_, value) => value && onChange({ ...config, direction: value })}
          >
            <ToggleButton value="GreekToEnglish">Greek → English</ToggleButton>
            <ToggleButton value="EnglishToGreek">English → Greek</ToggleButton>
            <ToggleButton value="Random">Random</ToggleButton>
          </ToggleButtonGroup>
        </Box>

        <Box>
          <Typography variant="subtitle2" sx={{ mb: 1 }}>Interaction Mode</Typography>
          <ToggleButtonGroup
            exclusive
            value={config.mode}
            onChange={(_, value) => value && onChange({ ...config, mode: value })}
          >
            <ToggleButton value="Flip">Flip</ToggleButton>
            <ToggleButton value="MultipleChoice">Multiple Choice</ToggleButton>
            <ToggleButton value="Mix">Mix</ToggleButton>
          </ToggleButtonGroup>
        </Box>

        <Button variant="contained" onClick={onStart} disabled={disabled}>
          Start Session
        </Button>
      </Stack>
    </Box>
  );
}
