// ============================================
// SHOWCASE.TSX - Component Showcase Page
// Suggested file: src/app/showcase/page.tsx
// ============================================

'use client';

import React from 'react';
import {
  Box,
  Typography,
  Stack,
  Container,
  Divider,
  useColorScheme,
  ThemeProvider,
  CssBaseline,
} from '@mui/material';
import {
  LightMode as LightModeIcon,
  DarkMode as DarkModeIcon,
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
import theme from '@/theme/theme';
import {
  Button,
  IconButton,
  ButtonGroup,
  ToggleButtonGroupComponent,
  TextField,
  Select,
  Checkbox,
  RadioGroupComponent,
  Switch,
  Fab,
  Card,
  ProgressCard,
  KoineCard,
  Alert,
  DialogComponent,
  ProseBlock,
  MultipleChoice,
  AcknowledgementButton,
  GreekTextUnit,
  Hero,
  FeatureSection,
  Footer,
  SignInForm,
  SignUpForm,
  AppShell,
  NavRail,
} from '@/components/ui';

/**
 * Dark mode toggle component
 */
const DarkModeToggle: React.FC = () => {
  const { mode, setMode } = useColorScheme();

  return (
    <Box
      sx={{
        position: 'fixed',
        top: 16,
        right: 16,
        zIndex: 1000,
      }}
    >
      <IconButton
        onClick={() => setMode(mode === 'light' ? 'dark' : 'light')}
        tooltip={`Switch to ${mode === 'light' ? 'dark' : 'light'} mode`}
        color="primary"
        size="large"
      >
        {mode === 'light' ? <DarkModeIcon /> : <LightModeIcon />}
      </IconButton>
    </Box>
  );
};

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
  const [selectedAnswer, setSelectedAnswer] = React.useState<string | undefined>();
  const [showFeedback, setShowFeedback] = React.useState(false);
  const [acknowledged, setAcknowledged] = React.useState(false);

  const multipleChoiceOptions = [
    { id: '1', text: 'ἀγαπάω (agapaō) - I love', isCorrect: true },
    { id: '2', text: 'λέγω (legō) - I say' },
    { id: '3', text: 'ἔχω (echō) - I have' },
    { id: '4', text: 'γράφω (graphō) - I write' },
  ];

  return (
    <>
      <DarkModeToggle />
      
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
              <Button variant="contained" loading>
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
              <IconButton tooltip="Delete">
                <DeleteIcon />
              </IconButton>
              <IconButton color="primary" tooltip="Edit">
                <EditIcon />
              </IconButton>
              <IconButton color="success" tooltip="Save">
                <SaveIcon />
              </IconButton>
              <IconButton color="error" tooltip="Delete">
                <DeleteIcon />
              </IconButton>
              <IconButton disabled tooltip="Disabled">
                <DeleteIcon />
              </IconButton>
            </Stack>

            <SubsectionHeader title="Button Group" />
            <ButtonGroup
              variant="outlined"
              buttons={[
                { label: 'One', onClick: () => {} },
                { label: 'Two', onClick: () => {} },
                { label: 'Three', onClick: () => {} },
              ]}
            />

            <SubsectionHeader title="Toggle Buttons" />
            <ToggleButtonGroupComponent
              value={selectedToggle}
              exclusive
              onChange={(e, value) => value && setSelectedToggle(value)}
              options={[
                { value: 'left', label: 'Left', icon: <FormatBoldIcon /> },
                { value: 'center', label: 'Center', icon: <FormatItalicIcon /> },
                { value: 'right', label: 'Right', icon: <FormatUnderlinedIcon /> },
              ]}
            />

            <SubsectionHeader title="Floating Action Button" />
            <Fab color="primary" tooltip="Add">
              <AddIcon />
            </Fab>
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
                showCount
                maxLength={50}
                value={textValue}
                onChange={(e) => setTextValue(e.target.value)}
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
              <Select
                label="Choose an option"
                value={selectValue}
                onChange={(e) => setSelectValue(e.target.value as string)}
                options={[
                  { value: 'option1', label: 'Option 1' },
                  { value: 'option2', label: 'Option 2' },
                  { value: 'option3', label: 'Option 3' },
                  { value: 'option4', label: 'Option 4 (Disabled)', disabled: true },
                ]}
                fullWidth
              />
            </Box>

            <SubsectionHeader title="Checkbox" />
            <Stack spacing={1}>
              <Checkbox
                label="Checkbox with label"
                checked={checkboxChecked}
                onChange={(e) => setCheckboxChecked(e.target.checked)}
              />
              <Checkbox label="Unchecked" />
              <Checkbox label="Disabled" disabled />
              <Checkbox label="Disabled checked" disabled checked />
            </Stack>

            <SubsectionHeader title="Radio Group" />
            <RadioGroupComponent
              value={radioValue}
              onChange={setRadioValue}
              options={[
                { value: 'option1', label: 'Option 1', helperText: 'Helper text' },
                { value: 'option2', label: 'Option 2' },
                { value: 'option3', label: 'Option 3', disabled: true },
              ]}
            />

            <SubsectionHeader title="Switch" />
            <Stack spacing={1}>
              <Switch
                label="Switch with label"
                checked={switchChecked}
                onChange={(e) => setSwitchChecked(e.target.checked)}
              />
              <Switch label="Unchecked" />
              <Switch label="Disabled" disabled />
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
                  description="Begin your journey with the Gospel of John"
                  greekPreview="Ἐν ἀρχῇ ἦν ὁ λόγος..."
                  progress={30}
                  onClick={() => {}}
                  icon={<BookIcon />}
                />

                <KoineCard
                  title="Common Verbs"
                  description="Essential Greek verbs for beginners"
                  progress={60}
                  actions={
                    <Button size="small" variant="contained">
                      Study Now
                    </Button>
                  }
                  icon={<SchoolIcon />}
                />

                <KoineCard
                  title="Completed Lesson"
                  description="Great job! You've mastered this content"
                  progress={100}
                  icon={<AssessmentIcon color="success" />}
                />
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
            <DialogComponent
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
                question="What does the Greek verb 'ἀγαπάω' mean?"
                greekText="Ἀγαπάω τὸν θεόν"
                options={multipleChoiceOptions}
                selectedOption={selectedAnswer}
                showFeedback={showFeedback}
                onSelect={(id) => {
                  setSelectedAnswer(id);
                  setShowFeedback(false);
                }}
              />
              <Box sx={{ p: 2, pt: 0 }}>
                <Button
                  variant="contained"
                  fullWidth
                  onClick={() => setShowFeedback(true)}
                  disabled={!selectedAnswer || showFeedback}
                >
                  Check Answer
                </Button>
              </Box>
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
              <AcknowledgementButton
                text="I understand and agree"
                acknowledged={acknowledged}
                onClick={() => setAcknowledged(!acknowledged)}
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
                <SignInForm
                  onSubmit={(email, password) => {
                    alert(`Sign in: ${email}`);
                  }}
                  signUpLink="#"
                  forgotPasswordLink="#"
                />
              </Box>

              <Box>
                <SubsectionHeader title="Sign Up Form" />
                <SignUpForm
                  onSubmit={(name, email, password) => {
                    alert(`Sign up: ${name}, ${email}`);
                  }}
                  signInLink="#"
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
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <ShowcaseContent />
    </ThemeProvider>
  );
}
