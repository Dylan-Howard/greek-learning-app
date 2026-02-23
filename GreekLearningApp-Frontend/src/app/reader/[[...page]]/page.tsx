'use server';

import { auth } from '@clerk/nextjs/server';
import * as AzureReaderService from '../../services/AzureReaderService';
import ReaderInterface from '../ReaderPage/ReaderInterface';
import ReaderPageUnit from '../ReaderPage/ReaderPageUnit';
import { Box, Typography, Container } from '@mui/material';

export default async function Page({ params }: { params: { page: string[] } }) {
  const { userId } = await auth();
  const chapterId = parseInt(params.page?.[1] || '1', 10);
  const pageData = await AzureReaderService.fetchPage(chapterId, userId || '');

  if (!pageData) {
    return (
      <Container>
        <Typography variant="h6" sx={{ mt: 4 }}>
          Failed to load chapter data. Please ensure the backend is running and seeded.
        </Typography>
      </Container>
    );
  }

  return (
    <ReaderInterface bookId={1} chapterId={chapterId}>
      <Container maxWidth="md" sx={{ py: 4 }}>
        <Typography variant="h4" gutterBottom>
          {pageData.title}
        </Typography>
        <Box sx={{ display: 'flex', flexWrap: 'wrap', gap: 1, mt: 2 }}>
          {pageData.units?.map((unit, index) => (
            <ReaderPageUnit key={index} unit={unit} />
          ))}
        </Box>
      </Container>
    </ReaderInterface>
  );
}
