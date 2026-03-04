export const XP_PER_LEVEL = 500;

export function levelFromExperience(totalExp: number): number {
  const bounded = Math.max(0, totalExp || 0);
  return Math.floor(bounded / XP_PER_LEVEL);
}

export function inLevelExperience(totalExp: number): number {
  const bounded = Math.max(0, totalExp || 0);
  return bounded - (levelFromExperience(bounded) * XP_PER_LEVEL);
}

export function experienceProgressPercent(totalExp: number): number {
  return (inLevelExperience(totalExp) / XP_PER_LEVEL) * 100;
}

export function avatarInitial(displayName?: string): string {
  const trimmed = (displayName || '').trim();
  return trimmed ? trimmed[0].toUpperCase() : '?';
}

export function avatarColorFromUserId(userId?: string): string {
  const id = userId || '0';
  let hash = 0;
  for (let index = 0; index < id.length; index += 1) {
    hash = ((hash << 5) - hash) + id.charCodeAt(index);
    hash |= 0;
  }

  const hue = Math.abs(hash) % 360;
  return `hsl(${hue} 62% 42%)`;
}
