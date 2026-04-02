'use client';
// src/components/lessons/LessonBlocks.tsx
// All lesson content block types in one file.
// MVP: Text, Image, Video, ConfirmCheckbox
// Future (structure present, UI stubbed): MultipleChoice, DragAndDrop, TextInput

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Checkbox from '@mui/material/Checkbox';
import FormControlLabel from '@mui/material/FormControlLabel';
import RadioGroup from '@mui/material/RadioGroup';
import Radio from '@mui/material/Radio';
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import Alert from '@mui/material/Alert'; // MUI v7: from @mui/material
import Image from 'next/image';
import { tokens } from '@/theme/theme';

// ── Text Block ────────────────────────────────────────────────────────────────
interface TextBlockProps { content: string }
export function TextBlock({ content }: TextBlockProps) {
  return (
    <Typography
      variant="body1"
      sx={{
        lineHeight: 1.75,
        color:      tokens.color.textPrimary,
        mb:         2,
        // Greek text inline in lesson body auto-uses serif
        '& .greek': { fontFamily: '"Noto Serif", serif', fontSize: '1.125rem' },
      }}
      dangerouslySetInnerHTML={{ __html: content }}
    />
  );
}

// ── Image Block ──────────────────────────────────────────────────────────────
interface ImageBlockProps { src: string; alt: string; caption?: string; }
export function ImageBlock({ src, alt, caption }: ImageBlockProps) {
  return (
    <Box sx={{ mb: 3 }}>
      <Box sx={{ position: 'relative', width: '100%', borderRadius: tokens.radius.md, overflow: 'hidden' }}>
        <Image
          src={src}
          alt={alt}
          width={680}
          height={400}
          style={{ width: '100%', height: 'auto', display: 'block' }}
        />
      </Box>
      {caption && (
        <Typography
          variant="body2"
          sx={{ mt: 1, color: tokens.color.textMuted, fontStyle: 'italic', textAlign: 'center' }}
        >
          {caption}
        </Typography>
      )}
    </Box>
  );
}

// ── Video Block ──────────────────────────────────────────────────────────────
interface VideoBlockProps { src: string; title?: string; }
export function VideoBlock({ src, title }: VideoBlockProps) {
  return (
    <Box sx={{ mb: 3 }}>
      <Box
        sx={{
          position:     'relative',
          paddingBottom: '56.25%', // 16:9
          height:       0,
          overflow:     'hidden',
          borderRadius: tokens.radius.md,
          bgcolor:      tokens.color.textPrimary,
        }}
      >
        <iframe
          src={src}
          title={title ?? 'Lesson video'}
          allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
          allowFullScreen
          style={{
            position: 'absolute',
            top: 0, left: 0,
            width: '100%', height: '100%',
            border: 'none',
          }}
        />
      </Box>
    </Box>
  );
}

// ── Confirm Checkbox (MVP) ────────────────────────────────────────────────────
interface ConfirmCheckboxProps {
  id:         string;
  label?:     string;
  checked:    boolean;
  onChange:   (id: string, checked: boolean) => void;
}
export function ConfirmCheckbox({
  id,
  label = 'I understand this concept.',
  checked,
  onChange,
}: ConfirmCheckboxProps) {
  return (
    <Box
      sx={{
        display:      'flex',
        alignItems:   'center',
        p:            2,
        my:           2,
        bgcolor:      checked ? `${tokens.color.srsGood}14` : tokens.color.surfaceAlt,
        border:       `1px solid ${checked ? tokens.color.srsGood : tokens.color.border}`,
        borderRadius: tokens.radius.md,
        transition:   `all ${tokens.motion.normal} ${tokens.motion.ease}`,
      }}
    >
      <FormControlLabel
        control={
          <Checkbox
            checked={checked}
            onChange={(e) => onChange(id, e.target.checked)}
            sx={{
              color:      tokens.color.border,
              '&.Mui-checked': { color: tokens.color.srsGood },
            }}
          />
        }
        label={
          <Typography
            variant="body1"
            sx={{
              color:      checked ? tokens.color.srsGood : tokens.color.textPrimary,
              fontWeight: checked ? 600 : 400,
              transition: `color ${tokens.motion.fast} ${tokens.motion.ease}`,
            }}
          >
            {label}
          </Typography>
        }
        sx={{ m: 0 }}
      />
    </Box>
  );
}

// ── Multiple Choice (Future) ──────────────────────────────────────────────────
interface MultipleChoiceProps {
  id:          string;
  question:    string;
  options:     { id: string; text: string }[];
  correctId:   string;
  onAnswer?:   (id: string, correct: boolean) => void;
}
export function MultipleChoice({ id, question, options, correctId, onAnswer }: MultipleChoiceProps) {
  const [selected,  setSelected]  = useState<string | null>(null);
  const [submitted, setSubmitted] = useState(false);

  function handleSubmit() {
    if (!selected) return;
    setSubmitted(true);
    onAnswer?.(id, selected === correctId);
  }

  return (
    <Box sx={{ my: 3, p: 2.5, border: `1px solid ${tokens.color.border}`, borderRadius: tokens.radius.md }}>
      <Typography variant="body1" sx={{ fontWeight: 600, mb: 2 }}>
        {question}
      </Typography>
      <RadioGroup value={selected} onChange={(e) => { if (!submitted) setSelected(e.target.value); }}>
        {options.map((opt) => {
          const isCorrect = opt.id === correctId;
          const isSelected = opt.id === selected;
          let borderColor: string = tokens.color.border;
          let bgcolor: string = 'transparent';
          if (submitted && isSelected) {
            borderColor = isCorrect ? tokens.color.srsGood : tokens.color.srsAgain;
            bgcolor     = isCorrect ? `${tokens.color.srsGood}14` : `${tokens.color.srsAgain}14`;
          }
          return (
            <Box
              key={opt.id}
              sx={{
                border:       `1px solid ${borderColor}`,
                borderRadius: tokens.radius.md,
                mb:           1,
                px:           1.5,
                bgcolor,
                transition:   `all ${tokens.motion.fast} ${tokens.motion.ease}`,
                '&:hover':    { borderColor: submitted ? borderColor : tokens.color.primary, bgcolor: submitted ? bgcolor : tokens.color.primaryLight },
              }}
            >
              <FormControlLabel
                value={opt.id}
                control={<Radio size="small" sx={{ '&.Mui-checked': { color: tokens.color.primary } }} />}
                label={<Typography variant="body1">{opt.text}</Typography>}
                sx={{ m: 0, width: '100%', py: 0.5 }}
              />
            </Box>
          );
        })}
      </RadioGroup>
      {!submitted && (
        <Button
          variant="contained"
          size="small"
          onClick={handleSubmit}
          disabled={!selected}
          sx={{ mt: 1, bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark } }}
        >
          Check Answer
        </Button>
      )}
      {submitted && (
        <Alert
          severity={selected === correctId ? 'success' : 'error'}
          sx={{ mt: 1.5, borderRadius: tokens.radius.sm }}
        >
          {selected === correctId ? 'Correct!' : 'Not quite — review the passage above.'}
        </Alert>
      )}
    </Box>
  );
}

// ── Text Input Question (Future) ──────────────────────────────────────────────
interface TextInputQuestionProps {
  id:        string;
  question:  string;
  answer:    string;   // expected answer (case-insensitive)
  onAnswer?: (id: string, correct: boolean) => void;
}
export function TextInputQuestion({ id, question, answer, onAnswer }: TextInputQuestionProps) {
  const [value,    setValue]    = useState('');
  const [result,   setResult]   = useState<'correct' | 'incorrect' | null>(null);

  function handleCheck() {
    const correct = value.trim().toLowerCase() === answer.trim().toLowerCase();
    setResult(correct ? 'correct' : 'incorrect');
    onAnswer?.(id, correct);
  }

  return (
    <Box sx={{ my: 3, p: 2.5, border: `1px solid ${tokens.color.border}`, borderRadius: tokens.radius.md }}>
      <Typography variant="body1" sx={{ fontWeight: 600, mb: 1.5 }}>
        {question}
      </Typography>
      <Box sx={{ display: 'flex', gap: 1, alignItems: 'flex-start' }}>
        <TextField
          value={value}
          onChange={(e) => setValue(e.target.value)}
          onKeyDown={(e) => { if (e.key === 'Enter') handleCheck(); }}
          disabled={!!result}
          size="small"
          placeholder="Your answer…"
          sx={{ flex: 1 }}
        />
        <Button
          variant="contained"
          size="small"
          onClick={handleCheck}
          disabled={!value.trim() || !!result}
          sx={{ bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark }, flexShrink: 0 }}
        >
          Check
        </Button>
      </Box>
      {result && (
        <Alert
          severity={result === 'correct' ? 'success' : 'error'}
          sx={{ mt: 1.5, borderRadius: tokens.radius.sm }}
        >
          {result === 'correct' ? 'Correct!' : `The answer is: ${answer}`}
        </Alert>
      )}
    </Box>
  );
}
