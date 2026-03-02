import NextLink from 'next/link';
import {
  Breadcrumbs,
  Chip,
  Divider,
  Grid,
  Stack,
  Typography,
} from '@mui/material';
import { fetchLesson, fetchLessonTrack, fetchNextLesson } from '@/lib/api/rest/lessons';
import LessonCompletionToggle from '@/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/LessonCompletionToggle';
import { Button } from '@/components/ui';

export const dynamic = 'force-dynamic';

interface LessonDetailPageProps {
  params: Promise<{ trackSlug: string; lessonId: string }>;
}

function renderMarkdown(content: string): string[] {
  return content
    .split('\n')
    .map((line) => line.trim().replace(/^#+\s*/, ''))
    .filter((line) => line.length > 0);
}

export default async function LessonDetailPage({ params }: LessonDetailPageProps) {
  const { trackSlug, lessonId } = await params;
  const numericLessonId = Number.parseInt(lessonId, 10);
  if (Number.isNaN(numericLessonId)) {
    return (
      <Grid container justifyContent="center" sx={{ mt: 4 }}>
        <Grid size={{ xs: 11 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Lesson not found</Typography>
          <NextLink href={`/lessons/tracks/${trackSlug}`}>Back to track</NextLink>
        </Grid>
      </Grid>
    );
  }

  const [trackResult, lessonResult, nextResult] = await Promise.all([
    fetchLessonTrack(trackSlug),
    fetchLesson(numericLessonId),
    fetchNextLesson(trackSlug),
  ]);

  const track = trackResult.ok ? trackResult.data : undefined;
  const lesson = lessonResult.ok ? lessonResult.data : undefined;
  const nextLesson = nextResult.ok ? nextResult.data : undefined;

  if (!track || !lesson || lesson.trackSlug !== trackSlug) {
    return (
      <Grid container justifyContent="center" sx={{ mt: 4 }}>
        <Grid size={{ xs: 11 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Lesson not found</Typography>
          <NextLink href={`/lessons/tracks/${trackSlug}`}>Back to track</NextLink>
        </Grid>
      </Grid>
    );
  }

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ sm: 11 }} sx={{ mb: 6 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <NextLink href="/lessons">Lessons</NextLink>
          <NextLink href={`/lessons/tracks/${track.slug}`}>{track.title}</NextLink>
          <Typography color="primary.main">{lesson.title}</Typography>
        </Breadcrumbs>
      </Grid>

      <Grid size={{ xs: 11, md: 9 }}>
        <Stack direction="row" spacing={1} sx={{ mb: 2 }}>
          <Chip label={`Lesson ${lesson.lessonIndex}`} size="small" />
          <Chip label={lesson.lessonType} size="small" color="primary" variant="outlined" />
          {lesson.isCompleted && <Chip label="Completed" size="small" color="success" />}
        </Stack>

        <Typography variant="h3" sx={{ mb: 3 }}>{lesson.title}</Typography>

        <Stack spacing={1} sx={{ mb: 3 }}>
          {renderMarkdown(lesson.contentMarkdown).map((line, index) => (
            <Typography key={`${index}-${line.slice(0, 12)}`} variant="body1">
              {line}
            </Typography>
          ))}
        </Stack>

        <Divider sx={{ my: 3 }} />

        <LessonCompletionToggle lessonId={lesson.id} initiallyCompleted={lesson.isCompleted} />

        <Stack direction="row" spacing={2} sx={{ mt: 4, mb: 8 }}>
          <NextLink href={`/lessons/tracks/${track.slug}`}>
            <Button>Back to Track</Button>
          </NextLink>
          {nextLesson && nextLesson.id !== lesson.id && (
            <NextLink href={`/lessons/tracks/${track.slug}/${nextLesson.id}`}>
              <Button variant="contained">Next Lesson</Button>
            </NextLink>
          )}
        </Stack>
      </Grid>
    </Grid>
  );
}
