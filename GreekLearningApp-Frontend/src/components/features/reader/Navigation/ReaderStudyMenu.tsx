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
import { fetchProgress, updateProgress } from '@/lib/api/rest/progress';
import { completeSession, rateCard, startSession } from '@/lib/api/rest/study';
import {
  DEV_USER_CHANGED_EVENT,
  getActiveDevUserId,
  sanitizeDevUserId,
} from '@/lib/services/auth/devSession';
import { Rating, UserProgressDto } from '@/lib/types/api';
import { useUserContext } from '@/lib/types/domain/user';

function applyReaderRatingToProgress(progress: UserProgressDto, vocabId: number, rating: Rating): UserProgressDto {
  const now = new Date().toISOString();
  const current = progress.vocabularyProgress[String(vocabId)] || {
    masteryLevel: 0,
    needsPractice: true,
    lastPracticed: now,
    timesSeen: 0,
  };

  let mastery = current.masteryLevel;
  let needsPractice = current.needsPractice;

  if (rating === 'Again') {
    mastery = Math.max(mastery - 20, 0);
    needsPractice = true;
  } else if (rating === 'Hard') {
    mastery = Math.max(mastery, 70);
    needsPractice = true;
  } else if (rating === 'Good') {
    mastery = Math.max(mastery, 80);
    needsPractice = false;
  } else if (rating === 'Easy') {
    mastery = Math.max(mastery, 90);
    needsPractice = false;
  }

  return {
    ...progress,
    vocabularyProgress: {
      ...progress.vocabularyProgress,
      [String(vocabId)]: {
        masteryLevel: mastery,
        needsPractice,
        lastPracticed: now,
        timesSeen: (current.timesSeen || 0) + 1,
      },
    },
  };
}

export default function ReaderStudyMenu() {
  const { awardExp, syncUser } = useUserContext();
  const { page, setPage } = useReaderContext();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');
  const [devUserId, setDevUserId] = useState('1');

  useEffect(() => {
    setDevUserId(getActiveDevUserId());

    const onDevUserChanged = (evt: Event) => {
      const customEvt = evt as CustomEvent<string>;
      setDevUserId(sanitizeDevUserId(customEvt.detail));
    };

    window.addEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
    return () => window.removeEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
  }, []);

  const amberQueue = useMemo(() => {
    const seen = new Set<number>();
    const queue: number[] = [];
    (page?.chapterUnits || []).forEach((unit) => {
      if (unit.type !== 'original_practice') {
        return;
      }
      if (!unit.morphologyId || seen.has(unit.morphologyId)) {
        return;
      }
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
    if (page?.tabId !== 4) {
      return;
    }

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

    startSession({
      // Use -1 to indicate "all selected cards" and avoid API max-card validation (<=100).
      cardCount: -1,
      pool: 'Mixed',
      direction: 'GreekToEnglish',
      mode: 'Flip',
      source: 'ReaderMini',
      vocabularyIds: amberQueue,
    }, devUserId).then((result) => {
      if (cancelled) {
        return;
      }

      if (!result.ok) {
        setError(result.error.message || 'Unable to start study session.');
        return;
      }

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
          sessionId: result.data.id,
          ratedStates: {},
          completed: false,
          completionXpApplied: false,
        },
      });
    }).finally(() => {
      if (!cancelled) {
        setLoading(false);
      }
    });

    return () => { cancelled = true; };
  }, [page?.tabId, page?.bookId, page?.chapterId, page?.studyFocusWordId, devUserId, queueKey]);

  const handleRate = async (rating: Rating) => {
    if (!activeStudy?.sessionId || !currentWordId) {
      return;
    }

    setLoading(true);
    setError('');
    const ratingResult = await rateCard(activeStudy.sessionId, currentWordId, { rating }, devUserId);
    if (!ratingResult.ok) {
      setError(ratingResult.error.message || 'Unable to rate card.');
      setLoading(false);
      return;
    }

    try {
      const progress = await fetchProgress(devUserId);
      const updated = applyReaderRatingToProgress(progress, currentWordId, rating);
      await updateProgress(devUserId, updated);
    } catch {
      setError('Rating saved, but progress sync failed.');
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
    if (!activeStudy?.completed || !activeStudy.sessionId || activeStudy.completionXpApplied) {
      return;
    }

    let cancelled = false;
    completeSession(activeStudy.sessionId, devUserId).then(async (result) => {
      if (cancelled || !result.ok) {
        return;
      }

      awardExp(result.data.xpGained, result.data.totalExperience);
      await syncUser(devUserId);

      setPage({
        ...page,
        study: {
          ...activeStudy,
          completionXpApplied: true,
        },
      });
    });

    return () => {
      cancelled = true;
    };
  }, [
    activeStudy?.completed,
    activeStudy?.sessionId,
    activeStudy?.completionXpApplied,
    awardExp,
    devUserId,
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
        {currentWordId ? (page.chapterUnits || []).find((x) => x.morphologyId === currentWordId)?.original
          || (page.chapterUnits || []).find((x) => x.morphologyId === currentWordId)?.content
          || '' : ''}
      </Typography>
      <RatingButtons onRate={handleRate} disabled={loading} />
    </Box>
  );
}
