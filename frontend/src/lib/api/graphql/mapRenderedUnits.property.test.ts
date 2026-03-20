// Feature: graphql-integration, Property 11: mapRenderedUnitsToDisplayUnits produces identical output from GraphQL and REST payloads

import { describe, it, expect } from 'vitest';
import fc from 'fast-check';
import { mapRenderedUnitsToDisplayUnits } from '@/lib/api/rest/reader';

// **Validates: Requirements 9.3**

// Mirror the camelCase fields of RawRenderedUnitDto (GraphQL shape)
interface CamelUnit {
  type: string;
  text?: string | null;
  original?: string | null;
  path?: string | null;
  hints?: string[] | null;
  vocabId?: number | null;
  gramFeatureIds?: number[] | null;
  synFeatureIds?: number[] | null;
  children?: CamelUnit[] | null;
}

// Mirror the PascalCase fields of RawRenderedUnitDto (legacy REST shape)
interface PascalUnit {
  type: string; // required by RawRenderedUnitDto; normalizer falls back to Type
  Type?: string;
  Text?: string | null;
  Original?: string | null;
  Path?: string | null;
  Hints?: string[] | null;
  VocabId?: number | null;
  GramFeatureIds?: number[] | null;
  SynFeatureIds?: number[] | null;
  Children?: PascalUnit[] | null;
}

/**
 * Generates a random camelCase unit tree (GraphQL shape).
 * Uses letrec for recursive structure with bounded depth.
 */
const camelUnitArb: fc.Arbitrary<CamelUnit> = fc.letrec((tie) => ({
  unit: fc.record({
    type: fc.constantFrom('word', 'phrase', 'clause', 'translated', 'verse'),
    text: fc.option(fc.string({ maxLength: 30 }), { nil: null }),
    original: fc.option(fc.string({ maxLength: 30 }), { nil: null }),
    path: fc.option(
      fc.tuple(fc.nat({ max: 20 }), fc.nat({ max: 10 })).map(([v, w]) => `${v}.${w}`),
      { nil: null },
    ),
    hints: fc.array(fc.string({ maxLength: 15 }), { maxLength: 3 }),
    vocabId: fc.option(fc.nat({ max: 9999 }), { nil: null }),
    gramFeatureIds: fc.array(fc.nat({ max: 999 }), { maxLength: 3 }),
    synFeatureIds: fc.array(fc.nat({ max: 999 }), { maxLength: 3 }),
    children: fc.oneof(
      fc.constant([] as CamelUnit[]),
      fc.array(tie('unit') as fc.Arbitrary<CamelUnit>, { maxLength: 2 }),
    ),
  }),
})).unit as fc.Arbitrary<CamelUnit>;

/**
 * Converts a camelCase unit tree to its PascalCase equivalent.
 * The `type` field is omitted (cast away) so normalizeRenderedUnit falls
 * through to `raw.Type` via nullish coalescing, matching legacy .NET serialization.
 */
function toPascalCase(unit: CamelUnit): PascalUnit {
  // Cast to omit the required `type` field — real .NET PascalCase payloads
  // don't include a lowercase `type`, so normalizeRenderedUnit uses `raw.Type`.
  const pascal = {
    Type: unit.type,
    Text: unit.text,
    Original: unit.original,
    Path: unit.path,
    Hints: unit.hints,
    VocabId: unit.vocabId,
    GramFeatureIds: unit.gramFeatureIds,
    SynFeatureIds: unit.synFeatureIds,
    Children: (unit.children ?? []).map(toPascalCase),
  } as unknown as PascalUnit;
  return pascal;
}

describe('Property 11: mapRenderedUnitsToDisplayUnits produces identical output from GraphQL and REST payloads', () => {
  it('produces deeply equal output for camelCase (GraphQL) and PascalCase (REST) input shapes', () => {
    fc.assert(
      fc.property(camelUnitArb, (camelUnit) => {
        const pascalUnit = toPascalCase(camelUnit);

        const fromGraphQL = mapRenderedUnitsToDisplayUnits([camelUnit]);
        const fromREST = mapRenderedUnitsToDisplayUnits([pascalUnit]);

        expect(fromGraphQL).toEqual(fromREST);
      }),
      { numRuns: 100 },
    );
  });
});
