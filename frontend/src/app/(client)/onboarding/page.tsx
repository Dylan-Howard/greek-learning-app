'use client';
// src/app/onboarding/page.tsx
//
// Post-signup onboarding screen: user selects their prior Greek knowledge level.
// The selection seeds their SRS deck with the appropriate words pre-marked as known,
// so they don't have to review words they already know.
//
// Route: /onboarding
// Redirect: /auth/signup → /onboarding → /read

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import { useRouter } from 'next/navigation';
import { tokens } from '@/theme/theme';

// ── Rank definitions ─────────────────────────────────────────────────────────
export type KnowledgeRank = 'beginner' | 'intermediate' | 'scholar' | 'advanced';

interface RankOption {
  id:           KnowledgeRank;
  letter:       string;     // Large decorative Greek letter
  name:         string;
  tagline:      string;
  description:  string;
  seedCount:    number;     // Words pre-marked as known in SRS
  seedLabel:    string;     // Human-readable seed description
  threshold:    string;     // "words occurring X+ times"
  color:        string;     // Accent color for this card
  darkBg:       boolean;    // Whether to use dark background
}

const RANKS: RankOption[] = [
  {
    id:          'beginner',
    letter:      'α',
    name:        'Beginner',
    tagline:     'No prior knowledge',
    description: 'I\'m new to biblical Greek. I want to learn from scratch — starting with the alphabet, pronunciation, and the most common words.',
    seedCount:   0,
    seedLabel:   'Start fresh',
    threshold:   'No prerequisites',
    color:       tokens.color.srsNew,
    darkBg:      false,
  },
  {
    id:          'intermediate',
    letter:      'β',
    name:        'Intermediate',
    tagline:     'Vocabulary to 50 occurrences',
    description: 'I know the high-frequency words — the top ~300 terms that cover the majority of NT text. I can read slowly with a lexicon.',
    seedCount:   300,
    seedLabel:   '~300 words pre-seeded',
    threshold:   'Words occurring 50+ times',
    color:       tokens.color.srsHard,
    darkBg:      false,
  },
  {
    id:          'scholar',
    letter:      'γ',
    name:        'Scholar',
    tagline:     'Vocabulary to 15 occurrences',
    description: 'I\'ve taken formal Greek courses or worked through a grammar textbook. I know most vocabulary and can parse forms with confidence.',
    seedCount:   750,
    seedLabel:   '~750 words pre-seeded',
    threshold:   'Words occurring 15+ times',
    color:       tokens.color.tierScholar,
    darkBg:      false,
  },
  {
    id:          'advanced',
    letter:      'δ',
    name:        'Advanced',
    tagline:     'Vocabulary to 5 occurrences',
    description: 'I read Greek regularly and am comfortable with most NT vocabulary. I want to use this app to maintain and sharpen what I already know.',
    seedCount:   1500,
    seedLabel:   '~1,500 words pre-seeded',
    threshold:   'Words occurring 5+ times',
    color:       tokens.color.primaryDark,
    darkBg:      true,
  },
];

// ── Individual rank card ──────────────────────────────────────────────────────
interface CardProps {
  rank:     RankOption;
  selected: boolean;
  onSelect: (id: KnowledgeRank) => void;
}

function RankCard({ rank, selected, onSelect }: CardProps) {
  return (
    <Box
      component="button"
      onClick={() => onSelect(rank.id)}
      aria-pressed={selected}
      sx={{
        display:        'flex',
        flexDirection:  'column',
        textAlign:      'left',
        p:              0,
        border:         'none',
        borderRadius:   tokens.radius.lg,
        cursor:         'pointer',
        position:       'relative',
        overflow:       'hidden',
        outline:        'none',
        // Selection ring
        boxShadow:      selected
          ? `0 0 0 3px ${rank.color}, 0 8px 32px ${rank.color}33`
          : '0 1px 4px rgba(0,0,0,0.06)',
        transition:     `box-shadow ${tokens.motion.normal} ${tokens.motion.ease}, transform ${tokens.motion.fast}`,
        '&:hover':      { transform: 'translateY(-2px)', boxShadow: selected
          ? `0 0 0 3px ${rank.color}, 0 12px 40px ${rank.color}44`
          : `0 6px 20px rgba(0,0,0,0.10)`,
        },
        '&:focus-visible': { boxShadow: `0 0 0 3px ${rank.color}` },
        bgcolor:        rank.darkBg ? tokens.color.primaryDark : tokens.color.bg,
      }}
    >
      {/* Large decorative letter — bottom-right watermark */}
      <Typography
        aria-hidden
        sx={{
          position:   'absolute',
          bottom:     -16,
          right:      8,
          fontFamily: '"Noto Serif", serif',
          fontSize:   '7rem',
          lineHeight: 1,
          color:      rank.darkBg
            ? 'rgba(255,255,255,0.06)'
            : `${rank.color}12`,
          userSelect: 'none',
          pointerEvents: 'none',
        }}
      >
        {rank.letter}
      </Typography>

      {/* Selected indicator bar at top */}
      <Box
        sx={{
          height:     3,
          width:      '100%',
          bgcolor:    selected ? rank.color : 'transparent',
          transition: `background-color ${tokens.motion.normal}`,
          flexShrink: 0,
        }}
      />

      {/* Card body */}
      <Box sx={{ p: 3, flex: 1, display: 'flex', flexDirection: 'column', gap: 2 }}>
        {/* Letter badge + name */}
        <Box sx={{ display: 'flex', alignItems: 'center', gap: 1.5 }}>
          <Box
            sx={{
              width:          40,
              height:         40,
              borderRadius:   tokens.radius.md,
              bgcolor:        selected ? rank.color : `${rank.color}18`,
              color:          selected ? '#FFF' : rank.color,
              display:        'flex',
              alignItems:     'center',
              justifyContent: 'center',
              fontFamily:     '"Noto Serif", serif',
              fontSize:       '1.375rem',
              lineHeight:     1,
              flexShrink:     0,
              transition:     `background-color ${tokens.motion.normal}, color ${tokens.motion.normal}`,
            }}
          >
            {rank.letter}
          </Box>
          <Box>
            <Typography
              sx={{
                fontFamily: '"Noto Serif", serif',
                fontSize:   '1.125rem',
                fontWeight: 700,
                color:      rank.darkBg ? '#FFF' : tokens.color.textPrimary,
                lineHeight: 1.2,
              }}
            >
              {rank.name}
            </Typography>
            <Typography
              sx={{
                fontSize:  '0.75rem',
                fontWeight: 600,
                color:     selected ? rank.color : (rank.darkBg ? 'rgba(255,255,255,0.5)' : tokens.color.textMuted),
                transition: `color ${tokens.motion.normal}`,
              }}
            >
              {rank.tagline}
            </Typography>
          </Box>
        </Box>

        {/* Description */}
        <Typography
          variant="body2"
          sx={{
            color:      rank.darkBg ? 'rgba(255,255,255,0.65)' : tokens.color.textSecondary,
            lineHeight: 1.7,
            flex:       1,
          }}
        >
          {rank.description}
        </Typography>

        {/* Seed info pill */}
        <Box
          sx={{
            display:      'inline-flex',
            alignItems:   'center',
            gap:          0.75,
            px:           1.25,
            py:           0.5,
            borderRadius: tokens.radius.full,
            bgcolor:      selected ? `${rank.color}18` : (rank.darkBg ? 'rgba(255,255,255,0.07)' : tokens.color.surfaceAlt),
            border:       `1px solid ${selected ? rank.color + '44' : 'transparent'}`,
            alignSelf:    'flex-start',
            transition:   `background-color ${tokens.motion.normal}, border-color ${tokens.motion.normal}`,
          }}
        >
          <Box
            sx={{
              width:        6,
              height:       6,
              borderRadius: '50%',
              bgcolor:      selected ? rank.color : (rank.darkBg ? 'rgba(255,255,255,0.3)' : tokens.color.textMuted),
              flexShrink:   0,
              transition:   `background-color ${tokens.motion.normal}`,
            }}
          />
          <Typography
            sx={{
              fontSize:  '0.6875rem',
              fontWeight: 600,
              color:     selected ? rank.color : (rank.darkBg ? 'rgba(255,255,255,0.5)' : tokens.color.textMuted),
              transition: `color ${tokens.motion.normal}`,
            }}
          >
            {rank.seedLabel}
          </Typography>
        </Box>
      </Box>
    </Box>
  );
}

// ── Page ──────────────────────────────────────────────────────────────────────
export default function OnboardingPage() {
  const router  = useRouter();
  const [rank, setRank]       = useState<KnowledgeRank | null>(null);
  const [loading, setLoading] = useState(false);

  async function handleContinue() {
    if (!rank) return;
    setLoading(true);
    // TODO: persist rank to user profile via your API
    // e.g. await fetch('/api/user/onboarding', { method: 'POST', body: JSON.stringify({ rank }) });
    await new Promise((r) => setTimeout(r, 600));
    router.push('/read');
  }

  const selectedRank = RANKS.find((r) => r.id === rank);

  return (
    <Box
      sx={{
        minHeight:       '100vh',
        bgcolor:         tokens.color.bg,
        display:         'flex',
        flexDirection:   'column',
        alignItems:      'center',
        justifyContent:  'center',
        px:              { xs: 3, md: 6 },
        py:              { xs: 6, md: 8 },
        // Same dot-grid as AuthShell
        backgroundImage: `radial-gradient(${tokens.color.border} 1px, transparent 1px)`,
        backgroundSize:  '24px 24px',
      }}
    >
      <Box sx={{ width: '100%', maxWidth: 820 }}>

        {/* Logo */}
        <Box sx={{ display: 'flex', alignItems: 'center', gap: 1.5, mb: 6 }}>
          <Box
            sx={{
              width:          36, height: 36,
              borderRadius:   tokens.radius.md,
              bgcolor:        tokens.color.primary,
              color:          '#FFF',
              display:        'flex',
              alignItems:     'center',
              justifyContent: 'center',
              fontFamily:     '"Noto Serif", serif',
              fontSize:       20,
            }}
          >
            α
          </Box>
          <Typography sx={{ fontFamily: '"Noto Serif", serif', color: tokens.color.primaryDark, fontSize: '1rem' }}>
            Greek NT Reader
          </Typography>
        </Box>

        {/* Heading */}
        <Box
          sx={{
            mb:        5,
            animation: 'fadeInUp 600ms ease both',
            '@keyframes fadeInUp': {
              from: { opacity: 0, transform: 'translateY(16px)' },
              to:   { opacity: 1, transform: 'translateY(0)' },
            },
          }}
        >
          <Typography
            component="h1"
            sx={{
              fontFamily: '"Noto Serif", serif',
              fontSize:   { xs: '1.875rem', md: '2.5rem' },
              color:      tokens.color.textPrimary,
              mb:         1.25,
              lineHeight: 1.2,
            }}
          >
            Where does your Greek journey begin?
          </Typography>
          <Typography
            variant="body1"
            sx={{ color: tokens.color.textSecondary, fontSize: '1.0625rem', maxWidth: 560, lineHeight: 1.7 }}
          >
            We'll pre-seed your vocabulary deck with words you already know, so you can start reading — not reviewing basics you've already mastered.
          </Typography>
        </Box>

        {/* Cards grid */}
        <Box
          sx={{
            display:             'grid',
            gridTemplateColumns: { xs: '1fr', sm: '1fr 1fr' },
            gap:                 2,
            mb:                  5,
            animation:           'fadeInUp 600ms 100ms ease both',
          }}
        >
          {RANKS.map((r) => (
            <RankCard
              key={r.id}
              rank={r}
              selected={rank === r.id}
              onSelect={setRank}
            />
          ))}
        </Box>

        {/* Footer row: seed info + CTA */}
        <Box
          sx={{
            display:     'flex',
            flexDirection: { xs: 'column', sm: 'row' },
            alignItems:  { xs: 'stretch', sm: 'center' },
            gap:         2,
            animation:   'fadeInUp 600ms 200ms ease both',
          }}
        >
          {/* Dynamic summary */}
          <Box sx={{ flex: 1, minHeight: 44, display: 'flex', alignItems: 'center' }}>
            {selectedRank ? (
              <Box
                sx={{
                  display:      'flex',
                  alignItems:   'center',
                  gap:          1,
                  px:           2,
                  py:           1,
                  borderRadius: tokens.radius.md,
                  bgcolor:      `${selectedRank.color}10`,
                  border:       `1px solid ${selectedRank.color}30`,
                }}
              >
                <Box
                  sx={{
                    fontFamily: '"Noto Serif", serif',
                    fontSize:   '1.25rem',
                    lineHeight: 1,
                    color:      selectedRank.color,
                    flexShrink: 0,
                  }}
                >
                  {selectedRank.letter}
                </Box>
                <Box>
                  <Typography sx={{ fontSize: '0.8125rem', fontWeight: 600, color: selectedRank.color, lineHeight: 1.2 }}>
                    {selectedRank.name} selected
                  </Typography>
                  <Typography sx={{ fontSize: '0.6875rem', color: tokens.color.textMuted }}>
                    {selectedRank.seedCount > 0
                      ? `${selectedRank.seedCount.toLocaleString()} words will be marked as known in your deck`
                      : 'Your deck will start empty — we\'ll build it together'}
                  </Typography>
                </Box>
              </Box>
            ) : (
              <Typography variant="body2" sx={{ color: tokens.color.textMuted, fontStyle: 'italic' }}>
                Select your level above to continue
              </Typography>
            )}
          </Box>

          {/* CTA */}
          <Button
            variant="contained"
            size="large"
            onClick={handleContinue}
            disabled={!rank || loading}
            sx={{
              bgcolor:      tokens.color.primary,
              '&:hover':    { bgcolor: tokens.color.primaryDark },
              '&:disabled': { bgcolor: tokens.color.border, color: tokens.color.textMuted },
              fontWeight:   700,
              px:           4,
              py:           1.375,
              fontSize:     '1rem',
              borderRadius: tokens.radius.sm,
              boxShadow:    rank ? `0 4px 20px ${tokens.color.primary}44` : 'none',
              transition:   `box-shadow ${tokens.motion.normal}, background-color ${tokens.motion.fast}`,
              whiteSpace:   'nowrap',
              flexShrink:   0,
            }}
          >
            {loading ? 'Setting up your deck…' : 'Begin reading →'}
          </Button>
        </Box>

        {/* Skip link */}
        <Typography
          variant="body2"
          sx={{ textAlign: 'center', mt: 3, color: tokens.color.textMuted, animation: 'fadeInUp 600ms 300ms ease both' }}
        >
          Not sure?{' '}
          <Box
            component="button"
            onClick={() => router.push('/read')}
            sx={{
              border:     'none',
              bgcolor:    'transparent',
              cursor:     'pointer',
              color:      tokens.color.primary,
              fontWeight: 500,
              fontSize:   'inherit',
              p:          0,
              '&:hover':  { textDecoration: 'underline' },
            }}
          >
            Skip for now
          </Box>
          {' '}— you can always change this in your profile settings.
        </Typography>
      </Box>
    </Box>
  );
}
