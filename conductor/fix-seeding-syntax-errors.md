# Plan: Fix Syntax Errors in Data Seeding Files

Correct property name inconsistencies in the book data seeding files to match the `Word` and `Phrase` class definitions in `SeedClasses.cs`.

## Objective
Standardize property names in `backend/src/Koine.Infrastructure/Data/Seed/*.cs` to ensure the application compiles and seeds data correctly.

## Key Files & Context
- `backend/src/Koine.Infrastructure/Data/Seed/SeedClasses.cs`: Defines the target structure.
    - `Word` class properties: `GrammarCodes`, `PartOfSpeech`.
- Various book data files using incorrect property names:
    - `Grammar_codes`
    - `Grammar_Codes`
    - `Part_of_speech`

## Implementation Steps

### 1. Fix `GrammarCodes` property names
Across the following files, replace all occurrences of `Grammar_codes` and `Grammar_Codes` with `GrammarCodes`:
- `backend/src/Koine.Infrastructure/Data/Seed/ActsTextData.cs`
- `backend/src/Koine.Infrastructure/Data/Seed/FirstCorinthiansTextData.cs`
- `backend/src/Koine.Infrastructure/Data/Seed/JohnTextData.cs`
- `backend/src/Koine.Infrastructure/Data/Seed/LukeTextData.cs`
- `backend/src/Koine.Infrastructure/Data/Seed/MarkTextData.cs`
- `backend/src/Koine.Infrastructure/Data/Seed/MatthewTextData.cs`
- `backend/src/Koine.Infrastructure/Data/Seed/RomansTextData.cs`

### 2. Fix `PartOfSpeech` property names
In the following file, replace all occurrences of `Part_of_speech` with `PartOfSpeech`:
- `backend/src/Koine.Infrastructure/Data/Seed/RomansTextData.cs`

## Verification & Testing
1. **Compile the Backend:** Run `dotnet build` in the `backend/` directory to ensure all syntax errors are resolved.
2. **Verify Seeding (Optional):** If possible, run the seeding process to ensure data is correctly mapped to the database.
3. **Verify via Grep:** Run `grep -rE "Grammar_codes|Grammar_Codes|Part_of_speech" backend/src/Koine.Infrastructure/Data/Seed/` to confirm no remaining matches (excluding `GrammaticalFeaturesData.cs` string values).
