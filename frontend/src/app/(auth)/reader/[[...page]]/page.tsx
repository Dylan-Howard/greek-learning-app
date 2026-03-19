import { cookies } from 'next/headers';

import * as AzureReaderService from '@/lib/api/rest/reader';
import { DEFAULT_DEV_USER_ID, DEV_USER_COOKIE_KEY, sanitizeDevUserId } from '@/lib/services/auth/devSession';
import { ReaderClient } from '@/components/features/reader/ReaderClient';

const DEFAULT_BOOK_ID = 1;
const DEFAULT_CHAPTER_NUMBER = 1;

export default async function ReaderPage({ params } : { params: { page: string[] } }) {
  const resolvedParams = await params;
  const cookieStore = await cookies();
  const userId = sanitizeDevUserId(cookieStore.get(DEV_USER_COOKIE_KEY)?.value || DEFAULT_DEV_USER_ID);

  /* Text data */
  const [bookId, chapterId] = resolvedParams.page ? resolvedParams.page : ['1', '1'];
  const page = {
    bookId: parseInt(bookId, 10) || DEFAULT_BOOK_ID,
    chapterId: parseInt(chapterId, 10) || DEFAULT_CHAPTER_NUMBER,
  };

  const data = await AzureReaderService.fetchPage(page.chapterId, userId, page.bookId);
  if (!data) {
    throw new Error('Error fetching the reader page.');
  }

  const { selection, title, text } = data;

  return (
    <ReaderClient
      bookId={page.bookId}
      chapterId={page.chapterId}
      selection={selection}
      title={title}
      text={text}
    />
  );
}
