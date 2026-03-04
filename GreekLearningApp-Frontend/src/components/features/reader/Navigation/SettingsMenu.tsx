'use client';

import {
  ChangeEvent,
  useMemo,
  useEffect,
  useState,
} from 'react';
import Link from 'next/link';

import Box from '@mui/material/Box';
import Divider from '@mui/material/Divider';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';
import { useTheme } from '@mui/material/styles';
import { SettingsMenuTabSkeleton } from '@/components/shared/Skeletons';

import * as AzureTextService from '@/lib/api/rest/text';
import * as AzureUserService from '@/lib/api/rest/user';
import { User } from '@/lib/types/domain/user';
import { Lesson } from '@/lib/types/domain/lesson';
import { Wordv2 } from '@/lib/types/domain/word';
import { SimpleWordDto } from '@/lib/types/api';
import transliterateGreek from '@/lib/services/reader/transliteration';
import OptionCheckbox from '@/components/features/reader/Navigation/OptionCheckbox';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';
import { Button, TextField } from '@/components/ui';
import {
  DEV_USER_CHANGED_EVENT,
  getActiveDevUserId,
  sanitizeDevUserId,
} from '@/lib/services/auth/devSession';

function mapLessons(lessons: Lesson[], user: User | undefined, filter: string) {
  return lessons.filter((lsn: Lesson) => (
    lsn.title.toLowerCase().indexOf(filter.toLowerCase()) !== -1
  )).map((lsn : Lesson) => ({
    id: lsn.lessonId,
    name: lsn.title,
    type: 'Lesson',
    isActive: !!user?.progress.lessons?.find(
      (prg: { lessonId: number }) => prg.lessonId === lsn.lessonId,
    )?.isComplete,
  }));
}

function mapVocabulary(vocabulary: Array<Wordv2 | SimpleWordDto>, user: User | undefined, filter: string) {
  const normalizedFilter = filter.trim().toLowerCase();
  return vocabulary
    .filter((vcb) => (
      normalizedFilter.length === 0
      || transliterateGreek(vcb.content).toLowerCase().startsWith(normalizedFilter)
    )).map((vcb) => ({
      id: vcb.rootId,
      name: vcb.content,
      type: 'Word',
      isActive: !!user?.progress.vocabulary?.find(
        (prg: { wordId: number }) => prg.wordId === vcb.rootId,
      )?.isComplete,
    }));
}

function SettingsLink({ resource }: { resource: string }) {
  return (
    <Link href={`/${resource}`}>
      <Button sx={{ textTransform: 'none', mb: 2 }}>
        {`See all ${resource}`}
      </Button>
    </Link>
  );
}

function SettingsMenu({ title } : { title: string }) {
  const { page } = useReaderContext();
  const [activeUser, setActiveUser] = useState(AzureUserService.getDefaultUserState());

  const [filter, setFilter] = useState('');
  const [lessonOptions, setLessonOptions] = useState<Lesson[]>([]);
  const [vocabularyOptions, setVocabularyOptions] = useState<SimpleWordDto[]>([]);
  const [loading, setLoading] = useState({
    user: true,
    options: true,
  });
  const [editing, setEditing] = useState({
    updatedUser: activeUser,
    isEditing: false,
  });
  const theme = useTheme();

  let resource;
  if (title === 'Dictionary') {
    resource = 'vocabulary';
  }
  if (title === 'Lessons') {
    resource = 'lessons';
  }

  const handleLessonsFetch = () => {
    if (loading.user) {
      return;
    }

    AzureTextService
      .fetchLessons()
      .then((lessons: Lesson[]) => {
        setLessonOptions(lessons || []);
      })
      .finally(() => {
        setLoading((prev) => ({ ...prev, options: false }));
      });
  };

  const handleVocabularyFetch = () => {
    if (loading.user) {
      return;
    }

    const activeBookId = page?.bookId || 1;
    const activeChapterNumber = page?.chapterId || 1;

    AzureTextService
      .fetchChaptersByText(activeBookId)
      .then((chapters) => {
        const matchedChapter = chapters.find((ch) => ch.chapterNumber === activeChapterNumber);
        const activeChapterId = matchedChapter?.chapterId ?? activeChapterNumber;
        return AzureTextService.fetchVocabularyByChapter(activeChapterId);
      })
      .then((vocabulary: SimpleWordDto[]) => {
        setVocabularyOptions(vocabulary || []);
      })
      .finally(() => {
        setLoading((prev) => ({ ...prev, options: false }));
      });
  };

  const handleDetailsFetch = () => {
    setLoading((prev) => ({ ...prev, options: false }));
  };

  useEffect(() => {
    const loadUser = (id: string) => {
      setLoading((prev) => ({ ...prev, user: true }));
      AzureUserService.fetchUser(id).then((usr: User) => {
        setActiveUser(usr);
        setLoading((prev) => ({ ...prev, user: false }));
      });
    };

    loadUser(getActiveDevUserId());

    const onDevUserChanged = (evt: Event) => {
      const customEvt = evt as CustomEvent<string>;
      loadUser(sanitizeDevUserId(customEvt.detail));
    };

    window.addEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
    return () => window.removeEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
  }, []);

  /* Loads the settings */
  useEffect(() => {
    setLoading((prev) => ({ ...prev, options: true }));
    if (title === 'Lessons') {
      handleLessonsFetch();
    }
    if (title === 'Dictionary') {
      handleVocabularyFetch();
    }
    if (title === 'Details') {
      handleDetailsFetch();
    }
  }, [title, activeUser.id, page?.bookId, page?.chapterId]);

  const options = useMemo(() => {
    if (title === 'Lessons') {
      return mapLessons(lessonOptions, activeUser, filter);
    }
    if (title === 'Dictionary') {
      return mapVocabulary(vocabularyOptions, activeUser, filter);
    }
    if (title === 'Details') {
      return [{
        id: 1,
        type: 'Details',
        name: page && page.morphologyId ? `${page.morphologyId}` : '',
        isActive: true,
      }];
    }
    return [];
  }, [title, lessonOptions, vocabularyOptions, activeUser, filter, page?.morphologyId]);

  const handleTextboxChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    setFilter(e.target.value);
  };

  const handleCheckboxChange = (
    e: ChangeEvent<HTMLInputElement>,
    settingId: number,
    settingType: string,
  ) => {
    /* Guards if no active user is set */
    if (!activeUser || activeUser.id === 'guest') { return; }

    if (!editing.isEditing) {
      setEditing({
        updatedUser: activeUser,
        isEditing: true,
      });
    }

    const updatedUser = {
      id: activeUser.id,
      name: activeUser.name,
      totalExp: activeUser.totalExp,
      progress: {
        ...activeUser.progress,
      },
      settings: {
        ...activeUser.settings,
      },
    };

    /* Guards from non-existant settings */
    if (settingType !== 'Lesson' && settingType !== 'Word') {
      return;
    }
    /* Handles each type by adding or updating entry */
    if (settingType === 'Lesson') {
      const targetProgressList = updatedUser.progress.lessons;
      const targetProgressItem = targetProgressList.find((prg: { lessonId: number }) => prg.lessonId === settingId);

      if (!targetProgressItem) {
        targetProgressList.push({ lessonId: settingId, isComplete: e.target.checked });
      } else {
        targetProgressItem.isComplete = e.target.checked;
      }
    } else {
      const targetProgressList = updatedUser.progress.vocabulary;
      const targetProgressItem = targetProgressList.find((prg: { wordId: number }) => prg.wordId === settingId);

      if (!targetProgressItem) {
        targetProgressList.push({ wordId: settingId, isComplete: e.target.checked });
      } else {
        targetProgressItem.isComplete = e.target.checked;
      }
    }
    setEditing({ updatedUser, isEditing: true });
  };

  const handleUserSaveCancel = () => {
    if (!editing.isEditing) {
      setActiveUser({ ...activeUser });
      return;
    }

    setEditing({ updatedUser: activeUser, isEditing: false });
  };

  const handleUserSave = () => {
    if (!editing.isEditing) {
      return;
    }

    AzureUserService.updateUser(activeUser)
      .then((usr: User) => setEditing({ updatedUser: usr, isEditing: false }));
  };

  if (loading.user || loading.options) {
    return (
      <Box sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, pr: 1 }}>
        <Typography variant="h2" color={theme.palette.text.primary} sx={{ fontSize: 48, mb: 2 }}>
          {title || ''}
        </Typography>
        { resource ? <SettingsLink resource={resource} /> : ''}
        <SettingsMenuTabSkeleton />
      </Box>
    );
  }

  return (
    <Box sx={{ height: { xs: 500, sm: 'calc(100vh - 72px)' }, pr: 1 }}>
      <Typography variant="h2" color={theme.palette.text.primary} sx={{ fontSize: 48, mb: 2 }}>
        {title || ''}
      </Typography>
      { resource ? <SettingsLink resource={resource} /> : ''}
      <TextField
        label="Search"
        type="search"
        value={filter}
        onChange={(e) => handleTextboxChange(e)}
        size="small"
        sx={{ bgcolor: 'background.default', mb: 2 }}
      />
      <Divider sx={{ mb: 2 }} />
      <Stack sx={{ height: editing.isEditing ? 'calc(100% - 260px)' : 'calc(100% - 200px)', overflowY: 'scroll' }}>
        {
          options.length !== 0
            ? options.map(({
              id,
              type,
              name,
              isActive,
            }) => (
              <OptionCheckbox
                id={`option-${type}-${id}`}
                key={`option-${type}-${id}`}
                name={name}
                value={isActive}
                onCheck={(e) => handleCheckboxChange(e, id, type)}
              />
            ))
            : <Typography variant="body1">No options match this search filter</Typography>
          }
      </Stack>
      {
        editing.isEditing
          ? (
            <Stack direction="row" justifyContent="space-around" sx={{ pt: 1 }}>
              <Button variant="outlined" onClick={handleUserSaveCancel}>Cancel</Button>
              <Button variant="contained" onClick={handleUserSave}>Save</Button>
            </Stack>
          )
          : ''
      }
    </Box>
  );
}

export default SettingsMenu;
