'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Button,
  Grid,
  Stack,
  Typography,
} from '@mui/material';
import { useEffect, useState } from 'react';
import { AppShell } from '@/components/layout/AppShell';
import { LessonTrackCard } from '@/design-system-v2/components/lessons/LessonTrackCard';
import { fetchLessonTracks } from '@/lib/api/rest/lessons';

export const dynamic = 'force-dynamic';

export default function LessonsPage() {
  const [tracks, setTracks] = useState<any[]>([]);
  const [tracksError, setTracksError] = useState<string | undefined>();

  useEffect(() => {
    fetchLessonTracks(false).then((result) => {
      if (result.ok) {
        setTracks(result.data);
        setTracksError(undefined);
      } else {
        setTracks([]);
        setTracksError(result.error.message);
      }
    });
  }, []);

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Lessons</Typography>
        </Breadcrumbs>

        <Typography variant="h2" sx={{ mb: 1 }}>Lesson Tracks</Typography>
        <Typography variant="body1" sx={{ mb: 3 }}>
          Lessons are ordered in each track. Complete lessons to unlock your next item.
        </Typography>

        {tracksError && (
          <Typography color="error.main" sx={{ mb: 3 }}>
            Unable to load lesson tracks: {tracksError}
          </Typography>
        )}

        <Grid container spacing={2}>
          {tracks.map((track) => (
            <Grid key={track.id} size={{ xs: 12, md: 6 }}>
              <LessonTrackCard
                title={track.title}
                description={track.description}
                completedLessons={track.completedLessons}
                totalLessons={track.totalLessons}
                percentComplete={Number(track.percentComplete)}
                nextLessonTitle={track.nextLessonTitle}
                actions={(
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
                )}
              />
            </Grid>
          ))}
        </Grid>

        {!tracksError && tracks.length === 0 && (
          <Typography sx={{ mt: 4 }}>No lesson tracks are currently available.</Typography>
        )}
      </Box>
    </AppShell>
  );
}
