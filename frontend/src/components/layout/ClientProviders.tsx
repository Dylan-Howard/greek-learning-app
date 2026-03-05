'use client';

import { useCallback, useEffect, useMemo, useState, ReactNode } from 'react';
import { UserContext } from '@/lib/types/domain/user';
import * as UserService from '@/lib/api/rest/user';
import {
  DEV_USER_CHANGED_EVENT,
  getActiveDevUserId,
  setActiveDevUserId,
  sanitizeDevUserId,
} from '@/lib/services/auth/devSession';

export default function ClientProviders({ children }: { children: ReactNode }) {
  const [activeUser, setActiveUser] = useState(UserService.getDefaultUserState());
  const [expQueue, setExpQueue] = useState<number[]>([]);

  const loadUser = useCallback((id: string) => {
    UserService.fetchUser(id).then((usr) => {
      if (usr) {
        setActiveUser(usr);
      }
    });
  }, []);

  useEffect(() => {
    const initialId = getActiveDevUserId();
    setActiveDevUserId(initialId);
    loadUser(initialId);

    const onDevUserChanged = (evt: Event) => {
      const customEvt = evt as CustomEvent<string>;
      loadUser(sanitizeDevUserId(customEvt.detail));
    };

    window.addEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
    return () => window.removeEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
  }, [loadUser]);

  const value = useMemo(() => ({
    user: activeUser,
    setUser: setActiveUser,
    syncUser: async (userId?: string) => {
      loadUser(userId || getActiveDevUserId());
    },
    awardExp: (xp: number, totalExpFromServer?: number) => {
      if (xp <= 0) {
        if (typeof totalExpFromServer === 'number') {
          setActiveUser((prev) => ({ ...prev, totalExp: totalExpFromServer }));
        }
        return;
      }

      setActiveUser((prev) => ({
        ...prev,
        totalExp: typeof totalExpFromServer === 'number'
          ? totalExpFromServer
          : prev.totalExp + xp,
      }));
      setExpQueue((prev) => [...prev, xp]);
    },
    expQueue,
    consumeExp: () => {
      setExpQueue((prev) => prev.slice(1));
    },
  }), [activeUser, expQueue, loadUser]);

  return (
    <UserContext.Provider value={value}>
      {children}
    </UserContext.Provider>
  );
}
