'use client';

import { useEffect, useState } from 'react';

import Box from '@mui/material/Box';
import Grid from '@mui/material/Grid';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';

import { DetailsSkeleton } from '@/components/shared/LoadingSkeleton';
import * as AzureTextService from '@/lib/api/rest/text';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';
import WordAudioButton from '@/components/features/reader/Navigation/WordAudioButton';

const POS_CODES = new Set(['N', 'V', 'ADJ', 'ART', 'PRON', 'PREP', 'CONJ', 'ADV', 'PART', 'INTERJ']);
const CASE_CODES = new Set(['NOM', 'GEN', 'DAT', 'ACC', 'VOC']);
const GENDER_CODES = new Set(['M', 'F', 'NEUT']);
const NUMBER_CODES = new Set(['S', 'P']);
const TENSE_CODES = new Set(['PRES', 'IMPF', 'FUT', 'AOR', 'PERF', 'PLUP', 'PLPF']);
const VOICE_CODES = new Set(['ACT', 'MID', 'PASS', 'MP']);
const MOOD_CODES = new Set(['IND', 'SUBJ', 'OPT', 'IMP', 'INF', 'PTCP']);
const PERSON_CODES = new Set(['1P', '2P', '3P']);
const DEGREE_CODES = new Set(['POS', 'COMP', 'SUPER']);

function pickFeatureName(
  features: AzureTextService.GrammaticalFeatureDetails[],
  codeSet: Set<string>,
) {
  return features.find((feature) => codeSet.has(feature.code))?.name || '';
}

function buildMorphologyDetails(
  features: AzureTextService.GrammaticalFeatureDetails[],
  morphology: Awaited<ReturnType<typeof AzureTextService.fetchMorphologyDetails>> | undefined,
): { field: string, value: string }[] {
  const details: { field: string, value: string }[] = [];
  const partOfSpeech = pickFeatureName(features, POS_CODES);
  const grammaticalCase = pickFeatureName(features, CASE_CODES);
  const tense = pickFeatureName(features, TENSE_CODES);
  const voice = pickFeatureName(features, VOICE_CODES);
  const mood = pickFeatureName(features, MOOD_CODES);
  const person = pickFeatureName(features, PERSON_CODES);
  const number = pickFeatureName(features, NUMBER_CODES);
  const gender = pickFeatureName(features, GENDER_CODES);
  const degree = pickFeatureName(features, DEGREE_CODES);

  if (partOfSpeech) { details.push({ field: 'Part of Speech', value: partOfSpeech }); }
  if (grammaticalCase) { details.push({ field: 'Case', value: grammaticalCase }); }
  if (tense) { details.push({ field: 'Tense', value: tense }); }
  if (voice) { details.push({ field: 'Voice', value: voice }); }
  if (mood) { details.push({ field: 'Mood', value: mood }); }
  if (person) { details.push({ field: 'Person', value: person }); }
  if (number) { details.push({ field: 'Number', value: number }); }
  if (gender) { details.push({ field: 'Gender', value: gender }); }
  if (degree) { details.push({ field: 'Degree', value: degree }); }
  if (features.length > 0) {
    details.push({ field: 'Grammar Tags', value: features.map((feature) => feature.code).join(', ') });
  }

  if (morphology?.rootName) {
    details.push({ field: 'Root', value: morphology.rootName });
  }
  if (morphology?.glossName) {
    details.push({ field: 'Gloss', value: morphology.glossName });
  }

  return details;
}

function DetailsItem({ label, value } : { label: string, value: string }) {
  return (
    <Box sx={{ mr: 2, mb: 2 }}>
      <Typography sx={{ fontSize: '.8rem', color: 'text.secondary' }}>{label}</Typography>
      <Typography sx={{ color: 'text.primary' }}>{value}</Typography>
    </Box>
  );
}

function DetailsMenu() {
  const { page } = useReaderContext();
  const selectedUnit = page?.selectedUnit;
  const [content, setContent] = useState({
    title: '',
    formDetails: [{ field: '', value: '' }],
    loading: true,
  });
  const [parentSyntax, setParentSyntax] = useState<Array<{
    phrase: string;
    features: string[];
  }>>([]);

  /* Fetch morphology details */
  useEffect(() => {
    if (!selectedUnit) {
      return;
    }

    let cancelled = false;
    setContent((prev) => ({ ...prev, loading: true }));
    const grammarFeatureIds = (selectedUnit.grammarFeatureIds || []).filter((id: number) => id > 0);
    Promise.all([
      selectedUnit.morphologyId
        ? AzureTextService.fetchMorphologyDetails(selectedUnit.morphologyId)
        : Promise.resolve(undefined),
      Promise.all(grammarFeatureIds.map((featureId: number) => AzureTextService.fetchGrammaticalFeatureDetails(featureId))),
    ]).then(([morphology, grammarFeatures]) => {
      if (cancelled) {
        return;
      }

      const validGrammarFeatures = grammarFeatures.filter(
        (feature): feature is AzureTextService.GrammaticalFeatureDetails => !!feature,
      );
      const title = selectedUnit.original || selectedUnit.content || morphology?.content || '';
      const formDetails = buildMorphologyDetails(validGrammarFeatures, morphology);

      setContent({
        title,
        formDetails,
        loading: false,
      });
    });

    return () => { cancelled = true; };
  }, [selectedUnit]);

  useEffect(() => {
    if (!selectedUnit) {
      return;
    }

    const parentPhrases = selectedUnit.parentPhrases || [];
    const uniqueFeatureIds = [...new Set(
      parentPhrases.flatMap((phrase: { syntacticalFeatureIds: number[] }) => phrase.syntacticalFeatureIds || []).filter((id: number) => id > 0),
    )];

    if (uniqueFeatureIds.length === 0) {
      setParentSyntax([]);
      return;
    }

    let cancelled = false;
    Promise.all(uniqueFeatureIds.map((featureId) => AzureTextService.fetchSyntacticalFeatureDetails(featureId)))
      .then((featureDetails) => {
        if (cancelled) {
          return;
        }

        const detailsById = new Map<number, AzureTextService.SyntacticalFeatureDetails>();
        featureDetails.forEach((detail: AzureTextService.SyntacticalFeatureDetails | undefined) => {
          if (detail) {
            detailsById.set(detail.id, detail);
          }
        });

        const syntaxRows = parentPhrases
          .map((phrase: { original: string, translation: string, path: string, syntacticalFeatureIds: number[] }) => ({
            phrase: phrase.original || phrase.translation || phrase.path,
            features: (phrase.syntacticalFeatureIds || [])
              .map((id: number) => detailsById.get(id))
              .filter((detail): detail is AzureTextService.SyntacticalFeatureDetails => !!detail)
              .map((detail: AzureTextService.SyntacticalFeatureDetails) => `${detail.code} - ${detail.name}`),
          }))
          .filter((row: { features: string[] }) => row.features.length > 0);

        setParentSyntax(syntaxRows);
      });

    return () => { cancelled = true; };
  }, [selectedUnit]);

  if (!selectedUnit) {
    return <DetailsSkeleton />;
  }

  if (content.loading) {
    return <DetailsSkeleton />;
  }

  return (
    <Box>
      <Stack direction="row" alignItems="center" justifyContent="space-between" sx={{ mb: 2 }}>
        <Typography
          variant="h2"
          sx={{ fontSize: 48, fontFamily: 'Noto Serif' }}
        >
          {content.title || selectedUnit.content}
        </Typography>
        <WordAudioButton word={content.title || selectedUnit.content} />
      </Stack>
      <Grid container>
        {
          content.formDetails.map(({ field, value }) => (
            <Grid size={{ xs: 6 }} key={`detail-${field}`}>
              <DetailsItem label={field} value={value} />
            </Grid>
          ))
        }
      </Grid>
      {
        parentSyntax.length > 0
          ? (
            <Box sx={{ mt: 2 }}>
              <Typography sx={{ fontSize: '.8rem', color: 'text.secondary', mb: 1 }}>
                Parent Syntax
              </Typography>
              {
                parentSyntax.map((row) => (
                  <Box key={`${row.phrase}-${row.features.join('|')}`} sx={{ mb: 1.5 }}>
                    <Typography sx={{ color: 'text.primary' }}>
                      {row.phrase}
                    </Typography>
                    <Typography sx={{ fontSize: '.85rem', color: 'text.secondary' }}>
                      {row.features.join(', ')}
                    </Typography>
                  </Box>
                ))
              }
            </Box>
          )
          : null
      }
    </Box>
  );
}

export default DetailsMenu;
