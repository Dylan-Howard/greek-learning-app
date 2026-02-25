import { describe, expect, it } from 'vitest';
import { mapRenderedUnitsToDisplayUnits } from '../AzureReaderService';

describe('mapRenderedUnitsToDisplayUnits', () => {
  it('maps to leaf-level units and preserves parent phrase syntax context', () => {
    const units = [
      {
        type: 'expanded',
        path: '0',
        original: 'εν αρχη',
        text: 'in the beginning',
        synFeatureIds: [2, 3],
        children: [
          {
            type: 'original',
            path: '0.0',
            original: 'εν',
            vocabId: 11,
            synFeatureIds: [],
          },
          {
            type: 'translated',
            path: '0.1',
            original: 'αρχη',
            text: 'beginning',
            vocabId: 12,
            synFeatureIds: [],
          },
        ],
      },
    ];

    const mapped = mapRenderedUnitsToDisplayUnits(units);
    expect(mapped).toHaveLength(2);
    expect(mapped[0].content).toBe('εν');
    expect(mapped[0].morphologyId).toBe(11);
    expect(mapped[0].parentPhrases?.[0]?.syntacticalFeatureIds).toEqual([2, 3]);
    expect(mapped[1].content).toBe('beginning');
    expect(mapped[1].morphologyId).toBe(12);
  });

  it('formats parsing hints in bracketed help text', () => {
    const units = [
      {
        type: 'original_with_hints',
        path: '1.0',
        original: 'λεγει',
        vocabId: 21,
        hints: ['V', '3S'],
      },
    ];

    const mapped = mapRenderedUnitsToDisplayUnits(units);
    expect(mapped).toHaveLength(1);
    expect(mapped[0].content).toBe('λεγει');
    expect(mapped[0].helpText).toBe('[V, 3S]');
  });

  it('handles PascalCase backend payload fields', () => {
    const units = [
      {
        Type: 'Original',
        Text: 'λογος',
        VocabId: 32,
        Path: '0.0',
      },
      {
        Type: 'Translated',
        Text: 'word',
        Original: 'λογος',
        VocabId: 32,
        Path: '0.1',
      },
    ];

    const mapped = mapRenderedUnitsToDisplayUnits(units as any);
    expect(mapped).toHaveLength(2);
    expect(mapped[0].content).toBe('λογος');
    expect(mapped[1].content).toBe('word');
  });
});
