'use client';
// src/app/lessons/page.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Divider from '@mui/material/Divider';
import Typography from '@mui/material/Typography';
import { useRouter } from 'next/navigation';
import AppShell from '@/components/layouts/AppShell';
import { PageHeader } from '@/components/shared/PageHeader';
import { LessonCard, type LessonMeta } from '@/components/lessons/LessonCard';
import { LessonCardSkeleton } from '@/components/shared/LoadingSkeleton';

const DEMO_LESSONS: LessonMeta[] = [
  { id: 'l01', number: 1,  title: 'The Greek Alphabet',           type: 'Grammar',    readTime: 8,  completed: true  },
  { id: 'l02', number: 2,  title: 'Pronunciation & Breathings',   type: 'Grammar',    readTime: 10, completed: true  },
  { id: 'l03', number: 3,  title: 'The Article',                  type: 'Grammar',    readTime: 12, completed: false },
  { id: 'l04', number: 4,  title: 'Second Declension Nouns',      type: 'Grammar',    readTime: 15, completed: false },
  { id: 'l05', number: 5,  title: 'First Declension Nouns',       type: 'Grammar',    readTime: 12, completed: false },
  { id: 'l06', number: 6,  title: 'High-Frequency Vocabulary',    type: 'Vocabulary', readTime: 6,  completed: false },
  { id: 'l07', number: 7,  title: 'Adjectives',                   type: 'Grammar',    readTime: 14, completed: false },
  { id: 'l08', number: 8,  title: 'The Jewish Context of the NT', type: 'Culture',    readTime: 9,  completed: false },
];

export default function LessonsPage() {
  const router = useRouter();
  const completed = DEMO_LESSONS.filter((l) => l.completed).length;

  return (
    <AppShell>
      <Box sx={{ p: { xs: 3, md: 4 }, maxWidth: 760, mx: 'auto' }}>
        <PageHeader
          title="Lessons"
          subtitle={`${completed} of ${DEMO_LESSONS.length} completed`}
        />
        <Box sx={{ display: 'flex', flexDirection: 'column', gap: 1.25 }}>
          {DEMO_LESSONS.map((lesson, i) => (
            <React.Fragment key={lesson.id}>
              {i > 0 && lesson.type !== DEMO_LESSONS[i - 1].type && (
                <Divider sx={{ my: 0.5 }} />
              )}
              <LessonCard lesson={lesson} onClick={(id) => router.push('/lessons/' + id)} />
            </React.Fragment>
          ))}
        </Box>
      </Box>
    </AppShell>
  );
}
