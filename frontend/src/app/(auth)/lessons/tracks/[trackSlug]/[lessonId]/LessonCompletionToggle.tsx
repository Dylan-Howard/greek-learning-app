'use client';

import { useState, useTransition } from 'react';
import { Checkbox, FormControlLabel, Stack, Typography } from '@mui/material';
import { useCompleteLessonMutation } from '@/lib/api/graphql/generated';
import { useUserContext } from '@/lib/types/domain/user';

interface LessonCompletionToggleProps {
  lessonId: number;
  initiallyCompleted: boolean;
}

export function LessonCompletionToggle({ lessonId, initiallyCompleted }: LessonCompletionToggleProps) {
  const { awardExp, syncUser } = useUserContext();
  const [isCompleted, setIsCompleted] = useState(initiallyCompleted);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [isPending, startTransition] = useTransition();

  const [completeLesson] = useCompleteLessonMutation();

  const onToggle = (_checked: boolean) => {
    startTransition(async () => {
      const result = await completeLesson({
        variables: { input: { lessonId } },
      });

      if (result.data?.completeLesson) {
        const { xpGained, totalExperience } = result.data.completeLesson;
        setIsCompleted(true);
        setErrorMessage(null);
        awardExp(xpGained, totalExperience);
        await syncUser();
        return;
      }

      if (result.errors && result.errors.length > 0) {
        setErrorMessage(result.errors[0].message);
        return;
      }

      setErrorMessage('Could not complete lesson. Please try again.');
    });
  };

  return (
    <Stack spacing={1} sx={{ mt: 4 }}>
      <FormControlLabel
        control={(
          <Checkbox
            checked={isCompleted}
            onChange={(_, checked) => onToggle(checked)}
            disabled={isCompleted || isPending}
          />
        )}
        label="I understand this lesson"
      />
      <Typography variant="caption" color="text.secondary">
        TODO(next phase): replace this checkbox with practice problems and a short mastery assessment.
      </Typography>
      {errorMessage && <Typography color="error.main">Could not save lesson completion: {errorMessage}</Typography>}
    </Stack>
  );
}
