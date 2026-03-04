import NextLink from 'next/link';
import {
  Breadcrumbs,
  Grid,
  List,
  ListItem,
  ListItemText,
  Stack,
  Typography,
} from '@mui/material';
import { cookies } from 'next/headers';
import { fetchVocabularySetById } from '@/lib/api/rest/vocabulary';
import { VocabularySetItemDto } from '@/lib/types/api';
import { Button } from '@/components/ui';
import { DEFAULT_DEV_USER_ID, DEV_USER_COOKIE_KEY, sanitizeDevUserId } from '@/lib/services/auth/devSession';

export const dynamic = 'force-dynamic';

interface VocabularySetDetailsPageProps {
  params: Promise<{ setId: string }>;
}

export default async function VocabularySetDetailsPage({ params }: VocabularySetDetailsPageProps) {
  const { setId } = await params;
  const numericId = Number.parseInt(setId, 10);
  const cookieStore = await cookies();
  const userId = sanitizeDevUserId(cookieStore.get(DEV_USER_COOKIE_KEY)?.value || DEFAULT_DEV_USER_ID);
  const setResult = Number.isNaN(numericId)
    ? undefined
    : await fetchVocabularySetById(numericId, userId);
  const set = setResult?.ok ? setResult.data : undefined;
  const errorMessage = setResult && !setResult.ok ? setResult.error.message : undefined;

  if (!set) {
    return (
      <Grid container justifyContent="center" sx={{ mt: 4 }}>
        <Grid size={{ xs: 11 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Vocabulary set not found</Typography>
          {errorMessage && (
            <Typography color="error.main" sx={{ mb: 2 }}>
              Error: {errorMessage}
            </Typography>
          )}
          <NextLink href="/vocabulary/sets">Back to sets</NextLink>
        </Grid>
      </Grid>
    );
  }

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ sm: 11 }} sx={{ mb: 6 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <NextLink href="/vocabulary/sets">Vocabulary Sets</NextLink>
          <Typography color="primary.main">{set.title}</Typography>
        </Breadcrumbs>
      </Grid>
      <Grid size={{ xs: 11, md: 8 }}>
        <Typography variant="h2" sx={{ mb: 2 }}>{set.title}</Typography>
        <Typography variant="body1" sx={{ mb: 2 }}>{set.description}</Typography>
        <Typography variant="body2" sx={{ mb: 4 }}>
          Progress: {set.knownCount}/{set.totalCount} known ({Math.round(set.percentComplete)}%)
        </Typography>

        <List>
          {set.items.map((item: VocabularySetItemDto) => (
            <ListItem key={item.id} divider>
              <ListItemText
                primary={item.root}
                secondary={`${item.gloss} - Mastery ${item.masteryLevel}%`}
              />
            </ListItem>
          ))}
        </List>

        <Stack direction="row" spacing={2} sx={{ mt: 4, mb: 6 }}>
          <NextLink href={`/study/session?setId=${set.id}`}>
            <Button variant="contained">Study This Set</Button>
          </NextLink>
          <NextLink href="/vocabulary/sets">
            <Button>Back to Sets</Button>
          </NextLink>
        </Stack>
      </Grid>
    </Grid>
  );
}
