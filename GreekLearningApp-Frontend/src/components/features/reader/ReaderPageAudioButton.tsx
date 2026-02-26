'use client';

import { useEffect, useMemo, useState } from 'react';
import IconButton from '@mui/material/IconButton';
import Tooltip from '@mui/material/Tooltip';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import StopIcon from '@mui/icons-material/Stop';
import { detectOriginalLanguage, isSpeechSynthesisSupported, speakText, stopSpeech } from '@/components/features/reader/readerTts';

export default function ReaderPageAudioButton({ content }: { content: string }) {
  const [isSupported, setIsSupported] = useState(false);
  const [isSpeaking, setIsSpeaking] = useState(false);
  const [hasError, setHasError] = useState(false);

  const cleanedContent = useMemo(() => content.replace(/\s+/g, ' ').trim(), [content]);

  useEffect(() => {
    setIsSupported(isSpeechSynthesisSupported());
  }, []);

  useEffect(() => () => {
    stopSpeech();
  }, []);

  const handleToggle = () => {
    if (!isSupported || !cleanedContent) {
      return;
    }

    if (isSpeaking) {
      stopSpeech();
      setIsSpeaking(false);
      return;
    }

    const lang = detectOriginalLanguage(cleanedContent);
    const started = speakText(cleanedContent, lang, {
      onStart: () => {
        setHasError(false);
        setIsSpeaking(true);
      },
      onEnd: () => setIsSpeaking(false),
      onError: () => {
        setIsSpeaking(false);
        setHasError(true);
      },
    });

    if (!started) {
      setHasError(true);
    }
  };

  const label = isSpeaking ? 'Stop reading' : 'Read page aloud';

  return (
    <Tooltip title={isSupported ? label : 'Speech not supported in this browser'}>
      <span>
        <IconButton
          aria-label={label}
          onClick={handleToggle}
          disabled={!isSupported || !cleanedContent}
          color={hasError ? 'error' : 'primary'}
        >
          {isSpeaking ? <StopIcon /> : <VolumeUpIcon />}
        </IconButton>
      </span>
    </Tooltip>
  );
}
