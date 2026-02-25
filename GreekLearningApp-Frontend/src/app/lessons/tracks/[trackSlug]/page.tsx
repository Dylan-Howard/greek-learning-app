import NextLink from 'next/link';
import {
  Breadcrumbs,
  Button,
  Card,
  CardActions,
  CardContent,
  Chip,
  Grid,
  LinearProgress,
  Stack,
  Typography,
} from '@mui/material';
import { fetchLessonTrack } from '../../../services/LessonService';

export const dynamic = 'force-dynamic';

interface LessonTrackPageProps {
  params: Promise<{ trackSlug: string }>;
}

export default async function LessonTrackPage({ params }: LessonTrackPageProps) {
  const { trackSlug } = await params;
  const trackResult = await fetchLessonTrack(trackSlug);
  const track = trackResult.ok ? trackResult.data : undefined;

  if (!track) {
    return (
      <Grid container justifyContent="center" sx={{ mt: 4 }}>
        <Grid size={{ xs: 11 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Lesson track not found</Typography>
          {!trackResult.ok && (
            <Typography color="error.main" sx={{ mb: 2 }}>
              Error: {trackResult.error.message}
            </Typography>
          )}
          <NextLink href="/lessons">Back to lesson tracks</NextLink>
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
          <Typography color="primary.main">{track.title}</Typography>
        </Breadcrumbs>
      </Grid>

      <Grid size={{ xs: 11 }} sx={{ mb: 3 }}>
        <Typography variant="h2" sx={{ mb: 1 }}>{track.title}</Typography>
        <Typography variant="body1" sx={{ mb: 2 }}>{track.description}</Typography>
        <Typography variant="body2" sx={{ mb: 1 }}>
          {track.completedLessons}/{track.totalLessons} completed
        </Typography>
        <LinearProgress value={Number(track.percentComplete)} variant="determinate" />
      </Grid>

      {track.lessons.map((lesson) => (
        <Grid key={lesson.id} size={{ xs: 11 }} sx={{ mb: 2 }}>
          <Card variant="outlined">
            <CardContent>
              <Stack direction="row" spacing={1} sx={{ mb: 1 }}>
                <Chip label={`#${lesson.lessonIndex}`} size="small" />
                <Chip label={lesson.lessonType} size="small" color="primary" variant="outlined" />
                {lesson.isCompleted && <Chip label="Completed" size="small" color="success" />}
              </Stack>
              <Typography variant="h6">{lesson.title}</Typography>
            </CardContent>
            <CardActions>
              <Button
                component={NextLink}
                href={`/lessons/tracks/${track.slug}/${lesson.id}`}
                variant={lesson.isCompleted ? 'text' : 'contained'}
              >
                {lesson.isCompleted ? 'Review Lesson' : 'Start Lesson'}
              </Button>
            </CardActions>
          </Card>
        </Grid>
      ))}
    </Grid>
  );
}
