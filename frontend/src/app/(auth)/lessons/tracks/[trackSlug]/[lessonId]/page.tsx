'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Button,
  Divider,
  Grid,
  Stack,
  Typography,
} from '@mui/material';
import { useEffect, useMemo, useState } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { AppShell } from '@/components/layout/AppShell';
import { TextBlock } from '@/design-system-v2/components/lessons/LessonBlocks';
import { fetchLesson, fetchLessonTrack, fetchNextLesson } from '@/lib/api/rest/lessons';
import LessonCompletionToggle from '@/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/LessonCompletionToggle';

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
  const trackSlug = Array.isArray(trackSlugParam) ? trackSlugParam[0] : trackSlugParam;
  const lessonId = Array.isArray(lessonIdParam) ? lessonIdParam[0] : lessonIdParam;
  const numericLessonId = Number.parseInt(lessonId || '', 10);

  const [track, setTrack] = useState<any | null>(null);
  const [lesson, setLesson] = useState<any | null>(null);
  const [nextLesson, setNextLesson] = useState<any | null>(null);

  useEffect(() => {
    if (!trackSlug || Number.isNaN(numericLessonId)) return;
    Promise.all([
      fetchLessonTrack(trackSlug),
      fetchLesson(numericLessonId),
      fetchNextLesson(trackSlug),
    ]).then(([trackResult, lessonResult, nextResult]) => {
      setTrack(trackResult.ok ? trackResult.data : null);
      setLesson(lessonResult.ok ? lessonResult.data : null);
      setNextLesson(nextResult.ok ? nextResult.data : null);
    });
  }, [numericLessonId, trackSlug]);

  const lessonContentHtml = useMemo(() => (
    renderMarkdown(lesson?.contentMarkdown || '').map((line) => `<p>${line}</p>`).join('')
  ), [lesson?.contentMarkdown]);

  if (!trackSlug || Number.isNaN(numericLessonId) || !track || !lesson || lesson.trackSlug !== trackSlug) {
    return (
      <AppShell>
        <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Lesson not found</Typography>
          <NextLink href={`/lessons/tracks/${trackSlug || ''}`}>Back to track</NextLink>
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
          <NextLink href={`/lessons/tracks/${track.slug}`}>{track.title}</NextLink>
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
          <Button onClick={() => router.push(`/lessons/tracks/${track.slug}`)}>
            Back to Track
          </Button>
          {nextLesson && nextLesson.id !== lesson.id && (
            <Button variant="contained" onClick={() => router.push(`/lessons/tracks/${track.slug}/${nextLesson.id}`)}>
              Next Lesson
            </Button>
          )}
        </Stack>
      </Box>
    </AppShell>
  );
}
