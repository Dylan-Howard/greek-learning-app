'use client';

import { useCallback, useEffect, useMemo, useState, ReactNode } from 'react';
import { useUser } from '@clerk/nextjs';
import { UserContext } from '@/lib/types/domain/user';
import * as UserService from '@/lib/api/rest/user';
import { ApolloClientProvider } from '@/components/layout/ApolloClientProvider';

export default function ClientProviders({ children }: { children: ReactNode }) {
  const { isLoaded, isSignedIn, user } = useUser();
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
    if (!isLoaded) return;
    if (!isSignedIn || !user) {
      setActiveUser(UserService.getDefaultUserState());
      return;
    }
    loadUser(user.id);
  }, [isLoaded, isSignedIn, user, loadUser]);

  const value = useMemo(() => ({
    user: activeUser,
    setUser: setActiveUser,
    syncUser: async (userId?: string) => {
      loadUser(userId ?? user?.id ?? 'guest');
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
  }), [activeUser, expQueue, loadUser, user]);

  // Return null while Clerk is still loading to avoid flash of guest state
  if (!isLoaded) return null;

  return (
    <UserContext.Provider value={value}>
      <ApolloClientProvider>{children}</ApolloClientProvider>
    </UserContext.Provider>
  );
}
