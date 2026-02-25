import NextLink from 'next/link';
import {
  Breadcrumbs,
  Button,
  Card,
  CardActions,
  CardContent,
  Grid,
  LinearProgress,
  Stack,
  Typography,
} from '@mui/material';
import { fetchLessonTracks } from '../services/LessonService';

export const dynamic = 'force-dynamic';

export default async function LessonsPage() {
  const tracksResult = await fetchLessonTracks(false);
  const tracksError = tracksResult.ok ? undefined : tracksResult.error.message;
  const tracks = tracksResult.ok ? tracksResult.data : [];

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ sm: 11 }} sx={{ mb: 8 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Lessons</Typography>
        </Breadcrumbs>
      </Grid>

      <Grid size={{ xs: 11 }} sx={{ mb: 4 }}>
        <Typography variant="h2" sx={{ mb: 1 }}>Lesson Tracks</Typography>
        <Typography variant="body1">
          Lessons are ordered in each track. Complete lessons to unlock your next item.
        </Typography>
      </Grid>

      {tracksError && (
        <Grid size={{ xs: 11 }} sx={{ mb: 3 }}>
          <Typography color="error.main">Unable to load lesson tracks: {tracksError}</Typography>
        </Grid>
      )}

      {tracks.map((track) => (
        <Grid key={track.id} size={{ xs: 11, md: 6 }} sx={{ mb: 4 }}>
          <Card variant="outlined">
            <CardContent>
              <Typography variant="h5" sx={{ mb: 1 }}>{track.title}</Typography>
              <Typography variant="body2" sx={{ mb: 2 }}>{track.description}</Typography>
              <Typography variant="body2" sx={{ mb: 1 }}>
                Progress: {track.completedLessons}/{track.totalLessons}
              </Typography>
              <LinearProgress value={Number(track.percentComplete)} variant="determinate" sx={{ mb: 2 }} />
              <Typography variant="body2" sx={{ mb: 1 }}>
                Next: {track.nextLessonTitle ?? 'Track completed'}
              </Typography>
            </CardContent>
            <CardActions>
              <Stack direction="row" spacing={2}>
                <Button component={NextLink} href={`/lessons/tracks/${track.slug}`} variant="contained">
                  Open Track
                </Button>
                {track.nextLessonId && (
                  <Button component={NextLink} href={`/lessons/tracks/${track.slug}/${track.nextLessonId}`}>
                    Continue
                  </Button>
                )}
              </Stack>
            </CardActions>
          </Card>
        </Grid>
      ))}

      {!tracksError && tracks.length === 0 && (
        <Grid size={{ xs: 11 }} sx={{ mb: 8 }}>
          <Typography>No lesson tracks are currently available.</Typography>
        </Grid>
      )}
    </Grid>
  );
}
