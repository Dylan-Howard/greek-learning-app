import { type Unitv2 } from '@/lib/types/domain/text';
import { type Verse } from '@/design-system-v2/components/reader/VerseDisplay';
import { type WordStatus } from '@/design-system-v2/components/reader/GreekWord';

const PRACTICE_TYPES = new Set(['original_practice']);

export function buildVerseDisplayData(units: Unitv2[]) {
  const verseMap = new Map<number, Verse>();
  const unitByTokenId = new Map<string, Unitv2>();

  units
    .filter((unit) => unit.content && unit.type !== 'translated')
    .forEach((unit) => {
      const verseNumber = unit.verseNumber || 0;
      if (!verseMap.has(verseNumber)) {
        verseMap.set(verseNumber, { verse: verseNumber, tokens: [] });
      }
      const tokenId = `unit-${unit.unitId}`;
      const status: WordStatus = PRACTICE_TYPES.has(unit.type || '') ? 'due' : 'default';
      verseMap.get(verseNumber)?.tokens.push({
        id: tokenId,
        text: unit.content,
        status,
      });
      unitByTokenId.set(tokenId, unit);
    });

  const verses = Array.from(verseMap.values())
    .filter((verse) => verse.verse > 0)
    .sort((a, b) => a.verse - b.verse);

  return { verses, unitByTokenId };
}

export function getStudyVocabularyIds(units: Unitv2[]) {
  const unique = new Set<number>();
  units.forEach((unit) => {
    if (unit.type !== 'original_practice') return;
    if (!unit.morphologyId) return;
    unique.add(unit.morphologyId);
  });
  return Array.from(unique.values());
}
