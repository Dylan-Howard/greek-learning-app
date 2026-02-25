export type OriginalLanguage = 'el-GR' | 'he-IL';

const GREEK_REGEX = /[\u0370-\u03FF\u1F00-\u1FFF]/g;
const HEBREW_REGEX = /[\u0590-\u05FF]/g;

export function normalizeSpeechText(value: string): string {
  return value.replace(/\s+/g, ' ').trim();
}

export function detectOriginalLanguage(text: string): OriginalLanguage {
  const source = normalizeSpeechText(text);
  const greekCount = (source.match(GREEK_REGEX) || []).length;
  const hebrewCount = (source.match(HEBREW_REGEX) || []).length;

  if (hebrewCount > greekCount && hebrewCount > 0) {
    return 'he-IL';
  }

  return 'el-GR';
}

export function isSpeechSynthesisSupported(): boolean {
  return typeof window !== 'undefined'
    && typeof window.speechSynthesis !== 'undefined'
    && typeof window.SpeechSynthesisUtterance !== 'undefined';
}

export function stopSpeech() {
  if (!isSpeechSynthesisSupported()) {
    return;
  }

  window.speechSynthesis.cancel();
}

export function speakText(
  text: string,
  lang: string,
  callbacks?: {
    onStart?: () => void;
    onEnd?: () => void;
    onError?: () => void;
  },
): boolean {
  if (!isSpeechSynthesisSupported()) {
    return false;
  }

  const content = normalizeSpeechText(text);
  if (!content) {
    return false;
  }

  stopSpeech();

  const utterance = new window.SpeechSynthesisUtterance(content);
  utterance.lang = lang;
  utterance.onstart = () => callbacks?.onStart?.();
  utterance.onend = () => callbacks?.onEnd?.();
  utterance.onerror = () => callbacks?.onError?.();

  window.speechSynthesis.speak(utterance);
  return true;
}
