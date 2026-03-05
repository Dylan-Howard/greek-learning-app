'use client';

import { useEffect, useMemo, useState } from 'react';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import StopIcon from '@mui/icons-material/Stop';
import { detectOriginalLanguage, isSpeechSynthesisSupported, speakText, stopSpeech } from '@/lib/services/reader/tts';
import { IconButton } from '@/components/shared';

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
    <span>
      <IconButton
        aria-label={label}
        tooltip={isSupported ? label : 'Speech not supported in this browser'}
        onClick={handleToggle}
        disabled={!isSupported || !cleanedContent}
        color={hasError ? 'error' : 'primary'}
      >
        {isSpeaking ? <StopIcon /> : <VolumeUpIcon />}
      </IconButton>
    </span>
  );
}
