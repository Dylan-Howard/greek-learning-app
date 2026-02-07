// frontend/src/App.tsx
import { useEffect, useState } from 'react';
import { ReaderClient, RenderedChapterDto } from './api/generated/api-client';
import { getDevToken, getApiConfig } from './api/client';

function App() {
  const [chapter, setChapter] = useState<RenderedChapterDto | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    async function loadReader() {
      try {
        // Get dev token (development only)
        await getDevToken();
        
        // Create client
        const config = getApiConfig();
        const client = new ReaderClient(config);
        
        // Fetch rendered chapter
        const result = await client.getChapter(1, 1, 'en');
        setChapter(result);
      } catch (error) {
        console.error('Error loading chapter:', error);
      } finally {
        setLoading(false);
      }
    }

    loadReader();
  }, []);

  if (loading) return <div>Loading...</div>;
  if (!chapter) return <div>No data</div>;

  return (
    <div>
      <h1>{chapter.title}</h1>
      {/* Render units */}
    </div>
  );
}

export default App;