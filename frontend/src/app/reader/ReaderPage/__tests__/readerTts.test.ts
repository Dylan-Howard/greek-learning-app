import { describe, expect, it } from 'vitest';
import { detectOriginalLanguage, normalizeSpeechText } from '@/lib/services/reader/tts';

describe('readerTts', () => {
  it('normalizes whitespace', () => {
    expect(normalizeSpeechText('  λογος   θεου  ')).toBe('λογος θεου');
  });

  it('detects Greek text as el-GR', () => {
    expect(detectOriginalLanguage('ἐν ἀρχῇ ἦν ὁ λόγος')).toBe('el-GR');
  });

  it('detects Hebrew text as he-IL', () => {
    expect(detectOriginalLanguage('בְּרֵאשִׁית בָּרָא')).toBe('he-IL');
  });

  it('defaults to el-GR when script is unclear', () => {
    expect(detectOriginalLanguage('hello world')).toBe('el-GR');
  });
});
