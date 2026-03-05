using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koine.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigrateVocabularyProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
INSERT INTO UserCardProgress
  (UserId, VocabularyId, Stability, Difficulty, ReviewCount,
   LastReviewDate, NextReviewDate, State, ElapsedDays, ScheduledDays, Lapses)
SELECT
  up.UserId,
  CAST(j.[key] AS int) AS VocabularyId,
  CAST(JSON_VALUE(j.[value], '$.MasteryLevel') AS float) AS Stability,
  5.0 AS Difficulty,
  CAST(JSON_VALUE(j.[value], '$.TimesSeen') AS int) AS ReviewCount,
  CAST(JSON_VALUE(j.[value], '$.LastPracticed') AS datetime2) AS LastReviewDate,
  CASE
    WHEN JSON_VALUE(j.[value], '$.NeedsPractice') = 'true' THEN GETUTCDATE()
    ELSE DATEADD(day, CAST(JSON_VALUE(j.[value], '$.MasteryLevel') AS int), CAST(JSON_VALUE(j.[value], '$.LastPracticed') AS datetime2))
  END AS NextReviewDate,
  CASE
    WHEN CAST(JSON_VALUE(j.[value], '$.TimesSeen') AS int) = 0 THEN 0 ELSE 2 END AS State,
  0, 0, 0
FROM UserProgresses up
CROSS APPLY OPENJSON(up.VocabularyProgressJson) AS j
WHERE NOT EXISTS (
  SELECT 1 FROM UserCardProgress ucp
  WHERE ucp.UserId = up.UserId AND ucp.VocabularyId = CAST(j.[key] AS int)
);";

            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM UserCardProgress WHERE UserId = 1;");
        }
    }
}
