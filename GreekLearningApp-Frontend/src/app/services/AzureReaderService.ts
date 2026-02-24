import { Unitv2 } from '../modules/Text';
import * as AzureTextService from './AzureTextService';
import { apiClient } from './apiClient';

type RenderedUnitDto = {
  type: string;
  text?: string | null;
  original?: string | null;
  hints?: string[] | null;
  vocabId?: number | null;
  children?: RenderedUnitDto[] | null;
};

function flattenUnits(units: RenderedUnitDto[] = []): Unitv2[] {
  const flattened: Unitv2[] = [];

  const walk = (unit: RenderedUnitDto) => {
    if (unit.type === 'expanded' && unit.children?.length) {
      unit.children.forEach(walk);
      return;
    }

    const content = unit.original || unit.text || '';
    const help = unit.type === 'translated'
      ? (unit.text || '')
      : (unit.hints?.join(', ') || '');

    flattened.push({
      unitId: flattened.length + 1,
      content,
      helpText: help,
      morphologyId: unit.vocabId || 0,
      verseNumber: 0,
    });
  };

  units.forEach(walk);
  return flattened;
}

export async function fetchPage(chapterId: number, _userId: string, bookId = 1): Promise<{
  selection: {
    texts: { textId: number; title: string }[];
    chapters: { chapterId: number; chapterNumber: number }[];
  };
  title: string;
  text: Unitv2[];
}> {
  const [rendered, selections] = await Promise.all([
    apiClient.get<{ chapterId: number; title: string; units: RenderedUnitDto[] }>(`reader?book=${bookId}&chapter=${chapterId}`),
    AzureTextService.fetchTextSelectionOptions(bookId),
  ]);

  return {
    selection: selections,
    title: rendered.title,
    text: flattenUnits(rendered.units),
  };
}

export default fetchPage;
