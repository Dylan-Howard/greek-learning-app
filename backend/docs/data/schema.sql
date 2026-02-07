-- ============================================
-- CORE CONTENT TABLES (Normalized)
-- ============================================

CREATE TABLE books (
  id SERIAL PRIMARY KEY,
  title VARCHAR(255) NOT NULL,
  language_code VARCHAR(10) NOT NULL DEFAULT 'grc', -- Ancient Greek
  created_at TIMESTAMP DEFAULT NOW()
);

CREATE TABLE chapters (
  id SERIAL PRIMARY KEY,
  book_id INTEGER REFERENCES books(id) ON DELETE CASCADE,
  chapter_index INTEGER NOT NULL,
  title VARCHAR(255),
  -- Denormalized: store the full unit tree as JSONB for fast retrieval
  unit_tree JSONB NOT NULL,
  created_at TIMESTAMP DEFAULT NOW(),
  UNIQUE(book_id, chapter_index)
);

CREATE INDEX idx_chapters_book ON chapters(book_id, chapter_index);

-- ============================================
-- LINGUISTIC FEATURES (Normalized)
-- ============================================

CREATE TABLE grammatical_features (
  id SERIAL PRIMARY KEY,
  code VARCHAR(20) UNIQUE NOT NULL, -- 'N', 'V', 'NMS', 'PAI', '3S', etc.
  name VARCHAR(100) NOT NULL,
  category VARCHAR(50) NOT NULL, -- 'part_of_speech', 'case', 'gender', 'number', 'tense', 'voice', 'mood', 'person'
  definition TEXT,
  sort_order INTEGER DEFAULT 0
);

CREATE INDEX idx_grammatical_features_code ON grammatical_features(code);
CREATE INDEX idx_grammatical_features_category ON grammatical_features(category);

CREATE TABLE syntactical_features (
  id SERIAL PRIMARY KEY,
  code VARCHAR(20) UNIQUE NOT NULL, -- 'SUBJ', 'OBJ', 'PRED', etc.
  name VARCHAR(100) NOT NULL,
  definition TEXT,
  sort_order INTEGER DEFAULT 0
);

CREATE INDEX idx_syntactical_features_code ON syntactical_features(code);

-- ============================================
-- VOCABULARY (Normalized)
-- ============================================

CREATE TABLE vocabulary (
  id SERIAL PRIMARY KEY,
  root VARCHAR(100) NOT NULL, -- 'λόγος', 'λύω'
  transliteration VARCHAR(100), -- 'logos', 'luo'
  gloss TEXT NOT NULL, -- Basic definition
  part_of_speech VARCHAR(20), -- For quick filtering
  frequency_rank INTEGER, -- Common words = lower number
  created_at TIMESTAMP DEFAULT NOW()
);

CREATE INDEX idx_vocabulary_root ON vocabulary(root);
CREATE INDEX idx_vocabulary_frequency ON vocabulary(frequency_rank);

-- ============================================
-- TRANSLATIONS (Normalized)
-- ============================================

CREATE TABLE translations (
  id SERIAL PRIMARY KEY,
  book_id INTEGER REFERENCES books(id) ON DELETE CASCADE,
  language_code VARCHAR(10) NOT NULL DEFAULT 'en',
  name VARCHAR(100) NOT NULL, -- e.g., "ESV", "NIV", "Literal"
  created_at TIMESTAMP DEFAULT NOW()
);

CREATE TABLE translation_units (
  id SERIAL PRIMARY KEY,
  translation_id INTEGER REFERENCES translations(id) ON DELETE CASCADE,
  chapter_id INTEGER REFERENCES chapters(id) ON DELETE CASCADE,
  
  -- Reference to original unit (stored as path in the unit_tree JSONB)
  -- e.g., "0.1.2" means chapter.unit_tree[0].children[1].children[2]
  original_unit_path VARCHAR(50) NOT NULL,
  
  -- Translation text
  translated_text VARCHAR(500) NOT NULL,
  
  -- Reordering information
  display_order INTEGER NOT NULL,
  
  -- Optional: scope for multi-word units
  -- If this translation covers multiple original units
  scope_start VARCHAR(50),
  scope_end VARCHAR(50),
  
  UNIQUE(translation_id, chapter_id, original_unit_path)
);

CREATE INDEX idx_translation_units_lookup ON translation_units(translation_id, chapter_id);

-- ============================================
-- LESSONS (Normalized)
-- ============================================

CREATE TABLE lessons (
  id SERIAL PRIMARY KEY,
  title VARCHAR(255) NOT NULL,
  lesson_index INTEGER NOT NULL,
  content_markdown TEXT NOT NULL,
  lesson_type VARCHAR(50) NOT NULL, -- 'grammar', 'syntax', 'vocabulary'
  
  -- What this lesson teaches (arrays for fast intersection checks)
  grammatical_feature_ids INTEGER[] DEFAULT '{}',
  syntactical_feature_ids INTEGER[] DEFAULT '{}',
  vocabulary_ids INTEGER[] DEFAULT '{}',
  
  created_at TIMESTAMP DEFAULT NOW()
);

CREATE INDEX idx_lessons_type ON lessons(lesson_type);
CREATE INDEX idx_lessons_index ON lessons(lesson_index);
-- GIN indexes for array containment queries
CREATE INDEX idx_lessons_gram_features ON lessons USING GIN(grammatical_feature_ids);
CREATE INDEX idx_lessons_syn_features ON lessons USING GIN(syntactical_feature_ids);
CREATE INDEX idx_lessons_vocab ON lessons USING GIN(vocabulary_ids);

-- ============================================
-- USERS (Normalized)
-- ============================================

CREATE TABLE users (
  id SERIAL PRIMARY KEY,
  email VARCHAR(255) UNIQUE NOT NULL,
  username VARCHAR(100) UNIQUE NOT NULL,
  password_hash VARCHAR(255) NOT NULL,
  display_name VARCHAR(100),
  created_at TIMESTAMP DEFAULT NOW(),
  last_login TIMESTAMP
);

-- ============================================
-- USER PROGRESS (Denormalized for Performance)
-- ============================================

CREATE TABLE user_progress (
  id SERIAL PRIMARY KEY,
  user_id INTEGER REFERENCES users(id) ON DELETE CASCADE,
  
  -- Completed lessons
  completed_lesson_ids INTEGER[] DEFAULT '{}',
  
  -- Feature mastery: JSONB for flexible storage
  -- Structure: { "feature_id": { "mastery_level": 0-100, "needs_practice": bool, "last_practiced": timestamp } }
  grammatical_feature_progress JSONB DEFAULT '{}',
  syntactical_feature_progress JSONB DEFAULT '{}',
  
  -- Vocabulary mastery
  -- Structure: { "vocab_id": { "mastery_level": 0-100, "needs_practice": bool, "last_practiced": timestamp, "times_seen": int } }
  vocabulary_progress JSONB DEFAULT '{}',
  
  updated_at TIMESTAMP DEFAULT NOW(),
  
  UNIQUE(user_id)
);

CREATE INDEX idx_user_progress_user ON user_progress(user_id);
-- GIN indexes for JSONB queries
CREATE INDEX idx_user_progress_gram ON user_progress USING GIN(grammatical_feature_progress);
CREATE INDEX idx_user_progress_syn ON user_progress USING GIN(syntactical_feature_progress);
CREATE INDEX idx_user_progress_vocab ON user_progress USING GIN(vocabulary_progress);

-- ============================================
-- LESSON COMPLETION LOG (Audit Trail)
-- ============================================

CREATE TABLE lesson_completions (
  id SERIAL PRIMARY KEY,
  user_id INTEGER REFERENCES users(id) ON DELETE CASCADE,
  lesson_id INTEGER REFERENCES lessons(id) ON DELETE CASCADE,
  score INTEGER, -- 0-100 for exercises
  completed_at TIMESTAMP DEFAULT NOW(),
  
  UNIQUE(user_id, lesson_id)
);

CREATE INDEX idx_lesson_completions_user ON lesson_completions(user_id);