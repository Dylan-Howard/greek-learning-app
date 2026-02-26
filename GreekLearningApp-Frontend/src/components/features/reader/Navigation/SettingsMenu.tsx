'use client';

import {
  ChangeEvent,
  useEffect,
  useState,
} from 'react';
import Link from 'next/link';

import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Divider from '@mui/material/Divider';
import Stack from '@mui/material/Stack';
import TextField from '@mui/material/TextField';
import Typography from '@mui/material/Typography';
import { useTheme } from '@mui/material/styles';
import { SettingsMenuTabSkeleton } from '@/components/features/modules/Skeletons';

import * as AzureTextService from '@/components/features/services/AzureTextService';
import * as AzureUserService from '@/components/features/services/AzureUserService';
import { User } from '@/components/features/services/User';
import { Lesson } from '@/lib/types/domain/lesson';
import { Wordv2 } from '@/lib/types/domain/word';
import { SimpleWordDto } from '@/components/types/api';
import transliterateGreek from '@/components/features/reader/Navigation/Transliterate';
import OptionCheckbox from '@/components/features/reader/Navigation/OptionCheckbox';
import { useReaderContext } from '@/components/features/reader/ReaderPage/ReaderPageContext';
import {
  DEV_USER_CHANGED_EVENT,
  getActiveDevUserId,
  sanitizeDevUserId,
} from '@/components/features/services/devUserSession';

function mapLessons(lessons: Lesson[], user: User | undefined, filter: string) {
  return lessons.filter((lsn: Lesson) => (
    lsn.title.toLowerCase().indexOf(filter.toLowerCase()) !== -1
  )).map((lsn : Lesson) => ({
    id: lsn.lessonId,
    name: lsn.title,
    type: 'Lesson',
    isActive: !!user?.progress.lessons?.find(
      (prg) => prg.lessonId === lsn.lessonId,
    )?.isComplete,
  }));
}

function mapVocabulary(vocabulary: Array<Wordv2 | SimpleWordDto>, user: User | undefined, filter: string) {
  return vocabulary
    .filter((vcb) => (
      filter.toLowerCase() === transliterateGreek(
        vcb.content.substring(0, filter.length),
      ).toLowerCase()
    )).map((vcb) => ({
      id: vcb.rootId,
      name: vcb.content,
      type: 'Word',
      isActive: !!user?.progress.vocabulary?.find(
        (prg) => prg.wordId === vcb.rootId,
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
  const [options, setOptions] = useState([{
    id: 0,
    type: '',
    name: '',
    isActive: false,
  }]);
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
      .then((lessons) => {
        if (lessons) {
          setOptions(mapLessons(lessons, activeUser, filter));
          setLoading({ ...loading, options: false });
        }
      });
  };

  const handleVocabularyFetch = () => {
    if (loading.user) {
      return;
    }

    const activeChapterId = page?.chapterId || 1;
    AzureTextService
      .fetchVocabularyByChapter(activeChapterId)
      .then((vocabulary) => {
        if (vocabulary) {
          setOptions(mapVocabulary(vocabulary, activeUser, filter));
          setLoading({ ...loading, options: false });
        }
      });
  };

  const handleDetailsFetch = () => {
    setOptions([{
      id: 1,
      type: 'Details',
      name: page && page.morphologyId ? `${page.morphologyId}` : '',
      isActive: true,
    }]);
    setLoading({ ...loading, options: false });
  };

  useEffect(() => {
    const loadUser = (id: string) => {
      setLoading({ ...loading, user: true });
      AzureUserService.fetchUser(id).then((usr) => {
        setActiveUser(usr);
        setLoading({ ...loading, user: false });
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
    setLoading({ ...loading, options: true });
    if (title === 'Lessons') {
      handleLessonsFetch();
    }
    if (title === 'Dictionary') {
      handleVocabularyFetch();
    }
    if (title === 'Details') {
      handleDetailsFetch();
    }
  }, [title, filter, activeUser]);

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
      const targetProgressItem = targetProgressList.find((prg) => prg.lessonId === settingId);

      if (!targetProgressItem) {
        targetProgressList.push({ lessonId: settingId, isComplete: e.target.checked });
      } else {
        targetProgressItem.isComplete = e.target.checked;
      }
    } else {
      const targetProgressList = updatedUser.progress.vocabulary;
      const targetProgressItem = targetProgressList.find((prg) => prg.wordId === settingId);

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
      .then((usr) => setEditing({ updatedUser: usr, isEditing: false }));
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
        variant="outlined"
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
