'use client';

import React from 'react';
import { Stack } from '@mui/material';
import { Button } from '@/components/ui';
import { Rating } from '@/lib/types/api';

interface RatingButtonsProps {
  onRate: (rating: Rating) => void;
  disabled?: boolean;
}

export default function RatingButtons({ onRate, disabled = false }: RatingButtonsProps) {
  return (
    <Stack direction="row" spacing={2}>
      <Button color="error" variant="contained" disabled={disabled} onClick={() => onRate('Again')}>
        Again
      </Button>
      <Button color="warning" variant="contained" disabled={disabled} onClick={() => onRate('Hard')}>
        Hard
      </Button>
      <Button color="primary" variant="contained" disabled={disabled} onClick={() => onRate('Good')}>
        Good
      </Button>
      <Button color="success" variant="contained" disabled={disabled} onClick={() => onRate('Easy')}>
        Easy
      </Button>
    </Stack>
  );
}
