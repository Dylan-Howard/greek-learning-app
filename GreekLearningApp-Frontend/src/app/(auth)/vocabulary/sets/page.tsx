import NextLink from 'next/link';
import {
  Breadcrumbs,
  Grid,
  Typography,
} from '@mui/material';
import VocabularySetCard from '@/components/features/vocabulary/VocabularySetCard';
import { fetchVocabularySets } from '@/lib/api/rest/vocabulary';
import { VocabularySetDto } from '@/lib/types/api';

export const dynamic = 'force-dynamic';

async function VocabularySet() {
  const setsResult = await fetchVocabularySets();
  const setsError = setsResult.ok ? undefined : setsResult.error.message;
  const sets = setsResult.ok ? setsResult.data : [];
  const systemSets = sets.filter((set: VocabularySetDto) => set.isSystem);
  const customSets = sets.filter((set: VocabularySetDto) => !set.isSystem);

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid  size={{ sm: 11 }} sx={{ mb: 8 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Vocabulary Sets</Typography>
        </Breadcrumbs>
      </Grid>
      <Grid  size={{ xs: 11 }}>
        <Typography variant="h2" sx={{ mb: 4 }}>System Vocabulary Sets</Typography>
      </Grid>
      {setsError && (
        <Grid size={{ xs: 11 }} sx={{ mb: 3 }}>
          <Typography color="error.main">Unable to load vocabulary sets: {setsError}</Typography>
        </Grid>
      )}
      {systemSets.length === 0 && (
        <Grid size={{ xs: 11 }} sx={{ mb: 6 }}>
          <Typography variant="body1">No system sets are currently available.</Typography>
        </Grid>
      )}
      {systemSets.map((set: VocabularySetDto) => {
        const progress = set.totalCount > 0
          ? (set.knownCount / set.totalCount) * 100
          : set.percentComplete;
        const clampedProgress = Math.max(0, Math.min(100, progress));

        return (
          <Grid key={set.id} size={{ xs: 11, sm: 6, md: 4 }} sx={{ mb: 4 }}>
            <VocabularySetCard
              title={set.title}
              description={set.description}
              link={`/sets/${set.id}`}
              progress={clampedProgress}
              subtitle={`${set.knownCount}/${set.totalCount} known`}
            />
          </Grid>
        );
      })}
      <Grid  size={{ xs: 11 }}>
        <Typography variant="h2" sx={{ mb: 4, mt: 4 }}>Custom Vocabulary Sets</Typography>
      </Grid>
      {customSets.length === 0 && (
        <Grid size={{ xs: 11 }} sx={{ mb: 8 }}>
          <Typography variant="body1">Create a custom set from the vocabulary page to start tracking your own list.</Typography>
        </Grid>
      )}
      {customSets.map((set: VocabularySetDto) => {
        const progress = set.totalCount > 0
          ? (set.knownCount / set.totalCount) * 100
          : set.percentComplete;
        const clampedProgress = Math.max(0, Math.min(100, progress));

        return (
          <Grid key={set.id} size={{ xs: 11, sm: 6, md: 4 }} sx={{ mb: 4 }}>
            <VocabularySetCard
              title={set.title}
              description={set.description}
              link={`/sets/${set.id}`}
              progress={clampedProgress}
              subtitle={`${set.knownCount}/${set.totalCount} known`}
            />
          </Grid>
        );
      })}
      <Grid size={{ xs: 11 }} sx={{ mb: 8 }}>
        <NextLink href="/vocabulary">Return to vocabulary</NextLink>
      </Grid>
    </Grid>
  );
}

export default VocabularySet;
