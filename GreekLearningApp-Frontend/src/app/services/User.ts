'use client';

import { createContext } from 'react';
import { UserDto } from '../../types/api';

export const UserContext = createContext<{ user: UserDto | null, setUser: Function }>({
  user: null,
  setUser: () => {},
});
