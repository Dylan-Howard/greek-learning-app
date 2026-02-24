import NextLink from 'next/link';
import {
  Breadcrumbs,
  Button,
  Grid,
  Stack,
  Typography,
} from '@mui/material';
import * as AzureTextService from '../services/AzureTextService';
import VocabularySetCard from './VocabularySetCard';
import VocabularyTable from './VocabularyTable';

export default async function Vocabulary() {
  let words: any[] = [];
  // let page = 0;
  // let rowsPerPage = 10;

  const data = await AzureTextService.fetchVocabulary();
  words = data;

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
      <Grid  size={{ sm: 3 }} sx={{ mb: 4 }}>
        <VocabularySetCard
          title="1 John"
          description="All vocabulary in the book of 1 John"
          link="sets/1John"
          progress={40}
        />
      </Grid>
      <Grid  size={{ sm: 3 }} sx={{ mb: 4 }}>
        <VocabularySetCard
          title="2 John"
          description="All vocabulary in the book of 2 John"
          link="sets/2John"
          progress={22}
        />
      </Grid>
      <Grid  size={{ sm: 3 }} sx={{ mb: 4 }}>
        <VocabularySetCard
          title="3 John"
          description="All vocabulary in the book of 3 John"
          link="sets/3John"
          progress={8}
        />
      </Grid>
      <Grid  size={{ xs: 12 }}>
        <Stack direction="row" justifyContent="center">
          <Button sx={{ mb: 8 }}>
            <NextLink href="/sets">See More</NextLink>
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
