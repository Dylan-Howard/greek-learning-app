'use client';

import { useEffect, useMemo, useState, ReactNode } from 'react';
import { useUser } from '@clerk/nextjs';
import { UserContext } from '../services/User';
import * as UserService from '../services/AzureUserService';

export default function ClientLayout({ children }: { children: ReactNode }) {
  const [activeUser, setActiveUser] = useState(UserService.getDefaultUserState());
  const { isLoaded, isSignedIn, user } = useUser();

  useEffect(() => {
    if (!isLoaded || !isSignedIn || !user) {
      return;
    }

    const userId = user.id;

    UserService.fetchUser(userId)
      .then((usr) => {
        if (usr) {
          setActiveUser(usr);
        }
      });
  }, [isLoaded, isSignedIn, user]);

  const value = useMemo(() => ({ user: activeUser, setUser: setActiveUser }), [activeUser]);

  return (
    <UserContext.Provider value={value}>
      { children }
    </UserContext.Provider>
  );
}
