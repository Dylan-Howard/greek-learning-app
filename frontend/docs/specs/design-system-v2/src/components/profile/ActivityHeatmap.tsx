'use client';
// src/components/profile/ActivityHeatmap.tsx

import React, { useMemo } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Tooltip from '@mui/material/Tooltip';
import { tokens } from '@/theme/theme';

interface DayActivity { date: string; count: number } // date: 'YYYY-MM-DD'

interface Props {
  data:  DayActivity[];
  weeks?: number; // default 26 (~6 months)
}

const INTENSITY_COLORS = [
  tokens.color.surfaceAlt,     // 0
  `${tokens.color.primary}33`, // 1–2
  `${tokens.color.primary}66`, // 3–5
  `${tokens.color.primary}99`, // 6–9
  tokens.color.primary,        // 10+
];

function intensityIndex(count: number): number {
  if (count === 0)  return 0;
  if (count < 3)    return 1;
  if (count < 6)    return 2;
  if (count < 10)   return 3;
  return 4;
}

export default function ActivityHeatmap({ data, weeks = 26 }: Props) {
  const grid = useMemo(() => {
    const map = new Map(data.map((d) => [d.date, d.count]));
    const days: { date: string; count: number }[] = [];

    // Start from (weeks * 7) days ago, aligned to Monday
    const end   = new Date();
    const start = new Date(end);
    start.setDate(start.getDate() - weeks * 7);

    for (let d = new Date(start); d <= end; d.setDate(d.getDate() + 1)) {
      const iso = d.toISOString().slice(0, 10);
      days.push({ date: iso, count: map.get(iso) ?? 0 });
    }
    return days;
  }, [data, weeks]);

  const CELL  = 10;
  const GAP   = 2;
  const total = weeks * 7;

  return (
    <Box>
      <Typography
        sx={{
          fontSize:      '0.625rem',
          fontWeight:    600,
          color:         tokens.color.textMuted,
          textTransform: 'uppercase',
          letterSpacing: '0.08em',
          mb:            1,
        }}
      >
        Reading Activity
      </Typography>

      <Box
        sx={{
          display:             'grid',
          gridTemplateColumns: `repeat(${weeks}, ${CELL}px)`,
          gridTemplateRows:    `repeat(7, ${CELL}px)`,
          gap:                 `${GAP}px`,
          gridAutoFlow:        'column',
          overflowX:           'auto',
        }}
      >
        {grid.slice(-total).map(({ date, count }) => (
          <Tooltip
            key={date}
            title={count > 0 ? `${date}: ${count} review${count !== 1 ? 's' : ''}` : date}
            placement="top"
            arrow
            enterDelay={200}
          >
            <Box
              sx={{
                width:        CELL,
                height:       CELL,
                borderRadius: 1,
                bgcolor:      INTENSITY_COLORS[intensityIndex(count)],
                cursor:       count > 0 ? 'default' : undefined,
                transition:   `background-color ${tokens.motion.fast}`,
              }}
            />
          </Tooltip>
        ))}
      </Box>

      {/* Legend */}
      <Box sx={{ display: 'flex', alignItems: 'center', gap: 0.5, mt: 1 }}>
        <Typography variant="body2" sx={{ color: tokens.color.textMuted, mr: 0.5 }}>Less</Typography>
        {INTENSITY_COLORS.map((color, i) => (
          <Box key={i} sx={{ width: CELL, height: CELL, borderRadius: 1, bgcolor: color }} />
        ))}
        <Typography variant="body2" sx={{ color: tokens.color.textMuted, ml: 0.5 }}>More</Typography>
      </Box>
    </Box>
  );
}
