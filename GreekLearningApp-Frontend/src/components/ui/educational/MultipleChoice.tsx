'use client';

import React from 'react';
import {
  Box,
  Stack,
  Typography,
  styled,
  alpha,
} from '@mui/material';
import {
  Check as CheckIcon,
  Close as CloseIcon,
} from '@mui/icons-material';
import Button from '../inputs/Button';

export interface MultipleChoiceOption {
  id: string;
  text: string;
  isCorrect?: boolean;
}

export interface MultipleChoiceProps {
  /**
   * Question text
   */
  question: string;
  /**
   * Greek text (optional)
   */
  greekText?: string;
  /**
   * Available options
   */
  options: MultipleChoiceOption[];
  /**
   * Selected option ID
   */
  selectedOption?: string;
  /**
   * Show feedback (after answer submission)
   */
  showFeedback?: boolean;
  /**
   * Selection handler
   */
  onSelect: (optionId: string) => void;
  /**
   * Disabled state
   */
  disabled?: boolean;
}

const OptionButton = styled(Button, {
  shouldForwardProp: (prop) =>
    prop !== 'isSelected' && prop !== 'isCorrect' && prop !== 'isWrong',
})<{
  isSelected?: boolean;
  isCorrect?: boolean;
  isWrong?: boolean;
}>(({ theme, isSelected, isCorrect, isWrong }) => ({
  justifyContent: 'flex-start',
  textAlign: 'left',
  padding: theme.spacing(2),
  border: `2px solid ${theme.vars.palette.border.default}`,
  backgroundColor: theme.vars.palette.canvas.default,
  color: theme.vars.palette.text.primary,
  textTransform: 'none',
  fontSize: '1rem',
  fontWeight: 400,
  minHeight: 64,
  transition: theme.transitions.create(['border-color', 'background-color'], {
    duration: theme.transitions.duration.shorter,
  }),
  '&:hover': {
    backgroundColor: theme.vars.palette.canvas.subtle,
    borderColor: theme.vars.palette.primary.main,
    transform: 'none',
  },
  ...(isSelected &&
    !isCorrect &&
    !isWrong && {
      borderColor: theme.vars.palette.primary.main,
      backgroundColor: alpha(theme.vars.palette.primary.main, 0.08),
    }),
  ...(isCorrect && {
    borderColor: theme.vars.palette.success.main,
    backgroundColor: alpha(theme.vars.palette.success.main, 0.1),
    color: theme.vars.palette.success.dark,
  }),
  ...(isWrong && {
    borderColor: theme.vars.palette.error.main,
    backgroundColor: alpha(theme.vars.palette.error.main, 0.1),
    color: theme.vars.palette.error.dark,
  }),
}));

/**
 * Multiple choice question component for quizzes
 */
export const MultipleChoice: React.FC<MultipleChoiceProps> = ({
  question,
  greekText,
  options,
  selectedOption,
  showFeedback,
  onSelect,
  disabled,
}) => {
  return (
    <Box>
      <Typography variant="h4" gutterBottom>
        {question}
      </Typography>
      {greekText && (
        <Typography variant="greekBody" sx={{ my: 3 }}>
          {greekText}
        </Typography>
      )}
      <Stack spacing={2} sx={{ mt: 3 }}>
        {options.map((option) => {
          const isSelected = selectedOption === option.id;
          const showCorrect = showFeedback && option.isCorrect;
          const showWrong = showFeedback && isSelected && !option.isCorrect;

          return (
            <OptionButton
              key={option.id}
              fullWidth
              variant="outlined"
              onClick={() => !disabled && onSelect(option.id)}
              isSelected={isSelected}
              isCorrect={showCorrect}
              isWrong={showWrong}
              disabled={disabled}
              endIcon={
                showCorrect ? (
                  <CheckIcon />
                ) : showWrong ? (
                  <CloseIcon />
                ) : undefined
              }
            >
              {option.text}
            </OptionButton>
          );
        })}
      </Stack>
    </Box>
  );
};

export default MultipleChoice;
