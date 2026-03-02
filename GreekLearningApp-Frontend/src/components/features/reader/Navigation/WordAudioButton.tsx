'use client';

import { useEffect, useMemo, useState } from 'react';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import StopIcon from '@mui/icons-material/Stop';
import { detectOriginalLanguage, isSpeechSynthesisSupported, speakText, stopSpeech } from '@/lib/services/reader/tts';
import { IconButton } from '@/components/ui';

export default function WordAudioButton({ word }: { word: string }) {
  const [isSupported, setIsSupported] = useState(false);
  const [isSpeaking, setIsSpeaking] = useState(false);

  const cleanedWord = useMemo(() => word.replace(/\s+/g, ' ').trim(), [word]);

  useEffect(() => {
    setIsSupported(isSpeechSynthesisSupported());
  }, []);

  useEffect(() => () => {
    stopSpeech();
  }, []);

  const handleToggle = () => {
    if (!isSupported || !cleanedWord) {
      return;
    }

    if (isSpeaking) {
      stopSpeech();
      setIsSpeaking(false);
      return;
    }

    const lang = detectOriginalLanguage(cleanedWord);
    speakText(cleanedWord, lang, {
      onStart: () => setIsSpeaking(true),
      onEnd: () => setIsSpeaking(false),
      onError: () => setIsSpeaking(false),
    });
  };

  const label = isSpeaking ? 'Stop word audio' : 'Play word audio';

  return (
    <span>
      <IconButton
        aria-label={label}
        tooltip={isSupported ? label : 'Speech not supported in this browser'}
        onClick={handleToggle}
        disabled={!isSupported || !cleanedWord}
        color="primary"
        size="large"
      >
        {isSpeaking ? <StopIcon /> : <VolumeUpIcon />}
      </IconButton>
    </span>
  );
}
