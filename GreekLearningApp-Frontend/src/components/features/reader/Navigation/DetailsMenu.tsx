'use client';

import { useEffect, useState } from 'react';

import Box from '@mui/material/Box';
import Grid from '@mui/material/Grid';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';

import { DetailsSkeleton } from '@/components/features/modules/Skeletons';
import * as AzureTextService from '@/components/features/services/AzureTextService';
import { useReaderContext } from '@/components/features/reader/ReaderPage/ReaderPageContext';
import WordAudioButton from '@/components/features/reader/Navigation/WordAudioButton';

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

    if (!selectedUnit.morphologyId) {
      setContent({
        title: selectedUnit.content,
        formDetails: [],
        loading: false,
      });
      return;
    }

    let cancelled = false;
    setContent((prev) => ({ ...prev, loading: true }));
    AzureTextService.fetchMorphologyDetails(selectedUnit.morphologyId)
      .then((frm) => {
        if (!frm || cancelled) {
          return;
        }

        const newContent: {
          title: string,
          formDetails: { field: string, value: string }[],
          loading: boolean,
        } = {
          title: frm.content || '',
          formDetails: [],
          loading: false,
        };
        newContent.formDetails.push({ field: 'Part of Speech', value: frm.posName });
        if (frm.caseName) { newContent.formDetails.push({ field: 'Case', value: frm.caseName }); }
        if (frm.tenseName) { newContent.formDetails.push({ field: 'Tense', value: frm.tenseName }); }
        if (frm.voiceName) { newContent.formDetails.push({ field: 'Voice', value: frm.voiceName }); }
        if (frm.moodName) { newContent.formDetails.push({ field: 'Mood', value: frm.moodName }); }
        if (frm.personName) { newContent.formDetails.push({ field: 'Person', value: frm.personName }); }
        if (frm.numberName) { newContent.formDetails.push({ field: 'Number', value: frm.numberName }); }
        if (frm.genderName) { newContent.formDetails.push({ field: 'Gender', value: frm.genderName }); }
        if (frm.patternName) { newContent.formDetails.push({ field: 'Pattern', value: frm.patternName }); }
        if (frm.degreeName) { newContent.formDetails.push({ field: 'Degree', value: frm.degreeName }); }
        newContent.formDetails.push({ field: 'Root', value: frm.rootName });

        setContent(newContent);
      });
    return () => { cancelled = true; };
  }, [selectedUnit]);

  useEffect(() => {
    if (!selectedUnit) {
      return;
    }

    const parentPhrases = selectedUnit.parentPhrases || [];
    const uniqueFeatureIds = [...new Set(
      parentPhrases.flatMap((phrase) => phrase.syntacticalFeatureIds || []).filter((id) => id > 0),
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
        featureDetails.forEach((detail) => {
          if (detail) {
            detailsById.set(detail.id, detail);
          }
        });

        const syntaxRows = parentPhrases
          .map((phrase) => ({
            phrase: phrase.original || phrase.translation || phrase.path,
            features: (phrase.syntacticalFeatureIds || [])
              .map((id) => detailsById.get(id))
              .filter((detail): detail is AzureTextService.SyntacticalFeatureDetails => !!detail)
              .map((detail) => `${detail.code} - ${detail.name}`),
          }))
          .filter((row) => row.features.length > 0);

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
