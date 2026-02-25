'use client';

import { useState, useTransition } from 'react';
import { Checkbox, FormControlLabel, Stack, Typography } from '@mui/material';
import { completeLesson } from '../../../../services/LessonService';

interface LessonCompletionToggleProps {
  lessonId: number;
  initiallyCompleted: boolean;
}

export default function LessonCompletionToggle({ lessonId, initiallyCompleted }: LessonCompletionToggleProps) {
  const [isCompleted, setIsCompleted] = useState(initiallyCompleted);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [isPending, startTransition] = useTransition();

  const onToggle = (_checked: boolean) => {
    startTransition(async () => {
      const result = await completeLesson(lessonId);
      if (result.ok) {
        setIsCompleted(true);
        setErrorMessage(null);
        return;
      }

      setErrorMessage(result.error.message);
    });
  };

  return (
    <Stack spacing={1} sx={{ mt: 4 }}>
      <FormControlLabel
        control={<Checkbox checked={isCompleted} onChange={(_, checked) => onToggle(checked)} disabled={isCompleted || isPending} />}
        label="I understand this lesson"
      />
      <Typography variant="caption" color="text.secondary">
        TODO(next phase): replace this checkbox with practice problems and a short mastery assessment.
      </Typography>
      {errorMessage && <Typography color="error.main">Could not save lesson completion: {errorMessage}</Typography>}
    </Stack>
  );
}
