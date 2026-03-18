'use client';
// src/app/lessons/[lessonId]/page.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Chip from '@mui/material/Chip';
import Divider from '@mui/material/Divider';
import { useParams, useRouter } from 'next/navigation';
import AppShell from '@/design-system-v2/components/layouts/AppShell';
import {
  TextBlock,
  ImageBlock,
  ConfirmCheckbox,
  MultipleChoice,
} from '@/design-system-v2/components/lessons/LessonBlocks';
import LessonCompletionBanner from '@/design-system-v2/components/lessons/LessonCompletionBanner';
import { tokens } from '@/design-system-v2/theme/theme';

// Demo lesson content — replace with CMS/API data
const DEMO_LESSON = {
  id:       'l03',
  number:   3,
  title:    'The Article in Greek',
  type:     'Grammar',
  readTime: 12,
  xpReward: 50,
  blocks: [
    { type: 'text' as const,    id: 'b1', content: 'Greek has a definite article (like English "the") but no indefinite article (no equivalent of "a" or "an"). The article agrees with its noun in gender, number, and case — a concept called concord.' },
    { type: 'text' as const,    id: 'b2', content: 'The masculine nominative singular form is <span class="greek">ὁ</span>, the feminine is <span class="greek">ἡ</span>, and the neuter is <span class="greek">τό</span>. You will encounter these constantly in the NT.' },
    { type: 'confirm' as const, id: 'c1', label: 'I understand that the Greek article must agree with its noun in gender, number, and case.' },
    { type: 'text' as const,    id: 'b3', content: 'The absence of an article (called anarthrous usage) can be significant. In John 1:1, <span class="greek">θεὸς ἦν ὁ λόγος</span> — the predicate nominative <span class="greek">θεός</span> lacks the article, which carries theological weight in translation debates.' },
    { type: 'confirm' as const, id: 'c2', label: 'I understand the significance of anarthrous usage in Greek.' },
    { type: 'mc' as const,      id: 'q1', question: 'What is the masculine nominative singular form of the Greek article?', options: [{ id: 'a', text: 'ἡ' }, { id: 'b', text: 'ὁ' }, { id: 'c', text: 'τό' }, { id: 'd', text: 'τῷ' }], correctId: 'b' },
  ],
  nextLessonId:    'l04',
  nextLessonTitle: 'Second Declension Nouns',
};

export default function LessonDetailPage() {
  const params = useParams();
  const router = useRouter();

  const [checks, setChecks] = useState<Record<string, boolean>>({});

  const confirmIds  = DEMO_LESSON.blocks.filter((b) => b.type === 'confirm').map((b) => b.id);
  const allComplete = confirmIds.every((id) => checks[id]);

  function handleCheck(id: string, checked: boolean) {
    setChecks((prev) => ({ ...prev, [id]: checked }));
  }

  return (
    <AppShell>
      <Box sx={{ p: { xs: 3, md: 4 }, maxWidth: 720, mx: 'auto' }}>
        {/* Header */}
        <Box sx={{ mb: 3 }}>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1, mb: 1 }}>
            <Chip
              label={DEMO_LESSON.type}
              size="small"
              sx={{ bgcolor: tokens.color.primaryLight, color: tokens.color.primaryDark, fontWeight: 600, fontSize: '0.6875rem' }}
            />
            <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
              Lesson {DEMO_LESSON.number} &middot; {DEMO_LESSON.readTime} min read
            </Typography>
          </Box>
          <Typography variant="h1">{DEMO_LESSON.title}</Typography>
          <Divider sx={{ mt: 2 }} />
        </Box>

        {/* Content blocks */}
        {DEMO_LESSON.blocks.map((block) => {
          if (block.type === 'text')    return <TextBlock key={block.id} content={block.content!} />;
          if (block.type === 'confirm') return <ConfirmCheckbox key={block.id} id={block.id} label={block.label} checked={!!checks[block.id]} onChange={handleCheck} />;
          if (block.type === 'mc')     return <MultipleChoice key={block.id} id={block.id} question={block.question!} options={block.options!} correctId={block.correctId!} />;
          return null;
        })}

        {/* Completion banner */}
        {allComplete && (
          <LessonCompletionBanner
            xpEarned={DEMO_LESSON.xpReward}
            nextLessonId={DEMO_LESSON.nextLessonId}
            nextLessonTitle={DEMO_LESSON.nextLessonTitle}
            onNextLesson={(id) => router.push('/lessons/' + id)}
          />
        )}
      </Box>
    </AppShell>
  );
}
