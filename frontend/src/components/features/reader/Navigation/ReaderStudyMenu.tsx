'use client';

import { useEffect, useMemo, useState } from 'react';
import Box from '@mui/material/Box';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';
import AutoAwesomeIcon from '@mui/icons-material/AutoAwesome';
import SchoolIcon from '@mui/icons-material/School';
import {
  ReaderRatedWordState,
  useReaderContext,
} from '@/app/reader/ReaderPage/ReaderPageContext';
import RatingButtons from '@/components/features/study/RatingButtons';
import {
  useCompleteStudySessionMutation,
  useGetUserProgressQuery,
  useRateCardMutation,
  useStartStudySessionMutation,
  useUpdateProgressMutation,
} from '@/lib/api/graphql/generated';
import { Rating } from '@/lib/types/api';
import { useUserContext } from '@/lib/types/domain/user';

/** Maps the string Rating type to the integer value expected by the GraphQL API. */
const RATING_TO_INT: Record<Rating, number> = {
  Again: 1,
  Hard: 2,
  Good: 3,
  Easy: 4,
};


export function ReaderStudyMenu() {
  const { awardExp, syncUser } = useUserContext();
  const { page, setPage } = useReaderContext();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');

  const [startStudySession] = useStartStudySessionMutation();
  const [rateCardMutation] = useRateCardMutation();
  const [completeStudySession] = useCompleteStudySessionMutation();
  const [updateProgressMutation] = useUpdateProgressMutation();
  const { data: progressData, error: progressError } = useGetUserProgressQuery();

  const amberQueue = useMemo(() => {
    const seen = new Set<number>();
    const queue: number[] = [];
    (page?.chapterUnits || []).forEach((unit) => {
      if (unit.type !== 'original_practice') return;
      if (!unit.morphologyId || seen.has(unit.morphologyId)) return;
      seen.add(unit.morphologyId);
      queue.push(unit.morphologyId);
    });
    return queue;
  }, [page?.chapterUnits]);

  const queueKey = amberQueue.join(',');
  const activeStudy = page?.study;
  const currentWordId = activeStudy?.currentWordId;
  const currentDisplayIndex = (activeStudy?.currentIndex || 0) + 1;

  useEffect(() => {
    if (page?.tabId !== 4) return;

    const currentQueueKey = (activeStudy?.queueWordIds || []).join(',');
    if (currentQueueKey === queueKey && activeStudy?.sessionId) {
      if (page.studyFocusWordId && amberQueue.includes(page.studyFocusWordId)) {
        const currentIndex = amberQueue.findIndex((id) => id === page.studyFocusWordId);
        setPage({
          ...page,
          study: {
            ...activeStudy,
            currentWordId: page.studyFocusWordId,
            currentIndex: currentIndex >= 0 ? currentIndex : 0,
          },
        });
      }
      return;
    }

    if (amberQueue.length === 0) {
      setPage({
        ...page,
        study: {
          queueWordIds: [],
          currentIndex: 0,
          ratedStates: {},
          completed: true,
          completionXpApplied: false,
        },
      });
      return;
    }

    let cancelled = false;
    setLoading(true);
    setError('');

    startStudySession({
      variables: {
        input: {
          // Use -1 to indicate "all selected cards" and avoid API max-card validation (<=100).
          cardCount: -1,
          pool: 'Mixed',
          direction: 'GreekToEnglish',
          mode: 'Flip',
          source: 'ReaderMini',
          vocabularyIds: amberQueue,
        },
      },
    }).then((result) => {
      if (cancelled) return;

      if (result.errors || !result.data?.startStudySession) {
        setError(result.errors?.[0]?.message || 'Unable to start study session.');
        return;
      }

      const session = result.data.startStudySession;
      const focusId = page.studyFocusWordId && amberQueue.includes(page.studyFocusWordId)
        ? page.studyFocusWordId
        : amberQueue[0];
      const currentIndex = amberQueue.findIndex((id) => id === focusId);

      setPage({
        ...page,
        study: {
          queueWordIds: amberQueue,
          currentWordId: focusId,
          currentIndex: currentIndex >= 0 ? currentIndex : 0,
          sessionId: session.id,
          ratedStates: {},
          completed: false,
          completionXpApplied: false,
        },
      });
    }).finally(() => {
      if (!cancelled) setLoading(false);
    });

    return () => { cancelled = true; };
  }, [page?.tabId, page?.bookId, page?.chapterId, page?.studyFocusWordId, queueKey]);

  const handleRate = async (rating: Rating) => {
    if (!activeStudy?.sessionId || !currentWordId) return;

    setLoading(true);
    setError('');
    const ratingResult = await rateCardMutation({
      variables: {
        sessionId: activeStudy.sessionId,
        vocabularyId: currentWordId,
        rating: RATING_TO_INT[rating],
      },
    });
    if (ratingResult.errors || !ratingResult.data?.rateCard) {
      setError(ratingResult.errors?.[0]?.message || 'Unable to rate card.');
      setLoading(false);
      return;
    }

    // Sync overall progress record via GraphQL after rating a card.
    // The card's SRS state is already updated server-side by rateCardMutation;
    // here we persist the latest completedLessonIds and totalExperience snapshot.
    if (progressError) {
      setError('Rating saved, but progress sync failed.');
    } else if (progressData?.progress) {
      const { completedLessonIds, totalExperience } = progressData.progress;
      const updateResult = await updateProgressMutation({
        variables: {
          input: { completedLessonIds, totalExperience },
        },
      });
      if (updateResult.errors) {
        setError('Rating saved, but progress sync failed.');
      }
    }

    const nextRatedState: ReaderRatedWordState = rating === 'Again' ? 'rejected' : 'accepted';
    const ratedStates: Record<number, ReaderRatedWordState> = {
      ...(activeStudy.ratedStates || {}),
      [currentWordId]: nextRatedState,
    };
    const nextIndex = Math.min(activeStudy.currentIndex + 1, activeStudy.queueWordIds.length);
    const completed = nextIndex >= activeStudy.queueWordIds.length;
    const nextWordId = completed ? undefined : activeStudy.queueWordIds[nextIndex];

    setPage({
      ...page,
      study: {
        ...activeStudy,
        ratedStates,
        currentIndex: completed ? activeStudy.currentIndex : nextIndex,
        currentWordId: nextWordId,
        completed,
        completionXpApplied: completed ? activeStudy.completionXpApplied : false,
      },
    });

    setLoading(false);
  };

  useEffect(() => {
    if (!activeStudy?.completed || !activeStudy.sessionId || activeStudy.completionXpApplied) return;

    let cancelled = false;
    completeStudySession({ variables: { sessionId: activeStudy.sessionId } }).then(async (result) => {
      if (cancelled || result.errors || !result.data?.completeStudySession) return;

      const summary = result.data.completeStudySession;
      awardExp(summary.xpGained, summary.totalExperience);
      await syncUser();

      setPage({
        ...page,
        study: {
          ...activeStudy,
          completionXpApplied: true,
        },
      });
    });

    return () => { cancelled = true; };
  }, [
    activeStudy?.completed,
    activeStudy?.sessionId,
    activeStudy?.completionXpApplied,
    awardExp,
    page,
    setPage,
    syncUser,
  ]);

  if (loading && !activeStudy?.sessionId) {
    return (
      <Box sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, pr: 1 }}>
        <Typography variant="h2" sx={{ fontSize: 48, mb: 2 }}>Study</Typography>
        <Typography>Preparing your chapter session...</Typography>
      </Box>
    );
  }

  if (error) {
    return (
      <Box sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, pr: 1 }}>
        <Typography variant="h2" sx={{ fontSize: 48, mb: 2 }}>Study</Typography>
        <Typography color="error.main">{error}</Typography>
      </Box>
    );
  }

  if (!activeStudy || activeStudy.queueWordIds.length === 0) {
    return (
      <Stack
        spacing={2}
        alignItems="center"
        justifyContent="center"
        sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, textAlign: 'center', pr: 1 }}
      >
        <SchoolIcon sx={{ fontSize: 64, color: 'text.secondary' }} />
        <Typography variant="h2" sx={{ fontSize: 42 }}>Study</Typography>
        <Typography color="text.secondary">No amber words here yet. Keep reading and you will build a review set.</Typography>
      </Stack>
    );
  }

  if (activeStudy.completed) {
    return (
      <Stack
        spacing={2}
        alignItems="center"
        justifyContent="center"
        sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, textAlign: 'center', pr: 1 }}
      >
        <AutoAwesomeIcon sx={{ fontSize: 64, color: 'success.main' }} />
        <Typography variant="h2" sx={{ fontSize: 42 }}>Great work</Typography>
        <Typography color="text.secondary">You reviewed every amber word on this page.</Typography>
      </Stack>
    );
  }

  return (
    <Box sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, pr: 1 }}>
      <Typography variant="h2" sx={{ fontSize: 48, mb: 2 }}>Study</Typography>
      <Typography sx={{ mb: 2, color: 'text.secondary' }}>
        {`Word ${currentDisplayIndex} of ${activeStudy.queueWordIds.length}`}
      </Typography>
      <Typography
        variant="h3"
        sx={{ mb: 3, fontFamily: '"Noto Serif", serif' }}
      >
        {currentWordId
          ? (page.chapterUnits || []).find((x) => x.morphologyId === currentWordId)?.original
            || (page.chapterUnits || []).find((x) => x.morphologyId === currentWordId)?.content
            || ''
          : ''}
      </Typography>
      <RatingButtons onRate={handleRate} disabled={loading} />
    </Box>
  );
}
