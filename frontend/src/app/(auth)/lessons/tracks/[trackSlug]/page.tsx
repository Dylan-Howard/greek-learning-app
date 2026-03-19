'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Grid,
  LinearProgress,
  Stack,
  Typography,
} from '@mui/material';
import { useEffect, useMemo, useState } from 'react';
import { useParams, useRouter } from 'next/navigation';
import { AppShell } from '@/components/layout/AppShell';
import { LessonCard, type LessonMeta } from '@/design-system-v2/components/lessons/LessonCard';
import { fetchLessonTrack } from '@/lib/api/rest/lessons';

export const dynamic = 'force-dynamic';

export default function LessonTrackPage() {
  const router = useRouter();
  const params = useParams();
  const trackSlugParam = params?.trackSlug;
  const trackSlug = Array.isArray(trackSlugParam) ? trackSlugParam[0] : trackSlugParam;
  const [track, setTrack] = useState<any | null>(null);
  const [errorMessage, setErrorMessage] = useState<string | undefined>();

  useEffect(() => {
    if (!trackSlug) return;
    fetchLessonTrack(trackSlug).then((result) => {
      if (result.ok) {
        setTrack(result.data);
        setErrorMessage(undefined);
      } else {
        setTrack(null);
        setErrorMessage(result.error.message);
      }
    });
  }, [trackSlug]);

  const lessons: LessonMeta[] = useMemo(() => (track?.lessons || []).map((lesson: any) => ({
    id: String(lesson.id),
    number: lesson.lessonIndex,
    title: lesson.title,
    type: lesson.lessonType === 'Vocabulary' ? 'Vocabulary' : lesson.lessonType === 'Culture' ? 'Culture' : 'Grammar',
    readTime: Math.max(3, Math.min(15, Math.round((lesson.contentMarkdown?.length ?? 0) / 400))),
    completed: lesson.isCompleted,
  })), [track?.lessons]);

  if (!track) {
    return (
      <AppShell>
        <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Lesson track not found</Typography>
          {errorMessage && (
            <Typography color="error.main" sx={{ mb: 2 }}>
              Error: {errorMessage}
            </Typography>
          )}
          <NextLink href="/lessons">Back to lesson tracks</NextLink>
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
          <Typography color="primary.main">{track.title}</Typography>
        </Breadcrumbs>

        <Box sx={{ mb: 3 }}>
          <Typography variant="h2" sx={{ mb: 1 }}>{track.title}</Typography>
          <Typography variant="body1" sx={{ mb: 2 }}>{track.description}</Typography>
          <Typography variant="body2" sx={{ mb: 1 }}>
            {track.completedLessons}/{track.totalLessons} completed
          </Typography>
          <LinearProgress value={Number(track.percentComplete)} variant="determinate" />
        </Box>

        <Stack spacing={2}>
          {lessons.map((lesson) => (
            <LessonCard
              key={lesson.id}
              lesson={lesson}
              onClick={(id) => router.push(`/lessons/tracks/${track.slug}/${id}`)}
            />
          ))}
        </Stack>
      </Box>
    </AppShell>
  );
}
