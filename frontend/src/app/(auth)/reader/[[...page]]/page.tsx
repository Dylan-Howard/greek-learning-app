import * as AzureTextService from '@/lib/api/rest/text';
import { ReaderPageLoader } from '@/components/features/reader/ReaderPageLoader';

const DEFAULT_BOOK_ID = 1;
const DEFAULT_CHAPTER_NUMBER = 1;

export default async function ReaderPage({ params } : { params: { page: string[] } }) {
  const resolvedParams = await params;

  const [bookId, chapterId] = resolvedParams.page ? resolvedParams.page : ['1', '1'];
  const page = {
    bookId: parseInt(bookId, 10) || DEFAULT_BOOK_ID,
    chapterId: parseInt(chapterId, 10) || DEFAULT_CHAPTER_NUMBER,
  };

  const selection = await AzureTextService.fetchTextSelectionOptions(page.bookId);

  return (
    <ReaderPageLoader
      bookId={page.bookId}
      chapterId={page.chapterId}
      chapterNumber={page.chapterId}
      selection={selection}
    />
  );
}
