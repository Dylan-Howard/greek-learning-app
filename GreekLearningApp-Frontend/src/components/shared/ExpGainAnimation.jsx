/**
 * ExpGainWidget — MUI v7  ·  XP gain + level-up animations
 *
 * ─── Quick-start ──────────────────────────────────────────────────────────────
 *
 *   const [totalExp, setTotalExp] = useState(6240); // raw XP across all levels
 *   const [gainedExp, setGainedExp] = useState(0);
 *
 *   // After any XP-earning event:
 *   const handleActivityComplete = (xpDelta) => {
 *     setGainedExp(xpDelta);
 *   };
 *
 *   <ExpGainWidget
 *     totalExp={totalExp}
 *     gainedExp={gainedExp}
 *     xpPerLevel={500}
 *     avatarInitial="A"
 *     onAnimationComplete={(newTotal) => {
 *       setTotalExp(newTotal);
 *       setGainedExp(0);
 *     }}
 *   />
 *
 * ─── Props ────────────────────────────────────────────────────────────────────
 *   totalExp          number   Raw cumulative XP (e.g. 6240 = level 12 + 240 XP in)
 *   gainedExp         number   Delta to animate; set > 0 to trigger; reset in callback
 *   xpPerLevel        number   XP required per level (default 500)
 *   avatarSrc         string?  Avatar image URL
 *   avatarInitial     string?  Fallback letter when no image
 *   onAnimationComplete (newTotal: number) => void
 */

import { useState, useEffect, useRef, useCallback } from "react";
import { Box, Avatar, LinearProgress, Typography, Chip } from "@mui/material";
import { keyframes } from "@mui/system";

// ─── Keyframes ────────────────────────────────────────────────────────────────

const popIn = keyframes`
  0%   { opacity:0; transform:translateY(6px) scale(0.65); }
  60%  { opacity:1; transform:translateY(-12px) scale(1.18); }
  80%  { transform:translateY(-6px) scale(0.96); }
  100% { opacity:1; transform:translateY(-8px) scale(1); }
`;
const popOut = keyframes`
  0%   { opacity:1; transform:translateY(-8px) scale(1); }
  100% { opacity:0; transform:translateY(-22px) scale(0.6); }
`;
const glowXP = keyframes`
  0%  { box-shadow: 0 0 0 2px rgba(255,255,255,.1); }
  40% { box-shadow: 0 0 0 3px #FFD700, 0 0 20px rgba(255,215,0,.5); }
  100%{ box-shadow: 0 0 0 2px rgba(255,255,255,.1); }
`;
const glowLvl = keyframes`
  from { box-shadow: 0 0 0 2px #a855f7, 0 0 10px rgba(168,85,247,.35); }
  to   { box-shadow: 0 0 0 4px #a855f7, 0 0 30px rgba(168,85,247,.75); }
`;
const flashCard = keyframes`
  0%  { background: rgba(10,10,22,.88); }
  25% { background: rgba(90,10,200,.38); }
  100%{ background: rgba(10,10,22,.88); }
`;
const pulseBar = keyframes`
  0%  { filter: brightness(1); }
  50% { filter: brightness(1.6) drop-shadow(0 0 6px #FFD700); }
  100%{ filter: brightness(1); }
`;

// ─── BarrelDigit ──────────────────────────────────────────────────────────────

const CELL_H = 30;

function BarrelDigit({ from, to, duration = 720, delay = 0, active }) {
  const digits = Array.from({ length: 30 }, (_, i) => i % 10);
  const startY = -((from + 10) * CELL_H);
  const endY   = -((to   + 10) * CELL_H);
  const ref    = useRef(null);

  useEffect(() => {
    if (!active || !ref.current) return;
    const el = ref.current;
    el.style.transition = "none";
    el.style.transform  = `translateY(${startY}px)`;
    void el.offsetHeight;
    const t = setTimeout(() => {
      el.style.transition = `transform ${duration}ms cubic-bezier(0.22,0.61,0.36,1)`;
      el.style.transform  = `translateY(${endY}px)`;
    }, delay);
    return () => clearTimeout(t);
  }, [active, from, to]);

  return (
    <Box sx={{ height: CELL_H, overflow: "hidden", display: "inline-block", verticalAlign: "top" }}>
      <Box ref={ref} sx={{ display: "flex", flexDirection: "column", willChange: "transform", transform: `translateY(${startY}px)` }}>
        {digits.map((d, i) => (
          <Box key={i} sx={{ height: CELL_H, lineHeight: `${CELL_H}px`, minWidth: 18, textAlign: "center", fontVariantNumeric: "tabular-nums", display: "block" }}>
            {d}
          </Box>
        ))}
      </Box>
    </Box>
  );
}

function BarrelNumber({ from, to, active, sx = {} }) {
  const maxLen  = Math.max(String(to).length, String(from).length);
  const fromStr = String(from).padStart(maxLen, "0");
  const toStr   = String(to).padStart(maxLen, "0");
  return (
    <Box sx={{ display: "inline-flex", alignItems: "center", ...sx }}>
      {toStr.split("").map((_, i) => (
        <BarrelDigit
          key={i}
          from={parseInt(fromStr[i], 10)}
          to={parseInt(toStr[i], 10)}
          active={active}
          duration={700 + i * 80}
          delay={i * 50}
        />
      ))}
    </Box>
  );
}

// ─── BadgeBarrelDigit  (tiny, for the level badge) ───────────────────────────

const BADGE_H = 11;

function BadgeBarrelDigit({ from, to, active, delay = 0 }) {
  const digits = Array.from({ length: 30 }, (_, i) => i % 10);
  // Extra spin pass for drama
  const startY = -((from + 10) * BADGE_H);
  const endY   = -((to   + 10 + 10) * BADGE_H); // +10 = one extra full rotation
  const ref    = useRef(null);

  useEffect(() => {
    if (!active || !ref.current) return;
    const el = ref.current;
    el.style.transition = "none";
    el.style.transform  = `translateY(${startY}px)`;
    void el.offsetHeight;
    const t = setTimeout(() => {
      el.style.transition = `transform 700ms cubic-bezier(0.22,0.61,0.36,1)`;
      el.style.transform  = `translateY(${endY}px)`;
    }, delay);
    // After anim, reset to canonical position
    const t2 = setTimeout(() => {
      if (!ref.current) return;
      ref.current.style.transition = "none";
      ref.current.style.transform  = `translateY(${-((to + 10) * BADGE_H)}px)`;
    }, delay + 800);
    return () => { clearTimeout(t); clearTimeout(t2); };
  }, [active, from, to]);

  return (
    <Box sx={{ height: BADGE_H, overflow: "hidden", display: "inline-block", verticalAlign: "top" }}>
      <Box
        ref={ref}
        sx={{ display: "flex", flexDirection: "column", willChange: "transform", transform: `translateY(${startY}px)` }}
      >
        {digits.map((d, i) => (
          <Box
            key={i}
            sx={{
              height: BADGE_H, lineHeight: `${BADGE_H}px`,
              fontSize: "0.46rem", fontWeight: 900, color: "#fff",
              textAlign: "center", minWidth: 7, display: "block",
              fontVariantNumeric: "tabular-nums",
              fontFamily: "'DM Mono', monospace",
            }}
          >
            {d}
          </Box>
        ))}
      </Box>
    </Box>
  );
}

function BadgeBarrelNumber({ from, to, active }) {
  const maxLen  = Math.max(String(to).length, String(from).length, 2);
  const fromStr = String(from).padStart(maxLen, "0");
  const toStr   = String(to).padStart(maxLen, "0");
  return (
    <Box sx={{ display: "inline-flex", alignItems: "center", height: BADGE_H, overflow: "hidden" }}>
      {toStr.split("").map((_, i) => (
        <BadgeBarrelDigit
          key={i}
          from={parseInt(fromStr[i], 10)}
          to={parseInt(toStr[i], 10)}
          active={active}
          delay={i * 80}
        />
      ))}
    </Box>
  );
}

// ─── Particle Canvas ──────────────────────────────────────────────────────────

const COLORS = ["#FFD700","#FFA500","#a855f7","#7C3AED","#c084fc","#fbbf24","#f0abfc","#fff","#e879f9"];
const SHAPES = ["circle","square","star","diamond"];

class Particle {
  constructor(x, y) {
    const angle = Math.random() * Math.PI * 2;
    const spd   = 3 + Math.random() * 6;
    Object.assign(this, {
      x, y,
      vx: Math.cos(angle) * spd, vy: Math.sin(angle) * spd - 2,
      alpha: 1,
      decay: 0.014 + Math.random() * 0.012,
      size: 3.5 + Math.random() * 4.5,
      color: COLORS[Math.floor(Math.random() * COLORS.length)],
      shape: SHAPES[Math.floor(Math.random() * SHAPES.length)],
      rot: Math.random() * Math.PI * 2,
      rotV: (Math.random() - 0.5) * 0.18,
      gravity: 0.14,
    });
  }
  update() {
    this.x += this.vx; this.y += this.vy;
    this.vy += this.gravity; this.vx *= 0.98;
    this.alpha -= this.decay; this.rot += this.rotV;
  }
  draw(ctx) {
    ctx.save();
    ctx.globalAlpha = Math.max(0, this.alpha);
    ctx.fillStyle   = this.color;
    ctx.translate(this.x, this.y); ctx.rotate(this.rot);
    const s = this.size;
    if (this.shape === "circle") {
      ctx.beginPath(); ctx.arc(0, 0, s / 2, 0, Math.PI * 2); ctx.fill();
    } else if (this.shape === "square") {
      ctx.fillRect(-s/2, -s/2, s, s);
    } else if (this.shape === "diamond") {
      ctx.beginPath();
      ctx.moveTo(0, -s/2); ctx.lineTo(s/2, 0); ctx.lineTo(0, s/2); ctx.lineTo(-s/2, 0);
      ctx.closePath(); ctx.fill();
    } else {
      const r1 = s/2, r2 = s/4, pts = 5;
      let a = -Math.PI/2;
      ctx.beginPath();
      for (let i = 0; i < pts * 2; i++) {
        const r = i % 2 === 0 ? r1 : r2;
        ctx.lineTo(Math.cos(a) * r, Math.sin(a) * r);
        a += Math.PI / pts;
      }
      ctx.closePath(); ctx.fill();
    }
    ctx.restore();
  }
}

function ParticleCanvas({ burst, onRegister }) {
  const canvasRef  = useRef(null);
  const particles  = useRef([]);
  const rafRef     = useRef(null);

  const loop = useCallback(() => {
    const canvas = canvasRef.current;
    if (!canvas) return;
    const ctx = canvas.getContext("2d");
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    particles.current = particles.current.filter(p => p.alpha > 0);
    particles.current.forEach(p => { p.update(); p.draw(ctx); });
    rafRef.current = particles.current.length ? requestAnimationFrame(loop) : null;
  }, []);

  const addBurst = useCallback((x, y, n = 50) => {
    for (let i = 0; i < n; i++) particles.current.push(new Particle(x, y));
    if (!rafRef.current) loop();
  }, [loop]);

  useEffect(() => {
    onRegister(addBurst);
  }, [addBurst, onRegister]);

  useEffect(() => {
    const canvas = canvasRef.current;
    if (!canvas) return;
    const resize = () => { canvas.width = window.innerWidth; canvas.height = window.innerHeight; };
    resize();
    window.addEventListener("resize", resize);
    return () => window.removeEventListener("resize", resize);
  }, []);

  return (
    <Box
      component="canvas"
      ref={canvasRef}
      sx={{ position: "fixed", inset: 0, pointerEvents: "none", zIndex: 10000 }}
    />
  );
}

// ─── ExpGainWidget ────────────────────────────────────────────────────────────

export function ExpGainWidget({
  totalExp      = 0,
  gainedExp     = 0,
  xpPerLevel    = 500,
  avatarSrc,
  avatarInitial = "?",
  onAnimationComplete,
}) {
  const levelOf    = (xp) => Math.floor(xp / xpPerLevel);
  const inLevel    = (xp) => xp - levelOf(xp) * xpPerLevel;

  const curLevel   = levelOf(totalExp);
  const curInLevel = inLevel(totalExp);

  const [phase, setPhase]             = useState("idle");
  const [displayedXP, setDisplayedXP] = useState(curInLevel);
  const [xpBarrelOn, setXpBarrelOn]   = useState(false);
  const [lvlBarrelOn, setLvlBarrelOn] = useState(false);
  const [barPct, setBarPct]           = useState((curInLevel / xpPerLevel) * 100);
  const [dispLevel, setDispLevel]     = useState(curLevel);
  const [cardMode, setCardMode]       = useState("idle"); // idle | xp | lvl

  const avatarRef  = useRef(null);
  const burstRef   = useRef(null);
  const timers     = useRef([]);

  const endTotal   = totalExp + gainedExp;
  const endLevel   = levelOf(endTotal);
  const endInLevel = inLevel(endTotal);
  const levelsUp   = endLevel - curLevel;

  const go = useCallback((fn, ms) => {
    const t = setTimeout(fn, ms);
    timers.current.push(t);
    return t;
  }, []);

  useEffect(() => {
    timers.current.forEach(clearTimeout);
    timers.current = [];
    if (gainedExp <= 0) return;

    setXpBarrelOn(false);
    setLvlBarrelOn(false);
    setDisplayedXP(curInLevel);
    setBarPct((curInLevel / xpPerLevel) * 100);

    // ── XP popup → barrel ────────────────────────────────
    go(() => setPhase("xp-popup"), 30);
    go(() => {
      setPhase("xp-rolling");
      setCardMode("xp");
      if (levelsUp > 0) {
        setBarPct(100);
      } else {
        setBarPct((endInLevel / xpPerLevel) * 100);
      }
      go(() => setXpBarrelOn(true), 40);
    }, 1250);

    // Approximate barrel duration
    const maxLen   = Math.max(String(endInLevel).length, String(curInLevel).length);
    const rollMs   = 700 + (maxLen - 1) * 80 + (maxLen - 1) * 50 + 500;

    go(() => {
      setDisplayedXP(endInLevel);
      setXpBarrelOn(false);
      setCardMode(levelsUp > 0 ? "lvl" : "idle");
      setPhase(levelsUp > 0 ? "lvl-up" : "done");

      if (levelsUp > 0) {
        // Reset bar → animate to new in-level pct
        setBarPct(0);
        go(() => setBarPct((endInLevel / xpPerLevel) * 100), 80);

        // Particle burst
        go(() => {
          if (avatarRef.current && burstRef.current) {
            const r = avatarRef.current.getBoundingClientRect();
            const cx = r.left + r.width / 2;
            const cy = r.top  + r.height / 2;
            burstRef.current(cx, cy, 55);
            go(() => burstRef.current?.(cx, cy, 35), 130);
            go(() => burstRef.current?.(cx, cy, 20), 280);
          }
        }, 100);

        // Badge barrel
        go(() => {
          setLvlBarrelOn(false);
          go(() => setLvlBarrelOn(true), 30);
        }, 200);

        // Level popup
        go(() => setPhase("lvl-popup"), 200);
        go(() => setPhase("lvl-popup-out"), 1900);
        go(() => {
          setPhase("idle");
          setCardMode("idle");
          setDispLevel(endLevel);
          onAnimationComplete?.(endTotal);
        }, 2400);
      } else {
        go(() => {
          setPhase("idle");
          onAnimationComplete?.(endTotal);
        }, 400);
      }
    }, 1250 + 40 + rollMs);

    return () => timers.current.forEach(clearTimeout);
  }, [gainedExp, totalExp]);

  const isXpActive  = cardMode === "xp";
  const isLvlActive = cardMode === "lvl";

  return (
    <>
      <ParticleCanvas onRegister={(fn) => { burstRef.current = fn; }} burst={null} />

      <Box sx={{ position: "fixed", bottom: 26, right: 26, display: "flex", flexDirection: "column", alignItems: "flex-end", gap: "5px", zIndex: 9999 }}>

        {/* Level-up chip */}
        {(phase === "lvl-popup" || phase === "lvl-popup-out") && (
          <Chip
            label="✦ LEVEL UP!"
            size="small"
            sx={{
              bgcolor: "linear-gradient(135deg, #a855f7, #6d28d9)",
              background: "linear-gradient(135deg, #a855f7, #6d28d9)",
              color: "#fff",
              fontWeight: 800,
              fontFamily: "'DM Mono', monospace",
              fontSize: "0.75rem",
              letterSpacing: "0.08em",
              textTransform: "uppercase",
              boxShadow: "0 4px 22px rgba(124,58,237,.55)",
              border: "1.5px solid rgba(255,255,255,.25)",
              animation: phase === "lvl-popup"
                ? `${popIn}  0.44s cubic-bezier(0.34,1.56,0.64,1) both`
                : `${popOut} 0.38s ease-in both`,
            }}
          />
        )}

        {/* XP gain chip */}
        {(phase === "xp-popup" || phase === "xp-rolling") && (
          <Chip
            label={`✦ +${gainedExp} XP`}
            size="small"
            sx={{
              background: "linear-gradient(135deg, #FFD700, #FFA500)",
              color: "#1a1003",
              fontWeight: 800,
              fontFamily: "'DM Mono', monospace",
              fontSize: "0.75rem",
              letterSpacing: "0.05em",
              boxShadow: "0 4px 22px rgba(255,165,0,.5)",
              border: "1.5px solid rgba(255,255,255,.28)",
              animation: phase === "xp-popup"
                ? `${popIn}  0.42s cubic-bezier(0.34,1.56,0.64,1) both`
                : `${popOut} 0.35s ease-in both`,
            }}
          />
        )}

        {/* Card */}
        <Box
          sx={{
            background: "rgba(10,10,22,.88)",
            backdropFilter: "blur(14px)",
            border: `1px solid ${isLvlActive ? "rgba(168,85,247,.7)" : isXpActive ? "rgba(255,215,0,.42)" : "rgba(255,255,255,.09)"}`,
            borderRadius: "16px",
            padding: "12px 16px",
            minWidth: 205,
            boxShadow: isLvlActive
              ? "0 0 0 2px #a855f7, 0 0 40px rgba(168,85,247,.4), 0 12px 40px rgba(0,0,0,.6)"
              : isXpActive
              ? "0 0 0 1.5px #FFD700, 0 12px 40px rgba(0,0,0,.6)"
              : "0 8px 32px rgba(0,0,0,.55)",
            transition: "box-shadow .35s ease, border-color .35s ease",
            animation: isLvlActive ? `${flashCard} 0.65s ease` : "none",
          }}
        >
          {/* Avatar + XP row */}
          <Box sx={{ display: "flex", alignItems: "center", gap: "12px", mb: "10px" }}>

            {/* Avatar */}
            <Box sx={{ position: "relative", flexShrink: 0, width: 42, height: 42 }}>
              <Avatar
                ref={avatarRef}
                src={avatarSrc}
                sx={{
                  width: 42, height: 42,
                  background: "linear-gradient(135deg, #7C3AED, #4F46E5)",
                  fontFamily: "'DM Mono', monospace",
                  fontWeight: 700, fontSize: "1rem",
                  animation: isLvlActive
                    ? `${glowLvl} 2s ease infinite alternate`
                    : isXpActive
                    ? `${glowXP} 1.4s ease`
                    : "none",
                  boxShadow: isXpActive
                    ? "0 0 0 2.5px #FFD700, 0 0 18px rgba(255,215,0,.4)"
                    : "0 0 0 2px rgba(255,255,255,.1)",
                  transition: "box-shadow .3s ease",
                }}
              >
                {!avatarSrc && avatarInitial}
              </Avatar>

              {/* Level badge */}
              <Box
                sx={{
                  position: "absolute", bottom: -3, right: -3,
                  width: 18, height: 18, borderRadius: "50%",
                  background: "#7C3AED", border: "1.5px solid #0a0a16",
                  display: "flex", alignItems: "center", justifyContent: "center",
                  overflow: "hidden", zIndex: 1,
                }}
              >
                {lvlBarrelOn ? (
                  <BadgeBarrelNumber
                    from={curLevel}
                    to={endLevel}
                    active={lvlBarrelOn}
                  />
                ) : (
                  <Typography sx={{ fontSize: "0.46rem", fontWeight: 900, color: "#fff", fontFamily: "'DM Mono', monospace", lineHeight: 1 }}>
                    {dispLevel}
                  </Typography>
                )}
              </Box>
            </Box>

            {/* XP text */}
            <Box sx={{ textAlign: "right", flex: 1 }}>
              <Typography sx={{ fontSize: "0.56rem", color: "rgba(255,255,255,.32)", letterSpacing: "0.14em", textTransform: "uppercase", mb: "3px" }}>
                Experience
              </Typography>
              <Box
                sx={{
                  display: "flex", alignItems: "baseline", justifyContent: "flex-end", gap: "2px",
                  fontWeight: 700, fontSize: "1.15rem", lineHeight: 1, fontFamily: "'DM Mono', monospace",
                  color: isXpActive ? "#FFD700" : "#fff",
                  filter: isXpActive ? "drop-shadow(0 0 10px rgba(255,215,0,.65))" : "none",
                  transition: "color .3s, filter .3s",
                  fontVariantNumeric: "tabular-nums",
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
                <Typography component="span" sx={{ fontSize: "0.6rem", color: "rgba(255,255,255,.28)", fontWeight: 400, fontFamily: "inherit" }}>
                  /{xpPerLevel}
                </Typography>
              </Box>
            </Box>
          </Box>

          {/* Progress bar */}
          <LinearProgress
            variant="determinate"
            value={barPct}
            sx={{
              height: 5, borderRadius: 99,
              bgcolor: "rgba(255,255,255,.07)",
              animation: (isXpActive || isLvlActive) ? `${pulseBar} 0.9s ease 1.3s` : "none",
              "& .MuiLinearProgress-bar": {
                borderRadius: 99,
                background: isLvlActive
                  ? "linear-gradient(90deg,#a855f7,#FFD700)"
                  : isXpActive
                  ? "linear-gradient(90deg,#7C3AED,#FFD700)"
                  : "linear-gradient(90deg,#7C3AED,#A78BFA)",
                transition: "transform .9s cubic-bezier(0.25,0.46,0.45,0.94), background .4s ease",
              },
            }}
          />

          {/* Bar labels */}
          <Box sx={{ display: "flex", justifyContent: "space-between", mt: "5px" }}>
            <Typography sx={{ fontSize: "0.51rem", color: "rgba(255,255,255,.18)", letterSpacing: "0.06em" }}>
              LVL {levelsUp > 0 && phase !== "idle" ? endLevel : dispLevel}
            </Typography>
            <Typography sx={{ fontSize: "0.51rem", color: "rgba(255,255,255,.18)", letterSpacing: "0.06em" }}>
              LVL {(levelsUp > 0 && phase !== "idle" ? endLevel : dispLevel) + 1}
            </Typography>
          </Box>
        </Box>
      </Box>
    </>
  );
}

// ─── Demo App ────────────────────────────────────────────────────────────────

export default function App() {
  const XP_PER_LEVEL = 500;
  const [totalExp, setTotalExp]   = useState(6240); // Level 12, 240 XP in
  const [gainedExp, setGainedExp] = useState(0);

  const earn = (amount) => {
    if (gainedExp > 0) return;
    setGainedExp(amount);
  };

  const handleDone = (newTotal) => {
    setTotalExp(newTotal);
    setGainedExp(0);
  };

  const level   = Math.floor(totalExp / XP_PER_LEVEL);
  const inLevel = totalExp - level * XP_PER_LEVEL;

  return (
    <Box sx={{
      minHeight: "100vh",
      background: "radial-gradient(ellipse at 60% 25%, #1a0838 0%, #0d0d1a 65%)",
      display: "flex", flexDirection: "column", alignItems: "center", justifyContent: "center",
      gap: 2, fontFamily: "'DM Mono', monospace", color: "#fff", pb: 20,
    }}>
      <Typography sx={{ fontSize: "0.58rem", letterSpacing: "0.22em", textTransform: "uppercase", color: "rgba(255,255,255,.28)" }}>
        Gamified Learning
      </Typography>
      <Typography sx={{ fontSize: "1.5rem", fontWeight: 700, letterSpacing: "-0.02em", mb: 0.5 }}>
        Complete an activity
      </Typography>
      <Typography sx={{ fontSize: "0.65rem", color: "rgba(255,255,255,.3)", mb: 1 }}>
        Level {level} · {inLevel} / {XP_PER_LEVEL} XP
      </Typography>

      {[
        { label: "⚡ Quick Quiz",       xp: 50  },
        { label: "📖 Complete Lesson",  xp: 150 },
        { label: "🌟 Level-Up Test",    xp: 400 },
      ].map(({ label, xp }) => (
        <Box
          key={xp}
          onClick={() => earn(xp)}
          sx={{
            display: "flex", justifyContent: "space-between", alignItems: "center",
            width: "100%", maxWidth: 300,
            px: 2.25, py: 1.6,
            border: `1px solid ${xp === 400 ? "rgba(255,215,0,.35)" : "rgba(124,58,237,.35)"}`,
            borderRadius: "12px",
            background: xp === 400 ? "rgba(255,215,0,.07)" : "rgba(124,58,237,.11)",
            color: xp === 400 ? "#FFD700" : "#A78BFA",
            fontFamily: "'DM Mono', monospace",
            fontWeight: 600, fontSize: "0.84rem",
            cursor: gainedExp > 0 ? "not-allowed" : "pointer",
            opacity: gainedExp > 0 ? 0.38 : 1,
            transition: "background .18s, border-color .18s, opacity .18s",
            "&:hover": gainedExp > 0 ? {} : {
              background: xp === 400 ? "rgba(255,215,0,.16)" : "rgba(124,58,237,.26)",
              borderColor: xp === 400 ? "rgba(255,215,0,.65)" : "rgba(124,58,237,.7)",
            },
          }}
        >
          <span>{label}</span>
          <span style={{ fontSize: "0.72rem", fontWeight: 700, color: "#FFD700" }}>+{xp} XP</span>
        </Box>
      ))}

      <ExpGainWidget
        totalExp={totalExp}
        gainedExp={gainedExp}
        xpPerLevel={XP_PER_LEVEL}
        avatarInitial="A"
        onAnimationComplete={handleDone}
      />
    </Box>
  );
}
