import NextLink from 'next/link';
import {
  Breadcrumbs,
  Grid,
  Stack,
  Typography,
} from '@mui/material';
import { cookies } from 'next/headers';
import * as AzureTextService from '@/lib/api/rest/text';
import * as VocabularySetService from '@/lib/api/rest/vocabulary';
import VocabularySetCard from '@/components/features/vocabulary/VocabularySetCard';
import VocabularyTable from '@/components/features/vocabulary/VocabularyTable';
import { SimpleWordDto, VocabularySetDto } from '@/lib/types/api';
import { Button } from '@/components/shared';
import { DEFAULT_DEV_USER_ID, DEV_USER_COOKIE_KEY, sanitizeDevUserId } from '@/lib/services/auth/devSession';

export const dynamic = 'force-dynamic';

export default async function Vocabulary() {
  const cookieStore = await cookies();
  const userId = sanitizeDevUserId(cookieStore.get(DEV_USER_COOKIE_KEY)?.value || DEFAULT_DEV_USER_ID);
  const [data, setsResult] = await Promise.all([
    AzureTextService.fetchVocabulary(),
    VocabularySetService.fetchVocabularySets(userId),
  ]);
  const words: SimpleWordDto[] = data;

  const setsError = setsResult.ok ? undefined : setsResult.error.message;
  const sets = setsResult.ok ? setsResult.data : [];
  const featuredSets = sets
    .filter((set: VocabularySetDto) => set.isSystem)
    .sort((a: VocabularySetDto, b: VocabularySetDto) => b.totalCount - a.totalCount)
    .slice(0, 3);

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid  size={{ sm: 11 }} sx={{ mb: 8 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Vocabulary</Typography>
        </Breadcrumbs>
      </Grid>
      <Grid  size={{ xs: 11 }}>
        <Typography variant="h2" sx={{ mb: 4 }}>Vocabulary Sets</Typography>
      </Grid>
      {setsError && (
        <Grid size={{ xs: 11 }} sx={{ mb: 3 }}>
          <Typography color="error.main">Unable to load vocabulary sets: {setsError}</Typography>
        </Grid>
      )}
      {featuredSets.map((set) => {
        const progress = set.totalCount > 0
          ? (set.knownCount / set.totalCount) * 100
          : set.percentComplete;
        const clampedProgress = Math.max(0, Math.min(100, progress));

        return (
          <Grid key={set.id} size={{ sm: 3, xs: 11 }} sx={{ mb: 4 }}>
            <VocabularySetCard
              title={set.title}
              description={set.description}
              link={`/vocabulary/sets/${set.id}`}
              progress={clampedProgress}
              subtitle={`${set.knownCount}/${set.totalCount} known`}
            />
          </Grid>
        );
      })}
      {featuredSets.length === 0 && (
        <Grid size={{ xs: 11 }} sx={{ mb: 4 }}>
          <Typography variant="body1">No vocabulary sets are currently available.</Typography>
        </Grid>
      )}
      <Grid  size={{ xs: 12 }}>
        <Stack direction="row" justifyContent="center">
          <Button sx={{ mb: 8 }}>
            <NextLink href="/vocabulary/sets">See More</NextLink>
          </Button>
        </Stack>
      </Grid>
      <Grid  size={{ xs: 11 }}>
        <Typography variant="h2" sx={{ mb: 4 }}>All Vocabulary</Typography>
      </Grid>
      <Grid  size={{ sm: 8 }} sx={{ mb: 8 }}>
        <VocabularyTable words={words} />
      </Grid>
    </Grid>
  );
}
