import { useCallback, useEffect, useRef, useState } from 'react';
import { Avatar, Box, Typography } from '@mui/material';
import { keyframes } from '@mui/system';

const glowXP = keyframes`
  0%  { box-shadow: 0 0 0 2px rgba(255,255,255,.1); }
  40% { box-shadow: 0 0 0 3px #FFD700, 0 0 20px rgba(255,215,0,.5); }
  100%{ box-shadow: 0 0 0 2px rgba(255,255,255,.1); }
`;

const glowLvl = keyframes`
  from { box-shadow: 0 0 0 2px #a855f7, 0 0 10px rgba(168,85,247,.35); }
  to   { box-shadow: 0 0 0 4px #a855f7, 0 0 30px rgba(168,85,247,.75); }
`;

const CELL_H = 30;
const BADGE_H = 11;

type BarrelDigitProps = {
  from: number;
  to: number;
  duration?: number;
  delay?: number;
  active: boolean;
};

function BarrelDigit({
  from,
  to,
  duration = 720,
  delay = 0,
  active,
}: BarrelDigitProps) {
  const digits = Array.from({ length: 30 }, (_, i) => i % 10);
  const startY = -((from + 10) * CELL_H);
  const endY = -((to + 10) * CELL_H);
  const ref = useRef<HTMLDivElement | null>(null);

  useEffect(() => {
    if (!active || !ref.current) {
      return;
    }

    const el = ref.current;
    el.style.transition = 'none';
    el.style.transform = `translateY(${startY}px)`;
    void el.offsetHeight;

    const timer = window.setTimeout(() => {
      if (!ref.current) {
        return;
      }
      ref.current.style.transition = `transform ${duration}ms cubic-bezier(0.22,0.61,0.36,1)`;
      ref.current.style.transform = `translateY(${endY}px)`;
    }, delay);

    return () => window.clearTimeout(timer);
  }, [active, delay, duration, endY, startY]);

  return (
    <Box
      sx={{
        height: CELL_H,
        overflow: 'hidden',
        display: 'inline-block',
        verticalAlign: 'top',
      }}
    >
      <Box
        ref={ref}
        sx={{
          display: 'flex',
          flexDirection: 'column',
          willChange: 'transform',
          transform: `translateY(${startY}px)`,
        }}
      >
        {digits.map((digit, i) => (
          <Box
            key={i}
            sx={{
              height: CELL_H,
              lineHeight: `${CELL_H}px`,
              minWidth: 18,
              textAlign: 'center',
              fontVariantNumeric: 'tabular-nums',
              display: 'block',
            }}
          >
            {digit}
          </Box>
        ))}
      </Box>
    </Box>
  );
}

type BarrelNumberProps = {
  from: number;
  to: number;
  active: boolean;
};

function BarrelNumber({ from, to, active }: BarrelNumberProps) {
  const maxLen = Math.max(String(to).length, String(from).length);
  const fromStr = String(from).padStart(maxLen, '0');
  const toStr = String(to).padStart(maxLen, '0');

  return (
    <Box sx={{ display: 'inline-flex', alignItems: 'center' }}>
      {toStr.split('').map((_, i) => (
        <BarrelDigit
          key={i}
          from={Number.parseInt(fromStr[i], 10)}
          to={Number.parseInt(toStr[i], 10)}
          active={active}
          duration={700 + i * 80}
          delay={i * 50}
        />
      ))}
    </Box>
  );
}

type BadgeBarrelDigitProps = {
  from: number;
  to: number;
  active: boolean;
  delay?: number;
};

function BadgeBarrelDigit({
  from,
  to,
  active,
  delay = 0,
}: BadgeBarrelDigitProps) {
  const digits = Array.from({ length: 30 }, (_, i) => i % 10);
  const startY = -((from + 10) * BADGE_H);
  const endY = -((to + 20) * BADGE_H);
  const ref = useRef<HTMLDivElement | null>(null);

  useEffect(() => {
    if (!active || !ref.current) {
      return;
    }

    const el = ref.current;
    el.style.transition = 'none';
    el.style.transform = `translateY(${startY}px)`;
    void el.offsetHeight;

    const firstTimer = window.setTimeout(() => {
      if (!ref.current) {
        return;
      }
      ref.current.style.transition = 'transform 700ms cubic-bezier(0.22,0.61,0.36,1)';
      ref.current.style.transform = `translateY(${endY}px)`;
    }, delay);

    const resetTimer = window.setTimeout(() => {
      if (!ref.current) {
        return;
      }
      ref.current.style.transition = 'none';
      ref.current.style.transform = `translateY(${-((to + 10) * BADGE_H)}px)`;
    }, delay + 800);

    return () => {
      window.clearTimeout(firstTimer);
      window.clearTimeout(resetTimer);
    };
  }, [active, delay, endY, startY, to]);

  return (
    <Box
      sx={{
        height: BADGE_H,
        overflow: 'hidden',
        display: 'inline-block',
        verticalAlign: 'top',
      }}
    >
      <Box
        ref={ref}
        sx={{
          display: 'flex',
          flexDirection: 'column',
          willChange: 'transform',
          transform: `translateY(${startY}px)`,
        }}
      >
        {digits.map((digit, i) => (
          <Box
            key={i}
            sx={{
              height: BADGE_H,
              lineHeight: `${BADGE_H}px`,
              fontSize: '0.46rem',
              fontWeight: 900,
              color: '#fff',
              textAlign: 'center',
              minWidth: 7,
              display: 'block',
              fontVariantNumeric: 'tabular-nums',
              fontFamily: '\'DM Mono\', monospace',
            }}
          >
            {digit}
          </Box>
        ))}
      </Box>
    </Box>
  );
}

type BadgeBarrelNumberProps = {
  from: number;
  to: number;
  active: boolean;
};

function BadgeBarrelNumber({ from, to, active }: BadgeBarrelNumberProps) {
  const maxLen = Math.max(String(to).length, String(from).length, 2);
  const fromStr = String(from).padStart(maxLen, '0');
  const toStr = String(to).padStart(maxLen, '0');

  return (
    <Box sx={{ display: 'inline-flex', alignItems: 'center', height: BADGE_H, overflow: 'hidden' }}>
      {toStr.split('').map((_, i) => (
        <BadgeBarrelDigit
          key={i}
          from={Number.parseInt(fromStr[i], 10)}
          to={Number.parseInt(toStr[i], 10)}
          active={active}
          delay={i * 80}
        />
      ))}
    </Box>
  );
}

type ExpAvatarBadgeProps = {
  totalExp?: number;
  gainedExp?: number;
  xpPerLevel?: number;
  avatarSrc?: string;
  avatarInitial?: string;
  onAnimationComplete?: (newTotal: number) => void;
  showMeta?: boolean;
};

export function ExpAvatarBadge({
  totalExp = 0,
  gainedExp = 0,
  xpPerLevel = 500,
  avatarSrc,
  avatarInitial = '?',
  onAnimationComplete,
  showMeta = false,
}: ExpAvatarBadgeProps) {
  const levelOf = (xp: number) => Math.floor(xp / xpPerLevel);
  const inLevel = (xp: number) => xp - levelOf(xp) * xpPerLevel;

  const curLevel = levelOf(totalExp);
  const curInLevel = inLevel(totalExp);
  const endTotal = totalExp + gainedExp;
  const endLevel = levelOf(endTotal);
  const endInLevel = inLevel(endTotal);
  const levelsUp = endLevel - curLevel;

  const [cardMode, setCardMode] = useState<'idle' | 'xp' | 'lvl'>('idle');
  const [displayedXP, setDisplayedXP] = useState(curInLevel);
  const [xpBarrelOn, setXpBarrelOn] = useState(false);
  const [displayLevel, setDisplayLevel] = useState(curLevel);
  const [lvlBarrelOn, setLvlBarrelOn] = useState(false);
  const timersRef = useRef<number[]>([]);

  const go = useCallback((fn: () => void, ms: number) => {
    const timer = window.setTimeout(fn, ms);
    timersRef.current.push(timer);
    return timer;
  }, []);

  useEffect(() => {
    setDisplayedXP(curInLevel);
    setDisplayLevel(curLevel);
  }, [curInLevel, curLevel]);

  useEffect(() => {
    timersRef.current.forEach((timer) => window.clearTimeout(timer));
    timersRef.current = [];

    if (gainedExp <= 0) {
      return;
    }

    setXpBarrelOn(false);
    setLvlBarrelOn(false);
    setDisplayedXP(curInLevel);
    setDisplayLevel(curLevel);

    go(() => {
      setCardMode('xp');
      go(() => setXpBarrelOn(true), 40);
    }, 1250);

    const maxLen = Math.max(String(endInLevel).length, String(curInLevel).length);
    const rollMs = 700 + (maxLen - 1) * 80 + (maxLen - 1) * 50 + 500;

    go(() => {
      setDisplayedXP(endInLevel);
      setXpBarrelOn(false);
      setCardMode(levelsUp > 0 ? 'lvl' : 'idle');

      if (levelsUp > 0) {
        go(() => {
          setLvlBarrelOn(false);
          go(() => setLvlBarrelOn(true), 30);
        }, 200);

        go(() => {
          setCardMode('idle');
          setDisplayLevel(endLevel);
          setLvlBarrelOn(false);
          onAnimationComplete?.(endTotal);
        }, 2400);
      } else {
        go(() => {
          setCardMode('idle');
          onAnimationComplete?.(endTotal);
        }, 400);
      }
    }, 1250 + 40 + rollMs);

    return () => {
      timersRef.current.forEach((timer) => window.clearTimeout(timer));
      timersRef.current = [];
    };
  }, [curInLevel, curLevel, endInLevel, endLevel, endTotal, gainedExp, go, levelsUp, onAnimationComplete]);

  const isXpActive = cardMode === 'xp';
  const isLvlActive = cardMode === 'lvl';

  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', alignItems: 'center', gap: showMeta ? 0.5 : 0 }}>
      <Box sx={{ position: 'relative', width: 42, height: 42 }}>
        <Avatar
          src={avatarSrc}
          sx={{
            width: 42,
            height: 42,
            background: 'linear-gradient(135deg, #7C3AED, #4F46E5)',
            fontFamily: '\'DM Mono\', monospace',
            fontWeight: 700,
            fontSize: '1rem',
            animation: isLvlActive
              ? `${glowLvl} 2s ease infinite alternate`
              : isXpActive
                ? `${glowXP} 1.4s ease`
                : 'none',
            boxShadow: isXpActive
              ? '0 0 0 2.5px #FFD700, 0 0 18px rgba(255,215,0,.4)'
              : '0 0 0 2px rgba(255,255,255,.1)',
            transition: 'box-shadow .3s ease',
          }}
        >
          {!avatarSrc && avatarInitial}
        </Avatar>
        <Box
          sx={{
            position: 'absolute',
            bottom: -3,
            right: -3,
            width: 18,
            height: 18,
            borderRadius: '50%',
            background: '#7C3AED',
            border: '1.5px solid #0a0a16',
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'center',
            overflow: 'hidden',
            zIndex: 1,
          }}
        >
          {lvlBarrelOn ? (
            <BadgeBarrelNumber from={curLevel} to={endLevel} active={lvlBarrelOn} />
          ) : (
            <Typography
              sx={{
                fontSize: '0.46rem',
                fontWeight: 900,
                color: '#fff',
                fontFamily: '\'DM Mono\', monospace',
                lineHeight: 1,
              }}
            >
              {displayLevel}
            </Typography>
          )}
        </Box>
      </Box>
      {showMeta ? (
        <>
          <Typography variant="caption" sx={{ fontWeight: 700 }}>
            {`Lv ${displayLevel}`}
          </Typography>
          <Typography
            variant="caption"
            color="text.secondary"
            sx={{
              display: 'flex',
              alignItems: 'baseline',
              fontVariantNumeric: 'tabular-nums',
              color: isXpActive ? '#FFD700' : undefined,
            }}
          >
            {xpBarrelOn ? (
              <BarrelNumber
                from={curInLevel}
                to={levelsUp > 0 ? xpPerLevel : endInLevel}
                active={xpBarrelOn}
              />
            ) : (
              <span>{displayedXP}</span>
            )}
            <Typography component="span" variant="caption" color="text.secondary">
              /{xpPerLevel}
            </Typography>
          </Typography>
        </>
      ) : null}
    </Box>
  );
}
