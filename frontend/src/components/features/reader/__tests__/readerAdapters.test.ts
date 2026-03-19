import { describe, expect, it } from 'vitest';
import { buildVerseDisplayData } from '@/components/features/reader/readerAdapters';

describe('buildVerseDisplayData', () => {
  it('includes translated units in the verse display', () => {
    const units = [
      {
        unitId: 1,
        content: 'word',
        helpText: '',
        morphologyId: 0,
        verseNumber: 1,
        type: 'translated',
        path: '0.0',
        original: 'λογος',
        translation: 'word',
      },
    ];

    const { verses } = buildVerseDisplayData(units);
    expect(verses).toHaveLength(1);
    expect(verses[0].tokens).toHaveLength(1);
    expect(verses[0].tokens[0].text).toBe('word');
  });
});
