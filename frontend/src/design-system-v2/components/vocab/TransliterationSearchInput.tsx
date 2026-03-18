'use client';
// src/components/vocab/TransliterationSearchInput.tsx
// Maps Latin characters to Greek equivalents for keyboard-friendly search.

import React from 'react';
import TextField from '@mui/material/TextField';
import InputAdornment from '@mui/material/InputAdornment';
import FormHelperText from '@mui/material/FormHelperText';
import Box from '@mui/material/Box';
import SearchIcon from '@mui/icons-material/Search';
import { tokens } from '@/design-system-v2/theme/theme';

// Basic transliteration map: Latin string → candidate Greek chars
// Covers common patterns. A real impl would use a full lookup table or server-side.
const TRANSLIT_MAP: [RegExp, string][] = [
  [/th/gi,  'θ'],
  [/ph/gi,  'φ'],
  [/ch/gi,  'χ'],
  [/ps/gi,  'ψ'],
  [/ou/gi,  'ου'],
  [/ai/gi,  'αι'],
  [/oi/gi,  'οι'],
  [/ei/gi,  'ει'],
  [/au/gi,  'αυ'],
  [/a/gi,   '[αά]'],
  [/e/gi,   '[εέη]'],
  [/i/gi,   '[ι]'],
  [/o/gi,   '[οό]'],
  [/u/gi,   '[υύ]'],
  [/b/gi,   'β'],
  [/g/gi,   'γ'],
  [/d/gi,   'δ'],
  [/z/gi,   'ζ'],
  [/k/gi,   'κ'],
  [/l/gi,   'λ'],
  [/m/gi,   'μ'],
  [/n/gi,   'ν'],
  [/x/gi,   'ξ'],
  [/p/gi,   'π'],
  [/r/gi,   'ρ'],
  [/s/gi,   '[σς]'],
  [/t/gi,   'τ'],
  [/f/gi,   'φ'],
  [/h/gi,   'η'],
  [/w/gi,   'ω'],
  [/y/gi,   '[υψ]'],
];

/**
 * Converts a Latin string to a RegExp pattern that matches its Greek transliteration.
 * Falls back to direct string match if no transliteration applies.
 */
export function translitToGreekPattern(input: string): RegExp {
  let pattern = input;
  for (const [from, to] of TRANSLIT_MAP) {
    pattern = pattern.replace(from, to);
  }
  try {
    return new RegExp(pattern, 'i');
  } catch {
    return new RegExp(input.replace(/[.*+?^${}()|[\]\\]/g, '\\$&'), 'i');
  }
}

interface Props {
  value:       string;
  onChange:    (value: string) => void;
  placeholder?: string;
}

export default function TransliterationSearchInput({
  value,
  onChange,
  placeholder = 'Search words…',
}: Props) {
  return (
    <Box>
      <TextField
        value={value}
        onChange={(e) => onChange(e.target.value)}
        placeholder={placeholder}
        size="small"
        fullWidth
        slotProps={{
          input: {
            startAdornment: (
              <InputAdornment position="start">
                <SearchIcon sx={{ fontSize: 18, color: tokens.color.textMuted }} />
              </InputAdornment>
            ),
          },
        }}
        sx={{
          '& .MuiOutlinedInput-root': { borderRadius: tokens.radius.sm },
        }}
        aria-label="Search vocabulary"
      />
      <FormHelperText sx={{ mt: 0.5, color: tokens.color.textMuted }}>
        Type in English letters — Greek search supported
      </FormHelperText>
    </Box>
  );
}
