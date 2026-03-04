# Koine Development Roadmap

**Project Vision:** A comprehensive Greek and Hebrew language learning platform with NT/OT text reading, SRS flashcards, structured lessons, and practice questions.

**Development Philosophy:** Incremental delivery, feature-complete sprints, dog-food principle (use while building).

---

## Sprint Overview

| Sprint | Duration | Focus | Status |
|--------|----------|-------|--------|
| Sprint 0 | 1 week | Foundation & Architecture | 🟡 In Progress |
| Sprint 1 | 2 weeks | Reader Service (Complete) | ⬜ Planned |
| Sprint 2 | 2 weeks | Auth & Azure Migration | ⬜ Planned |
| Sprint 3 | 2 weeks | Flashcard System (MVP) | ⬜ Planned |
| Sprint 4 | 2 weeks | Flashcard Enhancement | ⬜ Planned |
| Sprint 5 | 2 weeks | Lessons System (Phase 1) | ⬜ Planned |
| Sprint 6 | 2 weeks | Lessons System (Phase 2) | ⬜ Planned |
| Sprint 7 | 2 weeks | Practice Questions (MVP) | ⬜ Planned |
| Sprint 8 | 2 weeks | Practice Questions (Enhancement) | ⬜ Planned |
| Sprint 9 | 2 weeks | Admin Portal | ⬜ Planned |
| Sprint 10 | 2 weeks | Polish & Launch Prep | ⬜ Planned |

**Total Timeline:** ~22 weeks (5.5 months)

---

## Sprint 0: Foundation & Architecture (Week 1)

**Goal:** Set up documentation, restructure codebase, establish architectural patterns

### Documentation
- [x] Create PROJECT_STRUCTURE.md (current vs goal)
- [x] Write ADR-001: Hexagonal Architecture
- [x] Write ADR-002: GraphQL Strategy
- [x] Write ADR-003: Clerk Authentication
- [x] Write ADR-004: Azure SQL Database
- [x] Create system-overview.md with architecture diagrams
- [x] Document feature specifications (reader, flashcards, lessons, practice)

### Backend Organization
- [ ] Create feature folders in Domain (Text, Flashcards, Lessons, Practice)
- [ ] Move existing entities into Text/ folder
- [ ] Create placeholder folders for new features
- [ ] Update namespace references
- [ ] Verify build succeeds

### Development Environment
- [x] Set up local MSSQL container for development (temp, before Azure)
- [ ] Rename frontend directory
- [ ] Generate high-level smoke tests for all API routes
- [ ] Create .env.local.example for frontend
- [ ] Document environment variables needed
- [ ] Verify all services start correctly
- [ ] Update README with setup instructions

**Deliverables:**
- ✅ Restructured, documented codebase
- ✅ Clear architecture decisions recorded
- ✅ Development environment documented

---

## Sprint 1: Reader Service Complete (Weeks 2-3)

**Goal:** Polish existing reader functionality to production-ready state

### Backend Work

#### Text Rendering Fixes
- [ ] Debug text unit rendering issues (from roadmap.md checklist)
- [ ] Verify TranslationUnit display logic
- [ ] Test edge cases (punctuation, formatting)
- [ ] Add integration tests for rendering

#### Vocabulary Sets Enhancement
- [ ] Implement VocabularySets CRUD controller
- [ ] Create vocabulary set seed data:
  - All vocab >50 occurrences in NT
  - All vocab >15 occurrences in NT
  - All NT vocabulary
  - Per-book vocabulary sets (1 John, 2 John, Matthew, etc.)
- [ ] Add vocabulary occurrence counting query
- [ ] Write seed script for vocabulary sets
- [ ] Test vocabulary set endpoints

#### Reader Service Optimization
- [ ] Set the `study` sidebar panel as default and open on desktop.
- [ ] Implement copywrite information store and display in reader footer (muted, small text)
- [ ] Review ReaderService performance
- [ ] Implement caching strategy
- [ ] Optimize database queries (add indexes if needed)
- [ ] Write comprehensive unit tests

### Frontend Work

#### Reader Interface Polish
- [ ] Fix any UI bugs in reader components
- [ ] Improve mobile responsiveness
- [ ] Add keyboard shortcuts (next/prev word, etc.)
- [ ] Polish word details panel
- [ ] Add loading states and error handling

#### Vocabulary Display
- [ ] Connect vocabulary sets to UI
- [ ] Add vocabulary filtering by set
- [ ] Show user progress per set
- [ ] Add "mark as known" functionality
- [ ] Display occurrence count per word

#### Testing & Quality
- [ ] Test reader on all screen sizes
- [ ] Test with various NT books/chapters
- [ ] Verify TTS (text-to-speech) works
- [ ] Load test with concurrent users
- [ ] Fix any performance issues

**Deliverables:**
- ✅ Production-ready reader service
- ✅ Vocabulary sets fully functional
- ✅ No known bugs in reader flow
- ✅ Comprehensive test coverage

**Success Criteria:**
- Can read any NT chapter smoothly
- Vocabulary sets load quickly
- No console errors
- Mobile experience is excellent

---

## Sprint 2: Auth & Azure Migration (Weeks 4-5)

**Goal:** Implement authentication and migrate to Azure SQL

### Azure Setup

#### Database Migration
- [ ] Create Azure SQL Database (Basic tier for dev)
- [ ] Configure firewall rules
- [ ] Update connection strings in appsettings.json
- [ ] Run migrations against Azure DB
- [ ] Verify all seed data migrated
- [ ] Test database connectivity from local dev

#### Blob Storage Setup
- [ ] Create Azure Blob Storage account
- [ ] Create containers (flashcard-images, lesson-videos, etc.)
- [ ] Configure CORS for frontend access
- [ ] Set up CDN (optional, for performance)
- [ ] Test file upload/download

### Clerk Integration

#### Backend Auth
- [ ] Install Clerk.BackendAPI package
- [ ] Create ClerkAuthService in Infrastructure
- [ ] Implement JWT validation middleware
- [ ] Add [Authorize] attribute to controllers
- [ ] Map Clerk user ID to User entity
- [ ] Add migration for ClerkUserId field
- [ ] Test auth flow end-to-end

#### Frontend Auth
- [ ] Install @clerk/nextjs package
- [ ] Add ClerkProvider to root layout
- [ ] Create sign-in/sign-up pages
- [ ] Implement protected route middleware
- [ ] Add user menu with sign-out
- [ ] Test social login (Google, GitHub)

### User Data Tracking

#### Backend
- [ ] Extend User entity with profile fields
- [ ] Implement UserService CRUD operations
- [ ] Add user preferences storage
- [ ] Create user progress tracking tables
- [ ] Add endpoints for user profile management

#### Frontend
- [ ] Create user profile page
- [ ] Add settings page
- [ ] Display user progress stats
- [ ] Implement profile editing
- [ ] Test data persistence

### Offline/Guest Mode
- [ ] Implement localStorage for guest users
- [ ] Add "Sign up to save progress" prompts
- [ ] Migrate guest data to account on sign-up
- [ ] Test offline functionality
- [ ] Handle sync conflicts gracefully

**Deliverables:**
- ✅ Fully functional authentication
- ✅ Database migrated to Azure
- ✅ User data tracking operational
- ✅ Guest mode works offline

**Success Criteria:**
- Users can sign up/in via social login
- User progress persists across sessions
- Database is stable on Azure
- No auth-related bugs

---

## Sprint 3: Flashcard System MVP (Weeks 6-7)

**Goal:** Launch basic flashcard functionality with SRS scheduling

### Backend - Flashcard Domain

#### Entities
- [ ] Create Flashcard entity
  - VocabularyId (FK)
  - ImageUrl
  - FrontText (Greek/Hebrew)
  - BackText (English, parsing info)
  - CreatedAt, UpdatedAt
- [ ] Create FlashcardReview entity
  - FlashcardId (FK)
  - UserId (FK)
  - ReviewedAt
  - Rating (1-5)
  - TimeToAnswer
  - SrsState (JSON - FSRS parameters)
- [ ] Add EF Core configurations
- [ ] Create and run migrations

#### Services
- [ ] Implement FlashcardService
  - CRUD operations
  - GetDueFlashcards(userId)
  - SubmitReview(flashcardId, userId, rating)
- [ ] Implement SrsService (FSRS algorithm)
  - CalculateNextReview(currentState, rating)
  - UpdateSrsParameters(state, rating, elapsed)
  - GetOptimalInterval(state)
- [ ] Add unit tests for SRS algorithm
- [ ] Implement FlashcardImageService
  - UploadImage(flashcardId, imageFile)
  - GetImageUrl(flashcardId)

#### Repositories
- [ ] FlashcardRepository
- [ ] FlashcardReviewRepository
- [ ] Add to UnitOfWork

### Backend - REST API (temporary, before GraphQL)

#### Endpoints
- [ ] POST /api/flashcards (admin only)
- [ ] GET /api/flashcards/due (get due cards for user)
- [ ] POST /api/flashcards/{id}/review (submit review)
- [ ] GET /api/flashcards/stats (user statistics)

### Frontend - Flashcard UI

#### Components
- [ ] Create FlashcardDeck component
  - Swipe/keyboard controls
  - Flip animation
  - Rating buttons (1-5)
- [ ] Create FlashcardItem component
  - Front (Greek/Hebrew + image)
  - Back (English + parsing)
  - Smooth transitions
- [ ] Create FlashcardStats component
  - Cards due today
  - Cards mastered
  - Study streak
  - Time spent

#### Pages
- [ ] /flashcards (main deck view)
- [ ] /flashcards/stats (user statistics)

#### Services
- [ ] Create flashcard API client
- [ ] Implement FSRS logic in frontend (for preview)
- [ ] Add flashcard store (Zustand)

### Seed Data
- [ ] Create seed script for NT vocabulary flashcards
- [ ] Source images for top 500 vocabulary words
- [ ] Bulk upload images to Azure Blob Storage
- [ ] Generate flashcards for all NT vocabulary
- [ ] Test with real data

**Deliverables:**
- ✅ Functional flashcard system with SRS
- ✅ 500+ vocabulary flashcards seeded
- ✅ Mobile-friendly interface

**Success Criteria:**
- Can study flashcards daily
- SRS scheduling works correctly
- Images load quickly
- Progress is saved

---

## Sprint 4: Flashcard Enhancement (Weeks 8-9)

**Goal:** Add advanced features and polish flashcard experience

### Backend Enhancements

#### Advanced Features
- [ ] Implement flashcard collections (user-created decks)
- [ ] Add tagging system (beginner, intermediate, advanced)
- [ ] Implement difficulty estimation
- [ ] Add "bury card" functionality
- [ ] Support custom flashcards (user-created)

#### Analytics
- [ ] Track study sessions
- [ ] Calculate retention rates
- [ ] Generate progress reports
- [ ] Add heatmap data (study frequency)

### Frontend Enhancements

#### UI Polish
- [ ] Add animations (flip, swipe)
- [ ] Improve mobile gestures
- [ ] Add sound effects (optional toggle)
- [ ] Dark mode support
- [ ] Accessibility improvements (screen reader)

#### Features
- [ ] Implement study sessions (timed mode)
- [ ] Add "learn new cards" flow
- [ ] Create review history view
- [ ] Add flashcard search
- [ ] Implement bulk actions

#### Visualization
- [ ] Create progress charts (Chart.js)
- [ ] Add retention heatmap
- [ ] Display mastery levels per vocabulary
- [ ] Show study streaks

### Testing & Optimization
- [ ] Performance testing (1000+ cards)
- [ ] Test SRS algorithm accuracy
- [ ] Optimize image loading (lazy load, blur placeholder)
- [ ] Add error recovery (network failures)
- [ ] Load test concurrent users

**Deliverables:**
- ✅ Enhanced flashcard system
- ✅ Rich analytics and visualizations
- ✅ Excellent UX on all devices

**Success Criteria:**
- Flashcard reviews feel smooth and fast
- Users can track progress easily
- No performance issues with large decks

---

## Sprint 5: Lessons System Phase 1 (Weeks 10-11)

**Goal:** Core lesson infrastructure and content management

### Backend - Lesson Domain

#### Entities Enhancement
- [ ] Extend Lesson entity
  - Add LessonType enum (Grammar, Syntax, Vocabulary, Reading)
  - Add difficulty level
  - Add prerequisites (lesson dependencies)
- [ ] Create LessonModule entity
  - ModuleType (Text, Video, Image, Quiz)
  - Content (markdown for text, URL for media)
  - Order (sort order within lesson)
- [ ] Create LessonPath entity
  - Title, description
  - Lessons (ordered list)
  - IsPublished
- [ ] Update LessonCompletion to track module progress

#### Services
- [ ] Extend LessonService
  - GetLessonWithModules(lessonId)
  - GetUserProgress(userId, lessonId)
  - CompleteModule(userId, moduleId)
  - UnlockNextLesson(userId, pathId)
- [ ] Create LessonPathService
  - GetAllPaths()
  - GetPathProgress(userId, pathId)
  - GetNextLesson(userId, pathId)
- [ ] Implement LessonProgressService
  - TrackModuleCompletion
  - CalculatePathProgress
  - AwardAchievements (optional)

### Backend - Content Management

#### Admin Endpoints
- [ ] POST /api/admin/lessons (create lesson)
- [ ] PUT /api/admin/lessons/{id} (update lesson)
- [ ] POST /api/admin/lessons/{id}/modules (add module)
- [ ] DELETE /api/admin/lessons/{id}/modules/{moduleId}
- [ ] POST /api/admin/lesson-paths (create path)

### Frontend - Lesson Display

#### Components
- [ ] Create LessonCard component (grid/list view)
- [ ] Create LessonProgress component (progress bar)
- [ ] Create LessonModule component (text renderer)
- [ ] Create VideoPlayer component (embedded)
- [ ] Create LessonNavigation (prev/next)

#### Pages
- [ ] /lessons (browse paths)
- [ ] /lessons/[pathSlug] (path overview)
- [ ] /lessons/[pathSlug]/[lessonId] (lesson view)

### Seed Data
- [ ] Create 5 sample lesson paths
  - Beginner Greek Grammar (10 lessons)
  - Greek Alphabet & Pronunciation (5 lessons)
  - Basic Greek Syntax (8 lessons)
  - NT Reading: Gospel of John (12 lessons)
  - Hebrew Alphabet (7 lessons)
- [ ] Write content in markdown
- [ ] Find/create video content (YouTube embeds)
- [ ] Seed database with lessons

**Deliverables:**
- ✅ Functional lesson system
- ✅ 5 lesson paths with content
- ✅ Progress tracking works

**Success Criteria:**
- Users can browse and complete lessons
- Progress persists correctly
- Content displays well on all devices

---

## Sprint 6: Lessons System Phase 2 (Weeks 12-13)

**Goal:** Enhanced lesson features and media support

### Backend Enhancements

#### Video Management
- [ ] Implement video upload to Azure Blob Storage
- [ ] Add video transcoding (optional, for future)
- [ ] Support YouTube embed + custom upload
- [ ] Add video progress tracking (playback position)
- [ ] Generate video thumbnails

#### Rich Content
- [ ] Support inline images in markdown
- [ ] Add code block syntax highlighting (for Greek/Hebrew)
- [ ] Implement interactive exercises (quiz modules)
- [ ] Add downloadable resources (PDFs)

### Frontend Enhancements

#### Video Player
- [ ] Custom video player with controls
- [ ] Track watch progress
- [ ] Support captions/subtitles
- [ ] Offline video caching (PWA, future)

#### Lesson Features
- [ ] Add note-taking functionality
- [ ] Implement bookmarks
- [ ] Add lesson discussions (comments, future)
- [ ] Create lesson certificates (completion badges)

#### Navigation
- [ ] Breadcrumb navigation
- [ ] Lesson sidebar (table of contents)
- [ ] Quick jump to specific modules
- [ ] "Continue where you left off" feature

### Content Creation
- [ ] Write 20+ more lessons
- [ ] Record/source 10+ instructional videos
- [ ] Create downloadable cheat sheets (PDFs)
- [ ] Add practice exercises to lessons

**Deliverables:**
- ✅ Rich lesson experience
- ✅ 30+ lessons across paths
- ✅ 10+ videos embedded

**Success Criteria:**
- Lessons feel engaging and interactive
- Video playback is smooth
- Content is comprehensive

---

## Sprint 7: Practice Questions MVP (Weeks 14-15)

**Goal:** Question generation and basic practice sessions

### Backend - Practice Domain

#### Entities
- [ ] Create Question entity
  - QuestionType (MultipleChoice, FillBlank, Translation)
  - Difficulty level
  - SourceText (Greek/Hebrew passage)
  - QuestionText
  - CorrectAnswer
  - Distractors (for MC)
  - GrammaticalFeatures (tags)
- [ ] Create QuestionTemplate entity
  - Template text (with placeholders)
  - Feature requirements
  - Difficulty mapping
- [ ] Create UserAnswer entity
  - QuestionId, UserId
  - AnswerGiven
  - IsCorrect
  - TimeToAnswer
  - AnsweredAt
- [ ] Create PracticeSession entity
  - UserId, SessionType
  - QuestionsAnswered, Correct, Incorrect
  - StartedAt, CompletedAt

#### Services
- [ ] Implement QuestionGenerationService
  - GenerateQuestionsFromText(textId, count, features)
  - PopulateTemplate(template, textData)
  - ValidateQuestion(question)
- [ ] Implement QuestionBankService
  - GetQuestionsByFeature(feature, difficulty)
  - GetRandomQuestions(count, difficulty)
  - MarkQuestionUsed(userId, questionId)
- [ ] Implement GradingService
  - GradeAnswer(questionId, answer)
  - CalculateScore(session)
  - ProvideExplanation(question, answer)

### Backend - Question Generation Logic

#### Templates
- [ ] Create templates for:
  - Noun case identification (MC)
  - Verb tense identification (MC)
  - Translation (fill-blank)
  - Parsing questions (MC)
  - Word order questions (MC)
- [ ] Implement template population logic
- [ ] Add distractor generation (incorrect but plausible answers)

#### Text Analysis
- [ ] Query texts by grammatical features
- [ ] Extract vocabulary by frequency
- [ ] Filter by difficulty (word rarity, syntax complexity)
- [ ] Generate questions dynamically

### Frontend - Practice UI

#### Components
- [ ] Create QuestionCard component
- [ ] Create MultipleChoice component
- [ ] Create FillBlank component
- [ ] Create GradingFeedback component (instant feedback)
- [ ] Create PracticeStats component

#### Pages
- [ ] /practice (session type selection)
- [ ] /practice/[sessionId] (practice session)
- [ ] /practice/results (session summary)

#### Services
- [ ] Create practice API client
- [ ] Implement grading logic (client-side preview)
- [ ] Add practice session store

### Seed Data
- [ ] Generate 500+ questions across difficulty levels
- [ ] Validate question quality
- [ ] Balance question types
- [ ] Test generation algorithm

**Deliverables:**
- ✅ Functional practice question system
- ✅ 500+ generated questions
- ✅ Multiple question types supported

**Success Criteria:**
- Questions are grammatically correct
- Grading is accurate
- Distractors are plausible
- Instant feedback is helpful

---

## Sprint 8: Practice Enhancement (Weeks 16-17)

**Goal:** Advanced practice features and gamification

### Backend Enhancements

#### Advanced Question Types
- [ ] Implement sentence translation (longer passages)
- [ ] Add dictation mode (audio input)
- [ ] Support parsing diagrams (visual questions)
- [ ] Implement adaptive difficulty

#### Analytics
- [ ] Track question performance metrics
- [ ] Identify weak areas per user
- [ ] Generate personalized practice sessions
- [ ] Calculate mastery per feature

### Frontend Enhancements

#### Practice Sessions
- [ ] Add timed mode
- [ ] Implement streak tracking
- [ ] Add difficulty selector
- [ ] Create custom session builder (choose features)

#### Gamification
- [ ] Add achievement system
- [ ] Implement leaderboards (optional, privacy-aware)
- [ ] Award points/badges
- [ ] Display mastery levels per feature

#### Visualization
- [ ] Create performance charts
- [ ] Add weak area identification
- [ ] Display mastery progress
- [ ] Show improvement over time

### Testing & Optimization
- [ ] Test question generation accuracy
- [ ] Validate grading logic
- [ ] Optimize for large question banks
- [ ] Load test practice sessions

**Deliverables:**
- ✅ Enhanced practice system
- ✅ Adaptive difficulty working
- ✅ Rich analytics and gamification

**Success Criteria:**
- Practice sessions feel engaging
- Adaptive difficulty works well
- Analytics are insightful

---

## Sprint 9: Admin Portal (Weeks 18-19)

**Goal:** Content management tools for admins

### Backend - Admin API

#### Endpoints
- [ ] CRUD for all entities (soft deletes)
- [ ] Bulk operations
- [ ] Content publishing workflow
- [ ] User management (ban, promote, etc.)
- [ ] Analytics dashboard data

### Frontend - Admin Portal

#### Pages
- [ ] /admin (dashboard with metrics)
- [ ] /admin/lessons (lesson management)
- [ ] /admin/flashcards (flashcard management)
- [ ] /admin/questions (question bank management)
- [ ] /admin/users (user management)
- [ ] /admin/vocabulary (vocabulary sets)

#### Features
- [ ] Rich text editor for lessons (Markdown)
- [ ] Image uploader for flashcards
- [ ] Video uploader for lessons
- [ ] Question template editor
- [ ] Bulk import/export (CSV, JSON)

#### UI Components
- [ ] Data tables with sorting/filtering
- [ ] Forms with validation
- [ ] Preview modes
- [ ] Audit logs (who changed what, when)

### Testing
- [ ] Test all CRUD operations
- [ ] Verify soft deletes
- [ ] Test permissions (only admins)
- [ ] Validate data integrity

**Deliverables:**
- ✅ Functional admin portal
- ✅ Content can be managed easily
- ✅ Secure and role-restricted

**Success Criteria:**
- Admins can manage all content
- UI is intuitive and fast
- No data loss or corruption

---

## Sprint 10: Polish & Launch Prep (Weeks 20-22)

**Goal:** Final polish, testing, documentation, launch

### Frontend Polish

#### Public Pages
- [ ] Create landing page (public homepage)
- [ ] Write about page
- [ ] Create resources page (helpful links)
- [ ] Add privacy policy
- [ ] Add terms of service
- [ ] Add licensing page (open source)

#### UX Improvements
- [ ] Add onboarding flow for new users
- [ ] Create guided tours (tooltips)
- [ ] Improve error messages
- [ ] Add loading skeletons everywhere
- [ ] Polish animations and transitions

#### Mobile Optimization
- [ ] Test on iOS Safari
- [ ] Test on Android Chrome
- [ ] Fix mobile-specific bugs
- [ ] Add touch-friendly controls
- [ ] Optimize for performance

### Backend Polish

#### Performance
- [ ] Add Redis caching
- [ ] Optimize database queries (indexes)
- [ ] Implement CDN for static assets
- [ ] Add database connection pooling
- [ ] Load test (100+ concurrent users)

#### GraphQL Migration
- [ ] Set up Hot Chocolate
- [ ] Migrate REST endpoints to GraphQL
- [ ] Add DataLoaders (N+1 prevention)
- [ ] Implement subscriptions (for real-time grading)
- [ ] Deprecate unused REST endpoints

### Testing & QA

#### Automated Testing
- [ ] Increase unit test coverage to 80%+
- [ ] Add integration tests for critical flows
- [ ] Add E2E tests (Playwright)
- [ ] Set up CI/CD pipeline (GitHub Actions)

#### Manual Testing
- [ ] Test all features end-to-end
- [ ] Test on multiple browsers
- [ ] Test on multiple devices
- [ ] Fix all known bugs
- [ ] User acceptance testing (friends/family)

### Documentation

#### User Documentation
- [ ] Write user guide (how to use each feature)
- [ ] Create FAQ page
- [ ] Add video tutorials (optional)
- [ ] Document keyboard shortcuts

#### Developer Documentation
- [ ] Update README (setup, architecture, contribution)
- [ ] Document API (GraphQL schema)
- [ ] Write contribution guide
- [ ] Add code comments where needed
- [ ] Create development roadmap (future features)

### Launch Preparation

#### Deployment
- [ ] Set up production environment (Azure)
- [ ] Configure domain name
- [ ] Set up SSL certificates
- [ ] Configure CDN
- [ ] Set up monitoring (Application Insights)

#### Marketing
- [ ] Create launch announcement
- [ ] Post on social media
- [ ] Submit to directories (ProductHunt, etc.)
- [ ] Reach out to potential users (churches, seminaries)

**Deliverables:**
- ✅ Production-ready application
- ✅ Comprehensive documentation
- ✅ Launched to public

**Success Criteria:**
- No critical bugs
- All features work smoothly
- Documentation is complete
- Ready for users

---

## Post-Launch Roadmap (Future Sprints)

### Phase 2 Features (Months 6-12)
- [ ] Hebrew OT support (parallel to Greek NT)
- [ ] OT Apocrypha (optional)
- [ ] Community features (forums, study groups)
- [ ] Advanced analytics (data-driven insights)
- [ ] Mobile app (React Native, future)
- [ ] Offline mode (PWA enhancements)
- [ ] Social sharing (share progress, invite friends)

### Technical Debt & Optimization
- [ ] Split backend into bounded contexts (if needed)
- [ ] Migrate to microservices (if scale demands)
- [ ] Add Elasticsearch for full-text search
- [ ] Implement event sourcing (if needed)
- [ ] Add ML-based recommendations (personalized study)

---

## Success Metrics

### User Engagement
- Daily Active Users (DAU)
- Average session duration
- Retention rate (D1, D7, D30)
- Feature adoption rates

### Learning Outcomes
- Vocabulary mastery rate
- Lesson completion rate
- Practice question accuracy
- User-reported proficiency gains

### Technical Health
- API response time (<200ms p95)
- Error rate (<1%)
- Uptime (>99.9%)
- Test coverage (>80%)

---

## Risk Mitigation

| Risk | Impact | Likelihood | Mitigation |
|------|--------|------------|------------|
| Solo developer burnout | High | Medium | Take breaks, celebrate milestones, pace sprints |
| Feature creep | Medium | High | Stick to sprint plan, defer nice-to-haves |
| Technical debt accumulation | High | Medium | Allocate 20% time to refactoring, write tests |
| Low user adoption | High | Medium | Dog-food app, get early feedback, iterate |
| Azure costs exceed budget | Medium | Low | Monitor usage, optimize queries, use free tiers |

---

## Notes

- **Sprint flexibility:** Sprints can be adjusted based on progress and priorities
- **Dog-fooding:** Use the app throughout development to catch UX issues early
- **Community involvement:** Open-source from day 1, accept contributions as they come
- **Documentation-first:** Write docs before/during development, not after
- **Test as you go:** Don't defer testing to the end

**Last Updated:** 2025-02-26