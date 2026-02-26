import NextLink from 'next/link';
import {
  Breadcrumbs,
  Grid,
  List,
  ListItem,
  ListItemText,
  Typography,
} from '@mui/material';
import { fetchVocabularySetById } from '@/app/(auth)/vocabulary/services/VocabularySetService';

export const dynamic = 'force-dynamic';

interface VocabularySetDetailsPageProps {
  params: Promise<{ setId: string }>;
}

export default async function VocabularySetDetailsPage({ params }: VocabularySetDetailsPageProps) {
  const { setId } = await params;
  const numericId = Number.parseInt(setId, 10);
  const setResult = Number.isNaN(numericId)
    ? undefined
    : await fetchVocabularySetById(numericId);
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
          <NextLink href="/sets">Back to sets</NextLink>
        </Grid>
      </Grid>
    );
  }

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ sm: 11 }} sx={{ mb: 6 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <NextLink href="/sets">Vocabulary Sets</NextLink>
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
          {set.items.map((item) => (
            <ListItem key={item.id} divider>
              <ListItemText
                primary={item.root}
                secondary={`${item.gloss} - Mastery ${item.masteryLevel}%`}
              />
            </ListItem>
          ))}
        </List>
      </Grid>
    </Grid>
  );
}
