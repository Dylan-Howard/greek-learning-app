import NextLink from 'next/link';
import {
  Breadcrumbs,
  Button,
  Grid,
  Stack,
  Typography,
} from '@mui/material';

function VocabularySet() {
  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid  size={{ sm: 11 }} sx={{ mb: 8 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Vocabulary Sets</Typography>
        </Breadcrumbs>
      </Grid>
      <Grid  size={{ xs: 11 }}>
        <Typography variant="h2" sx={{ textAlign: 'center', mb: 4 }}>Coming Soon</Typography>
        <Typography variant="body1" sx={{ textAlign: 'center', mb: 4 }}>We&#39;re working hard to build this page for our users.</Typography>
        <Stack flexDirection="row" justifyContent="center">
          <NextLink href="/reader"><Button variant="contained">Return to reader</Button></NextLink>
        </Stack>
      </Grid>
    </Grid>
  );
}

export default VocabularySet;
