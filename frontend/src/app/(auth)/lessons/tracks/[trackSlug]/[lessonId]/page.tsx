'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Button,
  Divider,
  Stack,
  Typography,
} from '@mui/material';
import { useMemo } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { AppShell } from '@/components/layout/AppShell';
import { TextBlock } from '@/components/lessons/LessonBlocks';
import {
  useGetLessonByIdQuery,
  useGetLessonTracksQuery,
  useGetNextLessonQuery,
} from '@/lib/api/graphql/generated';
import { LessonCompletionToggle } from '@/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/LessonCompletionToggle';

export const dynamic = 'force-dynamic';

function renderMarkdown(content: string): string[] {
  return content
    .split('\n')
    .map((line) => line.trim().replace(/^#+\s*/, ''))
    .filter((line) => line.length > 0);
}

export default function LessonDetailPage() {
  const router = useRouter();
  const params = useParams();
  const trackSlugParam = params?.trackSlug;
  const lessonIdParam = params?.lessonId;
  const trackSlug = Array.isArray(trackSlugParam) ? trackSlugParam[0] : (trackSlugParam ?? '');
  const lessonId = Array.isArray(lessonIdParam) ? lessonIdParam[0] : (lessonIdParam ?? '');
  const numericLessonId = Number.parseInt(lessonId, 10);

  const { data: lessonData, error: lessonError } = useGetLessonByIdQuery({
    variables: { id: numericLessonId },
    skip: Number.isNaN(numericLessonId),
  });

  const { data: tracksData } = useGetLessonTracksQuery({
    skip: !trackSlug,
  });

  const { data: nextLessonData } = useGetNextLessonQuery({
    variables: { trackSlug },
    skip: !trackSlug,
  });

  const lesson = lessonData?.lessonById ?? null;
  const track = useMemo(
    () => tracksData?.lessonTracks.find((t) => t.slug === trackSlug) ?? null,
    [tracksData, trackSlug],
  );
  const nextLesson = nextLessonData?.nextLesson ?? null;

  const lessonContentHtml = useMemo(() => (
    renderMarkdown(lesson?.contentMarkdown ?? '').map((line) => `<p>${line}</p>`).join('')
  ), [lesson?.contentMarkdown]);

  if (!trackSlug || Number.isNaN(numericLessonId) || lessonError || !lesson || lesson.trackSlug !== trackSlug) {
    return (
      <AppShell>
        <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Lesson not found</Typography>
          {lessonError && (
            <Typography color="error.main" sx={{ mb: 2 }}>
              Error: {lessonError.message}
            </Typography>
          )}
          <NextLink href={`/lessons/tracks/${trackSlug}`}>Back to track</NextLink>
        </Box>
      </AppShell>
    );
  }

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Koine Reader</NextLink>
          <NextLink href="/lessons">Lessons</NextLink>
          <NextLink href={`/lessons/tracks/${trackSlug}`}>{track?.title ?? trackSlug}</NextLink>
          <Typography color="primary.main">{lesson.title}</Typography>
        </Breadcrumbs>

        <Box sx={{ mb: 3 }}>
          <Typography variant="overline" sx={{ color: 'text.secondary' }}>
            Lesson {lesson.lessonIndex} • {lesson.lessonType}
          </Typography>
          <Typography variant="h3" sx={{ mb: 2 }}>{lesson.title}</Typography>
        </Box>

        <TextBlock content={lessonContentHtml} />

        <Divider sx={{ my: 3 }} />

        <LessonCompletionToggle lessonId={lesson.id} initiallyCompleted={lesson.isCompleted} />

        <Stack direction="row" spacing={2} sx={{ mt: 4, mb: 8 }}>
          <Button onClick={() => router.push(`/lessons/tracks/${trackSlug}`)}>
            Back to Track
          </Button>
          {nextLesson && nextLesson.id !== lesson.id && (
            <Button variant="contained" onClick={() => router.push(`/lessons/tracks/${trackSlug}/${nextLesson.id}`)}>
              Next Lesson
            </Button>
          )}
        </Stack>
      </Box>
    </AppShell>
  );
}
