'use client';
//
// Bento-grid "How It Works" section.
// Five self-contained interactive micro-UIs arranged in an asymmetric CSS grid:
//
//  Desktop (3-col):
//   ┌─────────────┬──────────────┬───────────────┐
//   │  A: Parse   │  A: Parse    │  B: Flashcard │
//   │  (dark bg)  │  (dark bg)   │  (tall white) │
//   ├─────────────┼──────────────┤               │
//   │  C: Colors  │  D: Streak   │               │
//   │  (surface)  │  (warm tint) │               │
//   ├─────────────┴──────────────┴───────────────┤
//   │  E: Progress bar (full width, accent)       │
//   └────────────────────────────────────────────┘

import React, { useEffect, useRef, useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

// ── Scroll-reveal (reused from landing page) ────────────────────────────────
function useReveal(threshold = 0.1) {
  const ref = useRef<HTMLDivElement>(null);
  const [visible, setVisible] = useState(false);
  useEffect(() => {
    const el = ref.current;
    if (!el) return;
    const obs = new IntersectionObserver(
      ([e]) => { if (e.isIntersecting) setVisible(true); },
      { threshold },
    );
    obs.observe(el);
    return () => obs.disconnect();
  }, [threshold]);
  return { ref, visible };
}

// ── Shared cell label chip ──────────────────────────────────────────────────
function StepChip({ n, dark = false }: { n: number; dark?: boolean }) {
  return (
    <Box
      sx={{
        position:     'absolute',
        top:          14,
        left:         14,
        px:           1,
        py:           0.375,
        borderRadius: tokens.radius.xs,
        border:       `1px solid ${dark ? 'rgba(255,255,255,0.18)' : tokens.color.border}`,
        bgcolor:      dark ? 'rgba(255,255,255,0.10)' : tokens.color.surfaceAlt,
        display:      'flex',
        alignItems:   'center',
        gap:          0.625,
        zIndex:       2,
      }}
    >
      <Box
        sx={{
          width:          16,
          height:         16,
          borderRadius:   '50%',
          bgcolor:        dark ? 'rgba(255,255,255,0.85)' : tokens.color.primary,
          color:          dark ? tokens.color.primaryDark : '#FFF',
          display:        'flex',
          alignItems:     'center',
          justifyContent: 'center',
          fontSize:        '0.5625rem',
          fontWeight:      700,
          fontFamily:     '"Noto Sans", sans-serif',
          lineHeight:      1,
        }}
      >
        {n}
      </Box>
      <Typography
        sx={{
          fontSize:      '0.5625rem',
          fontWeight:    600,
          letterSpacing: '0.06em',
          textTransform: 'uppercase',
          color:         dark ? 'rgba(255,255,255,0.7)' : tokens.color.textMuted,
        }}
      >
        {['Tap to parse','Flashcard review','Word status','Build a streak','Track progress'][n - 1]}
      </Typography>
    </Box>
  );
}

// ─────────────────────────────────────────────────────────────────────────────
// CELL A — Tap-to-parse (dark, large)
// ─────────────────────────────────────────────────────────────────────────────
const PARSE_WORDS = [
  { id: 'en',    text: 'Ἐν',     status: 'mastered', lex: 'ἐν',    def: 'in, on, among',           pos: 'Prep',  freq: 2752 },
  { id: 'arche', text: 'ἀρχῇ',   status: 'due',      lex: 'ἀρχή',  def: 'beginning, origin',       pos: 'Noun',  freq: 55   },
  { id: 'en2',   text: 'ἦν',     status: 'mastered', lex: 'εἰμί',  def: 'I am, exist',             pos: 'Verb',  freq: 2460 },
  { id: 'ho',    text: 'ὁ',      status: 'mastered', lex: 'ὁ',     def: 'the (masc. nom. sg.)',     pos: 'Art',   freq: 9164 },
  { id: 'logos', text: 'Λόγος',  status: 'new',      lex: 'λόγος', def: 'word, reason, account',   pos: 'Noun',  freq: 330  },
];

const STATUS_COLORS: Record<string, string> = {
  new:      tokens.color.srsNew,
  due:      tokens.color.srsAgain,
  mastered: tokens.color.srsEasy,
};

function CellParse() {
  const [selected, setSelected] = useState<typeof PARSE_WORDS[0] | null>(null);
  const [panelIn,  setPanelIn]  = useState(false);

  function handleSelect(w: typeof PARSE_WORDS[0]) {
    if (selected?.id === w.id) {
      setPanelIn(false);
      setTimeout(() => setSelected(null), 220);
    } else {
      setSelected(w);
      setPanelIn(false);
      // tiny delay so transition re-fires on word change
      requestAnimationFrame(() => requestAnimationFrame(() => setPanelIn(true)));
    }
  }

  return (
    <Box
      sx={{
        gridArea:     'parse',
        position:     'relative',
        bgcolor:      tokens.color.primaryDark,
        borderRadius: tokens.radius.lg,
        p:            2.5,
        pt:           10,
        display:      'flex',
        flexDirection: 'column',
        gap:          2,
        overflow:     'hidden',
        minHeight:    260,
        cursor:       'default',
      }}
    >
      {/* Decorative watermark */}
      <Typography
        aria-hidden
        sx={{
          position:   'absolute',
          fontFamily: '"Noto Serif", serif',
          fontSize:   '7rem',
          color:      'rgba(255,255,255,0.04)',
          bottom:     -16,
          right:      -8,
          lineHeight: 1,
          userSelect: 'none',
          pointerEvents: 'none',
        }}
      >
        Λόγος
      </Typography>

      <StepChip n={1} dark />

      {/* Verse */}
      <Box sx={{ lineHeight: 2.0, flex: 1 }}>
        <Typography
          component="span"
          sx={{ fontSize: '0.5rem', color: 'rgba(255,255,255,0.35)', verticalAlign: 'super', mr: 0.5, fontFamily: '"Noto Sans"' }}
        >
          1
        </Typography>
        {PARSE_WORDS.map((w, i) => (
          <React.Fragment key={w.id}>
            <Box
              component="span"
              onClick={() => handleSelect(w)}
              sx={{
                fontFamily:     '"Noto Serif", serif',
                fontSize:       '1.375rem',
                lineHeight:     1.9,
                color:          selected?.id === w.id ? tokens.color.xpGold : 'rgba(255,255,255,0.92)',
                borderBottom:   `2px solid ${w.status === 'mastered' ? 'rgba(255,255,255,0.2)' : STATUS_COLORS[w.status]}`,
                cursor:         'pointer',
                px:             selected?.id === w.id ? 0.25 : 0,
                bgcolor:        selected?.id === w.id ? 'rgba(201,168,76,0.15)' : 'transparent',
                borderRadius:   tokens.radius.xs,
                transition:     `color 150ms, background-color 150ms`,
                userSelect:     'none',
                display:        'inline',
                '&:hover':      { color: tokens.color.xpGold },
              }}
            >
              {w.text}
            </Box>
            {i < PARSE_WORDS.length - 1 && (
              <Box component="span" sx={{ color: 'rgba(255,255,255,0.4)', fontFamily: '"Noto Serif"', fontSize: '1.375rem' }}> </Box>
            )}
          </React.Fragment>
        ))}
      </Box>

      {/* Parsing panel — slides up */}
      <Box
        sx={{
          bgcolor:      'rgba(255,255,255,0.07)',
          borderRadius: tokens.radius.md,
          border:       '1px solid rgba(255,255,255,0.10)',
          p:            1.5,
          transform:    panelIn && selected ? 'translateY(0)' : 'translateY(12px)',
          opacity:      panelIn && selected ? 1 : 0,
          transition:   'transform 220ms ease, opacity 220ms ease',
          minHeight:    72,
        }}
      >
        {selected ? (
          <Box sx={{ display: 'flex', gap: 2, alignItems: 'flex-start' }}>
            <Box>
              <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: '1.25rem', color: 'rgba(255,255,255,0.95)', lineHeight: 1.3 }}>
                {selected.lex}
              </Typography>
              <Typography sx={{ fontSize: '0.75rem', fontWeight: 600, color: tokens.color.xpGold, mt: 0.25 }}>
                {selected.def}
              </Typography>
            </Box>
            <Box sx={{ ml: 'auto', display: 'grid', gridTemplateColumns: '1fr 1fr', gap: 0.75 }}>
              {[['POS', selected.pos], ['Freq', `${selected.freq}×`]].map(([l, v]) => (
                <Box key={l}>
                  <Typography sx={{ fontSize: '0.5rem', color: 'rgba(255,255,255,0.35)', textTransform: 'uppercase', letterSpacing: '0.07em' }}>{l}</Typography>
                  <Typography sx={{ fontSize: '0.6875rem', color: 'rgba(255,255,255,0.75)' }}>{v}</Typography>
                </Box>
              ))}
            </Box>
          </Box>
        ) : (
          <Typography sx={{ fontSize: '0.75rem', color: 'rgba(255,255,255,0.3)', fontStyle: 'italic', textAlign: 'center', pt: 1 }}>
            ↑ tap any word
          </Typography>
        )}
      </Box>
    </Box>
  );
}

// ─────────────────────────────────────────────────────────────────────────────
// CELL B — Flashcard (white, tall, spans 2 rows)
// ─────────────────────────────────────────────────────────────────────────────
const DEMO_CARDS = [
  { front: 'λόγος', back: 'word, reason, account', parsing: 'Noun · Masc. Nom. Sg.', intervals: { again: '<10m', hard: '1d', good: '3d', easy: '1w' } },
  { front: 'ἀρχή',  back: 'beginning, origin',     parsing: 'Noun · Fem. Dat. Sg.',  intervals: { again: '<10m', hard: '2d', good: '5d', easy: '2w' } },
  { front: 'πρός',  back: 'toward, with (+ acc)',   parsing: 'Preposition',            intervals: { again: '<10m', hard: '1d', good: '4d', easy: '1w' } },
];

const RATINGS: { id: string; label: string; color: string }[] = [
  { id: 'again', label: 'Again', color: tokens.color.srsAgain },
  { id: 'hard',  label: 'Hard',  color: tokens.color.srsHard  },
  { id: 'good',  label: 'Good',  color: tokens.color.srsGood  },
  { id: 'easy',  label: 'Easy',  color: tokens.color.srsEasy  },
];

function CellFlashcard() {
  const [cardIdx, setCardIdx] = useState(0);
  const [flipped, setFlipped] = useState(false);
  const [rated,   setRated]   = useState<string | null>(null);
  const [exiting, setExiting] = useState(false);
  const card = DEMO_CARDS[cardIdx];

  function handleRate(id: string) {
    setRated(id);
    setExiting(true);
    setTimeout(() => {
      setFlipped(false);
      setRated(null);
      setExiting(false);
      setCardIdx((i) => (i + 1) % DEMO_CARDS.length);
    }, 380);
  }

  return (
    <Box
      sx={{
        gridArea:      'flip',
        position:      'relative',
        bgcolor:       tokens.color.bg,
        borderRadius:  tokens.radius.lg,
        border:        `1px solid ${tokens.color.border}`,
        p:             2.5,
        pt:            10,
        display:       'flex',
        flexDirection: 'column',
        gap:           1.5,
        overflow:      'hidden',
      }}
    >
      <StepChip n={2} />

      {/* Card */}
      <Box
        onClick={() => !flipped && setFlipped(true)}
        sx={{
          flex:        1,
          perspective: '600px',
          cursor:      flipped ? 'default' : 'pointer',
          minHeight:   140,
        }}
      >
        <Box
          sx={{
            width:          '100%',
            height:         '100%',
            position:       'relative',
            transformStyle: 'preserve-3d',
            transform:      flipped ? 'rotateY(180deg)' : 'rotateY(0deg)',
            opacity:        exiting ? 0 : 1,
            transition:     exiting
              ? 'opacity 300ms ease'
              : `transform ${tokens.motion.slow} ${tokens.motion.ease}`,
          }}
        >
          {/* Front */}
          <Box
            sx={{
              position:           'absolute', inset: 0,
              backfaceVisibility: 'hidden', WebkitBackfaceVisibility: 'hidden',
              bgcolor:            tokens.color.surface,
              border:             `1px solid ${tokens.color.border}`,
              borderRadius:       tokens.radius.md,
              display:            'flex',
              flexDirection:      'column',
              alignItems:         'center',
              justifyContent:     'center',
              gap:                0.75,
              p:                  2,
            }}
          >
            <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: '2rem', color: tokens.color.textPrimary }}>
              {card.front}
            </Typography>
            <Typography sx={{ fontSize: '0.625rem', fontWeight: 600, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em' }}>
              tap to reveal
            </Typography>
          </Box>

          {/* Back */}
          <Box
            sx={{
              position:           'absolute', inset: 0,
              backfaceVisibility: 'hidden', WebkitBackfaceVisibility: 'hidden',
              transform:          'rotateY(180deg)',
              bgcolor:            tokens.color.bg,
              border:             `1px solid ${tokens.color.border}`,
              borderRadius:       tokens.radius.md,
              display:            'flex',
              flexDirection:      'column',
              alignItems:         'center',
              justifyContent:     'center',
              gap:                0.5,
              p:                  2,
            }}
          >
            <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: '1rem', color: tokens.color.primary, fontWeight: 600, textAlign: 'center' }}>
              {card.back}
            </Typography>
            <Typography variant="body2" sx={{ color: tokens.color.textMuted, textAlign: 'center', fontSize: '0.75rem' }}>
              {card.parsing}
            </Typography>
          </Box>
        </Box>
      </Box>

      {/* Rating row */}
      <Box
        sx={{
          display:    'flex',
          gap:        0.5,
          opacity:    flipped ? 1 : 0,
          transform:  flipped ? 'translateY(0)' : 'translateY(6px)',
          transition: 'opacity 200ms ease, transform 200ms ease',
          pointerEvents: flipped ? 'auto' : 'none',
        }}
      >
        {RATINGS.map(({ id, label, color }) => (
          <Box
            key={id}
            onClick={() => handleRate(id)}
            sx={{
              flex:         1,
              py:           0.625,
              borderRadius: tokens.radius.xs,
              bgcolor:      rated === id ? color : `${color}22`,
              color:        rated === id ? '#FFF' : color,
              fontWeight:   700,
              fontSize:     '0.625rem',
              textAlign:    'center',
              cursor:       'pointer',
              border:       `1px solid ${color}44`,
              fontFamily:   '"Noto Sans", sans-serif',
              transition:   `background-color 150ms, color 150ms`,
              userSelect:   'none',
              '&:hover':    { bgcolor: color, color: '#FFF' },
            }}
          >
            {label}
          </Box>
        ))}
      </Box>

      {/* Interval hints */}
      <Box sx={{ display: 'flex', gap: 0.5, opacity: flipped ? 0.7 : 0, transition: 'opacity 200ms' }}>
        {RATINGS.map(({ id, label }) => (
          <Box key={id} sx={{ flex: 1, textAlign: 'center', fontSize: '0.5625rem', color: tokens.color.textMuted, fontFamily: '"Noto Sans"' }}>
            {card.intervals[id as keyof typeof card.intervals]}
          </Box>
        ))}
      </Box>
    </Box>
  );
}

// ─────────────────────────────────────────────────────────────────────────────
// CELL C — Word status colours (surface)
// ─────────────────────────────────────────────────────────────────────────────
const STATUS_DEMO = [
  { word: 'θεός',     status: 'mastered', label: 'Mastered',  color: tokens.color.srsEasy,  desc: 'solid recall' },
  { word: 'ἄνθρωπος', status: 'due',      label: 'Due',       color: tokens.color.srsAgain, desc: 'review today' },
  { word: 'ζωή',      status: 'new',      label: 'New',       color: tokens.color.srsNew,   desc: 'first time'   },
];

function CellColors() {
  const [hovered, setHovered] = useState<string | null>(null);

  return (
    <Box
      sx={{
        gridArea:      'colors',
        position:      'relative',
        bgcolor:       tokens.color.surface,
        borderRadius:  tokens.radius.lg,
        border:        `1px solid ${tokens.color.border}`,
        p:             2.5,
        pt:            10,
        display:       'flex',
        flexDirection: 'column',
        gap:           1.25,
        overflow:      'hidden',
      }}
    >
      <StepChip n={3} />

      {STATUS_DEMO.map(({ word, status, label, color, desc }) => (
        <Box
          key={status}
          onMouseEnter={() => setHovered(status)}
          onMouseLeave={() => setHovered(null)}
          sx={{
            display:      'flex',
            alignItems:   'center',
            gap:          1.5,
            px:           1.25,
            py:           0.875,
            borderRadius: tokens.radius.sm,
            bgcolor:      hovered === status ? `${color}10` : 'transparent',
            transition:   `background-color ${tokens.motion.fast}`,
            cursor:       'default',
          }}
        >
          <Box
            sx={{
              fontFamily:   '"Noto Serif", serif',
              fontSize:     '1.0625rem',
              lineHeight:   1.6,
              borderBottom: `2.5px solid ${color}`,
              pb:           '1px',
              color:        tokens.color.textPrimary,
              flexShrink:   0,
              minWidth:     80,
            }}
          >
            {word}
          </Box>
          <Box>
            <Typography sx={{ fontSize: '0.75rem', fontWeight: 700, color, lineHeight: 1.2 }}>
              {label}
            </Typography>
            <Typography sx={{ fontSize: '0.625rem', color: tokens.color.textMuted }}>
              {desc}
            </Typography>
          </Box>
        </Box>
      ))}
    </Box>
  );
}

// ─────────────────────────────────────────────────────────────────────────────
// CELL D — Streak & XP ring (warm tint)
// ─────────────────────────────────────────────────────────────────────────────
function AnimatedRing({ pct, size = 52 }: { pct: number; size?: number }) {
  const r    = (size - 6) / 2;
  const circ = 2 * Math.PI * r;
  const dash = (pct / 100) * circ;
  return (
    <svg width={size} height={size} viewBox={`0 0 ${size} ${size}`} style={{ transform: 'rotate(-90deg)', flexShrink: 0 }}>
      <circle cx={size / 2} cy={size / 2} r={r} fill="none" stroke={tokens.color.xpRingBg} strokeWidth={4} />
      <circle cx={size / 2} cy={size / 2} r={r} fill="none" stroke={tokens.color.xpGold} strokeWidth={4}
        strokeLinecap="round"
        strokeDasharray={`${dash} ${circ}`}
        style={{ transition: `stroke-dasharray 800ms ${tokens.motion.ease}` }}
      />
    </svg>
  );
}

function CellStreak() {
  const { ref, visible } = useReveal(0.3);
  const [streak,  setStreak]  = useState(0);
  const [xp,      setXP]      = useState(0);
  const [pressed, setPressed] = useState(false);
  const targetStreak = 14;
  const targetXP     = 68;

  useEffect(() => {
    if (!visible) return;
    let s = 0, x = 0;
    const t = setInterval(() => {
      s = Math.min(s + 1, targetStreak);
      x = Math.min(x + 3, targetXP);
      setStreak(s);
      setXP(x);
      if (s >= targetStreak && x >= targetXP) clearInterval(t);
    }, 60);
    return () => clearInterval(t);
  }, [visible]);

  function handlePress() {
    setPressed(true);
    setStreak((s) => Math.min(s + 1, 30));
    setXP((x) => Math.min(x + 7, 100));
    setTimeout(() => setPressed(false), 600);
  }

  return (
    <Box
      ref={ref}
      onClick={handlePress}
      sx={{
        gridArea:      'streak',
        position:      'relative',
        bgcolor:       tokens.color.primaryLight,
        borderRadius:  tokens.radius.lg,
        border:        `1px solid ${tokens.color.border}`,
        p:             2.5,
        pt:            5.5,
        display:       'flex',
        flexDirection: 'column',
        gap:           1.5,
        cursor:        'pointer',
        overflow:      'hidden',
        userSelect:    'none',
        transition:    `transform ${tokens.motion.fast}`,
        '&:active':    { transform: 'scale(0.98)' },
      }}
    >
      <StepChip n={4} />

      {/* Streak + ring side by side */}
      <Box sx={{ display: 'flex', alignItems: 'center', gap: 1.5 }}>
        <AnimatedRing pct={xp} size={48} />
        <Box>
          <Box sx={{ display: 'flex', alignItems: 'baseline', gap: 0.5 }}>
            <Typography sx={{ fontSize: '1.75rem', fontWeight: 700, color: tokens.color.srsHard, lineHeight: 1, fontFamily: '"Noto Sans"' }}>
              {streak}
            </Typography>
            <Typography sx={{ fontSize: '0.75rem', color: tokens.color.textMuted }}>day streak</Typography>
          </Box>
          <Box sx={{ display: 'flex', alignItems: 'baseline', gap: 0.5, mt: 0.25 }}>
            <Typography sx={{ fontSize: '1rem', fontWeight: 700, color: tokens.color.xpGold, lineHeight: 1, fontFamily: '"Noto Sans"' }}>
              {xp}%
            </Typography>
            <Typography sx={{ fontSize: '0.625rem', color: tokens.color.textMuted }}>to next level</Typography>
          </Box>
        </Box>
      </Box>

      {/* Tap hint */}
      <Typography
        sx={{
          fontSize:  '0.625rem',
          color:     tokens.color.primary,
          fontWeight: 600,
          opacity:   pressed ? 0 : 0.7,
          transition: 'opacity 300ms',
        }}
      >
        tap to earn XP ↑
      </Typography>

      {/* XP pop */}
      <Typography
        sx={{
          position:   'absolute',
          top:        '40%',
          left:       '50%',
          transform:  pressed ? 'translate(-50%, -16px)' : 'translate(-50%, 0)',
          opacity:    pressed ? 1 : 0,
          transition: 'opacity 200ms, transform 200ms',
          fontWeight: 700,
          fontSize:   '1rem',
          color:      tokens.color.xpGold,
          pointerEvents: 'none',
          fontFamily: '"Noto Sans"',
        }}
      >
        +7 XP
      </Typography>
    </Box>
  );
}

// ─────────────────────────────────────────────────────────────────────────────
// CELL E — Progress over time (full-width accent strip)
// ─────────────────────────────────────────────────────────────────────────────
const SPARKLINE_DATA = [2, 5, 4, 8, 12, 9, 14, 18, 16, 22, 20, 28, 25, 32, 30, 38, 35, 42, 40, 48, 45, 55, 52, 60, 58, 68, 65, 74, 80, 89];

function MiniSparkline({ data, width, height, color }: { data: number[]; width: number; height: number; color: string }) {
  const max    = Math.max(...data);
  const pts    = data.map((v, i) => {
    const x = (i / (data.length - 1)) * width;
    const y = height - (v / max) * height;
    return `${x},${y}`;
  }).join(' ');
  const area = `0,${height} ` + pts + ` ${width},${height}`;

  return (
    <svg width={width} height={height} viewBox={`0 0 ${width} ${height}`} preserveAspectRatio="none">
      <defs>
        <linearGradient id="sparkFill" x1="0" y1="0" x2="0" y2="1">
          <stop offset="0%"   stopColor={color} stopOpacity="0.3" />
          <stop offset="100%" stopColor={color} stopOpacity="0.02" />
        </linearGradient>
      </defs>
      <polyline points={area} fill="url(#sparkFill)" />
      <polyline points={pts} fill="none" stroke={color} strokeWidth="2" strokeLinejoin="round" strokeLinecap="round" />
    </svg>
  );
}

function CellProgress() {
  const { ref, visible } = useReveal(0.2);
  const [count, setCount] = useState(0);

  useEffect(() => {
    if (!visible) return;
    let n = 0;
    const t = setInterval(() => {
      n = Math.min(n + 3, 89);
      setCount(n);
      if (n >= 89) clearInterval(t);
    }, 18);
    return () => clearInterval(t);
  }, [visible]);

  return (
    <Box
      ref={ref}
      sx={{
        gridArea:     'progress',
        position:     'relative',
        bgcolor:      tokens.color.primaryDark,
        borderRadius: tokens.radius.lg,
        px:           2.5,
        py:           2,
        pt:           4.5,
        display:      'flex',
        alignItems:   'center',
        gap:          3,
        overflow:     'hidden',
      }}
    >
      <StepChip n={5} dark />

      {/* Count */}
      <Box sx={{ flexShrink: 0 }}>
        <Box sx={{ display: 'flex', alignItems: 'baseline', gap: 0.75 }}>
          <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: '2.25rem', color: tokens.color.xpGold, lineHeight: 1 }}>
            {count}
          </Typography>
          <Typography sx={{ fontSize: '0.875rem', color: 'rgba(255,255,255,0.5)' }}>words mastered</Typography>
        </Box>
        <Typography sx={{ fontSize: '0.6875rem', color: 'rgba(255,255,255,0.35)', mt: 0.25 }}>
          in your first 30 days
        </Typography>
      </Box>

      {/* Sparkline — fills remaining space */}
      <Box sx={{ flex: 1, height: 56, overflow: 'hidden' }}>
        <MiniSparkline data={SPARKLINE_DATA} width={300} height={56} color={tokens.color.xpGold} />
      </Box>

      {/* Decorative label right */}
      <Typography
        aria-hidden
        sx={{
          position:   'absolute',
          right:      20,
          bottom:     8,
          fontFamily: '"Noto Serif", serif',
          fontSize:   '0.625rem',
          color:      'rgba(255,255,255,0.2)',
          letterSpacing: '0.1em',
          textTransform: 'uppercase',
        }}
      >
        30-day arc
      </Typography>
    </Box>
  );
}

// ─────────────────────────────────────────────────────────────────────────────
// BENTO GRID
// ─────────────────────────────────────────────────────────────────────────────
export default function HowItWorksBento() {
  const { ref: sectionRef, visible: sectionVisible } = useReveal(0.05);

  return (
    <Box
      id="how-it-works"
      sx={{ py: { xs: 10, md: 14 }, px: { xs: 3, md: 6 }, bgcolor: tokens.color.surface, borderTop: `1px solid ${tokens.color.border}`, borderBottom: `1px solid ${tokens.color.border}` }}
    >
      <Box sx={{ maxWidth: 1100, mx: 'auto' }}>

        {/* Section heading */}
        <Box
          ref={sectionRef}
          sx={{
            mb:         { xs: 5, md: 7 },
            opacity:    sectionVisible ? 1 : 0,
            transform:  sectionVisible ? 'translateY(0)' : 'translateY(20px)',
            transition: 'opacity 600ms ease, transform 600ms ease',
          }}
        >
          <Typography
            sx={{
              fontFamily: '"Noto Serif", serif',
              fontSize:   { xs: '2rem', md: '2.625rem' },
              color:      tokens.color.textPrimary,
              mb:         1,
              lineHeight: 1.2,
            }}
          >
            How it works.
          </Typography>
          <Typography variant="body1" sx={{ color: tokens.color.textSecondary, fontSize: '1.0625rem', maxWidth: 520 }}>
            Five interactions. The entire product. Try each one.
          </Typography>
        </Box>

        {/* Bento grid */}
        <Box
          sx={{
            display:             'grid',
            gridTemplateAreas:   {
              xs: `
                "parse"
                "flip"
                "colors"
                "streak"
                "progress"
              `,
              md: `
                "parse  parse  flip"
                "colors streak flip"
                "progress progress progress"
              `,
            },
            gridTemplateColumns: { xs: '1fr', md: '1fr 1fr 1fr' },
            gridTemplateRows:    { xs: 'auto', md: '260px 200px 120px' },
            gap:                 1.5,
          }}
        >
          <CellParse />
          <CellFlashcard />
          <CellColors />
          <CellStreak />
          <CellProgress />
        </Box>
      </Box>
    </Box>
  );
}
