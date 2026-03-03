import { Unitv2 } from '@/lib/types/domain/text';
import * as AzureTextService from '@/lib/api/rest/text';
import { apiClient } from '@/lib/api/rest/client';

type RawRenderedUnitDto = {
  type: string;
  text?: string | null;
  original?: string | null;
  path?: string | null;
  hints?: string[] | null;
  vocabId?: number | null;
  gramFeatureIds?: number[] | null;
  synFeatureIds?: number[] | null;
  children?: RawRenderedUnitDto[] | null;
  // Some environments still return PascalCase payloads from .NET serialization.
  Type?: string;
  Text?: string | null;
  Original?: string | null;
  Path?: string | null;
  Hints?: string[] | null;
  VocabId?: number | null;
  GramFeatureIds?: number[] | null;
  SynFeatureIds?: number[] | null;
  Children?: RawRenderedUnitDto[] | null;
};

type ParentPhrase = {
  path: string;
  original: string;
  translation: string;
  syntacticalFeatureIds: number[];
};

type RenderedUnitDto = {
  type: string;
  text: string;
  original: string;
  path: string;
  hints: string[];
  vocabId: number | null;
  gramFeatureIds: number[];
  synFeatureIds: number[];
  children: RenderedUnitDto[];
};

const isReaderDebugEnabled = process.env.NEXT_PUBLIC_DEBUG_READER === 'true';

function normalizeRenderedUnit(raw: RawRenderedUnitDto): RenderedUnitDto {
  const children = raw.children ?? raw.Children ?? [];
  return {
    type: (raw.type ?? raw.Type ?? '').toLowerCase(),
    text: raw.text ?? raw.Text ?? '',
    original: raw.original ?? raw.Original ?? '',
    path: raw.path ?? raw.Path ?? '',
    hints: raw.hints ?? raw.Hints ?? [],
    vocabId: raw.vocabId ?? raw.VocabId ?? null,
    gramFeatureIds: raw.gramFeatureIds ?? raw.GramFeatureIds ?? [],
    synFeatureIds: raw.synFeatureIds ?? raw.SynFeatureIds ?? [],
    children: children.map(normalizeRenderedUnit),
  };
}

function getUnitContent(unit: RenderedUnitDto): string {
  if (unit.type === 'translated') {
    return unit.text || unit.original;
  }
  return unit.original || unit.text;
}

export function mapRenderedUnitsToDisplayUnits(units: RawRenderedUnitDto[] = []): Unitv2[] {
  const flattened: Unitv2[] = [];
  const normalizedUnits = units.map(normalizeRenderedUnit);

  const walk = (unit: RenderedUnitDto, parents: ParentPhrase[]) => {
    if (unit.children?.length) {
      const parentPhrase: ParentPhrase = {
        path: unit.path,
        original: unit.original,
        translation: unit.text,
        syntacticalFeatureIds: unit.synFeatureIds,
      };
      const nextParents = parentPhrase.path || parentPhrase.original || parentPhrase.translation
        ? [...parents, parentPhrase]
        : parents;
      unit.children.forEach((child) => walk(child, nextParents));
      return;
    }

    const content = getUnitContent(unit);
    const hints = unit.hints.filter(Boolean);
    const help = hints.length > 0 ? `[${hints.join(', ')}]` : '';

    if (isReaderDebugEnabled && !content) {
      // eslint-disable-next-line no-console
      console.warn('[ReaderDebug] Empty leaf content after normalization', {
        unit,
        parents,
      });
    }

    flattened.push({
      unitId: flattened.length + 1,
      content,
      helpText: help,
      morphologyId: unit.vocabId ?? 0,
      verseNumber: 0,
      type: unit.type,
      path: unit.path,
      original: unit.original,
      translation: unit.text,
      grammarFeatureIds: unit.gramFeatureIds,
      syntacticalFeatureIds: unit.synFeatureIds,
      parentPhrases: parents,
    });
  };

  normalizedUnits.forEach((unit) => walk(unit, []));
  return flattened;
}

export async function fetchPage(chapterNumber: number, _userId: string, bookId = 1): Promise<{
  selection: {
    texts: { textId: number; title: string }[];
    chapters: { chapterId: number; chapterNumber: number }[];
  };
  title: string;
  text: Unitv2[];
}> {
  const [rendered, selections] = await Promise.all([
    apiClient.get<{ chapterId: number; title: string; units: RawRenderedUnitDto[] }>(`reader?book=${bookId}&chapter=${chapterNumber}`),
    AzureTextService.fetchTextSelectionOptions(bookId),
  ]);

  if (isReaderDebugEnabled) {
    // eslint-disable-next-line no-console
    console.log('[ReaderDebug] Raw reader payload', {
      chapterId: rendered.chapterId,
      title: rendered.title,
      units: rendered.units?.length ?? 0,
      sample: rendered.units?.slice(0, 3),
    });
  }

  const mappedUnits = mapRenderedUnitsToDisplayUnits(rendered.units);

  if (isReaderDebugEnabled) {
    // eslint-disable-next-line no-console
    console.log('[ReaderDebug] Mapped display units', {
      count: mappedUnits.length,
      emptyCount: mappedUnits.filter((x) => !x.content).length,
      sample: mappedUnits.slice(0, 5),
    });
  }

  return {
    selection: selections,
    title: rendered.title,
    text: mappedUnits,
  };
}

export default fetchPage;
