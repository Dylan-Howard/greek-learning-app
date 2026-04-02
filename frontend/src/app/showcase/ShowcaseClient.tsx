// ============================================
// SHOWCASE.TSX - Component Showcase Page
// Suggested file: src/app/showcase/page.tsx
// ============================================

'use client';

import React from 'react';
import {
  Box,
  Button,
  ButtonGroup,
  Checkbox,
  CircularProgress,
  Typography,
  Stack,
  Container,
  Divider,
  Fab,
  FormControl,
  FormControlLabel,
  IconButton,
  InputLabel,
  MenuItem,
  Radio,
  RadioGroup,
  Select,
  Switch,
  TextField,
  ToggleButton,
  ToggleButtonGroup,
  Tooltip,
} from '@mui/material';
import {
  Send as SendIcon,
  Delete as DeleteIcon,
  Edit as EditIcon,
  Save as SaveIcon,
  Add as AddIcon,
  Remove as RemoveIcon,
  FormatBold as FormatBoldIcon,
  FormatItalic as FormatItalicIcon,
  FormatUnderlined as FormatUnderlinedIcon,
  Home as HomeIcon,
  Book as BookIcon,
  School as SchoolIcon,
  Assessment as AssessmentIcon,
  Twitter as TwitterIcon,
  Facebook as FacebookIcon,
  Instagram as InstagramIcon,
} from '@mui/icons-material';
import { LoginForm, SignUpForm } from '@/components/auth/AuthForms';
import { MultipleChoice, ConfirmCheckbox } from '@/components/lessons/LessonBlocks';
import { Alert } from '@/components/shared/Alert';
import { Card } from '@/components/shared/Card';
import { Dialog } from '@/components/shared/Dialog';
import { KoineCard } from '@/components/shared/KoineCard';
import { ProgressCard } from '@/components/shared/ProgressCard';
import { ProseBlock } from '@/components/shared/ProseBlock';
import { GreekTextUnit } from '@/components/features/reader';
import { Hero, FeatureSection, Footer } from '@/components/features/landing';
import { AppShell, NavRail } from '@/components/layout';


/**
 * Section header component
 */
const SectionHeader: React.FC<{ title: string; description?: string }> = ({
  title,
  description,
}) => (
  <Box sx={{ mb: 4 }}>
    <Typography variant="h2" gutterBottom>
      {title}
    </Typography>
    {description && (
      <Typography variant="body1" color="text.secondary">
        {description}
      </Typography>
    )}
  </Box>
);

/**
 * Subsection header component
 */
const SubsectionHeader: React.FC<{ title: string }> = ({ title }) => (
  <Typography variant="h4" sx={{ mt: 4, mb: 2 }}>
    {title}
  </Typography>
);

/**
 * Main showcase component
 */
const ShowcaseContent: React.FC = () => {
  const [selectedToggle, setSelectedToggle] = React.useState('left');
  const [textValue, setTextValue] = React.useState('');
  const [selectValue, setSelectValue] = React.useState('');
  const [checkboxChecked, setCheckboxChecked] = React.useState(false);
  const [radioValue, setRadioValue] = React.useState('option1');
  const [switchChecked, setSwitchChecked] = React.useState(false);
  const [dialogOpen, setDialogOpen] = React.useState(false);
  const [acknowledged, setAcknowledged] = React.useState(false);

  const multipleChoiceOptions = [
    { id: '1', text: 'ἀγαπάω (agapaō) - I love', isCorrect: true },
    { id: '2', text: 'λέγω (legō) - I say' },
    { id: '3', text: 'ἔχω (echō) - I have' },
    { id: '4', text: 'γράφω (graphō) - I write' },
  ];
  const multipleChoiceCorrectId = multipleChoiceOptions.find((option) => option.isCorrect)?.id ?? '1';

  return (
    <>
      <Container maxWidth="lg" sx={{ py: 6 }}>
        {/* Title Section */}
        <Box sx={{ textAlign: 'center', mb: 8 }}>
          <Typography variant="h1" gutterBottom>
            Koine Greek Design System
          </Typography>
          <Typography variant="h3" color="text.secondary" fontWeight={400}>
            Complete component library showcase
          </Typography>
        </Box>

        <Stack spacing={8} divider={<Divider />}>
          {/* BUTTONS SECTION */}
          <Box>
            <SectionHeader
              title="Buttons"
              description="Various button styles for different use cases"
            />

            <SubsectionHeader title="Primary Buttons" />
            <Stack direction="row" spacing={2} flexWrap="wrap">
              <Button variant="contained" color="primary">
                Primary
              </Button>
              <Button variant="contained" color="secondary">
                Secondary
              </Button>
              <Button variant="contained" color="success">
                Success
              </Button>
              <Button variant="contained" color="error">
                Error
              </Button>
              <Button variant="contained" color="warning">
                Warning
              </Button>
              <Button variant="contained" disabled>
                Disabled
              </Button>
              <Button variant="contained" disabled startIcon={<CircularProgress size={16} />}>
                Loading
              </Button>
            </Stack>

            <SubsectionHeader title="Outlined Buttons" />
            <Stack direction="row" spacing={2} flexWrap="wrap">
              <Button variant="outlined" color="primary">
                Primary
              </Button>
              <Button variant="outlined" color="secondary">
                Secondary
              </Button>
              <Button variant="outlined" startIcon={<SendIcon />}>
                With Icon
              </Button>
              <Button variant="outlined" endIcon={<SendIcon />}>
                With Icon
              </Button>
            </Stack>

            <SubsectionHeader title="Text Buttons" />
            <Stack direction="row" spacing={2} flexWrap="wrap">
              <Button variant="text">Default</Button>
              <Button variant="text" color="primary">
                Primary
              </Button>
              <Button variant="text" color="error">
                Error
              </Button>
            </Stack>

            <SubsectionHeader title="Button Sizes" />
            <Stack direction="row" spacing={2} alignItems="center" flexWrap="wrap">
              <Button size="small">Small</Button>
              <Button size="medium">Medium</Button>
              <Button size="large">Large</Button>
            </Stack>

            <SubsectionHeader title="Icon Buttons" />
            <Stack direction="row" spacing={2} flexWrap="wrap">
              <Tooltip title="Delete" arrow>
                <IconButton aria-label="Delete">
                  <DeleteIcon />
                </IconButton>
              </Tooltip>
              <Tooltip title="Edit" arrow>
                <IconButton color="primary" aria-label="Edit">
                  <EditIcon />
                </IconButton>
              </Tooltip>
              <Tooltip title="Save" arrow>
                <IconButton color="success" aria-label="Save">
                  <SaveIcon />
                </IconButton>
              </Tooltip>
              <Tooltip title="Delete" arrow>
                <IconButton color="error" aria-label="Delete">
                  <DeleteIcon />
                </IconButton>
              </Tooltip>
              <Tooltip title="Disabled" arrow>
                <span>
                  <IconButton disabled aria-label="Disabled">
                    <DeleteIcon />
                  </IconButton>
                </span>
              </Tooltip>
            </Stack>

            <SubsectionHeader title="Button Group" />
            <ButtonGroup variant="outlined">
              <Button>One</Button>
              <Button>Two</Button>
              <Button>Three</Button>
            </ButtonGroup>

            <SubsectionHeader title="Toggle Buttons" />
            <ToggleButtonGroup
              value={selectedToggle}
              exclusive
              onChange={(_, value) => value && setSelectedToggle(value)}
            >
              <ToggleButton value="left">
                <FormatBoldIcon fontSize="small" sx={{ mr: 0.5 }} />
                Left
              </ToggleButton>
              <ToggleButton value="center">
                <FormatItalicIcon fontSize="small" sx={{ mr: 0.5 }} />
                Center
              </ToggleButton>
              <ToggleButton value="right">
                <FormatUnderlinedIcon fontSize="small" sx={{ mr: 0.5 }} />
                Right
              </ToggleButton>
            </ToggleButtonGroup>

            <SubsectionHeader title="Floating Action Button" />
            <Tooltip title="Add" arrow>
              <Fab color="primary" aria-label="Add">
                <AddIcon />
              </Fab>
            </Tooltip>
          </Box>

          {/* INPUTS SECTION */}
          <Box>
            <SectionHeader
              title="Form Inputs"
              description="Input components for data collection"
            />

            <SubsectionHeader title="Text Fields" />
            <Stack spacing={3} maxWidth={400}>
              <TextField
                label="Standard"
                value={textValue}
                onChange={(e) => setTextValue(e.target.value)}
                helperText="Helper text"
              />
              <TextField
                label="With Character Count"
                value={textValue}
                onChange={(e) => setTextValue(e.target.value)}
                inputProps={{ maxLength: 50 }}
                helperText={`${textValue.length}/50`}
              />
              <TextField label="Required" required />
              <TextField label="Error State" error helperText="Error message" />
              <TextField label="Disabled" disabled value="Disabled value" />
              <TextField
                label="Multiline"
                multiline
                rows={4}
                placeholder="Enter multiple lines..."
              />
            </Stack>

            <SubsectionHeader title="Select" />
            <Box maxWidth={400}>
              <FormControl fullWidth size="small">
                <InputLabel id="showcase-select-label">Choose an option</InputLabel>
                <Select
                  labelId="showcase-select-label"
                  label="Choose an option"
                  value={selectValue}
                  onChange={(e) => setSelectValue(e.target.value)}
                >
                  <MenuItem value="option1">Option 1</MenuItem>
                  <MenuItem value="option2">Option 2</MenuItem>
                  <MenuItem value="option3">Option 3</MenuItem>
                  <MenuItem value="option4" disabled>Option 4 (Disabled)</MenuItem>
                </Select>
              </FormControl>
            </Box>

            <SubsectionHeader title="Checkbox" />
            <Stack spacing={1}>
              <FormControlLabel
                control={<Checkbox checked={checkboxChecked} onChange={(e) => setCheckboxChecked(e.target.checked)} />}
                label="Checkbox with label"
              />
              <FormControlLabel control={<Checkbox />} label="Unchecked" />
              <FormControlLabel control={<Checkbox disabled />} label="Disabled" />
              <FormControlLabel control={<Checkbox disabled checked />} label="Disabled checked" />
            </Stack>

            <SubsectionHeader title="Radio Group" />
            <RadioGroup value={radioValue} onChange={(e) => setRadioValue(e.target.value)}>
              <FormControlLabel value="option1" control={<Radio />} label="Option 1" />
              <Typography variant="caption" color="text.secondary" sx={{ ml: 4, mt: -0.5 }}>
                Helper text
              </Typography>
              <FormControlLabel value="option2" control={<Radio />} label="Option 2" />
              <FormControlLabel value="option3" control={<Radio />} label="Option 3" disabled />
            </RadioGroup>

            <SubsectionHeader title="Switch" />
            <Stack spacing={1}>
              <FormControlLabel
                control={<Switch checked={switchChecked} onChange={(e) => setSwitchChecked(e.target.checked)} />}
                label="Switch with label"
              />
              <FormControlLabel control={<Switch />} label="Unchecked" />
              <FormControlLabel control={<Switch disabled />} label="Disabled" />
            </Stack>
          </Box>

          {/* CARDS SECTION */}
          <Box>
            <SectionHeader
              title="Cards"
              description="Card components for content organization"
            />

            <SubsectionHeader title="Basic Cards" />
            <Stack spacing={3}>
              <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', md: 'repeat(3, 1fr)' }, gap: 3 }}>
                <Card title="Card Title" subtitle="Card subtitle">
                  <Typography>
                    This is the card content. Cards are used to group related
                    information.
                  </Typography>
                </Card>

                <Card
                  title="With Action"
                  headerAction={<IconButton><EditIcon /></IconButton>}
                >
                  <Typography>Card with header action button.</Typography>
                </Card>

                <Card
                  title="Hoverable Card"
                  hoverable
                  onClick={() => alert('Card clicked')}
                >
                  <Typography>Click me! This card has hover effects.</Typography>
                </Card>
              </Box>

              <SubsectionHeader title="Progress Card" />
              <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', md: 'repeat(2, 1fr)' }, gap: 3 }}>
                <ProgressCard
                  title="Lesson Progress"
                  subtitle="John 1:1-14"
                  progress={75}
                  progressLabel="Completion"
                  progressColor="success"
                >
                  <Typography variant="body2">
                    You've completed 75% of this lesson. Keep going!
                  </Typography>
                </ProgressCard>

                <ProgressCard
                  title="Vocabulary Mastery"
                  subtitle="Common Verbs"
                  progress={45}
                  progressLabel="Mastered"
                  progressColor="primary"
                >
                  <Typography variant="body2">
                    Master 20 more words to complete this set.
                  </Typography>
                </ProgressCard>
              </Box>

              <SubsectionHeader title="Koine Card" />
              <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', md: 'repeat(3, 1fr)' }, gap: 3 }}>
                <KoineCard
                  title="Gospel of John"
                  subtitle="Begin your journey with the Gospel of John"
                  headerAction={<BookIcon />}
                  onClick={() => {}}
                >
                  <Typography variant="body2" sx={{ fontFamily: '"Noto Serif", serif' }}>
                    Ἐν ἀρχῇ ἦν ὁ λόγος...
                  </Typography>
                  <Typography variant="caption" color="text.secondary" sx={{ mt: 1, display: 'block' }}>
                    Progress: 30%
                  </Typography>
                </KoineCard>

                <KoineCard
                  title="Common Verbs"
                  subtitle="Essential Greek verbs for beginners"
                  headerAction={<SchoolIcon />}
                  actions={(
                    <Button size="small" variant="contained">
                      Study Now
                    </Button>
                  )}
                >
                  <Typography variant="body2">
                    Practice daily to reach mastery.
                  </Typography>
                  <Typography variant="caption" color="text.secondary" sx={{ mt: 1, display: 'block' }}>
                    Progress: 60%
                  </Typography>
                </KoineCard>

                <KoineCard
                  title="Completed Lesson"
                  subtitle="Great job! You've mastered this content"
                  headerAction={<AssessmentIcon color="success" />}
                >
                  <Typography variant="body2">
                    You finished this track.
                  </Typography>
                  <Typography variant="caption" color="text.secondary" sx={{ mt: 1, display: 'block' }}>
                    Progress: 100%
                  </Typography>
                </KoineCard>
              </Box>
            </Stack>
          </Box>

          {/* FEEDBACK SECTION */}
          <Box>
            <SectionHeader
              title="Feedback Components"
              description="Components for user feedback and notifications"
            />

            <SubsectionHeader title="Alerts" />
            <Stack spacing={2}>
              <Alert severity="success" message="This is a success alert" closable />
              <Alert severity="info" message="This is an info alert" closable />
              <Alert severity="warning" message="This is a warning alert" closable />
              <Alert severity="error" message="This is an error alert" closable />
            </Stack>

            <SubsectionHeader title="Dialog" />
            <Button onClick={() => setDialogOpen(true)}>Open Dialog</Button>
            <Dialog
              open={dialogOpen}
              onClose={() => setDialogOpen(false)}
              title="Dialog Title"
              dialogContent={
                <Typography>
                  This is a dialog. It can contain any content you need.
                </Typography>
              }
              actions={
                <>
                  <Button onClick={() => setDialogOpen(false)}>Cancel</Button>
                  <Button
                    variant="contained"
                    onClick={() => setDialogOpen(false)}
                  >
                    Confirm
                  </Button>
                </>
              }
              showClose
            />
          </Box>

          {/* EDUCATIONAL COMPONENTS */}
          <Box>
            <SectionHeader
              title="Educational Components"
              description="Specialized components for learning"
            />

            <SubsectionHeader title="Multiple Choice Question" />
            <Card sx={{ maxWidth: 600 }}>
              <MultipleChoice
                id="showcase-mc"
                question="What does the Greek verb 'ἀγαπάω' mean?"
                options={multipleChoiceOptions.map((option) => ({ id: option.id, text: option.text }))}
                correctId={multipleChoiceCorrectId}
              />
            </Card>

            <SubsectionHeader title="Greek Text Unit" />
            <Box sx={{ p: 3, border: '1px solid', borderColor: 'border.default', borderRadius: 1 }}>
              <Stack direction="row" spacing={1} flexWrap="wrap">
                <GreekTextUnit greekText="Ἐν" helpText="In" />
                <GreekTextUnit greekText="ἀρχῇ" helpText="beginning" />
                <GreekTextUnit greekText="ἦν" helpText="was" />
                <GreekTextUnit
                  greekText="ὁ"
                  helpText="the"
                  highlighted
                  onClick={() => alert('Word clicked')}
                />
                <GreekTextUnit greekText="λόγος" helpText="word" onClick={() => {}} />
              </Stack>
            </Box>

            <SubsectionHeader title="Acknowledgement Button" />
            <Box maxWidth={400}>
              <ConfirmCheckbox
                id="acknowledge"
                label="I understand and agree"
                checked={acknowledged}
                onChange={(_, checked) => setAcknowledged(checked)}
              />
            </Box>
          </Box>

          {/* CONTENT COMPONENTS */}
          <Box>
            <SectionHeader
              title="Content Components"
              description="Components for rich content display"
            />

            <SubsectionHeader title="Prose Block" />
            <Card>
              <ProseBlock>
                <h2>About Koine Greek</h2>
                <p>
                  Koine Greek (κοινὴ διάλεκτος, "the common dialect") was the common
                  supra-regional form of Greek spoken and written during the Hellenistic
                  period, the Roman Empire, and the early Byzantine Empire.
                </p>
                <h3>Historical Significance</h3>
                <p>
                  It evolved from the spread of Greek following the conquests of Alexander
                  the Great in the 4th century BC. Koine Greek served as:
                </p>
                <ul>
                  <li>The lingua franca of the Mediterranean world</li>
                  <li>The language of the New Testament</li>
                  <li>The medium for early Christian literature</li>
                </ul>
                <blockquote>
                  The Greek of the New Testament is the Greek which was spoken in the
                  streets of Jerusalem and Athens.
                </blockquote>
              </ProseBlock>
            </Card>
          </Box>

          {/* LANDING PAGE COMPONENTS */}
          <Box>
            <SectionHeader
              title="Landing Page Components"
              description="Components for marketing and landing pages"
            />

            <SubsectionHeader title="Hero Section" />
            <Card>
              <Hero
                title="Learn Biblical Greek"
                subtitle="Master Koine Greek with interactive lessons and AI-powered tools"
                primaryAction={{
                  label: 'Start Learning',
                  onClick: () => alert('Start learning'),
                }}
                secondaryAction={{
                  label: 'Learn More',
                  onClick: () => alert('Learn more'),
                }}
              />
            </Card>

            <SubsectionHeader title="Feature Section" />
            <Card>
              <FeatureSection
                title="Why Choose Our Platform"
                features={[
                  {
                    icon: <BookIcon fontSize="large" />,
                    title: 'Interactive Reading',
                    description: 'Read Greek texts with instant help and translations',
                  },
                  {
                    icon: <SchoolIcon fontSize="large" />,
                    title: 'Structured Lessons',
                    description: 'Follow a proven curriculum from basics to advanced',
                  },
                  {
                    icon: <AssessmentIcon fontSize="large" />,
                    title: 'Track Progress',
                    description: 'Monitor your learning journey with detailed analytics',
                  },
                ]}
              />
            </Card>

            <SubsectionHeader title="Footer" />
            <Footer
              sections={[
                {
                  title: 'Product',
                  links: [
                    { label: 'Features', href: '#' },
                    { label: 'Pricing', href: '#' },
                    { label: 'Resources', href: '#' },
                  ],
                },
                {
                  title: 'Company',
                  links: [
                    { label: 'About', href: '#' },
                    { label: 'Blog', href: '#' },
                    { label: 'Contact', href: '#' },
                  ],
                },
                {
                  title: 'Legal',
                  links: [
                    { label: 'Privacy', href: '#' },
                    { label: 'Terms', href: '#' },
                    { label: 'Cookies', href: '#' },
                  ],
                },
              ]}
              copyright="© 2024 Koine Greek Learning. All rights reserved."
              socialLinks={[
                { icon: <TwitterIcon />, href: '#', label: 'Twitter' },
                { icon: <FacebookIcon />, href: '#', label: 'Facebook' },
                { icon: <InstagramIcon />, href: '#', label: 'Instagram' },
              ]}
            />
          </Box>

          {/* AUTH COMPONENTS */}
          <Box>
            <SectionHeader
              title="Authentication Components"
              description="Sign in and sign up forms"
            />

            <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', md: 'repeat(2, 1fr)' }, gap: 4 }}>
              <Box>
                <SubsectionHeader title="Sign In Form" />
                <LoginForm
                  onSubmit={async (email, password) => {
                    alert(`Sign in: ${email} / ${password}`);
                  }}
                  onSignUp={() => {}}
                />
              </Box>

              <Box>
                <SubsectionHeader title="Sign Up Form" />
                <SignUpForm
                  onSubmit={async (email, password) => {
                    alert(`Sign up: ${email} / ${password}`);
                  }}
                  onLogin={() => {}}
                />
              </Box>
            </Box>
          </Box>

          {/* NAVIGATION COMPONENTS */}
          <Box>
            <SectionHeader
              title="Navigation Components"
              description="Navigation patterns and components"
            />

            <SubsectionHeader title="Navigation Rail" />
            <Box sx={{ position: 'relative', height: 400, border: '1px solid', borderColor: 'border.default', borderRadius: 1 }}>
              <NavRail
                items={[
                  { icon: <HomeIcon />, label: 'Home', href: '#' },
                  { icon: <BookIcon />, label: 'Reader', href: '#', badge: 3 },
                  { icon: <SchoolIcon />, label: 'Lessons', href: '#' },
                  { icon: <AssessmentIcon />, label: 'Progress', href: '#' },
                ]}
                activeIndex={1}
                showLabels
              />
              <Box sx={{ ml: { xs: 0, md: 10 }, p: 3 }}>
                <Typography variant="h4">Main Content Area</Typography>
                <Typography variant="body2" color="text.secondary">
                  The navigation rail is fixed on desktop (left) and mobile (bottom).
                </Typography>
              </Box>
            </Box>

            <SubsectionHeader title="App Shell" />
            <Typography variant="body2" color="text.secondary" paragraph>
              The App Shell component provides a complete application layout with
              navigation drawer, app bar, and main content area. Check the
              implementation in the components file for full details.
            </Typography>
          </Box>
        </Stack>

        {/* Footer Note */}
        <Box sx={{ mt: 8, p: 4, textAlign: 'center', bgcolor: 'canvas.subtle', borderRadius: 2 }}>
          <Typography variant="h4" gutterBottom>
            Design System Complete
          </Typography>
          <Typography variant="body1" color="text.secondary">
            This showcase demonstrates all components in the Koine Greek Learning App
            design system. Toggle between light and dark modes using the button in the
            top right corner.
          </Typography>
        </Box>
      </Container>
    </>
  );
};

/**
 * Main showcase page with theme provider
 */
export default function ShowcasePage() {
  return (
    <ShowcaseContent />
  );
}
