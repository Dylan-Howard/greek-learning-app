'use client';

import { useEffect, useMemo, useState, ReactNode } from 'react';
import { UserContext } from '@/lib/types/domain/user';
import * as UserService from '@/lib/api/rest/user';
import {
  DEV_USER_CHANGED_EVENT,
  getActiveDevUserId,
  setActiveDevUserId,
  sanitizeDevUserId,
} from '@/lib/services/auth/devSession';

export default function ClientLayout({ children }: { children: ReactNode }) {
  const [activeUser, setActiveUser] = useState(UserService.getDefaultUserState());

  useEffect(() => {
    const loadUser = (id: string) => {
      UserService.fetchUser(id).then((usr) => {
        if (usr) {
          setActiveUser(usr);
        }
      });
    };

    const initialId = getActiveDevUserId();
    setActiveDevUserId(initialId);
    loadUser(initialId);

    const onDevUserChanged = (evt: Event) => {
      const customEvt = evt as CustomEvent<string>;
      loadUser(sanitizeDevUserId(customEvt.detail));
    };

    window.addEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
    return () => window.removeEventListener(DEV_USER_CHANGED_EVENT, onDevUserChanged);
  }, []);

  const value = useMemo(() => ({ user: activeUser, setUser: setActiveUser }), [activeUser]);

  return (
    <UserContext.Provider value={value}>
      { children }
    </UserContext.Provider>
  );
}
