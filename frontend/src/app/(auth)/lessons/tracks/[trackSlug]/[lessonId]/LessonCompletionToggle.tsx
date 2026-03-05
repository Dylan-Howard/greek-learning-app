'use client';

import { useState, useTransition } from 'react';
import { Stack, Typography } from '@mui/material';
import { completeLesson } from '@/lib/api/rest/lessons';
import { Checkbox } from '@/components/shared';
import { useUserContext } from '@/lib/types/domain/user';
import { getActiveDevUserId } from '@/lib/services/auth/devSession';

interface LessonCompletionToggleProps {
  lessonId: number;
  initiallyCompleted: boolean;
}

export default function LessonCompletionToggle({ lessonId, initiallyCompleted }: LessonCompletionToggleProps) {
  const { awardExp, syncUser } = useUserContext();
  const [isCompleted, setIsCompleted] = useState(initiallyCompleted);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [isPending, startTransition] = useTransition();

  const onToggle = (_checked: boolean) => {
    startTransition(async () => {
      const userId = getActiveDevUserId();
      const result = await completeLesson(lessonId, undefined, userId);
      if (result.ok) {
        setIsCompleted(true);
        setErrorMessage(null);
        awardExp(result.data.xpGained, result.data.totalExperience);
        await syncUser(userId);
        return;
      }

      setErrorMessage(result.error.message);
    });
  };

  return (
    <Stack spacing={1} sx={{ mt: 4 }}>
      <Checkbox
        label="I understand this lesson"
        checked={isCompleted}
        onChange={(_, checked) => onToggle(checked)}
        disabled={isCompleted || isPending}
      />
      <Typography variant="caption" color="text.secondary">
        TODO(next phase): replace this checkbox with practice problems and a short mastery assessment.
      </Typography>
      {errorMessage && <Typography color="error.main">Could not save lesson completion: {errorMessage}</Typography>}
    </Stack>
  );
}
