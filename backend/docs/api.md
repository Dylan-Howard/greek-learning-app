# API Endpoints Specification

## Authentication
Method | Endpoint | Description | Auth RequiredPOST/auth/loginUser loginNoPOST/auth/registerUser registrationNoGET/auth/meGet current userYes

## Reader
Method | Endpoint | Description | Auth RequiredGET/readerGet rendered chapterYes

## Books
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/booksList all booksNoNoGET/books/{id}Get book by IDNoNoPOST/booksCreate new bookYesYesPUT/books/{id}Update bookYesYesDELETE/books/{id}Delete bookYesYes

## Chapters
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/books/{bookId}/chaptersList chapters in bookNoNoGET/chapters/{id}Get chapter by IDNoNoPOST/books/{bookId}/chaptersCreate chapterYesYesPUT/chapters/{id}Update chapterYesYesDELETE/chapters/{id}Delete chapterYesYes

## Grammatical Features
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/grammatical-featuresList all featuresNoNoGET/grammatical-features/{id}Get feature by IDNoNoGET/grammatical-features/code/{code}Get feature by codeNoNoPOST/grammatical-featuresCreate featureYesYesPUT/grammatical-features/{id}Update featureYesYesDELETE/grammatical-features/{id}Delete featureYesYes

## Syntactical Features
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/syntactical-featuresList all featuresNoNoGET/syntactical-features/{id}Get feature by IDNoNoGET/syntactical-features/code/{code}Get feature by codeNoNoPOST/syntactical-featuresCreate featureYesYesPUT/syntactical-features/{id}Update featureYesYesDELETE/syntactical-features/{id}Delete featureYesYes

## Vocabulary
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/vocabularyList vocabulary (paginated)NoNoGET/vocabulary/{id}Get vocabulary by IDNoNoGET/vocabulary/searchSearch vocabularyNoNoPOST/vocabularyCreate vocabulary entryYesYesPUT/vocabulary/{id}Update vocabularyYesYesDELETE/vocabulary/{id}Delete vocabularyYesYes

## Translations
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/books/{bookId}/translationsList translations for bookNoNoGET/translations/{id}Get translation by IDNoNoPOST/books/{bookId}/translationsCreate translationYesYesPUT/translations/{id}Update translationYesYesDELETE/translations/{id}Delete translationYesYes

## Translation Units
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/translations/{translationId}/unitsList translation unitsNoNoGET/translation-units/{id}Get unit by IDNoNoPOST/translations/{translationId}/unitsCreate translation unitYesYesPOST/translations/{translationId}/units/batchBatch create unitsYesYesPUT/translation-units/{id}Update translation unitYesYesDELETE/translation-units/{id}Delete translation unitYesYes

## Lessons
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/lessonsList all lessonsYesNoGET/lessons/{id}Get lesson by IDYesNoPOST/lessons/{id}/completeComplete a lessonYesNoPOST/lessonsCreate lessonYesYesPUT/lessons/{id}Update lessonYesYesDELETE/lessons/{id}Delete lessonYesYes

## User Progress
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/progressGet current user's progressYesNoPUT/progressUpdate user progressYesNoGET/users/{userId}/progressGet user progress (admin)YesYes

## Users (Admin)
Method | Endpoint | Description | Auth RequiredAdmin OnlyGET/admin/usersList all usersYesYesGET/admin/users/{id}Get user by IDYesYesPUT/admin/users/{id}Update userYesYesDELETE/admin/users/{id}Delete userYesYes