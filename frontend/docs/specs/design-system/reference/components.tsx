// ============================================
// COMPONENTS LIBRARY
// Complete component collection for Koine Greek Learning App
// ============================================

import React from 'react';
import {
  Box,
  Button as MuiButton,
  ButtonProps as MuiButtonProps,
  IconButton as MuiIconButton,
  IconButtonProps as MuiIconButtonProps,
  ButtonGroup as MuiButtonGroup,
  ButtonGroupProps as MuiButtonGroupProps,
  ToggleButton as MuiToggleButton,
  ToggleButtonGroup as MuiToggleButtonGroup,
  ToggleButtonProps,
  ToggleButtonGroupProps,
  TextField as MuiTextField,
  TextFieldProps as MuiTextFieldProps,
  Select as MuiSelect,
  SelectProps as MuiSelectProps,
  MenuItem,
  FormControl,
  InputLabel,
  Checkbox as MuiCheckbox,
  CheckboxProps as MuiCheckboxProps,
  Radio as MuiRadio,
  RadioProps as MuiRadioProps,
  RadioGroup,
  FormControlLabel,
  Switch as MuiSwitch,
  SwitchProps as MuiSwitchProps,
  Autocomplete as MuiAutocomplete,
  AutocompleteProps,
  Card as MuiCard,
  CardProps as MuiCardProps,
  CardContent,
  CardHeader,
  CardActions,
  Typography,
  LinearProgress,
  CircularProgress,
  Alert as MuiAlert,
  AlertProps as MuiAlertProps,
  Snackbar,
  Dialog as MuiDialog,
  DialogTitle,
  DialogContent,
  DialogActions,
  DialogProps,
  Chip as MuiChip,
  ChipProps as MuiChipProps,
  Avatar as MuiAvatar,
  AvatarProps as MuiAvatarProps,
  Tooltip as MuiTooltip,
  TooltipProps as MuiTooltipProps,
  Divider as MuiDivider,
  List,
  ListItem,
  ListItemButton,
  ListItemText,
  ListItemIcon,
  Drawer,
  AppBar as MuiAppBar,
  Toolbar,
  Tabs as MuiTabs,
  Tab,
  Breadcrumbs,
  Link,
  Fab as MuiFab,
  FabProps as MuiFabProps,
  Paper as MuiPaper,
  PaperProps as MuiPaperProps,
  Container as MuiContainer,
  ContainerProps as MuiContainerProps,
  Grid,
  Stack,
  Skeleton,
  styled,
  alpha,
  useTheme,
} from '@mui/material';
import {
  Check as CheckIcon,
  Close as CloseIcon,
  Menu as MenuIcon,
  ArrowBack as ArrowBackIcon,
  ArrowForward as ArrowForwardIcon,
  Home as HomeIcon,
  Settings as SettingsIcon,
  Person as PersonIcon,
  Visibility as VisibilityIcon,
  VisibilityOff as VisibilityOffIcon,
  Email as EmailIcon,
  Lock as LockIcon,
} from '@mui/icons-material';

// ============================================
// BUTTON COMPONENT
// Suggested file: src/components/inputs/Button.tsx
// ============================================

export interface ButtonProps extends MuiButtonProps {
  /**
   * Visual style variant
   * - contained: Solid background (primary CTA)
   * - outlined: Outlined with border (secondary actions)
   * - text: No background or border (tertiary actions)
   */
  variant?: 'contained' | 'outlined' | 'text';
  /**
   * Color theme
   */
  color?: 'primary' | 'secondary' | 'error' | 'warning' | 'info' | 'success';
  /**
   * Size variant
   */
  size?: 'small' | 'medium' | 'large';
  /**
   * Show loading state with spinner
   */
  loading?: boolean;
}

const StyledButton = styled(MuiButton, {
  shouldForwardProp: (prop) => prop !== 'loading',
})<{ loading?: boolean }>(({ theme, loading }) => ({
  position: 'relative',
  '&:hover': {
    transform: 'translateY(-1px)',
  },
  '&:active': {
    transform: 'translateY(0)',
  },
  ...(loading && {
    color: 'transparent',
    pointerEvents: 'none',
  }),
}));

const ButtonSpinner = styled(CircularProgress)({
  position: 'absolute',
  top: '50%',
  left: '50%',
  marginTop: -12,
  marginLeft: -12,
});

/**
 * Primary button component with loading state and hover animations
 */
export const Button: React.FC<ButtonProps> = ({
  loading,
  children,
  disabled,
  ...props
}) => {
  return (
    <StyledButton loading={loading} disabled={disabled || loading} {...props}>
      {children}
      {loading && <ButtonSpinner size={24} color="inherit" />}
    </StyledButton>
  );
};

// ============================================
// ICON BUTTON COMPONENT
// Suggested file: src/components/inputs/IconButton.tsx
// ============================================

export interface IconButtonProps extends MuiIconButtonProps {
  /**
   * Tooltip text to show on hover
   */
  tooltip?: string;
}

const StyledIconButton = styled(MuiIconButton)(({ theme }) => ({
  transition: theme.transitions.create(['background-color', 'transform'], {
    duration: theme.transitions.duration.shorter,
  }),
  '&:hover': {
    transform: 'scale(1.05)',
  },
  '&:active': {
    transform: 'scale(0.95)',
  },
}));

/**
 * Icon button with optional tooltip
 */
export const IconButton: React.FC<IconButtonProps> = ({
  tooltip,
  children,
  ...props
}) => {
  const button = <StyledIconButton {...props}>{children}</StyledIconButton>;

  if (tooltip) {
    return <MuiTooltip title={tooltip}>{button}</MuiTooltip>;
  }

  return button;
};

// ============================================
// BUTTON GROUP COMPONENT
// Suggested file: src/components/inputs/ButtonGroup.tsx
// ============================================

export interface ButtonGroupProps extends MuiButtonGroupProps {
  /**
   * Buttons to render in the group
   */
  buttons: Array<{
    label: string;
    onClick: () => void;
    disabled?: boolean;
    startIcon?: React.ReactNode;
    endIcon?: React.ReactNode;
  }>;
}

/**
 * Group of related buttons
 */
export const ButtonGroup: React.FC<ButtonGroupProps> = ({
  buttons,
  ...props
}) => {
  return (
    <MuiButtonGroup {...props}>
      {buttons.map((button, index) => (
        <Button
          key={index}
          onClick={button.onClick}
          disabled={button.disabled}
          startIcon={button.startIcon}
          endIcon={button.endIcon}
        >
          {button.label}
        </Button>
      ))}
    </MuiButtonGroup>
  );
};

// ============================================
// TOGGLE BUTTON COMPONENT
// Suggested file: src/components/inputs/ToggleButton.tsx
// ============================================

export interface ToggleButtonGroupComponentProps extends ToggleButtonGroupProps {
  /**
   * Options to display
   */
  options: Array<{
    value: string;
    label: string;
    icon?: React.ReactNode;
    disabled?: boolean;
  }>;
}

/**
 * Toggle button group for mutually exclusive options
 */
export const ToggleButtonGroupComponent: React.FC<
  ToggleButtonGroupComponentProps
> = ({ options, ...props }) => {
  return (
    <MuiToggleButtonGroup {...props}>
      {options.map((option) => (
        <MuiToggleButton
          key={option.value}
          value={option.value}
          disabled={option.disabled}
        >
          {option.icon && <Box sx={{ mr: 1, display: 'flex' }}>{option.icon}</Box>}
          {option.label}
        </MuiToggleButton>
      ))}
    </MuiToggleButtonGroup>
  );
};

// ============================================
// TEXT FIELD COMPONENT
// Suggested file: src/components/inputs/TextField.tsx
// ============================================

export interface TextFieldProps extends Omit<MuiTextFieldProps, 'variant'> {
  /**
   * Show character count
   */
  showCount?: boolean;
  /**
   * Maximum character length
   */
  maxLength?: number;
}

/**
 * Enhanced text field with character count
 */
export const TextField: React.FC<TextFieldProps> = ({
  showCount,
  maxLength,
  helperText,
  value,
  ...props
}) => {
  const count = value ? String(value).length : 0;

  return (
    <MuiTextField
      value={value}
      inputProps={{ maxLength }}
      helperText={
        showCount ? (
          <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
            <span>{helperText}</span>
            <span>
              {count}
              {maxLength && `/${maxLength}`}
            </span>
          </Box>
        ) : (
          helperText
        )
      }
      {...props}
    />
  );
};

// ============================================
// SELECT COMPONENT
// Suggested file: src/components/inputs/Select.tsx
// ============================================

export interface SelectOption {
  value: string | number;
  label: string;
  disabled?: boolean;
}

export interface SelectProps extends Omit<MuiSelectProps, 'children'> {
  /**
   * Options to display
   */
  options: SelectOption[];
  /**
   * Optional label
   */
  label?: string;
}

/**
 * Select dropdown component
 */
export const Select: React.FC<SelectProps> = ({ options, label, ...props }) => {
  return (
    <FormControl fullWidth={props.fullWidth}>
      {label && <InputLabel>{label}</InputLabel>}
      <MuiSelect label={label} {...props}>
        {options.map((option) => (
          <MenuItem
            key={option.value}
            value={option.value}
            disabled={option.disabled}
          >
            {option.label}
          </MenuItem>
        ))}
      </MuiSelect>
    </FormControl>
  );
};

// ============================================
// CHECKBOX COMPONENT
// Suggested file: src/components/inputs/Checkbox.tsx
// ============================================

export interface CheckboxProps extends MuiCheckboxProps {
  /**
   * Label text
   */
  label?: string;
}

/**
 * Checkbox with optional label
 */
export const Checkbox: React.FC<CheckboxProps> = ({ label, ...props }) => {
  if (label) {
    return <FormControlLabel control={<MuiCheckbox {...props} />} label={label} />;
  }
  return <MuiCheckbox {...props} />;
};

// ============================================
// RADIO GROUP COMPONENT
// Suggested file: src/components/inputs/RadioGroup.tsx
// ============================================

export interface RadioGroupOption {
  value: string;
  label: string;
  disabled?: boolean;
  helperText?: string;
}

export interface RadioGroupComponentProps {
  /**
   * Current value
   */
  value: string;
  /**
   * Change handler
   */
  onChange: (value: string) => void;
  /**
   * Options to display
   */
  options: RadioGroupOption[];
  /**
   * Group name
   */
  name?: string;
  /**
   * Display direction
   */
  row?: boolean;
}

/**
 * Radio group with options
 */
export const RadioGroupComponent: React.FC<RadioGroupComponentProps> = ({
  value,
  onChange,
  options,
  name,
  row,
}) => {
  return (
    <RadioGroup
      value={value}
      onChange={(e) => onChange(e.target.value)}
      name={name}
      row={row}
    >
      {options.map((option) => (
        <Box key={option.value}>
          <FormControlLabel
            value={option.value}
            control={<MuiRadio />}
            label={option.label}
            disabled={option.disabled}
          />
          {option.helperText && (
            <Typography variant="caption" sx={{ ml: 4, display: 'block' }}>
              {option.helperText}
            </Typography>
          )}
        </Box>
      ))}
    </RadioGroup>
  );
};

// ============================================
// SWITCH COMPONENT
// Suggested file: src/components/inputs/Switch.tsx
// ============================================

export interface SwitchProps extends MuiSwitchProps {
  /**
   * Label text
   */
  label?: string;
}

/**
 * Switch with optional label
 */
export const Switch: React.FC<SwitchProps> = ({ label, ...props }) => {
  if (label) {
    return <FormControlLabel control={<MuiSwitch {...props} />} label={label} />;
  }
  return <MuiSwitch {...props} />;
};

// ============================================
// FAB COMPONENT (Floating Action Button)
// Suggested file: src/components/inputs/Fab.tsx
// ============================================

export interface FabProps extends MuiFabProps {
  /**
   * Tooltip text
   */
  tooltip?: string;
}

const StyledFab = styled(MuiFab)(({ theme }) => ({
  transition: theme.transitions.create(['transform', 'box-shadow'], {
    duration: theme.transitions.duration.shorter,
  }),
  '&:hover': {
    transform: 'scale(1.05)',
  },
  '&:active': {
    transform: 'scale(0.95)',
  },
}));

/**
 * Floating action button for primary actions
 */
export const Fab: React.FC<FabProps> = ({ tooltip, children, ...props }) => {
  const fab = <StyledFab {...props}>{children}</StyledFab>;

  if (tooltip) {
    return <MuiTooltip title={tooltip}>{fab}</MuiTooltip>;
  }

  return fab;
};

// ============================================
// CARD COMPONENT
// Suggested file: src/components/display/Card.tsx
// ============================================

export interface CardProps extends MuiCardProps {
  /**
   * Card title
   */
  title?: string;
  /**
   * Card subtitle/description
   */
  subtitle?: string;
  /**
   * Header action (e.g., icon button)
   */
  headerAction?: React.ReactNode;
  /**
   * Card actions (buttons)
   */
  actions?: React.ReactNode;
  /**
   * Show hover effect
   */
  hoverable?: boolean;
}

const HoverableCard = styled(MuiCard, {
  shouldForwardProp: (prop) => prop !== 'hoverable',
})<{ hoverable?: boolean }>(({ theme, hoverable }) => ({
  transition: theme.transitions.create(['transform', 'border-color'], {
    duration: theme.transitions.duration.shorter,
  }),
  ...(hoverable && {
    cursor: 'pointer',
    '&:hover': {
      transform: 'translateY(-2px)',
      borderColor: theme.vars.palette.primary.main,
    },
  }),
}));

/**
 * Versatile card component
 */
export const Card: React.FC<CardProps> = ({
  title,
  subtitle,
  headerAction,
  actions,
  children,
  hoverable,
  ...props
}) => {
  return (
    <HoverableCard hoverable={hoverable} {...props}>
      {(title || subtitle || headerAction) && (
        <CardHeader
          title={title}
          subheader={subtitle}
          action={headerAction}
          titleTypographyProps={{ variant: 'h4' }}
          subheaderTypographyProps={{ variant: 'body2' }}
        />
      )}
      {children && <CardContent>{children}</CardContent>}
      {actions && <CardActions>{actions}</CardActions>}
    </HoverableCard>
  );
};

// ============================================
// PROGRESS CARD COMPONENT
// Suggested file: src/components/display/ProgressCard.tsx
// ============================================

export interface ProgressCardProps extends CardProps {
  /**
   * Progress value (0-100)
   */
  progress: number;
  /**
   * Progress label
   */
  progressLabel?: string;
  /**
   * Progress color
   */
  progressColor?: 'primary' | 'secondary' | 'success' | 'error' | 'warning' | 'info';
}

/**
 * Card with integrated progress indicator
 */
export const ProgressCard: React.FC<ProgressCardProps> = ({
  progress,
  progressLabel,
  progressColor = 'primary',
  children,
  ...cardProps
}) => {
  return (
    <Card {...cardProps}>
      {children}
      <Box sx={{ px: 2, pb: 2 }}>
        <Box sx={{ display: 'flex', justifyContent: 'space-between', mb: 1 }}>
          <Typography variant="body2" color="text.secondary">
            {progressLabel || 'Progress'}
          </Typography>
          <Typography variant="body2" fontWeight={600}>
            {Math.round(progress)}%
          </Typography>
        </Box>
        <LinearProgress
          variant="determinate"
          value={progress}
          color={progressColor}
          sx={{ height: 6, borderRadius: 3 }}
        />
      </Box>
    </Card>
  );
};

// ============================================
// KOINE CARD COMPONENT (Application-specific)
// Suggested file: src/components/display/KoineCard.tsx
// ============================================

export interface KoineCardProps {
  /**
   * Title (e.g., lesson name, vocabulary set)
   */
  title: string;
  /**
   * Description
   */
  description?: string;
  /**
   * Progress percentage (0-100)
   */
  progress?: number;
  /**
   * Greek text preview
   */
  greekPreview?: string;
  /**
   * Click handler
   */
  onClick?: () => void;
  /**
   * Action buttons
   */
  actions?: React.ReactNode;
  /**
   * Icon or image
   */
  icon?: React.ReactNode;
}

const KoineCardRoot = styled(Card)(({ theme }) => ({
  height: '100%',
  display: 'flex',
  flexDirection: 'column',
}));

/**
 * Specialized card for Greek learning content
 */
export const KoineCard: React.FC<KoineCardProps> = ({
  title,
  description,
  progress,
  greekPreview,
  onClick,
  actions,
  icon,
}) => {
  return (
    <KoineCardRoot hoverable={!!onClick} onClick={onClick}>
      <CardHeader
        avatar={icon}
        title={title}
        titleTypographyProps={{ variant: 'h4' }}
      />
      <CardContent sx={{ flexGrow: 1 }}>
        {description && (
          <Typography variant="body2" color="text.secondary" paragraph>
            {description}
          </Typography>
        )}
        {greekPreview && (
          <Typography variant="greekBody" sx={{ mt: 2 }}>
            {greekPreview}
          </Typography>
        )}
      </CardContent>
      {progress !== undefined && (
        <Box sx={{ px: 2, pb: 1 }}>
          <LinearProgress
            variant="determinate"
            value={progress}
            sx={{ height: 4, borderRadius: 2 }}
          />
        </Box>
      )}
      {actions && <CardActions>{actions}</CardActions>}
    </KoineCardRoot>
  );
};

// ============================================
// ALERT COMPONENT
// Suggested file: src/components/feedback/Alert.tsx
// ============================================

export interface AlertProps extends MuiAlertProps {
  /**
   * Alert message
   */
  message: string;
  /**
   * Show close button
   */
  closable?: boolean;
  /**
   * Close handler
   */
  onClose?: () => void;
}

/**
 * Alert component for feedback messages
 */
export const Alert: React.FC<AlertProps> = ({
  message,
  closable,
  onClose,
  ...props
}) => {
  return (
    <MuiAlert onClose={closable ? onClose : undefined} {...props}>
      {message}
    </MuiAlert>
  );
};

// ============================================
// DIALOG COMPONENT
// Suggested file: src/components/feedback/Dialog.tsx
// ============================================

export interface DialogComponentProps extends Omit<DialogProps, 'content'> {
  /**
   * Dialog title
   */
  title: string;
  /**
   * Content
   */
  content: React.ReactNode;
  /**
   * Actions (buttons)
   */
  actions?: React.ReactNode;
  /**
   * Show close button
   */
  showClose?: boolean;
  /**
   * Close handler
   */
  onClose?: () => void;
}

/**
 * Modal dialog component
 */
export const DialogComponent: React.FC<DialogComponentProps> = ({
  title,
  content,
  actions,
  showClose,
  onClose,
  ...props
}) => {
  return (
    <MuiDialog onClose={onClose} {...props}>
      <DialogTitle>
        <Box sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
          {title}
          {showClose && onClose && (
            <IconButton onClick={onClose} size="small">
              <CloseIcon />
            </IconButton>
          )}
        </Box>
      </DialogTitle>
      <DialogContent>{content}</DialogContent>
      {actions && <DialogActions>{actions}</DialogActions>}
    </MuiDialog>
  );
};

// ============================================
// PROSE BLOCK COMPONENT
// Suggested file: src/components/content/ProseBlock.tsx
// ============================================

export interface ProseBlockProps {
  /**
   * Content to display
   */
  children: React.ReactNode;
  /**
   * Maximum width
   */
  maxWidth?: 'sm' | 'md' | 'lg';
}

const ProseRoot = styled(Box)(({ theme }) => ({
  '& h1, & h2, & h3, & h4, & h5, & h6': {
    marginTop: theme.spacing(4),
    marginBottom: theme.spacing(2),
    fontWeight: 600,
    lineHeight: 1.25,
  },
  '& h1': {
    fontSize: '2rem',
  },
  '& h2': {
    fontSize: '1.5rem',
  },
  '& h3': {
    fontSize: '1.25rem',
  },
  '& p': {
    marginBottom: theme.spacing(2),
    lineHeight: 1.7,
  },
  '& ul, & ol': {
    marginBottom: theme.spacing(2),
    paddingLeft: theme.spacing(3),
  },
  '& li': {
    marginBottom: theme.spacing(1),
  },
  '& a': {
    color: theme.vars.palette.primary.main,
    textDecoration: 'none',
    '&:hover': {
      textDecoration: 'underline',
    },
  },
  '& code': {
    backgroundColor: theme.vars.palette.neutral.subtle,
    padding: '2px 6px',
    borderRadius: 4,
    fontSize: '0.875em',
    fontFamily: 'monospace',
  },
  '& pre': {
    backgroundColor: theme.vars.palette.canvas.inset,
    padding: theme.spacing(2),
    borderRadius: 6,
    overflow: 'auto',
    marginBottom: theme.spacing(2),
  },
  '& blockquote': {
    borderLeft: `4px solid ${theme.vars.palette.border.default}`,
    paddingLeft: theme.spacing(2),
    marginLeft: 0,
    fontStyle: 'italic',
    color: theme.vars.palette.text.secondary,
  },
}));

/**
 * Styled prose container for content pages
 */
export const ProseBlock: React.FC<ProseBlockProps> = ({
  children,
  maxWidth = 'md',
}) => {
  const maxWidthMap = {
    sm: 640,
    md: 768,
    lg: 896,
  };

  return (
    <ProseRoot sx={{ maxWidth: maxWidthMap[maxWidth], mx: 'auto', py: 4 }}>
      {children}
    </ProseRoot>
  );
};

// ============================================
// MULTIPLE CHOICE COMPONENT
// Suggested file: src/components/educational/MultipleChoice.tsx
// ============================================

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

// ============================================
// ACKNOWLEDGEMENT BUTTON
// Suggested file: src/components/educational/AcknowledgementButton.tsx
// ============================================

export interface AcknowledgementButtonProps {
  /**
   * Button text
   */
  text: string;
  /**
   * Acknowledgement state
   */
  acknowledged: boolean;
  /**
   * Click handler
   */
  onClick: () => void;
  /**
   * Icon to show when acknowledged
   */
  acknowledgedIcon?: React.ReactNode;
}

const AckButton = styled(Button, {
  shouldForwardProp: (prop) => prop !== 'acknowledged',
})<{ acknowledged?: boolean }>(({ theme, acknowledged }) => ({
  transition: theme.transitions.create(['background-color', 'border-color'], {
    duration: theme.transitions.duration.standard,
  }),
  ...(acknowledged && {
    backgroundColor: alpha(theme.vars.palette.success.main, 0.1),
    borderColor: theme.vars.palette.success.main,
    color: theme.vars.palette.success.dark,
    '&:hover': {
      backgroundColor: alpha(theme.vars.palette.success.main, 0.2),
    },
  }),
}));

/**
 * Button for confirming user acknowledgement of information
 */
export const AcknowledgementButton: React.FC<AcknowledgementButtonProps> = ({
  text,
  acknowledged,
  onClick,
  acknowledgedIcon = <CheckIcon />,
}) => {
  return (
    <AckButton
      variant="outlined"
      acknowledged={acknowledged}
      onClick={onClick}
      endIcon={acknowledged ? acknowledgedIcon : undefined}
      fullWidth
    >
      {acknowledged ? 'Acknowledged' : text}
    </AckButton>
  );
};

// ============================================
// GREEK TEXT UNIT COMPONENT
// Suggested file: src/components/reader/GreekTextUnit.tsx
// ============================================

export interface GreekTextUnitProps {
  /**
   * Greek word/text
   */
  greekText: string;
  /**
   * Interlinear help text (English translation)
   */
  helpText?: string;
  /**
   * Click handler
   */
  onClick?: () => void;
  /**
   * Highlight state
   */
  highlighted?: boolean;
  /**
   * Disabled/non-interactive state
   */
  disabled?: boolean;
}

const GreekTextRoot = styled(Box, {
  shouldForwardProp: (prop) => prop !== 'highlighted' && prop !== 'clickable',
})<{ highlighted?: boolean; clickable?: boolean }>(({ theme, highlighted, clickable }) => ({
  display: 'inline-flex',
  flexDirection: 'column',
  alignItems: 'center',
  gap: theme.spacing(0.5),
  padding: theme.spacing(0.5, 1),
  borderRadius: 4,
  cursor: clickable ? 'pointer' : 'default',
  transition: theme.transitions.create(['background-color'], {
    duration: theme.transitions.duration.shorter,
  }),
  ...(clickable && {
    '&:hover': {
      backgroundColor: theme.vars.palette.neutral.subtle,
    },
  }),
  ...(highlighted && {
    backgroundColor: alpha(theme.vars.palette.primary.main, 0.1),
  }),
}));

/**
 * Interactive Greek text unit with optional interlinear help
 */
export const GreekTextUnit: React.FC<GreekTextUnitProps> = ({
  greekText,
  helpText,
  onClick,
  highlighted,
  disabled,
}) => {
  return (
    <GreekTextRoot
      highlighted={highlighted}
      clickable={!disabled && !!onClick}
      onClick={!disabled ? onClick : undefined}
    >
      <Typography variant="greekBody" component="span">
        {greekText}
      </Typography>
      {helpText && (
        <Typography variant="greekHelp" component="span" color="text.secondary">
          {helpText}
        </Typography>
      )}
    </GreekTextRoot>
  );
};

// ============================================
// HERO SECTION COMPONENT
// Suggested file: src/components/landing/Hero.tsx
// ============================================

export interface HeroProps {
  /**
   * Main headline
   */
  title: string;
  /**
   * Subtitle/description
   */
  subtitle?: string;
  /**
   * Primary CTA
   */
  primaryAction?: {
    label: string;
    onClick: () => void;
  };
  /**
   * Secondary CTA
   */
  secondaryAction?: {
    label: string;
    onClick: () => void;
  };
  /**
   * Background image URL
   */
  backgroundImage?: string;
  /**
   * Hero illustration/image
   */
  illustration?: React.ReactNode;
}

const HeroRoot = styled(Box)(({ theme }) => ({
  minHeight: '70vh',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
  textAlign: 'center',
  padding: theme.spacing(8, 2),
  position: 'relative',
  overflow: 'hidden',
}));

/**
 * Hero section for landing pages
 */
export const Hero: React.FC<HeroProps> = ({
  title,
  subtitle,
  primaryAction,
  secondaryAction,
  backgroundImage,
  illustration,
}) => {
  return (
    <HeroRoot
      sx={{
        backgroundImage: backgroundImage ? `url(${backgroundImage})` : undefined,
        backgroundSize: 'cover',
        backgroundPosition: 'center',
      }}
    >
      <MuiContainer maxWidth="md">
        <Stack spacing={4} alignItems="center">
          {illustration && <Box sx={{ mb: 2 }}>{illustration}</Box>}
          <Typography variant="h1" component="h1">
            {title}
          </Typography>
          {subtitle && (
            <Typography variant="h3" color="text.secondary" fontWeight={400}>
              {subtitle}
            </Typography>
          )}
          <Stack direction="row" spacing={2} flexWrap="wrap" justifyContent="center">
            {primaryAction && (
              <Button
                variant="contained"
                size="large"
                onClick={primaryAction.onClick}
              >
                {primaryAction.label}
              </Button>
            )}
            {secondaryAction && (
              <Button
                variant="outlined"
                size="large"
                onClick={secondaryAction.onClick}
              >
                {secondaryAction.label}
              </Button>
            )}
          </Stack>
        </Stack>
      </MuiContainer>
    </HeroRoot>
  );
};

// ============================================
// FEATURE SECTION COMPONENT
// Suggested file: src/components/landing/FeatureSection.tsx
// ============================================

export interface Feature {
  icon: React.ReactNode;
  title: string;
  description: string;
}

export interface FeatureSectionProps {
  /**
   * Section title
   */
  title?: string;
  /**
   * Section description
   */
  description?: string;
  /**
   * Features to display
   */
  features: Feature[];
  /**
   * Layout columns (2 or 3)
   */
  columns?: 2 | 3;
}

/**
 * Feature section for landing pages
 */
export const FeatureSection: React.FC<FeatureSectionProps> = ({
  title,
  description,
  features,
  columns = 3,
}) => {
  return (
    <Box sx={{ py: 8 }}>
      <MuiContainer maxWidth="lg">
        {(title || description) && (
          <Box sx={{ textAlign: 'center', mb: 6 }}>
            {title && <Typography variant="h2" gutterBottom>{title}</Typography>}
            {description && (
              <Typography variant="h3" color="text.secondary" fontWeight={400}>
                {description}
              </Typography>
            )}
          </Box>
        )}
        <Grid container spacing={4}>
          {features.map((feature, index) => (
            <Grid key={index} size={{ xs: 12, md: 12 / columns }}>
              <Stack spacing={2} alignItems="center" textAlign="center">
                <Box
                  sx={{
                    width: 64,
                    height: 64,
                    borderRadius: '50%',
                    display: 'flex',
                    alignItems: 'center',
                    justifyContent: 'center',
                    bgcolor: (theme) =>
                      alpha(theme.vars.palette.primary.main, 0.1),
                    color: 'primary.main',
                  }}
                >
                  {feature.icon}
                </Box>
                <Typography variant="h4">{feature.title}</Typography>
                <Typography variant="body1" color="text.secondary">
                  {feature.description}
                </Typography>
              </Stack>
            </Grid>
          ))}
        </Grid>
      </MuiContainer>
    </Box>
  );
};

// ============================================
// FOOTER COMPONENT
// Suggested file: src/components/landing/Footer.tsx
// ============================================

export interface FooterLink {
  label: string;
  href: string;
}

export interface FooterSection {
  title: string;
  links: FooterLink[];
}

export interface FooterProps {
  /**
   * Footer sections with links
   */
  sections: FooterSection[];
  /**
   * Copyright text
   */
  copyright?: string;
  /**
   * Social media links
   */
  socialLinks?: Array<{
    icon: React.ReactNode;
    href: string;
    label: string;
  }>;
}

const FooterRoot = styled(Box)(({ theme }) => ({
  backgroundColor: theme.vars.palette.canvas.subtle,
  borderTop: `1px solid ${theme.vars.palette.border.default}`,
  padding: theme.spacing(6, 0, 3),
  marginTop: 'auto',
}));

/**
 * Footer with links and copyright
 */
export const Footer: React.FC<FooterProps> = ({
  sections,
  copyright,
  socialLinks,
}) => {
  return (
    <FooterRoot>
      <MuiContainer maxWidth="lg">
        <Grid container spacing={4}>
          {sections.map((section, index) => (
            <Grid key={index} size={{ xs: 12, sm: 6, md: 3 }}>
              <Typography variant="h6" gutterBottom>
                {section.title}
              </Typography>
              <Stack spacing={1}>
                {section.links.map((link, linkIndex) => (
                  <Link
                    key={linkIndex}
                    href={link.href}
                    color="text.secondary"
                    underline="hover"
                  >
                    {link.label}
                  </Link>
                ))}
              </Stack>
            </Grid>
          ))}
        </Grid>
        <MuiDivider sx={{ my: 4 }} />
        <Box
          sx={{
            display: 'flex',
            justifyContent: 'space-between',
            alignItems: 'center',
            flexWrap: 'wrap',
            gap: 2,
          }}
        >
          <Typography variant="body2" color="text.secondary">
            {copyright || `© ${new Date().getFullYear()} All rights reserved.`}
          </Typography>
          {socialLinks && (
            <Stack direction="row" spacing={1}>
              {socialLinks.map((social, index) => (
                <IconButton
                  key={index}
                  href={social.href}
                  tooltip={social.label}
                  size="small"
                >
                  {social.icon}
                </IconButton>
              ))}
            </Stack>
          )}
        </Box>
      </MuiContainer>
    </FooterRoot>
  );
};

// ============================================
// SIGN IN FORM COMPONENT
// Suggested file: src/components/auth/SignInForm.tsx
// ============================================

export interface SignInFormProps {
  /**
   * Submit handler
   */
  onSubmit: (email: string, password: string) => void;
  /**
   * Loading state
   */
  loading?: boolean;
  /**
   * Error message
   */
  error?: string;
  /**
   * Link to sign up page
   */
  signUpLink?: string;
  /**
   * Link to forgot password
   */
  forgotPasswordLink?: string;
}

/**
 * Sign in form with email and password
 */
export const SignInForm: React.FC<SignInFormProps> = ({
  onSubmit,
  loading,
  error,
  signUpLink,
  forgotPasswordLink,
}) => {
  const [email, setEmail] = React.useState('');
  const [password, setPassword] = React.useState('');
  const [showPassword, setShowPassword] = React.useState(false);

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onSubmit(email, password);
  };

  return (
    <MuiPaper sx={{ p: 4, maxWidth: 400, mx: 'auto' }}>
      <Typography variant="h2" gutterBottom textAlign="center">
        Sign In
      </Typography>
      <form onSubmit={handleSubmit}>
        <Stack spacing={3} sx={{ mt: 3 }}>
          {error && <Alert severity="error" message={error} />}
          <TextField
            label="Email"
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
            fullWidth
            InputProps={{
              startAdornment: <EmailIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <TextField
            label="Password"
            type={showPassword ? 'text' : 'password'}
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
            fullWidth
            InputProps={{
              startAdornment: <LockIcon sx={{ mr: 1, color: 'text.secondary' }} />,
              endAdornment: (
                <IconButton
                  onClick={() => setShowPassword(!showPassword)}
                  edge="end"
                  size="small"
                >
                  {showPassword ? <VisibilityOffIcon /> : <VisibilityIcon />}
                </IconButton>
              ),
            }}
          />
          {forgotPasswordLink && (
            <Link
              href={forgotPasswordLink}
              variant="body2"
              textAlign="right"
              color="primary"
            >
              Forgot password?
            </Link>
          )}
          <Button
            type="submit"
            variant="contained"
            size="large"
            fullWidth
            loading={loading}
          >
            Sign In
          </Button>
          {signUpLink && (
            <Typography variant="body2" textAlign="center">
              Don't have an account?{' '}
              <Link href={signUpLink} color="primary">
                Sign up
              </Link>
            </Typography>
          )}
        </Stack>
      </form>
    </MuiPaper>
  );
};

// ============================================
// SIGN UP FORM COMPONENT
// Suggested file: src/components/auth/SignUpForm.tsx
// ============================================

export interface SignUpFormProps {
  /**
   * Submit handler
   */
  onSubmit: (name: string, email: string, password: string) => void;
  /**
   * Loading state
   */
  loading?: boolean;
  /**
   * Error message
   */
  error?: string;
  /**
   * Link to sign in page
   */
  signInLink?: string;
}

/**
 * Sign up form with name, email, and password
 */
export const SignUpForm: React.FC<SignUpFormProps> = ({
  onSubmit,
  loading,
  error,
  signInLink,
}) => {
  const [name, setName] = React.useState('');
  const [email, setEmail] = React.useState('');
  const [password, setPassword] = React.useState('');
  const [confirmPassword, setConfirmPassword] = React.useState('');
  const [showPassword, setShowPassword] = React.useState(false);
  const [agreedToTerms, setAgreedToTerms] = React.useState(false);

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (password !== confirmPassword) {
      return;
    }
    if (!agreedToTerms) {
      return;
    }
    onSubmit(name, email, password);
  };

  const passwordsMatch = password === confirmPassword || confirmPassword === '';

  return (
    <MuiPaper sx={{ p: 4, maxWidth: 400, mx: 'auto' }}>
      <Typography variant="h2" gutterBottom textAlign="center">
        Sign Up
      </Typography>
      <form onSubmit={handleSubmit}>
        <Stack spacing={3} sx={{ mt: 3 }}>
          {error && <Alert severity="error" message={error} />}
          <TextField
            label="Full Name"
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
            required
            fullWidth
            InputProps={{
              startAdornment: <PersonIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <TextField
            label="Email"
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
            fullWidth
            InputProps={{
              startAdornment: <EmailIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <TextField
            label="Password"
            type={showPassword ? 'text' : 'password'}
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
            fullWidth
            helperText="At least 8 characters"
            InputProps={{
              startAdornment: <LockIcon sx={{ mr: 1, color: 'text.secondary' }} />,
              endAdornment: (
                <IconButton
                  onClick={() => setShowPassword(!showPassword)}
                  edge="end"
                  size="small"
                >
                  {showPassword ? <VisibilityOffIcon /> : <VisibilityIcon />}
                </IconButton>
              ),
            }}
          />
          <TextField
            label="Confirm Password"
            type={showPassword ? 'text' : 'password'}
            value={confirmPassword}
            onChange={(e) => setConfirmPassword(e.target.value)}
            required
            fullWidth
            error={!passwordsMatch}
            helperText={!passwordsMatch ? 'Passwords do not match' : ''}
            InputProps={{
              startAdornment: <LockIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <FormControlLabel
            control={
              <MuiCheckbox
                checked={agreedToTerms}
                onChange={(e) => setAgreedToTerms(e.target.checked)}
              />
            }
            label={
              <Typography variant="body2">
                I agree to the{' '}
                <Link href="/terms" color="primary">
                  Terms of Service
                </Link>{' '}
                and{' '}
                <Link href="/privacy" color="primary">
                  Privacy Policy
                </Link>
              </Typography>
            }
          />
          <Button
            type="submit"
            variant="contained"
            size="large"
            fullWidth
            loading={loading}
            disabled={!passwordsMatch || !agreedToTerms}
          >
            Sign Up
          </Button>
          {signInLink && (
            <Typography variant="body2" textAlign="center">
              Already have an account?{' '}
              <Link href={signInLink} color="primary">
                Sign in
              </Link>
            </Typography>
          )}
        </Stack>
      </form>
    </MuiPaper>
  );
};

// ============================================
// APP SHELL COMPONENT
// Suggested file: src/components/layout/AppShell.tsx
// ============================================

export interface AppShellProps {
  /**
   * Main content
   */
  children: React.ReactNode;
  /**
   * Navigation items
   */
  navItems?: Array<{
    icon: React.ReactNode;
    label: string;
    href: string;
    active?: boolean;
  }>;
  /**
   * Show navigation
   */
  showNav?: boolean;
  /**
   * App bar content
   */
  appBarContent?: React.ReactNode;
}

const AppShellRoot = styled(Box)({
  display: 'flex',
  minHeight: '100vh',
});

const MainContent = styled(Box)(({ theme }) => ({
  flexGrow: 1,
  display: 'flex',
  flexDirection: 'column',
}));

/**
 * Application shell with navigation and app bar
 */
export const AppShell: React.FC<AppShellProps> = ({
  children,
  navItems,
  showNav = true,
  appBarContent,
}) => {
  const [mobileOpen, setMobileOpen] = React.useState(false);
  const theme = useTheme();

  const drawer = navItems && (
    <Box
      sx={{
        width: 240,
        height: '100%',
        borderRight: `1px solid ${theme.vars.palette.border.default}`,
        bgcolor: 'canvas.default',
      }}
    >
      <List sx={{ pt: 2 }}>
        {navItems.map((item, index) => (
          <ListItem key={index} disablePadding>
            <ListItemButton
              href={item.href}
              selected={item.active}
              sx={{
                borderRadius: 1,
                mx: 1,
                mb: 0.5,
              }}
            >
              <ListItemIcon>{item.icon}</ListItemIcon>
              <ListItemText primary={item.label} />
            </ListItemButton>
          </ListItem>
        ))}
      </List>
    </Box>
  );

  return (
    <AppShellRoot>
      {showNav && (
        <>
          {/* Mobile drawer */}
          <Drawer
            variant="temporary"
            open={mobileOpen}
            onClose={() => setMobileOpen(false)}
            ModalProps={{ keepMounted: true }}
            sx={{
              display: { xs: 'block', md: 'none' },
              '& .MuiDrawer-paper': { width: 240 },
            }}
          >
            {drawer}
          </Drawer>
          {/* Desktop drawer */}
          <Drawer
            variant="permanent"
            sx={{
              display: { xs: 'none', md: 'block' },
              '& .MuiDrawer-paper': { width: 240, position: 'relative' },
            }}
            open
          >
            {drawer}
          </Drawer>
        </>
      )}
      <MainContent>
        {appBarContent && (
          <MuiAppBar
            position="sticky"
            elevation={0}
            sx={{
              bgcolor: 'canvas.default',
              color: 'text.primary',
              borderBottom: `1px solid ${theme.vars.palette.border.default}`,
            }}
          >
            <Toolbar>
              {showNav && (
                <IconButton
                  edge="start"
                  onClick={() => setMobileOpen(!mobileOpen)}
                  sx={{ mr: 2, display: { md: 'none' } }}
                >
                  <MenuIcon />
                </IconButton>
              )}
              {appBarContent}
            </Toolbar>
          </MuiAppBar>
        )}
        <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
          {children}
        </Box>
      </MainContent>
    </AppShellRoot>
  );
};

// ============================================
// NAVIGATION RAIL COMPONENT
// Suggested file: src/components/navigation/NavRail.tsx
// ============================================

export interface NavRailItem {
  icon: React.ReactNode;
  label: string;
  href: string;
  badge?: number;
}

export interface NavRailProps {
  /**
   * Navigation items
   */
  items: NavRailItem[];
  /**
   * Active item index
   */
  activeIndex?: number;
  /**
   * Show labels
   */
  showLabels?: boolean;
}

const NavRailRoot = styled(Box)(({ theme }) => ({
  width: 80,
  height: '100vh',
  position: 'fixed',
  left: 0,
  top: 0,
  backgroundColor: theme.vars.palette.canvas.subtle,
  borderRight: `1px solid ${theme.vars.palette.border.default}`,
  display: 'flex',
  flexDirection: 'column',
  alignItems: 'center',
  paddingTop: theme.spacing(2),
  gap: theme.spacing(1),
  [theme.breakpoints.down('md')]: {
    width: '100%',
    height: 'auto',
    position: 'fixed',
    bottom: 0,
    top: 'auto',
    left: 0,
    right: 0,
    flexDirection: 'row',
    justifyContent: 'space-around',
    paddingTop: theme.spacing(1),
    paddingBottom: theme.spacing(1),
    borderRight: 'none',
    borderTop: `1px solid ${theme.vars.palette.border.default}`,
  },
}));

const NavRailButton = styled(IconButton, {
  shouldForwardProp: (prop) => prop !== 'isActive',
})<{ isActive?: boolean }>(({ theme, isActive }) => ({
  width: 56,
  height: 56,
  borderRadius: 12,
  flexDirection: 'column',
  gap: theme.spacing(0.5),
  ...(isActive && {
    backgroundColor: alpha(theme.vars.palette.primary.main, 0.1),
    color: theme.vars.palette.primary.main,
  }),
}));

/**
 * Vertical navigation rail for primary navigation
 */
export const NavRail: React.FC<NavRailProps> = ({
  items,
  activeIndex,
  showLabels = false,
}) => {
  return (
    <NavRailRoot>
      {items.map((item, index) => (
        <MuiTooltip key={index} title={item.label} placement="right">
          <NavRailButton href={item.href} isActive={activeIndex === index}>
            <Box sx={{ position: 'relative' }}>
              {item.icon}
              {item.badge !== undefined && item.badge > 0 && (
                <Box
                  sx={{
                    position: 'absolute',
                    top: -4,
                    right: -4,
                    minWidth: 18,
                    height: 18,
                    borderRadius: '9px',
                    bgcolor: 'error.main',
                    color: 'error.contrastText',
                    fontSize: '0.625rem',
                    fontWeight: 600,
                    display: 'flex',
                    alignItems: 'center',
                    justifyContent: 'center',
                    px: 0.5,
                  }}
                >
                  {item.badge > 99 ? '99+' : item.badge}
                </Box>
              )}
            </Box>
            {showLabels && (
              <Typography variant="caption" fontSize="0.625rem">
                {item.label}
              </Typography>
            )}
          </NavRailButton>
        </MuiTooltip>
      ))}
    </NavRailRoot>
  );
};
