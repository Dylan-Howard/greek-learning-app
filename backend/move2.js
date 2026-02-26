#!/usr/bin/env node

/**
 * Koine Backend Namespace Fixer
 * 
 * Updates C# namespaces after backend restructuring
 * Run this after the restructure-backend.sh script
 * 
 * Usage: node fix-namespaces.js
 */

const fs = require('fs');
const path = require('path');

// Namespace mappings based on new directory structure
const NAMESPACE_MAPPINGS = {
  // Domain.Entities - Text feature
  'Koine.Domain/Entities/Text/Book.cs': 'Koine.Domain.Entities.Text',
  'Koine.Domain/Entities/Text/Chapter.cs': 'Koine.Domain.Entities.Text',
  'Koine.Domain/Entities/Text/TranslationUnit.cs': 'Koine.Domain.Entities.Text',
  'Koine.Domain/Entities/Text/Translation.cs': 'Koine.Domain.Entities.Text',
  
  // Domain.Entities - Features
  'Koine.Domain/Entities/Features/GrammaticalFeature.cs': 'Koine.Domain.Entities.Features',
  'Koine.Domain/Entities/Features/SyntacticalFeature.cs': 'Koine.Domain.Entities.Features',
  
  // Domain.Entities - Lessons
  'Koine.Domain/Entities/Lessons/Lesson.cs': 'Koine.Domain.Entities.Lessons',
  'Koine.Domain/Entities/Lessons/LessonCompletion.cs': 'Koine.Domain.Entities.Lessons',
  'Koine.Domain/Entities/Lessons/LessonTrack.cs': 'Koine.Domain.Entities.Lessons',
  
  // Domain.Entities - Vocabulary
  'Koine.Domain/Entities/Vocabulary/Vocabulary.cs': 'Koine.Domain.Entities.Vocabulary',
  'Koine.Domain/Entities/Vocabulary/VocabularySet.cs': 'Koine.Domain.Entities.Vocabulary',
  'Koine.Domain/Entities/Vocabulary/VocabularySetItem.cs': 'Koine.Domain.Entities.Vocabulary',
  
  // Domain.Entities - Users
  'Koine.Domain/Entities/Users/User.cs': 'Koine.Domain.Entities.Users',
  'Koine.Domain/Entities/Users/UserProgress.cs': 'Koine.Domain.Entities.Users',
  'Koine.Domain/Entities/Users/UserSetting.cs': 'Koine.Domain.Entities.Users',
  
  // Application.Services - Text
  'Koine.Application/Services/Text/ReaderService.cs': 'Koine.Application.Services.Text',
  'Koine.Application/Services/Text/TranslationService.cs': 'Koine.Application.Services.Text',
  'Koine.Application/Services/Text/TranslationUnitService.cs': 'Koine.Application.Services.Text',
  'Koine.Application/Services/Text/ChapterService.cs': 'Koine.Application.Services.Text',
  'Koine.Application/Services/Text/BookService.cs': 'Koine.Application.Services.Text',
  'Koine.Application/Services/Text/GrammaticalFeatureService.cs': 'Koine.Application.Services.Text',
  'Koine.Application/Services/Text/SyntacticalFeatureService.cs': 'Koine.Application.Services.Text',
  
  // Application.Services - Lessons
  'Koine.Application/Services/Lessons/LessonService.cs': 'Koine.Application.Services.Lessons',
  'Koine.Application/Services/Lessons/StudyService.cs': 'Koine.Application.Services.Lessons',
  
  // Application.Services - Vocabulary
  'Koine.Application/Services/Vocabulary/VocabularyService.cs': 'Koine.Application.Services.Vocabulary',
  
  // Application.Services - Users
  'Koine.Application/Services/Users/UserService.cs': 'Koine.Application.Services.Users',
  'Koine.Application/Services/Users/ProgressService.cs': 'Koine.Application.Services.Users',
  'Koine.Application/Services/Users/AuthService.cs': 'Koine.Application.Services.Users',
};

// Using statement updates (for files that reference moved entities)
const USING_UPDATES = [
  // Update references to old namespaces
  { old: 'using Koine.Domain.Entities;', new: 'using Koine.Domain.Entities.Text;\nusing Koine.Domain.Entities.Features;\nusing Koine.Domain.Entities.Lessons;\nusing Koine.Domain.Entities.Vocabulary;\nusing Koine.Domain.Entities.Users;' },
  { old: 'using Koine.Application.Services;', new: 'using Koine.Application.Services.Text;\nusing Koine.Application.Services.Lessons;\nusing Koine.Application.Services.Vocabulary;\nusing Koine.Application.Services.Users;' },
];

function updateNamespace(filePath, newNamespace) {
  let content = fs.readFileSync(filePath, 'utf8');
  let modified = false;
  
  // Update namespace declaration
  const namespacePattern = /namespace\s+[\w.]+\s*[;{]/;
  if (namespacePattern.test(content)) {
    const match = content.match(namespacePattern);
    const oldDeclaration = match[0];
    let newDeclaration;
    
    // Detect if using file-scoped or block-scoped namespace
    if (oldDeclaration.endsWith(';')) {
      // File-scoped namespace (C# 10+)
      newDeclaration = `namespace ${newNamespace};`;
    } else {
      // Block-scoped namespace (traditional)
      newDeclaration = `namespace ${newNamespace}`;
    }
    
    content = content.replace(oldDeclaration, newDeclaration);
    modified = true;
  }
  
  if (modified) {
    fs.writeFileSync(filePath, content, 'utf8');
  }
  
  return modified;
}

function updateUsings(filePath) {
  let content = fs.readFileSync(filePath, 'utf8');
  let modified = false;
  
  for (const { old, new: newUsing } of USING_UPDATES) {
    if (content.includes(old)) {
      content = content.replace(old, newUsing);
      modified = true;
    }
  }
  
  if (modified) {
    fs.writeFileSync(filePath, content, 'utf8');
  }
  
  return modified;
}

function walkDirectory(dir, callback) {
  if (!fs.existsSync(dir)) {
    return;
  }
  
  const files = fs.readdirSync(dir);
  
  for (const file of files) {
    const filePath = path.join(dir, file);
    const stat = fs.statSync(filePath);
    
    if (stat.isDirectory()) {
      walkDirectory(filePath, callback);
    } else if (filePath.endsWith('.cs')) {
      callback(filePath);
    }
  }
}

function main() {
  console.log('🔧 Starting namespace fixer...\n');
  
  const backendDir = process.cwd();
  
  if (!fs.existsSync(path.join(backendDir, 'Koine.sln'))) {
    console.error('❌ Error: Koine.sln not found');
    console.error('   Make sure you run this from the backend/ directory');
    process.exit(1);
  }
  
  let filesModified = 0;
  
  // Step 1: Update namespaces in moved files
  console.log('Step 1: Updating namespaces in moved files...\n');
  
  for (const [relativeFilePath, newNamespace] of Object.entries(NAMESPACE_MAPPINGS)) {
    const filePath = path.join(backendDir, relativeFilePath);
    
    if (fs.existsSync(filePath)) {
      const wasModified = updateNamespace(filePath, newNamespace);
      
      if (wasModified) {
        filesModified++;
        console.log(`✓ Updated namespace in ${relativeFilePath}`);
      }
    }
  }
  
  // Step 2: Update using statements across entire codebase
  console.log('\nStep 2: Updating using statements across codebase...\n');
  
  const projectDirs = [
    'Koine.Domain',
    'Koine.Application',
    'Koine.Infrastructure',
    'Koine.API',
    'Koine.Tests'
  ];
  
  let usingFilesModified = 0;
  
  for (const projectDir of projectDirs) {
    const fullPath = path.join(backendDir, projectDir);
    
    if (!fs.existsSync(fullPath)) {
      continue;
    }
    
    walkDirectory(fullPath, (filePath) => {
      const wasModified = updateUsings(filePath);
      
      if (wasModified) {
        usingFilesModified++;
        const relativePath = path.relative(backendDir, filePath);
        console.log(`✓ Updated usings in ${relativePath}`);
      }
    });
  }
  
  console.log('\n📊 Summary:');
  console.log(`   Namespaces updated: ${filesModified}`);
  console.log(`   Using statements updated: ${usingFilesModified}`);
  
  if (filesModified > 0 || usingFilesModified > 0) {
    console.log('\n✅ Namespace fixing complete!');
    console.log('\n📝 Next steps:');
    console.log('   1. Run: dotnet build');
    console.log('   2. Fix any remaining compilation errors manually');
    console.log('   3. Run: dotnet test');
    console.log('   4. Commit changes');
  } else {
    console.log('\n✅ No namespace changes needed!');
  }
  
  console.log('\n⚠️  Note: Some using statements may need manual adjustment');
  console.log('   if you have complex cross-feature dependencies.');
}

main();