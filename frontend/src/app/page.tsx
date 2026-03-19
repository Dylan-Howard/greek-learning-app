'use client';

import React, { useEffect, useRef, useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import Link from '@mui/material/Link';
import Divider from '@mui/material/Divider';
import { useRouter } from 'next/navigation';
import PublicLayout from '@/components/public/PublicLayout';
import { tokens } from '@/design-system-v2/theme/theme';
import HowItWorksBento from '@/components/public/HowItWorksBento';

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

function Reveal({ children, delay = 0 }: { children: React.ReactNode; delay?: number }) {
  const { ref, visible } = useReveal();
  return (
    <Box
      ref={ref}
      sx={{
        opacity: visible ? 1 : 0,
        transform: visible ? 'translateY(0)' : 'translateY(28px)',
        transition: `opacity 600ms ease ${delay}ms, transform 600ms ease ${delay}ms`,
      }}
    >
      {children}
    </Box>
  );
}

const MOCK_WORDS = [
  { text: 'Ἐν', status: 'mastered', selected: false },
  { text: 'ἀρχῇ', status: 'due', selected: false },
  { text: 'ἦν', status: 'mastered', selected: false },
  { text: 'ὁ', status: 'mastered', selected: false },
  { text: 'Λόγος,', status: 'new', selected: true },
];
const MOCK_VERSE2 = [
  { text: 'καὶ', status: 'mastered', selected: false },
  { text: 'ὁ', status: 'mastered', selected: false },
  { text: 'Λόγος', status: 'new', selected: false },
  { text: 'ἦν', status: 'mastered', selected: false },
  { text: 'πρὸς', status: 'due', selected: false },
  { text: 'τὸν', status: 'mastered', selected: false },
  { text: 'Θεόν.', status: 'new', selected: false },
];

const STATUS_UNDERLINE: Record<string, string> = {
  new: tokens.color.srsNew,
  due: tokens.color.srsAgain,
  mastered: tokens.color.srsEasy,
};

function MockWord({ text, status, selected }: { text: string; status: string; selected: boolean }) {
  return (
    <Box
      component="span"
      sx={{
        fontFamily: '"Noto Serif", serif',
        fontSize: { xs: '1.125rem', md: '1.25rem' },
        lineHeight: 2.0,
        borderBottom: status !== 'default' ? `2px solid ${STATUS_UNDERLINE[status]}` : 'none',
        bgcolor: selected ? `${tokens.color.primaryLight}` : 'transparent',
        px: selected ? 0.25 : 0,
        borderRadius: selected ? tokens.radius.xs : 0,
        cursor: 'default',
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
        border: `1px solid ${tokens.color.border}`,
        boxShadow: '0 20px 60px rgba(107,66,38,0.12), 0 4px 16px rgba(0,0,0,0.06)',
        overflow: 'hidden',
        bgcolor: tokens.color.bg,
        maxWidth: 560,
        width: '100%',
      }}
    >
      <Box sx={{ bgcolor: tokens.color.surface, borderBottom: `1px solid ${tokens.color.border}`, px: 2, py: 1, display: 'flex', alignItems: 'center', gap: 1 }}>
        <Box sx={{ display: 'flex', gap: 0.625 }}>
          {['#FF5F56', '#FFBD2E', '#27C93F'].map((c) => (
            <Box key={c} sx={{ width: 10, height: 10, borderRadius: '50%', bgcolor: c }} />
          ))}
        </Box>
        <Box sx={{ flex: 1, mx: 2, bgcolor: tokens.color.surfaceAlt, borderRadius: tokens.radius.xs, px: 1.5, py: 0.375, fontSize: '0.625rem', color: tokens.color.textMuted, textAlign: 'center' }}>
          gntreader.app/read
        </Box>
      </Box>

      <Box sx={{ display: 'flex', height: { xs: 240, md: 320 } }}>
        <Box sx={{ flex: 1, p: { xs: 2, md: 3 }, overflowY: 'hidden', borderRight: `1px solid ${tokens.color.border}` }}>
          <Box sx={{ display: 'flex', gap: 0.5, mb: 2, justifyContent: 'center' }}>
            <Box sx={{ fontSize: '0.6875rem', color: tokens.color.textMuted, px: 1, py: 0.25, borderRadius: tokens.radius.xs, bgcolor: tokens.color.surfaceAlt }}>John</Box>
            <Box sx={{ fontSize: '0.6875rem', color: tokens.color.textMuted }}>/ Ch. 1</Box>
          </Box>
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

        <Box sx={{ width: { xs: 130, md: 160 }, p: 1.5, display: 'flex', flexDirection: 'column', gap: 0.75, bgcolor: tokens.color.surface }}>
          <Typography sx={{ fontSize: '0.5rem', fontWeight: 700, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em' }}>Word Details</Typography>
          <Typography sx={{ fontFamily: '"Noto Serif", serif', fontSize: { xs: '1rem', md: '1.125rem' }, color: tokens.color.textPrimary }}>λόγος</Typography>
          <Typography sx={{ fontSize: '0.6875rem', fontWeight: 600, color: tokens.color.primary }}>word, reason, account</Typography>
          <Box sx={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: 0.5, mt: 0.25 }}>
            {[['Case', 'Nom.'], ['Number', 'Sg.'], ['Gender', 'Masc.'], ['POS', 'Noun']].map(([l, v]) => (
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

      <Box sx={{ px: 2.5, py: 1.25, bgcolor: tokens.color.surface, borderTop: `1px solid ${tokens.color.border}`, display: 'flex', gap: 2, flexWrap: 'wrap' }}>
        {[
          { color: tokens.color.srsNew, label: 'New' },
          { color: tokens.color.srsAgain, label: 'Due for review' },
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

function FeatureCard({ icon, title, body, delay }: { icon: string; title: string; body: string; delay: number }) {
  return (
    <Reveal delay={delay}>
      <Box
        sx={{
          p: 3,
          borderRadius: tokens.radius.lg,
          border: `1px solid ${tokens.color.border}`,
          bgcolor: tokens.color.bg,
          height: '100%',
          transition: `box-shadow ${tokens.motion.normal}`,
          '&:hover': { boxShadow: '0 8px 32px rgba(107,66,38,0.10)' },
        }}
      >
        <Typography sx={{ fontSize: '2rem', mb: 1.5, lineHeight: 1 }}>{icon}</Typography>
        <Typography variant="h3" sx={{ mb: 1, color: tokens.color.textPrimary }}>{title}</Typography>
        <Typography variant="body2" sx={{ color: tokens.color.textSecondary, lineHeight: 1.7 }}>
          {body}
        </Typography>
      </Box>
    </Reveal>
  );
}

export default function LandingPage() {
  const router = useRouter();

  return (
    <PublicLayout>
      <Box sx={{ bgcolor: tokens.color.bg }}>
        <Box sx={{ px: { xs: 3, md: 6 }, pt: { xs: 8, md: 12 }, pb: { xs: 6, md: 10 } }}>
          <Box sx={{ maxWidth: 1100, mx: 'auto', display: 'grid', gridTemplateColumns: { xs: '1fr', md: '1.1fr 0.9fr' }, gap: { xs: 6, md: 8 }, alignItems: 'center' }}>
            <Box>
              <Reveal>
                <Typography
                  component="h1"
                  sx={{
                    fontFamily: '"Noto Serif", serif',
                    fontSize: { xs: '2.25rem', md: '3.25rem' },
                    lineHeight: 1.2,
                    color: tokens.color.textPrimary,
                    mb: 2,
                  }}
                >
                  Read the Greek New Testament with clarity and momentum.
                </Typography>
              </Reveal>
              <Reveal delay={120}>
                <Typography variant="body1" sx={{ color: tokens.color.textSecondary, maxWidth: 520, mb: 3, lineHeight: 1.8 }}>
                  A focused reading environment, integrated vocabulary, and spaced repetition — all designed to help you keep moving through the text.
                </Typography>
              </Reveal>
              <Reveal delay={200}>
                <Box sx={{ display: 'flex', gap: 1.5, flexWrap: 'wrap' }}>
                  <Button
                    variant="contained"
                    onClick={() => router.push('/reader')}
                    sx={{ bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark }, px: 3, py: 1.2, borderRadius: tokens.radius.sm }}
                  >
                    Start reading
                  </Button>
                  <Button
                    variant="outlined"
                    onClick={() => router.push('/auth/signup')}
                    sx={{ borderColor: tokens.color.border, color: tokens.color.textPrimary, px: 3, py: 1.2, borderRadius: tokens.radius.sm }}
                  >
                    Create account
                  </Button>
                </Box>
              </Reveal>
              <Reveal delay={280}>
                <Box sx={{ mt: 3, display: 'flex', gap: 1.5, alignItems: 'center', flexWrap: 'wrap' }}>
                  <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
                    Free forever · Donation-supported
                  </Typography>
                  <Divider orientation="vertical" flexItem />
                  <Link href="/contact#donate" underline="none" sx={{ fontSize: '0.875rem', color: tokens.color.primary }}>
                    Support the project →
                  </Link>
                </Box>
              </Reveal>
            </Box>

            <Reveal delay={240}>
              <ReaderMockup />
            </Reveal>
          </Box>
        </Box>

        {/* <Box id="how-it-works" sx={{ bgcolor: tokens.color.surface, py: { xs: 8, md: 10 } }}>
          <Box sx={{ maxWidth: 1100, mx: 'auto', px: { xs: 3, md: 6 } }}>
            <Typography variant="h2" sx={{ mb: 1 }}>How it works</Typography>
            <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 4 }}>
              Focus on reading; let the system handle review and retention.
            </Typography>
            <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', md: 'repeat(3, 1fr)' }, gap: 3 }}>
              <FeatureCard icon="📖" title="Read with context" body="Inline parsing, word details, and reference tools right where you need them." delay={0} />
              <FeatureCard icon="🧠" title="Spaced repetition" body="Train vocabulary with adaptive review sessions that fit your time." delay={120} />
              <FeatureCard icon="📈" title="Track progress" body="See growth over time with session stats and mastery tracking." delay={240} />
            </Box>
          </Box>
        </Box> */}

        <HowItWorksBento />

      </Box>
    </PublicLayout>
  );
}
