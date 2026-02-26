#!/bin/bash
set -e

# Koine Backend Restructuring Script
# This script organizes Domain entities into feature folders

echo "🚀 Starting Koine backend restructuring..."
echo "⚠️  Make sure you're in the backend/ directory!"
echo ""

# Verify we're in the right place
if [ ! -f "Koine.sln" ]; then
    echo "❌ Error: Koine.sln not found. Run this from backend/ directory"
    exit 1
fi

# Create backup branch
echo "📦 Creating backup branch..."
git checkout -b backup-backend-before-restructure-$(date +%Y%m%d-%H%M%S)
git checkout -

echo ""
echo "📂 Creating new directory structure in Domain..."

# Navigate to Domain
cd Koine.Domain

# Create feature directories
mkdir -p Entities/Text
mkdir -p Entities/Features
mkdir -p Entities/Flashcards
mkdir -p Entities/Lessons
mkdir -p Entities/Practice
mkdir -p Entities/Vocabulary
mkdir -p Entities/Users
mkdir -p ValueObjects

echo ""
echo "🔀 Moving entities to feature folders..."

# Text-related entities
echo "  → Moving text entities..."
git mv Entities/Book.cs Entities/Text/
git mv Entities/Chapter.cs Entities/Text/
git mv Entities/TranslationUnit.cs Entities/Text/
git mv Entities/Translation.cs Entities/Text/

# Feature entities (grammatical/syntactical)
echo "  → Moving feature entities..."
git mv Entities/GrammaticalFeature.cs Entities/Features/
git mv Entities/SyntacticalFeature.cs Entities/Features/

# Lesson entities (already exist, just move)
echo "  → Moving lesson entities..."
git mv Entities/Lesson.cs Entities/Lessons/
git mv Entities/LessonCompletion.cs Entities/Lessons/
git mv Entities/LessonTrack.cs Entities/Lessons/

# Vocabulary entities
echo "  → Moving vocabulary entities..."
git mv Entities/Vocabulary.cs Entities/Vocabulary/
git mv Entities/VocabularySet.cs Entities/Vocabulary/
git mv Entities/VocabularySetItem.cs Entities/Vocabulary/

# User entities
echo "  → Moving user entities..."
git mv Entities/User.cs Entities/Users/
git mv Entities/UserProgress.cs Entities/Users/
git mv Entities/UserSetting.cs Entities/Users/

# Move ValueObjects (keep existing ones, prepare for new)
echo "  → Organizing value objects..."
# These files may or may not exist, so check first
if [ -f "ValueObjects/FeatureProgress.cs" ]; then
    git mv ValueObjects/FeatureProgress.cs ValueObjects/ 2>/dev/null || true
fi
if [ -f "ValueObjects/TranslationMapping.cs" ]; then
    git mv ValueObjects/TranslationMapping.cs ValueObjects/ 2>/dev/null || true
fi
if [ -f "ValueObjects/UnitNode.cs" ]; then
    git mv ValueObjects/UnitNode.cs ValueObjects/ 2>/dev/null || true
fi
if [ -f "ValueObjects/VocabularyProgress.cs" ]; then
    git mv ValueObjects/VocabularyProgress.cs ValueObjects/ 2>/dev/null || true
fi

cd ..

echo ""
echo "📂 Creating feature directories in Application..."

cd Koine.Application

# Create service feature directories
mkdir -p Services/Text
mkdir -p Services/Flashcards
mkdir -p Services/Lessons
mkdir -p Services/Practice
mkdir -p Services/Vocabulary
mkdir -p Services/Users

# Create DTO feature directories
mkdir -p DTOs/Flashcards
mkdir -p DTOs/Practice

# Create interface feature directories
mkdir -p Interfaces/Flashcards
mkdir -p Interfaces/Practice

echo ""
echo "🔀 Moving services to feature folders..."

# Text services
echo "  → Moving text services..."
git mv Services/ReaderService.cs Services/Text/
git mv Services/TranslationService.cs Services/Text/
git mv Services/TranslationUnitService.cs Services/Text/
git mv Services/ChapterService.cs Services/Text/
git mv Services/BookService.cs Services/Text/

# Feature services (grammatical/syntactical)
echo "  → Moving feature services..."
git mv Services/GrammaticalFeatureService.cs Services/Text/
git mv Services/SyntacticalFeatureService.cs Services/Text/

# Lesson services
echo "  → Moving lesson services..."
git mv Services/LessonService.cs Services/Lessons/
git mv Services/StudyService.cs Services/Lessons/

# Vocabulary services
echo "  → Moving vocabulary services..."
git mv Services/VocabularyService.cs Services/Vocabulary/

# User services
echo "  → Moving user services..."
git mv Services/UserService.cs Services/Users/
git mv Services/ProgressService.cs Services/Users/

# Auth service
echo "  → Moving auth service..."
git mv Services/AuthService.cs Services/Users/

cd ..

echo ""
echo "📂 Creating infrastructure directories..."

cd Koine.Infrastructure

mkdir -p Services/Auth
mkdir -p Services/Storage
mkdir -p Services/Cache

echo "  → Infrastructure directories created (services will be added later)"

cd ..

echo ""
echo "🧹 Cleaning up empty directories..."
# Remove empty directories
find . -type d -empty -delete

echo ""
echo "✅ Backend restructuring complete!"
echo ""
echo "📝 Next steps:"
echo "   1. Update namespace declarations in moved files"
echo "   2. Update using statements where needed"
echo "   3. Run: dotnet build (to check for errors)"
echo "   4. Run tests: dotnet test"
echo "   5. Commit changes: git add -A && git commit -m 'refactor: organize backend into feature folders'"
echo ""
echo "⚠️  You will need to manually update namespaces in moved files:"
echo "   - Book.cs, Chapter.cs, etc. → namespace Koine.Domain.Entities.Text"
echo "   - ReaderService.cs, etc. → namespace Koine.Application.Services.Text"
echo "   - And so on..."
echo ""
echo "💡 Tip: Use your IDE's bulk rename feature or run a find-replace script"
echo ""
echo "⚠️  If something went wrong, checkout the backup branch:"
echo "   git checkout backup-backend-before-restructure-*"