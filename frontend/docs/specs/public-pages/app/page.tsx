'use client';
// src/app/page.tsx — Landing page
// Replaces the old redirect stub.

import React, { useEffect, useRef, useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import Link from '@mui/material/Link';
import Divider from '@mui/material/Divider';
import { useRouter } from 'next/navigation';
import PublicLayout from '@/components/public/PublicLayout';
import { tokens } from '@/theme/theme';

// ── Scroll-reveal hook ──────────────────────────────────────────────────────
function useReveal() {
  const ref = useRef<HTMLDivElement>(null);
  const [visible, setVisible] = useState(false);
  useEffect(() => {
    const el = ref.current;
    if (!el) return;
    const observer = new IntersectionObserver(
      ([entry]) => { if (entry.isIntersecting) setVisible(true); },
      { threshold: 0.12 },
    );
    observer.observe(el);
    return () => observer.disconnect();
  }, []);
  return { ref, visible };
}

// ── Reveal wrapper ──────────────────────────────────────────────────────────
function Reveal({ children, delay = 0 }: { children: React.ReactNode; delay?: number }) {
  const { ref, visible } = useReveal();
  return (
    <Box
      ref={ref}
      sx={{
        opacity:    visible ? 1 : 0,
        transform:  visible ? 'translateY(0)' : 'translateY(28px)',
        transition: `opacity 600ms ease ${delay}ms, transform 600ms ease ${delay}ms`,
      }}
    >
      {children}
    </Box>
  );
}

// ── Mini reader mockup (hero visual) ────────────────────────────────────────
const MOCK_WORDS = [
  { text: 'Ἐν',     status: 'mastered', selected: false },
  { text: 'ἀρχῇ',   status: 'due',      selected: false },
  { text: 'ἦν',     status: 'mastered', selected: false },
  { text: 'ὁ',      status: 'mastered', selected: false },
  { text: 'Λόγος,', status: 'new',      selected: true  },
];
const MOCK_VERSE2 = [
  { text: 'καὶ', status: 'mastered', selected: false },
  { text: 'ὁ',   status: 'mastered', selected: false },
  { text: 'Λόγος', status: 'new',    selected: false },
  { text: 'ἦν',  status: 'mastered', selected: false },
  { text: 'πρὸς', status: 'due',     selected: false },
  { text: 'τὸν', status: 'mastered', selected: false },
  { text: 'Θεόν.', status: 'new',    selected: false },
];

const STATUS_UNDERLINE: Record<string, string> = {
  new:      tokens.color.srsNew,
  due:      tokens.color.srsAgain,
  mastered: tokens.color.srsEasy,
};

function MockWord({ text, status, selected }: { text: string; status: string; selected: boolean }) {
  return (
    <Box
      component="span"
      sx={{
        fontFamily:   '"Noto Serif", serif',
        fontSize:     { xs: '1.125rem', md: '1.25rem' },
        lineHeight:   2.0,
        borderBottom: status !== 'default' ? `2px solid ${STATUS_UNDERLINE[status]}` : 'none',
        bgcolor:      selected ? `${tokens.color.primaryLight}` : 'transparent',
        px:           selected ? 0.25 : 0,
        borderRadius: selected ? tokens.radius.xs : 0,
        cursor:       'default',
      }}
    >
      {text}
    </Box>
  );
}

function ReaderMockup() {
  return (
    <Box
      sx={{
        borderRadius: tokens.radius.lg,
        border:       `1px solid ${tokens.color.border}`,
        boxShadow:    '0 20px 60px rgba(107,66,38,0.12), 0 4px 16px rgba(0,0,0,0.06)',
        overflow:     'hidden',
        bgcolor:      tokens.color.bg,
        maxWidth:     560,
        width:        '100%',
      }}
    >
      {/* Browser chrome bar */}
      <Box sx={{ bgcolor: tokens.color.surface, borderBottom: `1px solid ${tokens.color.border}`, px: 2, py: 1, display: 'flex', alignItems: 'center', gap: 1 }}>
        <Box sx={{ display: 'flex', gap: 0.625 }}>
          {['#FF5F56','#FFBD2E','#27C93F'].map((c) => (
            <Box key={c} sx={{ width: 10, height: 10, borderRadius: '50%', bgcolor: c }} />
          ))}
        </Box>
        <Box sx={{ flex: 1, mx: 2, bgcolor: tokens.color.surfaceAlt, borderRadius: tokens.radius.xs, px: 1.5, py: 0.375, fontSize: '0.625rem', color: tokens.color.textMuted, textAlign: 'center' }}>
          gntreader.app/read
        </Box>
      </Box>

      {/* App content */}
      <Box sx={{ display: 'flex', height: { xs: 240, md: 320 } }}>
        {/* Text column */}
        <Box sx={{ flex: 1, p: { xs: 2, md: 3 }, overflowY: 'hidden', borderRight: `1px solid ${tokens.color.border}` }}>
          {/* Ghost chapter selector */}
          <Box sx={{ display: 'flex', gap: 0.5, mb: 2, justifyContent: 'center' }}>
            <Box sx={{ fontSize: '0.6875rem', color: tokens.color.textMuted, px: 1, py: 0.25, borderRadius: tokens.radius.xs, bgcolor: tokens.color.surfaceAlt }}>John</Box>
            <Box sx={{ fontSize: '0.6875rem', color: tokens.color.textMuted }}>/ Ch. 1</Box>
          </Box>
          {/* Verses */}
          <Box component="p" sx={{ m: 0, lineHeight: 2, mb: 1, '&::before': { content: '"1"', fontSize: '0.6rem', verticalAlign: 'super', color: tokens.color.textMuted, mr: 0.5, fontFamily: '"Noto Sans"' } }}>
            {MOCK_WORDS.map((w, i) => (
              <React.Fragment key={i}>
                <MockWord {...w} />
                {i < MOCK_WORDS.length - 1 && ' '}
              </React.Fragment>
            ))}
          </Box>
          <Box component="p" sx={{ m: 0, lineHeight: 2, '&::before': { content: '"2"', fontSize: '0.6rem', verticalAlign: 'super', color: tokens.color.textMuted, mr: 0.5, fontFamily: '"Noto Sans"' } }}>
            {MOCK_VERSE2.map((w, i) => (
              <React.Fragment key={i}>
                <MockWord {...w} />
                {i < MOCK_VERSE2.length - 1 && ' '}
              </React.Fragment>
            ))}
          </Box>
        </Box>

        {/* Sidebar */}
        <Box sx={{ width: { xs: 130, md: 160 }, p: 1.5, display: 'flex', flexDirection: 'column', gap: 0.75, bgcolor: tokens.color.surface }}>
          <Typography sx={{ fontSize: '0.5rem', fontWeight: 700, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em' }}>Word Details</Typography>
          <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: { xs: '1rem', md: '1.125rem' }, color: tokens.color.textPrimary }}>λόγος</Typography>
          <Typography sx={{ fontSize: '0.6875rem', fontWeight: 600, color: tokens.color.primary }}>word, reason, account</Typography>
          <Box sx={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: 0.5, mt: 0.25 }}>
            {[['Case','Nom.'],['Number','Sg.'],['Gender','Masc.'],['POS','Noun']].map(([l, v]) => (
              <Box key={l}>
                <Typography sx={{ fontSize: '0.5rem', color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.06em' }}>{l}</Typography>
                <Typography sx={{ fontSize: '0.625rem', color: tokens.color.textPrimary }}>{v}</Typography>
              </Box>
            ))}
          </Box>
          <Box sx={{ mt: 'auto', pt: 1, borderTop: `1px solid ${tokens.color.border}` }}>
            <Box sx={{ bgcolor: tokens.color.srsAgain, color: '#FFF', borderRadius: tokens.radius.xs, px: 1, py: 0.375, fontSize: '0.5625rem', fontWeight: 700, textAlign: 'center' }}>
              2 words due
            </Box>
          </Box>
        </Box>
      </Box>

      {/* SRS legend */}
      <Box sx={{ px: 2.5, py: 1.25, bgcolor: tokens.color.surface, borderTop: `1px solid ${tokens.color.border}`, display: 'flex', gap: 2, flexWrap: 'wrap' }}>
        {[
          { color: tokens.color.srsNew,  label: 'New' },
          { color: tokens.color.srsAgain,label: 'Due for review' },
          { color: tokens.color.srsEasy, label: 'Mastered' },
        ].map(({ color, label }) => (
          <Box key={label} sx={{ display: 'flex', alignItems: 'center', gap: 0.5 }}>
            <Box sx={{ width: 18, height: 2, bgcolor: color, borderRadius: 1 }} />
            <Typography sx={{ fontSize: '0.6rem', color: tokens.color.textMuted }}>{label}</Typography>
          </Box>
        ))}
      </Box>
    </Box>
  );
}

// ── Feature card ─────────────────────────────────────────────────────────────
function FeatureCard({ icon, title, body, delay }: { icon: string; title: string; body: string; delay: number }) {
  return (
    <Reveal delay={delay}>
      <Box
        sx={{
          p:            3,
          borderRadius: tokens.radius.lg,
          border:       `1px solid ${tokens.color.border}`,
          bgcolor:      tokens.color.bg,
          height:       '100%',
          transition:   `box-shadow ${tokens.motion.normal}`,
          '&:hover':    { boxShadow: '0 8px 32px rgba(107,66,38,0.10)' },
        }}
      >
        <Typography sx={{ fontSize: '2rem', mb: 1.5, lineHeight: 1 }}>{icon}</Typography>
        <Typography variant="h3" sx={{ mb: 1, color: tokens.color.textPrimary }}>{title}</Typography>
        <Typography variant="body1" sx={{ color: tokens.color.textSecondary, lineHeight: 1.7 }}>{body}</Typography>
      </Box>
    </Reveal>
  );
}

// ── Step ─────────────────────────────────────────────────────────────────────
function Step({ n, title, body, delay }: { n: number; title: string; body: string; delay: number }) {
  return (
    <Reveal delay={delay}>
      <Box sx={{ display: 'flex', gap: 2.5, alignItems: 'flex-start' }}>
        <Box
          sx={{
            width:          44,
            height:         44,
            borderRadius:   '50%',
            bgcolor:        tokens.color.primaryLight,
            border:         `2px solid ${tokens.color.primary}`,
            color:          tokens.color.primary,
            display:        'flex',
            alignItems:     'center',
            justifyContent: 'center',
            fontFamily:     '"Noto Serif", serif',
            fontSize:       '1.25rem',
            fontWeight:     700,
            flexShrink:     0,
          }}
        >
          {n}
        </Box>
        <Box sx={{ pt: 0.5 }}>
          <Typography variant="h3" sx={{ mb: 0.5 }}>{title}</Typography>
          <Typography variant="body1" sx={{ color: tokens.color.textSecondary, lineHeight: 1.7 }}>{body}</Typography>
        </Box>
      </Box>
    </Reveal>
  );
}

// ── Page ─────────────────────────────────────────────────────────────────────
export default function LandingPage() {
  const router = useRouter();

  return (
    <PublicLayout>
      {/* ── HERO ── */}
      <Box
        sx={{
          minHeight:  { xs: 'auto', md: '92vh' },
          display:    'flex',
          alignItems: 'center',
          position:   'relative',
          overflow:   'hidden',
          px:         { xs: 3, md: 6 },
          pt:         { xs: 8, md: 0 },
          pb:         { xs: 8, md: 0 },
        }}
      >
        {/* Decorative watermark */}
        <Typography
          aria-hidden
          sx={{
            position:   'absolute',
            fontFamily: '"Noto Serif", serif',
            fontSize:   { xs: '5rem', md: '11rem' },
            fontWeight: 700,
            color:      `${tokens.color.primary}09`,
            top:        '50%',
            left:       '-2%',
            transform:  'translateY(-50%)',
            userSelect: 'none',
            lineHeight: 1,
            whiteSpace: 'nowrap',
            pointerEvents: 'none',
          }}
        >
          Ἐν ἀρχῇ ἦν ὁ Λόγος
        </Typography>

        <Box sx={{ maxWidth: 1100, mx: 'auto', width: '100%', position: 'relative', zIndex: 1 }}>
          <Box
            sx={{
              display:        'grid',
              gridTemplateColumns: { xs: '1fr', lg: '1fr 1fr' },
              gap:            { xs: 6, lg: 8 },
              alignItems:     'center',
            }}
          >
            {/* Left: copy */}
            <Box>
              <Box
                sx={{
                  display:      'inline-flex',
                  alignItems:   'center',
                  gap:          1,
                  px:           1.5,
                  py:           0.625,
                  borderRadius: tokens.radius.full,
                  border:       `1px solid ${tokens.color.border}`,
                  bgcolor:      tokens.color.primaryLight,
                  mb:           3,
                  animation:    'fadeInDown 600ms ease both',
                  '@keyframes fadeInDown': {
                    from: { opacity: 0, transform: 'translateY(-10px)' },
                    to:   { opacity: 1, transform: 'translateY(0)' },
                  },
                }}
              >
                <Box sx={{ width: 6, height: 6, borderRadius: '50%', bgcolor: tokens.color.srsGood }} />
                <Typography sx={{ fontSize: '0.75rem', fontWeight: 600, color: tokens.color.primaryDark }}>
                  Free forever · No subscription required
                </Typography>
              </Box>

              <Typography
                component="h1"
                sx={{
                  fontFamily: '"Noto Serif", serif',
                  fontSize:   { xs: '2.5rem', md: '3.5rem', lg: '3.75rem' },
                  fontWeight: 400,
                  lineHeight: 1.15,
                  color:      tokens.color.textPrimary,
                  mb:         2.5,
                  animation:  'fadeInUp 700ms 100ms ease both',
                  '@keyframes fadeInUp': {
                    from: { opacity: 0, transform: 'translateY(20px)' },
                    to:   { opacity: 1, transform: 'translateY(0)' },
                  },
                }}
              >
                Read the Greek New Testament.{' '}
                <Box component="em" sx={{ color: tokens.color.primary, fontStyle: 'normal' }}>
                  Actually.
                </Box>
              </Typography>

              <Typography
                variant="body1"
                sx={{
                  color:      tokens.color.textSecondary,
                  fontSize:   { xs: '1rem', md: '1.125rem' },
                  lineHeight: 1.75,
                  mb:         4,
                  maxWidth:   480,
                  animation:  'fadeInUp 700ms 200ms ease both',
                }}
              >
                An interlinear reader with tap-to-parse, integrated spaced-repetition flashcards, and gamified progress tracking. Every word. Every parsing. No paywall.
              </Typography>

              <Box
                sx={{
                  display:   'flex',
                  gap:       1.5,
                  flexWrap:  'wrap',
                  animation: 'fadeInUp 700ms 300ms ease both',
                }}
              >
                <Button
                  variant="contained"
                  size="large"
                  onClick={() => router.push('/auth/signup')}
                  sx={{
                    bgcolor:  tokens.color.primary,
                    '&:hover': { bgcolor: tokens.color.primaryDark },
                    fontWeight: 700,
                    px:         3.5,
                    py:         1.375,
                    fontSize:   '1rem',
                    borderRadius: tokens.radius.sm,
                    boxShadow:  `0 4px 20px ${tokens.color.primary}44`,
                  }}
                >
                  Start reading free
                </Button>
                <Button
                  variant="outlined"
                  size="large"
                  onClick={() => router.push('/read')}
                  sx={{
                    borderColor: tokens.color.border,
                    color:       tokens.color.textPrimary,
                    fontWeight:  600,
                    px:          3.5,
                    py:          1.375,
                    fontSize:    '1rem',
                    borderRadius: tokens.radius.sm,
                    '&:hover':   { borderColor: tokens.color.primary, color: tokens.color.primary, bgcolor: tokens.color.primaryLight },
                  }}
                >
                  Try without account →
                </Button>
              </Box>

              <Typography
                variant="body2"
                sx={{ color: tokens.color.textMuted, mt: 2, animation: 'fadeInUp 700ms 400ms ease both' }}
              >
                No credit card. No trial period. Just the text.
              </Typography>
            </Box>

            {/* Right: mockup */}
            <Box
              sx={{
                display:    'flex',
                justifyContent: { xs: 'center', lg: 'flex-end' },
                animation:  'fadeInRight 800ms 200ms ease both',
                '@keyframes fadeInRight': {
                  from: { opacity: 0, transform: 'translateX(24px)' },
                  to:   { opacity: 1, transform: 'translateX(0)' },
                },
              }}
            >
              <ReaderMockup />
            </Box>
          </Box>
        </Box>
      </Box>

      {/* ── FEATURES ── */}
      <Box
        sx={{
          bgcolor: tokens.color.surface,
          py:      { xs: 10, md: 14 },
          px:      { xs: 3, md: 6 },
          borderTop: `1px solid ${tokens.color.border}`,
          borderBottom: `1px solid ${tokens.color.border}`,
        }}
      >
        <Box sx={{ maxWidth: 1100, mx: 'auto' }}>
          <Reveal>
            <Typography
              sx={{
                fontFamily: '"Noto Serif", serif',
                fontSize:   { xs: '2rem', md: '2.5rem' },
                color:      tokens.color.textPrimary,
                mb:         1.5,
                textAlign:  'center',
              }}
            >
              Everything you need. Nothing you don't.
            </Typography>
          </Reveal>
          <Reveal delay={100}>
            <Typography
              variant="body1"
              sx={{ color: tokens.color.textSecondary, textAlign: 'center', mb: 6, fontSize: '1.0625rem' }}
            >
              Designed for students, pastors, and scholars who want to engage the original text directly.
            </Typography>
          </Reveal>

          <Box
            sx={{
              display:             'grid',
              gridTemplateColumns: { xs: '1fr', sm: '1fr 1fr', md: '1fr 1fr 1fr' },
              gap:                 3,
            }}
          >
            <FeatureCard
              icon="📖"
              title="Interlinear Reader"
              body="Read the Greek NT with tap-to-parse on every word. Instant access to lexical form, definition, full morphology, and SRS status — no app switching."
              delay={0}
            />
            <FeatureCard
              icon="🎴"
              title="Spaced Repetition"
              body="Words you tap automatically enter your SRS deck. Review cards in the sidebar as you read, or in a dedicated full session. Scientifically proven recall."
              delay={100}
            />
            <FeatureCard
              icon="⭐"
              title="Gamified Progress"
              body="Earn XP for every review and lesson. Track your streak, climb from Novice to Master, and watch your vocabulary grow on the progress dashboard."
              delay={200}
            />
            <FeatureCard
              icon="📚"
              title="Structured Lessons"
              body="Grammar explanations, vocabulary sets, and cultural context — all linked to what you're reading. Learn the article on Monday, read with it on Tuesday."
              delay={0}
            />
            <FeatureCard
              icon="🔍"
              title="Smart Vocabulary Search"
              body="Can't remember how to type Greek? Search by transliteration — type 'logos' and find λόγος instantly. Works across all vocabulary pages."
              delay={100}
            />
            <FeatureCard
              icon="🌐"
              title="Free & Open Forever"
              body="No subscription, no paywall, no premium tier hiding core features. Supported entirely by optional donations from people who find it useful."
              delay={200}
            />
          </Box>
        </Box>
      </Box>

      {/* ── HOW IT WORKS ── */}
      <Box id="how-it-works" sx={{ py: { xs: 10, md: 14 }, px: { xs: 3, md: 6 } }}>
        <Box sx={{ maxWidth: 760, mx: 'auto' }}>
          <Reveal>
            <Typography
              sx={{
                fontFamily: '"Noto Serif", serif',
                fontSize:   { xs: '2rem', md: '2.5rem' },
                color:      tokens.color.textPrimary,
                mb:         1.5,
              }}
            >
              From alphabet to fluency.
            </Typography>
          </Reveal>
          <Reveal delay={100}>
            <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 8, fontSize: '1.0625rem' }}>
              The app is designed around a simple loop that builds real reading ability over time.
            </Typography>
          </Reveal>

          <Box sx={{ display: 'flex', flexDirection: 'column', gap: 5 }}>
            <Step
              n={1}
              title="Open a passage and start reading"
              body="Navigate to any book and chapter. The Greek text is displayed in a clean, generous column. Tap any word to see its parsing, definition, and SRS status in the sidebar."
              delay={0}
            />
            <Box sx={{ ml: 2.75, borderLeft: `2px dashed ${tokens.color.border}`, height: 24 }} />
            <Step
              n={2}
              title="Words enter your deck automatically"
              body="Every word you look up is added to your spaced-repetition deck. The colored underlines show you at a glance which words are new, due for review, or mastered."
              delay={0}
            />
            <Box sx={{ ml: 2.75, borderLeft: `2px dashed ${tokens.color.border}`, height: 24 }} />
            <Step
              n={3}
              title="Review in the sidebar, never leave the text"
              body="When words are due, a 'Begin Review' button appears in the sidebar. Flip cards, rate your recall — Again, Hard, Good, Easy — and the scheduler handles the rest."
              delay={0}
            />
            <Box sx={{ ml: 2.75, borderLeft: `2px dashed ${tokens.color.border}`, height: 24 }} />
            <Step
              n={4}
              title="Watch your mastery grow"
              body="The progress dashboard tracks your streak, XP, and vocabulary growth over time. As you master more words, reading gets faster — a genuinely virtuous cycle."
              delay={0}
            />
          </Box>
        </Box>
      </Box>

      {/* ── MISSION ── */}
      <Box
        sx={{
          bgcolor:    tokens.color.primaryLight,
          borderTop:  `1px solid ${tokens.color.border}`,
          borderBottom:`1px solid ${tokens.color.border}`,
          py:         { xs: 10, md: 14 },
          px:         { xs: 3, md: 6 },
        }}
      >
        <Box
          sx={{
            maxWidth: 1100,
            mx:       'auto',
            display:  'grid',
            gridTemplateColumns: { xs: '1fr', md: '3fr 2fr' },
            gap:      8,
            alignItems: 'center',
          }}
        >
          <Reveal>
            <Box>
              <Typography
                sx={{
                  fontFamily: '"Noto Serif", serif',
                  fontSize:   { xs: '1.875rem', md: '2.25rem' },
                  color:      tokens.color.primaryDark,
                  mb:         2,
                  lineHeight: 1.3,
                }}
              >
                The Greek New Testament should be accessible to everyone who wants to read it.
              </Typography>
              <Typography variant="body1" sx={{ color: tokens.color.textSecondary, lineHeight: 1.8, mb: 2 }}>
                This project exists because language-learning tools for Biblical Greek have historically been expensive, clunky, or locked inside seminary curricula. We built the app we wished existed — free, elegant, and built around the actual experience of reading.
              </Typography>
              <Typography variant="body1" sx={{ color: tokens.color.textSecondary, lineHeight: 1.8 }}>
                Greek text is provided under the SBL Greek New Testament license. The app itself is free to use and sustained by optional donations from people who find it valuable.
              </Typography>
            </Box>
          </Reveal>

          <Reveal delay={150}>
            <Box
              sx={{
                p:            3.5,
                bgcolor:      tokens.color.bg,
                borderRadius: tokens.radius.lg,
                border:       `1px solid ${tokens.color.border}`,
                boxShadow:    '0 4px 16px rgba(107,66,38,0.08)',
                textAlign:    'center',
              }}
            >
              <Typography sx={{ fontSize: '2.5rem', mb: 1.5 }}>☕</Typography>
              <Typography variant="h3" sx={{ mb: 1, color: tokens.color.primaryDark }}>
                Support the project
              </Typography>
              <Typography variant="body2" sx={{ color: tokens.color.textSecondary, mb: 2.5, lineHeight: 1.7 }}>
                If this tool helps your study, consider a one-time or recurring donation. It keeps the servers on and the work continuing.
              </Typography>
              <Button
                variant="outlined"
                fullWidth
                href="/contact#donate"
                sx={{
                  borderColor: tokens.color.primary,
                  color:       tokens.color.primary,
                  fontWeight:  600,
                  borderRadius: tokens.radius.sm,
                  '&:hover':   { bgcolor: tokens.color.primaryLight },
                }}
              >
                Donate (optional)
              </Button>
              <Typography variant="body2" sx={{ color: tokens.color.textMuted, mt: 1.5, fontSize: '0.75rem' }}>
                The app is free whether or not you donate.
              </Typography>
            </Box>
          </Reveal>
        </Box>
      </Box>

      {/* ── FINAL CTA ── */}
      <Box
        sx={{
          py:         { xs: 12, md: 16 },
          px:         { xs: 3, md: 6 },
          textAlign:  'center',
          position:   'relative',
          overflow:   'hidden',
        }}
      >
        {/* Decorative */}
        <Typography
          aria-hidden
          sx={{
            position:   'absolute',
            fontFamily: '"Noto Serif", serif',
            fontSize:   '16rem',
            color:      `${tokens.color.primary}05`,
            top:        '50%',
            left:       '50%',
            transform:  'translate(-50%, -50%)',
            pointerEvents: 'none',
            userSelect: 'none',
            lineHeight: 1,
          }}
        >
          α
        </Typography>

        <Box sx={{ position: 'relative', zIndex: 1, maxWidth: 600, mx: 'auto' }}>
          <Reveal>
            <Typography
              sx={{
                fontFamily: '"Noto Serif", serif',
                fontSize:   { xs: '2.25rem', md: '3rem' },
                color:      tokens.color.textPrimary,
                mb:         2,
                lineHeight: 1.2,
              }}
            >
              Ready to read the original?
            </Typography>
          </Reveal>
          <Reveal delay={100}>
            <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 4, fontSize: '1.0625rem' }}>
              Create a free account and start reading John 1 in the next five minutes.
            </Typography>
          </Reveal>
          <Reveal delay={200}>
            <Box sx={{ display: 'flex', gap: 1.5, justifyContent: 'center', flexWrap: 'wrap' }}>
              <Button
                variant="contained"
                size="large"
                onClick={() => router.push('/auth/signup')}
                sx={{
                  bgcolor:  tokens.color.primary,
                  '&:hover': { bgcolor: tokens.color.primaryDark },
                  fontWeight: 700,
                  px:         4,
                  py:         1.5,
                  fontSize:   '1.0625rem',
                  borderRadius: tokens.radius.sm,
                  boxShadow:  `0 4px 20px ${tokens.color.primary}44`,
                }}
              >
                Create free account
              </Button>
              <Button
                variant="text"
                size="large"
                onClick={() => router.push('/read')}
                sx={{ color: tokens.color.textSecondary, fontWeight: 500, px: 2, py: 1.5 }}
              >
                Try without signing up →
              </Button>
            </Box>
          </Reveal>
        </Box>
      </Box>
    </PublicLayout>
  );
}
