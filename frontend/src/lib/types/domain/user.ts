/**
 * User class
 */
import { createContext, useContext } from 'react';

/** Knowledge level selected during onboarding — seeds the user's SRS deck. */
export type KnowledgeRank = 'beginner' | 'intermediate' | 'scholar' | 'advanced';

export type UserProgress = {
  lessons: {
    lessonId: number,
    isComplete: boolean,
  }[],
  vocabulary: {
    wordId: number,
    isComplete: boolean,
  }[],
};

export interface UserSettings {
  prefersDarkMode: boolean,
  translation: string,
}

export type User = {
  id: string,
  name: string,
  totalExp: number,
  progress: UserProgress,
  settings: UserSettings,
};

export interface UserContextValue {
  user: User | undefined;
  setUser: (user: User) => void;
  syncUser: (userId?: string) => Promise<void>;
  awardExp: (xp: number, totalExpFromServer?: number) => void;
  expQueue: number[];
  consumeExp: () => void;
}

export const UserContext = createContext<UserContextValue>({
  user: undefined,
  setUser: () => {},
  syncUser: async () => {},
  awardExp: () => {},
  expQueue: [],
  consumeExp: () => {},
});

export function useUserContext() {
  const context = useContext(UserContext);
  if (context === undefined) {
    throw new Error('useTodoContext must be within TodoProvider');
  }

  return context;
}
